namespace proyecto
{
    partial class Form2
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
			this.txtuser = new System.Windows.Forms.TextBox();
			this.txtclave = new System.Windows.Forms.TextBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtuser
			// 
			this.txtuser.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser.Location = new System.Drawing.Point(260, 119);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(276, 41);
			this.txtuser.TabIndex = 0;
			this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtclave
			// 
			this.txtclave.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtclave.Location = new System.Drawing.Point(260, 241);
			this.txtclave.Name = "txtclave";
			this.txtclave.Size = new System.Drawing.Size(276, 41);
			this.txtclave.TabIndex = 1;
			// 
			// btnInicio
			// 
			this.btnInicio.BackgroundImage = global::proyecto.Properties.Resources.btn_inicio;
			this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInicio.Location = new System.Drawing.Point(342, 323);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(118, 44);
			this.btnInicio.TabIndex = 2;
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::proyecto.Properties.Resources._2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnInicio);
			this.Controls.Add(this.txtclave);
			this.Controls.Add(this.txtuser);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btnInicio;
    }
}