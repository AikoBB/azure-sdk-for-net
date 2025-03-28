// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal class VaultHealthDetailsOperationSource : IOperationSource<VaultHealthDetails>
    {
        VaultHealthDetails IOperationSource<VaultHealthDetails>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return VaultHealthDetails.DeserializeVaultHealthDetails(document.RootElement);
        }

        async ValueTask<VaultHealthDetails> IOperationSource<VaultHealthDetails>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return VaultHealthDetails.DeserializeVaultHealthDetails(document.RootElement);
        }
    }
}
