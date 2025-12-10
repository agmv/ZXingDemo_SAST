using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] DrawingToolsEventTriggered (3d5AJll+PEiJ9lGrF6OJmQ)
///  <code>EN_8a068e43cce18c5870b845073fb713c1EntityRecord</code> that represent
/// s <code>DrawingToolsEventTriggered</code> <p>Description: Static entity with the available Drawing
///  Tool events that can be triggered.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DrawingToolsEventTriggered","3d5AJll+PEiJ9lGrF6OJmQ","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: DrawingToolsEventTriggered
public partial struct EN_8a068e43cce18c5870b845073fb713c1EntityRecord : ITypedRecord<EN_8a068e43cce18c5870b845073fb713c1EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*h3d8ENVBoEWVAyDSjnFRfw");

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

public EN_8a068e43cce18c5870b845073fb713c1EntityRecord() {
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
ssId = r.ReadText(index++, "DrawingToolsEventTriggered.Id", "");
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
public void ReadIM(EN_8a068e43cce18c5870b845073fb713c1EntityRecord r) {
this = r;
}


public static bool operator == (EN_8a068e43cce18c5870b845073fb713c1EntityRecord a, EN_8a068e43cce18c5870b845073fb713c1EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_8a068e43cce18c5870b845073fb713c1EntityRecord a, EN_8a068e43cce18c5870b845073fb713c1EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8a068e43cce18c5870b845073fb713c1EntityRecord)) return false;
return (this == (EN_8a068e43cce18c5870b845073fb713c1EntityRecord)o);
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


public EN_8a068e43cce18c5870b845073fb713c1EntityRecord Duplicate() {
EN_8a068e43cce18c5870b845073fb713c1EntityRecord t;
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
} // EN_8a068e43cce18c5870b845073fb713c1EntityRecord

/// <summary>
/// RecordList type <code>DrawingToolsEventTriggeredList</code> that represents a record list of
///  <code>DrawingToolsEventTriggered</code>
/// </summary>
public partial class RL_25b09e54ba65c9a859d9dfa5fd79e171 : GenericRecordList<EN_8a068e43cce18c5870b845073fb713c1EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_8a068e43cce18c5870b845073fb713c1EntityRecord GetElementDefaultValue() {
return new EN_8a068e43cce18c5870b845073fb713c1EntityRecord();
}

public T[] ToArray<T>(Func<EN_8a068e43cce18c5870b845073fb713c1EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_25b09e54ba65c9a859d9dfa5fd79e171 recordList, Func<EN_8a068e43cce18c5870b845073fb713c1EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_25b09e54ba65c9a859d9dfa5fd79e171(EN_8a068e43cce18c5870b845073fb713c1EntityRecord[] array) {
  RL_25b09e54ba65c9a859d9dfa5fd79e171 result = new RL_25b09e54ba65c9a859d9dfa5fd79e171();
result.InnerFromArray(array);
    return result;
}

public static RL_25b09e54ba65c9a859d9dfa5fd79e171 ToList<T>(T[] array, Func <T, EN_8a068e43cce18c5870b845073fb713c1EntityRecord> converter) {
  RL_25b09e54ba65c9a859d9dfa5fd79e171 result = new RL_25b09e54ba65c9a859d9dfa5fd79e171();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_25b09e54ba65c9a859d9dfa5fd79e171 FromRestList<T>(RestList<T> restList, Func <T, EN_8a068e43cce18c5870b845073fb713c1EntityRecord> converter) {
  RL_25b09e54ba65c9a859d9dfa5fd79e171 result = new RL_25b09e54ba65c9a859d9dfa5fd79e171();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_25b09e54ba65c9a859d9dfa5fd79e171() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8a068e43cce18c5870b845073fb713c1EntityRecord> NewList() {
return new RL_25b09e54ba65c9a859d9dfa5fd79e171();
}


} // RL_25b09e54ba65c9a859d9dfa5fd79e171
}
