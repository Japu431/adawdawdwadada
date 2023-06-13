namespace Sistema_Gerenciamento_Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            entrar_home = new Button();
            cadastro_home = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(234, 35);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca Chernoboys";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 119);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 1;
            // 
            // entrar_home
            // 
            entrar_home.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            entrar_home.Location = new Point(38, 111);
            entrar_home.Margin = new Padding(3, 4, 3, 4);
            entrar_home.Name = "entrar_home";
            entrar_home.Size = new Size(98, 43);
            entrar_home.TabIndex = 2;
            entrar_home.Text = "Entrar";
            entrar_home.UseVisualStyleBackColor = true;
            entrar_home.Click += entrar_home_Click;
            // 
            // cadastro_home
            // 
            cadastro_home.AutoSize = true;
            cadastro_home.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cadastro_home.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cadastro_home.Location = new Point(174, 111);
            cadastro_home.Margin = new Padding(3, 4, 3, 4);
            cadastro_home.Name = "cadastro_home";
            cadastro_home.Size = new Size(98, 36);
            cadastro_home.TabIndex = 3;
            cadastro_home.Text = "Cadastrar";
            cadastro_home.UseVisualStyleBackColor = true;
            cadastro_home.Click += cadastro_home_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(204, 197);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 5;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(314, 240);
            Controls.Add(button1);
            Controls.Add(cadastro_home);
            Controls.Add(entrar_home);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Biblioteca Chernoboys";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button entrar_home;
        private Button cadastro_home;
        private Button button1;
    }
}