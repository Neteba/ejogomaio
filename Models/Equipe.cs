using System;
using System.Collections.Generic;
using System.IO;
using WebApplication___Ocean.Interface;

namespace WebApplication___Ocean.Models
{

    //Herança 

    


    public class Equipe : EquipeBase, IEquipe
    {

        public int idEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }

        public const string caminho = "Database/equipe.csv";

        public Equipe()
        {

            CriarPastaouArquivo(caminho);



        }

        private void CriarPastaouArquivo(object caminho)
        {
            throw new NotImplementedException();
        }

        string Preparar(Equipe e)
        {


            //return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;

            //ou

            return $"{ e.idEquipe}; {e.Nome}; {e.Imagem}";

        }

        public void Criar(Equipe novaequipe)


        {
            string valor = Preparar(novaequipe);

            string[] equipe_texto = { valor };


            File.AppendAllLines(caminhobd, equipe_texto);


        }

        public List<Equipe> LerEquipes()
        {

            List<Equipe> listaEquipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {

                string[]

            }

        }
    }
}
