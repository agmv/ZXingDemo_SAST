namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionDecode</code> that represents the Service Studio reference action
///  <code>Decode</code> <p> Description: Scans barcode from an image</p>
/// </summary>
public static async Task<ST_7750e71a4e018dabac19d9f560c2b017Structure> ActionDecode(IRequestContext requestContext,byte[] inParamimage,string inParamformatHint,bool inParamdetectionImage,CancellationToken cancellationToken) {
ST_7750e71a4e018dabac19d9f560c2b017Structure outParamBarcode = default;
OutSystems.Application.Extensibility.DataTypes.IRecord proxy_Barcode;
proxy_Barcode = await RssExternalLibraryZXingLib.MssDecode(requestContext,inParamimage,inParamformatHint,inParamdetectionImage,cancellationToken);
outParamBarcode = (ST_7750e71a4e018dabac19d9f560c2b017Structure) proxy_Barcode;
return outParamBarcode;
}

}
