using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace FormSQL
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      List<Provincia> lista = new List<Provincia>();
      //MessageBox.Show(Properties.Settings.Default.CadenaSQL);
      SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadenaSQL);
      SqlCommand cm = new SqlCommand("Select id, nombre from Provincias",cn);
      cn.Open();
      SqlDataReader dr = cm.ExecuteReader();

      while (dr.Read())
      {
        lista.Add(new Provincia(dr["nombre"].ToString(),(int)(decimal)dr["id"]));
      }
      comboBox1.DataSource = lista;
      cn.Close();
    }
  }
}
