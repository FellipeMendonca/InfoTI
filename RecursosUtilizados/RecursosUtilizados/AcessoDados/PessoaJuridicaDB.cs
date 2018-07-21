using RecursosUtilizados.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosUtilizados.AcessoDados
{
    public class PessoaJuridicaDB
    {
        public static List<PessoaJuridica> GetPessoaJuridicas()
        {
            List<PessoaJuridica> pessoasJuridicas = new List<PessoaJuridica>();
            SqlDataReader leitor = null;
            SqlCommand comandoLeitura = null;
            try
            {
                comandoLeitura = ConexaoEComandos.CreateCommand("SELECT * FROM PessoaJuridica");
                leitor = comandoLeitura.ExecuteReader();

                while (leitor.Read())
                {
                    pessoasJuridicas.Add(new PessoaJuridica()
                    {
                        Id = leitor.GetInt32(0),
                        Nome = leitor.GetString(1),
                        Email = leitor.GetString(2),
                        CNPJ = leitor.GetString(3)
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

            return pessoasJuridicas;
        }

    }
}
