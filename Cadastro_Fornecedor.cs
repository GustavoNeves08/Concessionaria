using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concessionaria
{
    public partial class Cadastro_Fornecedor : Form
    {
        Class_Fornecedor fornecedor = new Class_Fornecedor();
        public Cadastro_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adicionando dados na classe
            fornecedor.setId(int.Parse(txtId.Text));
            fornecedor.setData(mTBdata.Text);
            fornecedor.setProduto(txtProduto.Text);
            fornecedor.setTempo_cont(int.Parse(txtTempo.Text));
            fornecedor.setEndereco(txtEndereco.Text);
            fornecedor.setCEP(txtCEP.Text);
            fornecedor.setNome(txtNome.Text);
            fornecedor.setTelefone(int.Parse(txtTelefone.Text));
            fornecedor.setEmail(txtEmail.Text);
            fornecedor.setCNPJ(txtCNPJ.Text);


            //Conexao com o banco de dados
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=m2; password=''");
            MySqlCommand sqlQuery = new MySqlCommand($"INSERT INTO fornecedor VALUE ('{fornecedor.getId()}'," +
                                                                    $"'{fornecedor.getData()}'," +
                                                                    $"'{fornecedor.getProduto()}'," +
                                                                    $"'{fornecedor.getTempo_cont()}'," +
                                                                    $"'{fornecedor.getEndereco()}'," +
                                                                    $"'{fornecedor.getCEP()}'," +
                                                                    $"'{fornecedor.getNome()}'," +
                                                                    $"'{fornecedor.getTelefone()}'," +
                                                                    $"'{fornecedor.getEmail()}'," +
                                                                    $"'{fornecedor.getCNPJ()}') ", conexao);

            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();
                MessageBox.Show("Dados enviado com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR Atençao!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
