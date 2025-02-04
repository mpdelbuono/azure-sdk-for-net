// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    internal static partial class TagOrderByExtensions
    {
        public static string ToSerialString(this TagOrderBy value) => value switch
        {
            TagOrderBy.None => "none",
            TagOrderBy.LastUpdatedOnDescending => "timedesc",
            TagOrderBy.LastUpdatedOnAscending => "timeasc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TagOrderBy value.")
        };

        public static TagOrderBy ToTagOrderBy(this string value)
        {
            if (string.Equals(value, "none", StringComparison.InvariantCultureIgnoreCase)) return TagOrderBy.None;
            if (string.Equals(value, "timedesc", StringComparison.InvariantCultureIgnoreCase)) return TagOrderBy.LastUpdatedOnDescending;
            if (string.Equals(value, "timeasc", StringComparison.InvariantCultureIgnoreCase)) return TagOrderBy.LastUpdatedOnAscending;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TagOrderBy value.");
        }
    }
}
