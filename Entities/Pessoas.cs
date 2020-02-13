using System;
using System.Collections.Generic;
using System.Text;

namespace SkyOneConsole.Entities
{

    /* 1 - Crie as classes contendo as seguintes informações

Pessoas
Codigo: numérico
Nome: texto
DataNascimento: data
Genero: {masculino, feminino, outros}*/
    public class Pessoas
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public GeneroPessoa Genero { get; set; }

    }

    public enum GeneroPessoa
    {
        Masculino, Feminino, Outros
    }
}


