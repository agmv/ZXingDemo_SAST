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
[Route("screenservices/OutSystemsUI/Content/AccordionItem")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Content_AccordionItem_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Content_AccordionItem_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Content_AccordionItem_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Content_AccordionItem_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Content_AccordionItem_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Content_AccordionItem_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Content_AccordionItem_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*Content.AccordionItem.TriggerToggleClick*/"Kn_hixxDWEm4lMd7mIpycQ*c_sNJOo86kWYpoNpxA4nVQ", 
/*AccordionItemDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*rrmTg1+Xykiad+HwVV_JGQ", 
/*Content.AccordionItem.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*Xs0BiIstikCHWx+3lhpfEQ", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*AccordionItemChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*4rhDsFFLT0eeio3o9DQsTQ", 
/*AccordionItemChangeBooleanProperty*/"Kn_hixxDWEm4lMd7mIpycQ*vg7pv8Q1vkCtHVqAlbGXGg", 
/*AccordionItemCreate*/"Kn_hixxDWEm4lMd7mIpycQ*c3wYxiLm3kKRJd0Xsw0tPQ", 
/*AccordionItemInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*3umux5mOLk697vqzHH2TVQ", 
/*AccordionItemRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*tkLl2TO99kWvYVVR_hREHA", 
/*Content.AccordionItem.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*fMtB8u3ePE+3jMZz99s1aA"});

    }

    public OutSystemsUI_Content_AccordionItem_Controller(
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
