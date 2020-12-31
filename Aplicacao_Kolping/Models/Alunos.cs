using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Kolping.Models
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime Nascimento { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public DateTime DiadePagamento { get; set; }
        public IList<Modalidades> Modalidades { get; set; } = new List<Modalidades>();
        public IList<Pagamentos> Pagamentos { get; set; } = new List<Pagamentos>();

        public Alunos()
        {
        }

        public Alunos(int iD, string nome, string documento, DateTime nascimento, int telefone, string email, string rua, string numero, string bairro, string cidade, string cep, DateTime diaDePagamaneto)
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
