using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GraficaRepository : Data
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable()
        {
            try {
                Abrir();
                Command = GetCommand("select id,nombre from grafica", CommandType.Text);
                return GetTableCommand(Command);
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

        public override void Save(Dictionary<string, double> colection)
        {
            throw new NotImplementedException();
        }
    }
}
