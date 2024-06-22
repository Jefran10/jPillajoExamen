namespace jPillajoExamen.View;

public partial class vLogin : ContentPage
{
    string[,] jpUsuariosContrasenas = {
            {"estudiante", "moviles"},
            {"uisrael", "2024"},

        };

    public vLogin()
    {
        InitializeComponent();
    }

    private void jpBtnIniciar_Clicked(object sender, EventArgs e)
    {
        string jpUsu = jpTxtUsuario.Text;
        string jpPass = jpTxtContrasena.Text;

        bool jpUsuCorr = false;
        bool jpPassCorr = false;

        for (int i = 0; i < jpUsuariosContrasenas.GetLength(0); i++)
        {
            if (jpUsuariosContrasenas[i, 0] == jpUsu)
            {
                jpUsuCorr = true;
                if (jpUsuariosContrasenas[i, 1] == jpPass)
                {
                    jpPassCorr = true;
                    break;
                }
            }
        }

        if (jpUsuCorr && jpPassCorr)
        {

            Navigation.PushAsync(new vRegistro(jpUsu));
        }
        else
        {
            DisplayAlert("Alerta", "Dato Incorrecto, Verificar usurio y Contraseña.!!", "Cerrar");
            jpTxtUsuario.Text = "";
            jpTxtContrasena.Text = "";
        }
    }
}
