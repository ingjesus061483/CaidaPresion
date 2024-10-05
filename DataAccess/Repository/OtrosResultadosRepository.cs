using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OtrosResultadosRepository : Data
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
                Command = GetCommand("select id, PrimerTermino,ReynoldEnjambre,SegundoTermino,TercerTermino,FuncionObjetivo,DiametroBurbuja,resultado_id  from otros_resultados where resultado_id=" + id, CommandType.Text);
                DataTable dataTable = GetTableCommand(Command);
                return dataTable;

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

        public override void Save(Dictionary<string, double> colection ,ref int id)
        {
            try
            {
                Abrir();               
                double PrimerTermino = Math.Round(colection["PrimerTermino"], 15);
                double ReynoldEnjambre = Math.Round(colection["ReynoldEnjambre"], 15);
                double SegundoTermino = Math.Round(colection["SegundoTermino"], 15);
                double TercerTermino = Math.Round(colection["TercerTermino"], 15);
                double FuncionObjetivo = Math.Round(colection["FuncionObjetivo"], 15);
                double DiametroBurbuja = Math.Round(colection["DiametroBurbuja"], 15);
                Command = GetCommand("insertar_otros_resultados", CommandType.StoredProcedure);
                Command.Parameters.Add("_PrimerTermino", MySqlDbType.Decimal).Value = PrimerTermino;
                Command.Parameters.Add("_ReynoldEnjambre", MySqlDbType.Decimal).Value = ReynoldEnjambre;
                Command.Parameters.Add("_SegundoTermino", MySqlDbType.Decimal).Value = SegundoTermino;
                Command.Parameters.Add("_TercerTermino", MySqlDbType.Decimal).Value = TercerTermino;
                Command.Parameters.Add("_FuncionObjetivo", MySqlDbType.Decimal).Value = FuncionObjetivo;
                Command.Parameters.Add("_DiametroBurbuja", MySqlDbType.Decimal).Value = DiametroBurbuja;                
                Command.Parameters.Add("_resultado_id", MySqlDbType.Int32).Value = id;
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
    }
}
