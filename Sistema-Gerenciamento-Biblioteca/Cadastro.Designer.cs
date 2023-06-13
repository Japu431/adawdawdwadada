namespace Sistema_Gerenciamento_Biblioteca
{
    partial class Cadastro
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
            label2 = new Label();
            campo_nome = new TextBox();
            campo_password = new TextBox();
            label3 = new Label();
            campo_email = new TextBox();
            label4 = new Label();
            campo_telefone = new TextBox();
            label5 = new Label();
            campo_endereco = new TextBox();
            label6 = new Label();
            campo_email_confirm = new TextBox();
            label7 = new Label();
            campo_password_confirm = new TextBox();
            label8 = new Label();
            campo_matricula = new TextBox();
            label9 = new Label();
            submit_cadastro = new Button();
            label10 = new Label();
            tela_entrar = new Button();
            radio_funcionarios = new RadioButton();
            radio_professor = new RadioButton();
            radio_aluno = new RadioButton();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 25);
            label1.Name = "label1";
            label1.Size = new Size(252, 47);
            label1.TabIndex = 0;
            label1.Text = "Tela de Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // campo_nome
            // 
            campo_nome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_nome.Location = new Point(43, 125);
            campo_nome.Multiline = true;
            campo_nome.Name = "campo_nome";
            campo_nome.Size = new Size(180, 32);
            campo_nome.TabIndex = 2;
            // 
            // campo_password
            // 
            campo_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_password.Location = new Point(43, 200);
            campo_password.Multiline = true;
            campo_password.Name = "campo_password";
            campo_password.PasswordChar = '*';
            campo_password.Size = new Size(180, 32);
            campo_password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 169);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // campo_email
            // 
            campo_email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_email.Location = new Point(43, 272);
            campo_email.Multiline = true;
            campo_email.Name = "campo_email";
            campo_email.Size = new Size(180, 32);
            campo_email.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 241);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 5;
            label4.Text = "E-mail";
            // 
            // campo_telefone
            // 
            campo_telefone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_telefone.Location = new Point(43, 344);
            campo_telefone.Multiline = true;
            campo_telefone.Name = "campo_telefone";
            campo_telefone.Size = new Size(180, 32);
            campo_telefone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 313);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 7;
            label5.Text = "Telefone";
            // 
            // campo_endereco
            // 
            campo_endereco.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_endereco.Location = new Point(261, 344);
            campo_endereco.Multiline = true;
            campo_endereco.Name = "campo_endereco";
            campo_endereco.Size = new Size(180, 32);
            campo_endereco.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(261, 313);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 15;
            label6.Text = "Endereço";
            // 
            // campo_email_confirm
            // 
            campo_email_confirm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_email_confirm.Location = new Point(261, 272);
            campo_email_confirm.Multiline = true;
            campo_email_confirm.Name = "campo_email_confirm";
            campo_email_confirm.Size = new Size(180, 32);
            campo_email_confirm.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(261, 241);
            label7.Name = "label7";
            label7.Size = new Size(157, 28);
            label7.TabIndex = 13;
            label7.Text = "Confirmar E-mail";
            // 
            // campo_password_confirm
            // 
            campo_password_confirm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_password_confirm.Location = new Point(261, 200);
            campo_password_confirm.Multiline = true;
            campo_password_confirm.Name = "campo_password_confirm";
            campo_password_confirm.PasswordChar = '*';
            campo_password_confirm.Size = new Size(180, 32);
            campo_password_confirm.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(261, 169);
            label8.Name = "label8";
            label8.Size = new Size(149, 28);
            label8.TabIndex = 11;
            label8.Text = "Confirmar Senha";
            // 
            // campo_matricula
            // 
            campo_matricula.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            campo_matricula.Location = new Point(261, 125);
            campo_matricula.Multiline = true;
            campo_matricula.Name = "campo_matricula";
            campo_matricula.Size = new Size(180, 32);
            campo_matricula.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(261, 94);
            label9.Name = "label9";
            label9.Size = new Size(36, 28);
            label9.TabIndex = 9;
            label9.Text = "RA";
            // 
            // submit_cadastro
            // 
            submit_cadastro.Font = new Font("Segoe Print", 13F, FontStyle.Regular, GraphicsUnit.Point);
            submit_cadastro.Location = new Point(284, 401);
            submit_cadastro.Name = "submit_cadastro";
            submit_cadastro.Size = new Size(157, 36);
            submit_cadastro.TabIndex = 17;
            submit_cadastro.Text = "Cadastrar";
            submit_cadastro.UseVisualStyleBackColor = true;
            submit_cadastro.Click += submit_cadastro_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(287, 450);
            label10.Name = "label10";
            label10.Size = new Size(90, 21);
            label10.TabIndex = 18;
            label10.Text = "Possuí conta?";
            label10.Click += label10_Click;
            // 
            // tela_entrar
            // 
            tela_entrar.BackColor = Color.White;
            tela_entrar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tela_entrar.Location = new Point(383, 451);
            tela_entrar.Name = "tela_entrar";
            tela_entrar.Size = new Size(58, 20);
            tela_entrar.TabIndex = 19;
            tela_entrar.Text = "Entrar";
            tela_entrar.UseVisualStyleBackColor = false;
            tela_entrar.Click += tela_entrar_Click;
            // 
            // radio_funcionarios
            // 
            radio_funcionarios.AutoSize = true;
            radio_funcionarios.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radio_funcionarios.Location = new Point(112, 448);
            radio_funcionarios.Name = "radio_funcionarios";
            radio_funcionarios.Size = new Size(101, 25);
            radio_funcionarios.TabIndex = 22;
            radio_funcionarios.TabStop = true;
            radio_funcionarios.Text = "Bibliotecario";
            radio_funcionarios.UseVisualStyleBackColor = true;
            // 
            // radio_professor
            // 
            radio_professor.AutoSize = true;
            radio_professor.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radio_professor.Location = new Point(112, 423);
            radio_professor.Name = "radio_professor";
            radio_professor.Size = new Size(82, 25);
            radio_professor.TabIndex = 21;
            radio_professor.TabStop = true;
            radio_professor.Text = "Professor";
            radio_professor.UseVisualStyleBackColor = true;
            // 
            // radio_aluno
            // 
            radio_aluno.AutoSize = true;
            radio_aluno.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radio_aluno.Location = new Point(112, 398);
            radio_aluno.Name = "radio_aluno";
            radio_aluno.Size = new Size(62, 25);
            radio_aluno.TabIndex = 20;
            radio_aluno.TabStop = true;
            radio_aluno.Text = "Aluno";
            radio_aluno.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(43, 395);
            label11.Name = "label11";
            label11.Size = new Size(63, 28);
            label11.TabIndex = 23;
            label11.Text = "Cargo:";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(488, 510);
            Controls.Add(label11);
            Controls.Add(radio_funcionarios);
            Controls.Add(radio_professor);
            Controls.Add(radio_aluno);
            Controls.Add(tela_entrar);
            Controls.Add(label10);
            Controls.Add(submit_cadastro);
            Controls.Add(campo_endereco);
            Controls.Add(label6);
            Controls.Add(campo_email_confirm);
            Controls.Add(label7);
            Controls.Add(campo_password_confirm);
            Controls.Add(label8);
            Controls.Add(campo_matricula);
            Controls.Add(label9);
            Controls.Add(campo_telefone);
            Controls.Add(label5);
            Controls.Add(campo_email);
            Controls.Add(label4);
            Controls.Add(campo_password);
            Controls.Add(label3);
            Controls.Add(campo_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox campo_nome;
        private TextBox campo_password;
        private Label label3;
        private TextBox campo_email;
        private Label label4;
        private TextBox campo_telefone;
        private Label label5;
        private TextBox campo_endereco;
        private Label label6;
        private TextBox campo_email_confirm;
        private Label label7;
        private TextBox campo_password_confirm;
        private Label label8;
        private TextBox campo_matricula;
        private Label label9;
        private Button submit_cadastro;
        private Label label10;
        private Button tela_entrar;
        private RadioButton radio_funcionarios;
        private RadioButton radio_professor;
        private RadioButton radio_aluno;
        private Label label11;
    }
}