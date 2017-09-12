using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace c1x_FlexGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerRequestView : ContentPage
    {
        public CustomerRequestView()
        {
            InitializeComponent();
            flexgrid.AutoSizeColumns(0, flexgrid.Columns.Count - 1);
        }

    }
}