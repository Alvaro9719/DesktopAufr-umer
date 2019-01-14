using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopAufräumer
{
    public class DesktopItems 
    {
        

        public List<String> _Type { get; set;}

        public DesktopItems(List<String> type)
        {
            _Type = type;
        }
        

        public List<String> readItems()
        {
            string folder = @"C:\Users\alvar\Desktop";
            List<String> txtFiles = new List<string>();

            try
            {
                for (int i = 0; i < _Type.Count; i++)
                {
                    foreach (string txtFilePath in Directory.GetFiles(folder, _Type[i]))
                    {
                        txtFiles.Add(txtFilePath.Replace(@"C:\Users\alvar\Desktop\", ""));
                    }
                }
            }
            catch (ArgumentException)
            {
              MessageBox.Show("Fehler im System");
              throw;
            }
            return txtFiles;
        }


    
    }
}
