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
[Route("screenservices/OutSystemsUI/Numbers/Rating")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Numbers_Rating_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Numbers_Rating_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Numbers_Rating_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Numbers_Rating_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Numbers_Rating_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Numbers_Rating_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Numbers_Rating_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GenerateUniqueId*/"Kn_hixxDWEm4lMd7mIpycQ*0XavAbDZ6Ua+QBhH6oQk2g", 
/*RatingChangeIsEdit*/"Kn_hixxDWEm4lMd7mIpycQ*EiJeKGTwH06e68J_CIuC8w", 
/*RatingCreate*/"Kn_hixxDWEm4lMd7mIpycQ*L5t_KkbRg0SBXKauP8KC_A", 
/*Numbers.Rating.RegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*c51TUxawTUWkZA1zIBizTw", 
/*RatingInitialize*/"Kn_hixxDWEm4lMd7mIpycQ*kUEMaLvq6ESsz6EhZrS1oA", 
/*Numbers.Rating.OnSelectHandler*/"Kn_hixxDWEm4lMd7mIpycQ*gy+6hzpOg0ehBXdgqysklA", 
/*LogEvent*/"Kn_hixxDWEm4lMd7mIpycQ*3jjJi8SibUOUuWrcNNmYFg", 
/*RatingChangeRatingScale*/"Kn_hixxDWEm4lMd7mIpycQ*dE0mjWY0IEC+SAy8ramS1A", 
/*RatingChangeRatingValue*/"Kn_hixxDWEm4lMd7mIpycQ*6KW1sVgDZk6dkklXF3CH3Q", 
/*RatingRegisterCallback*/"Kn_hixxDWEm4lMd7mIpycQ*kwKMwxx0SE2EHAonspMQfg", 
/*RatingChangeExtendedClass*/"Kn_hixxDWEm4lMd7mIpycQ*A12N0WqSv0eTrR2+y9WNpw", 
/*RatingChangeSize*/"Kn_hixxDWEm4lMd7mIpycQ*rDZm3AFin0uP2+JY++zSkg", 
/*Numbers.Rating.InitializedHandler*/"Kn_hixxDWEm4lMd7mIpycQ*VG3F4JUWqU296HNlO0+_Xg", 
/*RatingDestroy*/"Kn_hixxDWEm4lMd7mIpycQ*_QUL8QzouU21w4Y+HjgWTg"});

    }

    public OutSystemsUI_Numbers_Rating_Controller(
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
