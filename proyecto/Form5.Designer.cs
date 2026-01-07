namespace proyecto
{
    partial class Form5
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
			this.clasificacion = new System.Windows.Forms.Button();
			this.produccion = new System.Windows.Forms.Button();
			this.plagas = new System.Windows.Forms.Button();
			this.ciclo = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// clasificacion
			// 
			this.clasificacion.BackgroundImage = global::proyecto.Properties.Resources.BTNclasificacion;
			this.clasificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.clasificacion.Location = new System.Drawing.Point(147, 240);
			this.clasificacion.Name = "clasificacion";
			this.clasificacion.Size = new System.Drawing.Size(246, 50);
			this.clasificacion.TabIndex = 0;
			this.clasificacion.UseVisualStyleBackColor = true;
			this.clasificacion.Click += new System.EventHandler(this.button1_Click);
			// 
			// produccion
			// 
			this.produccion.BackgroundImage = global::proyecto.Properties.Resources.btnProduccion;
			this.produccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.produccion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.produccion.Location = new System.Drawing.Point(409, 240);
			this.produccion.Name = "produccion";
			this.produccion.Size = new System.Drawing.Size(246, 50);
			this.produccion.TabIndex = 1;
			this.produccion.UseVisualStyleBackColor = true;
			this.produccion.Click += new System.EventHandler(this.produccion_Click);
			// 
			// plagas
			// 
			this.plagas.BackgroundImage = global::proyecto.Properties.Resources.btnPlagas;
			this.plagas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.plagas.Location = new System.Drawing.Point(147, 296);
			this.plagas.Name = "plagas";
			this.plagas.Size = new System.Drawing.Size(246, 50);
			this.plagas.TabIndex = 2;
			this.plagas.UseVisualStyleBackColor = true;
			this.plagas.Click += new System.EventHandler(this.button3_Click);
			// 
			// ciclo
			// 
			this.ciclo.BackgroundImage = global::proyecto.Properties.Resources.BtnCiclo;
			this.ciclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ciclo.Location = new System.Drawing.Point(409, 296);
			this.ciclo.Name = "ciclo";
			this.ciclo.Size = new System.Drawing.Size(246, 50);
			this.ciclo.TabIndex = 3;
			this.ciclo.UseVisualStyleBackColor = true;
			this.ciclo.Click += new System.EventHandler(this.ciclo_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImage = global::proyecto.Properties.Resources.btnflecha;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(12, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 71);
			this.button2.TabIndex = 5;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::proyecto.Properties.Resources.btncasa;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(715, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 71);
			this.button1.TabIndex = 6;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::proyecto.Properties.Resources._5;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ciclo);
			this.Controls.Add(this.plagas);
			this.Controls.Add(this.produccion);
			this.Controls.Add(this.clasificacion);
			this.Name = "Form5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form5";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clasificacion;
        private System.Windows.Forms.Button produccion;
        private System.Windows.Forms.Button plagas;
        private System.Windows.Forms.Button ciclo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}