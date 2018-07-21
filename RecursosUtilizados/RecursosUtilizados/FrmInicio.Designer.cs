namespace RecursosUtilizados
{
    partial class FrmInicio
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
            this.lblPessoasFisicas = new System.Windows.Forms.Label();
            this.dgvPessoasFisicas = new System.Windows.Forms.DataGridView();
            this.dgvPessoasJuridicas = new System.Windows.Forms.DataGridView();
            this.lblPessoasJuridicas = new System.Windows.Forms.Label();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.lblPessoas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasFisicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasJuridicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPessoasFisicas
            // 
            this.lblPessoasFisicas.AutoSize = true;
            this.lblPessoasFisicas.Font = new System.Drawing.Font("Ebrima", 16F);
            this.lblPessoasFisicas.Location = new System.Drawing.Point(31, 27);
            this.lblPessoasFisicas.Name = "lblPessoasFisicas";
            this.lblPessoasFisicas.Size = new System.Drawing.Size(154, 30);
            this.lblPessoasFisicas.TabIndex = 0;
            this.lblPessoasFisicas.Text = "Pessoas Físicas";
            // 
            // dgvPessoasFisicas
            // 
            this.dgvPessoasFisicas.AllowUserToAddRows = false;
            this.dgvPessoasFisicas.AllowUserToDeleteRows = false;
            this.dgvPessoasFisicas.AllowUserToOrderColumns = true;
            this.dgvPessoasFisicas.AllowUserToResizeColumns = false;
            this.dgvPessoasFisicas.AllowUserToResizeRows = false;
            this.dgvPessoasFisicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPessoasFisicas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPessoasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoasFisicas.Location = new System.Drawing.Point(36, 60);
            this.dgvPessoasFisicas.Name = "dgvPessoasFisicas";
            this.dgvPessoasFisicas.Size = new System.Drawing.Size(859, 187);
            this.dgvPessoasFisicas.TabIndex = 1;
            this.dgvPessoasFisicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoasFisicas_CellClick);
            // 
            // dgvPessoasJuridicas
            // 
            this.dgvPessoasJuridicas.AllowUserToAddRows = false;
            this.dgvPessoasJuridicas.AllowUserToDeleteRows = false;
            this.dgvPessoasJuridicas.AllowUserToOrderColumns = true;
            this.dgvPessoasJuridicas.AllowUserToResizeColumns = false;
            this.dgvPessoasJuridicas.AllowUserToResizeRows = false;
            this.dgvPessoasJuridicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPessoasJuridicas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPessoasJuridicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoasJuridicas.Location = new System.Drawing.Point(36, 294);
            this.dgvPessoasJuridicas.Name = "dgvPessoasJuridicas";
            this.dgvPessoasJuridicas.Size = new System.Drawing.Size(859, 187);
            this.dgvPessoasJuridicas.TabIndex = 3;
            this.dgvPessoasJuridicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoasJuridicas_CellClick);
            // 
            // lblPessoasJuridicas
            // 
            this.lblPessoasJuridicas.AutoSize = true;
            this.lblPessoasJuridicas.Font = new System.Drawing.Font("Ebrima", 16F);
            this.lblPessoasJuridicas.Location = new System.Drawing.Point(31, 261);
            this.lblPessoasJuridicas.Name = "lblPessoasJuridicas";
            this.lblPessoasJuridicas.Size = new System.Drawing.Size(175, 30);
            this.lblPessoasJuridicas.TabIndex = 2;
            this.lblPessoasJuridicas.Text = "Pessoas Jurídicas";
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.AllowUserToOrderColumns = true;
            this.dgvPessoas.AllowUserToResizeColumns = false;
            this.dgvPessoas.AllowUserToResizeRows = false;
            this.dgvPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPessoas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(36, 528);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(859, 187);
            this.dgvPessoas.TabIndex = 5;
            this.dgvPessoas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellClick);
            // 
            // lblPessoas
            // 
            this.lblPessoas.AutoSize = true;
            this.lblPessoas.Font = new System.Drawing.Font("Ebrima", 16F);
            this.lblPessoas.Location = new System.Drawing.Point(31, 495);
            this.lblPessoas.Name = "lblPessoas";
            this.lblPessoas.Size = new System.Drawing.Size(88, 30);
            this.lblPessoas.TabIndex = 4;
            this.lblPessoas.Text = "Pessoas";
            // 
            // FrmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 741);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.lblPessoas);
            this.Controls.Add(this.dgvPessoasJuridicas);
            this.Controls.Add(this.lblPessoasJuridicas);
            this.Controls.Add(this.dgvPessoasFisicas);
            this.Controls.Add(this.lblPessoasFisicas);
            this.Font = new System.Drawing.Font("Ebrima", 14F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seminario Info TI";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasFisicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoasJuridicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPessoasFisicas;
        private System.Windows.Forms.DataGridView dgvPessoasFisicas;
        private System.Windows.Forms.DataGridView dgvPessoasJuridicas;
        private System.Windows.Forms.Label lblPessoasJuridicas;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Label lblPessoas;
    }
}

