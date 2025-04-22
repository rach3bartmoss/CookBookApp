using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace ProjetoFinalGestãoReceitas
{
    public partial class Form1 : Form
    {
        public struct Receita
        {
            public  string  nome;
            public int      tempoDePrep;
            public int      pessoas;
            public string   modoDePrep;
            public string   categoria;
            public string   nivel;

            public List<Ingredientes> IngredientesLocalList;

            /*public  Receita()
            {
                nome = string.Empty;
                tempoDePrep = 0;
                pessoas = 0;
                modoDePrep = string.Empty;
                categoria = string.Empty;
                nivel = string.Empty;
                IngredientesLocalList = new List<Ingredientes>();
            }*/
        }

        public struct Ingredientes
        {
            public string   ingrediente;
            public int      quantidade;
            public string   medida;
        }

        List<Receita> receitas = new List<Receita>();

        List<Ingredientes> tempIngredientesList = new List<Ingredientes>();

        private const string recipeDirectory = "../../Receitas";

        int currentEditingRecipeIndex = -1;

        int index;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            InitializeComboBoxes();

            comboBoxFilterType.SelectedIndexChanged += comboBoxFilterType_SelectedIndexChanged;
        }

        private void buttonAdd_ingredients_Click(object sender, EventArgs e)
        {
            Ingredientes novoIngrediente = new Ingredientes();
            novoIngrediente.ingrediente = textBoxIngrediente.Text;

            if (!int.TryParse(textBoxQuantidade.Text, out int quant))
            {
                MessageBox.Show("Informe um valor numérico válido para a quantidade");
                return;
            }
            novoIngrediente.quantidade = quant;

            if (comboBoxMedida.SelectedItem != null)
            {
                novoIngrediente.medida = comboBoxMedida.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma medida para o ingrediente!");
                return;
            }

            tempIngredientesList.Add(novoIngrediente);

            dataGridView1.Rows.Add(novoIngrediente.ingrediente, novoIngrediente.quantidade, novoIngrediente.medida);

            textBoxIngrediente.Clear();
            textBoxQuantidade.Clear();
            comboBoxMedida.SelectedIndex = -1;
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            Receita receitaAtual = new Receita
            {
                IngredientesLocalList = new List<Ingredientes>()
            };

            if (string.IsNullOrWhiteSpace(textBox_NomeReceita.Text))
            {
                MessageBox.Show("O nome da receita não pode estar vazio.");
                return;
            }
            receitaAtual.nome = textBox_NomeReceita.Text;
            if (!int.TryParse(textBox_tempoPreparo.Text, out int tempoDePrep) || tempoDePrep <= 0)
            {
                MessageBox.Show("O tempo de preparo deve ser um número inteiro positivo.");
                return;
            }
            receitaAtual.tempoDePrep = Convert.ToInt32(textBox_tempoPreparo.Text);
            if (!int.TryParse(textBoxNPessoas.Text, out int pessoas) || pessoas <= 0)
            {
                MessageBox.Show("O número de pessoas deve ser um número inteiro positivo.");
                return;
            }
            receitaAtual.pessoas = Convert.ToInt32(textBoxNPessoas.Text);
            if (string.IsNullOrWhiteSpace(textBoxModoPreparo.Text))
            {
                MessageBox.Show("O modo de preparo não pode estar vazio.");
                return;
            }
            receitaAtual.modoDePrep = textBoxModoPreparo.Text;
            if (comboBoxCat.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma categoria para a receita.");
                return;
            }
            receitaAtual.categoria = comboBoxCat.SelectedItem.ToString();
            if (comboBoxNivel.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um nível de dificuldade para a receita.");
                return;
            }
            receitaAtual.nivel = comboBoxNivel.SelectedItem.ToString();
            if (tempIngredientesList.Count == 0)
            {
                MessageBox.Show("A receita deve conter pelo menos um ingrediente.");
                return;
            }
            receitaAtual.IngredientesLocalList = new List<Ingredientes>(tempIngredientesList);

            if (currentEditingRecipeIndex >= 0)
            {
                receitas[currentEditingRecipeIndex] = receitaAtual;
                MessageBox.Show("Receita atualizada com sucesso!");
                currentEditingRecipeIndex = -1;
            }
            else
            {
                receitas.Add(receitaAtual);
                MessageBox.Show("Receita salva com sucesso!");
            }

            SaveRecipeToFile(receitaAtual);

            tempIngredientesList.Clear();

            textBox_NomeReceita.Clear();
            textBox_tempoPreparo.Clear();
            textBoxNPessoas.Clear();
            textBoxModoPreparo.Clear();
            comboBoxCat.SelectedIndex = -1;
            comboBoxNivel.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            DeleteRecipeForm formExclusao = new DeleteRecipeForm(receitas);

            if (formExclusao.ShowDialog() == DialogResult.OK)
            {
                string receitaParaExcluir = formExclusao.ReceitaSelecionada;

                var receitaEncontrada = receitas.FirstOrDefault(r => r.nome == receitaParaExcluir);
                if (!string.IsNullOrEmpty(receitaEncontrada.nome))
                {
                    receitas.Remove(receitaEncontrada);
                    DeleteRecipeFile(receitaParaExcluir);
                    MessageBox.Show("Receita Removida com sucesso!");
                }
            }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            SelectRecipeForm formSelect = new SelectRecipeForm(receitas);
            if (formSelect.ShowDialog() == DialogResult.OK)
            {
                currentEditingRecipeIndex = formSelect.SelectedRecipeIndex;

                var receitaEdit = receitas[currentEditingRecipeIndex];

                textBox_NomeReceita.Text = receitaEdit.nome;
                textBox_tempoPreparo.Text = receitaEdit.tempoDePrep.ToString();
                textBoxNPessoas.Text = receitaEdit.pessoas.ToString();
                textBoxModoPreparo.Text = receitaEdit.modoDePrep;
                comboBoxCat.SelectedItem = receitaEdit.categoria;
                comboBoxNivel.SelectedItem = receitaEdit.nivel;

                dataGridView1.Rows.Clear();

                if (receitaEdit.IngredientesLocalList == null)
                {
                    receitaEdit.IngredientesLocalList = new List<Ingredientes>();
                }
                tempIngredientesList = new List<Ingredientes>(receitaEdit.IngredientesLocalList);

                foreach (var ingrediente in receitaEdit.IngredientesLocalList)
                {
                    dataGridView1.Rows.Add(ingrediente.ingrediente, ingrediente.quantidade, ingrediente.medida);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(recipeDirectory))
            {
                Directory.CreateDirectory(recipeDirectory);
            }
            EnsureDirectoryExists();
            LoadAllRecipes();
        }

        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(recipeDirectory))
            {
                Directory.CreateDirectory(recipeDirectory);
            }
        }

        private void SaveRecipeToFile(Receita receita)
        {
            try
            {
                if (string.IsNullOrEmpty(receita.nome))
                {
                    MessageBox.Show("Erro: nome da receita está vazio. Não é possível salvar.");
                    return;
                }
                string filePath = Path.Combine(recipeDirectory, receita.nome + ".json");
                string json = JsonConvert.SerializeObject(receita, Formatting.Indented);
                File.WriteAllText(filePath, json);
                Console.WriteLine($"Saved json: {json}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar receita: {ex.Message}");
                return;
            }
        }

        private void LoadAllRecipes()
        {
            receitas.Clear();
            var files = Directory.GetFiles(recipeDirectory, "*.json");
            foreach (string file in files)
            {
                try
                {
                    string json = File.ReadAllText(file);
                    Receita receita = JsonConvert.DeserializeObject<Receita>(json);
                    if (receita.IngredientesLocalList == null)
                    {
                        receita.IngredientesLocalList = new List<Ingredientes>();
                    }
                    receitas.Add(receita);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar receita do arquivo '{file}': {ex.Message}");
                }
            }
        }

        private void DeleteRecipeFile(string receitaNome)
        {
            try
            {
                string filePath = Path.Combine(recipeDirectory, receitaNome + ".json");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine($"Arquivo '{filePath}' deletado com sucesso.");
                }
                else
                {
                    MessageBox.Show($"O arquivo da receita '{receitaNome}' não foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar o arquivo da receita '{receitaNome}': {ex.Message}");
            }
        }

       private void InitializeComboBoxes()
        {
            comboBoxFilterType.Items.AddRange(new string[] { "Todas", "Categoria", "Nível" , "Tempo de Preparo" });

            comboBoxFilterType.SelectedIndex = 0;
            comboBoxFilterOption.Enabled = false;
        }

        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFilterOption.Enabled = true;
            comboBoxFilterOption.Items.Clear();
            if (comboBoxFilterType.SelectedItem.ToString() == "Categoria")
            {
                comboBoxFilterOption.Items.AddRange(new string[]
                { 
                    "Porco", "Vaca", "Sobremesa", "Peixe", "Marisco", "Pastelaria", "Brunch", "Regional",
                    "Especial"
                });
            }
            else if (comboBoxFilterType.SelectedItem.ToString() == "Nível")
            {
                comboBoxFilterOption.Items.AddRange(new string[] { "Iniciante", "Intermédio", "Avançado", "Master chef" });
            }
            else if (comboBoxFilterType.SelectedItem.ToString() == "Tempo de Preparo")
            {
                comboBoxFilterOption.Items.AddRange(new string[] { "Crescente", "Decrescente" });
            }
            else if (comboBoxFilterType.SelectedItem.ToString() == "Todas")
            {
                comboBoxFilterOption.Enabled = false;
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            List<Receita> filteredRecipes = new List<Receita>();

            string selectedFilterType = comboBoxFilterType.SelectedItem?.ToString();
            string selectedFilterOption = comboBoxFilterOption.SelectedItem?.ToString();

            switch (selectedFilterType)
            {
                case "Nível":
                    if (!string.IsNullOrEmpty(selectedFilterOption))
                    {
                        filteredRecipes = receitas
                            .Where(r => r.nivel.Equals(selectedFilterOption, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    break;
                case "Tempo de Preparo":
                    if (selectedFilterOption == "Crescente")
                    {
                        filteredRecipes = receitas
                            .OrderBy(r => r.tempoDePrep)
                            .ToList();
                    }
                    else if (selectedFilterOption == "Decrescente")
                    {
                        filteredRecipes = receitas
                            .OrderByDescending(r => r.tempoDePrep)
                            .ToList();
                    }
                    break;

                case "Categoria":
                    if (!string.IsNullOrEmpty(selectedFilterOption))
                    {
                        filteredRecipes = receitas
                            .Where(r => r.categoria.Equals(selectedFilterOption, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    break;
                case "Todas":
                    filteredRecipes = receitas;
                    break;
            }
            ConfigureListViewColumns(selectedFilterType);
            PopulateListView(filteredRecipes, selectedFilterType);
        }

        private void PopulateListView(List<Receita> recipes, string filterType)
        {
            listViewRecipes.Items.Clear();

            foreach (var receita in recipes)
            {
                ListViewItem item = new ListViewItem(receita.nome);
                if (filterType.Equals("Todas", StringComparison.OrdinalIgnoreCase))
                {
                    item.SubItems.Add(receita.categoria);
                    item.SubItems.Add(receita.nivel);
                    item.SubItems.Add(receita.tempoDePrep.ToString());
                }
                else if (filterType.Equals("Nível", StringComparison.OrdinalIgnoreCase))
                {
                    item.SubItems.Add(receita.nivel);
                }
                else if (filterType.Equals("Categoria", StringComparison.OrdinalIgnoreCase))
                {
                    item.SubItems.Add(receita.categoria);
                }
                else if (filterType.Equals("Tempo de Preparo", StringComparison.OrdinalIgnoreCase))
                {
                    item.SubItems.Add(receita.tempoDePrep.ToString());
                }
                listViewRecipes.Items.Add(item);
            }
        }

        private void ConfigureListViewColumns(string filterType)
        {
            listViewRecipes.Items.Clear();
            listViewRecipes.Columns.Clear();

            listViewRecipes.View = View.Details;
            listViewRecipes.FullRowSelect = true;
            listViewRecipes.GridLines = true;

            if (filterType.Equals("Todas", StringComparison.OrdinalIgnoreCase))
            {
                listViewRecipes.Columns.Add("Nome", 150);
                listViewRecipes.Columns.Add("Categoria", 100);
                listViewRecipes.Columns.Add("Nível", 100);
                listViewRecipes.Columns.Add("Tempo de Preparo", 120);
            }
            else
            {
                listViewRecipes.Columns.Add("Nome", 150);
                listViewRecipes.Columns.Add(filterType, 150);
            }
        }

        private void buttonRemoverIng_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedRowIndex >= 0 && selectedRowIndex < tempIngredientesList.Count)
                {
                    tempIngredientesList.RemoveAt(selectedRowIndex);

                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                    MessageBox.Show("Ingrediente removido com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um ingrediente para remover.");
            }
        }
    }
}
