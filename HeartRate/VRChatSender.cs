using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;

namespace HeartRate
{
    internal class VRChatSender {
		static void SendHeartRate(int heartRate) {
            byte[] dataBytes = Encoding.UTF8.GetBytes(heartRate.ToString());

			IPEndPoint localIPEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 15737);
            IPEndPoint destIPEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 15738);

			localUDPClient = new UdpClient(localIPEndpoint);
            localUDPClient.Send(dataBytes, dataBytes.Length, destIPEndpoint);
        }
	}
}
