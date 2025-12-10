using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] MarkerEventTriggered (shJYz8m9sk6CQAn2Nnxq1g)
///  <code>EN_d9c97e718205f8627d74b06df54e3543EntityRecord</code> that represent
/// s <code>MarkerEventTriggered</code> <p>Description: Static entity with the available marker events
///  that can be triggered.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("MarkerEventTriggered","shJYz8m9sk6CQAn2Nnxq1g","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: MarkerEventTriggered
public partial struct EN_d9c97e718205f8627d74b06df54e3543EntityRecord : ITypedRecord<EN_d9c97e718205f8627d74b06df54e3543EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*EsuaEkXGYEmbNAPCo+PStQ");

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

public EN_d9c97e718205f8627d74b06df54e3543EntityRecord() {
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
ssId = r.ReadText(index++, "MarkerEventTriggered.Id", "");
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
public void ReadIM(EN_d9c97e718205f8627d74b06df54e3543EntityRecord r) {
this = r;
}


public static bool operator == (EN_d9c97e718205f8627d74b06df54e3543EntityRecord a, EN_d9c97e718205f8627d74b06df54e3543EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_d9c97e718205f8627d74b06df54e3543EntityRecord a, EN_d9c97e718205f8627d74b06df54e3543EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d9c97e718205f8627d74b06df54e3543EntityRecord)) return false;
return (this == (EN_d9c97e718205f8627d74b06df54e3543EntityRecord)o);
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


public EN_d9c97e718205f8627d74b06df54e3543EntityRecord Duplicate() {
EN_d9c97e718205f8627d74b06df54e3543EntityRecord t;
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
} // EN_d9c97e718205f8627d74b06df54e3543EntityRecord

/// <summary>
/// RecordList type <code>MarkerEventTriggeredList</code> that represents a record list of
///  <code>MarkerEventTriggered</code>
/// </summary>
public partial class RL_e3387fd9387e17b451b57ed577025ebf : GenericRecordList<EN_d9c97e718205f8627d74b06df54e3543EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_d9c97e718205f8627d74b06df54e3543EntityRecord GetElementDefaultValue() {
return new EN_d9c97e718205f8627d74b06df54e3543EntityRecord();
}

public T[] ToArray<T>(Func<EN_d9c97e718205f8627d74b06df54e3543EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e3387fd9387e17b451b57ed577025ebf recordList, Func<EN_d9c97e718205f8627d74b06df54e3543EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e3387fd9387e17b451b57ed577025ebf(EN_d9c97e718205f8627d74b06df54e3543EntityRecord[] array) {
  RL_e3387fd9387e17b451b57ed577025ebf result = new RL_e3387fd9387e17b451b57ed577025ebf();
result.InnerFromArray(array);
    return result;
}

public static RL_e3387fd9387e17b451b57ed577025ebf ToList<T>(T[] array, Func <T, EN_d9c97e718205f8627d74b06df54e3543EntityRecord> converter) {
  RL_e3387fd9387e17b451b57ed577025ebf result = new RL_e3387fd9387e17b451b57ed577025ebf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e3387fd9387e17b451b57ed577025ebf FromRestList<T>(RestList<T> restList, Func <T, EN_d9c97e718205f8627d74b06df54e3543EntityRecord> converter) {
  RL_e3387fd9387e17b451b57ed577025ebf result = new RL_e3387fd9387e17b451b57ed577025ebf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e3387fd9387e17b451b57ed577025ebf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d9c97e718205f8627d74b06df54e3543EntityRecord> NewList() {
return new RL_e3387fd9387e17b451b57ed577025ebf();
}


} // RL_e3387fd9387e17b451b57ed577025ebf
}
