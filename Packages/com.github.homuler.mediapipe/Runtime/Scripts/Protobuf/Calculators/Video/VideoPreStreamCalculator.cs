// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/video/video_pre_stream_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/video/video_pre_stream_calculator.proto</summary>
  public static partial class VideoPreStreamCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/video/video_pre_stream_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoPreStreamCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1tZWRpYXBpcGUvY2FsY3VsYXRvcnMvdmlkZW8vdmlkZW9fcHJlX3N0cmVh",
            "bV9jYWxjdWxhdG9yLnByb3RvEgltZWRpYXBpcGUaJG1lZGlhcGlwZS9mcmFt",
            "ZXdvcmsvY2FsY3VsYXRvci5wcm90byLPAgofVmlkZW9QcmVTdHJlYW1DYWxj",
            "dWxhdG9yT3B0aW9ucxI7CgNmcHMYASABKAsyLi5tZWRpYXBpcGUuVmlkZW9Q",
            "cmVTdHJlYW1DYWxjdWxhdG9yT3B0aW9ucy5GcHMalAEKA0ZwcxINCgV2YWx1",
            "ZRgBIAEoARJICgVyYXRpbxgCIAEoCzI5Lm1lZGlhcGlwZS5WaWRlb1ByZVN0",
            "cmVhbUNhbGN1bGF0b3JPcHRpb25zLkZwcy5SYXRpb25hbDMyGjQKClJhdGlv",
            "bmFsMzISEQoJbnVtZXJhdG9yGAEgASgFEhMKC2Rlbm9taW5hdG9yGAIgASgF",
            "MlgKA2V4dBIcLm1lZGlhcGlwZS5DYWxjdWxhdG9yT3B0aW9ucxiL8JdIIAEo",
            "CzIqLm1lZGlhcGlwZS5WaWRlb1ByZVN0cmVhbUNhbGN1bGF0b3JPcHRpb25z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.VideoPreStreamCalculatorOptions), global::Mediapipe.VideoPreStreamCalculatorOptions.Parser, new[]{ "Fps" }, null, null, new pb::Extension[] { global::Mediapipe.VideoPreStreamCalculatorOptions.Extensions.Ext }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps), global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Parser, new[]{ "Value", "Ratio" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32), global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32.Parser, new[]{ "Numerator", "Denominator" }, null, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VideoPreStreamCalculatorOptions : pb::IMessage<VideoPreStreamCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoPreStreamCalculatorOptions> _parser = new pb::MessageParser<VideoPreStreamCalculatorOptions>(() => new VideoPreStreamCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VideoPreStreamCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.VideoPreStreamCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoPreStreamCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoPreStreamCalculatorOptions(VideoPreStreamCalculatorOptions other) : this() {
      fps_ = other.fps_ != null ? other.fps_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoPreStreamCalculatorOptions Clone() {
      return new VideoPreStreamCalculatorOptions(this);
    }

    /// <summary>Field number for the "fps" field.</summary>
    public const int FpsFieldNumber = 1;
    private global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps fps_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps Fps {
      get { return fps_; }
      set {
        fps_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VideoPreStreamCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VideoPreStreamCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Fps, other.Fps)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (fps_ != null) hash ^= Fps.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (fps_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Fps);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (fps_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Fps);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (fps_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Fps);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VideoPreStreamCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.fps_ != null) {
        if (fps_ == null) {
          Fps = new global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps();
        }
        Fps.MergeFrom(other.Fps);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (fps_ == null) {
              Fps = new global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps();
            }
            input.ReadMessage(Fps);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (fps_ == null) {
              Fps = new global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps();
            }
            input.ReadMessage(Fps);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the VideoPreStreamCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// An arbitrary number of frames per second.
      /// Prefer the StandardFps enum to store industry-standard, safe FPS values.
      /// </summary>
      public sealed partial class Fps : pb::IMessage<Fps>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Fps> _parser = new pb::MessageParser<Fps>(() => new Fps());
        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Fps> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Mediapipe.VideoPreStreamCalculatorOptions.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Fps() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Fps(Fps other) : this() {
          _hasBits0 = other._hasBits0;
          value_ = other.value_;
          ratio_ = other.ratio_ != null ? other.ratio_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Fps Clone() {
          return new Fps(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private readonly static double ValueDefaultValue = 0D;

        private double value_;
        /// <summary>
        /// The possibly approximated value of the frame rate, in frames per second.
        /// Unsafe to use in accurate computations because prone to rounding errors.
        /// For example, the 23.976 FPS value has no exact representation as a
        /// double.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public double Value {
          get { if ((_hasBits0 & 1) != 0) { return value_; } else { return ValueDefaultValue; } }
          set {
            _hasBits0 |= 1;
            value_ = value;
          }
        }
        /// <summary>Gets whether the "value" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasValue {
          get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "value" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearValue() {
          _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "ratio" field.</summary>
        public const int RatioFieldNumber = 2;
        private global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32 ratio_;
        /// <summary>
        /// The exact value of the frame rate, as a rational number.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32 Ratio {
          get { return ratio_; }
          set {
            ratio_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Fps);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Fps other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Value, other.Value)) return false;
          if (!object.Equals(Ratio, other.Ratio)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HasValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Value);
          if (ratio_ != null) hash ^= Ratio.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (HasValue) {
            output.WriteRawTag(9);
            output.WriteDouble(Value);
          }
          if (ratio_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Ratio);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (HasValue) {
            output.WriteRawTag(9);
            output.WriteDouble(Value);
          }
          if (ratio_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Ratio);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (HasValue) {
            size += 1 + 8;
          }
          if (ratio_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ratio);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Fps other) {
          if (other == null) {
            return;
          }
          if (other.HasValue) {
            Value = other.Value;
          }
          if (other.ratio_ != null) {
            if (ratio_ == null) {
              Ratio = new global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32();
            }
            Ratio.MergeFrom(other.Ratio);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 9: {
                Value = input.ReadDouble();
                break;
              }
              case 18: {
                if (ratio_ == null) {
                  Ratio = new global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32();
                }
                input.ReadMessage(Ratio);
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 9: {
                Value = input.ReadDouble();
                break;
              }
              case 18: {
                if (ratio_ == null) {
                  Ratio = new global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Types.Rational32();
                }
                input.ReadMessage(Ratio);
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the Fps message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          public sealed partial class Rational32 : pb::IMessage<Rational32>
          #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              , pb::IBufferMessage
          #endif
          {
            private static readonly pb::MessageParser<Rational32> _parser = new pb::MessageParser<Rational32>(() => new Rational32());
            private pb::UnknownFieldSet _unknownFields;
            private int _hasBits0;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pb::MessageParser<Rational32> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Mediapipe.VideoPreStreamCalculatorOptions.Types.Fps.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Rational32() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Rational32(Rational32 other) : this() {
              _hasBits0 = other._hasBits0;
              numerator_ = other.numerator_;
              denominator_ = other.denominator_;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Rational32 Clone() {
              return new Rational32(this);
            }

            /// <summary>Field number for the "numerator" field.</summary>
            public const int NumeratorFieldNumber = 1;
            private readonly static int NumeratorDefaultValue = 0;

            private int numerator_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public int Numerator {
              get { if ((_hasBits0 & 1) != 0) { return numerator_; } else { return NumeratorDefaultValue; } }
              set {
                _hasBits0 |= 1;
                numerator_ = value;
              }
            }
            /// <summary>Gets whether the "numerator" field is set</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool HasNumerator {
              get { return (_hasBits0 & 1) != 0; }
            }
            /// <summary>Clears the value of the "numerator" field</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void ClearNumerator() {
              _hasBits0 &= ~1;
            }

            /// <summary>Field number for the "denominator" field.</summary>
            public const int DenominatorFieldNumber = 2;
            private readonly static int DenominatorDefaultValue = 0;

            private int denominator_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public int Denominator {
              get { if ((_hasBits0 & 2) != 0) { return denominator_; } else { return DenominatorDefaultValue; } }
              set {
                _hasBits0 |= 2;
                denominator_ = value;
              }
            }
            /// <summary>Gets whether the "denominator" field is set</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool HasDenominator {
              get { return (_hasBits0 & 2) != 0; }
            }
            /// <summary>Clears the value of the "denominator" field</summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void ClearDenominator() {
              _hasBits0 &= ~2;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override bool Equals(object other) {
              return Equals(other as Rational32);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool Equals(Rational32 other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Numerator != other.Numerator) return false;
              if (Denominator != other.Denominator) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override int GetHashCode() {
              int hash = 1;
              if (HasNumerator) hash ^= Numerator.GetHashCode();
              if (HasDenominator) hash ^= Denominator.GetHashCode();
              if (_unknownFields != null) {
                hash ^= _unknownFields.GetHashCode();
              }
              return hash;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void WriteTo(pb::CodedOutputStream output) {
            #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              output.WriteRawMessage(this);
            #else
              if (HasNumerator) {
                output.WriteRawTag(8);
                output.WriteInt32(Numerator);
              }
              if (HasDenominator) {
                output.WriteRawTag(16);
                output.WriteInt32(Denominator);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            #endif
            }

            #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
              if (HasNumerator) {
                output.WriteRawTag(8);
                output.WriteInt32(Numerator);
              }
              if (HasDenominator) {
                output.WriteRawTag(16);
                output.WriteInt32(Denominator);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(ref output);
              }
            }
            #endif

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public int CalculateSize() {
              int size = 0;
              if (HasNumerator) {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Numerator);
              }
              if (HasDenominator) {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Denominator);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void MergeFrom(Rational32 other) {
              if (other == null) {
                return;
              }
              if (other.HasNumerator) {
                Numerator = other.Numerator;
              }
              if (other.HasDenominator) {
                Denominator = other.Denominator;
              }
              _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void MergeFrom(pb::CodedInputStream input) {
            #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              input.ReadRawMessage(this);
            #else
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                    break;
                  case 8: {
                    Numerator = input.ReadInt32();
                    break;
                  }
                  case 16: {
                    Denominator = input.ReadInt32();
                    break;
                  }
                }
              }
            #endif
            }

            #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                  case 8: {
                    Numerator = input.ReadInt32();
                    break;
                  }
                  case 16: {
                    Denominator = input.ReadInt32();
                    break;
                  }
                }
              }
            }
            #endif

          }

        }
        #endregion

      }

    }
    #endregion

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the VideoPreStreamCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.VideoPreStreamCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.VideoPreStreamCalculatorOptions>(151386123, pb::FieldCodec.ForMessage(1211088986, global::Mediapipe.VideoPreStreamCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code