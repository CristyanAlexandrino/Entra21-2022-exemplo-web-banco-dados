using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using System.Linq;


namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio
{
    public class RacaRepositorio : IRacaRepositorio
    {
        // Essa linha aqui que permite fazer as coisas tudo no banco de forma mais simples
        private readonly ClinicaVeterinariaContexto _contexto;

        public RacaRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Apagar(int id)
        {
            var raca = _contexto.Racas.Where(x => x.Id == id).FirstOrDefault();

            _contexto.Racas.Remove(raca);
        }

        public void Atualizar(Raca racaParaAlterar)
        {
            var raca = _contexto.Racas
                .Where(x => x.Id == racaParaAlterar.Id).FirstOrDefault();

            raca.Nome = racaParaAlterar.Nome;
            raca.Especie = racaParaAlterar.Especie;
<<<<<<< HEAD
=======

            _contexto.Update(raca);
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
        }

        public void Cadastrar(Raca raca)
        {
            // INSERT NA TABELA DE RAÇAS
            _contexto.Racas.Add(raca);
            _contexto.SaveChanges();
        }

        public Raca ObterPorId(int id)
        {
            var raca = _contexto.Racas.Where(x => x.Id == id).FirstOrDefault();
<<<<<<< HEAD
=======

>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
            return raca;
        }

        public List<Raca> ObterTodos()
        {
<<<<<<< HEAD
            return _contexto.Racas.ToList();
=======
            // Buscar todos os registros de raças
            // SELECT * FROM racas
            var racas = _contexto.Racas.ToList();

            return racas;
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
        }
    }
}
