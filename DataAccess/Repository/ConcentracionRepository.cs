using System.Data;
namespace DataAccess.Repository
{
    public class ConcentracionRepository : Data
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable()
        {
            try
            {
                Abrir();
                Command = GetCommand("select id,nombre from concentracion" , CommandType.Text);
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

        public override void Save(Dictionary<string, object> colection,ref int id)
        {
            try
            {
                Abrir();
                Command = GetCommand("insertar_espumante_concentracion", CommandType.StoredProcedure);
                Command.Parameters.Add("_espumante_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = int.Parse(colection["espumante_id"].ToString());
                Command.Parameters.Add("_concentracion_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = int.Parse(colection["concentracion_id"].ToString());
                Command.ExecuteNonQuery();
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

        public override void Update(Dictionary<string, object> colection, int id)
        {
            throw new NotImplementedException();
        }
    }
}
