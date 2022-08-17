namespace poo_classe_com_herança
{
    partial class Form2
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
            this.btncadastrar1 = new System.Windows.Forms.Button();
            this.txtnomeprof = new System.Windows.Forms.TextBox();
            this.txtidadeprof = new System.Windows.Forms.TextBox();
            this.txttitulacao = new System.Windows.Forms.TextBox();
            this.btnexibir1 = new System.Windows.Forms.Button();
            this.btnvoltar1 = new System.Windows.Forms.Button();
            this.lbltitulacao = new System.Windows.Forms.Label();
            this.lblidadeprof = new System.Windows.Forms.Label();
            this.lblnomeprof = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncadastrar1
            // 
            this.btncadastrar1.Location = new System.Drawing.Point(151, 311);
            this.btncadastrar1.Name = "btncadastrar1";
            this.btncadastrar1.Size = new System.Drawing.Size(129, 39);
            this.btncadastrar1.TabIndex = 0;
            this.btncadastrar1.Text = "Cadastar";
            this.btncadastrar1.UseVisualStyleBackColor = true;
            // 
            // txtnomeprof
            // 
            this.txtnomeprof.Location = new System.Drawing.Point(150, 134);
            this.txtnomeprof.Name = "txtnomeprof";
            this.txtnomeprof.Size = new System.Drawing.Size(129, 20);
            this.txtnomeprof.TabIndex = 1;
            // 
            // txtidadeprof
            // 
            this.txtidadeprof.Location = new System.Drawing.Point(150, 181);
            this.txtidadeprof.Name = "txtidadeprof";
            this.txtidadeprof.Size = new System.Drawing.Size(129, 20);
            this.txtidadeprof.TabIndex = 2;
            // 
            // txttitulacao
            // 
            this.txttitulacao.Location = new System.Drawing.Point(150, 227);
            this.txttitulacao.Name = "txttitulacao";
            this.txttitulacao.Size = new System.Drawing.Size(129, 20);
            this.txttitulacao.TabIndex = 3;
            // 
            // btnexibir1
            // 
            this.btnexibir1.Location = new System.Drawing.Point(334, 311);
            this.btnexibir1.Name = "btnexibir1";
            this.btnexibir1.Size = new System.Drawing.Size(123, 39);
            this.btnexibir1.TabIndex = 4;
            this.btnexibir1.Text = "Exibir";
            this.btnexibir1.UseVisualStyleBackColor = true;
            // 
            // btnvoltar1
            // 
            this.btnvoltar1.Location = new System.Drawing.Point(530, 310);
            this.btnvoltar1.Name = "btnvoltar1";
            this.btnvoltar1.Size = new System.Drawing.Size(129, 40);
            this.btnvoltar1.TabIndex = 5;
            this.btnvoltar1.Text = "Voltar";
            this.btnvoltar1.UseVisualStyleBackColor = true;
            // 
            // lbltitulacao
            // 
            this.lbltitulacao.AutoSize = true;
            this.lbltitulacao.Location = new System.Drawing.Point(90, 227);
            this.lbltitulacao.Name = "lbltitulacao";
            this.lbltitulacao.Size = new System.Drawing.Size(54, 13);
            this.lbltitulacao.TabIndex = 6;
            this.lbltitulacao.Text = "Titulação:";
            // 
            // lblidadeprof
            // 
            this.lblidadeprof.AutoSize = true;
            this.lblidadeprof.Location = new System.Drawing.Point(91, 181);
            this.lblidadeprof.Name = "lblidadeprof";
            this.lblidadeprof.Size = new System.Drawing.Size(37, 13);
            this.lblidadeprof.TabIndex = 7;
            this.lblidadeprof.Text = "Idade:";
            // 
            // lblnomeprof
            // 
            this.lblnomeprof.AutoSize = true;
            this.lblnomeprof.Location = new System.Drawing.Point(91, 134);
            this.lblnomeprof.Name = "lblnomeprof";
            this.lblnomeprof.Size = new System.Drawing.Size(38, 13);
            this.lblnomeprof.TabIndex = 8;
            this.lblnomeprof.Text = "Nome:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnomeprof);
            this.Controls.Add(this.lblidadeprof);
            this.Controls.Add(this.lbltitulacao);
            this.Controls.Add(this.btnvoltar1);
            this.Controls.Add(this.btnexibir1);
            this.Controls.Add(this.txttitulacao);
            this.Controls.Add(this.txtidadeprof);
            this.Controls.Add(this.txtnomeprof);
            this.Controls.Add(this.btncadastrar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar1;
        private System.Windows.Forms.TextBox txtnomeprof;
        private System.Windows.Forms.TextBox txtidadeprof;
        private System.Windows.Forms.TextBox txttitulacao;
        private System.Windows.Forms.Button btnexibir1;
        private System.Windows.Forms.Button btnvoltar1;
        private System.Windows.Forms.Label lbltitulacao;
        private System.Windows.Forms.Label lblidadeprof;
        private System.Windows.Forms.Label lblnomeprof;
    }
}