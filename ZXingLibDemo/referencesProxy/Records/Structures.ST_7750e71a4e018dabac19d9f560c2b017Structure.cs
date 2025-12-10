namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] Barcode (t16+B4zwwkqySX8MwGhkfg)
///  <code>ST_7750e71a4e018dabac19d9f560c2b017Structure</code> that represents <code>Barcode</code
/// > <p>Description: Structure that holds decoded barcodes</p>
/// </summary>
// Name: Barcode
public partial struct ST_7750e71a4e018dabac19d9f560c2b017Structure : ITypedRecord<ST_7750e71a4e018dabac19d9f560c2b017Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey Idvalue = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*OaCc4h0prWXTqS4TixwB8Q");
internal static readonly GlobalObjectKey IdrawBytes = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*XOGChk+RNl7dLVvtBn9SLA");
internal static readonly GlobalObjectKey Idformat = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*oRsagtBCsp3OdAhK1bDvGQ");
internal static readonly GlobalObjectKey Idmetadata = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*66hm8qO511ySvwh4tm3TwA");
internal static readonly GlobalObjectKey IddetectedBarcode = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*QgaVAqFsk6TbWVLQTN8f9g");

[System.Xml.Serialization.XmlElement("value")]
public string ssvalue;

[System.Xml.Serialization.XmlElement("rawBytes")]
public byte[] ssrawBytes;

[System.Xml.Serialization.XmlElement("format")]
public string ssformat;

[System.Xml.Serialization.XmlElement("metadata")]
public RL_7919f33989696cd32796fc8e261021d2 ssmetadata;

[System.Xml.Serialization.XmlElement("detectedBarcode")]
public byte[] ssdetectedBarcode;


public BitArray OptimizedAttributes;

public ST_7750e71a4e018dabac19d9f560c2b017Structure() {
OptimizedAttributes = null;
ssvalue = "";
ssrawBytes = new byte[] {};
ssformat = "";
ssmetadata = new RL_7919f33989696cd32796fc8e261021d2();
ssdetectedBarcode = new byte[] {};
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssvalue = r.ReadText(index++, "Barcode.value", "");
ssrawBytes = r.ReadBinaryData(index++, "Barcode.rawBytes", new byte[] {});
ssformat = r.ReadText(index++, "Barcode.format", "");
ssdetectedBarcode = r.ReadBinaryData(index++, "Barcode.detectedBarcode", new byte[] {});
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_7750e71a4e018dabac19d9f560c2b017Structure r) {
this = r;
}


public static bool operator == (ST_7750e71a4e018dabac19d9f560c2b017Structure a, ST_7750e71a4e018dabac19d9f560c2b017Structure b) {
if (a.ssvalue != b.ssvalue) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssrawBytes, b.ssrawBytes)) return false;
if (a.ssformat != b.ssformat) return false;
if (a.ssmetadata != b.ssmetadata) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssdetectedBarcode, b.ssdetectedBarcode)) return false;
return true;
}

