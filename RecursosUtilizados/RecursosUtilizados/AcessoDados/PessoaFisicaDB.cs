using RecursosUtilizados.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosUtilizados.AcessoDados
{
    public class PessoaFisicaDB
    {
        public static List<PessoaFisica> GetPessoaFisicas()
        {
            List<PessoaFisica> pessoaFisicas = new List<PessoaFisica>();
            SqlDataReader leitor = null;
            SqlCommand comandoLeitura = null;
            try
            {
                comandoLeitura = ConexaoEComandos.CreateCommand("SELECT * FROM PessoaFisica");
                leitor = comandoLeitura.ExecuteReader();

                while (leitor.Read())
                {
                    pessoaFisicas.Add(new PessoaFisica()
                    {
                        Id = leitor.GetInt32(0),
                        Nome = leitor.GetString(1),
                        Email = leitor.GetString(2),
                        CPF = leitor.GetString(3)
                    });
                }

                leitor.Close();
                comandoLeitura.Dispose();
            }
            catch (Exception exception)
            {
                if (leitor != null)
                    leitor.Close();

                if (comandoLeitura != null)
                    comandoLeitura.Dispose();
            }

            return pessoaFisicas;
        }

    }
}
