using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM98690___LOGIN_E_INSS
{
    public partial class Aposentadoria : Form
    {
        public Aposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIdade.Text) || string.IsNullOrEmpty(txtAnosTrabalhados.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!int.TryParse(txtIdade.Text, out int idade) || !int.TryParse(txtAnosTrabalhados.Text, out int anosTrabalhados))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para idade e anos trabalhados.");
                return;
            }


            if (cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um gênero.");
                return;
            }

            string genero = cmbGenero.SelectedItem.ToString();

            int idadeMinimaHomem = 65;
            int idadeMinimaMulher = 62;
            int tempoContribuicaoMinimo = 15;
            int tempoContribuicaoHomem = 35;
            int tempoContribuicaoMulher = 30;

            if (genero == "Masculino")
            {
                if (idade >= idadeMinimaHomem && anosTrabalhados >= tempoContribuicaoMinimo)
                {
                    lblResultado.Text = "Você já pode se aposentar por idade!";
                }
                else if (anosTrabalhados >= tempoContribuicaoHomem)
                {
                    lblResultado.Text = "Você já pode se aposentar por tempo de contribuição!";
                }
                else
                {
                    int anosFaltantesIdade = idadeMinimaHomem - idade;
                    int anosFaltantesContribuicao = tempoContribuicaoHomem - anosTrabalhados;
                    lblResultado.Text = $"Faltam {Math.Max(anosFaltantesIdade, anosFaltantesContribuicao)} anos para você se aposentar.";
                }
            }
            else if (genero == "Feminino")
            {
                if (idade >= idadeMinimaMulher && anosTrabalhados >= tempoContribuicaoMinimo)
                {
                    lblResultado.Text = "Você já pode se aposentar por idade!";
                }
                else if (anosTrabalhados >= tempoContribuicaoMulher)
                {
                    lblResultado.Text = "Você já pode se aposentar por tempo de contribuição!";
                }
                else
                {
                    int anosFaltantesIdade = idadeMinimaMulher - idade;
                    int anosFaltantesContribuicao = tempoContribuicaoMulher - anosTrabalhados;
                    lblResultado.Text = $"Faltam {Math.Max(anosFaltantesIdade, anosFaltantesContribuicao)} anos para você se aposentar.";
                }
            }
            else if (genero == "Outro")
            {

                if (idade >= idadeMinimaHomem && anosTrabalhados >= tempoContribuicaoMinimo)
                {
                    lblResultado.Text = "Você já pode se aposentar por idade! (Cálculo baseado nas regras mais restritivas)";
                }
                else if (anosTrabalhados >= tempoContribuicaoHomem)
                {
                    lblResultado.Text = "Você já pode se aposentar por tempo de contribuição! (Cálculo baseado nas regras mais restritivas)";
                }
                else
                {
                    int anosFaltantesIdade = idadeMinimaHomem - idade;
                    int anosFaltantesContribuicao = tempoContribuicaoHomem - anosTrabalhados;
                    lblResultado.Text = $"Faltam {Math.Max(anosFaltantesIdade, anosFaltantesContribuicao)} anos para você se aposentar. (Cálculo baseado nas regras mais restritivas)";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
