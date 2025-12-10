namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ReturnMessage (KgQ1mt4nIkmym4cw+pNz7A)
///  <code>ST_13c131829a33cb5bedb5c64aa6f4add2Structure</code> that represent
/// s <code>ReturnMessage</code> <p>Description: Returning structures from actions.</p>
/// </summary>
// Name: ReturnMessage
public partial struct ST_13c131829a33cb5bedb5c64aa6f4add2Structure : ITypedRecord<ST_13c131829a33cb5bedb5c64aa6f4add2Structure> {
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*WfWrcURO8EC8hM1YZP0VAQ");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*pENWchqbsEqh8QPKvs3amg");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*SZSImHZOek+QRSr6c6NWhA");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*9SpoZkh3i0OI3d1iK0rw1g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IsSuccess")]
public bool ssIsSuccess;

[System.Xml.Serialization.XmlElement("Code")]
public string ssCode;

[System.Xml.Serialization.XmlElement("Message")]
public string ssMessage;

[System.Xml.Serialization.XmlElement("Value")]
public string ssValue;


public BitArray OptimizedAttributes;

public ST_13c131829a33cb5bedb5c64aa6f4add2Structure() {
OptimizedAttributes = null;
ssIsSuccess = false;
ssCode = "";
ssMessage = "";
ssValue = "";
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
ssIsSuccess = r.ReadBoolean(index++, "ReturnMessage.IsSuccess", false);
ssCode = r.ReadText(index++, "ReturnMessage.Code", "");
ssMessage = r.ReadText(index++, "ReturnMessage.Message", "");
ssValue = r.ReadText(index++, "ReturnMessage.Value", "");
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
public void ReadIM(ST_13c131829a33cb5bedb5c64aa6f4add2Structure r) {
this = r;
}


public static bool operator == (ST_13c131829a33cb5bedb5c64aa6f4add2Structure a, ST_13c131829a33cb5bedb5c64aa6f4add2Structure b) {
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_13c131829a33cb5bedb5c64aa6f4add2Structure a, ST_13c131829a33cb5bedb5c64aa6f4add2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_13c131829a33cb5bedb5c64aa6f4add2Structure)) return false;
return (this == (ST_13c131829a33cb5bedb5c64aa6f4add2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_13c131829a33cb5bedb5c64aa6f4add2Structure Duplicate() {
ST_13c131829a33cb5bedb5c64aa6f4add2Structure t;
t.ssIsSuccess = this.ssIsSuccess;
t.ssCode = this.ssCode;
t.ssMessage = this.ssMessage;
t.ssValue = this.ssValue;
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
if (head == "issuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSuccess")) variable.Value = ssIsSuccess; else variable.Optimized = true;
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdIsSuccess) {
return ssIsSuccess;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsSuccess.Key.AsGuid) {
return ssIsSuccess;
}
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssCode = (string) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
ssValue = (string) other.AttributeGet(IdValue);
}
} // ST_13c131829a33cb5bedb5c64aa6f4add2Structure
/// <summary>
/// RecordList type <code>ReturnMessageList</code> that represents a record list of
///  <code>ReturnMessage</code>
/// </summary>
public partial class RL_a99fc4ead772763d78283a9d04a1dd57 : GenericRecordList<ST_13c131829a33cb5bedb5c64aa6f4add2Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_13c131829a33cb5bedb5c64aa6f4add2Structure GetElementDefaultValue() {
return new ST_13c131829a33cb5bedb5c64aa6f4add2Structure();
}

public T[] ToArray<T>(Func<ST_13c131829a33cb5bedb5c64aa6f4add2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a99fc4ead772763d78283a9d04a1dd57 recordList, Func<ST_13c131829a33cb5bedb5c64aa6f4add2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a99fc4ead772763d78283a9d04a1dd57(ST_13c131829a33cb5bedb5c64aa6f4add2Structure[] array) {
  RL_a99fc4ead772763d78283a9d04a1dd57 result = new RL_a99fc4ead772763d78283a9d04a1dd57();
result.InnerFromArray(array);
    return result;
}

public static RL_a99fc4ead772763d78283a9d04a1dd57 ToList<T>(T[] array, Func <T, ST_13c131829a33cb5bedb5c64aa6f4add2Structure> converter) {
  RL_a99fc4ead772763d78283a9d04a1dd57 result = new RL_a99fc4ead772763d78283a9d04a1dd57();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a99fc4ead772763d78283a9d04a1dd57 FromRestList<T>(RestList<T> restList, Func <T, ST_13c131829a33cb5bedb5c64aa6f4add2Structure> converter) {
  RL_a99fc4ead772763d78283a9d04a1dd57 result = new RL_a99fc4ead772763d78283a9d04a1dd57();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a99fc4ead772763d78283a9d04a1dd57() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_13c131829a33cb5bedb5c64aa6f4add2Structure> NewList() {
return new RL_a99fc4ead772763d78283a9d04a1dd57();
}


} // RL_a99fc4ead772763d78283a9d04a1dd57
}

