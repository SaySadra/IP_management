using DAL;
using System.Collections.Generic;
using System.IO;

namespace BLL
{
    public static class IPApplication
    {
        public static string filePath = @"ipList.txt";
        public static List<IPModel> model = new List<IPModel>();


        public static void LoadIPsFromFile()
        {
            model.Clear();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                
                var parts = line.Split(' ');
                if (parts.Length >= 5)
                {
                    string infoport = $"{parts[0]} {parts[1]}"; // "open tcp"
                    int port = int.Parse(parts[2]); // Port
                    string ip = parts[3]; // IP
                    int ttl = int.Parse(parts[4]); // Ttl

                    model.Add(new IPModel
                    {
                        Infoport = infoport,
                        Port = port,
                        Ip = ip,
                        Ttl = ttl
                    });
                }
            }
        }


        public static void SaveIPsToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var ipPort in model)
                {
                    writer.WriteLine((ipPort.Ip)+":"+(ipPort.Port));
                }
            }
        }
    }
}
