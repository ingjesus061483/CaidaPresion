using MySql.Data.MySqlClient;
using System.Data;
namespace DataAccess.Repository
{
    public class ResultadoRepository : Data
    {
        public override void Delete()
        {

            try
            {
                Abrir();
                Command = GetCommand("delete from resultados", CommandType.Text);
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
        public override DataTable GetDataTable()
        {
            try
            {
                Abrir();
                Command = GetCommand("select id,Jg,DeltaP,Jsl,Holdup," +
                                   "Db,Ub,Reb,Usg,concentracion_id," +
                                   "concentracion,espumante_id,espumante " +
                                   "from view_resultados", CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
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

        public  DataTable GetDataTableEspumateConcentracion(int espumante,int concentracion)
        {
            try
            {
                Abrir();
                Command = GetCommand("select id,Jg,DeltaP,Jsl,Holdup," +
                                   "Db,Ub,Reb,Usg,concentracion_id," +
                                   "concentracion,espumante_id,espumante " +
                                   "from view_resultados where espumante_id="+espumante+" and " +
                                   "concentracion_id="+concentracion, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {
                Cerrar();
            }
        }


        public override void Save(Dictionary<string, double> colection, ref int id)
        {
            try
            {
                Abrir();
                double deltap = Math.Round( colection["deltap"],2);
                double jsl =Math.Round( colection["jsl"],2);
                double holdup =Math.Round( colection["holdup"],2);
                double db = Math.Round(colection["db"], 2);   
                double ub =Math.Round (colection["ub"],2);
                double reb =Math.Round( colection["reb"],2);
                double usg =Math.Round( colection["usg"],2);
                double jg =Math.Round( colection["jg"],2);
                int.TryParse( colection["concentracion_id"].ToString(),out int concentracion_id);
                int.TryParse(colection["espumante_id"].ToString(),out int espumante_id);                
                Command = GetCommand("Insertar_resultados", CommandType.StoredProcedure);
                Command.Parameters.Add("_deltap", MySqlDbType.Decimal).Value = deltap;
                Command.Parameters.Add("_jsl", MySqlDbType.Decimal).Value =jsl;
                Command.Parameters.Add("_holdup", MySqlDbType.Decimal).Value =holdup;
                Command.Parameters.Add("_db", MySqlDbType.Decimal).Value = db;
                Command.Parameters.Add("_ub", MySqlDbType.Decimal).Value = ub;
                Command.Parameters.Add("_reb", MySqlDbType.Decimal).Value = reb;
                Command.Parameters.Add("_usg", MySqlDbType.Decimal).Value = usg;
                Command.Parameters.Add("_jg", MySqlDbType.Decimal).Value =jg;
                Command.Parameters.Add("_concentracion_id", MySqlDbType.Int32).Value = concentracion_id ;
                Command.Parameters.Add("_espumante_id",MySqlDbType.Int32 ).Value = espumante_id ;
                Command.Parameters.Add("_id_resultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                Command.ExecuteNonQuery();
                int.TryParse(Command.Parameters["_id_resultado"].Value.ToString(), out id);
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
        public DataTable AirHoldupVsJg(int concentracion ,int espumante)
        {
            try
            {
                Abrir();
                Command = GetCommand("select holdup,jg from resultados where concentracion_id=" + concentracion + " and espumante_id=" + espumante , CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
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
        public DataTable UsgVsAirHoldup(int concentracion ,int espumante)
        {
            try
            {
                Abrir();                
                Command = GetCommand("select holdup,usg from resultados where concentracion_id="+concentracion+" and espumante_id="+espumante, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Cerrar();
            }
        }
        public DataTable DiámetroBurbujaVsJg( int concentracion ,int espumante )
        {
            try
            {
                Abrir();                
                Command = GetCommand("select db,jg from resultados where concentracion_id=" + concentracion + " and espumante_id=" + espumante, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
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
    }
}