public static bool operator != (ST_7750e71a4e018dabac19d9f560c2b017Structure a, ST_7750e71a4e018dabac19d9f560c2b017Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7750e71a4e018dabac19d9f560c2b017Structure)) return false;
return (this == (ST_7750e71a4e018dabac19d9f560c2b017Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssvalue.GetHashCode()
 ^ ssrawBytes.GetHashCode()
 ^ ssformat.GetHashCode()
 ^ ssmetadata.GetHashCode()
 ^ ssdetectedBarcode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssmetadata.RecursiveReset();
}

public void InternalRecursiveSave() {
ssmetadata.InternalRecursiveSave();
}


public ST_7750e71a4e018dabac19d9f560c2b017Structure Duplicate() {
ST_7750e71a4e018dabac19d9f560c2b017Structure t;
t.ssvalue = this.ssvalue;
t.ssrawBytes = this.ssrawBytes;
t.ssformat = this.ssformat;
t.ssmetadata = (RL_7919f33989696cd32796fc8e261021d2)this.ssmetadata.Duplicate();
t.ssdetectedBarcode = this.ssdetectedBarcode;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".value")) variable.Value = ssvalue; else variable.Optimized = true;
} else if (head == "rawbytes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".rawBytes")) variable.Value = ssrawBytes; else variable.Optimized = true;
} else if (head == "format") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".format")) variable.Value = ssformat; else variable.Optimized = true;
} else if (head == "metadata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".metadata")) variable.Value = ssmetadata; else variable.Optimized = true;
variable.SetFieldName("metadata");
} else if (head == "detectedbarcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".detectedBarcode")) variable.Value = ssdetectedBarcode; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == Idvalue) {
return ssvalue;
}
if (key == IdrawBytes) {
return ssrawBytes;
}
if (key == Idformat) {
return ssformat;
}
if (key == Idmetadata) {
return ssmetadata;
}
if (key == IddetectedBarcode) {
return ssdetectedBarcode;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idvalue.Key.AsGuid) {
return ssvalue;
}
if (attributeKey == IdrawBytes.Key.AsGuid) {
return ssrawBytes;
}
if (attributeKey == Idformat.Key.AsGuid) {
return ssformat;
}
if (attributeKey == Idmetadata.Key.AsGuid) {
return ssmetadata;
}
if (attributeKey == IddetectedBarcode.Key.AsGuid) {
return ssdetectedBarcode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssvalue = (string) other.AttributeGet(Idvalue);
ssrawBytes = (byte[]) other.AttributeGet(IdrawBytes);
ssformat = (string) other.AttributeGet(Idformat);
ssmetadata = new RL_7919f33989696cd32796fc8e261021d2();
ssmetadata.FillFromOther((IOSList) other.AttributeGet(Idmetadata));
ssdetectedBarcode = (byte[]) other.AttributeGet(IddetectedBarcode);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssvalue = (string) other.GetAttribute(Idvalue.Key.AsGuid);
ssrawBytes = (byte[]) other.GetAttribute(IdrawBytes.Key.AsGuid);
ssformat = (string) other.GetAttribute(Idformat.Key.AsGuid);
ssmetadata = new RL_7919f33989696cd32796fc8e261021d2();
ssmetadata.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecordList) other.GetAttribute(Idmetadata.Key.AsGuid));
ssdetectedBarcode = (byte[]) other.GetAttribute(IddetectedBarcode.Key.AsGuid);
}
} // ST_7750e71a4e018dabac19d9f560c2b017Structure
/// <summary>
/// RecordList type <code>BarcodeList</code> that represents a record list of <code>Barcode</code>
/// </summary>
public partial class RL_8fdc1c2bcc6f385410bdb8a93bd26489 : GenericRecordList<ST_7750e71a4e018dabac19d9f560c2b017Structure>, IEnumerable, IEnumerator , OutSystems.Application.Extensibility.DataTypes.IRecordList {

public IEnumerable<OutSystems.Application.Extensibility.DataTypes.IRecord> GetRecords() {
    return _data.Cast<OutSystems.Application.Extensibility.DataTypes.IRecord>();
}

public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecordList other) {
    foreach (var element in other.GetRecords()) {
        var convertedElement = new ST_7750e71a4e018dabac19d9f560c2b017Structure();
        convertedElement.CopyFrom(element);
        Append(convertedElement);
    }
}


protected override ST_7750e71a4e018dabac19d9f560c2b017Structure GetElementDefaultValue() {
return new ST_7750e71a4e018dabac19d9f560c2b017Structure();
}

public T[] ToArray<T>(Func<ST_7750e71a4e018dabac19d9f560c2b017Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8fdc1c2bcc6f385410bdb8a93bd26489 recordList, Func<ST_7750e71a4e018dabac19d9f560c2b017Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8fdc1c2bcc6f385410bdb8a93bd26489(ST_7750e71a4e018dabac19d9f560c2b017Structure[] array) {
  RL_8fdc1c2bcc6f385410bdb8a93bd26489 result = new RL_8fdc1c2bcc6f385410bdb8a93bd26489();
result.InnerFromArray(array);
    return result;
}

public static RL_8fdc1c2bcc6f385410bdb8a93bd26489 ToList<T>(T[] array, Func <T, ST_7750e71a4e018dabac19d9f560c2b017Structure> converter) {
  RL_8fdc1c2bcc6f385410bdb8a93bd26489 result = new RL_8fdc1c2bcc6f385410bdb8a93bd26489();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8fdc1c2bcc6f385410bdb8a93bd26489 FromRestList<T>(RestList<T> restList, Func <T, ST_7750e71a4e018dabac19d9f560c2b017Structure> converter) {
  RL_8fdc1c2bcc6f385410bdb8a93bd26489 result = new RL_8fdc1c2bcc6f385410bdb8a93bd26489();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8fdc1c2bcc6f385410bdb8a93bd26489() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7750e71a4e018dabac19d9f560c2b017Structure> NewList() {
return new RL_8fdc1c2bcc6f385410bdb8a93bd26489();
}


} // RL_8fdc1c2bcc6f385410bdb8a93bd26489
}

