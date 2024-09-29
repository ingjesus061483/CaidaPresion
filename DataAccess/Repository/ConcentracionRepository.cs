using System.Data;
namespace DataAccess.Repository
{
    public class ConcentracionRepository : Data
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable()
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable(int id)
        {
            try
            {
                Abrir();
                Command = GetCommand("select concentracion_id,concentracion from view_espumante_concentracion where espumante_id=" + id, CommandType.Text);
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

        public override void Save(Dictionary<string, double> colection)
        {
            throw new NotImplementedException();
        }
    }
}
