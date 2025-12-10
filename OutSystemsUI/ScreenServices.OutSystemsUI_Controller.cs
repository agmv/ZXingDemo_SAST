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
[Route("screenservices/OutSystemsUI")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsUI_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsUI_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsUI_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsUI_Controller); }
        public override void EnsureInitialized() { OutSystemsUI_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsUI_Controller.GetDbBinaryConfigs(); }
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

                
                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        
        return dbBinaryConfigs;
    }



    static OutSystemsUI_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* SkipToContent_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*_c2CAT+D102tYgVoS_HEdw", new String[] { });
Permissions.AddPermissionPropagationPath(/* MoveElement */"Kn_hixxDWEm4lMd7mIpycQ*fKauCzBE8E+Jnb0QL5gRGQ", new String[] { 
/*MoveElement_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*oMixQCMUiEOQs_GqRKQkKA"});
Permissions.AddPermissionPropagationPath(/* MenuReady */"Kn_hixxDWEm4lMd7mIpycQ*RmlZEysVCEm+VI+vAZotsQ", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* SetLang */"Kn_hixxDWEm4lMd7mIpycQ*WxQ0Foobt06XqI2YgwwILQ", new String[] { 
/*SetLang_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*nZQjn7+6F0yyGkK6j4rYmQ"});
Permissions.AddPermissionPropagationPath(/* ToggleTextSpacing */"Kn_hixxDWEm4lMd7mIpycQ*lpumF0DITkK_p+HM2xm0Pg", new String[] { 
/*ToggleTextSpacing_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*6+J2Prvw3UaqBKoGDDjE3w"});
Permissions.AddPermissionPropagationPath(/* SetMenuIcon */"Kn_hixxDWEm4lMd7mIpycQ*ZETeHV+it0+N0my823scLA", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* SetFocus_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*gWJMJUfS4E+y0ECssH27_g", new String[] { });
Permissions.AddPermissionPropagationPath(/* SetMenuIconListeners */"Kn_hixxDWEm4lMd7mIpycQ*_11xLwz33EKTaCdoVOzzhQ", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* MasterDetailSetContentFocus_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*tt_EL8+CZESaEDdh17865g", new String[] { });
Permissions.AddPermissionPropagationPath(/* SetMenuAttributes */"Kn_hixxDWEm4lMd7mIpycQ*ESHkOFhygUSr2c6PVMh1+Q", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* ToggleTextSpacing_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*6+J2Prvw3UaqBKoGDDjE3w", new String[] { });
Permissions.AddPermissionPropagationPath(/* MoveElement_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*oMixQCMUiEOQs_GqRKQkKA", new String[] { });
Permissions.AddPermissionPropagationPath(/* SetAriaHidden_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*_q7uQOI+fkKSXEb_iaUNlA", new String[] { });
Permissions.AddPermissionPropagationPath(/* ToggleSideMenu */"Kn_hixxDWEm4lMd7mIpycQ*DCQtVNJTOkqa1AaUsdSc5w", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* AddFavicon */"Kn_hixxDWEm4lMd7mIpycQ*_0NYWTTYl0ycqAqbD2ODmA", new String[] { 
/*AddFavicon_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*49snllG4+EmkehUTxAND6w"});
Permissions.AddPermissionPropagationPath(/* DatePickerDisableWeekDays */"Kn_hixxDWEm4lMd7mIpycQ*jXtJWw8wo0CLBUWLGUJBYQ", new String[] { 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});
Permissions.AddPermissionPropagationPath(/* SkipToContent */"Kn_hixxDWEm4lMd7mIpycQ*47TabZ9HT0ixaXEVUGyJag", new String[] { 
/*SkipToContent_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*_c2CAT+D102tYgVoS_HEdw"});
Permissions.AddPermissionPropagationPath(/* SetFocus */"Kn_hixxDWEm4lMd7mIpycQ*oih6gdN1p02bcN63KtmoNg", new String[] { 
/*SetFocus_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*gWJMJUfS4E+y0ECssH27_g"});
Permissions.AddPermissionPropagationPath(/* SetMenuListeners */"Kn_hixxDWEm4lMd7mIpycQ*9cFahaid_ESaRP3Q6_FwUw", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* SetActiveMenuItems */"Kn_hixxDWEm4lMd7mIpycQ*FMhBkkyTfUCBwiIQM1Ct6w", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* AddFavicon_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*49snllG4+EmkehUTxAND6w", new String[] { });
Permissions.AddPermissionPropagationPath(/* SetLang_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*nZQjn7+6F0yyGkK6j4rYmQ", new String[] { });
Permissions.AddPermissionPropagationPath(/* MasterDetailSetContentFocus */"Kn_hixxDWEm4lMd7mIpycQ*3wuNsg73ZEiE8P2CkpP9KQ", new String[] { 
/*MasterDetailSetContentFocus_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*tt_EL8+CZESaEDdh17865g"});
Permissions.AddPermissionPropagationPath(/* SetDeviceBreakpoints */"Kn_hixxDWEm4lMd7mIpycQ*kzLCurPnyEiZZBS7mNwWSA", new String[] { 
/*SetDeviceBreakpoints_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*OPbw+rkI00e_6hZxAdOnDw"});
Permissions.AddPermissionPropagationPath(/* LayoutReady */"Kn_hixxDWEm4lMd7mIpycQ*3YPe0a8dvEOq0s0BQKEmYA", new String[] { 
/*FixInputs*/"Kn_hixxDWEm4lMd7mIpycQ*joiCQJkwhEazo8+aMtGV2Q", 
/*WCAGMetaTag*/"Kn_hixxDWEm4lMd7mIpycQ*P1CTemhq5kGBBVkXbTT5aA", 
/*SetDeviceClass*/"Kn_hixxDWEm4lMd7mIpycQ*OOQHk+EK0UyAa1lqT_YN4w", 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* MenuHide */"Kn_hixxDWEm4lMd7mIpycQ*rTUt1ZeC60SXXTbA17bXvg", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* IsMenuDraggable */"Kn_hixxDWEm4lMd7mIpycQ*Nrq11Yu9QUG7x8e2miqF_g", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* MenuDestroy */"Kn_hixxDWEm4lMd7mIpycQ*JtlI3IoeP0q+nWXkkIPiTg", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* SetBottomBarActiveElement */"Kn_hixxDWEm4lMd7mIpycQ*aKul3GyFdUyInhOVT5pVnQ", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* SetAccessibilityRole_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*EPpn3UpIC0iwrU2cI_+V3A", new String[] { });
Permissions.AddPermissionPropagationPath(/* LoadOutSystemsUIScript */"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q", new String[] { 
/*System_.RequireScript*/"uXCIR2Atc0+es3zYuZSnNw*VUaNOBzdXEyNRvQg0P4CoQ"});
Permissions.AddPermissionPropagationPath(/* SetAccessibilityRole */"Kn_hixxDWEm4lMd7mIpycQ*nIPZ47GGZkyGi3Ef5TZsqw", new String[] { 
/*SetAccessibilityRole_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*EPpn3UpIC0iwrU2cI_+V3A"});
Permissions.AddPermissionPropagationPath(/* AddRTLObserver */"Kn_hixxDWEm4lMd7mIpycQ*CHNd69jPd0mQhoaurABYmA", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});
Permissions.AddPermissionPropagationPath(/* SetAriaHidden */"Kn_hixxDWEm4lMd7mIpycQ*sdxo8WObfkKHDkj1hJ+dxQ", new String[] { 
/*SetAriaHidden_Legacy*/"Kn_hixxDWEm4lMd7mIpycQ*_q7uQOI+fkKSXEb_iaUNlA"});
Permissions.AddPermissionPropagationPath(/* SetDeviceBreakpoints_Legacy */"Kn_hixxDWEm4lMd7mIpycQ*OPbw+rkI00e_6hZxAdOnDw", new String[] { });
Permissions.AddPermissionPropagationPath(/* MenuShow */"Kn_hixxDWEm4lMd7mIpycQ*kaZY_xZ0Q0WkzEXP5e61QQ", new String[] { 
/*LoadOutSystemsUIScript*/"Kn_hixxDWEm4lMd7mIpycQ*_uqx30P38UGXftOZRV0J5Q"});

    }

    public OutSystemsUI_Controller(
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
