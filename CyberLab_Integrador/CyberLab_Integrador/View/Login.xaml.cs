using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberLab_Integrador
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
          
            // Define o binding context
            this.BindingContext = this;
            // Define a propriedade
            this.IsBusy = false;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (TxtLogin.Text.Equals("cb") && (TxtSenha.Text.Equals("123")))
            {
                //ativa o ActivityIndicator
                this.IsBusy = true;
                // aqui ficaria o seu código 
                // para fazer a autenticação              
                Application.Current.MainPage = new NavigationPage(new TelaPrincipal());


            }
            else { await DisplayAlert("Alerta", "Login ou Senha Errado!", "OK"); }
        }

       
    }
}