using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace RM98690___LOGIN_E_INSS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "RM98690@fiap.com.br" && senha == "98690")
            {
                // Se o login for bem-sucedido, abre a segunda tela
                Aposentadoria aposentadoria = new Aposentadoria();
                aposentadoria.Show();
                this.Hide(); // Esconde a tela de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
