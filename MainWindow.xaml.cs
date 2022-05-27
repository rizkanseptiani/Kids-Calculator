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

namespace Calkulator_kids
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
        
        /// variable untuk menghitung
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_seleksi = false;

        /// Untuk menampilkan angka 1
        private void satu_Click_1(object sender, RoutedEventArgs e)
        {
            if(screen.Text == "0")
            {
                screen.Text = "1";
            }
            else
            {
                screen.Text += "1";
            }
            /// screen.Text = screen.Text + "1";
        }

        /// Untuk menampilkan angka 2
        private void dua_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "2";
            }
            else
            {
                screen.Text += "2";
            }
            /// screen.Text = screen.Text + "2";
        }

        /// Untuk menghapus apa yang ada di screen.Text
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "0";
            bil1 = 0;
            bil2 = 0;
            /// screen.Text = "";
        }

        /// Untuk menampilkan tanda koma
        private void koma_Click(object sender, RoutedEventArgs e)
        {
            if (!(screen.Text.Contains(".")))
            {
                screen.Text += ".";
            }
            /// screen.Text = screen.Text + ",";
        }

        /// Untuk menampilkan angka 3
        private void tiga_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "3";
            }
            else
            {
                screen.Text += "3";
            }
            /// screen.Text = screen.Text + "3";
        }

        /// Untuk menampilkan menghapus satu per satu yang ada di screen.Text
        private void hapus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text.Remove(screen.Text.Length - 1);
        }

        /// Untuk menampilkan angka 4
        private void empat_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "4";
            }
            else
            {
                screen.Text += "4";
            }
           /// screen.Text = screen.Text + "4";
        }

        /// Untuk menampilkan angka 5
        private void lima_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "5";
            }
            else
            {
                screen.Text += "5";
            }
            /// screen.Text = screen.Text + "5";
        }

        /// Untuk menampilkan angka 6
        private void enam_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "6";
            }
            else
            {
                screen.Text += "6";
            }
            /// screen.Text = screen.Text + "6";
        }

        /// Untuk menampilkan angka 7
        private void tujuh_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "7";
            }
            else
            {
                screen.Text += "7";
            }
            /// screen.Text = screen.Text + "7";
        }

        /// Untuk menampilkan angka 8
        private void delapan_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "8";
            }
            else
            {
                screen.Text += "8";
            }
            /// screen.Text = screen.Text + "8";
        }

        /// Untuk menampilkan angka 9
        private void sembilan_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "9";
            }
            else
            {
                screen.Text += "9";
            }
            /// screen.Text = screen.Text + "9";
        }

        /// Untuk menampilkan angka 0
        private void nol_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text != "0")
            {
                screen.Text += "0";
            }
           /// screen.Text = screen.Text + "0";
        }

        /// Untuk menampilkan angka 00
        private void double_nol_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text != "0")
            {
                screen.Text += "00";
            }
            /// screen.Text = screen.Text + "00";
        }

        /// Untuk menampilkan hasil perhitungan
        private void result_Click(object sender, RoutedEventArgs e)
        {
            if (opr_seleksi == true)
            {
                string bil = screen.Text;
                bil = bil.Remove(0, 1);
                 bil2 = Convert.ToDecimal(bil);
             }
            {
                switch (opr)
                {
                    /// Untuk menampilkan hasil perkalian
                    case 1:
                        screen.Text = Convert.ToString(bil1 * bil2);
                        break;
                    /// Untuk menampilkan hasil pembagian
                    case 2:
                        screen.Text = Convert.ToString(bil1 / bil2);
                        break;
                    /// Untuk menampilkan hasil pengurangan
                    case 3:
                        screen.Text = Convert.ToString(bil1 - bil2);
                        break;
                    /// Untuk menampilkan hasil penjumlahan
                    case 4:
                        screen.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_seleksi = false;
            }
        }

        /// Untuk menghitung pembagian
        private void bagi_Click(object sender, RoutedEventArgs e)
        {
            bil1 = Convert.ToDecimal(screen.Text);
            screen.Text = ":";
            opr = 2;
            opr_seleksi = true;
        }

        /// Untuk menghitung pengurangan
        private void kurang_Click(object sender, RoutedEventArgs e)
        {
            bil1 = Convert.ToDecimal(screen.Text);
            screen.Text = "-";
            opr = 3;
            opr_seleksi = true;
        }

        /// Untuk menghitung penjumlahan
        private void tambah_Click(object sender, RoutedEventArgs e)
        {
            bil1 = Convert.ToDecimal(screen.Text);
            screen.Text = "+";
            opr = 4;
            opr_seleksi = true;
        }

        /// Untuk menghitung perkalian
        private void kali_Click(object sender, RoutedEventArgs e)
        {
            bil1 = Convert.ToDecimal(screen.Text);
            screen.Text = "x";
            opr = 1;
            opr_seleksi = true;
        }
    }
}
