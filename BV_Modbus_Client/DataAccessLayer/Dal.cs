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
       
        internal void SaveToFile(UserConfiguration objects)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml";
            saveFileDialog.FileName = "ModbusConfig.xml"; // Default file name

            // Retrieve the last used folder path from application settings
            string lastUsedFolder = Properties.Settings.Default.SaveFolder;
            if (!string.IsNullOrEmpty(lastUsedFolder))
            {
                saveFileDialog.InitialDirectory = lastUsedFolder;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savefilePath = saveFileDialog.FileName;

                try
                {
                    var serializer = new DataContractSerializer(typeof(UserConfiguration));

                    using (var fileStream = new FileStream(savefilePath, FileMode.Create))
                    {
                        using (var xmlWriter = XmlWriter.Create(fileStream))
                        {
                            serializer.WriteObject(xmlWriter, objects);
                        }
                    }

                    // Store the current selected folder path in application settings
                    string selectedFolderPath = Path.GetDirectoryName(savefilePath);
                    Properties.Settings.Default.SaveFolder = selectedFolderPath;
                    Properties.Settings.Default.Save();

                    Console.WriteLine("Modbus configuration file saved successfully.");
                    //MessageBox.Show("Modbus configuration file saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to save Modbus configuration file. Error: " + ex.Message);
                    MessageBox.Show("Failed to save Modbus configuration file. Error: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal UserConfiguration LoadFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            openFileDialog.FileName = "ModbusConfig.xml"; // Default file name

            // Retrieve the last used folder path from application settings
            string lastUsedFolder = Properties.Settings.Default.SaveFolder;
            if (!string.IsNullOrEmpty(lastUsedFolder))
            {
                openFileDialog.InitialDirectory = lastUsedFolder;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openFilePath = openFileDialog.FileName;

                try
                {
                    var serializer = new DataContractSerializer(typeof(UserConfiguration));

                    using (var fileStream = new FileStream(openFilePath, FileMode.Open))
                    {
                        using (var xmlReader = XmlReader.Create(fileStream))
                        {
                            var objects = (UserConfiguration)serializer.ReadObject(xmlReader);
                            Console.WriteLine("Modbus configuration file opened successfully.");
                            //MessageBox.Show("Modbus configuration file opened successfully.", "Open Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return objects;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to open Modbus configuration file. Error: " + ex.Message);
                    MessageBox.Show("Failed to open Modbus configuration file. Error: " + ex.Message, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null; // Return null if the open operation is canceled or encounters an error
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

        //internal UserConfiguration LoadFromFile()
        //{
        //    string filePath = @"C:/testing/file.xml";
        //    var serializer = new DataContractSerializer(typeof(UserConfiguration));
        //    using (var fileStream = new FileStream(filePath, FileMode.Open))
        //    {
        //        using (var xmlReader = XmlReader.Create(fileStream))
        //        {
        //            UserConfiguration deserializedObjects = (UserConfiguration)serializer.ReadObject(xmlReader);

        //            return deserializedObjects;
        //            // Access the objects and perform operations
        //            //foreach (var obj in deserializedObjects)
        //            //{
        //            //    // ...
        //            //}
        //        }
        //    }
        //}
    }
}
