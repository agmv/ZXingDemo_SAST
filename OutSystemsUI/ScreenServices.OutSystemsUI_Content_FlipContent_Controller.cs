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
[Route("screenservices/OutSystemsUI/Content/FlipContent")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Content_FlipContent_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Content_FlipContent_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Content_FlipContent_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Content_FlipContent_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Content_FlipContent_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Content_FlipContent_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Content_FlipContent_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Content.FlipContent.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*QTzPDzOwAE6p70fmeAL06A", 
/*FlipContentInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*dwAxGFz8BkK1Ua8n1OieMQ", 
/*FlipContentChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*p0RjLKVzWE2WNqZBcx+mLw", 
/*Content.FlipContent.ToggleFlip*/"Kn_hixxDWEm4lMd7mIpycQ*A2a3RBio5EqCrCgSk9LgfA", 
/*FlipContentChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*XlrGVrg3bUWHGoRS02L8Vw", 
/*FlipContentCreate*/"Kn_hixxDWEm4lMd7mIpycQ*vvIRai0rhEWviZJuHSkz_Q", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*FlipContentDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*hdYpur_hSUadIG5Mgt4Sxg", 
/*Content.FlipContent.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*eMY74oxNt0O_38oez3yd4g", 
/*FlipContentRegisterCallack*/"Kn_hixxDWEm4lMd7mIpycQ*Yf+y+pTpa060VtHVpp49Lg"});

    }

    public OutSystemsUI_Content_FlipContent_Controller(
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
