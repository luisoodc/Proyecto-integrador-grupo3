namespace proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnInicio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnInicio
			// 
			this.btnInicio.BackgroundImage = global::proyecto.Properties.Resources.button_for_starting_game_clicking_play_vector;
			this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInicio.Location = new System.Drawing.Point(351, 319);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(99, 46);
			this.btnInicio.TabIndex = 0;
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::proyecto.Properties.Resources._1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnInicio);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
    }
}

