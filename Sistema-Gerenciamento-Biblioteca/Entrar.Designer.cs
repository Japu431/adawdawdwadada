namespace Sistema_Gerenciamento_Biblioteca
{
    partial class Entrar
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
            label1 = new Label();
            campo_emailRA = new TextBox();
            campo_password = new TextBox();
            label2 = new Label();
            radio_aluno = new RadioButton();
            radio_professor = new RadioButton();
            radio_funcionarios = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            Tela_Login_Entrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 106);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 0;
            label1.Text = "RA ou E-mail: ";
            // 
            // campo_emailRA
            // 
            campo_emailRA.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            campo_emailRA.Location = new Point(43, 129);
            campo_emailRA.Multiline = true;
            campo_emailRA.Name = "campo_emailRA";
            campo_emailRA.Size = new Size(256, 34);
            campo_emailRA.TabIndex = 1;
            // 
            // campo_password
            // 
            campo_password.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            campo_password.Location = new Point(43, 209);
            campo_password.Multiline = true;
            campo_password.Name = "campo_password";
            campo_password.PasswordChar = '*';
            campo_password.Size = new Size(256, 34);
            campo_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(43, 186);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 2;
            label2.Text = "Senha: ";
            // 
            // radio_aluno
            // 
            radio_aluno.AutoSize = true;
            radio_aluno.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radio_aluno.Location = new Point(206, 255);
            radio_aluno.Name = "radio_aluno";
            radio_aluno.Size = new Size(62, 25);
            radio_aluno.TabIndex = 4;
            radio_aluno.TabStop = true;
            radio_aluno.Text = "Aluno";
            radio_aluno.UseVisualStyleBackColor = true;
            // 
            // radio_professor
            // 
            radio_professor.AutoSize = true;
            radio_professor.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radio_professor.Location = new Point(206, 280);
            radio_professor.Name = "radio_professor";
            radio_professor.Size = new Size(82, 25);
            radio_professor.TabIndex = 5;
            radio_professor.TabStop = true;
            radio_professor.Text = "Professor";
            radio_professor.UseVisualStyleBackColor = true;
            // 
            // radio_funcionarios
            // 
            radio_funcionarios.AutoSize = true;
            radio_funcionarios.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radio_funcionarios.Location = new Point(206, 305);
            radio_funcionarios.Name = "radio_funcionarios";
            radio_funcionarios.Size = new Size(101, 25);
            radio_funcionarios.TabIndex = 6;
            radio_funcionarios.TabStop = true;
            radio_funcionarios.Text = "Bibliotecario";
            radio_funcionarios.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 253);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 7;
            label3.Text = "Preencha o seu cargo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 28);
            label4.Name = "label4";
            label4.Size = new Size(158, 37);
            label4.TabIndex = 8;
            label4.Text = "Tela de Login";
            // 
            // Tela_Login_Entrar
            // 
            Tela_Login_Entrar.BackColor = Color.White;
            Tela_Login_Entrar.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Tela_Login_Entrar.Location = new Point(43, 289);
            Tela_Login_Entrar.Name = "Tela_Login_Entrar";
            Tela_Login_Entrar.Size = new Size(126, 35);
            Tela_Login_Entrar.TabIndex = 9;
            Tela_Login_Entrar.Text = "Entrar";
            Tela_Login_Entrar.UseVisualStyleBackColor = false;
            Tela_Login_Entrar.Click += Tela_Login_Entrar_Click;
            // 
            // Entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(374, 404);
            Controls.Add(Tela_Login_Entrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(radio_funcionarios);
            Controls.Add(radio_professor);
            Controls.Add(radio_aluno);
            Controls.Add(campo_password);
            Controls.Add(label2);
            Controls.Add(campo_emailRA);
            Controls.Add(label1);
            Name = "Entrar";
            Text = "Tela Login";
            Load += Entrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox campo_emailRA;
        private TextBox campo_password;
        private Label label2;
        private RadioButton radio_aluno;
        private RadioButton radio_professor;
        private RadioButton radio_funcionarios;
        private Label label3;
        private Label label4;
        private Button Tela_Login_Entrar;
    }
}