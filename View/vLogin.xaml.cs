namespace jPillajoExamen.View;

public partial class vLogin : ContentPage
{
    string[,] usuariosContrase�as = {
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

        for (int i = 0; i < usuariosContrase�as.GetLength(0); i++)
        {
            if (usuariosContrase�as[i, 0] == usu)
            {
                usuCorr = true;
                if (usuariosContrase�as[i, 1] == pass)
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
            DisplayAlert("Alerta", "Dato Incorrecto, Verificar usurio y Contrase�a.!!", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}