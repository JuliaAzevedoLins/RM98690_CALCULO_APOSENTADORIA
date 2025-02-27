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
            // Verifica se os campos foram preenchidos
            if (string.IsNullOrEmpty(txtIdade.Text) || string.IsNullOrEmpty(txtAnosTrabalhados.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verifica se os valores de idade e anos trabalhados são números válidos
            if (!int.TryParse(txtIdade.Text, out int idade) || !int.TryParse(txtAnosTrabalhados.Text, out int anosTrabalhados))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para idade e anos trabalhados.");
                return;
            }

            // Verifica o gênero selecionado
            if (cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um gênero.");
                return;
            }

            string genero = cmbGenero.SelectedItem.ToString();

            // Regras do INSS
            int idadeMinimaHomem = 65;
            int idadeMinimaMulher = 62;
            int tempoContribuicaoMinimo = 15;
            int tempoContribuicaoHomem = 35;
            int tempoContribuicaoMulher = 30;

            // Verifica se a pessoa já pode se aposentar
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
                // Aplica as regras mais restritivas (homens) como padrão
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
            // Método vazio (pode ser removido se não for utilizado)
        }
    }
}