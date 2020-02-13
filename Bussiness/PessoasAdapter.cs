using SkyOneConsole.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkyOneConsole.Bussines
{
    class PessoasAdapter
    {
        List<Pessoas> listaPessoas = new List<Pessoas>();

        List<Pets> listaPets = new List<Pets>();
        public Tuple<string, string> RetornarPessoasMasculino()
        {

            var masculinoComPaPagaio = from pessoas in listaPessoas
                                       join pets in listaPets on new { X1 = pessoas.Codigo } equals new { X1 = pets.CodigoDono }
                                       where pessoas.Genero == GeneroPessoa.Masculino && pets.Tipo == TipoAnimais.papagaio && pets.DataNascimento == DateTime.Now.AddYears(-1)
                                       select pessoas;



            List<Pessoas> pessoasQueNaoPossuemPets = new List<Pessoas>();

            foreach (var pessoa1 in listaPessoas)
            {

                var consulta = listaPets.Where(x => x.CodigoDono == pessoa1.Codigo).FirstOrDefault();

                if (consulta == null)
                {
                    pessoasQueNaoPossuemPets.Add(pessoa1);
                }
            }


            return null;
            //var result = from x in PessoaCadastro
            //             join y in Pessoas on new { X1 = x.PessoaId } equals new { X1 = y.PessoaId }
            //             where x.PessoaTipo == 1
            //             select y;

        }

        /* 4 - Dado as classes criadas, retorna uma lista contendo o “nome da pessoa” e o “nome do pet” com os seguintes filtros
        a) pessoas do gênero masculino que tenham papagaio com um ano de vida
        b) Pessoas que não possuam pets
        c) Todos os pets com seus donos */
    }
}