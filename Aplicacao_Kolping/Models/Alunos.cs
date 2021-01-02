using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao_Kolping.Models
{
    public class Alunos
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} Campo Obrigatório")]
        [Display(Name = "Nome *")]
        public string Nome { get; set; }
        public string Documento { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} Campo Obrigatório")]
        [Display(Name = "Data de Nascimento *")]
        public DateTime Nascimento { get; set; }
        public int Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        [Display(Name = "Dia de Pagamento *")]
        [Required(ErrorMessage = "{0} Campo Obrigatório")]
        public int DiadePagamento { get; set; }
        public ICollection<Modalidades> Modalidades { get; set; } = new List<Modalidades>();
        public ICollection<Pagamentos> Pagamentos { get; set; } = new List<Pagamentos>();

        public Alunos()
        {
        }

        public Alunos(int iD, string nome, string documento, DateTime nascimento, int telefone, string email, string rua, string numero, string bairro, string cidade, string cep, int diaDePagamaneto)
        {
            ID = iD;
            Nome = nome;
            Documento = documento;
            Nascimento = nascimento;
            Telefone = telefone;
            Email = email;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
            DiadePagamento = diaDePagamaneto;
        }

        public void AddPagamento(Pagamentos pg)
        {
            Pagamentos.Add(pg);
        }
        public void RemovePagamento(Pagamentos pg)
        {
            Pagamentos.Remove(pg);
        }
        public double TotalPagamentos(DateTime initial, DateTime final)
        {
            return Pagamentos.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Valor);
        }
        public void AddModalidade(Modalidades md)
        {
            Modalidades.Add(md);
        }
        public void removeModalidade(Modalidades md)
        {
            Modalidades.Remove(md);
        }
    }
}
