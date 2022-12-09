using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFormChecking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void BtnRegistreren_Click(object sender, RoutedEventArgs e)
        {
            int aantalPogingen = 0;
            lblNaamRequired.Content = "";
            lblEmailRequired.Content = "";
            lblGeboortedatumRequired.Content = "";
            lblProfielRequired.Content = "";
            lblPaswoordRequired.Content = "";
            lblGeslachtRequired.Content = "";
            lblInteressesRequired.Content = "";

            if (txtNaam.Text=="")
            {
                lblNaamRequired.Content = "Naam moet ingevuld zijn";
                aantalPogingen++;
            }
            if (txtEmail.Text == "")
            {
                lblEmailRequired.Content = "Email moet ingevuld zijn";
                aantalPogingen++;
            }
            if (dateGeboortedatum.SelectedDate == null)
            {
                lblGeboortedatumRequired.Content = "Datum moet ingevuld zijn";
                aantalPogingen++;
            }
            if (cmbProfiel.SelectedItem == null || cmbProfiel.SelectedIndex == 0)
            {
                lblProfielRequired.Content = "Maak een keuze";
                aantalPogingen++;  
            }
            if (pwbPassword.Password.Length == 0)
            {
                lblPaswoordRequired.Content = "Kies een paswoord";
                aantalPogingen++;
            }
            if (rdbMan.IsChecked != true && rdbVrouw.IsChecked != true)
            {
                lblGeslachtRequired.Content = "Kies een geslacht";
                aantalPogingen++;
            }
            if (chkProgrammeren.IsChecked != true && chkNetwerken.IsChecked != true && chkBusiness.IsChecked != true)
            {
                lblInteressesRequired.Content = "Kies minstens één interesse";
                aantalPogingen++;
            }
            


            lblResultaat.Content = $"dit formulier bevat {aantalPogingen} fout(en)";
            if (aantalPogingen == 0)
            {
                lblResultaat.Content = "bedankt voor de registratie";
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            // alle labels wissen
            lblNaamRequired.Content = "";
            lblEmailRequired.Content = "";
            lblGeboortedatumRequired.Content = "";
            lblProfielRequired.Content = "";
            lblPaswoordRequired.Content = "";
            lblGeslachtRequired.Content = "";
            lblInteressesRequired.Content = "";
            lblResultaat.Content = "";

            // alle content wissen
            txtNaam.Text = "";
            txtEmail.Text = "";
            dateGeboortedatum.SelectedDate = null;
            cmbProfiel.SelectedIndex = 0;
            pwbPassword.Password = "";
            rdbMan.IsChecked = false;
            rdbVrouw.IsChecked = false;
            chkBusiness.IsChecked = false;
            chkNetwerken.IsChecked = false;
            chkProgrammeren.IsChecked = false;

        }
    }
}
