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

using Microsoft.Win32; //FileDialog

namespace ClientFacturacion.Views
{
    /// <summary>
    /// Interaction logic for Inicio.xaml
    /// </summary>
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog factura = new OpenFileDialog();
            factura.Multiselect = true;
            factura.Filter = "XML|*.xml";
            factura.DefaultExt = ".xml";
            Nullable<bool> facturaOK = factura.ShowDialog();

            if (facturaOK == true)
            {
                string sFilenames = "";
                foreach (string sFilename in factura.FileNames)
                {
                    sFilenames += ";" + sFilename;
                }
                sFilenames = sFilenames.Substring(1); //delete first
                txtFileNames.Text = sFilenames;
            }
        }
    }
}
