/*
 * Creado por SharpDevelop.
 * Usuario: pc
 * Fecha: 28/05/2019
 * Hora: 8:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LICAMBAThomasOrjuela
{
	partial class FormMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel lblType;
		private System.Windows.Forms.ToolStripStatusLabel lblName;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblType = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblName = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.administracionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(757, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// administracionToolStripMenuItem
			// 
			this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.usuariosToolStripMenuItem});
			this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
			this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.administracionToolStripMenuItem.Text = "Administracion";
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.crearToolStripMenuItem,
			this.editarToolStripMenuItem,
			this.eliminarToolStripMenuItem,
			this.reportesToolStripMenuItem});
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblType,
			this.lblName});
			this.statusStrip1.Location = new System.Drawing.Point(0, 308);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(757, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// crearToolStripMenuItem
			// 
			this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
			this.crearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.crearToolStripMenuItem.Text = "Crear";
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editarToolStripMenuItem.Text = "Editar";
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// lblType
			// 
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(118, 17);
			this.lblType.Text = "toolStripStatusLabel1";
			// 
			// lblName
			// 
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(118, 17);
			this.lblName.Text = "toolStripStatusLabel2";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 330);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "FormMenu";
			this.Text = "FormMenu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
