﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Ocsp;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace DataAccess
{
    public abstract class Data
    {
        protected MySqlConnection Connection { get; set; }
        protected MySqlCommand? Command { get; set; }
        protected MySqlDataAdapter? DataAdapter { get; set; }
        public Data(string server = "127.0.0.1", string uid = " root", string pwd = "", string database = "caidapresion")
        {
            Connection = new MySqlConnection { ConnectionString = "server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=" + database };
        }
        protected void Abrir()
        {
            Connection.Open();
        }
        protected DataTable GetTableCommand(MySqlCommand command)
        {
            DataTable dt = new DataTable();
            DataAdapter = new MySqlDataAdapter { SelectCommand = Command };
            DataAdapter.Fill(dt);
            return dt;

        }

        protected MySqlCommand GetCommand(string sql, CommandType type)
        {
            MySqlCommand command = new MySqlCommand
            {
                Connection = Connection,
                CommandType = type,
                CommandText = sql
            };
            return command;

        }
        public abstract void Save(Dictionary<string, double> colection);
        public abstract DataTable GetDataTable();
        public abstract DataTable GetDataTable(int id);

        public abstract void Delete();
      
       protected  void Cerrar( )
        {
            Connection.Close();
        }
          }
}