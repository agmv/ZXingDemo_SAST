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
[Route("screenservices/OutSystemsUI/Interaction/StackedCards")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Interaction_StackedCards_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Interaction_StackedCards_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Interaction_StackedCards_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Interaction_StackedCards_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Interaction_StackedCards_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Interaction_StackedCards_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsUI_Interaction_StackedCards_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Interaction.StackedCards.CurrentElement*/"Kn_hixxDWEm4lMd7mIpycQ*2looCe2DAU2eNMVEIAC9Nw", 
/*Interaction.StackedCards.OnActionTop*/"Kn_hixxDWEm4lMd7mIpycQ*aXKcCwl8AUCT4Iq+lfyqkg", 
/*Interaction.StackedCards.ResetOverlayLeft*/"Kn_hixxDWEm4lMd7mIpycQ*CDgwF8t5MEmXRWt86hePGA", 
/*Interaction.StackedCards.SetZindex*/"Kn_hixxDWEm4lMd7mIpycQ*I5OmJ6mRd0abw81ao4Dg_Q", 
/*Interaction.StackedCards.RemoveNoTransition*/"Kn_hixxDWEm4lMd7mIpycQ*iKCqKHwmA0S61+P+4piKgQ", 
/*Interaction.StackedCards.OnListRemoveUpdate*/"Kn_hixxDWEm4lMd7mIpycQ*SmYjOC_LX0eMo0pTaJA7dw", 
/*Interaction.StackedCards.UpdateLastActive_A11S*/"Kn_hixxDWEm4lMd7mIpycQ*h7lFQ1sW7ESaIlQfNcXm4A", 
/*Interaction.StackedCards.TransformUi*/"Kn_hixxDWEm4lMd7mIpycQ*QuK1Tih4N0K_lL4t+jtH9w", 
/*Interaction.StackedCards.OnSwipeTop*/"Kn_hixxDWEm4lMd7mIpycQ*vIgtYysXC0mYoqcM_iEX7Q", 
/*Interaction.StackedCards.ResetOverlays*/"Kn_hixxDWEm4lMd7mIpycQ*lyysdtzOv02oTrgeVp9+Hw", 
/*Interaction.StackedCards.OnSwipeLeft*/"Kn_hixxDWEm4lMd7mIpycQ*52+BgjgskkqSgGPWQsNkfA", 
/*Interaction.StackedCards.OnSwipeRight*/"Kn_hixxDWEm4lMd7mIpycQ*TGZ4kuQVwEeq0f610w_2Og", 
/*Interaction.StackedCards.OnActionLeft*/"Kn_hixxDWEm4lMd7mIpycQ*QLKcms4pRUerPrkgJpKPwQ", 
/*Interaction.StackedCards.SetActiveHidden*/"Kn_hixxDWEm4lMd7mIpycQ*OOVUso7_p0OKi6PyrORgqA", 
/*Interaction.StackedCards.ResetOverlayRight*/"Kn_hixxDWEm4lMd7mIpycQ*XXQ0tjjSZUGcmEfOBG3Ujg", 
/*Interaction.StackedCards.Init*/"Kn_hixxDWEm4lMd7mIpycQ*niat0jUlxkKGD0GJ2nljzw", 
/*Interaction.StackedCards.UpdateUi*/"Kn_hixxDWEm4lMd7mIpycQ*rw0p4bWe5UexyW6B96E0aQ", 
/*Interaction.StackedCards.BackToMiddle*/"Kn_hixxDWEm4lMd7mIpycQ*DYPU7IArtkyMqabkMx2Q1Q", 
/*Interaction.StackedCards.OnActionRight*/"Kn_hixxDWEm4lMd7mIpycQ*iKUb7kYdOkuyRp4BK8WE+Q", 
/*Interaction.StackedCards.CountElements*/"Kn_hixxDWEm4lMd7mIpycQ*8HG09WjkX0qbKSCqVyvXRg"});

    }

    public OutSystemsUI_Interaction_StackedCards_Controller(
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
