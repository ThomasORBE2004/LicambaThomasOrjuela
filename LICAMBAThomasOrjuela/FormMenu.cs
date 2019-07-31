/*
 * Creado por SharpDevelop.
 * Usuario: pc
 * Fecha: 28/05/2019
 * Hora: 8:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LICAMBAThomasOrjuela
{
	/// <summary>
	/// Description of FormMenu.
	/// </summary>
	public partial class FormMenu : Form
	{
		public FormMenu(string TypeUser, string NameUser)
		{
			InitializeComponent();
			lblType.Text = TypeUser;
			lblName.Text = NameUser;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void UsuariosToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
	}
}
