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

namespace ssOutSystemsMaps.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/OutSystemsMaps")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class OutSystemsMaps_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return OutSystemsMaps_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return OutSystemsMaps_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(OutSystemsMaps_Controller); }
        public override void EnsureInitialized() { OutSystemsMaps_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return OutSystemsMaps_Controller.GetDbBinaryConfigs(); }
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



    static OutSystemsMaps_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* ChangeHeatmapLayerPoints */"0TG7lXnw1k+rLlyDJoVaqg*9XKyAJxhxEmAV4Vxsg3WVA", new String[] { 
/*ChangeHeatmapLayerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*zttENGmCAkmGgOR5wjTufQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMapStyleId */"0TG7lXnw1k+rLlyDJoVaqg*d8G8DWV3A0ivGCDKmJ8I6A", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* ChangeMapUseAdvancedMarkers */"0TG7lXnw1k+rLlyDJoVaqg*tgYID3Ag8EWIXKMtLj66Bg", new String[] { 
/*ChangeMapProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*6TD2xAs9QESk6ypercnO3A"});
Permissions.AddPermissionPropagationPath(/* RemoveMarker */"0TG7lXnw1k+rLlyDJoVaqg*cfkSEMyznEu+vlXNBkJScw", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMapStyle */"0TG7lXnw1k+rLlyDJoVaqg*31ChFPeAO0WQq_Odz0Yf8Q", new String[] { 
/*ChangeMapProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*3akU50Vqo0yvHgOI1Hvvpg"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeCenter */"0TG7lXnw1k+rLlyDJoVaqg*b8YjFycVSE+AxceYfGc5Xw", new String[] { 
/*ChangeShapeProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*+eqaVpmy6EasDNk1p7Vv6Q"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeStrokeOpacity */"0TG7lXnw1k+rLlyDJoVaqg*1EXSJEb24EWiz13ogof5VQ", new String[] { 
/*ChangeShapeProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*O7UooPvU5U6bnRLd0PhOFg"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeFillOpacity */"0TG7lXnw1k+rLlyDJoVaqg*veXPJTGki0e1gjqRBttI0w", new String[] { 
/*ChangeShapeProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*O7UooPvU5U6bnRLd0PhOFg"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerIconHeight */"0TG7lXnw1k+rLlyDJoVaqg*mvT9JXb0mk+5FRX6aJn4Ww", new String[] { 
/*ChangeMarkerProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*yhWZiUsTXk6WOio7eq00Ug"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerAllowDrag */"0TG7lXnw1k+rLlyDJoVaqg*C7dbMGvtsEmcAagJEol3tw", new String[] { 
/*ChangeMarkerProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*z0yxHAzQlEGeljIdu7tDKA"});
Permissions.AddPermissionPropagationPath(/* ChangeHeatmapLayerGradient */"0TG7lXnw1k+rLlyDJoVaqg*tuGSMNSPAUqSkYYkW9YjVQ", new String[] { 
/*ChangeHeatmapLayerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*zttENGmCAkmGgOR5wjTufQ"});
Permissions.AddPermissionPropagationPath(/* ChangeToolStrokeColor */"0TG7lXnw1k+rLlyDJoVaqg*ZJJpMVnfy06nLZgBEbfJ+A", new String[] { 
/*ChangeToolProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*t7zTjtuQ00CxewT5k_NYBQ"});
Permissions.AddPermissionPropagationPath(/* ChangeHeatmapLayerRadius */"0TG7lXnw1k+rLlyDJoVaqg*OF6pMYNuLEiRyR963Xo8vA", new String[] { 
/*ChangeHeatmapLayerProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*emD_stx_b0m1gQz+yP7CSw"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeFillColor */"0TG7lXnw1k+rLlyDJoVaqg*U7dKNGqhRkOQSA8D3uIkFg", new String[] { 
/*ChangeShapeProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*+eqaVpmy6EasDNk1p7Vv6Q"});
Permissions.AddPermissionPropagationPath(/* ChangeSearchPlacesCountries */"0TG7lXnw1k+rLlyDJoVaqg*NNdEOJouNECbhHSOYWEkKg", new String[] { 
/*ChangeSearchPlacesProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*O7BxtqZ+C0yyT9Pvt+H72Q"});
Permissions.AddPermissionPropagationPath(/* ChangeFileLayerPreserveViewport */"0TG7lXnw1k+rLlyDJoVaqg*W_NAOoD83ECsAeu43mU87g", new String[] { 
/*ChangeFileLayerProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*Ddxoy9U5w0+GbO05_pvTIw"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeAllowDrag */"0TG7lXnw1k+rLlyDJoVaqg*c6BFPn99WkqYg8LMBpRdCg", new String[] { 
/*ChangeShapeProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*jZTb3NItn0W6rKSMONIcWw"});
Permissions.AddPermissionPropagationPath(/* ChangeMapMarkerClusteringZoomOnClick */"0TG7lXnw1k+rLlyDJoVaqg*6pYZRFxDBUuiPXQZhX5bqQ", new String[] { 
/*ChangeMapProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*6TD2xAs9QESk6ypercnO3A"});
Permissions.AddPermissionPropagationPath(/* ChangeMapApiKey */"0TG7lXnw1k+rLlyDJoVaqg*re_vRH0QtUGhpKABCuWbFQ", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* ChangeMapAutoZoomOnShape */"0TG7lXnw1k+rLlyDJoVaqg*_h_ERvX_2UufYoLSBGJKGg", new String[] { 
/*ChangeMapProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*6TD2xAs9QESk6ypercnO3A"});
Permissions.AddPermissionPropagationPath(/* ChangeHeatmapLayerDissipateOnZoom */"0TG7lXnw1k+rLlyDJoVaqg*eN0ZRwbc+Uu+Ajze6sGktA", new String[] { 
/*ChangeHeatmapLayerProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*EJeGmyixh0iYGGbqWxr1fA"});
Permissions.AddPermissionPropagationPath(/* RemoveAllMarkers */"0TG7lXnw1k+rLlyDJoVaqg*3fEcSG5grUq0+lRifVRvNw", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeToolStrokeWeight */"0TG7lXnw1k+rLlyDJoVaqg*TeMFSSDAYkuwRPsWoB9nQQ", new String[] { 
/*ChangeToolProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*oMhz7tZegkuKx0FbBAuG+w"});
Permissions.AddPermissionPropagationPath(/* ChangeHeatmapLayerMaxIntensity */"0TG7lXnw1k+rLlyDJoVaqg*yBqfSXn1+U6xpQd1IyZ_CA", new String[] { 
/*ChangeHeatmapLayerProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*emD_stx_b0m1gQz+yP7CSw"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerIconUrl */"0TG7lXnw1k+rLlyDJoVaqg*brCkSuFrKU+9dRXVEfIGOg", new String[] { 
/*ChangeMarkerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*zD6EVrcn5Umqvm_6TwYslg"});
Permissions.AddPermissionPropagationPath(/* RemoveDirections */"0TG7lXnw1k+rLlyDJoVaqg*3yLOS7ZmM0eIrzwojJyE8g", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMapShowTraffic */"0TG7lXnw1k+rLlyDJoVaqg*aldeTur5bU2aed7Vly8XmA", new String[] { 
/*ChangeMapProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*6TD2xAs9QESk6ypercnO3A"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkers */"0TG7lXnw1k+rLlyDJoVaqg*ajlkTvFzK0C5lvyg6DHkYg", new String[] { 
/*RemoveAllMarkers*/"0TG7lXnw1k+rLlyDJoVaqg*3fEcSG5grUq0+lRifVRvNw", 
/*CreateMarker*/"0TG7lXnw1k+rLlyDJoVaqg*w8en7rvyOEirTmksRY2OeA"});
Permissions.AddPermissionPropagationPath(/* ChangeToolFillColor */"0TG7lXnw1k+rLlyDJoVaqg*ima0VCj2hU+FhW9gFLa51A", new String[] { 
/*ChangeToolProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*t7zTjtuQ00CxewT5k_NYBQ"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeRadius */"0TG7lXnw1k+rLlyDJoVaqg*nowOVcrfy0a6DgR1bgTHDw", new String[] { 
/*ChangeShapeProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*O7UooPvU5U6bnRLd0PhOFg"});
Permissions.AddPermissionPropagationPath(/* ChangeMapMarkerClusteringActive */"0TG7lXnw1k+rLlyDJoVaqg*Fr2EWdLyY0iWovgNDUd10A", new String[] { 
/*ChangeMapProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*6TD2xAs9QESk6ypercnO3A"});
Permissions.AddPermissionPropagationPath(/* ChangeFileLayerLayerURL */"0TG7lXnw1k+rLlyDJoVaqg*TL8VZZx7SE69lz9wPejUqA", new String[] { 
/*ChangeFileLayerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*dH1JpbVJ+0OHPUqQq6IDig"});
Permissions.AddPermissionPropagationPath(/* SetDirections */"0TG7lXnw1k+rLlyDJoVaqg*ukt+akS9zEGJNU77DWGKnw", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ContainsLocation */"0TG7lXnw1k+rLlyDJoVaqg*7T2da8IJEkeygBhDbz0l5g", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMapZoom */"0TG7lXnw1k+rLlyDJoVaqg*r9cgeghgkECgMG_YdzhGLw", new String[] { 
/*ChangeMapProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*3akU50Vqo0yvHgOI1Hvvpg"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerLocation */"0TG7lXnw1k+rLlyDJoVaqg*_kpbfPKDpEGZYyC5cTERbA", new String[] { 
/*ChangeMarkerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*zD6EVrcn5Umqvm_6TwYslg"});
Permissions.AddPermissionPropagationPath(/* ChangeMapType */"0TG7lXnw1k+rLlyDJoVaqg*numlfOQiWECAYEJbdqImzQ", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* ChangeToolFillOpacity */"0TG7lXnw1k+rLlyDJoVaqg*Aye9fkIfnE+403zOAvrqpw", new String[] { 
/*ChangeToolProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*oMhz7tZegkuKx0FbBAuG+w"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerIconWidth */"0TG7lXnw1k+rLlyDJoVaqg*+xPlfyYlgUW456YAjXl5Yw", new String[] { 
/*ChangeMarkerProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*yhWZiUsTXk6WOio7eq00Ug"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeBounds */"0TG7lXnw1k+rLlyDJoVaqg*yo8dhewit0Chl3GQmbWeqQ", new String[] { 
/*ChangeShapeProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*+eqaVpmy6EasDNk1p7Vv6Q"});
Permissions.AddPermissionPropagationPath(/* ChangeSearchPlacesLocalization */"0TG7lXnw1k+rLlyDJoVaqg*DXcWhgEjq06y7jmZgMt_sw", new String[] { 
/*ChangeSearchPlacesProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*O7BxtqZ+C0yyT9Pvt+H72Q"});
Permissions.AddPermissionPropagationPath(/* LoadLeafletDirectionsPlugin */"0TG7lXnw1k+rLlyDJoVaqg*1OX7i60m+kGE_woSg1SJNw", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ", 
/*System_.RequireScript*/"uXCIR2Atc0+es3zYuZSnNw*VUaNOBzdXEyNRvQg0P4CoQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerLabel */"0TG7lXnw1k+rLlyDJoVaqg*qARHmpe2WUiWq9bqDOT9YQ", new String[] { 
/*ChangeMarkerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*zD6EVrcn5Umqvm_6TwYslg"});
Permissions.AddPermissionPropagationPath(/* ChangeSearchPlacesSearchType */"0TG7lXnw1k+rLlyDJoVaqg*skmIoBBHuUiuvVO5AtEPXQ", new String[] { 
/*ChangeSearchPlacesProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*O7BxtqZ+C0yyT9Pvt+H72Q"});
Permissions.AddPermissionPropagationPath(/* ChangeToolIconUrl */"0TG7lXnw1k+rLlyDJoVaqg*vTStqCOP8k6C6bFY39QPKQ", new String[] { 
/*ChangeToolProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*t7zTjtuQ00CxewT5k_NYBQ"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeLocations */"0TG7lXnw1k+rLlyDJoVaqg*241rqQ3XGka1R7qs3_XUjg", new String[] { 
/*ChangeShapeProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*+eqaVpmy6EasDNk1p7Vv6Q"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeStrokeWeight */"0TG7lXnw1k+rLlyDJoVaqg*FxkUrV+GWUatwvpDbIFj+w", new String[] { 
/*ChangeShapeProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*O7UooPvU5U6bnRLd0PhOFg"});
Permissions.AddPermissionPropagationPath(/* ChangeMarkerTitle */"0TG7lXnw1k+rLlyDJoVaqg*7xEis+m38kCAS9WQ1RpA5w", new String[] { 
/*ChangeMarkerProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*zD6EVrcn5Umqvm_6TwYslg"});
Permissions.AddPermissionPropagationPath(/* ChangeMapAdvancedFormat */"0TG7lXnw1k+rLlyDJoVaqg*KkgVu5YjGEu+ISJNRZWhvw", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* ChangeSearchPlacesSearchArea */"0TG7lXnw1k+rLlyDJoVaqg*yz_avGz+ZE6YrL5q2g4_aA", new String[] { 
/*ChangeSearchPlacesProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*O7BxtqZ+C0yyT9Pvt+H72Q"});
Permissions.AddPermissionPropagationPath(/* SubscribeMarkerEvent */"0TG7lXnw1k+rLlyDJoVaqg*5tcivfzVzUCAvhGVHdNB5Q", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeSearchPlacesApiKey */"0TG7lXnw1k+rLlyDJoVaqg*boMCvgHkxE2gSVw7_2sHwg", new String[] { 
/*ChangeSearchPlacesProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*O7BxtqZ+C0yyT9Pvt+H72Q"});
Permissions.AddPermissionPropagationPath(/* ChangeMapRespectUserZoom */"0TG7lXnw1k+rLlyDJoVaqg*+1y5xfyciEy5idMcZ6frOw", new String[] { 
/*ChangeMapProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*6TD2xAs9QESk6ypercnO3A"});
Permissions.AddPermissionPropagationPath(/* ChangeMapMarkerClusteringMaxZoom */"0TG7lXnw1k+rLlyDJoVaqg*3Vycx_cgeka088ZpogT3iA", new String[] { 
/*ChangeMapProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*3akU50Vqo0yvHgOI1Hvvpg"});
Permissions.AddPermissionPropagationPath(/* ChangeToolAllowEdit */"0TG7lXnw1k+rLlyDJoVaqg*pFWjyG1VqEa6uB3b+cth5g", new String[] { 
/*ChangeToolProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*oFMEhuJoNEWH4hFXP0eF8Q"});
Permissions.AddPermissionPropagationPath(/* UnsubscribeMarkerEvent */"0TG7lXnw1k+rLlyDJoVaqg*7VRZyqtlH0eVg_AXo4wCqg", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeDrawingToolsPosition */"0TG7lXnw1k+rLlyDJoVaqg*5V1Q0YJSU0KtwVSmcrkFKg", new String[] { 
/*ChangeDrawingToolsProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*YJ+GJ0FATUi9kS7rOWMMeA"});
Permissions.AddPermissionPropagationPath(/* ChangeFileLayerSuppressPopups */"0TG7lXnw1k+rLlyDJoVaqg*KsxK0u82XEKJKhM7DYZ_zw", new String[] { 
/*ChangeFileLayerProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*Ddxoy9U5w0+GbO05_pvTIw"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeAllowEdit */"0TG7lXnw1k+rLlyDJoVaqg*4Yx0037XC02E0i_CVZmRGg", new String[] { 
/*ChangeShapeProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*jZTb3NItn0W6rKSMONIcWw"});
Permissions.AddPermissionPropagationPath(/* ChangeToolStrokeOpacity */"0TG7lXnw1k+rLlyDJoVaqg*Oedb1DSViEq3KbYKKZHvzg", new String[] { 
/*ChangeToolProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*oMhz7tZegkuKx0FbBAuG+w"});
Permissions.AddPermissionPropagationPath(/* ChangeShapeStrokeColor */"0TG7lXnw1k+rLlyDJoVaqg*yCiT2qwRl0ipYuzgDs1DFg", new String[] { 
/*ChangeShapeProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*+eqaVpmy6EasDNk1p7Vv6Q"});
Permissions.AddPermissionPropagationPath(/* ChangeMapOffset */"0TG7lXnw1k+rLlyDJoVaqg*90GM4m8oWEWE6oo54l+U6Q", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* GetMapCenter */"0TG7lXnw1k+rLlyDJoVaqg*fkDt45YoY02rlEcGMnth6A", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMapLocalization */"0TG7lXnw1k+rLlyDJoVaqg*3K8l6VFFsUK1nDA0bcMXfg", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* ChangeToolAllowDrag */"0TG7lXnw1k+rLlyDJoVaqg*ADFT6cMHTkSMaapqOFbluw", new String[] { 
/*ChangeToolProperty_Boolean*/"0TG7lXnw1k+rLlyDJoVaqg*oFMEhuJoNEWH4hFXP0eF8Q"});
Permissions.AddPermissionPropagationPath(/* CreateMarker */"0TG7lXnw1k+rLlyDJoVaqg*w8en7rvyOEirTmksRY2OeA", new String[] { 
/*GenerateUniqueId*/"0TG7lXnw1k+rLlyDJoVaqg*SdviJ86NeUiPf3xGcptBrg"});
Permissions.AddPermissionPropagationPath(/* LogEvent */"0TG7lXnw1k+rLlyDJoVaqg*ah7o9bgR1E6MEo7Wp_Nj1A", new String[] { 
/*SetLogVerbosity*/"0TG7lXnw1k+rLlyDJoVaqg*EsQSU3F8oUq8I8nXDzRzvA"});
Permissions.AddPermissionPropagationPath(/* AddMarker */"0TG7lXnw1k+rLlyDJoVaqg*_olQ+ThIj0i06huGH3ykLA", new String[] { 
/*GetMapErrorByMapErrorCode*/"0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ"});
Permissions.AddPermissionPropagationPath(/* ChangeMapLocation */"0TG7lXnw1k+rLlyDJoVaqg*efqT+sEXEUmu3HCDqG4SPQ", new String[] { 
/*ChangeMapProperty_Text*/"0TG7lXnw1k+rLlyDJoVaqg*cvpGVcb6G027GfA9MrH8Bw"});
Permissions.AddPermissionPropagationPath(/* ChangeMapMarkerClusteringMinClusterSize */"0TG7lXnw1k+rLlyDJoVaqg*e8Vv_d3FoU2aZosIxlSGdg", new String[] { 
/*ChangeMapProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*3akU50Vqo0yvHgOI1Hvvpg"});
Permissions.AddPermissionPropagationPath(/* ChangeHeatmapLayerOpacity */"0TG7lXnw1k+rLlyDJoVaqg*XS9Q_wJXiE2jDPfdY4qVWg", new String[] { 
/*ChangeHeatmapLayerProperty_Number*/"0TG7lXnw1k+rLlyDJoVaqg*emD_stx_b0m1gQz+yP7CSw"});

    }

    public OutSystemsMaps_Controller(
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

[HttpPost]
[Route("ActionGetMapErrorByMapErrorCode")]
[RESTScreenServicesActionProperties(Name="GetMapErrorByMapErrorCode",Screen="OutSystemsMaps",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetMapErrorByMapErrorCode(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AKO00eFUq17OMeJdpb1KGw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        OutSystemsMaps_ActionGetMapErrorByMapErrorCode_Model inputs = null;
Actions.lcoGetMapErrorByMapErrorCode res =  new Actions.lcoGetMapErrorByMapErrorCode();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, "0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ", out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), "0TG7lXnw1k+rLlyDJoVaqg*ltkOCYLSHU+XcBFVlu40LQ", out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMessage = await Actions.ActionGetMapErrorByMapErrorCode(requestContext,inputs.inParamMapErrorCode,cancellationToken);

var output = RESTOutSystemsMaps_ActionGetMapErrorByMapErrorCode_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}
}
