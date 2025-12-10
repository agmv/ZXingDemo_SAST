using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] MarkerType (CvEFPekoKUC7hFq3renjag)
///  <code>EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord</code> that represent
/// s <code>MarkerType</code> <p>Description: Static entity with the available marker types.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("MarkerType","CvEFPekoKUC7hFq3renjag","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: MarkerType
public partial struct EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord : ITypedRecord<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*tnDs8n75x02sv7_Coz0QYQ");

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

public EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord() {
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
ssId = r.ReadText(index++, "MarkerType.Id", "");
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
public void ReadIM(EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord r) {
this = r;
}


public static bool operator == (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord a, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord a, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord)) return false;
return (this == (EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord)o);
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


public EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord Duplicate() {
EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord t;
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
} // EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord

/// <summary>
/// RecordList type <code>MarkerTypeList</code> that represents a record list of
///  <code>MarkerType</code>
/// </summary>
public partial class RL_1dd9beeca9296fa7b8e0dda894601f07 : GenericRecordList<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord GetElementDefaultValue() {
return new EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord();
}

public T[] ToArray<T>(Func<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1dd9beeca9296fa7b8e0dda894601f07 recordList, Func<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1dd9beeca9296fa7b8e0dda894601f07(EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord[] array) {
  RL_1dd9beeca9296fa7b8e0dda894601f07 result = new RL_1dd9beeca9296fa7b8e0dda894601f07();
result.InnerFromArray(array);
    return result;
}

public static RL_1dd9beeca9296fa7b8e0dda894601f07 ToList<T>(T[] array, Func <T, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> converter) {
  RL_1dd9beeca9296fa7b8e0dda894601f07 result = new RL_1dd9beeca9296fa7b8e0dda894601f07();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1dd9beeca9296fa7b8e0dda894601f07 FromRestList<T>(RestList<T> restList, Func <T, EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> converter) {
  RL_1dd9beeca9296fa7b8e0dda894601f07 result = new RL_1dd9beeca9296fa7b8e0dda894601f07();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1dd9beeca9296fa7b8e0dda894601f07() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c3a74b883bf36717c1c549a2bbfbc0daEntityRecord> NewList() {
return new RL_1dd9beeca9296fa7b8e0dda894601f07();
}


} // RL_1dd9beeca9296fa7b8e0dda894601f07
}
