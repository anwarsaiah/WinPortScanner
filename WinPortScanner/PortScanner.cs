using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;

namespace WinPortScanner
{
    public class PortScanner
    {
        private string host;
        private PortList portList;
        public bool stopped = false;
        
        public event DisplayResult dspR;
        public string result { get; set; }
        public string open_ports_list { get; set; }
        public Thread[] th;
        public PortScanner(string host, int portStart, int portStop, DisplayResult dspResult)
        {
            dspR = dspResult;
            this.host = host;
            this.portList = new PortList(portStart-1, portStop-1);
            this.result = "Ports status for IP:"+host+" for IPs in the range: "+portStart+" - "+portStop+"\n\n";
            this.open_ports_list = "";
            dspR(result,0);
        }

        public PortScanner(string host, DisplayResult dspResult)
            : this(host, 1, 65535, dspResult)
        {
        }

        public PortScanner(DisplayResult dspResult)
            : this("127.0.0.1",dspResult)
        {
        }
        public void stop() {
            this.stopped = true;
        }
        public void start(int threadCtr) 
        {
            this.stopped = false;
            th = new Thread[threadCtr];
            for (int i = 0; i < threadCtr; i++)
            {
                th[i] = new Thread(new ThreadStart(run));
                th[i].Start();                
            }                         
        }

        public void run()
        {
            bool isAvailable = false;
            int counter = 0;
            int port;
            TcpClient tcp = new TcpClient();
            while ((port = portList.getNext()) != -1)
            {
                if (stopped) break;
                dspR("Thread "+Thread.CurrentThread.ManagedThreadId+" is trying port "+port.ToString()+"\n", Thread.CurrentThread.ManagedThreadId);
                try
                {
                    tcp = new TcpClient(host, port);  //try to open new tcp client, if port closed will not succeed.
                }
                catch
                {
                    continue;
                }
                finally
                {
                    try
                    {
                        tcp.Close();
                    }
                    catch { }
                }
                result = "TCP Port " + port + " is open\n";
                open_ports_list += port+",";
                dspR(result, 0);
            }
            stopped = true;
        }
    }
}




/* Old code
 * 
 * result = counter++.ToString() + " ("+Thread.CurrentThread.ManagedThreadId+")";
 * 
 * 
 * 
 IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();                
                IPEndPoint[]    tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();
                foreach (IPEndPoint tcpi in tcpConnInfoArray)
                {
                    if (tcpi.Port == port && host==tcpi.Address.ToString())
                    {
                        isAvailable = true;
                        counter++;
                        break;                        
                    }                    
                }
                if (isAvailable)
                {
                    result += "Port " + port + " is open.\n";
                    dspR(result);
                    isAvailable = false;
                }
            }
            if (counter == 0) {
                result += "\nNo open ports found in specified range, for this IP address!";
                dspR(result);
            }
     */
