using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find
{
    class Finder
    {
        List<DirectoryInfo> pathes = new List<DirectoryInfo>();
        int spaceCount = 0;
        string separatedString = "-+";
        string fullPath = "";

        public Finder() => spaceCount = 0;

        public Finder(int tabCount, string fullPath)
        {
            this.spaceCount = tabCount;
            this.fullPath = fullPath;
        }

        public int Find(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);

                Console.WriteLine(new string(' ', spaceCount) + separatedString + fullPath + "\\" + (fullPath == "" ? directory.Name : fullPath));

                if (string.IsNullOrEmpty(fullPath))
                    fullPath = directory.Name;

                foreach (var item in directory.GetFiles())
                {
                    Console.WriteLine(new string(' ', spaceCount + 2) + separatedString + fullPath + "\\" + item.Name);
                }

                pathes.AddRange(directory.GetDirectories());

                foreach (var item in pathes)
                {
                    new Finder(spaceCount + 2, fullPath + "\\" + item.Name).Find(item.FullName);
                }

                return 0;
            }
            else
                Console.WriteLine("Directory not exist");

            return -1;
        }
    }
}
