using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Pedido
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();



        //Construitor

        public Conexao()
        {
            con.ConnectionStruing = @"Data Source=DESKTOP-IPTSMND\SQLEXPRESS;Initial Catalog=Denny;Integrated Security=True";
        }

        //Método para conectar

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;  
        }

        //Método para Desconectar

        public SqlConnection desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }

    }

    public class SqlConnection
    {
        public string ConnectionStruing { get; internal set; }
        public ConnectionState State { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
