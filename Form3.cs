using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class FormInicio : Form
    {
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=meubanco;Data Source=.\SQLEXPRESS");
        private object txtCadLogin;
        private object txtCadSenha;

        public FormInicio()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void btnCadUsu_Click(object sender, EventArgs e)
        {

            FormCadastro inicio = new FormCadastro();
            inicio.Show();
        }

        private void dgv1_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDados()
        {
            //dgvResultados.Rows.Clear();
            conexao.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dados = new SqlDataAdapter("select * from usuario", conexao);
            dados.Fill(dt);
            dgv1.DataSource = dt;
            conexao.Close();

        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            /* conexao.Open();
             DataTable dt = new DataTable();
             SqlDataAdapter dados = new SqlDataAdapter("select * from usuario", conexao);
             dados.Fill(dt);
             dgv1.DataSource = dt;
             conexao.Close();*/
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void btnApagar_Click_2(object sender, EventArgs e)
        {   //tratativa de exceção
            try
            {   //abrir conexao
                conexao.Open();
                //criando o comando para executar instrução sql
                SqlCommand cmdApagar = new SqlCommand("delete from usuario where id = @id", conexao);
                //adicionando o paramentro na(vai trocar do @ pelo o valor que precisa)
                cmdApagar.Parameters.AddWithValue("@id", dgv1.CurrentRow.Cells[0].FormattedValue);
                //executa o comando não query 
                cmdApagar.ExecuteNonQuery();

            }
            //caso corra não corra o try ele usa o catch 
            catch (Exception exp)
            {
                MessageBox.Show($"erro {exp.Message}");
            }
            finally
            {
                //fechar conexão
                conexao.Close();
                //metodo que carrega a grade
                CarregarDados();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conexao.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dados = new SqlDataAdapter($" select * from usuario where username like '{ textBox1.Text }%' ", conexao);
            dados.Fill(dt);
            dgv1.DataSource = dt;
            conexao.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnApagar_Click_1(object sender, EventArgs e)
        {
        }
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
