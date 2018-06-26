using LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.C2S;
using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.S2C
{
    public class ViewResponse : Packet
    {
        public ViewResponse(ViewRequest request)
            : base(PacketCmd.PKT_S2_C_VIEW_ANS)
        {
            _buffer.Write(request.NetId);
        }

        public void SetRequestNo(byte requestNo)
        {
            _buffer.Write(requestNo);
        }
    }
}