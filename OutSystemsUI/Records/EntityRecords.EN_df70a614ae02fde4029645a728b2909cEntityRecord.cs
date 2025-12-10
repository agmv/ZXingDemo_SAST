using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] RegisteredCallbackEvents (A9eSglUkr02VdKhS3EK6_w)
///  <code>EN_df70a614ae02fde4029645a728b2909cEntityRecord</code> that represent
/// s <code>RegisteredCallbackEvents</code> <p>Description: Define all the registered callback event
///  names.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("RegisteredCallbackEvents","A9eSglUkr02VdKhS3EK6_w","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: RegisteredCallbackEvents
public partial struct EN_df70a614ae02fde4029645a728b2909cEntityRecord : ITypedRecord<EN_df70a614ae02fde4029645a728b2909cEntityRecord> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*7iV2C6EAWUu2kaF_PoIFig");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NAME",100,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Name")]
private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssName = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_df70a614ae02fde4029645a728b2909cEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssName = "";
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
ssName = r.ReadText(index++, "RegisteredCallbackEvents.Name", "");
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
public void ReadIM(EN_df70a614ae02fde4029645a728b2909cEntityRecord r) {
this = r;
}


public static bool operator == (EN_df70a614ae02fde4029645a728b2909cEntityRecord a, EN_df70a614ae02fde4029645a728b2909cEntityRecord b) {
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (EN_df70a614ae02fde4029645a728b2909cEntityRecord a, EN_df70a614ae02fde4029645a728b2909cEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_df70a614ae02fde4029645a728b2909cEntityRecord)) return false;
return (this == (EN_df70a614ae02fde4029645a728b2909cEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_df70a614ae02fde4029645a728b2909cEntityRecord Duplicate() {
EN_df70a614ae02fde4029645a728b2909cEntityRecord t;
t._ssName = this._ssName;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdName)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdName)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdName) {
return ssName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[0] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdName);
}
} // EN_df70a614ae02fde4029645a728b2909cEntityRecord

/// <summary>
/// RecordList type <code>RegisteredCallbackEventsList</code> that represents a record list of
///  <code>RegisteredCallbackEvents</code>
/// </summary>
public partial class RL_bca66b074f528989e6d5482126ef35c6 : GenericRecordList<EN_df70a614ae02fde4029645a728b2909cEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_df70a614ae02fde4029645a728b2909cEntityRecord GetElementDefaultValue() {
return new EN_df70a614ae02fde4029645a728b2909cEntityRecord();
}

public T[] ToArray<T>(Func<EN_df70a614ae02fde4029645a728b2909cEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bca66b074f528989e6d5482126ef35c6 recordList, Func<EN_df70a614ae02fde4029645a728b2909cEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bca66b074f528989e6d5482126ef35c6(EN_df70a614ae02fde4029645a728b2909cEntityRecord[] array) {
  RL_bca66b074f528989e6d5482126ef35c6 result = new RL_bca66b074f528989e6d5482126ef35c6();
result.InnerFromArray(array);
    return result;
}

public static RL_bca66b074f528989e6d5482126ef35c6 ToList<T>(T[] array, Func <T, EN_df70a614ae02fde4029645a728b2909cEntityRecord> converter) {
  RL_bca66b074f528989e6d5482126ef35c6 result = new RL_bca66b074f528989e6d5482126ef35c6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bca66b074f528989e6d5482126ef35c6 FromRestList<T>(RestList<T> restList, Func <T, EN_df70a614ae02fde4029645a728b2909cEntityRecord> converter) {
  RL_bca66b074f528989e6d5482126ef35c6 result = new RL_bca66b074f528989e6d5482126ef35c6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bca66b074f528989e6d5482126ef35c6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_df70a614ae02fde4029645a728b2909cEntityRecord> NewList() {
return new RL_bca66b074f528989e6d5482126ef35c6();
}


} // RL_bca66b074f528989e6d5482126ef35c6
}
