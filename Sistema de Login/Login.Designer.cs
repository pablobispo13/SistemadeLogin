
namespace Sistema_de_Login
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.mts = new MaterialSkin.Controls.MaterialTabSelector();
            this.mtc = new MaterialSkin.Controls.MaterialTabControl();
            this.tp_login = new System.Windows.Forms.TabPage();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bt_login = new MaterialSkin.Controls.MaterialFlatButton();
            this.tp_cad_login = new System.Windows.Forms.TabPage();
            this.txt_conf_senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.msk_cpf_cad = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha_cad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.bt_cadastrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.notificação = new System.Windows.Forms.NotifyIcon(this.components);
            this.bt_tema = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mtc.SuspendLayout();
            this.tp_login.SuspendLayout();
            this.tp_cad_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // mts
            // 
            this.mts.BaseTabControl = this.mtc;
            this.mts.Depth = 0;
            this.mts.Location = new System.Drawing.Point(117, 35);
            this.mts.MouseState = MaterialSkin.MouseState.HOVER;
            this.mts.Name = "mts";
            this.mts.Size = new System.Drawing.Size(257, 23);
            this.mts.TabIndex = 0;
            // 
            // mtc
            // 
            this.mtc.Controls.Add(this.tp_login);
            this.mtc.Controls.Add(this.tp_cad_login);
            this.mtc.Depth = 0;
            this.mtc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mtc.Location = new System.Drawing.Point(2, 65);
            this.mtc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtc.Name = "mtc";
            this.mtc.SelectedIndex = 0;
            this.mtc.Size = new System.Drawing.Size(400, 440);
            this.mtc.TabIndex = 1;
            // 
            // tp_login
            // 
            this.tp_login.BackColor = System.Drawing.Color.White;
            this.tp_login.Controls.Add(this.msk_cpf);
            this.tp_login.Controls.Add(this.txt_senha);
            this.tp_login.Controls.Add(this.materialLabel2);
            this.tp_login.Controls.Add(this.materialLabel1);
            this.tp_login.Controls.Add(this.bt_login);
            this.tp_login.Location = new System.Drawing.Point(4, 22);
            this.tp_login.Name = "tp_login";
            this.tp_login.Padding = new System.Windows.Forms.Padding(3);
            this.tp_login.Size = new System.Drawing.Size(392, 414);
            this.tp_login.TabIndex = 0;
            this.tp_login.Text = "Login";
            // 
            // msk_cpf
            // 
            this.msk_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msk_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msk_cpf.ForeColor = System.Drawing.Color.White;
            this.msk_cpf.Location = new System.Drawing.Point(134, 25);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(121, 26);
            this.msk_cpf.TabIndex = 8;
            // 
            // txt_senha
            // 
            this.txt_senha.Depth = 0;
            this.txt_senha.Hint = "";
            this.txt_senha.Location = new System.Drawing.Point(86, 93);
            this.txt_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.SelectedText = "";
            this.txt_senha.SelectionLength = 0;
            this.txt_senha.SelectionStart = 0;
            this.txt_senha.Size = new System.Drawing.Size(249, 23);
            this.txt_senha.TabIndex = 7;
            this.txt_senha.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 97);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Senha";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "CPF";
            // 
            // bt_login
            // 
            this.bt_login.AutoSize = true;
            this.bt_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_login.Depth = 0;
            this.bt_login.Location = new System.Drawing.Point(156, 185);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_login.Name = "bt_login";
            this.bt_login.Primary = false;
            this.bt_login.Size = new System.Drawing.Size(60, 36);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "Logar!";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tp_cad_login
            // 
            this.tp_cad_login.BackColor = System.Drawing.Color.White;
            this.tp_cad_login.Controls.Add(this.txt_conf_senha);
            this.tp_cad_login.Controls.Add(this.materialLabel6);
            this.tp_cad_login.Controls.Add(this.materialLabel5);
            this.tp_cad_login.Controls.Add(this.txt_nome);
            this.tp_cad_login.Controls.Add(this.msk_cpf_cad);
            this.tp_cad_login.Controls.Add(this.txt_senha_cad);
            this.tp_cad_login.Controls.Add(this.materialLabel3);
            this.tp_cad_login.Controls.Add(this.materialLabel4);
            this.tp_cad_login.Controls.Add(this.bt_cadastrar);
            this.tp_cad_login.Location = new System.Drawing.Point(4, 22);
            this.tp_cad_login.Name = "tp_cad_login";
            this.tp_cad_login.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cad_login.Size = new System.Drawing.Size(392, 414);
            this.tp_cad_login.TabIndex = 1;
            this.tp_cad_login.Text = "Cadastrar Login";
            // 
            // txt_conf_senha
            // 
            this.txt_conf_senha.Depth = 0;
            this.txt_conf_senha.Hint = "";
            this.txt_conf_senha.Location = new System.Drawing.Point(119, 226);
            this.txt_conf_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_conf_senha.Name = "txt_conf_senha";
            this.txt_conf_senha.PasswordChar = '*';
            this.txt_conf_senha.SelectedText = "";
            this.txt_conf_senha.SelectionLength = 0;
            this.txt_conf_senha.SelectionStart = 0;
            this.txt_conf_senha.Size = new System.Drawing.Size(249, 23);
            this.txt_conf_senha.TabIndex = 16;
            this.txt_conf_senha.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 226);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(96, 38);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Confirmação\r\n de senha";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(29, 59);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Depth = 0;
            this.txt_nome.Hint = "";
            this.txt_nome.Location = new System.Drawing.Point(93, 55);
            this.txt_nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.Size = new System.Drawing.Size(249, 23);
            this.txt_nome.TabIndex = 13;
            this.txt_nome.UseSystemPasswordChar = false;
            // 
            // msk_cpf_cad
            // 
            this.msk_cpf_cad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msk_cpf_cad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_cpf_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msk_cpf_cad.ForeColor = System.Drawing.Color.White;
            this.msk_cpf_cad.Location = new System.Drawing.Point(141, 105);
            this.msk_cpf_cad.Mask = "000.000.000-00";
            this.msk_cpf_cad.Name = "msk_cpf_cad";
            this.msk_cpf_cad.Size = new System.Drawing.Size(121, 26);
            this.msk_cpf_cad.TabIndex = 12;
            // 
            // txt_senha_cad
            // 
            this.txt_senha_cad.Depth = 0;
            this.txt_senha_cad.Hint = "";
            this.txt_senha_cad.Location = new System.Drawing.Point(93, 173);
            this.txt_senha_cad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_senha_cad.Name = "txt_senha_cad";
            this.txt_senha_cad.PasswordChar = '*';
            this.txt_senha_cad.SelectedText = "";
            this.txt_senha_cad.SelectionLength = 0;
            this.txt_senha_cad.SelectionStart = 0;
            this.txt_senha_cad.Size = new System.Drawing.Size(249, 23);
            this.txt_senha_cad.TabIndex = 11;
            this.txt_senha_cad.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(29, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Senha";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(29, 112);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "CPF";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.AutoSize = true;
            this.bt_cadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_cadastrar.Depth = 0;
            this.bt_cadastrar.Location = new System.Drawing.Point(141, 310);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_cadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Primary = false;
            this.bt_cadastrar.Size = new System.Drawing.Size(95, 36);
            this.bt_cadastrar.TabIndex = 1;
            this.bt_cadastrar.Text = "Cadastrar!";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // notificação
            // 
            this.notificação.Icon = ((System.Drawing.Icon)(resources.GetObject("notificação.Icon")));
            this.notificação.Visible = true;
            // 
            // bt_tema
            // 
            this.bt_tema.BackColor = System.Drawing.Color.Transparent;
            this.bt_tema.Depth = 0;
            this.bt_tema.Location = new System.Drawing.Point(2, 35);
            this.bt_tema.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_tema.Name = "bt_tema";
            this.bt_tema.Primary = true;
            this.bt_tema.Size = new System.Drawing.Size(75, 22);
            this.bt_tema.TabIndex = 2;
            this.bt_tema.Text = "Light";
            this.bt_tema.UseVisualStyleBackColor = false;
            this.bt_tema.Click += new System.EventHandler(this.bt_tema_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 512);
            this.Controls.Add(this.bt_tema);
            this.Controls.Add(this.mtc);
            this.Controls.Add(this.mts);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 510);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mtc.ResumeLayout(false);
            this.tp_login.ResumeLayout(false);
            this.tp_login.PerformLayout();
            this.tp_cad_login.ResumeLayout(false);
            this.tp_cad_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector mts;
        private MaterialSkin.Controls.MaterialTabControl mtc;
        private System.Windows.Forms.TabPage tp_login;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton bt_login;
        private System.Windows.Forms.TabPage tp_cad_login;
        private System.Windows.Forms.NotifyIcon notificação;
        private MaterialSkin.Controls.MaterialRaisedButton bt_tema;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_senha;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_conf_senha;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nome;
        private System.Windows.Forms.MaskedTextBox msk_cpf_cad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_senha_cad;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton bt_cadastrar;
    }
}

