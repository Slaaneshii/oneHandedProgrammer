using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace oneHandedProgrammer
{
    public class SlaXmlSerializer
    {
        /// <summary>
        /// Fonction statique qui serialize un objet 
        /// </summary>
        /// <param name="objToSerialize">Objet à serializer</param>
        /// <param name="path">Chemin du fichier à sérializer</param>
        static public void serializeXML(object objToSerialize, string path)
        {
            XmlSerializer serializer = getXMLSerializer(objToSerialize.GetType());
            FileStream fs = createFileStream(path);
            serializer.Serialize(fs, objToSerialize);
            fs.Close();
        }
        /// <summary>
        /// Fonction statique qui renvoie un objet désérializer
        /// </summary>
        /// <typeparam name="typeC">Type de la class a déséralizer</typeparam>
        /// <param name="path">Chemin du XML à désérializer</param>
        /// <returns></returns>
        static public typeC deserializeXML<typeC>(string path)
        {
            XmlSerializer serializer = getXMLSerializer(typeof(typeC));
            FileStream fs = getFileStream(path);
            typeC result = (typeC)serializer.Deserialize(fs);
            fs.Close();
            return result;
        }
        /// <summary>Création du serializeur XML
        /// </summary>
        /// <param name="objType">Type de l'objet à sérializer</param>
        /// <returns></returns>
        static private XmlSerializer getXMLSerializer(Type objType)
        {
            return new XmlSerializer(objType);
        }

        /// <summary>
        /// (Il est recommandé d'utiliser slaaneshFilesUtils plutôt) Retourne le chemin de l'assembly en cours
        /// </summary>
        /// <returns></returns>
        static public string exePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        static private FileStream createFileStream(string path)
        {
            return new FileStream(path, FileMode.Create);
        }
        static private FileStream getFileStream(string path)
        {
            return new FileStream(path, FileMode.Open);
        }
    }
}
