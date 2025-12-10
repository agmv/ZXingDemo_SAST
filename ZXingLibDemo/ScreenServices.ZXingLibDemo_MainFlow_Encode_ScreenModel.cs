using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_MainFlow_Encode_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_MainFlow_Encode_ScreenModel).Namespace);

    public string varLcFilename;
public string varLcBarcodeFormat;
public string varLcValue;
public int varLcWidth;
public int varLcHeight;
public byte[] varLcOverlayImage;
public bool varLcIsPureBarcode;
public bool varLcUseGS1Format;
public int varLcQRCodeVersion;
public int varLcMargin;
public bool varLcNoPadding;
public string varLcEncoding;
public string varLcErrorCorrection;
public string varLcForceShape;
public ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model varLcGetBarcodeDefaults;
public ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model varLcGetCodes;
public ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model varLcEncodeBarcodeImage;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_MainFlow_Encode_ScreenModel() {
}



    public ZXingLibDemo_MainFlow_Encode_ScreenModel(string varLcFilename, string varLcBarcodeFormat, string varLcValue, int varLcWidth, int varLcHeight, byte[] varLcOverlayImage, bool varLcIsPureBarcode, bool varLcUseGS1Format, int varLcQRCodeVersion, int varLcMargin, bool varLcNoPadding, string varLcEncoding, string varLcErrorCorrection, string varLcForceShape, ZXingLibDemo_MainFlow_Encode_DataActionGetBarcodeDefaults_Model varLcGetBarcodeDefaults, ZXingLibDemo_MainFlow_Encode_DataActionGetCodes_Model varLcGetCodes, ZXingLibDemo_MainFlow_Encode_DataActionEncodeBarcodeImage_Model varLcEncodeBarcodeImage, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"Filename", "BarcodeFormat", "Value", "Width", "Height", "OverlayImage", "IsPureBarcode", "UseGS1Format", "QRCodeVersion", "Margin", "NoPadding", "Encoding", "ErrorCorrection", "ForceShape", "GetBarcodeDefaults", "GetCodes", "EncodeBarcodeImage", "ClientVars"}, new string[] {"varLcFilename", "varLcBarcodeFormat", "varLcValue", "varLcWidth", "varLcHeight", "varLcOverlayImage", "varLcIsPureBarcode", "varLcUseGS1Format", "varLcQRCodeVersion", "varLcMargin", "varLcNoPadding", "varLcEncoding", "varLcErrorCorrection", "varLcForceShape", "varLcGetBarcodeDefaults", "varLcGetCodes", "varLcEncodeBarcodeImage", "clientVariables"});
this.varLcFilename = varLcFilename;
this.varLcBarcodeFormat = varLcBarcodeFormat;
this.varLcValue = varLcValue;
this.varLcWidth = varLcWidth;
this.varLcHeight = varLcHeight;
this.varLcOverlayImage = varLcOverlayImage;
this.varLcIsPureBarcode = varLcIsPureBarcode;
this.varLcUseGS1Format = varLcUseGS1Format;
this.varLcQRCodeVersion = varLcQRCodeVersion;
this.varLcMargin = varLcMargin;
this.varLcNoPadding = varLcNoPadding;
this.varLcEncoding = varLcEncoding;
this.varLcErrorCorrection = varLcErrorCorrection;
this.varLcForceShape = varLcForceShape;
this.varLcGetBarcodeDefaults = varLcGetBarcodeDefaults;
this.varLcGetCodes = varLcGetCodes;
this.varLcEncodeBarcodeImage = varLcEncodeBarcodeImage;
this.clientVariables = clientVariables;
}



    

    public class lcvGetBarcodeDefaults : VarsBag {
public RL_389ebe1f107310cdc9de4af24cd413c4 queryResGetCodeByLabel_outParamList = new RL_389ebe1f107310cdc9de4af24cd413c4();
public long queryResGetCodeByLabel_outParamCount = 0L;

public lcvGetBarcodeDefaults() {
}
}
public class lcoGetBarcodeDefaults : VarsBag {
public EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord outParamCode = new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord();

public lcoGetBarcodeDefaults() {
}
}
/// <summary>
/// Action <code>GetBarcodeDefaults</code> that represents the Service Studio action
///  <code>GetBarcodeDefaults</code> <p> Description: </p>
/// </summary>
public async Task<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> DataActionGetBarcodeDefaults(IRequestContext requestContext,CancellationToken cancellationToken) {
EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord outParamCode = default;
lcoGetBarcodeDefaults result = new lcoGetBarcodeDefaults();
lcvGetBarcodeDefaults localVars = new lcvGetBarcodeDefaults();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_Encode_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("Encode", "GetBarcodeDefaults")){
// Query datasetGetCodeByLabel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCodeByLabel_maxRecords = 0;
int datasetGetCodeByLabel_startIndex = 0;(localVars.queryResGetCodeByLabel_outParamList,localVars.queryResGetCodeByLabel_outParamCount) = await FuncDataActionGetBarcodeDefaults.datasetGetCodeByLabel(requestContext,datasetGetCodeByLabel_maxRecords,datasetGetCodeByLabel_startIndex,IterationMultiplicity.Never,varLcBarcodeFormat,cancellationToken);

// Set Code
// Code = GetCodeByLabel.List.Current
result.outParamCode=(((EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord)localVars.queryResGetCodeByLabel_outParamList.CurrentRec));
} //close CreateActionActivity using block
} //try

