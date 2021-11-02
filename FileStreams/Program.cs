using System;
using System.IO;
namespace FileStreams
{
    class Program
    {
        private const string var1 = "Teste";
        private static string ficheiroTxt; 
        private static string ficheiroBin; 
        static void Main(string[] args)
        {
            ficheiroTxt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"dados.txt");
            ficheiroBin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"dados.bin");

            EscreverTexto();
            //LerTexto();
        }

        private void EscreverTexto()
        {
            TextWriter sw = new StreamWriter(ficheiroTxt);

            sw.WriteLine("Ficheiro com uma string");
            sw.Close();
        }

        private void LerTexto()
        {
            TextReader sr = new StringReader(ficheiroTxt);

            string v1 = sr.ReadLine();
            float v2 = float.Parse(sr.ReadLine());
            int v3 = int.Parse(sr.ReadLine());

            Console.WriteLine($"{v1}\n{v2}\n{v3}\n");

        }

        private void EscreverBin(string ficheiroBin)
        {
            /*Stream fs = new FileStream(ficheiroBin, FileMode.Create, FileAccess.Write);
            
            BinaryWriter sw = new BinaryWriter(fs);

            sw.WriteLine("Ficheiro com um bin");
            sw.Close();*/
        }

        private void LerBin()
        {
            
        }
    }
}
