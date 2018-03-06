using System;
using System.IO;

namespace csharp_tree_project
{
    class Program
    {
        static void Tree (string path, string padding)
        {
            string[] folder = Directory.GetDirectories(path);
            string[] file = Directory.GetFiles(path);

            if (folder.Length >0) {
                for (int i = 0; i <= folder.Length-1; i++)
                {
                    string current_folder =  Path.GetFileName(folder[i]);
                    if (i==folder.Length-1) {
                        if (file.Length-1 > 0) {
                            System.Console.WriteLine(padding + "├──" + current_folder);
                            Tree(path + "//"+ current_folder, padding + "| ");
                        } else {
                            System.Console.WriteLine(padding + "└──" + current_folder);
                            Tree(path + "//"+ current_folder, padding + "   ");
                        }
                    } else {
                        System.Console.WriteLine(padding + "├──" + current_folder);
                        Tree(path + "//"+ current_folder, padding + "| ");
                    }        
                }
            }

            for (int k = 0; k <= file.Length-1; k++)
            {
                if (k == file.Length-1) {
                    System.Console.WriteLine(padding + "└──" + Path.GetFileName(file[k]));    
                } else {
                    System.Console.WriteLine(padding + "├──" + Path.GetFileName(file[k]));
                }
                
            }
            
          
        }

       
        static void Main(string[] args)
        {
            string input =  "/home/techmaster/CSharpProject/treeapp/";
            System.Console.WriteLine(input);
            Tree(input, "");
        }
    }
}