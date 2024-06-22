namespace jPillajoExamen.View
{
    public partial class vResumen : ContentPage
    {
        public vResumen(string jpNombre, string jpApellido, string jpEdad, string jpFecha, string? jpPais, string? jpCiudad, string jpMontoInicial, string jpPagoMensual, string jpCajaUsuario, string jpMontoTotal)
        {
            InitializeComponent();

    
            jpLblNombre.Text = jpNombre;
            jpLblApellido.Text = jpApellido;
            jpLblEdad.Text = jpEdad;
            jpLblFecha.Text = jpFecha;
            jpLblPais.Text = jpPais;
            jpLblCiudad.Text = jpCiudad;
            jpLblMontoInicial.Text = jpMontoInicial;
            jpLblPagoMensual.Text = jpPagoMensual;
            jpLblPagoTotal.Text = jpMontoTotal;
            jpLblUsuario.Text = jpCajaUsuario;
        }
    }
}
