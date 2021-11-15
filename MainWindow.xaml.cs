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
using System.Windows.Ink;
using Microsoft.Win32;

namespace WPF_Paint
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum enumSize 
        {
            Thin = 5,
            Normal = 10,
            Thick = 15,
        }

        public MainWindow()
        {
            InitializeComponent();

            defaultSettings();
            checkThickness();            
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Eraser_Click(object sender, RoutedEventArgs e)
        {
            checkThickness();
            Canvas_DrawingArea.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void Button_Pen_Click(object sender, RoutedEventArgs e)
        {
            checkThickness();
            Canvas_DrawingArea.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Button_SelectArea_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.EditingMode = InkCanvasEditingMode.None;
        }

        private void line_thin_Checked(object sender, RoutedEventArgs e)
        {
            if (Canvas_DrawingArea != null)
            {
                switch (Canvas_DrawingArea.EditingMode)
                {
                    case (InkCanvasEditingMode.Ink):
                        Canvas_DrawingArea.DefaultDrawingAttributes.Width = 5;
                        Canvas_DrawingArea.DefaultDrawingAttributes.Height = 5;
                        break;
                    case (InkCanvasEditingMode.EraseByPoint):
                        Canvas_DrawingArea.EraserShape = new EllipseStylusShape(5, 5);
                        break;
                    default:
                        break;
                }
            }
        }

        private void line_normal_Checked(object sender, RoutedEventArgs e)
        {
            if (Canvas_DrawingArea != null)
            {
                switch (Canvas_DrawingArea.EditingMode)
                {
                    case (InkCanvasEditingMode.Ink):
                        Canvas_DrawingArea.DefaultDrawingAttributes.Width = 10;
                        Canvas_DrawingArea.DefaultDrawingAttributes.Height = 10;
                        break;
                    case (InkCanvasEditingMode.EraseByPoint):
                        Canvas_DrawingArea.EraserShape = new EllipseStylusShape(10, 10);
                        break;
                    default:
                        break;
                }
            }
        }

        private void line_thick_Checked(object sender, RoutedEventArgs e)
        {
            if (Canvas_DrawingArea != null)
            {
                switch (Canvas_DrawingArea.EditingMode)
                {
                    case (InkCanvasEditingMode.Ink):
                        Canvas_DrawingArea.DefaultDrawingAttributes.Width = 15;
                        Canvas_DrawingArea.DefaultDrawingAttributes.Height = 15;
                        break;
                    case (InkCanvasEditingMode.EraseByPoint):
                        Canvas_DrawingArea.EraserShape = new EllipseStylusShape(15, 15);
                        break;
                    default:
                        break;
                }
            }
        }

        private void defaultSettings()
        {
            Canvas_DrawingArea.EditingMode = InkCanvasEditingMode.None;
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Black;
            Canvas_DrawingArea.DefaultDrawingAttributes.Width = (int)enumSize.Thin;
            Canvas_DrawingArea.DefaultDrawingAttributes.Height = (int)enumSize.Thin;
            Canvas_DrawingArea.EraserShape = new EllipseStylusShape(5, 5);
        }

        private void checkThickness()
        {
            if (line_thin.IsChecked == true)
            {
                Canvas_DrawingArea.DefaultDrawingAttributes.Width = (int)enumSize.Thin;
                Canvas_DrawingArea.DefaultDrawingAttributes.Height = (int)enumSize.Thin;
                Canvas_DrawingArea.EraserShape = new EllipseStylusShape(5, 5);
            }
            else if (line_normal.IsChecked == true)
            {
                Canvas_DrawingArea.DefaultDrawingAttributes.Width = (int)enumSize.Normal;
                Canvas_DrawingArea.DefaultDrawingAttributes.Height = (int)enumSize.Normal;
                Canvas_DrawingArea.EraserShape = new EllipseStylusShape(10, 10);
            }
            else if (line_thick.IsChecked == true)
            {
                Canvas_DrawingArea.DefaultDrawingAttributes.Width = (int)enumSize.Thick;
                Canvas_DrawingArea.DefaultDrawingAttributes.Height = (int)enumSize.Thick;
                Canvas_DrawingArea.EraserShape = new EllipseStylusShape(15, 15);
            }
        }

        private void Grid_Black_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void Grid_White_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void Grid_DimGray_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.DimGray;
        }

        private void Grid_Brown_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Brown;
        }

        private void Grid_Red_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Grid_OrangeRed_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.OrangeRed;
        }

        private void Grid_Gold_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Gold;
        }

        private void Grid_Cyan_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Cyan;
        }

        private void Grid_Blue_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Grid_Green_Click(object sender, RoutedEventArgs e)
        {
            Canvas_DrawingArea.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            var rect = new Rect(Canvas_DrawingArea.RenderSize);
            var renderTargetBitmap = new RenderTargetBitmap((int)rect.Width, (int)rect.Height, 96, 96, PixelFormats.Default);
            var drawingVisual = new DrawingVisual();

            using (var dv = drawingVisual.RenderOpen())
            {
                var vb = new VisualBrush
                {
                    Visual = Canvas_DrawingArea,
                    Viewbox = rect,
                    ViewboxUnits = BrushMappingMode.Absolute
                };

                dv.DrawRectangle(vb, null, rect);
            }
            renderTargetBitmap.Render(drawingVisual);

            BitmapEncoder bitmapEncoder = new PngBitmapEncoder();
            bitmapEncoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

            try
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();

                bitmapEncoder.Save(memoryStream);
                memoryStream.Close();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = ".png";
                saveFileDialog.Filter = "Image (.png)|*.png";
                string filename = "";
                if (saveFileDialog.ShowDialog() == true)
                    filename = saveFileDialog.FileName;

                System.IO.File.WriteAllBytes(filename, memoryStream.ToArray());
            }
            catch (ArgumentException err)
            {
                MessageBox.Show("Wrong path!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
