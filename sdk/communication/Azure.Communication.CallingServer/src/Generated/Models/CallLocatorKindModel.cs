// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The call locator kind. </summary>
    public readonly partial struct CallLocatorKindModel : IEquatable<CallLocatorKindModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CallLocatorKindModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CallLocatorKindModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GroupCallLocatorValue = "groupCallLocator";
        private const string ServerCallLocatorValue = "serverCallLocator";

        /// <summary> groupCallLocator. </summary>
        public static CallLocatorKindModel GroupCallLocator { get; } = new CallLocatorKindModel(GroupCallLocatorValue);
        /// <summary> serverCallLocator. </summary>
        public static CallLocatorKindModel ServerCallLocator { get; } = new CallLocatorKindModel(ServerCallLocatorValue);
        /// <summary> Determines if two <see cref="CallLocatorKindModel"/> values are the same. </summary>
        public static bool operator ==(CallLocatorKindModel left, CallLocatorKindModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CallLocatorKindModel"/> values are not the same. </summary>
        public static bool operator !=(CallLocatorKindModel left, CallLocatorKindModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CallLocatorKindModel"/>. </summary>
        public static implicit operator CallLocatorKindModel(string value) => new CallLocatorKindModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CallLocatorKindModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CallLocatorKindModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
