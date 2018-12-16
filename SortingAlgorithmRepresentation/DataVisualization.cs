using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmRepresentation
{
    class DataVisualization
    {//        private Pen colorfulPen;

        public void DrawLinesWithShowingStartAndEndCaps(PaintEventArgs e, Point StartPosition, Point EndPosition, Brush brushColor, float brushWidth)
        {
            Pen MyPen = new Pen(brushColor, brushWidth);
            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics.DrawLine(MyPen, StartPosition, EndPosition);
            MyPen.Dispose();
        }

        public void DrawWithTexture(bool Selection, string textureFilePath, int penWidth, PaintEventArgs e, int UpperLeft_X_Coordinates, int UpperLeft_Y_Coordinates, int Width, int Height)
        {//Draw ellipse draws picture starts from given upper left coordinates or draws picure according to the given parameters and locations
            Bitmap bitmap = new Bitmap(textureFilePath);
            TextureBrush tBrush = new TextureBrush(bitmap);
            Pen texturedPen = new Pen(tBrush, penWidth);

            if (Selection)
                e.Graphics.DrawImage(bitmap, UpperLeft_X_Coordinates, UpperLeft_Y_Coordinates, bitmap.Width, bitmap.Height);
            else
                e.Graphics.DrawEllipse(texturedPen, UpperLeft_X_Coordinates, UpperLeft_Y_Coordinates, Width, Height);
        }

    }



}
