using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aplicacao_Kolping.Models
{
    public class Modalidades
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Preco { get; set; }
        public ICollection<Alunos> Alunos { get; set; } = new List<Alunos>();

        public Modalidades()
        {
        }

        public Modalidades(int iD, string name, double preco)
        {
            ID = iD;
            Name = name;
            Preco = preco;
        }

        public void AddAluno(Alunos Aluno)
        {
            Alunos.Add(Aluno);
        }
        public void RemoveAluno(Alunos Aluno)
        {
            Alunos.Remove(Aluno);
        }
    }


}
