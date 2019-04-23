using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Telop
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        [System.Obsolete]
        public MainWindow()
        {
            InitializeComponent();
            Typeface typeface = new Typeface(MediaTitles.FontFamily,
                     MediaTitles.FontStyle, MediaTitles.FontWeight, MediaTitles.FontStretch);
            MediaTitles.Background = new DrawingBrush(GetFrameDrawing(MediaTitles.Text, typeface));
        }

        [System.Obsolete]
        private Drawing GetFrameDrawing(string textString, Typeface typeface)
        {
            var formattedText = new FormattedText(
                "Hello World",
                CultureInfo.CurrentCulture,
                flowDirection: FlowDirection.LeftToRight,
                typeface: typeface,
                emSize: 12,
                foreground: new SolidColorBrush()
            );
            var inBrush = new SolidColorBrush(Color.FromArgb(200, 255, 255, 255));
            Geometry textGeometry = formattedText.BuildGeometry(new Point(0, 0));
            //LinearGradientBrush brush = new LinearGradientBrush(
            //    Colors.YellowGreen,
            //    Colors.SkyBlue,
            //    new Point(0.1, 0), new Point(0.4, 1)
            //);
            //var drawing = new GeometryDrawing(inBrush, new Pen(Brushes.Black, 0.3),
            //                                     textGeometry);
            var drawing = new GeometryDrawing(inBrush, new Pen(Brushes.Black, 0.3), textGeometry);
            return drawing;
        }
    }
}
