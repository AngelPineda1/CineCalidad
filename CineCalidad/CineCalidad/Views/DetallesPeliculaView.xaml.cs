using CineCalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CineCalidad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallesPeliculaView : ContentPage
    {
        public DetallesPeliculaView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            gridEliminar.IsVisible = true;
        }

        private void btnNoEliminar_Clicked(object sender, EventArgs e)
        {
            gridEliminar.IsVisible = false;
        }
    }
}