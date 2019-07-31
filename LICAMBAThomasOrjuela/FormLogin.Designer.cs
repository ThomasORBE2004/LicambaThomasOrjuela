/*
 * Creado por SharpDevelop.
 * Usuario: pc
 * Fecha: 28/05/2019
 * Hora: 7:56 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LICAMBAThomasOrjuela
{
	partial class FormLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.button1 = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lab = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(209, 326);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Ingresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(139, 269);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(255, 34);
			this.txtPassword.TabIndex = 1;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(139, 171);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(255, 34);
			this.txtUser.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(139, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "USUARIO:";
			// 
			// lab
			// 
			this.lab.Location = new System.Drawing.Point(139, 242);
			this.lab.Name = "lab";
			this.lab.Size = new System.Drawing.Size(161, 24);
			this.lab.TabIndex = 4;
			this.lab.Text = "CONTRASEÑA:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(282, 441);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Olvide mi contraseña";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(176, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(179, 114);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(492, 494);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lab);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingrseo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
