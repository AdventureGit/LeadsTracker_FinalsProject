﻿using Microsoft.Win32;
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

namespace LeadsTracker_FinalsProject
{
	/// <summary>
	/// Interaction logic for Menu.xaml
	/// </summary>
	public partial class Menu : Window
	{
		public Menu()
		{				
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse Photos...";
            ofd.DefaultExt = "png";
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";          

            ofd.ShowDialog();

            if (ofd.FileName.Length > 0)
            {
                txtPath.Text = ofd.FileName;
            }   
        }
    }
}
	