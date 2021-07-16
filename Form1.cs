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
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {

        }

        public void BuildClient() 
        {
 
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
    }
}
