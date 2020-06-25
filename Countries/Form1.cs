namespace Countries
{
    using Countries.Models;
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Services;
    using System.Threading.Tasks;
    using System.IO;
    using System.Net;
    using System.Drawing.Imaging;
    using Svg;
    using System.Windows.Media.Imaging;

    public partial class Form1 : Form
    {

        #region Atributos

        private List<Country> Countries;

        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        private DataService dataService;

        #endregion

        public Form1()
        {
            InitializeComponent();

            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();

            LoadCountries();
        }

        private async void LoadCountries()
        {
            bool load;

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalCountries();
                load = false;
            }
            else
            {
                await LoadApiCountries();
                load = true;
            }

            if (Countries.Count == 0)
            {
                labelResultado.Text = "Without internet connection" + Environment.NewLine +
                    "And no preload countries" + Environment.NewLine +
                    "Try again later!";

                labelStatus.Text = "First initialization with Internet connection";

                return;
            }

            if (!Directory.Exists("Flags"))
            {
                Directory.CreateDirectory("Flags");
            }

            foreach (var donwloadFlag in Countries)
            {
                try
                {
                    string flagName = donwloadFlag.Flag.Split('/')[4].Split('.')[0];
                    var path = @"Flags\" + $"{flagName}.svg";

                    string svgFile = "http://restcountries.eu" + $"/data/{flagName}.svg";

                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(svgFile, path);
                    }

                    string flag = flagName;
                    var pathFlag = @"Flags\" + $"{flagName}.jpg";

                    var svgDoc = SvgDocument.Open(path);
                    var bitMap = svgDoc.Draw(100, 100);

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    if (!File.Exists(pathFlag))
                    {
                        bitMap.Save(pathFlag, ImageFormat.Jpeg);
                    }
                }
                catch
                {
                    continue;
                }
            }

            listBox_Countries.DataSource = Countries;
            listBox_Countries.DisplayMember = "Name";
            listBox_Countries.BindingContext = new BindingContext();

            labelResultado.Text = "Updated Countries!";

            if (load) 
            {
                labelStatus.Text = string.Format("loaded data from internet at {0:F}", DateTime.Now);
            }
            else 
            {
                labelStatus.Text = string.Format("Loaded data from DataBase");
            }
            progressBar1.Value = 100;
        }

        private void LoadLocalCountries()
        {
            Countries = dataService.GetData();
        }

        private async Task LoadApiCountries()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetCountries("http://restcountries.eu", "/rest/v2/all");

            Countries = (List<Country>)response.Result;

            dataService.DeleteData();

            dataService.SaveData(Countries);
        }

        private void listBox_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = (Country)listBox_Countries.SelectedItem;
            lbl_CountryName.Text = selectedCountry.Name;
            lbl_CapitalName.Text = selectedCountry.Capital;
            lbl_Region.Text = selectedCountry.Region;
            lbl_SubRegion.Text = selectedCountry.Subregion;
            lbl_Population.Text = selectedCountry.Population.ToString();
            lbl_GiniIndex.Text = selectedCountry.Gini;


            string flag = selectedCountry.Flag.Split('/')[4].Split('.')[0];

            BitmapImage image = new BitmapImage();
            image.BeginInit();

            if (File.Exists(Environment.CurrentDirectory + "/Flags" + $"/{flag}.jpg"))
            {
                image.UriSource = new Uri(Environment.CurrentDirectory + "/Flags" + $"/{flag}.jpg");
            }
            else
            {
                image.UriSource = new Uri(Environment.CurrentDirectory + "/Resources" + "/NoImage.jpeg");

            }

            pictureBox_Country.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Country.ImageLocation = image.ToString();
            image.EndInit();

            if(lbl_CountryName.Text == string.Empty)
            {
                lbl_CountryName.Text = "Not available.";
            }
            if (lbl_CapitalName.Text == string.Empty)
            {
                lbl_CapitalName.Text = "Not available.";
            }
            if (lbl_Region.Text == string.Empty)
            {
                lbl_Region.Text = "Not available.";
            }
            if (lbl_SubRegion.Text == string.Empty)
            {
                lbl_SubRegion.Text = "Not available.";
            }
            if (lbl_Population.Text == string.Empty)
            {
                lbl_Population.Text = "Not available.";
            }
            if (lbl_GiniIndex.Text == string.Empty)
            {
                lbl_GiniIndex.Text = "Not available.";
            }
        }
    }
}

