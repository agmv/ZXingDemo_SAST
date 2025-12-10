namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionEncoders</code> that represents the Service Studio reference action
///  <code>Encoders</code> <p> Description: Supported barcode encoding formats</p>
/// </summary>
public static async Task<BasicTypeList<string>> ActionEncoders(IRequestContext requestContext,CancellationToken cancellationToken) {
BasicTypeList<string> outParamFormats = default;
BasicTypeList<string> proxy_Formats;
proxy_Formats = await RssExternalLibraryZXingLib.MssEncoders(requestContext,cancellationToken);
outParamFormats = (BasicTypeList<string>) proxy_Formats;
return outParamFormats;
}

}
