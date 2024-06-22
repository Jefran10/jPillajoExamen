namespace jPillajoExamen.View;

public partial class vLogin : ContentPage
{
    string[,] usuariosContraseñas = {
            {"estudiante", "moviles"},
            {"uisrael", "2024"},

        };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usu = txtUsuario.Text;
        string pass = txtContrasena.Text;

        bool usuCorr = false;
        bool passCorr = false;

        for (int i = 0; i < usuariosContraseñas.GetLength(0); i++)
        {
            if (usuariosContraseñas[i, 0] == usu)
            {
                usuCorr = true;
                if (usuariosContraseñas[i, 1] == pass)
                {
                    passCorr = true;
                    break;
                }
            }
        }

        if (usuCorr && passCorr)
        {

            Navigation.PushAsync(new vRegistro(usu));
        }
        else
        {
            DisplayAlert("Alerta", "Dato Incorrecto, Verificar usurio y Contraseña.!!", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}