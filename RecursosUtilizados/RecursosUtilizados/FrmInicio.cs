using RecursosUtilizados.AcessoDados;
using RecursosUtilizados.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosUtilizados
{
    public partial class FrmInicio : Form
    {
        private List<PessoaFisica> pessoaFisicas;
        private List<PessoaJuridica> pessoaJuridicas;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CarregarGrid()
        {
            pessoaFisicas = PessoaFisicaDB.GetPessoaFisicas();
            pessoaJuridicas = PessoaJuridicaDB.GetPessoaJuridicas();

            dgvPessoasFisicas.DataSource = pessoaFisicas;
            dgvPessoasJuridicas.DataSource = pessoaJuridicas;

            // Selecionado apenas as pessoas
            var pessoas = (from p in pessoaFisicas select new { p.Nome, p.Email })
                            .Concat(from p in pessoaJuridicas select new { p.Nome, p.Email }).ToList();

            dgvPessoas.DataSource = pessoas;
        }

        private void dgvPessoasFisicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MostrarPessoa(pessoaFisicas[e.RowIndex]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvPessoasJuridicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MostrarPessoa(pessoaJuridicas[e.RowIndex]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa()
                {
                    Nome = dgvPessoas[0, e.RowIndex].Value.ToString(),
                    Email = dgvPessoas[1, e.RowIndex].Value.ToString()
                };
                MostrarPessoa(pessoa);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MostrarPessoa(object objeto)
        {
            if (objeto is PessoaFisica pessoaFisica)
            {
                MessageBox.Show(pessoaFisica.Nome + " - " + pessoaFisica.CPF, "Pessoa Física");
            }
            else if (objeto is PessoaJuridica pessoaJuridica)
            {
                MessageBox.Show(pessoaJuridica.Nome + " - " + pessoaJuridica.CNPJ, "Pessoa Jurídica");
            }
            else if (objeto is Pessoa pessoa)
            {
                MessageBox.Show(pessoa.Nome + " - " + pessoa.Email, "Pessoa Genérica");
            }
        }
    }
}
