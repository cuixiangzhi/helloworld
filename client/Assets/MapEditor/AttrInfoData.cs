//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: AttrInfoData.proto
namespace AttrInfoData
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AttrInfoDatatable")]
  public partial class AttrInfoDatatable : global::ProtoBuf.IExtensible
  {
    public AttrInfoDatatable() {}
    
    private string _tname = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tname
    {
      get { return _tname; }
      set { _tname = value; }
    }
    private readonly global::System.Collections.Generic.List<AttrInfoData> _tlist = new global::System.Collections.Generic.List<AttrInfoData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"tlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<AttrInfoData> tlist
    {
      get { return _tlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AttrInfoData")]
  public partial class AttrInfoData : global::ProtoBuf.IExtensible
  {
    public AttrInfoData() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Tag = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Tag
    {
      get { return _Tag; }
      set { _Tag = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _Key = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Key
    {
      get { return _Key; }
      set { _Key = value; }
    }
    private string _Des = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Des
    {
      get { return _Des; }
      set { _Des = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}