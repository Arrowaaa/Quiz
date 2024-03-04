namespace Quiz
{
    partial class lblQuestion
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblQuestionn = new System.Windows.Forms.Label();
            this.btnnNext_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(57, 168);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Madri";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(57, 222);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Berlim";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(57, 275);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Paris";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(57, 326);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Londres";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // lblQuestionn
            // 
            this.lblQuestionn.AutoSize = true;
            this.lblQuestionn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuestionn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestionn.Location = new System.Drawing.Point(151, 60);
            this.lblQuestionn.Name = "lblQuestionn";
            this.lblQuestionn.Size = new System.Drawing.Size(345, 31);
            this.lblQuestionn.TabIndex = 4;
            this.lblQuestionn.Text = "Qual é a capital da França?";
            // 
            // btnnNext_Click
            // 
            this.btnnNext_Click.Location = new System.Drawing.Point(525, 384);
            this.btnnNext_Click.Name = "btnnNext_Click";
            this.btnnNext_Click.Size = new System.Drawing.Size(75, 23);
            this.btnnNext_Click.TabIndex = 5;
            this.btnnNext_Click.Text = "NEXT";
            this.btnnNext_Click.UseVisualStyleBackColor = true;
            this.btnnNext_Click.Click += new System.EventHandler(this.btnnNext_Click_Click);
            // 
            // lblQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources.stock_vector_neon_quiz_sign_vector_design_template_quiz_neon_frame_light_banner_design_element_colorful_modern_17228835881;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnnNext_Click);
            this.Controls.Add(this.lblQuestionn);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "lblQuestion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblQuestionn;
        private System.Windows.Forms.Button btnnNext_Click;
    }
}

