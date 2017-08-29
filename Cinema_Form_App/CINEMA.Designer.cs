namespace Cinema_Form_App
{
    partial class CINEMA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CINEMA));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.first_afisha = new System.Windows.Forms.PictureBox();
            this.second_afisha = new System.Windows.Forms.PictureBox();
            this.third_afisha = new System.Windows.Forms.PictureBox();
            this.hall1 = new System.Windows.Forms.Button();
            this.hall2 = new System.Windows.Forms.Button();
            this.hall3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.first_afisha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_afisha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.third_afisha)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // first_afisha
            // 
            this.first_afisha.Image = ((System.Drawing.Image)(resources.GetObject("first_afisha.Image")));
            this.first_afisha.Location = new System.Drawing.Point(12, 59);
            this.first_afisha.Name = "first_afisha";
            this.first_afisha.Size = new System.Drawing.Size(241, 296);
            this.first_afisha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_afisha.TabIndex = 0;
            this.first_afisha.TabStop = false;
            // 
            // second_afisha
            // 
            this.second_afisha.Image = ((System.Drawing.Image)(resources.GetObject("second_afisha.Image")));
            this.second_afisha.Location = new System.Drawing.Point(287, 59);
            this.second_afisha.Name = "second_afisha";
            this.second_afisha.Size = new System.Drawing.Size(237, 296);
            this.second_afisha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.second_afisha.TabIndex = 1;
            this.second_afisha.TabStop = false;
            // 
            // third_afisha
            // 
            this.third_afisha.Image = ((System.Drawing.Image)(resources.GetObject("third_afisha.Image")));
            this.third_afisha.Location = new System.Drawing.Point(552, 59);
            this.third_afisha.Name = "third_afisha";
            this.third_afisha.Size = new System.Drawing.Size(241, 296);
            this.third_afisha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.third_afisha.TabIndex = 2;
            this.third_afisha.TabStop = false;
            // 
            // hall1
            // 
            this.hall1.Location = new System.Drawing.Point(64, 361);
            this.hall1.Name = "hall1";
            this.hall1.Size = new System.Drawing.Size(137, 57);
            this.hall1.TabIndex = 3;
            this.hall1.Text = "Hall-1";
            this.hall1.UseVisualStyleBackColor = true;
            this.hall1.Click += new System.EventHandler(this.hall1_Click);
            // 
            // hall2
            // 
            this.hall2.Location = new System.Drawing.Point(336, 361);
            this.hall2.Name = "hall2";
            this.hall2.Size = new System.Drawing.Size(137, 57);
            this.hall2.TabIndex = 4;
            this.hall2.Text = "Hall-2";
            this.hall2.UseVisualStyleBackColor = true;
            this.hall2.Click += new System.EventHandler(this.hall2_Click);
            // 
            // hall3
            // 
            this.hall3.Location = new System.Drawing.Point(609, 361);
            this.hall3.Name = "hall3";
            this.hall3.Size = new System.Drawing.Size(137, 57);
            this.hall3.TabIndex = 5;
            this.hall3.Text = "Hall-3";
            this.hall3.UseVisualStyleBackColor = true;
            this.hall3.Click += new System.EventHandler(this.hall3_Click);
            // 
            // CINEMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 449);
            this.Controls.Add(this.hall3);
            this.Controls.Add(this.hall2);
            this.Controls.Add(this.hall1);
            this.Controls.Add(this.third_afisha);
            this.Controls.Add(this.second_afisha);
            this.Controls.Add(this.first_afisha);
            this.Name = "CINEMA";
            this.Text = "CINEMA";
            ((System.ComponentModel.ISupportInitialize)(this.first_afisha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_afisha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.third_afisha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox first_afisha;
        private System.Windows.Forms.PictureBox second_afisha;
        private System.Windows.Forms.PictureBox third_afisha;
        private System.Windows.Forms.Button hall1;
        private System.Windows.Forms.Button hall2;
        private System.Windows.Forms.Button hall3;
    }
}

