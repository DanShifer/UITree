using System.IO;

namespace UITree.Helper
{
    public struct Scene
    {        
        public int Id;
        public string Name;

        public FileInfo Script;
    
        public Objects[] Objects;
        public NPC[] NPC;
    }
}