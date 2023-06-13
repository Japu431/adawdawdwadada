namespace Sistema_Gerenciamento_Biblioteca
{
    partial class UsuarioForm
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
            txt_livro = new TextBox();
            txt_lista_de_livros = new TextBox();
            buscar_livro = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_livro
            // 
            txt_livro.Location = new Point(12, 53);
            txt_livro.Name = "txt_livro";
            txt_livro.Size = new Size(177, 23);
            txt_livro.TabIndex = 0;
            // 
            // txt_lista_de_livros
            // 
            txt_lista_de_livros.Location = new Point(12, 82);
            txt_lista_de_livros.Multiline = true;
            txt_lista_de_livros.Name = "txt_lista_de_livros";
            txt_lista_de_livros.Size = new Size(279, 133);
            txt_lista_de_livros.TabIndex = 1;
            // 
            // buscar_livro
            // 
            buscar_livro.Location = new Point(207, 52);
            buscar_livro.Name = "buscar_livro";
            buscar_livro.Size = new Size(84, 23);
            buscar_livro.TabIndex = 2;
            buscar_livro.Text = "buscar";
            buscar_livro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar Livro";
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(607, 450);
            Controls.Add(label1);
            Controls.Add(buscar_livro);
            Controls.Add(txt_lista_de_livros);
            Controls.Add(txt_livro);
            Name = "UsuarioForm";
            Text = "Tela de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_livro;
        private TextBox txt_lista_de_livros;
        private Button buscar_livro;
        private Label label1;
    }
}