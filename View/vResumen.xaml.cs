namespace jPillajoExamen.View
{
    public partial class vResumen : ContentPage
    {
        public vResumen(string jpNombre, string jpApellido, string jpEdad, string jpFecha, string? jpPais, string? jpCiudad, string jpMontoInicial, string jpPagoMensual, string jpCajaUsuario, string jpMontoTotal)
        {
            InitializeComponent();

            // Aquí puedes usar los datos recibidos para inicializar los elementos de la página
            lblNombre.Text = jpNombre;
            lblApellido.Text = jpApellido;
            lblEdad.Text = jpEdad;
            lblFecha.Text = jpFecha;
            lblPais.Text = jpPais;
            lblCiudad.Text = jpCiudad;
            lblMontoInicial.Text = jpMontoInicial;
            lblPagoMensual.Text = jpPagoMensual;
            lblPagoTotal.Text = jpMontoTotal;
            lblUsuario.Text = jpCajaUsuario;
        }
    }
}
