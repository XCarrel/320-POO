using ChickInvaders.Helpers;

namespace ChickInvaders
{
    // Cette partie de la classe Drone définit comment on peut voir un drone

    public partial class Chick
    {

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            int imgWidth = chickImage.Width;
            int imgHeight = chickImage.Height;
            //
            //drawingSpace.Graphics.DrawImage(chickImage, _x - imgWidth / 2, _y - imgHeight / 2);
            int desiredWidth = 50;
            int desiredHeight = 50;

            // Calculate position to keep the image centered
            int imgX = _x - desiredWidth / 2;
            int imgY = _y - desiredHeight / 2;

            // Draw the resized image
            drawingSpace.Graphics.DrawImage(chickImage, new Rectangle(imgX, imgY, desiredWidth, desiredHeight));

            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, _x + imgWidth / 2 + 5, _y - imgHeight / 2);
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{Name} ({((int)((double)_charge / FULLCHARGE * 100)).ToString()}%)";
        }

    }
}
