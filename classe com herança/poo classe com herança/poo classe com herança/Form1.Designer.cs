namespace poo_classe_com_herança
{
    partial class Form1
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
            this.btnprofessor = new System.Windows.Forms.Button();
            this.btnaluno = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnprofessor
            // 
            this.btnprofessor.Location = new System.Drawing.Point(81, 188);
            this.btnprofessor.Name = "btnprofessor";
            this.btnprofessor.Size = new System.Drawing.Size(162, 49);
            this.btnprofessor.TabIndex = 0;
            this.btnprofessor.Text = "Cadastrar professor";
            this.btnprofessor.UseVisualStyleBackColor = true;
            // 
            // btnaluno
            // 
            this.btnaluno.Location = new System.Drawing.Point(326, 188);
            this.btnaluno.Name = "btnaluno";
            this.btnaluno.Size = new System.Drawing.Size(168, 49);
            this.btnaluno.TabIndex = 1;
            this.btnaluno.Text = "Cadastrar aluno";
            this.btnaluno.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(571, 188);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(154, 49);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnaluno);
            this.Controls.Add(this.btnprofessor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnprofessor;
        private System.Windows.Forms.Button btnaluno;
        private System.Windows.Forms.Button btnsair;
    }
}

