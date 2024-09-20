using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drones.View
{
    public partial class Building
    {
        Random alea = new Random();

        private int emplacementX;
        private int emplacementY;
        private int largeur;
        private int profondeur;

        private Pen buildingBrush = new Pen(new SolidBrush(Color.Black), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(emplacementX - 4, emplacementY - 2, 8, 8));
            //drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, emplacementX + 5, emplacementY - 5);
        }
        public void UpdateB()
        {
            emplacementX = alea.Next(1, 1200);
            emplacementY = alea.Next(1, 500);
        }
    }
}
