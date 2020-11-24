
using CyberLab_Integrador.View;
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
    public partial class TelaPrincipal : MasterDetailPage
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MainPage());
            NavigationPage.SetHasNavigationBar(this, false);

            
            
        }

        private void Sair_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Login());
        
        
        }


        private void Gopage1(object sender, EventArgs e)
        {

            Detail.Navigation.PushAsync(new agendamento_new());
            IsPresented = false;
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Contato());
            IsPresented = false;
        }

        private void ViewCell_Tapped_1(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Desenvolvedores());
            IsPresented = false;
        }
    }

       
}