using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optiones.newFolder.newFolders.taskets.ConsoleApp2
{
    class options
    {
        public string host { get; init; }
        public int port { get; init; }
        public byte[] ip { get; init; } 
        private string password;

        public options(string password, string host, int port, bool ssl, byte[]? ip = null)
        {
            this.password = password;
            this.host = host;
            this.port = port;
            this.ssl = ssl;
            this.ip = ip ?? new byte[] { 1, 2, 3, 4 };
        }

        public bool check_password => !string.IsNullOrEmpty(password);
        public bool ssl { get; init; }

        public static void Run()
        {
            var op = new options(
                password: "",
                host: "localhost",
                port: 80,
                ssl: false,
                ip: Convert.FromBase64String("MTIuMTIuMTIuMTI=")
            );

            foreach (var kv in op.GetType().GetProperties())
            {
                Console.WriteLine($"{kv.Name}: {kv.GetValue(op)} {kv.PropertyType}");
                if (kv.Name == "ip" && kv.GetValue(op) is byte[] ipArr)
                {
                    foreach (var ip in ipArr)
                    {
                        Console.WriteLine(ip.GetType());
                    }
                }
            }
        }
    }
}
