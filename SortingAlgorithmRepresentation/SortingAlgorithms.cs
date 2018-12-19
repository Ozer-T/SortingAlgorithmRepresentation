using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmRepresentation
{
    class SortingAlgorithms
    {
        
        public void Counting_Sort_Algorithm(int[] X_Values,int[] Y_Values)
        {
           
            /*
            // find smallest and largest value
            double minVal = X_Values[0];
            double maxVal = X_Values[0];
            for (int i = 1; i < X_Values.Length; i++)
            {
                if (X_Values[i] < minVal) minVal = X_Values[i];
                else if (X_Values[i] > maxVal) maxVal = X_Values[i];
            }

            // init array of frequencies
            float[] counts = new float[(int)(maxVal - minVal + 1)];

            // init the frequencies
            for (int i = 0; i < X_Values.Length; i++)
            {
                counts[(int)(X_Values[i] - minVal)]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = X_Values.Length - 1; i >= 0; i--)
            {
                Y_Values[(int)(counts[(int)(X_Values[i] - minVal)]--)] = X_Values[i];
            }
            */


        }

        public void Merge_Sort_Algorithm(int[] X_Values,int[] Y_Values)
        {



        }
        public void Bubble_Sort_Algorithm(int[] X_Values,int[] Y_Values)
        {



        }
    }
}
