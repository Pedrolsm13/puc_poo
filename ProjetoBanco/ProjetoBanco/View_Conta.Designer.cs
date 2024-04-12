namespace ProjetoBanco
{
    partial class View_Conta
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
            this.boxnumero = new System.Windows.Forms.TextBox();
            this.boxtitulo = new System.Windows.Forms.TextBox();
            this.boxsaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxnumero
            // 
            this.boxnumero.Location = new System.Drawing.Point(136, 141);
            this.boxnumero.Name = "boxnumero";
            this.boxnumero.Size = new System.Drawing.Size(100, 20);
            this.boxnumero.TabIndex = 21;
            this.boxnumero.Text = "0";
            this.boxnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxtitulo
            // 
            this.boxtitulo.Location = new System.Drawing.Point(290, 141);
            this.boxtitulo.Name = "boxtitulo";
            this.boxtitulo.Size = new System.Drawing.Size(100, 20);
            this.boxtitulo.TabIndex = 20;
            this.boxtitulo.Text = "*";
            this.boxtitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxsaldo
            // 
            this.boxsaldo.Location = new System.Drawing.Point(438, 141);
            this.boxsaldo.Name = "boxsaldo";
            this.boxsaldo.Size = new System.Drawing.Size(100, 20);
            this.boxsaldo.TabIndex = 19;
            this.boxsaldo.Text = "0";
            this.boxsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // View_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 308);
            this.Controls.Add(this.boxnumero);
            this.Controls.Add(this.boxtitulo);
            this.Controls.Add(this.boxsaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "View_Conta";
            this.Text = "View_Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxnumero;
        private System.Windows.Forms.TextBox boxtitulo;
        private System.Windows.Forms.TextBox boxsaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}