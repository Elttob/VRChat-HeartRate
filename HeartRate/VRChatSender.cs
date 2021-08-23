using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HeartRate
{
    public class VRChatSender {
		public static void SendHeartRate(int heartRate) {
            byte[] dataBytes = Encoding.UTF8.GetBytes(heartRate.ToString());

			IPEndPoint localIPEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 15737);
            IPEndPoint destIPEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 15738);

			UdpClient localUDPClient = new UdpClient(localIPEndpoint);
            localUDPClient.Send(dataBytes, dataBytes.Length, destIPEndpoint);
        }
	}
}
