using JcvillaltavS68A.Models;
using System.Net;

namespace JcvillaltavS68A.Views;

public partial class vActElim : ContentPage
{
	public vActElim( Estudiante datos)
	{
		InitializeComponent();

        //Envio los datos
        txtCodigo.Text = datos.codigo.ToString();
        txtNombre.Text = datos.nombre.ToString();
        txtApellido.Text = datos.apellido.ToString();
        txtEdad.Text = datos.edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {

    }
}