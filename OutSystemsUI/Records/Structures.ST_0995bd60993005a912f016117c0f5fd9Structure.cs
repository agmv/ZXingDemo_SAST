namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ProviderEventReturnMessage (W7o2Ugd2sU+kzjxd98zNaw)
///  <code>ST_0995bd60993005a912f016117c0f5fd9Structure</code> that represent
/// s <code>ProviderEventReturnMessage</code> <p>Description: Returning structures from actions.</p>
/// </summary>
// Name: ProviderEventReturnMessage
public partial struct ST_0995bd60993005a912f016117c0f5fd9Structure : ITypedRecord<ST_0995bd60993005a912f016117c0f5fd9Structure> {
internal static readonly GlobalObjectKey IdProviderEventId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*hdD_guFVfUqldTUMywRN+Q");
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*HWhdSLmpd0m6Bd29MrtXAQ");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*aU63d0HWe0yH3ufv4p3Rkw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*9fjIgc27nkKysog+RUXoMg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProviderEventId")]
public string ssProviderEventId;

[System.Xml.Serialization.XmlElement("IsSuccess")]
public bool ssIsSuccess;

[System.Xml.Serialization.XmlElement("Code")]
public string ssCode;

[System.Xml.Serialization.XmlElement("Message")]
public string ssMessage;


public BitArray OptimizedAttributes;

public ST_0995bd60993005a912f016117c0f5fd9Structure() {
OptimizedAttributes = null;
ssProviderEventId = "";
ssIsSuccess = false;
ssCode = "";
ssMessage = "";
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
ssProviderEventId = r.ReadText(index++, "ProviderEventReturnMessage.ProviderEventId", "");
ssIsSuccess = r.ReadBoolean(index++, "ProviderEventReturnMessage.IsSuccess", false);
ssCode = r.ReadText(index++, "ProviderEventReturnMessage.Code", "");
ssMessage = r.ReadText(index++, "ProviderEventReturnMessage.Message", "");
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
public void ReadIM(ST_0995bd60993005a912f016117c0f5fd9Structure r) {
this = r;
}


public static bool operator == (ST_0995bd60993005a912f016117c0f5fd9Structure a, ST_0995bd60993005a912f016117c0f5fd9Structure b) {
if (a.ssProviderEventId != b.ssProviderEventId) return false;
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_0995bd60993005a912f016117c0f5fd9Structure a, ST_0995bd60993005a912f016117c0f5fd9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0995bd60993005a912f016117c0f5fd9Structure)) return false;
return (this == (ST_0995bd60993005a912f016117c0f5fd9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProviderEventId.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_0995bd60993005a912f016117c0f5fd9Structure Duplicate() {
ST_0995bd60993005a912f016117c0f5fd9Structure t;
t.ssProviderEventId = this.ssProviderEventId;
t.ssIsSuccess = this.ssIsSuccess;
t.ssCode = this.ssCode;
t.ssMessage = this.ssMessage;
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
if (head == "providereventid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProviderEventId")) variable.Value = ssProviderEventId; else variable.Optimized = true;
} else if (head == "issuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSuccess")) variable.Value = ssIsSuccess; else variable.Optimized = true;
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
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
if (key == IdProviderEventId) {
return ssProviderEventId;
}
if (key == IdIsSuccess) {
return ssIsSuccess;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProviderEventId.Key.AsGuid) {
return ssProviderEventId;
}
if (attributeKey == IdIsSuccess.Key.AsGuid) {
return ssIsSuccess;
}
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssProviderEventId = (string) other.AttributeGet(IdProviderEventId);
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssCode = (string) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_0995bd60993005a912f016117c0f5fd9Structure
/// <summary>
/// RecordList type <code>ProviderEventReturnMessageList</code> that represents a record list of
///  <code>ProviderEventReturnMessage</code>
/// </summary>
public partial class RL_7ab705bfa7ab8be3383dd7312431c92b : GenericRecordList<ST_0995bd60993005a912f016117c0f5fd9Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_0995bd60993005a912f016117c0f5fd9Structure GetElementDefaultValue() {
return new ST_0995bd60993005a912f016117c0f5fd9Structure();
}

public T[] ToArray<T>(Func<ST_0995bd60993005a912f016117c0f5fd9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7ab705bfa7ab8be3383dd7312431c92b recordList, Func<ST_0995bd60993005a912f016117c0f5fd9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7ab705bfa7ab8be3383dd7312431c92b(ST_0995bd60993005a912f016117c0f5fd9Structure[] array) {
  RL_7ab705bfa7ab8be3383dd7312431c92b result = new RL_7ab705bfa7ab8be3383dd7312431c92b();
result.InnerFromArray(array);
    return result;
}

public static RL_7ab705bfa7ab8be3383dd7312431c92b ToList<T>(T[] array, Func <T, ST_0995bd60993005a912f016117c0f5fd9Structure> converter) {
  RL_7ab705bfa7ab8be3383dd7312431c92b result = new RL_7ab705bfa7ab8be3383dd7312431c92b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7ab705bfa7ab8be3383dd7312431c92b FromRestList<T>(RestList<T> restList, Func <T, ST_0995bd60993005a912f016117c0f5fd9Structure> converter) {
  RL_7ab705bfa7ab8be3383dd7312431c92b result = new RL_7ab705bfa7ab8be3383dd7312431c92b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7ab705bfa7ab8be3383dd7312431c92b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0995bd60993005a912f016117c0f5fd9Structure> NewList() {
return new RL_7ab705bfa7ab8be3383dd7312431c92b();
}


} // RL_7ab705bfa7ab8be3383dd7312431c92b
}

