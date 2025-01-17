// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClassF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Test {

  /// <summary>Holder for reflection information generated from ClassF.proto</summary>
  public static partial class ClassFReflection {

    #region Descriptor
    /// <summary>File descriptor for ClassF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClassFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxDbGFzc0YucHJvdG8SEFNpbXBsZUJpbmFyeVRlc3QaD3RpbWVzdGFtcC5w",
            "cm90byJhCglDbGFzc0ZQdWYSDAoEbmFtZRgBIAEoCRILCgNhZ2UYAiABKAUS",
            "KAoEdGltZRgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASDwoH",
            "YWRkcmVzcxgEIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Test.ClassFPuf), global::Test.ClassFPuf.Parser, new[]{ "Name", "Age", "Time", "Address" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClassFPuf : pb::IMessage<ClassFPuf> {
    private static readonly pb::MessageParser<ClassFPuf> _parser = new pb::MessageParser<ClassFPuf>(() => new ClassFPuf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClassFPuf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Test.ClassFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassFPuf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassFPuf(ClassFPuf other) : this() {
      name_ = other.name_;
      age_ = other.age_;
      time_ = other.time_ != null ? other.time_.Clone() : null;
      address_ = other.address_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassFPuf Clone() {
      return new ClassFPuf(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 2;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 4;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClassFPuf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClassFPuf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Age != other.Age) return false;
      if (!object.Equals(Time, other.Time)) return false;
      if (Address != other.Address) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
      if (time_ != null) hash ^= Time.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Age != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Age);
      }
      if (time_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Time);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      if (time_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Time);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClassFPuf other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Age != 0) {
        Age = other.Age;
      }
      if (other.time_ != null) {
        if (time_ == null) {
          Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Time.MergeFrom(other.Time);
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Age = input.ReadInt32();
            break;
          }
          case 26: {
            if (time_ == null) {
              Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Time);
            break;
          }
          case 34: {
            Address = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
