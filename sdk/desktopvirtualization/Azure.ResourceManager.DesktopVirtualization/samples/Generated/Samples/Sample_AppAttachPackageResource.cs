// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_AppAttachPackageResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AppAttachPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/AppAttachPackage_Get.json
            // this example is just showing the usage of "AppAttachPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppAttachPackageResource created on azure
            // for more information of creating AppAttachPackageResource, please refer to the document of AppAttachPackageResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string appAttachPackageName = "packagefullname";
            ResourceIdentifier appAttachPackageResourceId = AppAttachPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appAttachPackageName);
            AppAttachPackageResource appAttachPackage = client.GetAppAttachPackageResource(appAttachPackageResourceId);

            // invoke the operation
            AppAttachPackageResource result = await appAttachPackage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppAttachPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_AppAttachPackageDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/AppAttachPackage_Delete.json
            // this example is just showing the usage of "AppAttachPackage_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppAttachPackageResource created on azure
            // for more information of creating AppAttachPackageResource, please refer to the document of AppAttachPackageResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string appAttachPackageName = "packagefullname";
            ResourceIdentifier appAttachPackageResourceId = AppAttachPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appAttachPackageName);
            AppAttachPackageResource appAttachPackage = client.GetAppAttachPackageResource(appAttachPackageResourceId);

            // invoke the operation
            await appAttachPackage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AppAttachPackageUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/AppAttachPackage_Update.json
            // this example is just showing the usage of "AppAttachPackage_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppAttachPackageResource created on azure
            // for more information of creating AppAttachPackageResource, please refer to the document of AppAttachPackageResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string appAttachPackageName = "msixpackagefullname";
            ResourceIdentifier appAttachPackageResourceId = AppAttachPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, appAttachPackageName);
            AppAttachPackageResource appAttachPackage = client.GetAppAttachPackageResource(appAttachPackageResourceId);

            // invoke the operation
            AppAttachPackagePatch patch = new AppAttachPackagePatch();
            AppAttachPackageResource result = await appAttachPackage.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppAttachPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
