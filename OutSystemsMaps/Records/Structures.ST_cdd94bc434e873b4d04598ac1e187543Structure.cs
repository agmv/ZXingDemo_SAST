namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] ReturnMessage (IXnfnv0oPE6z_eqaJzK4SA)
///  <code>ST_cdd94bc434e873b4d04598ac1e187543Structure</code> that represent
/// s <code>ReturnMessage</code> <p>Description: Returning error message from actions such as
///  SetDirections or RemoveRedirections.</p>
/// </summary>
// Name: ReturnMessage
public partial struct ST_cdd94bc434e873b4d04598ac1e187543Structure : ITypedRecord<ST_cdd94bc434e873b4d04598ac1e187543Structure> {
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*crC4_deEn0OYhk0c7FIOwg");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*+1c3zwMBT0my1ed0pr4mzg");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*3bI6t81_oE2OQ34ehLq0mw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IsSuccess")]
public bool ssIsSuccess;

[System.Xml.Serialization.XmlElement("Code")]
public string ssCode;

[System.Xml.Serialization.XmlElement("Message")]
public string ssMessage;


public BitArray OptimizedAttributes;

public ST_cdd94bc434e873b4d04598ac1e187543Structure() {
OptimizedAttributes = null;
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
ssIsSuccess = r.ReadBoolean(index++, "ReturnMessage.IsSuccess", false);
ssCode = r.ReadText(index++, "ReturnMessage.Code", "");
ssMessage = r.ReadText(index++, "ReturnMessage.Message", "");
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
public void ReadIM(ST_cdd94bc434e873b4d04598ac1e187543Structure r) {
this = r;
}


public static bool operator == (ST_cdd94bc434e873b4d04598ac1e187543Structure a, ST_cdd94bc434e873b4d04598ac1e187543Structure b) {
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_cdd94bc434e873b4d04598ac1e187543Structure a, ST_cdd94bc434e873b4d04598ac1e187543Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_cdd94bc434e873b4d04598ac1e187543Structure)) return false;
return (this == (ST_cdd94bc434e873b4d04598ac1e187543Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
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


public ST_cdd94bc434e873b4d04598ac1e187543Structure Duplicate() {
ST_cdd94bc434e873b4d04598ac1e187543Structure t;
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
if (head == "issuccess") {
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
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssCode = (string) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_cdd94bc434e873b4d04598ac1e187543Structure
/// <summary>
/// RecordList type <code>ReturnMessageList</code> that represents a record list of
///  <code>ReturnMessage</code>
/// </summary>
public partial class RL_d66ace1346b52d1c825353e8e6242745 : GenericRecordList<ST_cdd94bc434e873b4d04598ac1e187543Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_cdd94bc434e873b4d04598ac1e187543Structure GetElementDefaultValue() {
return new ST_cdd94bc434e873b4d04598ac1e187543Structure();
}

public T[] ToArray<T>(Func<ST_cdd94bc434e873b4d04598ac1e187543Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d66ace1346b52d1c825353e8e6242745 recordList, Func<ST_cdd94bc434e873b4d04598ac1e187543Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d66ace1346b52d1c825353e8e6242745(ST_cdd94bc434e873b4d04598ac1e187543Structure[] array) {
  RL_d66ace1346b52d1c825353e8e6242745 result = new RL_d66ace1346b52d1c825353e8e6242745();
result.InnerFromArray(array);
    return result;
}

public static RL_d66ace1346b52d1c825353e8e6242745 ToList<T>(T[] array, Func <T, ST_cdd94bc434e873b4d04598ac1e187543Structure> converter) {
  RL_d66ace1346b52d1c825353e8e6242745 result = new RL_d66ace1346b52d1c825353e8e6242745();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d66ace1346b52d1c825353e8e6242745 FromRestList<T>(RestList<T> restList, Func <T, ST_cdd94bc434e873b4d04598ac1e187543Structure> converter) {
  RL_d66ace1346b52d1c825353e8e6242745 result = new RL_d66ace1346b52d1c825353e8e6242745();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d66ace1346b52d1c825353e8e6242745() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_cdd94bc434e873b4d04598ac1e187543Structure> NewList() {
return new RL_d66ace1346b52d1c825353e8e6242745();
}


} // RL_d66ace1346b52d1c825353e8e6242745
}

