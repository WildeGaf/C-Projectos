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
  public partial class FormPersona : Form
  {
    public Persona persona;
    public FormPersona()
    {
      InitializeComponent();
      persona = new Persona();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      persona.nombre = txtNombre.Text;
      persona.apellido = txtApellido.Text;
      persona.dni = txtDni.Text;
      this.DialogResult = DialogResult.OK;
    }

    private void FormPersona_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
