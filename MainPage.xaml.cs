using GridViewAutoSizeSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GridViewAutoSizeSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MyDataViewModel viewModel = new MyDataViewModel();

        public MainPage()
        {
            this.InitializeComponent();               
            this.DataContext = viewModel;
        }

        private void MyGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MyGridView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ItemsWrapGrid MyItemsPanel = (ItemsWrapGrid)MyGridView.ItemsPanelRoot;            

            int ItemsNumber = MyGridView.Items.Count;

            // Based on screensize determine how many items to show in a row
            double currentGridViewWidth = e.NewSize.Width;
            double currentGridViewHeight = e.NewSize.Height;

            int itemsPerRow = 0;

            if (currentGridViewWidth > 1600)
            {
                itemsPerRow = 6;
                MyItemsPanel.MaximumRowsOrColumns = 6;
            }
            else if (currentGridViewWidth > 1200)
            {
                itemsPerRow = 5;
                MyItemsPanel.MaximumRowsOrColumns = 5;
            }
            else if (currentGridViewWidth > 900)
            {
                itemsPerRow = 4;
                MyItemsPanel.MaximumRowsOrColumns = 4;
            }
            else if (currentGridViewWidth > 600)
            {
                itemsPerRow = 3;
                MyItemsPanel.MaximumRowsOrColumns = 3;
            }
            else if (currentGridViewWidth > 400)
            {
                itemsPerRow = 2;
                MyItemsPanel.MaximumRowsOrColumns = 2;
            }
            else
            {
                itemsPerRow = 1;
                MyItemsPanel.MaximumRowsOrColumns = 1;
            }

            int myMargin = 0;

            double newWidth = (currentGridViewWidth - myMargin) / (double)itemsPerRow;
            double newHeight = newWidth * .4;

            // Now, knowing the height and the total number of items in our list and the number of items in a row...
            // If we have extra screen space let's recalc the height to make items fill the screen.
            var numRows = MyGridView.Items.Count / itemsPerRow;
            numRows += ((MyGridView.Items.Count % itemsPerRow) == 0) ? 0 : 1;

            if (numRows * newHeight < currentGridViewHeight)
                newHeight = currentGridViewHeight / numRows;

            MyItemsPanel.ItemWidth = newWidth;
            MyItemsPanel.ItemHeight = newHeight;

        }

        private void ShowPopup(object sender, TappedRoutedEventArgs e)
        {
            // open the Popup if it isn't open already 
            if (SettingsPopup.Visibility == Visibility.Collapsed) {
                SelectedBackgroundImage.Source = ((sender as Grid).Children[0] as Image).Source;
                SelectedOverlayImage.Source = ((sender as Grid).Children[1] as Image).Source;

                SettingsPopup.Visibility = Visibility.Visible;                
            }
        }

        private void HidePopup(object sender, TappedRoutedEventArgs e)
        {
            // if the Popup is open, then close it 
            if (SettingsPopup.Visibility== Visibility.Visible) { SettingsPopup.Visibility= Visibility.Collapsed; }
        }
    }
    
}
