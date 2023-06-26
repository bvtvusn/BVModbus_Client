using BV_Modbus_Client.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BV_Modbus_Client.DataAccessLayer
{
    internal class Dal
    {
        //public void SaveToFile(FcWrapperBase[] objects)
        //{
            

        //}

        //internal void SaveToFile(List<FcWrapperBase> fcWrappers)
        //{
        //    FcWrapperBase[] objects = fcWrappers.ToArray();

        //    var serializer = new DataContractSerializer(typeof(FcWrapperBase[]));
        //    string filePath = @"C:/testing/file.xml";

        //    using (var fileStream = new FileStream(filePath, FileMode.Create))
        //    {
        //        using (var xmlWriter = XmlWriter.Create(fileStream))
        //        {
        //            serializer.WriteObject(xmlWriter, objects);
        //        }
        //    }
        //}
        internal void SaveToFile(UserConfiguration objects)
        {
            //FcWrapperBase[] objects = fcWrappers.ToArray();

            var serializer = new DataContractSerializer(typeof(UserConfiguration));
            string filePath = @"C:/testing/file.xml";

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (var xmlWriter = XmlWriter.Create(fileStream))
                {
                    serializer.WriteObject(xmlWriter, objects);
                }
            }
        }

        //internal List<FcWrapperBase> LoadFromFile()
        //{
        //    string filePath = @"C:/testing/file.xml";
        //    var serializer = new DataContractSerializer(typeof(FcWrapperBase[]));
        //    using (var fileStream = new FileStream(filePath, FileMode.Open))
        //    {
        //        using (var xmlReader = XmlReader.Create(fileStream))
        //        {
        //            FcWrapperBase[] deserializedObjects = (FcWrapperBase[])serializer.ReadObject(xmlReader);

        //            return deserializedObjects.ToList();
        //            // Access the objects and perform operations
        //            //foreach (var obj in deserializedObjects)
        //            //{
        //            //    // ...
        //            //}
        //        }
        //    }
        //}

        internal UserConfiguration LoadFromFile()
        {
            string filePath = @"C:/testing/file.xml";
            var serializer = new DataContractSerializer(typeof(UserConfiguration));
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (var xmlReader = XmlReader.Create(fileStream))
                {
                    UserConfiguration deserializedObjects = (UserConfiguration)serializer.ReadObject(xmlReader);

                    return deserializedObjects;
                    // Access the objects and perform operations
                    //foreach (var obj in deserializedObjects)
                    //{
                    //    // ...
                    //}
                }
            }
        }
    }
}
