namespace uzun_kısa_kenarhesaplama
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUzun = new System.Windows.Forms.Label();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblçevre = new System.Windows.Forms.Label();
            this.lblalan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "kısa kenar";
            // 
            // lblUzun
            // 
            this.lblUzun.AutoSize = true;
            this.lblUzun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzun.Location = new System.Drawing.Point(11, 75);
            this.lblUzun.Name = "lblUzun";
            this.lblUzun.Size = new System.Drawing.Size(79, 17);
            this.lblUzun.TabIndex = 1;
            this.lblUzun.Text = "uzun kenar";
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(96, 36);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(100, 20);
            this.txtKenar1.TabIndex = 2;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(96, 72);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(100, 20);
            this.txtKenar2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(28, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alan ve çevre hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblçevre
            // 
            this.lblçevre.AutoSize = true;
            this.lblçevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblçevre.Location = new System.Drawing.Point(28, 173);
            this.lblçevre.Name = "lblçevre";
            this.lblçevre.Size = new System.Drawing.Size(43, 17);
            this.lblçevre.TabIndex = 5;
            this.lblçevre.Text = "çevre";
            // 
            // lblalan
            // 
            this.lblalan.AutoSize = true;
            this.lblalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblalan.Location = new System.Drawing.Point(28, 220);
            this.lblalan.Name = "lblalan";
            this.lblalan.Size = new System.Drawing.Size(35, 17);
            this.lblalan.TabIndex = 6;
            this.lblalan.Text = "alan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 277);
            this.Controls.Add(this.lblalan);
            this.Controls.Add(this.lblçevre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKenar2);
            this.Controls.Add(this.txtKenar1);
            this.Controls.Add(this.lblUzun);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUzun;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblçevre;
        private System.Windows.Forms.Label lblalan;
    }
}

