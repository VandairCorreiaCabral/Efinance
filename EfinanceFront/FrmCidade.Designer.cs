
namespace EfinanceFront
{
    partial class FrmCidade
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
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.txtCidadeId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbxRegistro = new System.Windows.Forms.GroupBox();
            this.GbxLista = new System.Windows.Forms.GroupBox();
            this.GdwCidade = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GbxRegistro.SuspendLayout();
            this.GbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GdwCidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(30, 6);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(587, 20);
            this.txtEndPoint.TabIndex = 1;
            this.txtEndPoint.Text = "https://localhost:5001";
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.Location = new System.Drawing.Point(9, 34);
            this.txtCidadeId.MaxLength = 6;
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.ReadOnly = true;
            this.txtCidadeId.Size = new System.Drawing.Size(86, 20);
            this.txtCidadeId.TabIndex = 3;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(9, 18);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(18, 13);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "ID";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(114, 17);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "ESTADO";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(114, 33);
            this.cboEstado.MaxLength = 50;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(258, 21);
            this.cboEstado.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(9, 92);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(532, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CIDADE";
            // 
            // GbxRegistro
            // 
            this.GbxRegistro.Controls.Add(this.cboEstado);
            this.GbxRegistro.Controls.Add(this.LblId);
            this.GbxRegistro.Controls.Add(this.txtCidadeId);
            this.GbxRegistro.Controls.Add(this.lblEstado);
            this.GbxRegistro.Controls.Add(this.txtCidade);
            this.GbxRegistro.Controls.Add(this.label2);
            this.GbxRegistro.Enabled = false;
            this.GbxRegistro.Location = new System.Drawing.Point(30, 41);
            this.GbxRegistro.Name = "GbxRegistro";
            this.GbxRegistro.Size = new System.Drawing.Size(580, 135);
            this.GbxRegistro.TabIndex = 10;
            this.GbxRegistro.TabStop = false;
            // 
            // GbxLista
            // 
            this.GbxLista.Controls.Add(this.GdwCidade);
            this.GbxLista.Enabled = false;
            this.GbxLista.Location = new System.Drawing.Point(30, 182);
            this.GbxLista.Name = "GbxLista";
            this.GbxLista.Size = new System.Drawing.Size(580, 118);
            this.GbxLista.TabIndex = 12;
            this.GbxLista.TabStop = false;
            this.GbxLista.Text = "Lista de cidade";
            // 
            // GdwCidade
            // 
            this.GdwCidade.AllowUserToAddRows = false;
            this.GdwCidade.AllowUserToDeleteRows = false;
            this.GdwCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdwCidade.Location = new System.Drawing.Point(6, 20);
            this.GdwCidade.MultiSelect = false;
            this.GdwCidade.Name = "GdwCidade";
            this.GdwCidade.Size = new System.Drawing.Size(568, 88);
            this.GdwCidade.TabIndex = 1;
            this.GdwCidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GdwCidade_CellContentClick);
            this.GdwCidade.Click += new System.EventHandler(this.GdwCidade_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(30, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 61);
            this.groupBox2.TabIndex = 22;
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
            this.btnIncluir.Click += new System.EventHandler(this.button4_Click);
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
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbxLista);
            this.Controls.Add(this.GbxRegistro);
            this.Controls.Add(this.txtEndPoint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Módulo Cidade";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            this.GbxRegistro.ResumeLayout(false);
            this.GbxRegistro.PerformLayout();
            this.GbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GdwCidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.TextBox txtCidadeId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbxRegistro;
        private System.Windows.Forms.GroupBox GbxLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView GdwCidade;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}