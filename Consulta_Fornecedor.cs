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
    public partial class Consulta_Fornecedor : Form
    {
        public Consulta_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpa o dataGrid
            dataGridView1.Rows.Clear();



            // Conexao com o banco de dados
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=m2; password=''");
            //Comando sql
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM fornecedor;", conexao);


            try
            {
                conexao.Open();
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();


                while (dataReader.Read())
                {
                    object[] registro = new object[dataReader.FieldCount];


                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));

                        }
                    }

                    // Busca o registro
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        registro[i] = dataReader.GetValue(i); //mostra o registro                  
                    }
                    dataGridView1.Rows.Add(registro); // Adiciona uma linha
                }
            }
            catch (Exception ex)
            {
                // caso tenha um erro
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}

