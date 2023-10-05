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
using System.Xml;

namespace Llista05102023
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<persona> persones = new List<persona>();

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string name = this.Name.Text.ToString().ToUpper();
            string ange = this.Age.Text.ToString();
            ZML zml = new ZML();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(ange))
            {
                int age = int.Parse(ange);
                persona p = new persona(name, age);

                if (!persones.Any(p1 => p1.Name == name || p1.Age == age))
                {
                    persones.Add(p);
                    zml.ShowDialog();
                    string name1 = zml.RetornarNom();
                    int age1 = zml.RetornarEdat();
                    persona p2 = new persona(name1, age1);

                    if (!persones.Any(p1 => p1.Name == name1 || p1.Age == age1))
                    {
                        persones.Add(p2);
                        foreach (persona p1 in persones)
                        {
                            this.Contingut_Dins.Items.Add(p1.Name + " " + p1.Age);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre o la edad del segundo elemento ya existen en la lista.");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre o la edad ya existen en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Introduce un nombre y una edad válida.");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.Contingut_Dins.SelectedItem != null)
            {
                this.Contingut_Dins.Items.Remove(this.Contingut_Dins.SelectedItem);
            }
            else
            {
                this.Contingut_Dins.Items.Clear();
            }
        }
        private void LeftToRight_One_Click(object sender, RoutedEventArgs e)
        {
            if (this.Contingut_Dins.Items.Count > 0)
            {
                this.Contingut_Fora.Items.Add(this.Contingut_Dins.SelectedItem);
                this.Contingut_Dins.Items.Remove(this.Contingut_Dins.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hi ha cap element a la llista");
            }
        }

        private void RightToLeft_One_Click(object sender, RoutedEventArgs e)
        {
            if (this.Contingut_Fora.Items.Count > 0)
            {
                this.Contingut_Dins.Items.Add(this.Contingut_Fora.SelectedItem);
                this.Contingut_Fora.Items.Remove(this.Contingut_Fora.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hi ha cap element a la llista");
            }
        }

        private void LeftToRight_All_Click(object sender, RoutedEventArgs e)
        {
            if (this.Contingut_Dins.Items.Count > 0)
            {
                foreach (var item in this.Contingut_Dins.Items)
                {
                    this.Contingut_Fora.Items.Add(item);
                }

                this.Contingut_Dins.Items.Clear();
            }
            else
            {
                MessageBox.Show("La lista de origen está vacía.");
            }
        }
        private void RightToLeft_All_Click(object sender, RoutedEventArgs e)
        {
            if (this.Contingut_Dins.Items.Count > 0)
            {
                foreach (var item in this.Contingut_Dins.Items)
                {
                    this.Contingut_Fora.Items.Add(item);
                }

                this.Contingut_Dins.Items.Clear();
            }
            else
            {
                MessageBox.Show("La lista de origen está vacía.");
            }
        }
    }
}
