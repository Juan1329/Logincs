using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Login
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=meubanco;Data Source=.\SQLEXPRESS");
        private void btnCadSenha_Click(object sender, EventArgs e)
        {


            conexao.Open();
            //Adcionar a informacao no banco
            String query = "insert into usuario (username, password) values (@username, @password)";
            SqlCommand dp = new SqlCommand(query, conexao);
            //pegando o parametro do text e jogando no banco
            dp.Parameters.AddWithValue("@username", txtCadLogin.Text);
            dp.Parameters.AddWithValue("@password", txtCadSenha.Text);
            //executando a query que enviará para o banco
            dp.ExecuteNonQuery();
            //conexão fechada
            conexao.Close();
            MessageBox.Show("Cadastrado", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            /*txtCadLogin.Text = "";
            txtCadSenha.Text = "";
            txtCadLogin.Select();*/

        }

        private void btnCadSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
        }
    }
}
