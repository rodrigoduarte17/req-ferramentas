namespace ReqFerramentas
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnRequisicoes = new System.Windows.Forms.Button();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.Location = new System.Drawing.Point(43, 201);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(163, 72);
            this.btnColaboradores.TabIndex = 1;
            this.btnColaboradores.Text = "Gerir Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            // 
            // btnRequisicoes
            // 
            this.btnRequisicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisicoes.Location = new System.Drawing.Point(300, 201);
            this.btnRequisicoes.Name = "btnRequisicoes";
            this.btnRequisicoes.Size = new System.Drawing.Size(163, 72);
            this.btnRequisicoes.TabIndex = 2;
            this.btnRequisicoes.Text = "Gerir Requisições";
            this.btnRequisicoes.UseVisualStyleBackColor = true;
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerramentas.Location = new System.Drawing.Point(566, 201);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Size = new System.Drawing.Size(163, 72);
            this.btnFerramentas.TabIndex = 3;
            this.btnFerramentas.Text = "Gerir Ferramentas";
            this.btnFerramentas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFerramentas);
            this.Controls.Add(this.btnRequisicoes);
            this.Controls.Add(this.btnColaboradores);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnRequisicoes;
        private System.Windows.Forms.Button btnFerramentas;
    }
}

