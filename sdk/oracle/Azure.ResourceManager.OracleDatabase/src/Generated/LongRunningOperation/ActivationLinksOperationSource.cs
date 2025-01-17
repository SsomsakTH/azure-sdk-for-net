// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.OracleDatabase.Models;

namespace Azure.ResourceManager.OracleDatabase
{
    internal class ActivationLinksOperationSource : IOperationSource<ActivationLinks>
    {
        ActivationLinks IOperationSource<ActivationLinks>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ActivationLinks.DeserializeActivationLinks(document.RootElement);
        }

        async ValueTask<ActivationLinks> IOperationSource<ActivationLinks>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ActivationLinks.DeserializeActivationLinks(document.RootElement);
        }
    }
}
