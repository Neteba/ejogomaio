using System.Collections.Generic;
using WebApplication___Ocean.Models;

namespace WebApplication___Ocean.Interface
{
    public interface IEquipe
    {

        //contrato
        //Representa os metodos que são obrigatorios em uma classe.

        void Criar(Equipe novaequipe); //este é o contrato

        List<Equipe>LerEquipes();



    }
}
