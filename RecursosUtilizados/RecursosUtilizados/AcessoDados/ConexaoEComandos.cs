using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosUtilizados.AcessoDados
{
    public static class ConexaoEComandos
    {
        private static SqlConnection conexao = null;

        private static SqlConnection GetSqlConnection()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection(stringConexao);
                conexao.Open();
            }

            return conexao;
        }

        public static SqlCommand CreateCommand(string comandoSQL)
        {
            return new SqlCommand(comandoSQL, GetSqlConnection());
        }
    }
}
