// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Maintenance.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Maintenance.Samples
{
    public partial class Sample_MaintenanceApplyUpdateResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApplyUpdatesGet()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-10-01-preview/examples/ApplyUpdates_Get.json
            // this example is just showing the usage of "ApplyUpdates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MaintenanceApplyUpdateResource created on azure
            // for more information of creating MaintenanceApplyUpdateResource, please refer to the document of MaintenanceApplyUpdateResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            string providerName = "Microsoft.Compute";
            string resourceType = "virtualMachineScaleSets";
            string resourceName = "smdtest1";
            string applyUpdateName = "e9b9685d-78e4-44c4-a81c-64a14f9b87b6";
            ResourceIdentifier maintenanceApplyUpdateResourceId = MaintenanceApplyUpdateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceType, resourceName, applyUpdateName);
            MaintenanceApplyUpdateResource maintenanceApplyUpdate = client.GetMaintenanceApplyUpdateResource(maintenanceApplyUpdateResourceId);

            // invoke the operation
            MaintenanceApplyUpdateResource result = await maintenanceApplyUpdate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MaintenanceApplyUpdateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApplyUpdatesCreateOrUpdateOnlyNoCancellation()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-10-01-preview/examples/ApplyUpdates_CreateOrUpdateOnly_NoCancellation.json
            // this example is just showing the usage of "ApplyUpdates_CreateOrUpdateOrCancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MaintenanceApplyUpdateResource created on azure
            // for more information of creating MaintenanceApplyUpdateResource, please refer to the document of MaintenanceApplyUpdateResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            string providerName = "Microsoft.Compute";
            string resourceType = "virtualMachineScaleSets";
            string resourceName = "smdtest1";
            string applyUpdateName = "20230901121200";
            ResourceIdentifier maintenanceApplyUpdateResourceId = MaintenanceApplyUpdateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceType, resourceName, applyUpdateName);
            MaintenanceApplyUpdateResource maintenanceApplyUpdate = client.GetMaintenanceApplyUpdateResource(maintenanceApplyUpdateResourceId);

            // invoke the operation
            MaintenanceApplyUpdateData data = new MaintenanceApplyUpdateData();
            ArmOperation<MaintenanceApplyUpdateResource> lro = await maintenanceApplyUpdate.UpdateAsync(WaitUntil.Completed, data);
            MaintenanceApplyUpdateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MaintenanceApplyUpdateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApplyUpdatesCreateOrUpdateOrCancel()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/preview/2023-10-01-preview/examples/ApplyUpdates_CreateOrUpdate_CancelMaintenance.json
            // this example is just showing the usage of "ApplyUpdates_CreateOrUpdateOrCancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MaintenanceApplyUpdateResource created on azure
            // for more information of creating MaintenanceApplyUpdateResource, please refer to the document of MaintenanceApplyUpdateResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            string providerName = "Microsoft.Maintenance";
            string resourceType = "maintenanceConfigurations";
            string resourceName = "maintenanceConfig1";
            string applyUpdateName = "20230901121200";
            ResourceIdentifier maintenanceApplyUpdateResourceId = MaintenanceApplyUpdateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceType, resourceName, applyUpdateName);
            MaintenanceApplyUpdateResource maintenanceApplyUpdate = client.GetMaintenanceApplyUpdateResource(maintenanceApplyUpdateResourceId);

            // invoke the operation
            MaintenanceApplyUpdateData data = new MaintenanceApplyUpdateData
            {
                Status = MaintenanceUpdateStatus.Cancel,
            };
            ArmOperation<MaintenanceApplyUpdateResource> lro = await maintenanceApplyUpdate.UpdateAsync(WaitUntil.Completed, data);
            MaintenanceApplyUpdateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MaintenanceApplyUpdateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
