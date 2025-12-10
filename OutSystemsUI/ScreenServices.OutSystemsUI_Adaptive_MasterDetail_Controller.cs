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
[Route("screenservices/OutSystemsUI/Adaptive/MasterDetail")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Adaptive_MasterDetail_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Adaptive_MasterDetail_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Adaptive_MasterDetail_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Adaptive_MasterDetail_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Adaptive_MasterDetail_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Adaptive_MasterDetail_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsUI_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsUI_Adaptive_MasterDetail_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Adaptive.MasterDetail.OnDetailOpen*/"Kn_hixxDWEm4lMd7mIpycQ*27cEBi3vKECfCz8nOuarVA", 
/*Adaptive.MasterDetail.FocusTrap*/"Kn_hixxDWEm4lMd7mIpycQ*ruLjBsCWpEGP14RJNOU9ZA", 
/*MoveElement*/"Kn_hixxDWEm4lMd7mIpycQ*fKauCzBE8E+Jnb0QL5gRGQ", 
/*Adaptive.MasterDetail.GetActiveElement*/"Kn_hixxDWEm4lMd7mIpycQ*5vBmJlzWpk2GscZ2O0O5ag", 
/*Adaptive.MasterDetail.SetAttributes*/"Kn_hixxDWEm4lMd7mIpycQ*LGHOJx9iXEuCRd3Lk9OxuA", 
/*Adaptive.MasterDetail.OnDetailClose*/"Kn_hixxDWEm4lMd7mIpycQ*tCmiY9oyDkSBa9j8zSuD8w", 
/*Adaptive.MasterDetail.OnReady*/"Kn_hixxDWEm4lMd7mIpycQ*6HS7bYq2KkKfGWRd0mjj8Q", 
/*Adaptive.MasterDetail.FocusOnSpan*/"Kn_hixxDWEm4lMd7mIpycQ*wtc9oqm1y0GhATh1sjvChg"});

    }

    public OutSystemsUI_Adaptive_MasterDetail_Controller(
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
