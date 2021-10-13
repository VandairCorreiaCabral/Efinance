
namespace EfinanceFront
{
    partial class FrmEstado
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
            this.GbxRegistro = new System.Windows.Forms.GroupBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBacen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIbge = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TxtCodigoIbge = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GdwCidade)).BeginInit();
            this.GbxRegistro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxLista
            // 
            this.GbxLista.Controls.Add(this.GdwCidade);
            this.GbxLista.Enabled = false;
            this.GbxLista.Location = new System.Drawing.Point(12, 186);
            this.GbxLista.Name = "GbxLista";
            this.GbxLista.Size = new System.Drawing.Size(580, 148);
            this.GbxLista.TabIndex = 17;
            this.GbxLista.TabStop = false;
            this.GbxLista.Text = "Lista de estados[UF]";
            // 
            // GdwCidade
            // 
            this.GdwCidade.AllowUserToAddRows = false;
            this.GdwCidade.AllowUserToDeleteRows = false;
            this.GdwCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdwCidade.Location = new System.Drawing.Point(6, 19);
            this.GdwCidade.MultiSelect = false;
            this.GdwCidade.Name = "GdwCidade";
            this.GdwCidade.Size = new System.Drawing.Size(568, 115);
            this.GdwCidade.TabIndex = 0;
            this.GdwCidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GdwCidade_CellContentClick);
            this.GdwCidade.Click += new System.EventHandler(this.GdwCidade_Click);
            // 
            // GbxRegistro
            // 
            this.GbxRegistro.Controls.Add(this.txtPais);
            this.GbxRegistro.Controls.Add(this.label5);
            this.GbxRegistro.Controls.Add(this.txtBacen);
            this.GbxRegistro.Controls.Add(this.label4);
            this.GbxRegistro.Controls.Add(this.txtSigla);
            this.GbxRegistro.Controls.Add(this.label3);
            this.GbxRegistro.Controls.Add(this.txtIbge);
            this.GbxRegistro.Controls.Add(this.LblId);
            this.GbxRegistro.Controls.Add(this.txtId);
            this.GbxRegistro.Controls.Add(this.TxtCodigoIbge);
            this.GbxRegistro.Controls.Add(this.txtEstado);
            this.GbxRegistro.Controls.Add(this.label2);
            this.GbxRegistro.Enabled = false;
            this.GbxRegistro.Location = new System.Drawing.Point(12, 45);
            this.GbxRegistro.Name = "GbxRegistro";
            this.GbxRegistro.Size = new System.Drawing.Size(580, 135);
            this.GbxRegistro.TabIndex = 15;
            this.GbxRegistro.TabStop = false;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(286, 85);
            this.txtPais.MaxLength = 50;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(275, 20);
            this.txtPais.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "NOME PAÍS";
            // 
            // txtBacen
            // 
            this.txtBacen.Location = new System.Drawing.Point(137, 85);
            this.txtBacen.MaxLength = 20;
            this.txtBacen.Name = "txtBacen";
            this.txtBacen.Size = new System.Drawing.Size(137, 20);
            this.txtBacen.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CÓDIGO BACEN";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(32, 85);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(83, 20);
            this.txtSigla.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SIGLA";
            // 
            // txtIbge
            // 
            this.txtIbge.Location = new System.Drawing.Point(137, 36);
            this.txtIbge.MaxLength = 2;
            this.txtIbge.Name = "txtIbge";
            this.txtIbge.Size = new System.Drawing.Size(137, 20);
            this.txtIbge.TabIndex = 8;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(29, 20);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(18, 13);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(29, 36);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(86, 20);
            this.txtId.TabIndex = 3;
            // 
            // TxtCodigoIbge
            // 
            this.TxtCodigoIbge.AutoSize = true;
            this.TxtCodigoIbge.Location = new System.Drawing.Point(134, 19);
            this.TxtCodigoIbge.Name = "TxtCodigoIbge";
            this.TxtCodigoIbge.Size = new System.Drawing.Size(77, 13);
            this.TxtCodigoIbge.TabIndex = 4;
            this.TxtCodigoIbge.Text = "CÓDIGO IBGE";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(286, 36);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(275, 20);
            this.txtEstado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME DO ESTADO";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(12, 10);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.ReadOnly = true;
            this.txtEndPoint.Size = new System.Drawing.Size(580, 20);
            this.txtEndPoint.TabIndex = 14;
            this.txtEndPoint.Text = "https://localhost:5001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(12, 340);
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
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // FrmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbxLista);
            this.Controls.Add(this.GbxRegistro);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstado";
            this.Text = "Módulo Estado";
            this.GbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GdwCidade)).EndInit();
            this.GbxRegistro.ResumeLayout(false);
            this.GbxRegistro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxLista;
        private System.Windows.Forms.GroupBox GbxRegistro;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIbge;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label TxtCodigoIbge;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView GdwCidade;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}