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
[Route("screenservices/OutSystemsUI/Adaptive/Gallery")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Adaptive_Gallery_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Adaptive_Gallery_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Adaptive_Gallery_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Adaptive_Gallery_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Adaptive_Gallery_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Adaptive_Gallery_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Adaptive_Gallery_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*GalleryRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*svdAEfCJPE6IdJtofKUbEg", 
/*GalleryChangeTextProperty*/"Kn_hixxDWEm4lMd7mIpycQ*3fmUJ7MfX0GOEcH3GCL__Q", 
/*GalleryCreate*/"Kn_hixxDWEm4lMd7mIpycQ*yHUNNI9FOUW0LTimdHPQmw", 
/*GalleryInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*j8d_bE3kSkuDNoG5h6HlMA", 
/*GalleryDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*6geNfWfYNEKJUt8iiF4k0Q", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*Adaptive.Gallery.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*TvBEvKbTo02sKfn3gAwLOw", 
/*Adaptive.Gallery.RegisterCallbacks*/"Kn_hixxDWEm4lMd7mIpycQ*5R0Z5h_R2UuwoYCorxzsRQ"});

    }

    public OutSystemsUI_Adaptive_Gallery_Controller(
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
