using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] MessageStatus (wF8BwRzIzECgRr+ZzyGigA)
///  <code>EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord</code> that represent
/// s <code>MessageStatus</code> <p>Description: Identify if the message was Received, Sent or
///  Read.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("MessageStatus","wF8BwRzIzECgRr+ZzyGigA","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: MessageStatus
public partial struct EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord : ITypedRecord<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jusDsvPoBEa1q3P4HMjSWQ");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*o5goQc_jWkGg9jiwWsZ3vA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TYPE",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Type")]
private string _ssType;
public string ssType{
  get{
      return _ssType;
  }
  set{
      if((_ssType!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssType = value;
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

public EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssType = "";
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
ssType = r.ReadText(index++, "MessageStatus.Type", "");
ssOrder = r.ReadInteger(index++, "MessageStatus.Order", 0);
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
public void ReadIM(EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord r) {
this = r;
}


public static bool operator == (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord a, EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord b) {
if (a.ssType != b.ssType) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord a, EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord)) return false;
return (this == (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssType.GetHashCode()
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


public EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord Duplicate() {
EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord t;
t._ssType = this._ssType;
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
if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdType)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdType)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdType) {
return ssType;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
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
ssType = (string) other.AttributeGet(IdType);
ChangedAttributes[0] = other.ChangedAttributeGet(IdType);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdType);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord

/// <summary>
/// RecordList type <code>MessageStatusList</code> that represents a record list of
///  <code>MessageStatus</code>
/// </summary>
public partial class RL_718bfa5485b42466fae8f4ad1fc16180 : GenericRecordList<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord GetElementDefaultValue() {
return new EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord();
}

public T[] ToArray<T>(Func<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_718bfa5485b42466fae8f4ad1fc16180 recordList, Func<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_718bfa5485b42466fae8f4ad1fc16180(EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord[] array) {
  RL_718bfa5485b42466fae8f4ad1fc16180 result = new RL_718bfa5485b42466fae8f4ad1fc16180();
result.InnerFromArray(array);
    return result;
}

public static RL_718bfa5485b42466fae8f4ad1fc16180 ToList<T>(T[] array, Func <T, EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> converter) {
  RL_718bfa5485b42466fae8f4ad1fc16180 result = new RL_718bfa5485b42466fae8f4ad1fc16180();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_718bfa5485b42466fae8f4ad1fc16180 FromRestList<T>(RestList<T> restList, Func <T, EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> converter) {
  RL_718bfa5485b42466fae8f4ad1fc16180 result = new RL_718bfa5485b42466fae8f4ad1fc16180();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_718bfa5485b42466fae8f4ad1fc16180() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord> NewList() {
return new RL_718bfa5485b42466fae8f4ad1fc16180();
}


} // RL_718bfa5485b42466fae8f4ad1fc16180
}
