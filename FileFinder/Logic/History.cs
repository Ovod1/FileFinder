using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder.Logic
{
    static class History
    {
        static public void NewRecord(string path, string name, string searchText)
        {
            File.Delete(Path.Combine(Environment.CurrentDirectory, "OldPath.txt"));
            File.Delete(Path.Combine(Environment.CurrentDirectory, "OldName.txt"));
            File.Delete(Path.Combine(Environment.CurrentDirectory, "OldOldSearchText.txt"));
            File.Create(Path.Combine(Environment.CurrentDirectory, "OldPath.txt"));
            using (FileStream fstream = new FileStream(Path.Combine(Environment.CurrentDirectory, "OldPath.txt"), FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(path);
                fstream.Write(array, 0, array.Length);
            }
            File.Create(Path.Combine(Environment.CurrentDirectory, "OldName.txt"));
            using (FileStream fstream = new FileStream(Path.Combine(Environment.CurrentDirectory, "OldName.txt"), FileMode.OpenOrCreate))
            {
                byte[] array2 = System.Text.Encoding.Default.GetBytes(name);
                fstream.Write(array2, 0, array2.Length);
            }
            File.Create(Path.Combine(Environment.CurrentDirectory, "OldSearchText.txt"));
            using (FileStream fstream = new FileStream(Path.Combine(Environment.CurrentDirectory, "OldSearchText.txt"), FileMode.OpenOrCreate))
            {
                byte[] array3 = System.Text.Encoding.Default.GetBytes(searchText);
                fstream.Write(array3, 0, array3.Length);
            }
        }
        static public string HistoryInfo()
        {
            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "OldPath.txt");
            if (files.Length > 0)
                return "Есть";
            else
                return "Нет";

        }

    }
}
