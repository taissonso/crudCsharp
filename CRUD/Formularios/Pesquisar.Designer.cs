namespace CRUD.Formularios
{
    partial class Pesquisar
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
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMostrar
            // 
            this.gridMostrar.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.gridMostrar.AllowUserToAddRows = false;
            this.gridMostrar.AllowUserToDeleteRows = false;
            this.gridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostrar.Location = new System.Drawing.Point(2, 85);
            this.gridMostrar.Name = "gridMostrar";
            this.gridMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMostrar.Size = new System.Drawing.Size(979, 573);
            this.gridMostrar.TabIndex = 34;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::CRUD.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(70, 20);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 40);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gridMostrar);
            this.Name = "Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMostrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}