using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] SearchPlacesErrors (VUfxTsarw02BXezTptw0Bw)
///  <code>EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord</code> that represent
/// s <code>SearchPlacesErrors</code> <p>Description: Static entity with the available search places
///  errors.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("SearchPlacesErrors","VUfxTsarw02BXezTptw0Bw","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: SearchPlacesErrors
public partial struct EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord : ITypedRecord<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*x18uqCyXKUa9Jkrvmjj0gA");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*bHGPn03t7E2odWUdO6tMGA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CODE",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Code")]
private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssCode = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MESSAGE",500,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Message")]
private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssMessage = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssCode = "";
_ssMessage = "";
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
ssCode = r.ReadText(index++, "SearchPlacesErrors.Code", "");
ssMessage = r.ReadText(index++, "SearchPlacesErrors.Message", "");
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord r) {
this = r;
}


public static bool operator == (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord a, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord a, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord)) return false;
return (this == (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord)o);
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


public EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord Duplicate() {
EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord t;
t._ssCode = this._ssCode;
t._ssMessage = this._ssMessage;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (key.Equals(IdCode)) {
return ChangedAttributes[0];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdCode)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[1];
}
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
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[0] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[1] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdMessage);
}
} // EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord

/// <summary>
/// RecordList type <code>SearchPlacesErrorsList</code> that represents a record list of
///  <code>SearchPlacesErrors</code>
/// </summary>
public partial class RL_f0d4cb9d719e2431c9c125448897412d : GenericRecordList<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord GetElementDefaultValue() {
return new EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord();
}

public T[] ToArray<T>(Func<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f0d4cb9d719e2431c9c125448897412d recordList, Func<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f0d4cb9d719e2431c9c125448897412d(EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord[] array) {
  RL_f0d4cb9d719e2431c9c125448897412d result = new RL_f0d4cb9d719e2431c9c125448897412d();
result.InnerFromArray(array);
    return result;
}

public static RL_f0d4cb9d719e2431c9c125448897412d ToList<T>(T[] array, Func <T, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> converter) {
  RL_f0d4cb9d719e2431c9c125448897412d result = new RL_f0d4cb9d719e2431c9c125448897412d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f0d4cb9d719e2431c9c125448897412d FromRestList<T>(RestList<T> restList, Func <T, EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> converter) {
  RL_f0d4cb9d719e2431c9c125448897412d result = new RL_f0d4cb9d719e2431c9c125448897412d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f0d4cb9d719e2431c9c125448897412d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord> NewList() {
return new RL_f0d4cb9d719e2431c9c125448897412d();
}


} // RL_f0d4cb9d719e2431c9c125448897412d
}
