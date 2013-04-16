using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Grafo
{
    class xmlMetodos
    {
        public static List<Nodo> LoadXML(string FileName)
        {
            if (!File.Exists(FileName))
                throw new FileNotFoundException("The file could not be found", FileName);

            List<Nodo> result;

            using (FileStream fs = new FileStream(FileName, FileMode.Open))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Nodo>));
                result = (List<Nodo>)ser.Deserialize(fs);
            }
            return result;
        }
    }
}
