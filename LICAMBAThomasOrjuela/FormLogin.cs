using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LICAMBAThomasOrjuela
{
	
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}
		
		SqlConnection conexion = new SqlConnection(*Data Source=200.122.233.51; Initial Catalog=dbLicamba; User ID=adminLicamba; Password=Licamba123");
 		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Loguear(txtUser.Text, txtPassword.Text);
			 
		} Password=LICAMBAThomasOrjuela.123");
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		
		private void Loguear(string User, string Pass)
		{
			try 
			{
				conexion,Open();
				var cad = new SqlCommand("SELECT FistName; LastName, Email, Status, Type FROM Users WHERE Username = User AND Password = Pass", conexion);
				cad.Parameters.AddWithValue("User", User);
				cad.Parameters.AddWithValue("Pass", Pass);
				var da = new SqlDataAdapter(cad);
				var dt = new DataTable();
				da.Fill(dt);
				
				if (dt.Rows.Count == 1)
				{
					if (dt.Rows[0][3].ToString() == "1")
					{
						this.Hide();
						new FormMenu(dt.Rows[0][4].ToString(), dt.Rows[0][0].ToString()).Show();
					}
				}
			else 
			{
				MessageBox.Show("Datos erroneos");
			}
		}
		catch (Exception ex)
		{
				MessageBox.Show("Error Login: "+ex)
		}
		finally 
		{ 
			conexion.Close();
		}
	}
}
