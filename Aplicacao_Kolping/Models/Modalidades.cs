﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Aplicacao_Kolping.Models
{
    public class Modalidades
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double Preco { get; set; }

        public Modalidades()
        {
        }

        public Modalidades(int iD, string name, double preco)
        {
            Id = iD;
            Name = name;
            Preco = preco;
        }

    }


}
