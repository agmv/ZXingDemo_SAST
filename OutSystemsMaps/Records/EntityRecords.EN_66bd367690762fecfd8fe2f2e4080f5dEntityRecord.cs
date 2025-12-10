using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] TravelMode (mj8f_a2H+kWBtEamHaYGcQ)
///  <code>EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord</code> that represent
/// s <code>TravelMode</code> <p>Description: Static entity with the available travel modes for
///  directions.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TravelMode","mj8f_a2H+kWBtEamHaYGcQ","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: TravelMode
public partial struct EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord : ITypedRecord<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*AJYg+hAGdkq8sbrTwFH95g");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssId = "";
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
ssId = r.ReadText(index++, "TravelMode.Id", "");
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord r) {
this = r;
}


public static bool operator == (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord a, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord a, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord)) return false;
return (this == (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord Duplicate() {
EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord t;
t._ssId = this._ssId;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
}
} // EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord

/// <summary>
/// RecordList type <code>TravelModeList</code> that represents a record list of
///  <code>TravelMode</code>
/// </summary>
public partial class RL_bf8419dbc0d495138fce5469408e1ae2 : GenericRecordList<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord GetElementDefaultValue() {
return new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord();
}

public T[] ToArray<T>(Func<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bf8419dbc0d495138fce5469408e1ae2 recordList, Func<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bf8419dbc0d495138fce5469408e1ae2(EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord[] array) {
  RL_bf8419dbc0d495138fce5469408e1ae2 result = new RL_bf8419dbc0d495138fce5469408e1ae2();
result.InnerFromArray(array);
    return result;
}

public static RL_bf8419dbc0d495138fce5469408e1ae2 ToList<T>(T[] array, Func <T, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> converter) {
  RL_bf8419dbc0d495138fce5469408e1ae2 result = new RL_bf8419dbc0d495138fce5469408e1ae2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bf8419dbc0d495138fce5469408e1ae2 FromRestList<T>(RestList<T> restList, Func <T, EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> converter) {
  RL_bf8419dbc0d495138fce5469408e1ae2 result = new RL_bf8419dbc0d495138fce5469408e1ae2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bf8419dbc0d495138fce5469408e1ae2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord> NewList() {
return new RL_bf8419dbc0d495138fce5469408e1ae2();
}


} // RL_bf8419dbc0d495138fce5469408e1ae2
}
