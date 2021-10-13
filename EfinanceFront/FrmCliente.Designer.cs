
namespace EfinanceFront
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            this.GbxLista = new System.Windows.Forms.GroupBox();
            this.GdwCidade = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.GbxRegistro = new System.Windows.Forms.GroupBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.CboEstado = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.TxtCodigoIbge = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GdwCidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GbxRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxLista
            // 
            this.GbxLista.Controls.Add(this.GdwCidade);
            this.GbxLista.Enabled = false;
            this.GbxLista.Location = new System.Drawing.Point(15, 230);
            this.GbxLista.Name = "GbxLista";
            this.GbxLista.Size = new System.Drawing.Size(580, 112);
            this.GbxLista.TabIndex = 22;
            this.GbxLista.TabStop = false;
            this.GbxLista.Text = "Lista de cidade";
            // 
            // GdwCidade
            // 
            this.GdwCidade.AllowUserToAddRows = false;
            this.GdwCidade.AllowUserToDeleteRows = false;
            this.GdwCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdwCidade.Location = new System.Drawing.Point(6, 19);
            this.GdwCidade.MultiSelect = false;
            this.GdwCidade.Name = "GdwCidade";
            this.GdwCidade.Size = new System.Drawing.Size(568, 88);
            this.GdwCidade.TabIndex = 2;
            this.GdwCidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GdwCidade_CellContentClick);
            this.GdwCidade.Click += new System.EventHandler(this.GdwCidade_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(15, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 61);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Painel de controle";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(298, 32);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 23);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(428, 32);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(122, 23);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Text = "INCLUIR";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(156, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(28, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "EDITAR";
            this.toolTip1.SetToolTip(this.btnEditar, "Comece por aqui.");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // GbxRegistro
            // 
            this.GbxRegistro.Controls.Add(this.cboCidade);
            this.GbxRegistro.Controls.Add(this.CboEstado);
            this.GbxRegistro.Controls.Add(this.chkAtivo);
            this.GbxRegistro.Controls.Add(this.txtDataCadastro);
            this.GbxRegistro.Controls.Add(this.label5);
            this.GbxRegistro.Controls.Add(this.txtRazao);
            this.GbxRegistro.Controls.Add(this.label4);
            this.GbxRegistro.Controls.Add(this.txtFantasia);
            this.GbxRegistro.Controls.Add(this.label3);
            this.GbxRegistro.Controls.Add(this.txtCpfCnpj);
            this.GbxRegistro.Controls.Add(this.LblId);
            this.GbxRegistro.Controls.Add(this.txtClienteId);
            this.GbxRegistro.Controls.Add(this.TxtCodigoIbge);
            this.GbxRegistro.Controls.Add(this.txtEmail);
            this.GbxRegistro.Controls.Add(this.label2);
            this.GbxRegistro.Enabled = false;
            this.GbxRegistro.Location = new System.Drawing.Point(15, 41);
            this.GbxRegistro.Name = "GbxRegistro";
            this.GbxRegistro.Size = new System.Drawing.Size(580, 183);
            this.GbxRegistro.TabIndex = 20;
            this.GbxRegistro.TabStop = false;
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(95, 35);
            this.cboCidade.MaxLength = 50;
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(258, 21);
            this.cboCidade.TabIndex = 17;
            // 
            // CboEstado
            // 
            this.CboEstado.AutoSize = true;
            this.CboEstado.Location = new System.Drawing.Point(95, 19);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(47, 13);
            this.CboEstado.TabIndex = 16;
            this.CboEstado.Text = "CIDADE";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(503, 143);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(58, 17);
            this.chkAtivo.TabIndex = 15;
            this.chkAtivo.Text = "ATIVO";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(359, 140);
            this.txtDataCadastro.MaxLength = 10;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(136, 20);
            this.txtDataCadastro.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DATA CADASTRO";
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(286, 85);
            this.txtRazao.MaxLength = 50;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(275, 20);
            this.txtRazao.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RAZAO SOCIAL";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(6, 85);
            this.txtFantasia.MaxLength = 50;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(274, 20);
            this.txtFantasia.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOME FANTASIA";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(359, 36);
            this.txtCpfCnpj.MaxLength = 14;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(202, 20);
            this.txtCpfCnpj.TabIndex = 8;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(3, 20);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(18, 13);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "ID";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(3, 36);
            this.txtClienteId.MaxLength = 6;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(86, 20);
            this.txtClienteId.TabIndex = 3;
            // 
            // TxtCodigoIbge
            // 
            this.TxtCodigoIbge.AutoSize = true;
            this.TxtCodigoIbge.Location = new System.Drawing.Point(356, 19);
            this.TxtCodigoIbge.Name = "TxtCodigoIbge";
            this.TxtCodigoIbge.Size = new System.Drawing.Size(59, 13);
            this.TxtCodigoIbge.TabIndex = 4;
            this.TxtCodigoIbge.Text = "CPF/CNPJ";
            this.TxtCodigoIbge.Click += new System.EventHandler(this.TxtCodigoIbge_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 140);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-MAIL";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(15, 6);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(587, 20);
            this.txtEndPoint.TabIndex = 19;
            this.txtEndPoint.Text = "https://localhost:5001";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 421);
            this.Controls.Add(this.GbxLista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbxRegistro);
            this.Controls.Add(this.txtEndPoint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.Text = "Módulo Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.GbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GdwCidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.GbxRegistro.ResumeLayout(false);
            this.GbxRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox GbxRegistro;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label TxtCodigoIbge;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label CboEstado;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView GdwCidade;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}