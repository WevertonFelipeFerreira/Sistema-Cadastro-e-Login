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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void checkBoxExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxExibeSenha.Checked)
            {
                TextBoxCadastroSenha.UseSystemPasswordChar = false;
                TextBoxConfirmaSenha.UseSystemPasswordChar = false;
            }
            else 
            {
                TextBoxCadastroSenha.UseSystemPasswordChar = true;
                TextBoxConfirmaSenha.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         bool login =  VerificaCaixa(TextBoxCadastroLogin.Text, "Login");
         bool senha =  VerificaCaixa(TextBoxCadastroSenha.Text, "Senha");
         bool confirma =  VerificaCaixa(TextBoxConfirmaSenha.Text, "Confirma Senha");
         bool nome =  VerificaCaixa(TextBoxNome.Text, "Nome");
         bool idade =  VerificaCaixa(TextBoxIdade.Text, "Idade");
         bool cpf =  VerificaCaixa(TextBoxCPF.Text, "CPF");
         bool cep =  VerificaCaixa(TextBoxCEP.Text, "CEP");
         bool endereco =  VerificaCaixa(TextBoxEndereco.Text, "Endereço");
         bool cidade =  VerificaCaixa(TextBoxCidade.Text, "Cidade");
         bool estado =  VerificaCaixa(TextBoxEstado.Text, "Estado");
            if (login == true && senha == true && confirma == true && nome == true
                && idade == true && cpf == true && cep == true && endereco == true &&
                cidade == true && estado == true)
            {
                if (TextBoxCadastroSenha.Text.Length < 8) 
                {
                    MessageBox.Show("A senha deve conter mais que 8 digitos.","AVISO!");
                    return;
                }
                if (TextBoxConfirmaSenha.Text != TextBoxCadastroSenha.Text) 
                {
                    MessageBox.Show("As senhas não conferem!");
                    return;
                }
                try
                {
                    int idadeFormatado = int.Parse(TextBoxIdade.Text);
                    int cepFormatado = int.Parse(TextBoxCEP.Text);
                    CadastroLogin.RegistrarUsuario(TextBoxCadastroLogin.Text, TextBoxCadastroSenha.Text, TextBoxNome.Text, idadeFormatado, TextBoxCPF.Text,
                       cepFormatado, TextBoxEndereco.Text, TextBoxCidade.Text, TextBoxEstado.Text);
                    MessageBox.Show("Usuário registrado!");
                    this.Close();
                }
                catch (FormatException) 
                {
                    MessageBox.Show("Os campos Idade e CEP devem ser somente números.","AVISO");
                    return;
                }
            }
            else return;
        }
        private bool VerificaCaixa(string nomeCaixa, string Campo) 
        {
            if (nomeCaixa == "") 
            {
                MessageBox.Show($"O Campo de {Campo} deve ser preenchido!", "AVISO");
                return false;
            }
            return true;
        }
    }
}
