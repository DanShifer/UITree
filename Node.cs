using System.Collections.Generic;
using System.IO;
using UITree.Helper;
using System.Xml;

namespace UITree
{
    public class Node
    {
        private static Dictionary<int,Scene> Scenes = new Dictionary<int, Scene>();
        private static XmlDocument XmlDocument = new XmlDocument();

        public void Add(string XmlDocumentFile,int Index, string Name, NPC[] NPC, Objects[] Objects, FileInfo Script)
        {
            Scenes.Add(Index, new Scene() { Id = Index, Name = Name, NPC = NPC, Objects = Objects, Script = Script });

            XmlDocument.Load(XmlDocumentFile);

            XmlElement xRoot = XmlDocument.DocumentElement;

            #region Scene
            //XmlElement SceneElement = XmlDocument.CreateElement("Scene");
            //XmlAttribute SceneName = XmlDocument.CreateAttribute("Name");
            //XmlElement SceneScript = XmlDocument.CreateElement("SceneScript");
        
            //SceneName.AppendChild(XmlDocument.CreateTextNode(Name));
            //SceneScript.AppendChild(XmlDocument.CreateTextNode(Script.FullName));
            #endregion

            #region NPCObject
            XmlElement NPCElement = null;
            XmlAttribute NPCAttribute = null;

            XmlElement NPCElementX = null;
            XmlElement NPCElementY = null;
            XmlElement NPCElementZ = null;
            XmlElement NPCElementDx = null;
            XmlElement NPCElementDy = null;
            XmlElement NPCElementSprite = null;
            XmlElement NPCElementScript = null;

            XmlText NPCTextAttribute = null;
            XmlText NPCTextX = null;
            XmlText NPCTextY = null;
            XmlText NPCTextZ = null;
            XmlText NPCTextDx = null;
            XmlText NPCTextDy = null;
            XmlText NPCTextSprite = null;
            XmlText NPCTextScript = null;

            foreach (var NPCObject in NPC)
            {
                NPCElement = XmlDocument.CreateElement("NPC");
                NPCAttribute = XmlDocument.CreateAttribute("NPCName");
                NPCElementX = XmlDocument.CreateElement("X");
                NPCElementY = XmlDocument.CreateElement("Y");
                NPCElementZ = XmlDocument.CreateElement("Z");
                NPCElementDx = XmlDocument.CreateElement("Dx");
                NPCElementDy = XmlDocument.CreateElement("Dy");
                NPCElementSprite = XmlDocument.CreateElement("Sprite");
                NPCElementScript = XmlDocument.CreateElement("Script");

                NPCTextAttribute = XmlDocument.CreateTextNode(NPCObject.Name);
                NPCTextX = XmlDocument.CreateTextNode(NPCObject.X.ToString());
                NPCTextY = XmlDocument.CreateTextNode(NPCObject.Y.ToString());
                NPCTextZ = XmlDocument.CreateTextNode(NPCObject.Z.ToString());
                NPCTextDx = XmlDocument.CreateTextNode(NPCObject.Dx.ToString());
                NPCTextDy = XmlDocument.CreateTextNode(NPCObject.Dy.ToString());
                NPCTextSprite = XmlDocument.CreateTextNode(NPCObject.Sprite.FullName);
                NPCTextScript = XmlDocument.CreateTextNode(NPCObject.Script.FullName);

                NPCAttribute.AppendChild(NPCTextAttribute);
                NPCElementX.AppendChild(NPCTextX);
                NPCElementY.AppendChild(NPCTextY);
                NPCElementZ.AppendChild(NPCTextZ);
                NPCElementDx.AppendChild(NPCTextDx);
                NPCElementDy.AppendChild(NPCTextDy);
                NPCElementSprite.AppendChild(NPCTextSprite);
                NPCElementScript.AppendChild(NPCTextScript);

                NPCElement.Attributes.Append(NPCAttribute);
                NPCElement.AppendChild(NPCElementX);
                NPCElement.AppendChild(NPCElementY);
                NPCElement.AppendChild(NPCElementZ);
                NPCElement.AppendChild(NPCElementDx);
                NPCElement.AppendChild(NPCElementDy);
                NPCElement.AppendChild(NPCElementSprite);
                NPCElement.AppendChild(NPCElementScript);

                xRoot.AppendChild(NPCElement);
                //SceneElement.AppendChild(NPCElement);
            }
            #endregion

            //NPCElement.Attributes.Append(SceneName);
            //NPCAttribute.AppendChild(SceneScript);

            //xRoot.AppendChild(NPCElement);
            XmlDocument.Save(XmlDocumentFile);
        }

        public Scene GetSceneClass(int Index)
        {
            Scene GScene = new Scene();

            foreach(var sc in Scenes)
            {
                if(sc.Key == Index)
                {
                    GScene = sc.Value;
                    break;
                }
            }

            return GScene;
        }
    }
}