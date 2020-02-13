using System;
using System.Collections.Generic;
using System.Text;

namespace SkyOneConsole.Entities
{

    /*
Pets:
Codigo: numérico
CodigoDono: númerico
Nome: texto
DataNascimento: data
tipo: {cachorro, gato, papagaio, outros} */
    public class Pets
    {

        public int Codigo { get; set; }
        public int CodigoDono { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public TipoAnimais Tipo { get; set; }

        
        //public virtual Pessoas Pessoas { get; set; }


    }

    public enum TipoAnimais
    {
        Cachorro, gato, papagaio, outros
    }
}


