using System.IO;

namespace UITree.Helper
{
    public class NPC : Objects
    {
        public NPC(string Name, int X, int Y, int Z, int Dx, int Dy, FileInfo Sprite, FileInfo Script) : base(Name, X, Y, Z, Dx, Dy, Sprite) => this.Script = Script;

        public FileInfo Script;
    }
}