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
    public partial class Ejemplo1 : ContentPage
    {
        public Ejemplo1()
        {
            InitializeComponent();
        }

        private void btnabrir_Clicked(object sender, EventArgs e)
        {
            String datoUno = txtDatoUno.Text;
            int datoDos = Convert.ToInt32(txtDatoDos.Text);
           
            Navigation.PushAsync(new Ejemplo2 (datoUno, datoDos));

        }
    }
}