﻿using System;
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
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public string Documento { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} Campo Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; set; }
        [DisplayFormat(DataFormatString = "{0:## ##### ####}")]
        public long Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        [Display(Name = "Dia de Pagamento")]
        [Required(ErrorMessage = "{0} Campo Obrigatório")]
        public int DiadePagamento { get; set; }
        public IList<AlunosModalidades> Modalidades { get; set; } = new List<AlunosModalidades>();
        public IList<Pagamentos> Pagamentos { get; set; } = new List<Pagamentos>();

        public Alunos()
        {
        }

        public Alunos(int iD, string nome, string documento, DateTime nascimento, int telefone, string email, string rua, string numero, string bairro, string cidade, string cep, int diadePagamento, bool jan, bool fev, bool mar, bool abr, bool mai, bool jun, bool jul, bool ago, bool set, bool @out, bool nov, bool dez)
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
            DiadePagamento = diadePagamento;
        }

        public void AddModalidade(Modalidades md)
        {
            Modalidades.Add(new AlunosModalidades { AlunoID = ID, ModalidadeID = md.ID, Modalidade = md});
        }
        public void removeModalidade(Modalidades md)
        {
            var modalidade = Modalidades.FirstOrDefault(m => m.ModalidadeID == md.ID);
            if (modalidade != null)
            {
                Modalidades.Remove(modalidade);
            }
        }        
    }
}
