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
        public string NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Cep { get; set; }
        public ICollection<Modalidades> Modalidades { get; set; } = new List<Modalidades>();
        public ICollection<Pagamentos> Pagamentos { get; set; } = new List<Pagamentos>();

        public Alunos()
        {
        }

        public Alunos(int iD, string nome, string documento, DateTime nascimento, int telefone, string email, string rua, string numeroCasa, string bairro, string cidade, int cep)
        {
            ID = iD;
            Nome = nome;
            Documento = documento;
            Nascimento = nascimento;
            Telefone = telefone;
            Email = email;
            Rua = rua;
            NumeroCasa = numeroCasa;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
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
