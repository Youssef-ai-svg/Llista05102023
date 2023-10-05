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
using System.Windows.Shapes;

namespace Llista05102023
{
    /// <summary>
    /// Lógica de interacción para ZML.xaml
    /// </summary>
    public partial class ZML : Window
    {
        public ZML()
        {
            InitializeComponent();
        }
        public string RetornarNom()
        {
            return this.Name1.Text.ToString().ToUpper();
        }
        public int RetornarEdat()
        {
            return int.Parse(this.Age2.Text.ToString());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
