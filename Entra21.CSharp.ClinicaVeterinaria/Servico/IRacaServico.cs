using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    internal interface IRacaServico
    {
        void Cadastrar(string nome, string especie);
<<<<<<< HEAD

         List<Raca> ObterTodos();
=======
        List<Raca> ObterTodos();
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
        void Alterar(int id, string nome, string especie);
        void Apagar(int id);
        Raca ObterPorId(int id);

<<<<<<< HEAD
        
=======
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
    }

    
}
