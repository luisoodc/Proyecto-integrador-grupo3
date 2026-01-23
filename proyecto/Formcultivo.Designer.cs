namespace proyecto
{
    partial class Formcultivo
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
            this.button1 = new System.Windows.Forms.Button();
            this.imgfondojuego1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgfondojuego1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::proyecto.Properties.Resources.btnflecha;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 52);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // imgfondojuego1
            // 
            this.imgfondojuego1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgfondojuego1.Image = global::proyecto.Properties.Resources._7N;
            this.imgfondojuego1.Location = new System.Drawing.Point(0, 0);
            this.imgfondojuego1.Name = "imgfondojuego1";
            this.imgfondojuego1.Size = new System.Drawing.Size(800, 450);
            this.imgfondojuego1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgfondojuego1.TabIndex = 2;
            this.imgfondojuego1.TabStop = false;
            // 
            // Formcultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgfondojuego1);
            this.Name = "Formcultivo";
            this.Text = "Formcultivo";
            ((System.ComponentModel.ISupportInitialize)(this.imgfondojuego1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgfondojuego1;
        private System.Windows.Forms.Button button1;
    }
}