// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Files
{
    internal readonly partial struct InternalUploadPartObject : IEquatable<InternalUploadPartObject>
    {
        private readonly string _value;

        public InternalUploadPartObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UploadPartValue = "upload.part";

        public static InternalUploadPartObject UploadPart { get; } = new InternalUploadPartObject(UploadPartValue);
        public static bool operator ==(InternalUploadPartObject left, InternalUploadPartObject right) => left.Equals(right);
        public static bool operator !=(InternalUploadPartObject left, InternalUploadPartObject right) => !left.Equals(right);
        public static implicit operator InternalUploadPartObject(string value) => new InternalUploadPartObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalUploadPartObject other && Equals(other);
        public bool Equals(InternalUploadPartObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}