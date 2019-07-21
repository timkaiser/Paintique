// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/sessions/interactionOutputMapping.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ubii.Sessions {

  /// <summary>Holder for reflection information generated from proto/sessions/interactionOutputMapping.proto</summary>
  public static partial class InteractionOutputMappingReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/sessions/interactionOutputMapping.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InteractionOutputMappingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1wcm90by9zZXNzaW9ucy9pbnRlcmFjdGlvbk91dHB1dE1hcHBpbmcucHJv",
            "dG8SDXViaWkuc2Vzc2lvbnMaIXByb3RvL2ludGVyYWN0aW9ucy9pb0Zvcm1h",
            "dC5wcm90bxoecHJvdG8vZGV2aWNlcy90b3BpY0RlbXV4LnByb3RvIn8KGElu",
            "dGVyYWN0aW9uT3V0cHV0TWFwcGluZxIMCgRuYW1lGAEgASgJEg8KBXRvcGlj",
            "GAIgASgJSAASLwoLdG9waWNfZGVtdXgYAyABKAsyGC51YmlpLmRldmljZXMu",
            "VG9waWNEZW11eEgAQhMKEXRvcGljX2Rlc3RpbmF0aW9uIlkKHEludGVyYWN0",
            "aW9uT3V0cHV0TWFwcGluZ0xpc3QSOQoIZWxlbWVudHMYASADKAsyJy51Ymlp",
            "LnNlc3Npb25zLkludGVyYWN0aW9uT3V0cHV0TWFwcGluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Ubii.Interactions.IoFormatReflection.Descriptor, global::Ubii.Devices.TopicDemuxReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ubii.Sessions.InteractionOutputMapping), global::Ubii.Sessions.InteractionOutputMapping.Parser, new[]{ "Name", "Topic", "TopicDemux" }, new[]{ "TopicDestination" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ubii.Sessions.InteractionOutputMappingList), global::Ubii.Sessions.InteractionOutputMappingList.Parser, new[]{ "Elements" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InteractionOutputMapping : pb::IMessage<InteractionOutputMapping> {
    private static readonly pb::MessageParser<InteractionOutputMapping> _parser = new pb::MessageParser<InteractionOutputMapping>(() => new InteractionOutputMapping());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InteractionOutputMapping> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ubii.Sessions.InteractionOutputMappingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InteractionOutputMapping() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InteractionOutputMapping(InteractionOutputMapping other) : this() {
      name_ = other.name_;
      switch (other.TopicDestinationCase) {
        case TopicDestinationOneofCase.Topic:
          Topic = other.Topic;
          break;
        case TopicDestinationOneofCase.TopicDemux:
          TopicDemux = other.TopicDemux.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InteractionOutputMapping Clone() {
      return new InteractionOutputMapping(this);
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

    /// <summary>Field number for the "topic" field.</summary>
    public const int TopicFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Topic {
      get { return topicDestinationCase_ == TopicDestinationOneofCase.Topic ? (string) topicDestination_ : ""; }
      set {
        topicDestination_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        topicDestinationCase_ = TopicDestinationOneofCase.Topic;
      }
    }

    /// <summary>Field number for the "topic_demux" field.</summary>
    public const int TopicDemuxFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Ubii.Devices.TopicDemux TopicDemux {
      get { return topicDestinationCase_ == TopicDestinationOneofCase.TopicDemux ? (global::Ubii.Devices.TopicDemux) topicDestination_ : null; }
      set {
        topicDestination_ = value;
        topicDestinationCase_ = value == null ? TopicDestinationOneofCase.None : TopicDestinationOneofCase.TopicDemux;
      }
    }

    private object topicDestination_;
    /// <summary>Enum of possible cases for the "topic_destination" oneof.</summary>
    public enum TopicDestinationOneofCase {
      None = 0,
      Topic = 2,
      TopicDemux = 3,
    }
    private TopicDestinationOneofCase topicDestinationCase_ = TopicDestinationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopicDestinationOneofCase TopicDestinationCase {
      get { return topicDestinationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTopicDestination() {
      topicDestinationCase_ = TopicDestinationOneofCase.None;
      topicDestination_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InteractionOutputMapping);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InteractionOutputMapping other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Topic != other.Topic) return false;
      if (!object.Equals(TopicDemux, other.TopicDemux)) return false;
      if (TopicDestinationCase != other.TopicDestinationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (topicDestinationCase_ == TopicDestinationOneofCase.Topic) hash ^= Topic.GetHashCode();
      if (topicDestinationCase_ == TopicDestinationOneofCase.TopicDemux) hash ^= TopicDemux.GetHashCode();
      hash ^= (int) topicDestinationCase_;
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
      if (topicDestinationCase_ == TopicDestinationOneofCase.Topic) {
        output.WriteRawTag(18);
        output.WriteString(Topic);
      }
      if (topicDestinationCase_ == TopicDestinationOneofCase.TopicDemux) {
        output.WriteRawTag(26);
        output.WriteMessage(TopicDemux);
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
      if (topicDestinationCase_ == TopicDestinationOneofCase.Topic) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Topic);
      }
      if (topicDestinationCase_ == TopicDestinationOneofCase.TopicDemux) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TopicDemux);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InteractionOutputMapping other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.TopicDestinationCase) {
        case TopicDestinationOneofCase.Topic:
          Topic = other.Topic;
          break;
        case TopicDestinationOneofCase.TopicDemux:
          if (TopicDemux == null) {
            TopicDemux = new global::Ubii.Devices.TopicDemux();
          }
          TopicDemux.MergeFrom(other.TopicDemux);
          break;
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
          case 18: {
            Topic = input.ReadString();
            break;
          }
          case 26: {
            global::Ubii.Devices.TopicDemux subBuilder = new global::Ubii.Devices.TopicDemux();
            if (topicDestinationCase_ == TopicDestinationOneofCase.TopicDemux) {
              subBuilder.MergeFrom(TopicDemux);
            }
            input.ReadMessage(subBuilder);
            TopicDemux = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class InteractionOutputMappingList : pb::IMessage<InteractionOutputMappingList> {
    private static readonly pb::MessageParser<InteractionOutputMappingList> _parser = new pb::MessageParser<InteractionOutputMappingList>(() => new InteractionOutputMappingList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InteractionOutputMappingList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ubii.Sessions.InteractionOutputMappingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InteractionOutputMappingList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InteractionOutputMappingList(InteractionOutputMappingList other) : this() {
      elements_ = other.elements_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InteractionOutputMappingList Clone() {
      return new InteractionOutputMappingList(this);
    }

    /// <summary>Field number for the "elements" field.</summary>
    public const int ElementsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Ubii.Sessions.InteractionOutputMapping> _repeated_elements_codec
        = pb::FieldCodec.ForMessage(10, global::Ubii.Sessions.InteractionOutputMapping.Parser);
    private readonly pbc::RepeatedField<global::Ubii.Sessions.InteractionOutputMapping> elements_ = new pbc::RepeatedField<global::Ubii.Sessions.InteractionOutputMapping>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Ubii.Sessions.InteractionOutputMapping> Elements {
      get { return elements_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InteractionOutputMappingList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InteractionOutputMappingList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!elements_.Equals(other.elements_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= elements_.GetHashCode();
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
      elements_.WriteTo(output, _repeated_elements_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += elements_.CalculateSize(_repeated_elements_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InteractionOutputMappingList other) {
      if (other == null) {
        return;
      }
      elements_.Add(other.elements_);
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
            elements_.AddEntriesFrom(input, _repeated_elements_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code