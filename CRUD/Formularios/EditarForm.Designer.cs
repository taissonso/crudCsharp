namespace CRUD.Formularios
{
    partial class EditarForm
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
            this.gridMostrar = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvarAlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMostrar
            // 
            this.gridMostrar.AllowUserToAddRows = false;
            this.gridMostrar.AllowUserToDeleteRows = false;
            this.gridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostrar.Location = new System.Drawing.Point(2, 393);
            this.gridMostrar.Name = "gridMostrar";
            this.gridMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMostrar.Size = new System.Drawing.Size(979, 267);
            this.gridMostrar.TabIndex = 33;
            this.gridMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMostrar_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 20);
            this.txtId.TabIndex = 39;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(319, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(138, 46);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(170, 23);
            this.txtCpf.TabIndex = 34;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(380, 47);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(566, 23);
            this.txtNome.TabIndex = 35;
            this.txtNome.Tag = "caixaNome";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(776, 104);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(170, 23);
            this.txtCidade.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(706, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 110);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(619, 106);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumero.Size = new System.Drawing.Size(81, 23);
            this.txtNumero.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 106);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Rua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Endereço";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(138, 103);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRua.Size = new System.Drawing.Size(401, 23);
            this.txtRua.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 57;
            this.label8.Text = "Pedido";
            // 
            // txtPedido
            // 
            this.txtPedido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(138, 163);
            this.txtPedido.MaxLength = 10;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(142, 23);
            this.txtPedido.TabIndex = 47;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(322, 174);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(347, 112);
            this.txtDescricao.TabIndex = 51;
            this.txtDescricao.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 18);
            this.label14.TabIndex = 56;
            this.label14.Text = "Descrição";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(138, 261);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 23);
            this.txtValor.TabIndex = 50;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 54;
            this.label12.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(138, 198);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(142, 23);
            this.txtQuantidade.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(138, 232);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 23);
            this.txtCodigo.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Nº do Pedido";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Image = global::CRUD.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(709, 322);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 40);
            this.btnVoltar.TabIndex = 61;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::CRUD.Properties.Resources.exit;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(509, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 40);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Image = global::CRUD.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(309, 322);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(170, 40);
            this.btnExcluir.TabIndex = 59;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnSalvarAlt
            // 
            this.btnSalvarAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarAlt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlt.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarAlt.Image = global::CRUD.Properties.Resources.edit;
            this.btnSalvarAlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAlt.Location = new System.Drawing.Point(109, 322);
            this.btnSalvarAlt.Name = "btnSalvarAlt";
            this.btnSalvarAlt.Size = new System.Drawing.Size(170, 40);
            this.btnSalvarAlt.TabIndex = 58;
            this.btnSalvarAlt.Text = "Salvar";
            this.btnSalvarAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarAlt.UseVisualStyleBackColor = false;
            this.btnSalvarAlt.Click += new System.EventHandler(this.BtnSalvarAlt_Click);
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvarAlt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gridMostrar);
            this.Name = "EditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMostrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalvarAlt;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
    }
}