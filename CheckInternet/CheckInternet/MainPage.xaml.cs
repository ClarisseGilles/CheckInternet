using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckInternet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnInternet_Pressed(object sender, EventArgs e)
        {
            if (CheckInternetConnection())
            {
                lblInternet.Text = "Connected to the internet";
            }
            else
            {
                lblInternet.Text = "Not onnected to the internet";
            }
        }

        public bool CheckInternetConnection()
        {
            string CheckUrl = "http://google.com";

            try
            {
                HttpWebRequest iNetRequest = (HttpWebRequest)WebRequest.Create(CheckUrl);

                iNetRequest.Timeout = 5000;

                WebResponse iNetResponse = iNetRequest.GetResponse();

                iNetResponse.Close();

                return true;

            }
            catch (WebException ex)
            {
                return false;
            }
        }
    }
}