finally {
outParamCode = result.outParamCode;
}
RETURN_STATEMENT:
return outParamCode;
}
public class lcvGetCodes : VarsBag {
public BasicTypeList<string> resEncoders_outParamFormats = new BasicTypeList<string>();

public lcvGetCodes() {
}
}
public class lcoGetCodes : VarsBag {
public BasicTypeList<string> outParamFormats = new BasicTypeList<string>();

public lcoGetCodes() {
}
}
/// <summary>
/// Action <code>GetCodes</code> that represents the Service Studio action <code>GetCodes</code> <p>
///  Description: </p>
/// </summary>
public async Task<BasicTypeList<string>> DataActionGetCodes(IRequestContext requestContext,CancellationToken cancellationToken) {
BasicTypeList<string> outParamFormats = default;
lcoGetCodes result = new lcoGetCodes();
lcvGetCodes localVars = new lcvGetCodes();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_Encode_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("Encode", "GetCodes")){
// Encoders
localVars.resEncoders_outParamFormats = await Actions.ActionEncoders(requestContext,cancellationToken);

// Formats = Encoders.Formats
result.outParamFormats=localVars.resEncoders_outParamFormats;
} //close CreateActionActivity using block
} //try

finally {
outParamFormats = result.outParamFormats;
}
RETURN_STATEMENT:
return outParamFormats;
}
public class lcvEncodeBarcodeImage : VarsBag {
public byte[] resEncode2_outParamBarcodeImage = new byte[] {};

public lcvEncodeBarcodeImage() {
}
}
public class lcoEncodeBarcodeImage : VarsBag {
public byte[] outParamImage = new byte[] {};

public lcoEncodeBarcodeImage() {
}
}
/// <summary>
/// Action <code>EncodeBarcodeImage</code> that represents the Service Studio action
///  <code>EncodeBarcodeImage</code> <p> Description: Data Action that returns the QR Code.</p>
/// </summary>
public async Task<byte[]> DataActionEncodeBarcodeImage(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamImage = default;
lcoEncodeBarcodeImage result = new lcoEncodeBarcodeImage();
lcvEncodeBarcodeImage localVars = new lcvEncodeBarcodeImage();
try {
cancellationToken.ThrowIfCancellationRequested();
ZXingLibDemo_MainFlow_Encode_ScreenModel model = this;

using (activitySource.CreateScreenDataActionActivity("Encode", "EncodeBarcodeImage")){
// Encode2
localVars.resEncode2_outParamBarcodeImage = await Actions.ActionEncode(requestContext,varLcValue,varLcBarcodeFormat,varLcWidth,varLcHeight,(((varLcMargin<0)) ? (0) : (varLcMargin)),varLcIsPureBarcode,varLcUseGS1Format,varLcNoPadding,varLcEncoding,varLcErrorCorrection,varLcQRCodeVersion,varLcOverlayImage,varLcForceShape,"PNG",cancellationToken);

// Set Image
// Image = Encode2.BarcodeImage
result.outParamImage=localVars.resEncode2_outParamBarcodeImage;
} //close CreateActionActivity using block
} //try

finally {
outParamImage = result.outParamImage;
}
RETURN_STATEMENT:
return outParamImage;
}


    public static class FuncDataActionGetBarcodeDefaults {

// Query Function "GetCodeByLabel" veEfQj7GVECzL+vngFulmQ of Action "GetBarcodeDefaults"
public static async Task<(RL_389ebe1f107310cdc9de4af24cd413c4,long)> datasetGetCodeByLabel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteLabel,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateAggregateQueryActivity("MainFlow.Encode.GetBarcodeDefaults.GetCodeByLabel", "421fe1bd-c63e-4054-b32f-ebe7805ba599", "ZXingLibDemo", "61918b7a-e496-4b63-992b-b83299b21e43");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
StringBuilder selectBuilder = new StringBuilder();
StringBuilder fromBuilder = new StringBuilder();
StringBuilder whereBuilder = new StringBuilder();
StringBuilder orderByBuilder = new StringBuilder();
StringBuilder groupByBuilder = new StringBuilder();
StringBuilder havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.fWtJs57lI0qCTlwkcDoxDA/NodesShownInESpaceTree.XlTkP0l_Ok+HdvfbxiS6Zg/DataActions.HtY7JYTTIEyScZKEa+ST5A/NodesNotShownInESpaceTree.veEfQj7GVECzL+vngFulmQ, 61918b7a-e496-4b63-992b-b83299b21e43 ZXingLibDemo */");
selectBuilder.Append("SELECT NULL o0, \"encodedefaults\".\"sample\" o1, \"encodedefaults\".\"margin\" o2, \"encodedefaults\".\"width\" o3, \"encodedefaults\".\"height\" o4");
fromBuilder.Append(" FROM {CodeDefaults} \"encodedefaults\"");
whereBuilder.Append(" WHERE (\"encodedefaults\".\"label\" = (@qpteLabel))");
sqlCmd.CreateParameterWithoutReplacements("@qpteLabel", DbType.String, qpteLabel);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_389ebe1f107310cdc9de4af24cd413c4 outParamList = new RL_389ebe1f107310cdc9de4af24cd413c4();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query MainFlow.Encode.GetBarcodeDefaults.GetCodeByLabel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_389ebe1f107310cdc9de4af24cd413c4 _tmp = new RL_389ebe1f107310cdc9de4af24cd413c4();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query MainFlow.Encode.GetBarcodeDefaults.GetCodeByLabel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_389ebe1f107310cdc9de4af24cd413c4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetCodes {
}
public static class FuncDataActionEncodeBarcodeImage {
}


}
