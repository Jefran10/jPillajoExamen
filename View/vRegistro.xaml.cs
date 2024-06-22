namespace jPillajoExamen.View
{
    public partial class vRegistro : ContentPage
    {
        public vRegistro(string jpUsu)
        {
            InitializeComponent();
            DisplayAlert("Bienvenido", jpUsu, "Cerrar");
            jpLblUsuario.Text = "Usuario conectado: " + jpUsu;
        }

        private void jpBtnCalcular_Clicked(object sender, EventArgs e)
        {
            
            if (!double.TryParse(jpTxtMontoInicial.Text, out double jpMontoInicial))
            {
                DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
                return;
            }

            double jpMontoRestante = 1500 - jpMontoInicial;
            double jpMontoPorCuota = jpMontoRestante / 4;
            double jpMontoConInteres = jpMontoPorCuota * 1.04;
            double jpMontoTotal = jpMontoConInteres * 4 + jpMontoInicial;

            jpTxtPagoMensual.Text = jpMontoConInteres.ToString("C");


            jpTxtMontoTotal.Text = jpMontoTotal.ToString("C");
            jpTxtMontoTotal.Text = jpMontoTotal.ToString("C");

        }

        private void jpBtnResumen_Clicked(object sender, EventArgs e)
        {
            
            string jpNombre = jpTxtNombre.Text;
            string jpApellido = jpTxtApellido.Text;
            string jpEdad = jpTxtEdad.Text;
            string jpFecha = jpDatePicker.Date.ToString("dd/MM/yyyy");
            string jpPais = jpPickerPais.SelectedItem?.ToString();
            string jpCiudad = jpPickerCiudad.SelectedItem?.ToString();
            string jpMontoInicial = jpTxtMontoInicial.Text;
            string jpPagoMensual = jpTxtPagoMensual.Text;
            string jpCajaUsuario = jpLblUsuario.Text;
            string jpMontoTotal = jpTxtMontoTotal.Text;

            // Navegar a la página de resumen
            vResumen jpResumenPage = new vResumen(jpNombre, jpApellido, jpEdad, jpFecha, jpPais, jpCiudad, jpMontoInicial, jpPagoMensual, jpCajaUsuario, jpMontoTotal);
            Navigation.PushAsync(jpResumenPage);
        }
    }
}
