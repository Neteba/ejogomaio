using System.IO;

namespace WebApplication___Ocean.Models
{
    public class EquipeBase
    {

        public void CriarPastaouArquivo(string caminho)
        {

            //nome da pasta / nomedoarquivo.csv

            string pasta = caminho.Split('/')[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);


            }


            if(!File.Exists(caminho))
            {

                File.Create(caminho).Close();

            }



        }



    }
}
