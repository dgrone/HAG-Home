using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using HAG_HomeLights.Global;
using HAG_HomeLights.Models;

namespace HAG_HomeLights
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public HAGProject HAGProjectInfo { get; set; }
        public LampInfo HAGLampInfo { get; set; }

        Point _LastPoint;
        Image? _LastImage = null;
        List<LampInfo> _LampList = new List<LampInfo>();
        int _GroupInc = 1;

        public MainWindow()
        {
            InitializeComponent();
            CreateProjectInfos();
            CreateLampInfo();
            CreateEventOrder();
            this.DataContext = this;
        }

        private void CreateLampInfo()
        {
            HAGLampInfo = new LampInfo();
            HAGLampInfo.Width = 20;
            HAGLampInfo.Group = "Gruppe " + GetGroup();
        }

        private int GetGroup()
        {
            return _GroupInc++;
        }

        private void CreateProjectInfos()
        {
            HAGProjectInfo = new HAGProject();
            HAGProjectInfo.Name = "Unbenanntes Projekt";
            HAGProjectInfo.Description = "Projektbeschreibung";
            HAGProjectInfo.Created = DateTime.Now;
            HAGProjectInfo.Updated = DateTime.Now;
        }

        private void CreateEventOrder()
        {
            CanvasSettings.MouseLeftButtonDown += Window_MouseLeftButtonDown;
            CanvasImage.MouseDown += Window_MouseDown;
            CanvasImageLights.MouseDown += Window_MouseDownLights;

            ProjectSettings.MouseEnter += ProjectSettings_MouseEnter;
            ProjectSettings.MouseLeave += ProjectSettings_MouseLeave;
            ProjectSettings.MouseDown += ProjectSettings_MouseDown;

        }

        private void Window_MouseDownLights(object sender, MouseButtonEventArgs e)
        {
            _LastPoint = G.GetInvalidPoint();
            foreach (Image lImage in CanvasImageLights.Children)
            {
                if (IsPointThere(lImage, e.GetPosition(this)))
                {
                    _LastPoint = e.GetPosition(this);
                    _LastImage = lImage;
                }
            }
        }

        private bool IsAlreadyImageOnPosition(Point aMousePoint)
        {
            foreach (Image lImage in CanvasImageLights.Children)
            {
                if (IsPointThere(lImage, aMousePoint))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsPointThere(Image aImage, Point aPoint)
        {
            double Y = Canvas.GetTop((UIElement)aImage);
            double X = Canvas.GetLeft((UIElement)aImage);

            double aImageWidth = aImage.Width;
            double aImageHeight = aImage.Width;

            if((aPoint.X > X) && aPoint.X < (X + aImageWidth) && (aPoint.Y > Y) && aPoint.Y < (Y + aImageHeight))
            {
                aImage.Opacity = 0.5;
                return true;

            }

            aImage.Opacity = 1;
            return false;

        }

        private void ProjectSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ContextMenu contextMenu = ProjectSettings.ContextMenu;
            contextMenu.PlacementTarget = ProjectSettings;
            contextMenu.IsOpen = true;
            e.Handled = true;
        }

        private void ProjectSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            ProjectSettings.Opacity = 1;
        }

        private void ProjectSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = null;
            ProjectSettings.Opacity = 0.5;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                AddLightOnCavas(e.GetPosition(this), HAGLampInfo.Width);

        }

        private void AddLightOnCavas(Point aPoint, int aWidth = 25)
        {
            if (IsAlreadyImageOnPosition(aPoint)) // Gucken, ob bereits eine Lampe an der Position ist
                return;

            Image lFinalImage = new Image();
            lFinalImage.Width = aWidth;
            BitmapImage lImageLight = new BitmapImage();
            lImageLight.BeginInit();
            lImageLight.UriSource = new Uri("pack://siteoforigin:,,,/Resources/light_on.png");
            lImageLight.EndInit();
            lFinalImage.Source = lImageLight;

            int lLampPosXAbzug = (int)lFinalImage.Width / 2;
            Point lImagePoint = new Point(aPoint.X - lLampPosXAbzug, aPoint.Y - lLampPosXAbzug);
            Canvas.SetTop(lFinalImage, lImagePoint.Y);
            Canvas.SetLeft(lFinalImage, lImagePoint.X);

            //Seperate Liste führen zum Speichern
            LampInfo lImageInfo = new LampInfo();
            lImageInfo.Width = aWidth;
            lImageInfo.Point = lImagePoint;
            lImageInfo.Image = lFinalImage;
            lImageInfo.Group = HAGLampInfo.Group;
            _LampList.Add(lImageInfo);

            CanvasImageLights.Children.Add(lFinalImage);

            HAGProjectInfo.InstalledLights++;
        }

        private void DeleteLampInList(Image aImage)
        {
            foreach (var l in _LampList)
            {
                if (l.Image == aImage)
                {
                    _LampList.Remove(l);
                    break;
                }
            }
        }

        private LampInfo? GetLampInList(Image aImage)
        {
            foreach (var l in _LampList)
            {
                if (l.Image == aImage)
                {
                    return l;
                }
            }
            return null;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void DeleteLampOnCanvas(object sender, RoutedEventArgs e)
        {
            if(G.IsPointValid(_LastPoint) && _LastImage != null)
            {
                DeleteLampInList(_LastImage);
                CanvasImageLights.Children.Remove(_LastImage);
                _LastImage = null;
                HAGProjectInfo.InstalledLights--;
            }

        }

        private void EditLampOnCanvas(object sender, RoutedEventArgs e)
        {
            if (G.IsPointValid(_LastPoint) && _LastImage != null)
            {
                LampInfo lLampInfo = GetLampInList(_LastImage);
                HAGLampInfo.Group = lLampInfo.Group;
                HAGLampInfo.Width = lLampInfo.Width;
            }
        }

        private void GroupTextEdit(object sender, TextChangedEventArgs e)
        {
            HAGLampInfo.Group = ((TextBox)sender).Text;
        }
    }
}
