// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> Error details. </summary>
    public partial class ErrorDetails
    {
        /// <summary> Initializes a new instance of <see cref="ErrorDetails"/>. </summary>
        internal ErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDetails"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="innerError"> Inner error details. </param>
        internal ErrorDetails(string code, string message, ErrorDetails innerError)
        {
            Code = code;
            Message = message;
            InnerError = innerError;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Inner error details. </summary>
        public ErrorDetails InnerError { get; }
    }
}
