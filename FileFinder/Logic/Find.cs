using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder.Logic
{
    static class Find
    {
        static public void MakeSearch(string path, string name, string searchText)
        {
            int Count = 0;
            string[] files = Directory.GetFiles(@path, name, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                string text = File.ReadAllText(file);
                //Results.Show(file);
                // вывод сейчас обрабатывается файл
                // вывод обработано файлов
                if (text.IndexOf(searchText, 0) != -1)
                {
                    //вывод пути файла
                    Count++;
                }
            }
        }
        static public void MakeOldSearch()
        {
            string path,name, searchText;
            using (FileStream fstream = File.OpenRead(Path.Combine(Environment.CurrentDirectory, "OldPath.txt")))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                path = Encoding.Default.GetString(array);
            }
            using (FileStream fstream = File.OpenRead(Path.Combine(Environment.CurrentDirectory, "OldName.txt")))
            {
                byte[] array2 = new byte[fstream.Length];
                fstream.Read(array2, 0, array2.Length);
                name = Encoding.Default.GetString(array2);
            }
            using (FileStream fstream = File.OpenRead(Path.Combine(Environment.CurrentDirectory, "OldSearchText.txt")))
            {
                byte[] array3 = new byte[fstream.Length];
                fstream.Read(array3, 0, array3.Length);
                searchText = Encoding.Default.GetString(array3);
            }
            MakeSearch(name, path, searchText);
        }

    }

}
