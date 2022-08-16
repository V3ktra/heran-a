namespace herança2
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
            this.btn_prof = new System.Windows.Forms.Button();
            this.btn_aluno = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_prof
            // 
            this.btn_prof.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prof.Location = new System.Drawing.Point(137, 172);
            this.btn_prof.Name = "btn_prof";
            this.btn_prof.Size = new System.Drawing.Size(236, 70);
            this.btn_prof.TabIndex = 0;
            this.btn_prof.Text = "Cadastrar Professor";
            this.btn_prof.UseVisualStyleBackColor = true;
            // 
            // btn_aluno
            // 
            this.btn_aluno.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aluno.Location = new System.Drawing.Point(396, 172);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(236, 70);
            this.btn_aluno.TabIndex = 1;
            this.btn_aluno.Text = "Cadastrar Aluno";
            this.btn_aluno.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(613, 357);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(161, 70);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_aluno);
            this.Controls.Add(this.btn_prof);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prof;
        private System.Windows.Forms.Button btn_aluno;
        private System.Windows.Forms.Button btn_sair;
    }
}

