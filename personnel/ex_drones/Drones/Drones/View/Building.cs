using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public partial class Building
    {
        public int emplacementX;
        public int emplacementY;
        public int largeur;
        public int profondeur;

        private Pen buildingBrush = new Pen(new SolidBrush(Color.Black), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(emplacementX - 4, emplacementY - 2, 8, 8));
            //drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, emplacementX + 5, emplacementY - 5);
        }
    }
}
