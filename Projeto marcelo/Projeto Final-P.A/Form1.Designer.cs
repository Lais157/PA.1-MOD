namespace Projeto_Final_P.A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.Btn_Produtos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cliente.BackgroundImage")));
            this.Btn_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cliente.FlatAppearance.BorderSize = 0;
            this.Btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cliente.Location = new System.Drawing.Point(352, 68);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(79, 83);
            this.Btn_Cliente.TabIndex = 1;
            this.Btn_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // Btn_Produtos
            // 
            this.Btn_Produtos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Produtos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Produtos.BackgroundImage")));
            this.Btn_Produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Produtos.FlatAppearance.BorderSize = 0;
            this.Btn_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Produtos.Location = new System.Drawing.Point(352, 231);
            this.Btn_Produtos.Name = "Btn_Produtos";
            this.Btn_Produtos.Size = new System.Drawing.Size(80, 81);
            this.Btn_Produtos.TabIndex = 2;
            this.Btn_Produtos.UseVisualStyleBackColor = false;
            this.Btn_Produtos.Click += new System.EventHandler(this.Btn_Produtos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(326, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(18, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 231);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Produtos);
            this.Controls.Add(this.Btn_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 399);
            this.MinimumSize = new System.Drawing.Size(485, 399);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cliente;
        private System.Windows.Forms.Button Btn_Produtos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

