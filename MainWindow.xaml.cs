//David Laughton
//May 27th 2019
//Game of life

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
using System.Windows.Threading;

namespace u5GameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<Button> list = new List<Button>();
        private DispatcherTimer gameTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();           

            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Button w = new Button();
                    w.Height = 20;
                    w.Width = 20;
                    canvas.Children.Add(w);
                    Canvas.SetTop(w, i * 20);
                    Canvas.SetLeft(w, j * 20);
                    w.Click += (sender, RoutedEventArgs) => { btn1_Click(sender, RoutedEventArgs, w); };
                }
            }
            Button s = new Button();
            s.Height = 20;
            s.Width = 425;
            s.Content = "click to run";
            canvas.Children.Add(s);
            Canvas.SetBottom(s, 0);            
            s.Click += new RoutedEventHandler(StartBtn_Click);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach (Button f in list)
            {
                if
                {

                }
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {            
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 10);
        }
        private void btn1_Click(object sender, RoutedEventArgs e, Button f)
        {
            f.Background = Brushes.Black;           
            Button clickedButton = (Button)sender;
            clickedButton.IsEnabled = true;
            list.Add(f);
        }
    }
}
