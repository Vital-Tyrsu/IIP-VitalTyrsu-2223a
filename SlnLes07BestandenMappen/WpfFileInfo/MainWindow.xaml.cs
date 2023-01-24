using Microsoft.Win32;
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
using System.IO;

namespace WpfFileInfo
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

        private void ChooseFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string fileText = File.ReadAllText(filePath);
                string lastModifiedDate = File.GetLastWriteTime(filePath).ToString("MM/dd/yyyy hh:mm:ss tt");
                string[] words = fileText.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                lblFilePath.Content = "bestandsnaam" + filePath;
                lblWordCount.Content = "aantal woorden" + wordCount;
                lblFileLaatstaangemaakt.Content = "gemaakt op" + lastModifiedDate;
            }
        }

    }
}
