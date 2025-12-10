namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] ErrorMessage (l1FzEHvK5EiuF9pxnTNxKw)
///  <code>ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure</code> that represents <code>ErrorMessage</code
/// > <p>Description: Error message from actions from the Map. Contains a code and a message explaining
///  the error.</p>
/// </summary>
// Name: ErrorMessage
public partial struct ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure : ITypedRecord<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*pFflTShalEeyh6wqL3ZMCw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*ryavKmvrgU6kawHHdyNvYA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Code")]
public string ssCode;

[System.Xml.Serialization.XmlElement("Message")]
public string ssMessage;


public BitArray OptimizedAttributes;

public ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure() {
OptimizedAttributes = null;
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
ssCode = r.ReadText(index++, "ErrorMessage.Code", "");
ssMessage = r.ReadText(index++, "ErrorMessage.Message", "");
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
public void ReadIM(ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure r) {
this = r;
}


public static bool operator == (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure a, ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure a, ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure)) return false;
return (this == (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
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


public ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure Duplicate() {
ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure t;
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
if (head == "code") {
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
if (key == IdCode) {
return ssCode;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
ssCode = (string) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure
/// <summary>
/// RecordList type <code>ErrorMessageList</code> that represents a record list of
///  <code>ErrorMessage</code>
/// </summary>
public partial class RL_1638668ea76502df056543656d2e89d1 : GenericRecordList<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure GetElementDefaultValue() {
return new ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure();
}

public T[] ToArray<T>(Func<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1638668ea76502df056543656d2e89d1 recordList, Func<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1638668ea76502df056543656d2e89d1(ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure[] array) {
  RL_1638668ea76502df056543656d2e89d1 result = new RL_1638668ea76502df056543656d2e89d1();
result.InnerFromArray(array);
    return result;
}

public static RL_1638668ea76502df056543656d2e89d1 ToList<T>(T[] array, Func <T, ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> converter) {
  RL_1638668ea76502df056543656d2e89d1 result = new RL_1638668ea76502df056543656d2e89d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1638668ea76502df056543656d2e89d1 FromRestList<T>(RestList<T> restList, Func <T, ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> converter) {
  RL_1638668ea76502df056543656d2e89d1 result = new RL_1638668ea76502df056543656d2e89d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1638668ea76502df056543656d2e89d1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure> NewList() {
return new RL_1638668ea76502df056543656d2e89d1();
}


} // RL_1638668ea76502df056543656d2e89d1
}

