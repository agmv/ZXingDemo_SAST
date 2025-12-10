using Microsoft.AspNetCore.Mvc;
using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.Controllers;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Core.ClientSettings;

namespace ssOutSystemsUI.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/OutSystemsUI/Private/OfflineDataSyncCore")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Private_OfflineDataSyncCore_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Private_OfflineDataSyncCore_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Private_OfflineDataSyncCore_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Private_OfflineDataSyncCore_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Private_OfflineDataSyncCore_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Private_OfflineDataSyncCore_Controller.GetDbBinaryConfigs(); }
    }

    public static readonly CheckPermissionsIndex Permissions;

    private static readonly HashSet<IScreenControllerProxy> childControllers = new();
    public static IEnumerable<IScreenControllerProxy> GetChildControllers() {
        return childControllers;
    }

    private static volatile bool initialized = false;
    public static void EnsureInitialized() {
        // Only a single thread can do initializations at the time. Allows the CheckPermissionsIndex class non-threadsafe.
        // This should always be done only once at ApplicationStart
        lock (ScreenServicesApiController.GlobalScreenServicesInitializationLock) {
            if (!initialized) {
                initialized = true; // InitPermissionIndexes propagates to new parents as well so we can set it as initialized here before going into recursion

                SafeAddChildController(OutSystemsUI_Private_NetworkStatusChanged_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsUI_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsUI_Private_OfflineDataSyncCore_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Private.OfflineDataSyncCore.OnResume*/"Kn_hixxDWEm4lMd7mIpycQ*ljgpFByHWECqPa9R9yql0w", 
/*StartOfflineDataSync*/"Kn_hixxDWEm4lMd7mIpycQ*6wYKHDHaTk24G0Nx4wSdrQ", 
/*Private.OfflineDataSyncCore.TriggerOnSyncComplete*/"Kn_hixxDWEm4lMd7mIpycQ*yRN8KzK4XEqBnkM+5MLnwg", 
/*Private.OfflineDataSyncCore.Init*/"Kn_hixxDWEm4lMd7mIpycQ*YQeNisDMZkCYXmveaPDjNw", 
/*Private.OfflineDataSyncCore.SyncWrapper*/"Kn_hixxDWEm4lMd7mIpycQ*61JtyqdE4kyQ3ouMgX1hkA", 
/*Private.OfflineDataSyncCore.TriggerOnSyncStart*/"Kn_hixxDWEm4lMd7mIpycQ*FlCNyxoo3kOfKJMpvkOKJA", 
/*Private.OfflineDataSyncCore.TriggerOnSyncError*/"Kn_hixxDWEm4lMd7mIpycQ*7ttB2m5dm0WJJXYKe4r3wQ", 
/*EndOfflineDataSync*/"Kn_hixxDWEm4lMd7mIpycQ*AB+048wZeESjgZV4xG1UYg"});

    }

    public OutSystemsUI_Private_OfflineDataSyncCore_Controller(
        IAppInfo appInfo,
        IApplicationLogger applicationLogger,
        ISettingsProvider settingsProvider,
        IHttpContextAccessor httpContextAccessor,
        IRequestContext requestContext,
        IClientSettingsService clientSettingsService
    ) : base(
        appInfo,
        applicationLogger,
        settingsProvider,
        httpContextAccessor,
        requestContext,
        clientSettingsService
    ) {
    }


}
