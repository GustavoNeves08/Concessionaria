using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concessionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //#######################################
        //#                                     #
        //#       PARTE MATEUS GIMENES          #
        //#                                     #
        //#######################################

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de cadastro do Cliente
            Cadastro_Cliente cadcli = new Cadastro_Cliente();

            cadcli.MdiParent = this;
            cadcli.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de consulta do Cliente
            Form_consulta consult = new Form_consulta();

            consult.MdiParent = this;
            consult.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de atualizar do Cliente
            Form_Update update = new Form_Update();

            update.MdiParent = this;
            update.Show();
        }

        private void excluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // abre tela de excluir do Cliente
            Form_Delet delete = new Form_Delet();

            delete.MdiParent = this;
            delete.Show();
        }


        //#######################################
        //#                                     #
        //#       PARTE FELIPE ROCHA            #
        //#                                     #
        //#######################################

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de Cadastro de seu Carro
            Cadastro_Carro cadcar = new Cadastro_Carro();

            cadcar.MdiParent = this;
            cadcar.Show();
        }

        private void consultarSeusCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de consulta de seu Carro
            Consulta_Carro conscar = new Consulta_Carro();

            conscar.MdiParent = this;
            conscar.Show();
        }

        private void atualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de update de seu Carro
            Update_Carro uptcar = new Update_Carro();

            uptcar.MdiParent = this;
            uptcar.Show();
        }

        private void excluirUmCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de delete de seu Carro
            Delete_Carro delete = new Delete_Carro();

            delete.MdiParent = this;
            delete.Show();
        }

        //#######################################
        //#                                     #
        //#       PARTE GUSTAVO NEVES           #
        //#                                     #
        //#######################################

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // abre tela de Cadastro do fornecedor
            Cadastro_Fornecedor cadforn = new Cadastro_Fornecedor();

            cadforn.MdiParent = this;
            cadforn.Show();
        }

        private void consultarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de Cadastro do fornecedor
            Consulta_Fornecedor consulforn = new Consulta_Fornecedor();

            consulforn.MdiParent = this;
            consulforn.Show();
        }

        private void atualizarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de Update do fornecedor
            Update_Fornecedor updateforn = new Update_Fornecedor();

            updateforn.MdiParent = this;
            updateforn.Show();
        }

        private void excluirFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre tela de Update do fornecedor
            Delete_Fornecedor delforn = new Delete_Fornecedor();

            delforn.MdiParent = this;
            delforn.Show();
        }
    }
}
