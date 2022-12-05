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
    public partial class Update_Fornecedor : Form
    {
        public Update_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Atualizar           
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=m2; password=''"); // Conexão - Server: porta / DB
            MySqlCommand sqlQuery = new MySqlCommand("UPDATE fornecedor SET data_ = '" + mTBdata.Text +
                                                     "', produto = '" + txtProduto.Text +
                                                     "', tempo_cont = '" + int.Parse(txtTempo.Text) +
                                                       "', endereco = '" + txtEndereco.Text +
                                                         "', CEP = '" + txtCEP.Text +
                                                           "', nome = '" + txtNome.Text +
                                                             "', telefone = '" + int.Parse(txtTelefone.Text) +
                                                               "', email = '" + txtEmail.Text +
                                                                 "', CNPJ = '" + txtCNPJ.Text +
                                                     "' WHERE id = " + int.Parse(txtId.Text), conexao); // Instr. SQL



            conexao.Open(); // Abrir Conexão

            var resp = MessageBox.Show("Identificador: " + "\n\nDeseja realmente alterar ? ", "Alterar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                sqlQuery.ExecuteNonQuery(); // Executa a instrução SQL; 
                MessageBox.Show("Dados alterados!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }
    }
}
