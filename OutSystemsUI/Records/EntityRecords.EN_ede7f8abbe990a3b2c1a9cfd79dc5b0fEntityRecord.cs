using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] DeviceResponsive (HY5GKVqiw0K_U7IyrMwVDQ)
///  <code>EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord</code> that represent
/// s <code>DeviceResponsive</code> <p>Description: Contains different responsive behaviors according
///  to device screen size.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DeviceResponsive","HY5GKVqiw0K_U7IyrMwVDQ","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: DeviceResponsive
public partial struct EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord : ITypedRecord<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Es7FMyRxsUSDyqjyZsFbJA");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Ah+4F7G0KEKi5kDo8VoIkw");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*HDfXL6JsPE62F7G52DTzZg");

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
          ChangedAttributes = new BitArray(3,true);
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

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IS_ACTIVE",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Is_Active")]
private bool _ssIs_Active;
public bool ssIs_Active{
  get{
      return _ssIs_Active;
  }
  set{
      if((_ssIs_Active!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssIs_Active = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssType = "";
_ssOrder = 0;
_ssIs_Active = false;
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
ssType = r.ReadText(index++, "DeviceResponsive.Type", "");
ssOrder = r.ReadInteger(index++, "DeviceResponsive.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "DeviceResponsive.Is_Active", false);
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord r) {
this = r;
}


public static bool operator == (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord a, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord b) {
if (a.ssType != b.ssType) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
return true;
}

public static bool operator != (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord a, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord)) return false;
return (this == (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssType.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord Duplicate() {
EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord t;
t._ssType = this._ssType;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
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
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
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
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[2];
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
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[2];
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
if (key == IdIs_Active) {
return ssIs_Active;
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
if (attributeKey == IdIs_Active.Key.AsGuid) {
return ssIs_Active;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssType = (string) other.AttributeGet(IdType);
ChangedAttributes[0] = other.ChangedAttributeGet(IdType);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdType);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[2] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIs_Active);
}
} // EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord

/// <summary>
/// RecordList type <code>DeviceResponsiveList</code> that represents a record list of
///  <code>DeviceResponsive</code>
/// </summary>
public partial class RL_d1ce957a73e235b2c1f9383b50c6c777 : GenericRecordList<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord GetElementDefaultValue() {
return new EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord();
}

public T[] ToArray<T>(Func<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d1ce957a73e235b2c1f9383b50c6c777 recordList, Func<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d1ce957a73e235b2c1f9383b50c6c777(EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord[] array) {
  RL_d1ce957a73e235b2c1f9383b50c6c777 result = new RL_d1ce957a73e235b2c1f9383b50c6c777();
result.InnerFromArray(array);
    return result;
}

public static RL_d1ce957a73e235b2c1f9383b50c6c777 ToList<T>(T[] array, Func <T, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> converter) {
  RL_d1ce957a73e235b2c1f9383b50c6c777 result = new RL_d1ce957a73e235b2c1f9383b50c6c777();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d1ce957a73e235b2c1f9383b50c6c777 FromRestList<T>(RestList<T> restList, Func <T, EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> converter) {
  RL_d1ce957a73e235b2c1f9383b50c6c777 result = new RL_d1ce957a73e235b2c1f9383b50c6c777();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d1ce957a73e235b2c1f9383b50c6c777() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord> NewList() {
return new RL_d1ce957a73e235b2c1f9383b50c6c777();
}


} // RL_d1ce957a73e235b2c1f9383b50c6c777
}
