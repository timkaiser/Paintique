// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/topicData/topicDataRecord/dataStructure/handGestureType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ubii.DataStructure {

  /// <summary>Holder for reflection information generated from proto/topicData/topicDataRecord/dataStructure/handGestureType.proto</summary>
  public static partial class HandGestureTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/topicData/topicDataRecord/dataStructure/handGestureType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HandGestureTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNwcm90by90b3BpY0RhdGEvdG9waWNEYXRhUmVjb3JkL2RhdGFTdHJ1Y3R1",
            "cmUvaGFuZEdlc3R1cmVUeXBlLnByb3RvEhJ1YmlpLmRhdGFTdHJ1Y3R1cmUq",
            "ZAoPSGFuZEdlc3R1cmVUeXBlEggKBFJFU1QQABISCg5GSU5HRVJTX1NQUkVB",
            "RBABEgsKB1dBVkVfSU4QAhIMCghXQVZFX09VVBADEggKBEZJU1QQBBIOCgpE",
            "T1VCTEVfVEFQEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Ubii.DataStructure.HandGestureType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum HandGestureType {
    [pbr::OriginalName("REST")] Rest = 0,
    [pbr::OriginalName("FINGERS_SPREAD")] FingersSpread = 1,
    [pbr::OriginalName("WAVE_IN")] WaveIn = 2,
    [pbr::OriginalName("WAVE_OUT")] WaveOut = 3,
    [pbr::OriginalName("FIST")] Fist = 4,
    [pbr::OriginalName("DOUBLE_TAP")] DoubleTap = 5,
  }

  #endregion

}

#endregion Designer generated code