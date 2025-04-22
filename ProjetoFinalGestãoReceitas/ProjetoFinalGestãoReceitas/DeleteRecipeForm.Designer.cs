namespace ProjetoFinalGestãoReceitas
{
    partial class DeleteRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListaReceitas = new System.Windows.Forms.ComboBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelarExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione item para eliminar:";
            // 
            // comboBoxListaReceitas
            // 
            this.comboBoxListaReceitas.FormattingEnabled = true;
            this.comboBoxListaReceitas.Location = new System.Drawing.Point(229, 46);
            this.comboBoxListaReceitas.Name = "comboBoxListaReceitas";
            this.comboBoxListaReceitas.Size = new System.Drawing.Size(236, 28);
            this.comboBoxListaReceitas.TabIndex = 1;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(309, 168);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(142, 45);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelarExcluir
            // 
            this.buttonCancelarExcluir.Location = new System.Drawing.Point(61, 168);
            this.buttonCancelarExcluir.Name = "buttonCancelarExcluir";
            this.buttonCancelarExcluir.Size = new System.Drawing.Size(142, 45);
            this.buttonCancelarExcluir.TabIndex = 3;
            this.buttonCancelarExcluir.Text = "Cancelar";
            this.buttonCancelarExcluir.UseVisualStyleBackColor = true;
            // 
            // DeleteRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 244);
            this.Controls.Add(this.buttonCancelarExcluir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.comboBoxListaReceitas);
            this.Controls.Add(this.label1);
            this.Name = "DeleteRecipeForm";
            this.Text = "DeleteRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListaReceitas;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelarExcluir;
    }
}