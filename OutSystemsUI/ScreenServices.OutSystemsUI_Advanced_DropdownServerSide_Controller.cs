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
[Route("screenservices/OutSystemsUI/Advanced/DropdownServerSide")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Advanced_DropdownServerSide_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Advanced_DropdownServerSide_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Advanced_DropdownServerSide_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Advanced_DropdownServerSide_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Advanced_DropdownServerSide_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Advanced_DropdownServerSide_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Advanced_DropdownServerSide_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*DropdownDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*zLAqT9q5REWxvlshdPuq0Q", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*DropdownChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*VpYwsq6V_EaQJ+NsQiw2MQ", 
/*Advanced.DropdownServerSide.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*aJYjtY7sNEuuIPTz6r2OIQ", 
/*DropdownInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*+qIK2Pa33EGh+pJM7btGag", 
/*DropdownRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*ybA42fKFsEi+gRcq8_XSeA", 
/*Advanced.DropdownServerSide.OnToggleHandler*/"Kn_hixxDWEm4lMd7mIpycQ*KHMa3JDMf0yVNCNE4718eA", 
/*DropdownCreate*/"Kn_hixxDWEm4lMd7mIpycQ*UK267ycLLk2GBwu7GMyd0w", 
/*Advanced.DropdownServerSide.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*akgS8rY+6Ei00fospaE2qg", 
/*DropdownChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*MU419xEbKUe3AmuNGg_wHg"});

    }

    public OutSystemsUI_Advanced_DropdownServerSide_Controller(
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
