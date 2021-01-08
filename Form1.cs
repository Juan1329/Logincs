using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {//conetando com o banco--- 
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=meubanco;Data Source=.\SQLEXPRESS");
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {   
            //abrindo a conexao
             conexao.Open();
            //verificando a informacao no banco
            String query = "select * from usuario where username = '" + txtLogin.Text + "'and password = '" + txtSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            //aqui instanciando uma tabela de dados para alocar a tabela que veio do banco 
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                FormInicio form = new FormInicio();
                this.Hide();
                form.Show();
                conexao.Close();
            }
            else
            {
                //exibindo mensagem de erro
                MessageBox.Show("Usuario ou senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //assim que a mensagem box aparecer a instrução abaixo é para limpar os campos
                txtLogin.Text = "";
                txtSenha.Text = "";
                //deixar o cursor piscando na caixa de texto
                txtLogin.Select();
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {   //chamar a tela cadastro
            FormCadastro cad = new FormCadastro();
            cad.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
