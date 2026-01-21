namespace proyecto
{
    partial class Form11infor
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
            this.pictureBarra = new System.Windows.Forms.PictureBox();
            this.picturedominico = new System.Windows.Forms.PictureBox();
            this.pictureharton = new System.Windows.Forms.PictureBox();
            this.picturemacho = new System.Windows.Forms.PictureBox();
            this.picturemaqueño = new System.Windows.Forms.PictureBox();
            this.irjuego = new System.Windows.Forms.Button();
            this.panelbarraganete = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelmaqueño = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelmacho = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.paneldominico = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelharton = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgfondojuego1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedominico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureharton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemaqueño)).BeginInit();
            this.panelbarraganete.SuspendLayout();
            this.panelmaqueño.SuspendLayout();
            this.panelmacho.SuspendLayout();
            this.paneldominico.SuspendLayout();
            this.panelharton.SuspendLayout();
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
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgfondojuego1
            // 
            this.imgfondojuego1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgfondojuego1.Image = global::proyecto.Properties.Resources._7N;
            this.imgfondojuego1.Location = new System.Drawing.Point(0, 0);
            this.imgfondojuego1.Name = "imgfondojuego1";
            this.imgfondojuego1.Size = new System.Drawing.Size(800, 450);
            this.imgfondojuego1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgfondojuego1.TabIndex = 1;
            this.imgfondojuego1.TabStop = false;
            // 
            // pictureBarra
            // 
            this.pictureBarra.Image = global::proyecto.Properties.Resources.Barraganete;
            this.pictureBarra.Location = new System.Drawing.Point(37, 121);
            this.pictureBarra.Name = "pictureBarra";
            this.pictureBarra.Size = new System.Drawing.Size(132, 198);
            this.pictureBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBarra.TabIndex = 6;
            this.pictureBarra.TabStop = false;
            this.pictureBarra.Tag = "panelbarraganete";
            this.pictureBarra.Click += new System.EventHandler(this.MostrarPanel_Click);
            // 
            // picturedominico
            // 
            this.picturedominico.BackColor = System.Drawing.SystemColors.Control;
            this.picturedominico.Image = global::proyecto.Properties.Resources.Dominico;
            this.picturedominico.Location = new System.Drawing.Point(175, 121);
            this.picturedominico.Name = "picturedominico";
            this.picturedominico.Size = new System.Drawing.Size(147, 198);
            this.picturedominico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturedominico.TabIndex = 7;
            this.picturedominico.TabStop = false;
            this.picturedominico.Tag = "paneldominico";
            this.picturedominico.Click += new System.EventHandler(this.MostrarPanel_Click);
            // 
            // pictureharton
            // 
            this.pictureharton.Image = global::proyecto.Properties.Resources.Harton;
            this.pictureharton.Location = new System.Drawing.Point(328, 121);
            this.pictureharton.Name = "pictureharton";
            this.pictureharton.Size = new System.Drawing.Size(138, 198);
            this.pictureharton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureharton.TabIndex = 8;
            this.pictureharton.TabStop = false;
            this.pictureharton.Tag = "panelharton";
            this.pictureharton.Click += new System.EventHandler(this.MostrarPanel_Click);
            // 
            // picturemacho
            // 
            this.picturemacho.Image = global::proyecto.Properties.Resources.Macho;
            this.picturemacho.Location = new System.Drawing.Point(472, 121);
            this.picturemacho.Name = "picturemacho";
            this.picturemacho.Size = new System.Drawing.Size(134, 198);
            this.picturemacho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturemacho.TabIndex = 9;
            this.picturemacho.TabStop = false;
            this.picturemacho.Tag = "panelmacho";
            this.picturemacho.Click += new System.EventHandler(this.MostrarPanel_Click);
            // 
            // picturemaqueño
            // 
            this.picturemaqueño.Image = global::proyecto.Properties.Resources.Maqueño;
            this.picturemaqueño.Location = new System.Drawing.Point(612, 121);
            this.picturemaqueño.Name = "picturemaqueño";
            this.picturemaqueño.Size = new System.Drawing.Size(131, 198);
            this.picturemaqueño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturemaqueño.TabIndex = 10;
            this.picturemaqueño.TabStop = false;
            this.picturemaqueño.Tag = "panelmaqueño";
            this.picturemaqueño.Click += new System.EventHandler(this.MostrarPanel_Click);
            // 
            // irjuego
            // 
            this.irjuego.BackColor = System.Drawing.Color.YellowGreen;
            this.irjuego.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irjuego.Location = new System.Drawing.Point(580, 335);
            this.irjuego.Name = "irjuego";
            this.irjuego.Size = new System.Drawing.Size(135, 43);
            this.irjuego.TabIndex = 11;
            this.irjuego.Text = "Juego";
            this.irjuego.UseVisualStyleBackColor = false;
            this.irjuego.Click += new System.EventHandler(this.irjuego_Click);
            // 
            // panelbarraganete
            // 
            this.panelbarraganete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelbarraganete.Controls.Add(this.button3);
            this.panelbarraganete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbarraganete.Location = new System.Drawing.Point(0, 0);
            this.panelbarraganete.Name = "panelbarraganete";
            this.panelbarraganete.Size = new System.Drawing.Size(800, 450);
            this.panelbarraganete.TabIndex = 12;
            this.panelbarraganete.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Volver_Click);
            // 
            // panelmaqueño
            // 
            this.panelmaqueño.BackColor = System.Drawing.Color.Maroon;
            this.panelmaqueño.Controls.Add(this.button4);
            this.panelmaqueño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmaqueño.Location = new System.Drawing.Point(0, 0);
            this.panelmaqueño.Name = "panelmaqueño";
            this.panelmaqueño.Size = new System.Drawing.Size(800, 450);
            this.panelmaqueño.TabIndex = 13;
            this.panelmaqueño.Visible = false;
            this.panelmaqueño.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmaqueño_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Volver_Click);
            // 
            // panelmacho
            // 
            this.panelmacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelmacho.Controls.Add(this.button5);
            this.panelmacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmacho.Location = new System.Drawing.Point(0, 0);
            this.panelmacho.Name = "panelmacho";
            this.panelmacho.Size = new System.Drawing.Size(800, 450);
            this.panelmacho.TabIndex = 14;
            this.panelmacho.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Volver_Click);
            // 
            // paneldominico
            // 
            this.paneldominico.BackColor = System.Drawing.Color.Cyan;
            this.paneldominico.Controls.Add(this.label2);
            this.paneldominico.Controls.Add(this.button2);
            this.paneldominico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldominico.Location = new System.Drawing.Point(0, 0);
            this.paneldominico.Name = "paneldominico";
            this.paneldominico.Size = new System.Drawing.Size(800, 450);
            this.paneldominico.TabIndex = 13;
            this.paneldominico.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Volver_Click);
            // 
            // panelharton
            // 
            this.panelharton.BackColor = System.Drawing.Color.Olive;
            this.panelharton.Controls.Add(this.label1);
            this.panelharton.Controls.Add(this.button6);
            this.panelharton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelharton.Location = new System.Drawing.Point(0, 0);
            this.panelharton.Name = "panelharton";
            this.panelharton.Size = new System.Drawing.Size(800, 450);
            this.panelharton.TabIndex = 13;
            this.panelharton.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 38);
            this.button6.TabIndex = 2;
            this.button6.Text = "Volver";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "INFORMACION SOBRE EL BARRAGANETE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-200, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFORMACION SOBRE EL DOMINICO";
            // 
            // Form11infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelmaqueño);
            this.Controls.Add(this.paneldominico);
            this.Controls.Add(this.panelharton);
            this.Controls.Add(this.panelmacho);
            this.Controls.Add(this.picturemaqueño);
            this.Controls.Add(this.picturemacho);
            this.Controls.Add(this.pictureharton);
            this.Controls.Add(this.picturedominico);
            this.Controls.Add(this.panelbarraganete);
            this.Controls.Add(this.irjuego);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgfondojuego1);
            this.Controls.Add(this.pictureBarra);
            this.Name = "Form11infor";
            this.Text = "Form11infor";
            ((System.ComponentModel.ISupportInitialize)(this.imgfondojuego1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedominico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureharton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemaqueño)).EndInit();
            this.panelbarraganete.ResumeLayout(false);
            this.panelmaqueño.ResumeLayout(false);
            this.panelmacho.ResumeLayout(false);
            this.paneldominico.ResumeLayout(false);
            this.paneldominico.PerformLayout();
            this.panelharton.ResumeLayout(false);
            this.panelharton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgfondojuego1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBarra;
        private System.Windows.Forms.PictureBox picturedominico;
        private System.Windows.Forms.PictureBox pictureharton;
        private System.Windows.Forms.PictureBox picturemacho;
        private System.Windows.Forms.PictureBox picturemaqueño;
        private System.Windows.Forms.Button irjuego;
        private System.Windows.Forms.Panel panelbarraganete;
        private System.Windows.Forms.Panel panelmaqueño;
        private System.Windows.Forms.Panel panelmacho;
        private System.Windows.Forms.Panel paneldominico;
        private System.Windows.Forms.Panel panelharton;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}