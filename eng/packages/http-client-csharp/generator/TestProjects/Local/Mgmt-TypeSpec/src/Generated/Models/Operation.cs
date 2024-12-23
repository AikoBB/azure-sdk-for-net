// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtTypeSpec.Models
{
    /// <summary> Details of a REST API operation, returned from the Resource Provider Operations API. </summary>
    public partial class Operation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal Operation()
        {
        }

        internal Operation(string name, bool? isDataAction, OperationDisplay display, Origin? origin, ActionType? actionType, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            IsDataAction = isDataAction;
            Display = display;
            Origin = origin;
            ActionType = actionType;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The name of the operation, as per Resource-Based Access Control (RBAC). Examples: "Microsoft.Compute/virtualMachines/write", "Microsoft.Compute/virtualMachines/capture/action". </summary>
        public string Name { get; }

        /// <summary> Whether the operation applies to data-plane. This is "true" for data-plane operations and "false" for Azure Resource Manager/control-plane operations. </summary>
        public bool? IsDataAction { get; }

        /// <summary> Localized display information for this particular operation. </summary>
        public OperationDisplay Display { get; }

        /// <summary> The intended executor of the operation; as in Resource Based Access Control (RBAC) and audit logs UX. Default value is "user,system". </summary>
        public Origin? Origin { get; }

        /// <summary> Extensible enum. Indicates the action type. "Internal" refers to actions that are for internal only APIs. </summary>
        public ActionType? ActionType { get; }
    }
}
