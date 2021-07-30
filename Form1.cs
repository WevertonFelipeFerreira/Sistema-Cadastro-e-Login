using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeUsuario.Classes;

namespace CadastroDeUsuario
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
            CadastrarContaTest();
        }
        static int idContaLogada;
        public void CadastrarContaTest() 
        {
            string Login = "kangster";
            string Senha = "weverton99";
            string Nome = "Weverton Ferreira";
            int Idade = 22;
            string Cpf = "48677323899";
            int Cep = 13232524;
            string Endereco = "Rua flor de maio, 166";
            string Cidade = "Campo Limpo Paulista";
            string Estado = "São Paulo";

            CadastroLogin.RegistrarUsuario(Login, Senha, Nome, Idade, Cpf, Cep, Endereco, Cidade, Estado);
        }
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            string loginFornecido = TextBoxLogin.Text;
            string senhaFornecida = TextBoxSenha.Text;

            for (int i = 0; i < CadastroLogin.Contas.Count; i++)
            {
                if (CadastroLogin.Contas[i].Login == loginFornecido && CadastroLogin.Contas[i].Senha == senhaFornecida)
                {
                    idContaLogada = i;
                    BuildClient(i);
                    TextBoxLogin.Text = "";
                    TextBoxSenha.Text = "";
                    GroupBoxLogin.Enabled = false;
                    MessageBox.Show($"Usuario logado.\n Seja Bem-Vindo {CadastroLogin.Contas[idContaLogada].Nome}!","Saudações!");
                    break;
                }
                else MessageBox.Show("Login ou Senha incorreto!");
                break;
            }
        }

        public void BuildClient(int id) 
        {
            GroupBoxUsuario.Enabled = true;
            TextBoxNome.Text = CadastroLogin.Contas[id].Nome;
            TextBoxIdade.Text = Convert.ToString(CadastroLogin.Contas[id].Idade);
            TextBoxCPF.Text = CadastroLogin.Contas[id].Cpf;
            TextBoxCEP.Text = Convert.ToString(CadastroLogin.Contas[id].Cep);
            TextBoxEndereco.Text = CadastroLogin.Contas[id].Endereco;
            TextBoxCidade.Text = CadastroLogin.Contas[id].Cidade;
            TextBoxEstado.Text = CadastroLogin.Contas[id].Estado;
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
        }

        private void BtnCadastro_Click_1(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxSenha.Checked)
                {
                    TextBoxSenha.UseSystemPasswordChar = false;
                    TextBoxSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    TextBoxSenha.UseSystemPasswordChar = true;
                    TextBoxSenha.UseSystemPasswordChar = true;
                }
            }
        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void BtnLoggout_Click(object sender, EventArgs e)
        {
            GroupBoxLogin.Enabled = true;
            TextBoxNome.Text = "";
            TextBoxIdade.Text = "";
            TextBoxCPF.Text = "";
            TextBoxCEP.Text = "";
            TextBoxEndereco.Text = "";
            TextBoxCidade.Text = "";
            TextBoxEstado.Text = "";
            idContaLogada = 0;
            GroupBoxUsuario.Enabled = false;
            MessageBox.Show("Logout realizado com sucesso.");
        }
    }
}
