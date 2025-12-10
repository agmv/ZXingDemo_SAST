using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] LogType (ktP0AJ5oIk235PshtTxQcg)
///  <code>EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord</code> that represents <code>LogType</code
/// > <p>Description: Type of the log being recorded.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("LogType","ktP0AJ5oIk235PshtTxQcg","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: LogType
public partial struct EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord : ITypedRecord<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> {
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GZx+KF7gYkmgwBn9bbrj3Q");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*6lv_FA_l00OxkEmDSzIh6Q");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Label")]
private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssLabel = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ORDER",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Order")]
private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrder = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssLabel = "";
_ssOrder = 0;
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
ssLabel = r.ReadText(index++, "LogType.Label", "");
ssOrder = r.ReadInteger(index++, "LogType.Order", 0);
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
public void ReadIM(EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord r) {
this = r;
}


public static bool operator == (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord a, EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord b) {
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord a, EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord)) return false;
return (this == (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord Duplicate() {
EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord t;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
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
if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[0] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord

/// <summary>
/// RecordList type <code>LogTypeList</code> that represents a record list of <code>LogType</code>
/// </summary>
public partial class RL_6897c0b9a465b6b8e75080159ed1a0ba : GenericRecordList<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord GetElementDefaultValue() {
return new EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord();
}

public T[] ToArray<T>(Func<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6897c0b9a465b6b8e75080159ed1a0ba recordList, Func<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6897c0b9a465b6b8e75080159ed1a0ba(EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord[] array) {
  RL_6897c0b9a465b6b8e75080159ed1a0ba result = new RL_6897c0b9a465b6b8e75080159ed1a0ba();
result.InnerFromArray(array);
    return result;
}

public static RL_6897c0b9a465b6b8e75080159ed1a0ba ToList<T>(T[] array, Func <T, EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> converter) {
  RL_6897c0b9a465b6b8e75080159ed1a0ba result = new RL_6897c0b9a465b6b8e75080159ed1a0ba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6897c0b9a465b6b8e75080159ed1a0ba FromRestList<T>(RestList<T> restList, Func <T, EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> converter) {
  RL_6897c0b9a465b6b8e75080159ed1a0ba result = new RL_6897c0b9a465b6b8e75080159ed1a0ba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6897c0b9a465b6b8e75080159ed1a0ba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord> NewList() {
return new RL_6897c0b9a465b6b8e75080159ed1a0ba();
}


} // RL_6897c0b9a465b6b8e75080159ed1a0ba
}
