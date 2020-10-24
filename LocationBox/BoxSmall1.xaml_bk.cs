using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LocationBox
{
    /// <summary>
    /// Interaction logic for BoxSmall1.xaml
    /// </summary>
    public partial class BoxSmall1 : UserControl
    {
        public BoxSmall1()
        {
            InitializeComponent();
        }

        private string gCaption = string.Empty;
        private string gCaption1 = string.Empty;
        public string Caption
        {
            set { gCaption = value; }
            get { return gCaption; }
        }

        public void SetCaption()
        {

            this.label1.Content = gCaption;
            //this.TextCaption.Text = gCaption;

        }

        public string Caption1
        {
            set { gCaption1 = value; }
            get { return gCaption1; }
        }

        public void SetCaption1()
        {

            this.label2.Content = gCaption1;
            //this.TextCaption.Text = gCaption;

        }


        #region Method
        public void BoxColorChange()
        {
            RectFront.Fill = new SolidColorBrush(System.Windows.Media.Colors.HotPink);
            RectTop.Fill = new SolidColorBrush(System.Windows.Media.Colors.HotPink);
            RectRight.Fill = new SolidColorBrush(System.Windows.Media.Colors.HotPink);
            
        }

        public void BoxColorFullCapa()
        {
            RectFront.Fill = new SolidColorBrush(System.Windows.Media.Colors.LightGray);
            RectTop.Fill = new SolidColorBrush(System.Windows.Media.Colors.DodgerBlue);
            RectRight.Fill = new SolidColorBrush(System.Windows.Media.Colors.DodgerBlue);
            
        }


        public void BoxColorHasData()
        {
            RectFront.Fill = new SolidColorBrush(System.Windows.Media.Colors.LightGray);
            RectTop.Fill = new SolidColorBrush(System.Windows.Media.Colors.Olive);
            RectRight.Fill = new SolidColorBrush(System.Windows.Media.Colors.Olive);

        }

        public void BoxPolygonColorHasData(bool arg_color)
        {
            if (arg_color)
                Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Orange);
            else
                Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Olive);
        }
        public void BoxPolygonColorFullCapa(bool arg_color)
        {
            if (arg_color)
                Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Orange);
            else
                Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.DodgerBlue);
        }

        public void BoxColorSearch()
        {
            RectFront.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
            RectTop.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            RectRight.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
        }

        public void BoxColorDefault()
        {
            RectFront.Fill = new SolidColorBrush(System.Windows.Media.Colors.LightGray);
            RectTop.Fill = new SolidColorBrush(System.Windows.Media.Colors.Orange);
            RectRight.Fill = new SolidColorBrush(System.Windows.Media.Colors.Orange);
        }

        public void BoxPolyGonNearly()
        {
            
            Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        }

        public void BoxPolygonColor(bool arg_color)
        {
            if (arg_color)
                Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Orange);
            else
                Polygon1.Fill = new SolidColorBrush(System.Windows.Media.Colors.HotPink);
        }


        public void setVisible(bool arg_visible)
        {
            if (arg_visible)
                this.Polygon1.Visibility = System.Windows.Visibility.Visible;
            else
                this.Polygon1.Visibility = System.Windows.Visibility.Hidden;

        }

        public void setSizeBox(int w, int h)
        {
            GridBox.Width = w;
            GridBox.Height = h;

        }



        #endregion

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }


    }
}
