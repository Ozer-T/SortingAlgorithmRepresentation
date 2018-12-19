//fill the sorting algorithms
//Use thread to draw and by doing that use start-stop button to sudden interference to the process (May be added additional button fot that either).
//Handle with the exceptions like entering a nonnumeric character to the input!
//Add more sortingAlgorithms as methods and also to combobox.
//make the form compatible with all screen sizes on Windows!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmRepresentation
{
    public partial class Form1 : Form
    {

        private bool buttonState = false;//Program has not actived yet.
        public Random rnd = new Random((int)DateTime.Now.Ticks);

        public static int LINE_COUNT;
        public static int MARGIN_X = 0, MARGIN_Y = 0;
        public short[] ColorRED, ColorGREEN, ColorBLUE;
        public static int[] randomcizgiler_x, randomcizgiler_y;
        public static double[] Length_of_The_Lines, SORTED_Length_of_The_Lines;
        public Graphics g;
        Rectangle canvasRectangle;
        Process Myprocess;
        PaintEventArgs paintevent;
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            cmb_Sorting_Algorithms.Items.Add("Counting Sort");
            cmb_Sorting_Algorithms.Items.Add("Merge Sort");
            cmb_Sorting_Algorithms.Items.Add("Bubble Sort");
            cmb_Sorting_Algorithms.Items.Add("Visualize the array sequentialy (Not Sorting)");
            cmb_Sorting_Algorithms.Items.Add("Visualize an array (Not Sorting)");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            Myprocess = new Process();

            buttonState = !buttonState;

            if (buttonState)
            {
                button2.Text = "STARTED!";
                textBox1.Text = "DEMO STARTED";
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                LINE_COUNT = Convert.ToInt32(textBox2.Text);


                progressBar1.Maximum = LINE_COUNT;

                randomcizgiler_x = new int[LINE_COUNT];
                randomcizgiler_y = new int[LINE_COUNT];
                Length_of_The_Lines = new double[LINE_COUNT];
                SORTED_Length_of_The_Lines = new double[LINE_COUNT];
                ColorRED = new short[LINE_COUNT];
                ColorGREEN = new short[LINE_COUNT];
                ColorBLUE = new short[LINE_COUNT];


                Myprocess.RandomNumbers(randomcizgiler_x, randomcizgiler_y, MARGIN_X, MARGIN_Y, LINE_COUNT, rnd, canvas.Width, canvas.Height);
                Myprocess.Random_Numbers_For_Colors(ColorRED, ColorGREEN, ColorBLUE, rnd);
                Myprocess.FindTheLengthsOfTheLines(Length_of_The_Lines, randomcizgiler_x, randomcizgiler_y);

                SortingAlgorithmSelection(cmb_Sorting_Algorithms.SelectedIndex);

            }
            else
            {
                button2.Text = "STOPPED!";
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.White;
                g.Clear(Color.AliceBlue);
                textBox1.Text = "DEMO STOPPED";
            }



        }
        


        private void VisualizeTheArray(int[] randomcizgiler_x,int [] randomcizgiler_y)
        {
            paintevent = new PaintEventArgs(g, canvasRectangle);
            canvasRectangle = new Rectangle(canvas.Location.X, canvas.Location.Y, canvas.Width, canvas.Height);
            progressBar1.Value = 0;

            Brush drawingBrush;
            Point point_end;
            Point point_start = new Point(canvasRectangle.Width / 2, canvasRectangle.Height / 2);
            
            DataVisualization dataVisualizer = new DataVisualization();


            for (int i = 0; i < randomcizgiler_x.Length; i++)
            {
                point_end = new Point(randomcizgiler_x[i], randomcizgiler_y[i]);
                drawingBrush = new SolidBrush(Color.FromArgb(Convert.ToInt32(ColorRED[i]), Convert.ToInt32(ColorBLUE[i]), Convert.ToInt32(ColorBLUE[i])));
                dataVisualizer.DrawLinesWithShowingStartAndEndCaps(paintevent, point_start, point_end, drawingBrush, 2.0f);
                
                progressBar1.Increment(1);
                progressBar1.Refresh();
            }
            
        } 

        private void VisualizeTheArraySequential(int[] randomcizgiler_x, int[] randomcizgiler_y)
        {
            paintevent = new PaintEventArgs(g, canvasRectangle);
            canvasRectangle = new Rectangle(canvas.Location.X, canvas.Location.Y, canvas.Width, canvas.Height);
            progressBar1.Value = 0;

            Brush drawingBrush;
            Point point_end;

            DataVisualization dataVisualizer = new DataVisualization();


            for (int i = 1; i < randomcizgiler_x.Length; i++)
            {
                Point point_start = new Point(randomcizgiler_x[i-1],randomcizgiler_y[i-1]);
                point_end = new Point(randomcizgiler_x[i], randomcizgiler_y[i]);
                drawingBrush = new SolidBrush(Color.FromArgb(Convert.ToInt32(ColorRED[i]), Convert.ToInt32(ColorBLUE[i]), Convert.ToInt32(ColorBLUE[i])));
                dataVisualizer.DrawLinesWithShowingStartAndEndCaps(paintevent, point_start, point_end, drawingBrush, 2.0f);

                progressBar1.Increment(1);
                progressBar1.Refresh();
            }

        }


        private void SortingAlgorithmSelection(int selectedindex)
        {
            
            SortingAlgorithms sortAlg = new SortingAlgorithms();

            switch (selectedindex)
            {
                case 0:
                    {
                        sortAlg.Counting_Sort_Algorithm(randomcizgiler_x, randomcizgiler_y);
                        break;
                    }
                case 1:
                    {
                        sortAlg.Merge_Sort_Algorithm(randomcizgiler_x, randomcizgiler_y);
                        break;
                    }
                case 2:
                    {
                        sortAlg.Bubble_Sort_Algorithm(randomcizgiler_x, randomcizgiler_y);
                        break;
                    }
                case 3:
                    {
                        VisualizeTheArraySequential(randomcizgiler_x, randomcizgiler_y);//This draws the lines between each lines 
                        break;
                    }
                case 4:
                    {
                        VisualizeTheArray(randomcizgiler_x, randomcizgiler_y);
                        break;
                    }
            
            }

        }
    }
}






