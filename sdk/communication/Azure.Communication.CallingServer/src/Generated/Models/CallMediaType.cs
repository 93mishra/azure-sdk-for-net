// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The CallMediaType. </summary>
    public readonly partial struct CallMediaType : IEquatable<CallMediaType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CallMediaType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CallMediaType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AudioValue = "audio";
        private const string VideoValue = "video";

        /// <summary> audio. </summary>
        public static CallMediaType Audio { get; } = new CallMediaType(AudioValue);
        /// <summary> video. </summary>
        public static CallMediaType Video { get; } = new CallMediaType(VideoValue);
        /// <summary> Determines if two <see cref="CallMediaType"/> values are the same. </summary>
        public static bool operator ==(CallMediaType left, CallMediaType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CallMediaType"/> values are not the same. </summary>
        public static bool operator !=(CallMediaType left, CallMediaType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CallMediaType"/>. </summary>
        public static implicit operator CallMediaType(string value) => new CallMediaType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CallMediaType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CallMediaType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
