using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] DrawingToolType (ZibhFIQaMEO3mOmYHgU3xA)
///  <code>EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord</code> that represent
/// s <code>DrawingToolType</code> <p>Description: Static entity with the available Drawing Tool
///  types.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DrawingToolType","ZibhFIQaMEO3mOmYHgU3xA","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: DrawingToolType
public partial struct EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord : ITypedRecord<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*MDSwsR24ZU6UtE4gwq0M4w");

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

public EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord() {
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
ssId = r.ReadText(index++, "DrawingToolType.Id", "");
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
public void ReadIM(EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord r) {
this = r;
}


public static bool operator == (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord a, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord a, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord)) return false;
return (this == (EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord)o);
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


public EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord Duplicate() {
EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord t;
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
} // EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord

/// <summary>
/// RecordList type <code>DrawingToolTypeList</code> that represents a record list of
///  <code>DrawingToolType</code>
/// </summary>
public partial class RL_93b6a88c9c2da7119b9466c342ffdb20 : GenericRecordList<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord GetElementDefaultValue() {
return new EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord();
}

public T[] ToArray<T>(Func<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_93b6a88c9c2da7119b9466c342ffdb20 recordList, Func<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_93b6a88c9c2da7119b9466c342ffdb20(EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord[] array) {
  RL_93b6a88c9c2da7119b9466c342ffdb20 result = new RL_93b6a88c9c2da7119b9466c342ffdb20();
result.InnerFromArray(array);
    return result;
}

public static RL_93b6a88c9c2da7119b9466c342ffdb20 ToList<T>(T[] array, Func <T, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> converter) {
  RL_93b6a88c9c2da7119b9466c342ffdb20 result = new RL_93b6a88c9c2da7119b9466c342ffdb20();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_93b6a88c9c2da7119b9466c342ffdb20 FromRestList<T>(RestList<T> restList, Func <T, EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> converter) {
  RL_93b6a88c9c2da7119b9466c342ffdb20 result = new RL_93b6a88c9c2da7119b9466c342ffdb20();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_93b6a88c9c2da7119b9466c342ffdb20() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8d1df0845b207a514a87b62b89a2f0f9EntityRecord> NewList() {
return new RL_93b6a88c9c2da7119b9466c342ffdb20();
}


} // RL_93b6a88c9c2da7119b9466c342ffdb20
}
