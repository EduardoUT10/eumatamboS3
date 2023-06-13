using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eumatamboS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejemplo2 : ContentPage
    {
        public Ejemplo2(String datoUno,int datoDos)
        {
            InitializeComponent();
            lblDatoUno.Text = "Dato Uno"+ datoUno;
            lblDatoDos.Text = "Dato Dos" + datoDos.ToString();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejemplo3());
        }
    }
}