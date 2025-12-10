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
[Route("screenservices/OutSystemsUI/Interaction/DEPRECATED_Carousel")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(OutSystemsUI_Utilities_TouchEvents_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsUI_Utilities_MouseEvents_Controller.ProxyInstance, childControllers);
SafeAddChildController(OutSystemsUI_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Interaction.DEPRECATED_Carousel.SetEventsStatus*/"Kn_hixxDWEm4lMd7mIpycQ*J2ywBRNER0inIN+jUubB5w", 
/*Interaction.DEPRECATED_Carousel.ChangeIsAnimatingStatus*/"Kn_hixxDWEm4lMd7mIpycQ*WAvNMvx6wUe6GV65E3znQA", 
/*Interaction.DEPRECATED_Carousel.GoTo*/"Kn_hixxDWEm4lMd7mIpycQ*CWD+VFGpG029nEk8wze__g", 
/*Interaction.DEPRECATED_Carousel.SetInterval*/"Kn_hixxDWEm4lMd7mIpycQ*oBa4dSkY_kuxHi9bSEjWpw", 
/*Interaction.DEPRECATED_Carousel.Init*/"Kn_hixxDWEm4lMd7mIpycQ*DXlhflRQHEWvJvSsH5iRaw", 
/*Interaction.DEPRECATED_Carousel.Update*/"Kn_hixxDWEm4lMd7mIpycQ*LqtDhvLlC0SzTjCf7V84bg", 
/*Interaction.DEPRECATED_Carousel.ClearInterval*/"Kn_hixxDWEm4lMd7mIpycQ*aIZShmBfBkGQyjp4Sbly_g", 
/*Interaction.DEPRECATED_Carousel.OnOrientationChange*/"Kn_hixxDWEm4lMd7mIpycQ*dmX_mFSK5EawGA3ns+ZSYQ", 
/*Interaction.DEPRECATED_Carousel.Previous*/"Kn_hixxDWEm4lMd7mIpycQ*fYkirezbM0ieZWqMvq6GcA", 
/*Interaction.DEPRECATED_Carousel.Next*/"Kn_hixxDWEm4lMd7mIpycQ*_KUd0lr_mUuqIYQ+cx3sOw"});

    }

    public OutSystemsUI_Interaction_DEPRECATED_Carousel_Controller(
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
