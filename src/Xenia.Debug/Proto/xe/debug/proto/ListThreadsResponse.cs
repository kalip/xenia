// automatically generated, do not modify

namespace xe.debug.proto
{

using FlatBuffers;

public sealed class ListThreadsResponse : Table {
  public static ListThreadsResponse GetRootAsListThreadsResponse(ByteBuffer _bb) { return GetRootAsListThreadsResponse(_bb, new ListThreadsResponse()); }
  public static ListThreadsResponse GetRootAsListThreadsResponse(ByteBuffer _bb, ListThreadsResponse obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public ListThreadsResponse __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }


  public static void StartListThreadsResponse(FlatBufferBuilder builder) { builder.StartObject(0); }
  public static int EndListThreadsResponse(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return o;
  }
};


}
