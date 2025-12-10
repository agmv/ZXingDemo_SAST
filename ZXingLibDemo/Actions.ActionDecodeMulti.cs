namespace ssZXingLibDemo;

public partial class Actions {
/// <summary>
/// Action <code>ActionDecodeMulti</code> that represents the Service Studio reference action
///  <code>DecodeMulti</code> <p> Description: Scans barcode from an image</p>
/// </summary>
public static async Task<RL_8fdc1c2bcc6f385410bdb8a93bd26489> ActionDecodeMulti(IRequestContext requestContext,byte[] inParamimage,string inParamformatHint,bool inParamdetectionImage,CancellationToken cancellationToken) {
RL_8fdc1c2bcc6f385410bdb8a93bd26489 outParamBarcodes = default;
OutSystems.Application.Extensibility.DataTypes.IRecordList proxy_Barcodes;
proxy_Barcodes = await RssExternalLibraryZXingLib.MssDecodeMulti(requestContext,inParamimage,inParamformatHint,inParamdetectionImage,cancellationToken);
outParamBarcodes = (RL_8fdc1c2bcc6f385410bdb8a93bd26489) proxy_Barcodes;
return outParamBarcodes;
}

}
