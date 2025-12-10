using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] FileLayerEvent (p9v1oRLj502wwpMW4gpmpA)
///  <code>EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord</code> that represent
/// s <code>FileLayerEvent</code> <p>Description: Static entity with the available file layer
///  events.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("FileLayerEvent","p9v1oRLj502wwpMW4gpmpA","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: FileLayerEvent
public partial struct EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord : ITypedRecord<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*pWVhbQNVHUKu3qXdvHmaRA");

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

public EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord() {
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
ssId = r.ReadText(index++, "FileLayerEvent.Id", "");
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
public void ReadIM(EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord r) {
this = r;
}


public static bool operator == (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord a, EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord a, EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord)) return false;
return (this == (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord)o);
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


public EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord Duplicate() {
EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord t;
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
} // EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord

/// <summary>
/// RecordList type <code>FileLayerEventList</code> that represents a record list of
///  <code>FileLayerEvent</code>
/// </summary>
public partial class RL_d3d84b93751a23851d803ac48dd5ce8a : GenericRecordList<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord GetElementDefaultValue() {
return new EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord();
}

public T[] ToArray<T>(Func<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d3d84b93751a23851d803ac48dd5ce8a recordList, Func<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d3d84b93751a23851d803ac48dd5ce8a(EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord[] array) {
  RL_d3d84b93751a23851d803ac48dd5ce8a result = new RL_d3d84b93751a23851d803ac48dd5ce8a();
result.InnerFromArray(array);
    return result;
}

public static RL_d3d84b93751a23851d803ac48dd5ce8a ToList<T>(T[] array, Func <T, EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord> converter) {
  RL_d3d84b93751a23851d803ac48dd5ce8a result = new RL_d3d84b93751a23851d803ac48dd5ce8a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d3d84b93751a23851d803ac48dd5ce8a FromRestList<T>(RestList<T> restList, Func <T, EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord> converter) {
  RL_d3d84b93751a23851d803ac48dd5ce8a result = new RL_d3d84b93751a23851d803ac48dd5ce8a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d3d84b93751a23851d803ac48dd5ce8a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord> NewList() {
return new RL_d3d84b93751a23851d803ac48dd5ce8a();
}


} // RL_d3d84b93751a23851d803ac48dd5ce8a
}
