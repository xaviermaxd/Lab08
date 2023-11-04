using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab08
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QrScanDemo : ContentPage
    {
        public QrScanDemo()
        {
            InitializeComponent();
        }

        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanning>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnOpenWebPage_Clicked(object sender, EventArgs e)
        {
            try
            {
                var uri = new Uri(txtBarcode.Text);
                Device.OpenUri(uri);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}