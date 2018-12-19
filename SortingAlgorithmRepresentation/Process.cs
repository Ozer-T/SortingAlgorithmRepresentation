using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmRepresentation
{
    class Process
    {
        public void FindTheLengthsOfTheLines( double[] Length_of_The_Lines, int[] randomcizgiler_x, int[] randomcizgiler_y)
        {
            for (int i = 0; i < Length_of_The_Lines.Length; i++)
            {
                Length_of_The_Lines[i] = Math.Sqrt(Math.Pow(randomcizgiler_x[i], 2) + Math.Pow(randomcizgiler_y[i], 2));
            }
        }


        public void RandomNumbers( int[] randomcizgiler_x,  int[] randomcizgiler_y, int MariginX, int MariginY, int LineCount, Random rnd, int CANVAS_WIDTH, int CANVAS_HEIGHT)
        {
            randomcizgiler_y[0] = rnd.Next(0, CANVAS_HEIGHT);

            for (int x = 1; x < LineCount; x++)
            {
                do
                {
                    randomcizgiler_x[x - 1] = MariginX + rnd.Next(CANVAS_WIDTH);
                    randomcizgiler_x[x] = MariginX + rnd.Next(CANVAS_WIDTH);
                } while ((randomcizgiler_x[x - 1] == randomcizgiler_x[x]));

                do
                {
                    randomcizgiler_y[x - 1] = MariginY + rnd.Next(0, CANVAS_HEIGHT);
                    randomcizgiler_y[x] = MariginY + rnd.Next(CANVAS_HEIGHT);
                } while ((randomcizgiler_y[x - 1] == randomcizgiler_y[x]));
            }
        }

        public void Random_Numbers_For_Colors( short[] Color_R,  short[] Color_G,  short[] Color_B, Random rnd)
        {

            Color_R[0] = (short)Math.Round(0.0f + rnd.Next(255));
            Color_G[0] = (short)Math.Round(0.0f + rnd.Next(255));
            Color_B[0] = (short)Math.Round(0.0f + rnd.Next(255));

            for (int x = 1; x < Color_R.Length; x++)
            {
                while ((Color_R[x - 1] == Color_R[x]))
                    Color_R[x] = (short)Math.Round(0.0f + rnd.Next(255));

                while ((Color_G[x - 1] == Color_G[x]))
                    Color_G[x] = (short)Math.Round(0.0f + rnd.Next(255));

                while ((Color_B[x - 1] == Color_B[x]))
                    Color_B[x] = (short)Math.Round(0.0f + rnd.Next(255));
            }
        }


    }
}
