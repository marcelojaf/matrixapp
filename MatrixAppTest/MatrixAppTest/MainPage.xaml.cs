using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tftp.Net;
using Xamarin.Forms;

namespace MatrixAppTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnProcurar_ClickedAsync(object sender, EventArgs e)
        {
            try
            {
                FileData x = await CrossFilePicker.Current.PickFile();

                txtArquivo.Text = x.FileName;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void enviarArquivo()
        {
            Tftp.Net.TftpClient tftpClient;
            //var client = new TftpClient("localhost");
        }
    }
}
