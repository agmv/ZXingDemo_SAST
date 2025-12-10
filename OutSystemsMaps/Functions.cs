namespace ssOutSystemsMaps;
public class Functions {
/// <summary>
/// Function <code>GetGoogleMapsServerKey</code> that represents the Service Studio function
///  <code>GetGoogleMapsServerKey</code> <p> Description: Returns the Google Maps API key setup for thi
/// s component.</p>
/// </summary>

public static async Task<string> ActionGetGoogleMapsServerKey(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamKey;
outParamKey = await Actions.ActionGetGoogleMapsServerKey(requestContext,cancellationToken);

return outParamKey;
}

/// <summary>
/// Function <code>GetLogType</code> that represents the Service Studio function
///  <code>GetLogType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6633adb48f346ff9147637b286666408> ssGetLogType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_6633adb48f346ff9147637b286666408.EnsureInitialized();
RC_6633adb48f346ff9147637b286666408 outParamRecord;
outParamRecord = await ExtendedActions.GetLogType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMapErrors</code> that represents the Service Studio function
///  <code>GetMapErrors</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3d151c63adf137bd3c85eaa462bbbe0c> ssGetMapErrors(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3d151c63adf137bd3c85eaa462bbbe0c.EnsureInitialized();
RC_3d151c63adf137bd3c85eaa462bbbe0c outParamRecord;
outParamRecord = await ExtendedActions.GetMapErrors(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDrawingToolType</code> that represents the Service Studio function
///  <code>GetDrawingToolType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e2e4078a68f051b01b0e49ed4f3f6e07> ssGetDrawingToolType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e2e4078a68f051b01b0e49ed4f3f6e07.EnsureInitialized();
RC_e2e4078a68f051b01b0e49ed4f3f6e07 outParamRecord;
outParamRecord = await ExtendedActions.GetDrawingToolType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetShapeType</code> that represents the Service Studio function
///  <code>GetShapeType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3201d1384957542debf3cb5808f51144> ssGetShapeType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3201d1384957542debf3cb5808f51144.EnsureInitialized();
RC_3201d1384957542debf3cb5808f51144 outParamRecord;
outParamRecord = await ExtendedActions.GetShapeType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDirectionsProvider</code> that represents the Service Studio function
///  <code>GetDirectionsProvider</code> <p> Description: </p>
/// </summary>

public static async Task<RC_9c493adade9ae0a5806b7a20eb12f1e0> ssGetDirectionsProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_9c493adade9ae0a5806b7a20eb12f1e0.EnsureInitialized();
RC_9c493adade9ae0a5806b7a20eb12f1e0 outParamRecord;
outParamRecord = await ExtendedActions.GetDirectionsProvider(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPopupEvent</code> that represents the Service Studio function
///  <code>GetPopupEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_b426a0d7aa8f7cff1977eb04da864b0f> ssGetPopupEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b426a0d7aa8f7cff1977eb04da864b0f.EnsureInitialized();
RC_b426a0d7aa8f7cff1977eb04da864b0f outParamRecord;
outParamRecord = await ExtendedActions.GetPopupEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDrawingToolsEventTriggered</code> that represents the Service Studio function
///  <code>GetDrawingToolsEventTriggered</code> <p> Description: </p>
/// </summary>

public static async Task<RC_499511b992975daa9639159d76f69e74> ssGetDrawingToolsEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_499511b992975daa9639159d76f69e74.EnsureInitialized();
RC_499511b992975daa9639159d76f69e74 outParamRecord;
outParamRecord = await ExtendedActions.GetDrawingToolsEventTriggered(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetType</code> that represents the Service Studio function <code>GetType</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_b32e755d03dd085a4b975b8c0c7d4454> ssGetType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_b32e755d03dd085a4b975b8c0c7d4454.EnsureInitialized();
RC_b32e755d03dd085a4b975b8c0c7d4454 outParamRecord;
outParamRecord = await ExtendedActions.GetType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSearchPlacesEvent</code> that represents the Service Studio function
///  <code>GetSearchPlacesEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f1764d7c40e4f0543f1781c01f8cbcf5> ssGetSearchPlacesEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_f1764d7c40e4f0543f1781c01f8cbcf5.EnsureInitialized();
RC_f1764d7c40e4f0543f1781c01f8cbcf5 outParamRecord;
outParamRecord = await ExtendedActions.GetSearchPlacesEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetShapeEvent</code> that represents the Service Studio function
///  <code>GetShapeEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_edb1f7bb91ddbc761736a4f9fe9ed955> ssGetShapeEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_edb1f7bb91ddbc761736a4f9fe9ed955.EnsureInitialized();
RC_edb1f7bb91ddbc761736a4f9fe9ed955 outParamRecord;
outParamRecord = await ExtendedActions.GetShapeEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMarkerType</code> that represents the Service Studio function
///  <code>GetMarkerType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_0b102c453446be3ebcb793be90d6b209> ssGetMarkerType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0b102c453446be3ebcb793be90d6b209.EnsureInitialized();
RC_0b102c453446be3ebcb793be90d6b209 outParamRecord;
outParamRecord = await ExtendedActions.GetMarkerType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSearchPlacesErrors</code> that represents the Service Studio function
///  <code>GetSearchPlacesErrors</code> <p> Description: </p>
/// </summary>

public static async Task<RC_28b5debce9c04e64c6dd40275449bf6c> ssGetSearchPlacesErrors(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_28b5debce9c04e64c6dd40275449bf6c.EnsureInitialized();
RC_28b5debce9c04e64c6dd40275449bf6c outParamRecord;
outParamRecord = await ExtendedActions.GetSearchPlacesErrors(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMapEvent</code> that represents the Service Studio function
///  <code>GetMapEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_227974ef92f7b64b18b95570fef9abe3> ssGetMapEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_227974ef92f7b64b18b95570fef9abe3.EnsureInitialized();
RC_227974ef92f7b64b18b95570fef9abe3 outParamRecord;
outParamRecord = await ExtendedActions.GetMapEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMapEventTriggered</code> that represents the Service Studio function
///  <code>GetMapEventTriggered</code> <p> Description: </p>
/// </summary>

public static async Task<RC_bf75694d8016688134fa555a2fd4f5d7> ssGetMapEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_bf75694d8016688134fa555a2fd4f5d7.EnsureInitialized();
RC_bf75694d8016688134fa555a2fd4f5d7 outParamRecord;
outParamRecord = await ExtendedActions.GetMapEventTriggered(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSearchTypes</code> that represents the Service Studio function
///  <code>GetSearchTypes</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d186ae1becb56f86c126b4768e3f70d2> ssGetSearchTypes(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_d186ae1becb56f86c126b4768e3f70d2.EnsureInitialized();
RC_d186ae1becb56f86c126b4768e3f70d2 outParamRecord;
outParamRecord = await ExtendedActions.GetSearchTypes(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMarkerEvent</code> that represents the Service Studio function
///  <code>GetMarkerEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2d18bab1b72b271dc15dda249e871290> ssGetMarkerEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_2d18bab1b72b271dc15dda249e871290.EnsureInitialized();
RC_2d18bab1b72b271dc15dda249e871290 outParamRecord;
outParamRecord = await ExtendedActions.GetMarkerEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProvider</code> that represents the Service Studio function
///  <code>GetProvider</code> <p> Description: </p>
/// </summary>

public static async Task<RC_21369035d43ec8805ca548830e8c3c98> ssGetProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_21369035d43ec8805ca548830e8c3c98.EnsureInitialized();
RC_21369035d43ec8805ca548830e8c3c98 outParamRecord;
outParamRecord = await ExtendedActions.GetProvider(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDrawingToolsPosition</code> that represents the Service Studio function
///  <code>GetDrawingToolsPosition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c52fa927f09489f1c90f3a0526a1c8c9> ssGetDrawingToolsPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_c52fa927f09489f1c90f3a0526a1c8c9.EnsureInitialized();
RC_c52fa927f09489f1c90f3a0526a1c8c9 outParamRecord;
outParamRecord = await ExtendedActions.GetDrawingToolsPosition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetStyle</code> that represents the Service Studio function <code>GetStyle</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_97843bcb52146db1681dfc816cff70a0> ssGetStyle(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_97843bcb52146db1681dfc816cff70a0.EnsureInitialized();
RC_97843bcb52146db1681dfc816cff70a0 outParamRecord;
outParamRecord = await ExtendedActions.GetStyle(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFileLayerEvent</code> that represents the Service Studio function
///  <code>GetFileLayerEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_dc7b093401bf134dc8399c003cfc6bc0> ssGetFileLayerEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_dc7b093401bf134dc8399c003cfc6bc0.EnsureInitialized();
RC_dc7b093401bf134dc8399c003cfc6bc0 outParamRecord;
outParamRecord = await ExtendedActions.GetFileLayerEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMarkerEventTriggered</code> that represents the Service Studio function
///  <code>GetMarkerEventTriggered</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d18425d8035234c443ecbdefa0da8210> ssGetMarkerEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_d18425d8035234c443ecbdefa0da8210.EnsureInitialized();
RC_d18425d8035234c443ecbdefa0da8210 outParamRecord;
outParamRecord = await ExtendedActions.GetMarkerEventTriggered(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMapType</code> that represents the Service Studio function
///  <code>GetMapType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_992836b5ddde04d0d91f0c87e7233524> ssGetMapType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_992836b5ddde04d0d91f0c87e7233524.EnsureInitialized();
RC_992836b5ddde04d0d91f0c87e7233524 outParamRecord;
outParamRecord = await ExtendedActions.GetMapType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetZoom</code> that represents the Service Studio function <code>GetZoom</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_80e81fddca0089d3f29f81106c0bee34> ssGetZoom(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_80e81fddca0089d3f29f81106c0bee34.EnsureInitialized();
RC_80e81fddca0089d3f29f81106c0bee34 outParamRecord;
outParamRecord = await ExtendedActions.GetZoom(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetVerbosity</code> that represents the Service Studio function
///  <code>GetVerbosity</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a9d171af5978fe3e4b7ef9f38c0c5a39> ssGetVerbosity(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a9d171af5978fe3e4b7ef9f38c0c5a39.EnsureInitialized();
RC_a9d171af5978fe3e4b7ef9f38c0c5a39 outParamRecord;
outParamRecord = await ExtendedActions.GetVerbosity(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDrawingToolsEvent</code> that represents the Service Studio function
///  <code>GetDrawingToolsEvent</code> <p> Description: </p>
/// </summary>

public static async Task<RC_499414721b608cf3d3b8f99fae961f52> ssGetDrawingToolsEvent(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_499414721b608cf3d3b8f99fae961f52.EnsureInitialized();
RC_499414721b608cf3d3b8f99fae961f52 outParamRecord;
outParamRecord = await ExtendedActions.GetDrawingToolsEvent(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetShapeEventTriggered</code> that represents the Service Studio function
///  <code>GetShapeEventTriggered</code> <p> Description: </p>
/// </summary>

public static async Task<RC_098c46906c1c0c7e7b39f1210fb64f78> ssGetShapeEventTriggered(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_098c46906c1c0c7e7b39f1210fb64f78.EnsureInitialized();
RC_098c46906c1c0c7e7b39f1210fb64f78 outParamRecord;
outParamRecord = await ExtendedActions.GetShapeEventTriggered(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetTravelMode</code> that represents the Service Studio function
///  <code>GetTravelMode</code> <p> Description: </p>
/// </summary>

public static async Task<RC_fd916ed3e439afbf2b3a8036c2de75ba> ssGetTravelMode(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_fd916ed3e439afbf2b3a8036c2de75ba.EnsureInitialized();
RC_fd916ed3e439afbf2b3a8036c2de75ba outParamRecord;
outParamRecord = await ExtendedActions.GetTravelMode(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

}
