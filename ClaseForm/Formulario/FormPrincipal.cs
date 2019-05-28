using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
  public partial class FormPrincipal : Form
  {
    List<Persona> personas;
    FormPersona formPersona = new FormPersona();

    public FormPrincipal()
    {
      InitializeComponent();
      personas = new List<Persona>();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {

    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      if (formPersona.ShowDialog() == DialogResult.OK)
        personas.Add(formPersona.persona);
      else
        MessageBox.Show("Error al guardar los datos de persona");
    }

    private void btnPersona_Click(object sender, EventArgs e)
    {
      listPersona.Items.Clear();
      foreach (Persona p in personas)
      {
        listPersona.Items.Add(p);
      }
      
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {

    }
  }
}
