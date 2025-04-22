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
    public partial class SelectRecipeForm : Form
    {
        public int SelectedRecipeIndex { get; private set; } = -1;
        public SelectRecipeForm(List<Form1.Receita> receitasExistentes)
        {
            InitializeComponent();
            for (int i = 0; i < receitasExistentes.Count; i++)
            {
                if (!string.IsNullOrEmpty(receitasExistentes[i].nome))
                {
                    comboBoxReceitas.Items.Add(receitasExistentes[i].nome);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxReceitas.SelectedIndex >= 0)
            {
                SelectedRecipeIndex = comboBoxReceitas.SelectedIndex;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma receita para editar.");
            }
        }
    }
}
