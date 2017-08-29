namespace Cinema_Form_App
{
    partial class Hall_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hall_1));
            this.button1 = new System.Windows.Forms.Button();
            this.ok_duyme = new System.Windows.Forms.Button();
            this.silmek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(187, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ekran";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ok_duyme
            // 
            this.ok_duyme.Location = new System.Drawing.Point(196, 357);
            this.ok_duyme.Name = "ok_duyme";
            this.ok_duyme.Size = new System.Drawing.Size(105, 23);
            this.ok_duyme.TabIndex = 1;
            this.ok_duyme.Text = "OK";
            this.ok_duyme.UseVisualStyleBackColor = true;
            this.ok_duyme.Click += new System.EventHandler(this.ok_duyme_Click);
            // 
            // silmek
            // 
            this.silmek.Location = new System.Drawing.Point(331, 357);
            this.silmek.Name = "silmek";
            this.silmek.Size = new System.Drawing.Size(95, 23);
            this.silmek.TabIndex = 2;
            this.silmek.Text = "silmek";
            this.silmek.UseVisualStyleBackColor = true;
            this.silmek.Click += new System.EventHandler(this.silmek_Click);
            // 
            // Hall_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 392);
            this.Controls.Add(this.silmek);
            this.Controls.Add(this.ok_duyme);
            this.Controls.Add(this.button1);
            this.Name = "Hall_1";
            this.Text = "Hall_1";
            this.Load += new System.EventHandler(this.Hall_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ok_duyme;
        private System.Windows.Forms.Button silmek;
    }
}