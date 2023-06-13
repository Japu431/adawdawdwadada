namespace Sistema_Gerenciamento_Biblioteca
{
    partial class CadastroDeLivro
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
            submit_cadastro = new Button();
            campo_password_confirm = new TextBox();
            label8 = new Label();
            campo_matricula = new TextBox();
            label9 = new Label();
            campo_password = new TextBox();
            label3 = new Label();
            campo_nome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // submit_cadastro
            // 
            submit_cadastro.Font = new Font("Segoe Print", 13F, FontStyle.Regular, GraphicsUnit.Point);
            submit_cadastro.Location = new Point(392, 230);
            submit_cadastro.Name = "submit_cadastro";
            submit_cadastro.Size = new Size(207, 36);
            submit_cadastro.TabIndex = 41;
            submit_cadastro.Text = "Cadastrar Livro";
            submit_cadastro.UseVisualStyleBackColor = true;
            // 
            // campo_password_confirm
            // 
            campo_password_confirm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_password_confirm.Location = new Point(419, 176);
            campo_password_confirm.Multiline = true;
            campo_password_confirm.Name = "campo_password_confirm";
            campo_password_confirm.PasswordChar = '*';
            campo_password_confirm.Size = new Size(180, 32);
            campo_password_confirm.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(419, 145);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 35;
            label8.Text = "Ano de publicação";
            // 
            // campo_matricula
            // 
            campo_matricula.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_matricula.Location = new Point(419, 101);
            campo_matricula.Multiline = true;
            campo_matricula.Name = "campo_matricula";
            campo_matricula.Size = new Size(180, 32);
            campo_matricula.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(419, 70);
            label9.Name = "label9";
            label9.Size = new Size(59, 28);
            label9.TabIndex = 33;
            label9.Text = "Autor";
            // 
            // campo_password
            // 
            campo_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_password.Location = new Point(201, 176);
            campo_password.Multiline = true;
            campo_password.Name = "campo_password";
            campo_password.PasswordChar = '*';
            campo_password.Size = new Size(180, 32);
            campo_password.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 145);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 27;
            label3.Text = "Editoria";
            // 
            // campo_nome
            // 
            campo_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_nome.Location = new Point(201, 101);
            campo_nome.Multiline = true;
            campo_nome.Name = "campo_nome";
            campo_nome.Size = new Size(180, 32);
            campo_nome.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 25;
            label2.Text = "Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 47);
            label1.TabIndex = 24;
            label1.Text = "Cadastro de Livro";
            // 
            // CadastroDeLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 330);
            Controls.Add(submit_cadastro);
            Controls.Add(campo_password_confirm);
            Controls.Add(label8);
            Controls.Add(campo_matricula);
            Controls.Add(label9);
            Controls.Add(campo_password);
            Controls.Add(label3);
            Controls.Add(campo_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroDeLivro";
            Text = "CadastroDeLivro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submit_cadastro;
        private TextBox campo_password_confirm;
        private Label label8;
        private TextBox campo_matricula;
        private Label label9;
        private TextBox campo_password;
        private Label label3;
        private TextBox campo_nome;
        private Label label2;
        private Label label1;
    }
}