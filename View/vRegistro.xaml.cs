namespace jPillajoExamen.View
{
    public partial class vRegistro : ContentPage
    {
        public vRegistro(string usu)
        {
            InitializeComponent();
            DisplayAlert("Bienvenido", usu, "Cerrar");
            lblUsuario.Text = "Usuario conectado: " + usu;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            // Validar y convertir el monto inicial ingresado
            if (!double.TryParse(txtMontoInicial.Text, out double jpMontoInicial))
            {
                DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
                return;
            }

            // Calcular montos
            double jpMontoRestante = 1500 - jpMontoInicial;
            double jpMontoPorCuota = jpMontoRestante / 4;
            double jpMontoConInteres = jpMontoPorCuota * 1.04;
            double jpMontoTotal = jpMontoConInteres * 4 + jpMontoInicial;

            txtPagoMensual.Text = jpMontoConInteres.ToString("C");

           
            txtmontoTotal.Text = jpMontoTotal.ToString("C");
            txtmontoTotal.Text = jpMontoTotal.ToString("C");

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            // Recopilar información del formulario
            string jpNombre = txtNombre.Text;
            string jpApellido = txtApellido.Text;
            string jpEdad = txtEdad.Text;
            string jpFecha = datePicker.Date.ToString("dd/MM/yyyy");
            string jpPais = pickerPais.SelectedItem?.ToString();
            string jpCiudad = pickerCiudad.SelectedItem?.ToString();
            string jpMontoInicial = txtMontoInicial.Text;
            string jpPagoMensual = txtPagoMensual.Text;
            string jpCajaUsuario = lblUsuario.Text;
            string jpMontoTotal = txtmontoTotal.Text;

            // Navegar a la página de resumen
            vResumen jpResumenPage = new vResumen(jpNombre, jpApellido, jpEdad, jpFecha, jpPais, jpCiudad, jpMontoInicial, jpPagoMensual, jpCajaUsuario, jpMontoTotal);
            Navigation.PushAsync(jpResumenPage);
        }
    }
}
