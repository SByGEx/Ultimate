namespace Proyecto_Real.Ezequiel
{
    partial class EMTi
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
            this.rbL1 = new System.Windows.Forms.RadioButton();
            this.rbJugar = new System.Windows.Forms.RadioButton();
            this.rbR1 = new System.Windows.Forms.RadioButton();
            this.rbL11 = new System.Windows.Forms.RadioButton();
            this.rbL12 = new System.Windows.Forms.RadioButton();
            this.rbR11 = new System.Windows.Forms.RadioButton();
            this.rbR12 = new System.Windows.Forms.RadioButton();
            this.lPlay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbL1
            // 
            this.rbL1.AutoSize = true;
            this.rbL1.Location = new System.Drawing.Point(250, 94);
            this.rbL1.Name = "rbL1";
            this.rbL1.Size = new System.Drawing.Size(14, 13);
            this.rbL1.TabIndex = 0;
            this.rbL1.TabStop = true;
            this.rbL1.UseVisualStyleBackColor = true;
            this.rbL1.Visible = false;
            this.rbL1.CheckedChanged += new System.EventHandler(this.rbL1_CheckedChanged);
            // 
            // rbJugar
            // 
            this.rbJugar.AutoSize = true;
            this.rbJugar.Location = new System.Drawing.Point(310, 35);
            this.rbJugar.Name = "rbJugar";
            this.rbJugar.Size = new System.Drawing.Size(14, 13);
            this.rbJugar.TabIndex = 1;
            this.rbJugar.UseVisualStyleBackColor = true;
            this.rbJugar.CheckedChanged += new System.EventHandler(this.rbJugar_CheckedChanged);
            // 
            // rbR1
            // 
            this.rbR1.AutoSize = true;
            this.rbR1.Location = new System.Drawing.Point(381, 94);
            this.rbR1.Name = "rbR1";
            this.rbR1.Size = new System.Drawing.Size(14, 13);
            this.rbR1.TabIndex = 2;
            this.rbR1.TabStop = true;
            this.rbR1.UseVisualStyleBackColor = true;
            this.rbR1.Visible = false;
            this.rbR1.CheckedChanged += new System.EventHandler(this.rbR1_CheckedChanged);
            // 
            // rbL11
            // 
            this.rbL11.AutoSize = true;
            this.rbL11.Location = new System.Drawing.Point(213, 149);
            this.rbL11.Name = "rbL11";
            this.rbL11.Size = new System.Drawing.Size(14, 13);
            this.rbL11.TabIndex = 3;
            this.rbL11.TabStop = true;
            this.rbL11.UseVisualStyleBackColor = true;
            this.rbL11.Visible = false;
            this.rbL11.CheckedChanged += new System.EventHandler(this.rbL11_CheckedChanged);
            // 
            // rbL12
            // 
            this.rbL12.AutoSize = true;
            this.rbL12.Location = new System.Drawing.Point(283, 149);
            this.rbL12.Name = "rbL12";
            this.rbL12.Size = new System.Drawing.Size(14, 13);
            this.rbL12.TabIndex = 4;
            this.rbL12.TabStop = true;
            this.rbL12.UseVisualStyleBackColor = true;
            this.rbL12.Visible = false;
            this.rbL12.CheckedChanged += new System.EventHandler(this.rbL12_CheckedChanged);
            // 
            // rbR11
            // 
            this.rbR11.AutoSize = true;
            this.rbR11.Location = new System.Drawing.Point(349, 149);
            this.rbR11.Name = "rbR11";
            this.rbR11.Size = new System.Drawing.Size(14, 13);
            this.rbR11.TabIndex = 5;
            this.rbR11.TabStop = true;
            this.rbR11.UseVisualStyleBackColor = true;
            this.rbR11.Visible = false;
            this.rbR11.CheckedChanged += new System.EventHandler(this.rbR11_CheckedChanged);
            // 
            // rbR12
            // 
            this.rbR12.AutoSize = true;
            this.rbR12.Location = new System.Drawing.Point(424, 149);
            this.rbR12.Name = "rbR12";
            this.rbR12.Size = new System.Drawing.Size(14, 13);
            this.rbR12.TabIndex = 6;
            this.rbR12.TabStop = true;
            this.rbR12.UseVisualStyleBackColor = true;
            this.rbR12.Visible = false;
            this.rbR12.CheckedChanged += new System.EventHandler(this.rbR12_CheckedChanged);
            // 
            // lPlay
            // 
            this.lPlay.AutoSize = true;
            this.lPlay.BackColor = System.Drawing.Color.Transparent;
            this.lPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lPlay.Location = new System.Drawing.Point(330, 35);
            this.lPlay.Name = "lPlay";
            this.lPlay.Size = new System.Drawing.Size(33, 13);
            this.lPlay.TabIndex = 7;
            this.lPlay.Text = "Jugar";
            this.lPlay.Click += new System.EventHandler(this.lPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "result";
            this.label1.Visible = false;
            // 
            // EMTi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPlay);
            this.Controls.Add(this.rbR12);
            this.Controls.Add(this.rbR11);
            this.Controls.Add(this.rbL12);
            this.Controls.Add(this.rbL11);
            this.Controls.Add(this.rbR1);
            this.Controls.Add(this.rbJugar);
            this.Controls.Add(this.rbL1);
            this.Name = "EMTi";
            this.Text = "EMTi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbL1;
        private System.Windows.Forms.RadioButton rbJugar;
        private System.Windows.Forms.RadioButton rbR1;
        private System.Windows.Forms.RadioButton rbL11;
        private System.Windows.Forms.RadioButton rbL12;
        private System.Windows.Forms.RadioButton rbR11;
        private System.Windows.Forms.RadioButton rbR12;
        private System.Windows.Forms.Label lPlay;
        private System.Windows.Forms.Label label1;
    }
}