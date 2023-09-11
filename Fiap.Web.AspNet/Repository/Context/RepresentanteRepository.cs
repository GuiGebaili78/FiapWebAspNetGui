using Fiap.Web.AspNet.Models;

namespace Fiap.Web.AspNet.Repository.Context
{
    public class RepresentanteRepository
    {

        private readonly DataBaseContext dataBaseContext;

        public RepresentanteRepository(DataBaseContext ctx)
        {
            dataBaseContext = ctx;
        }



        public IList<RepresentanteModel> Listar()
        {
            var lista = new List<RepresentanteModel>();

            // Efetuando a listagem (Substituindo o Select *)
            lista = dataBaseContext.Representante.ToList();

            return lista;
        }

        public RepresentanteModel Consultar(int id)
        {
            // Recuperando o objeto Representante de um determinado Id
            var representante = dataBaseContext.Representante.Find(id);

            return representante;
        }

        public void Inserir(RepresentanteModel representante)
        {
            // Adiciona o objeto preenchido pelo usuário
            dataBaseContext.Representante.Add(representante);

            // Salva as alterações
            dataBaseContext.SaveChanges();

        }

        public void Alterar(RepresentanteModel representante)
        {
            dataBaseContext.Representante.Update(representante);

            // Salva as alterações
            dataBaseContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var representante = new RepresentanteModel(id, "");

            dataBaseContext.Representante.Remove(representante);

            // Salva as alterações
            dataBaseContext.SaveChanges();

        }


    }
}