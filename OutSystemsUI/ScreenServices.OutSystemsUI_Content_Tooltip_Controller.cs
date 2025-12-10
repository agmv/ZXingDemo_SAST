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
[Route("screenservices/OutSystemsUI/Content/Tooltip")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Content_Tooltip_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Content_Tooltip_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Content_Tooltip_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Content_Tooltip_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Content_Tooltip_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Content_Tooltip_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Content_Tooltip_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Content.Tooltip.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*b9toGOe8tEG6r2Ydz92_Ow", 
/*Content.Tooltip.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*ToiZNAbtwUKpjTU5wJmGew", 
/*TooltipDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*APpqPdOjPkSc2mjejWu0gw", 
/*TooltipCreate*/"Kn_hixxDWEm4lMd7mIpycQ*Vaz8Xj6hJUiaMOfyfSQSVg", 
/*TooltipInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*6R75hTWHKkSBIZXoFIQzZg", 
/*TooltipRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*xOdzigVObk+qgbId5Q3K+w", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*Content.Tooltip.OnToggleHandler*/"Kn_hixxDWEm4lMd7mIpycQ*weUjxfbziUmetnZ78bi_mQ", 
/*TooltipChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*OAjb1bJms0GMJ_7am73lFw", 
/*TooltipChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*4zh0+dFnB0KQbMr9_Bui0g"});

    }

    public OutSystemsUI_Content_Tooltip_Controller(
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
