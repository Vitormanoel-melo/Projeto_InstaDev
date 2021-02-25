using System.Collections.Generic;
using System.IO;

namespace InstaDev_MVC.Models
{
    public abstract class InstaDev_base
    {
        
        public void CreateFolderAndFile(string path){

            string folder = path.Split("/")[0];

            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(path)){
                File.Create(path).Close();
            }
        }

        
        
        public List<string> ReadAllLinesCSV(string PATH){
            
            List<string> linhas = new List<string>();
            
            using(StreamReader file = new StreamReader(PATH))
            {
                string linha;
                
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            
            }
            
            return linhas;
        }
        


        
        public void RewriteCSV(string PATH, List<string> linhas)
        {
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + "\n");
                }
            }
        }
        
            

    }
}