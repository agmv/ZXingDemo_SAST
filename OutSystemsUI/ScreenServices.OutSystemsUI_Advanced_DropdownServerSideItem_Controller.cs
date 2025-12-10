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
[Route("screenservices/OutSystemsUI/Advanced/DropdownServerSideItem")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Advanced_DropdownServerSideItem_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Advanced_DropdownServerSideItem_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Advanced_DropdownServerSideItem_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Advanced_DropdownServerSideItem_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Advanced_DropdownServerSideItem_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Advanced_DropdownServerSideItem_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Advanced_DropdownServerSideItem_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Advanced.DropdownServerSideItem.OnSelectedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*YMYADkEwuE6IYEKXuSuMbQ", 
/*DropdownServerSideItemChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*ivv6L8da+Ueg++3ty2nJow", 
/*Advanced.DropdownServerSideItem.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*e2+LNpGulEeL++j8Pu_BaQ", 
/*DropdownServerSideItemInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*ZgiXX4m8h0u2uEPwuF2ORQ", 
/*DropdownServerSideItemCreate*/"Kn_hixxDWEm4lMd7mIpycQ*50DEeUs2A0yfpEj7zd3pSg", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*Advanced.DropdownServerSideItem.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*_UdKjoT6w0yWTlRXx+Xx+Q", 
/*DropdownServerSideItemChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*C0atkRn+5Eqr1VTjOHOxTQ", 
/*DropdownServerSideItemDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*8f63xbyl4E+J8p73vD7LjA", 
/*DropdownServerSideItemRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*6qR+2praTUuB1rRCrl_Tyw"});

    }

    public OutSystemsUI_Advanced_DropdownServerSideItem_Controller(
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
