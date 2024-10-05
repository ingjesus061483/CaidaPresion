using System.Data;
namespace DataAccess.Repository
{
    public class EspumanteRepository : Data
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable()
        {
            try
            {
                Abrir();
                Command = GetCommand("select * from espumante", CommandType.Text);
                DataTable table = GetTableCommand(Command);
                return table;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cerrar();
            }
        }

        public override DataTable GetDataTable(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save(Dictionary<string, double> colection, ref int id)
        {
            throw new NotImplementedException();
        }
    }
}
