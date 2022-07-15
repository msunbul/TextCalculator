using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace CalculateApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client;
        string sayi1 = string.Empty, sayi2 = string.Empty;
        int selectLanguage = 1;

        CalculateTranslatorService.Controllers.CalculateTranslatorController cont = null;
        
        public Form1()
        {
            InitializeComponent();

           cont = new CalculateTranslatorService.Controllers.CalculateTranslatorController();



            client = new HttpClient();
            //TODO:aşağıdaki base api url appsetting den getirecem.
            client.BaseAddress = new Uri("https://localhost:44334/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private void veri_kontrol()
        {
            sayi1 = txtBirinciSayi.Text;
            sayi2 = txtİkinciSayi.Text;
            selectLanguage= lblGecerliDil.Text == "Current Language:" ? 2 : 1;

            int sayi1Rakam;
            bool sayi1Rakammi = int.TryParse(sayi1, out sayi1Rakam);
            int sayi2Rakam;
            bool sayi2Rakammi = int.TryParse(sayi2, out sayi2Rakam);

            var Sayi1Uygunmu = sayi1.Contains(" ") || string.IsNullOrEmpty(sayi1) || sayi1Rakammi;
            var Sayi2Uygunmu = sayi2.Contains(" ") || string.IsNullOrEmpty(sayi2) || sayi2Rakammi || sayi2Rakammi || sayi2.ToLower() == "sıfır";
            if (Sayi1Uygunmu || Sayi2Uygunmu)
            {
                MessageBox.Show("Lütfen geçerli bir söz dizimi girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetServiceResponse(int type,int languageType)
        {
            HttpResponseMessage response = await client.GetAsync(
                client.BaseAddress + "api/CalculateTranslator/" + type +","+languageType+ "?val1=" + sayi1 + "&val2=" + sayi2);
            var resultText = string.Empty;

            if (response.IsSuccessStatusCode)
            {
                resultText = await response.Content.ReadAsStringAsync();
            }

            return resultText;
        }

        private async void btnTopla_Click(object sender, EventArgs e)
        {
            veri_kontrol();
            //txtSonuç.Text = await GetServiceResponse(1,selectLanguage);
            //txtSonuç.Text = txtSonuç.Text.Substring(1, txtSonuç.Text.Length - 2);

            txtSonuç.Text = cont.Get(1, selectLanguage, sayi1, sayi2);
        }
        private async void btnÇıkar_Click(object sender, EventArgs e)
        {
            veri_kontrol();
            //txtSonuç.Text = await GetServiceResponse(2,selectLanguage);
            //txtSonuç.Text = txtSonuç.Text.Substring(1,txtSonuç.Text.Length-2);
            txtSonuç.Text = cont.Get(2, selectLanguage, sayi1, sayi2);
        }
        private async void btnÇarp_Click(object sender, EventArgs e)
        {
            veri_kontrol();
            //txtSonuç.Text = await GetServiceResponse(3,selectLanguage);
            //txtSonuç.Text = txtSonuç.Text.Substring(1, txtSonuç.Text.Length - 2);

            txtSonuç.Text = cont.Get(3, selectLanguage, sayi1, sayi2);
        }
        private async void btnBöl_Click(object sender, EventArgs e)
        {
            veri_kontrol();
            //txtSonuç.Text = await GetServiceResponse(4,selectLanguage);
            //txtSonuç.Text = txtSonuç.Text.Substring(1, txtSonuç.Text.Length - 2);

            txtSonuç.Text = cont.Get(4, selectLanguage, sayi1, sayi2);
        }

        private void cbGeçerliDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chosenLanguage = cbGeçerliDil.SelectedItem.ToString();
            txtGeçerliDil.Text = chosenLanguage;
           
            //Todo:App Settingden okuyacam
            if (chosenLanguage == "Türkçe")
            {
                Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("tr");
                Thread.CurrentThread.CurrentUICulture =
                   new System.Globalization.CultureInfo("tr");
                #region Geçici alan atamaları

                    lblDilSecim.Text = "Dil Secimi";
                    lblGecerliDil.Text = "Geçerli Dil:";
                    lblKullaniciGiris.Text = "Kullanici Girişi";
                    lblBirinciSayi.Text = "Birinci Sayi";
                    lblİkinciSayi.Text = "İkinci Sayi";
                    btnTopla.Text = "Topla";
                    btnÇıkar.Text = "Çıkar";
                    btnÇarp.Text = "Çarp";
                    btnBöl.Text = "Böl";
                    lblSonuç.Text = "Sonuç";
                    Form1.ActiveForm.Text = "Hesap Makinası";
                selectLanguage = 1;

                #endregion

            }
            else
            {
                Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture =
                   new System.Globalization.CultureInfo("en");
                #region Temporary Field Setting

                lblDilSecim.Text = "Language selection";
                lblGecerliDil.Text = "Current Language:";
                lblKullaniciGiris.Text = "User login";
                lblBirinciSayi.Text = "First Number";
                lblİkinciSayi.Text = "Second Number";
                btnTopla.Text = "Add";
                btnÇıkar.Text = "Subtract";
                btnÇarp.Text = "Multiply";
                btnBöl.Text = "Divide";
                lblSonuç.Text = "Result";
                Form1.ActiveForm.Text = "Calculator";
                selectLanguage = 2;
                #endregion

            }

            //this.Update();
            //Application.DoEvents();


        }

    }
}
