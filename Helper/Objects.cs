using System.IO;

namespace UITree.Helper
{
    public class Objects
    {
        public Objects(string Name, int X, int Y, int Z, int Dx, int Dy, FileInfo Sprite)
        {
            this.Name = Name;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.Dx = Dx;
            this.Dy = Dy;
            this.Sprite = Sprite;
        }

        public string Name;

        public int X, Y, Z,Dx, Dy;

        public FileInfo Sprite;
    }
}