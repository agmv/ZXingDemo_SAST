using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] DrawingToolsPosition (zN0PlRIkSEKoZDmaD9m0aQ)
///  <code>EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord</code> that represent
/// s <code>DrawingToolsPosition</code> <p>Description: Set the drawing tools position within a
///  Map.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DrawingToolsPosition","zN0PlRIkSEKoZDmaD9m0aQ","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: DrawingToolsPosition
public partial struct EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord : ITypedRecord<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*lT15A8RaYkS1ySOphytfMQ");

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

public EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord() {
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
ssId = r.ReadText(index++, "DrawingToolsPosition.Id", "");
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
public void ReadIM(EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord r) {
this = r;
}


public static bool operator == (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord a, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord a, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord)) return false;
return (this == (EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord)o);
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


public EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord Duplicate() {
EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord t;
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
} // EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord

/// <summary>
/// RecordList type <code>DrawingToolsPositionList</code> that represents a record list of
///  <code>DrawingToolsPosition</code>
/// </summary>
public partial class RL_3ceaf8c75f7341cd8a52e0037549736f : GenericRecordList<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord GetElementDefaultValue() {
return new EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord();
}

public T[] ToArray<T>(Func<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3ceaf8c75f7341cd8a52e0037549736f recordList, Func<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3ceaf8c75f7341cd8a52e0037549736f(EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord[] array) {
  RL_3ceaf8c75f7341cd8a52e0037549736f result = new RL_3ceaf8c75f7341cd8a52e0037549736f();
result.InnerFromArray(array);
    return result;
}

public static RL_3ceaf8c75f7341cd8a52e0037549736f ToList<T>(T[] array, Func <T, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> converter) {
  RL_3ceaf8c75f7341cd8a52e0037549736f result = new RL_3ceaf8c75f7341cd8a52e0037549736f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3ceaf8c75f7341cd8a52e0037549736f FromRestList<T>(RestList<T> restList, Func <T, EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> converter) {
  RL_3ceaf8c75f7341cd8a52e0037549736f result = new RL_3ceaf8c75f7341cd8a52e0037549736f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3ceaf8c75f7341cd8a52e0037549736f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f6b05f1cc2ae707d67f7da7ba2f4fd22EntityRecord> NewList() {
return new RL_3ceaf8c75f7341cd8a52e0037549736f();
}


} // RL_3ceaf8c75f7341cd8a52e0037549736f
}
