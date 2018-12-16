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
            

            //dataVisualizer.DrawLineWithTexture(@"C:\Users\Catorsem\Desktop\texture.png", 7, paintevent);
               //--------------------------//

            /*
            // find smallest and largest value
            double minVal = length_of_lines[0];
            double maxVal = length_of_lines[0];
            for (int i = 1; i < length_of_lines.Length; i++)
            {
                if (length_of_lines[i] < minVal) minVal = length_of_lines[i];
                else if (length_of_lines[i] > maxVal) maxVal = length_of_lines[i];
            }

            // init array of frequencies
            float[] counts = new float[(int)(maxVal - minVal + 1)];

            // init the frequencies
            for (int i = 0; i < length_of_lines.Length; i++)
            {
                counts[(int)(length_of_lines[i] - minVal)]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = length_of_lines.Length - 1; i >= 0; i--)
            {
                SORTED_Length_of_The_Lines[(int)(counts[(int)(length_of_lines[i] - minVal)]--)] = length_of_lines[i];
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
