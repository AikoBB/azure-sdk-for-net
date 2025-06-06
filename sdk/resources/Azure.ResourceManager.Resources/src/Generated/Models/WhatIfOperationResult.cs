// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Result of the What-If operation. Contains a list of predicted changes and a URL link to get to the next set of results. </summary>
    public partial class WhatIfOperationResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WhatIfOperationResult"/>. </summary>
        internal WhatIfOperationResult()
        {
            Changes = new ChangeTrackingList<WhatIfChange>();
            PotentialChanges = new ChangeTrackingList<WhatIfChange>();
            Diagnostics = new ChangeTrackingList<DeploymentDiagnosticsDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="WhatIfOperationResult"/>. </summary>
        /// <param name="status"> Status of the What-If operation. </param>
        /// <param name="error"> Error when What-If operation fails. </param>
        /// <param name="changes"> List of resource changes predicted by What-If operation. </param>
        /// <param name="potentialChanges"> List of resource changes predicted by What-If operation. </param>
        /// <param name="diagnostics"> List of resource diagnostics detected by What-If operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WhatIfOperationResult(string status, ResponseError error, IReadOnlyList<WhatIfChange> changes, IReadOnlyList<WhatIfChange> potentialChanges, IReadOnlyList<DeploymentDiagnosticsDefinition> diagnostics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Error = error;
            Changes = changes;
            PotentialChanges = potentialChanges;
            Diagnostics = diagnostics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of the What-If operation. </summary>
        [WirePath("status")]
        public string Status { get; }
        /// <summary> Error when What-If operation fails. </summary>
        [WirePath("error")]
        public ResponseError Error { get; }
        /// <summary> List of resource changes predicted by What-If operation. </summary>
        [WirePath("properties.changes")]
        public IReadOnlyList<WhatIfChange> Changes { get; }
        /// <summary> List of resource changes predicted by What-If operation. </summary>
        [WirePath("properties.potentialChanges")]
        public IReadOnlyList<WhatIfChange> PotentialChanges { get; }
        /// <summary> List of resource diagnostics detected by What-If operation. </summary>
        [WirePath("properties.diagnostics")]
        public IReadOnlyList<DeploymentDiagnosticsDefinition> Diagnostics { get; }
    }
}
