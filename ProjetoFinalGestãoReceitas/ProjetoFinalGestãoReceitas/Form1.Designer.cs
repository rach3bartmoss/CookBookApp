namespace ProjetoFinalGestãoReceitas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nomeReceita = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.dificuldade = new System.Windows.Forms.Label();
            this.npessoas = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.descricao = new System.Windows.Forms.Label();
            this.ingredientes = new System.Windows.Forms.Label();
            this.textBoxModoPreparo = new System.Windows.Forms.TextBox();
            this.textBox_NomeReceita = new System.Windows.Forms.TextBox();
            this.textBox_tempoPreparo = new System.Windows.Forms.TextBox();
            this.textBoxNPessoas = new System.Windows.Forms.TextBox();
            this.buttonAdd_ingredients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMedida = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFilterOption = new System.Windows.Forms.ComboBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.listViewRecipes = new System.Windows.Forms.ListView();
            this.buttonRemoverIng = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeReceita
            // 
            this.nomeReceita.AutoSize = true;
            this.nomeReceita.Location = new System.Drawing.Point(52, 68);
            this.nomeReceita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeReceita.Name = "nomeReceita";
            this.nomeReceita.Size = new System.Drawing.Size(136, 20);
            this.nomeReceita.TabIndex = 1;
            this.nomeReceita.Text = "Nome da Receita:";
            // 
            // tempo
            // 
            this.tempo.AutoSize = true;
            this.tempo.Location = new System.Drawing.Point(18, 111);
            this.tempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(170, 20);
            this.tempo.TabIndex = 2;
            this.tempo.Text = "Tempo de Preparação:";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Iniciante",
            "Intermédio",
            "Avançado",
            "Master Chef"});
            this.comboBoxNivel.Location = new System.Drawing.Point(201, 238);
            this.comboBoxNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(127, 28);
            this.comboBoxNivel.TabIndex = 3;
            // 
            // dificuldade
            // 
            this.dificuldade.AutoSize = true;
            this.dificuldade.Location = new System.Drawing.Point(141, 243);
            this.dificuldade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dificuldade.Name = "dificuldade";
            this.dificuldade.Size = new System.Drawing.Size(46, 20);
            this.dificuldade.TabIndex = 4;
            this.dificuldade.Text = "Nivel:";
            // 
            // npessoas
            // 
            this.npessoas.AutoSize = true;
            this.npessoas.Location = new System.Drawing.Point(74, 154);
            this.npessoas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npessoas.Name = "npessoas";
            this.npessoas.Size = new System.Drawing.Size(116, 20);
            this.npessoas.TabIndex = 5;
            this.npessoas.Text = "Nº de pessoas:";
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(108, 202);
            this.categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(82, 20);
            this.categoria.TabIndex = 6;
            this.categoria.Text = "Categoria:";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Items.AddRange(new object[] {
            "Porco",
            "Vaca",
            "Frango",
            "Peixe",
            "Marisco",
            "Pastelaria",
            "Sobremesas",
            "Brunch",
            "Regional",
            "Especial"});
            this.comboBoxCat.Location = new System.Drawing.Point(201, 197);
            this.comboBoxCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(127, 28);
            this.comboBoxCat.TabIndex = 7;
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(52, 289);
            this.descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(135, 20);
            this.descricao.TabIndex = 8;
            this.descricao.Text = "Modo de Preparo:";
            // 
            // ingredientes
            // 
            this.ingredientes.AutoSize = true;
            this.ingredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientes.Location = new System.Drawing.Point(53, 410);
            this.ingredientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingredientes.Name = "ingredientes";
            this.ingredientes.Size = new System.Drawing.Size(138, 25);
            this.ingredientes.TabIndex = 9;
            this.ingredientes.Text = "Ingredientes:";
            // 
            // textBoxModoPreparo
            // 
            this.textBoxModoPreparo.Location = new System.Drawing.Point(200, 289);
            this.textBoxModoPreparo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxModoPreparo.Multiline = true;
            this.textBoxModoPreparo.Name = "textBoxModoPreparo";
            this.textBoxModoPreparo.Size = new System.Drawing.Size(398, 119);
            this.textBoxModoPreparo.TabIndex = 10;
            // 
            // textBox_NomeReceita
            // 
            this.textBox_NomeReceita.Location = new System.Drawing.Point(201, 63);
            this.textBox_NomeReceita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NomeReceita.Name = "textBox_NomeReceita";
            this.textBox_NomeReceita.Size = new System.Drawing.Size(310, 26);
            this.textBox_NomeReceita.TabIndex = 11;
            // 
            // textBox_tempoPreparo
            // 
            this.textBox_tempoPreparo.Location = new System.Drawing.Point(201, 106);
            this.textBox_tempoPreparo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_tempoPreparo.Name = "textBox_tempoPreparo";
            this.textBox_tempoPreparo.Size = new System.Drawing.Size(310, 26);
            this.textBox_tempoPreparo.TabIndex = 12;
            // 
            // textBoxNPessoas
            // 
            this.textBoxNPessoas.Location = new System.Drawing.Point(201, 149);
            this.textBoxNPessoas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNPessoas.Name = "textBoxNPessoas";
            this.textBoxNPessoas.Size = new System.Drawing.Size(310, 26);
            this.textBoxNPessoas.TabIndex = 13;
            // 
            // buttonAdd_ingredients
            // 
            this.buttonAdd_ingredients.Location = new System.Drawing.Point(177, 569);
            this.buttonAdd_ingredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd_ingredients.Name = "buttonAdd_ingredients";
            this.buttonAdd_ingredients.Size = new System.Drawing.Size(242, 38);
            this.buttonAdd_ingredients.TabIndex = 14;
            this.buttonAdd_ingredients.Text = "Adicionar Ingrediente";
            this.buttonAdd_ingredients.UseVisualStyleBackColor = true;
            this.buttonAdd_ingredients.Click += new System.EventHandler(this.buttonAdd_ingredients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIngrediente,
            this.ColumnQuantidade,
            this.ColumnMedida});
            this.dataGridView1.Location = new System.Drawing.Point(54, 619);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(709, 186);
            this.dataGridView1.TabIndex = 15;
            // 
            // ColumnIngrediente
            // 
            this.ColumnIngrediente.HeaderText = "Ingrediente";
            this.ColumnIngrediente.MinimumWidth = 8;
            this.ColumnIngrediente.Name = "ColumnIngrediente";
            this.ColumnIngrediente.Width = 150;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.MinimumWidth = 8;
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.Width = 120;
            // 
            // ColumnMedida
            // 
            this.ColumnMedida.HeaderText = "Medida";
            this.ColumnMedida.MinimumWidth = 8;
            this.ColumnMedida.Name = "ColumnMedida";
            this.ColumnMedida.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrediente:";
            // 
            // textBoxIngrediente
            // 
            this.textBoxIngrediente.Location = new System.Drawing.Point(203, 456);
            this.textBoxIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIngrediente.Name = "textBoxIngrediente";
            this.textBoxIngrediente.Size = new System.Drawing.Size(310, 26);
            this.textBoxIngrediente.TabIndex = 17;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(202, 496);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(103, 26);
            this.textBoxQuantidade.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 501);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantidade:";
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(78, 29);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(61, 29);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardar.Image")));
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(79, 29);
            this.toolStripButtonGuardar.Text = "Guardar";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEliminar,
            this.toolStripButtonEditar,
            this.toolStripButtonGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1552, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 534);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Medida:";
            // 
            // comboBoxMedida
            // 
            this.comboBoxMedida.FormattingEnabled = true;
            this.comboBoxMedida.Items.AddRange(new object[] {
            "Unidade",
            "(ml)",
            "(Litros)",
            "Xícara (240ml)",
            "Colher de sopa (15ml)",
            "Colher de chá (5ml)",
            "(g)",
            "(Kg)",
            "Xícara (120g)",
            "Colher de sopa(20g)",
            "Colher de chá (5g)"});
            this.comboBoxMedida.Location = new System.Drawing.Point(203, 531);
            this.comboBoxMedida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMedida.Name = "comboBoxMedida";
            this.comboBoxMedida.Size = new System.Drawing.Size(185, 28);
            this.comboBoxMedida.TabIndex = 21;
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Location = new System.Drawing.Point(1068, 103);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(283, 28);
            this.comboBoxFilterType.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(898, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Listar Receitas por:";
            // 
            // comboBoxFilterOption
            // 
            this.comboBoxFilterOption.FormattingEnabled = true;
            this.comboBoxFilterOption.Items.AddRange(new object[] {
            "Nivel de Dificuldade",
            "Tempo de Preparação",
            "Categoria",
            "Todas as Receitas"});
            this.comboBoxFilterOption.Location = new System.Drawing.Point(1068, 154);
            this.comboBoxFilterOption.Name = "comboBoxFilterOption";
            this.comboBoxFilterOption.Size = new System.Drawing.Size(283, 28);
            this.comboBoxFilterOption.TabIndex = 25;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(1120, 215);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(212, 47);
            this.buttonListar.TabIndex = 26;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // listViewRecipes
            // 
            this.listViewRecipes.FullRowSelect = true;
            this.listViewRecipes.GridLines = true;
            this.listViewRecipes.HideSelection = false;
            this.listViewRecipes.Location = new System.Drawing.Point(828, 303);
            this.listViewRecipes.Name = "listViewRecipes";
            this.listViewRecipes.Size = new System.Drawing.Size(669, 501);
            this.listViewRecipes.TabIndex = 27;
            this.listViewRecipes.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRemoverIng
            // 
            this.buttonRemoverIng.Location = new System.Drawing.Point(461, 569);
            this.buttonRemoverIng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoverIng.Name = "buttonRemoverIng";
            this.buttonRemoverIng.Size = new System.Drawing.Size(242, 38);
            this.buttonRemoverIng.TabIndex = 28;
            this.buttonRemoverIng.Text = "Remover Ingrediente";
            this.buttonRemoverIng.UseVisualStyleBackColor = true;
            this.buttonRemoverIng.Click += new System.EventHandler(this.buttonRemoverIng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 838);
            this.Controls.Add(this.buttonRemoverIng);
            this.Controls.Add(this.listViewRecipes);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.comboBoxFilterOption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFilterType);
            this.Controls.Add(this.comboBoxMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxIngrediente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd_ingredients);
            this.Controls.Add(this.textBoxNPessoas);
            this.Controls.Add(this.textBox_tempoPreparo);
            this.Controls.Add(this.textBox_NomeReceita);
            this.Controls.Add(this.textBoxModoPreparo);
            this.Controls.Add(this.ingredientes);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.npessoas);
            this.Controls.Add(this.dificuldade);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.nomeReceita);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomeReceita;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Label dificuldade;
        private System.Windows.Forms.Label npessoas;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label ingredientes;
        private System.Windows.Forms.TextBox textBoxModoPreparo;
        private System.Windows.Forms.TextBox textBox_NomeReceita;
        private System.Windows.Forms.TextBox textBox_tempoPreparo;
        private System.Windows.Forms.TextBox textBoxNPessoas;
        private System.Windows.Forms.Button buttonAdd_ingredients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIngrediente;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedida;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFilterOption;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.ListView listViewRecipes;
        private System.Windows.Forms.Button buttonRemoverIng;
    }
}

