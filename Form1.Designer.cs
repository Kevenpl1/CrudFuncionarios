namespace Funcionarios
{
    partial class Funcionarios
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
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            txtID = new Label();
            lblId = new Label();
            button1 = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 89);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 144);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 197);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 255);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(232, 89);
            txtNome.MaxLength = 200;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(461, 27);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(232, 144);
            txtEmail.MaxLength = 200;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(461, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(232, 197);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(461, 27);
            txtCPF.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(232, 255);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(461, 27);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Location = new Point(557, 336);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(136, 36);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Location = new Point(232, 336);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(136, 36);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtID.Location = new Point(61, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(111, 18);
            txtID.TabIndex = 7;
            txtID.Text = "Funcionario ID";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(232, 37);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(599, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Location = new Point(399, 336);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(136, 36);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(441, 26);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 11;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click_1;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 450);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(button1);
            Controls.Add(lblId);
            Controls.Add(txtID);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Funcionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Label txtID;
        private Label lblId;
        private Button button1;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}