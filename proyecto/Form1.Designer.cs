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
            this.btnInicio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio1
            // 
            this.btnInicio1.BackgroundImage = global::proyecto.Properties.Resources.button_for_starting_game_clicking_play_vector;
            this.btnInicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio1.Location = new System.Drawing.Point(234, 207);
            this.btnInicio1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicio1.Name = "btnInicio1";
            this.btnInicio1.Size = new System.Drawing.Size(66, 30);
            this.btnInicio1.TabIndex = 0;
            this.btnInicio1.UseVisualStyleBackColor = true;
            this.btnInicio1.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnInicio1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio1;
    }
}

