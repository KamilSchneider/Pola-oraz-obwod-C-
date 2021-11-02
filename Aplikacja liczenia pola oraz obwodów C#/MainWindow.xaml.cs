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

namespace Combo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cb1.Items.Add("aaaaa");
            cb1.Items.Add("bbbbb");
        }

        private void CbZmiana(object sender, SelectionChangedEventArgs e)
        {
            if (cb1.SelectedItem != null)
                MessageBox.Show(cb1.SelectedItem.ToString());
        }

        private void CbNajechanieMyszka(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Najechano");
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (!cb1.Items.Contains(tb1.Text))
                cb1.Items.Add(tb1.Text);
        }

        private void btUsun_Click(object sender, RoutedEventArgs e)
        {
            cb1.Items.RemoveAt(cb1.Items.Count - 1);
        }

        private void btUsunKonkretny_Click(object sender, RoutedEventArgs e)
        {
            cb1.Items.Remove(tb1.Text);
        }

        private void textBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        //private void butA_Click(object sender, RoutedEventArgs e)
        //{
        //    dodajElementDoCombo("A");
        //    //if (!cb1.Items.Contains("A"))
        //    //    cb1.Items.Add("A");
        //}

        //private void butB_Click(object sender, RoutedEventArgs e)
        //{
        //    dodajElementDoCombo("B");
        //    //if (!cb1.Items.Contains("B"))
        //    //    cb1.Items.Add("B");
        //}

        //private void butC_Click(object sender, RoutedEventArgs e)
        //{
        //    dodajElementDoCombo("C");
        //    //if (!cb1.Items.Contains("C"))
        //    //    cb1.Items.Add("C");
        //}

        private void dodajElementDoCombo(string element)
        {
            if (!string.IsNullOrWhiteSpace(element) && !cb1.Items.Contains(element))
                cb1.Items.Add(element);
        }

        private void butDodaj_Click(object sender, RoutedEventArgs e)
        {
            //if (sender != null && sender is Button)
            //{
            //    Button but = sender as Button; // (Button)sender
            //    string txt = but.Content.ToString();               
            //    txt = txt.Remove(0, txt.Length-1); // Dodaj A 
            //    dodajElementDoCombo(txt);
            //}

            if (sender != null && sender is Button)
            {
                //Button but = sender as Button; // (Button)sender
                //string txt = but.CommandParameter.ToString();
                //dodajElementDoCombo(txt);
                dodajElementDoCombo((sender as Button).CommandParameter.ToString());
            }
        }

    }
}
