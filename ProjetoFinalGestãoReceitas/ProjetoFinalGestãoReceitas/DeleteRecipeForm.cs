using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGestãoReceitas
{
    public partial class DeleteRecipeForm : Form
    {
        public string ReceitaSelecionada { get; private set; }
        public DeleteRecipeForm(List<Form1.Receita> receitasExistentes)
        {
            InitializeComponent();
            foreach (var receita in receitasExistentes)
            {
                if (!string.IsNullOrEmpty(receita.nome))
                {
                    comboBoxListaReceitas.Items.Add(receita.nome);
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (comboBoxListaReceitas.SelectedItem != null)
            {
                ReceitaSelecionada = comboBoxListaReceitas.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma receita para excluir.");
            }

        }
    }
}
