// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The mode of operation for runtime protection. </summary>
    public readonly partial struct ClusterUpdateStrategyType : IEquatable<ClusterUpdateStrategyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterUpdateStrategyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterUpdateStrategyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RackValue = "Rack";
        private const string PauseAfterRackValue = "PauseAfterRack";

        /// <summary> Rack. </summary>
        public static ClusterUpdateStrategyType Rack { get; } = new ClusterUpdateStrategyType(RackValue);
        /// <summary> PauseAfterRack. </summary>
        public static ClusterUpdateStrategyType PauseAfterRack { get; } = new ClusterUpdateStrategyType(PauseAfterRackValue);
        /// <summary> Determines if two <see cref="ClusterUpdateStrategyType"/> values are the same. </summary>
        public static bool operator ==(ClusterUpdateStrategyType left, ClusterUpdateStrategyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterUpdateStrategyType"/> values are not the same. </summary>
        public static bool operator !=(ClusterUpdateStrategyType left, ClusterUpdateStrategyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterUpdateStrategyType"/>. </summary>
        public static implicit operator ClusterUpdateStrategyType(string value) => new ClusterUpdateStrategyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterUpdateStrategyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterUpdateStrategyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
