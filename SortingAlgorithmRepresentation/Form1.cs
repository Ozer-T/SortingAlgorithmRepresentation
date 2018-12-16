﻿//LINECOUNT A BAŞTA GIRMEDIĞINDEN HEP 1000 TANE ÇIZGI CIZIYOR. Ve Sorting Yapmıyor (COunting i ayarlamadım daha.)//line count a default olarak ihtiyacı var
// ama bu benim işime gelmiyor. gel biz en  iyisi list kullanalım. oradan diziye çekeriz ama o zaman da verimsiz olur.
//Dizilerin hepsine bak bakalım oraya koymamıza gerek var mı diye
//textboxlardan hepsini kullandığına emin ol!
//Hadi ben kaçtım pampa!!

//Counting sort ile uğraş
//button2 click in için idoldur.
//algoritmaların içini kendin yazarak doldur.
//testlerini yap 
//yorum satırı olan her yere bak da kısalt veya sil oraları"



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmRepresentation
{
    public partial class Form1 : Form
    {
        //bu fazla olmuş silinebilir.  public enum SortingAlgorithmNames{Counting_Sort,Merge_Sort,Bubble_Sort}

        private bool buttonState = false;//Program has not actived yet.
        public Random rnd = new Random((int)DateTime.Now.Ticks);

        public static int LINE_COUNT;
        public static int MARGIN_X = 0, MARGIN_Y = 0;
        public short[] ColorRED, ColorGREEN, ColorBLUE;
        public static int[] randomcizgiler_x, randomcizgiler_y;
        public static double[] Length_of_The_Lines, SORTED_Length_of_The_Lines;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Graphics g;



        /*
        Int32 PEN_THICKNESS = 4;
        PEN_THICKNESS = Convert.ToInt32(txt_PenThickness.Text);




        //Array.Sort<float>(randomcizgiler_x);
        Array.Sort<float>(randomcizgiler_y);

        FindTheLengthsOfTheLines(ref Length_of_The_Lines, randomcizgiler_x, randomcizgiler_y);
        counting_Sort(Length_of_The_Lines, ref SORTED_Length_of_The_Lines);





        for (int i = 1; i<Length_of_The_Lines.Length; i++)
        {
            colorfulPen.Color = Color.FromArgb(255, (int) Color_R[i - 1], (int)Color_G[i - 1], (int) Color_B[i - 1]);
        //g.DrawLine(colorfulPen, randomcizgiler_x[i - 1], randomcizgiler_y[i - 1], randomcizgiler_x[i], randomcizgiler_y[i]);//Bunu aktif hale getirirsen çizgiler RASTGELE yerlerde olur.
        g.DrawLine(colorfulPen, canvas.Width/2,canvas.Height/2, randomcizgiler_x[i], randomcizgiler_y[i]);//Bunu aktif hale getirirsen çizgiler MERKEZDE olur.



            //Thread.Sleep(1);
            



    */

            
        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            cmb_Sorting_Algorithms.Items.Add("Counting Sort");
            cmb_Sorting_Algorithms.Items.Add("Merge Sort");
            cmb_Sorting_Algorithms.Items.Add("Bubble Sort");
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            DataVisualization DataVisualizer = new DataVisualization();
            Rectangle canvasRectangle = new Rectangle(canvas.Location.X, canvas.Location.Y, canvas.Width, canvas.Height);
            PaintEventArgs paintevent = new PaintEventArgs(g, canvasRectangle);
            Process Myprocess = new Process();



            buttonState = !buttonState;

            if (buttonState)
            {
                button2.Text = "STARTED!";
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                LINE_COUNT = Convert.ToInt32(textBox2.Text);
                
            
                randomcizgiler_x = new int[LINE_COUNT];
                randomcizgiler_y = new int[LINE_COUNT];
                Length_of_The_Lines = new double[LINE_COUNT];
                SORTED_Length_of_The_Lines = new double[LINE_COUNT];
                ColorRED = new short[LINE_COUNT];
                ColorGREEN = new short[LINE_COUNT];
                ColorBLUE = new short[LINE_COUNT];

                MessageBox.Show("Line count : " + LINE_COUNT);

                Myprocess.RandomNumbers(ref randomcizgiler_x, ref randomcizgiler_y, MARGIN_X, MARGIN_Y, LINE_COUNT, rnd, canvas.Width, canvas.Height);

                // burada üstteki düzgün çalışıyor mu diye kontrol et ve ekrana vea textboza bastırarak test et !

                  Myprocess.Random_Numbers_For_Colors( ColorRED,  ColorGREEN,  ColorBLUE, rnd);
                
                SortingAlgorithmSelection(cmb_Sorting_Algorithms.SelectedIndex);

                textBox1.Text = "DEMO STARTED";
            }
            else
            {
                button2.Text = "STOPPED!";
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.White;
                g.Clear(Color.AliceBlue);
                textBox1.Text = "DEMO STOPPED";
            }

            //   nesnem.DrawLineWithTexture. += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        }

        private void SortingAlgorithmSelection(int selectedindex)
        {
            SortingAlgorithms sortAlg = new SortingAlgorithms();

            switch (selectedindex)
            {
                case 0:
                    {
                        MessageBox.Show("You have selected the COUNTING SORT");
                        // sortAlg.Counting_Sort_Algorithm(ref randomcizgiler_x,ref randomcizgiler_y);
                        break;
                    }
                case 1:
                    {
                        sortAlg.Merge_Sort_Algorithm(ref randomcizgiler_x, ref randomcizgiler_y);
                        break;
                    }
                case 2:
                    {
                        sortAlg.Bubble_Sort_Algorithm(ref randomcizgiler_x, ref randomcizgiler_y);
                        break;
                    }
            }

        }
    }
}





//EXAMPLE USAGE
/*
 * Point StartLine = new Point(40,40);
 * Point EndLine = new Point(400,500);
 * DataVisualizer.DrawLinesWithShowingStartAndEndCaps(paintevent,StartLine,EndLine,Brushes.CadetBlue, 4.0f);
 * dataVisualizer.DrawLineWithTexture(@"C:\Users\Catorsem\Desktop\texture.png", 7, paintevent);
*/