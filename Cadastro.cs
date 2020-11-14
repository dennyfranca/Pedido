using System;
using System.Runtime.Serialization;
using System.Data.AddWithValue;


namespace Pedido
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Cadastro(String nome_produto, String valor, String data_vencimento)
        {
            //Comando Sql -- SqlCommand
            cmd.CommandText = "insert into CRUD (nome_produto, valor, data_vencimento) values (@nome_produto, @valor, @data_vencimento)";


            //Colocaremos os parametros

            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue( " @valor ", valor) ;
            cmd.Parameters.AddWithValue("@data_vencimento", data_vencimento);



            try
            {
                //conectar com banco de dados -- Conexao
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mostrar msg de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";

                
            }
            
           
            
        }

        private void Value(string v, string data_vencimento)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class SqlException : Exception
    {
        public SqlException()
        {
        }

        public AddWithValue()
        {

        }
        public SqlException(string message) : base(message)
        {
        }

        public SqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    internal class SqlCommand
    {
        public string CommandText { get; internal set; }
        public object Parameters { get; internal set; }
        public SqlConnection Connection { get; internal set; }
        public object Parameter { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}
