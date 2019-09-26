namespace CRUD
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(238, 160);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(401, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "caixaNome";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(238, 265);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRua.Size = new System.Drawing.Size(401, 20);
            this.txtRua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(177, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 264);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(238, 307);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumero.Size = new System.Drawing.Size(102, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 307);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(425, 307);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(214, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(113, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nº do Pedido";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(238, 452);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(165, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Código";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(238, 492);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(142, 20);
            this.txtQuantidade.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(129, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Quantidade";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(238, 532);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(177, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Valor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(422, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(425, 438);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(350, 112);
            this.txtDescricao.TabIndex = 9;
            this.txtDescricao.Text = "";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(238, 415);
            this.txtPedido.MaxLength = 10;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(142, 20);
            this.txtPedido.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(159, 91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 20);
            this.txtId.TabIndex = 33;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Pedido";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(238, 127);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(170, 20);
            this.txtCpf.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::CRUD.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(706, 22);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(170, 40);
            this.btnSair.TabIndex = 34;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditar.BackgroundImage = global::CRUD.Properties.Resources.edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(306, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(170, 40);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.botaoPesquisar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisar.ForeColor = System.Drawing.Color.Black;
            this.botaoPesquisar.Image = global::CRUD.Properties.Resources.listar;
            this.botaoPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPesquisar.Location = new System.Drawing.Point(506, 22);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(170, 40);
            this.botaoPesquisar.TabIndex = 11;
            this.botaoPesquisar.Text = "Listar";
            this.botaoPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoPesquisar.UseVisualStyleBackColor = false;
            this.botaoPesquisar.Click += new System.EventHandler(this.BotaoPesquisar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvar.BackgroundImage = global::CRUD.Properties.Resources.save;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Image = global::CRUD.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(106, 22);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 40);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button botaoPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCpf;
    }
}

