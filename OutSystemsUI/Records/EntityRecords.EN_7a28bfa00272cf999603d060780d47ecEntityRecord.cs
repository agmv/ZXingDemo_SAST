using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] DropdownType (kvMl4l2CLESsH7SwjYKaXQ)
///  <code>EN_7a28bfa00272cf999603d060780d47ecEntityRecord</code> that represent
/// s <code>DropdownType</code> <p>Description: Sets which is the Dropdown type.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DropdownType","kvMl4l2CLESsH7SwjYKaXQ","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: DropdownType
public partial struct EN_7a28bfa00272cf999603d060780d47ecEntityRecord : ITypedRecord<EN_7a28bfa00272cf999603d060780d47ecEntityRecord> {
internal static readonly GlobalObjectKey IdMode = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*iKrMrk1yPkiy8s8l7dwa+w");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MODE",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Mode")]
private string _ssMode;
public string ssMode{
  get{
      return _ssMode;
  }
  set{
      if((_ssMode!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssMode = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7a28bfa00272cf999603d060780d47ecEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssMode = "";
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
ssMode = r.ReadText(index++, "DropdownType.Mode", "");
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
public void ReadIM(EN_7a28bfa00272cf999603d060780d47ecEntityRecord r) {
this = r;
}


public static bool operator == (EN_7a28bfa00272cf999603d060780d47ecEntityRecord a, EN_7a28bfa00272cf999603d060780d47ecEntityRecord b) {
if (a.ssMode != b.ssMode) return false;
return true;
}

public static bool operator != (EN_7a28bfa00272cf999603d060780d47ecEntityRecord a, EN_7a28bfa00272cf999603d060780d47ecEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7a28bfa00272cf999603d060780d47ecEntityRecord)) return false;
return (this == (EN_7a28bfa00272cf999603d060780d47ecEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7a28bfa00272cf999603d060780d47ecEntityRecord Duplicate() {
EN_7a28bfa00272cf999603d060780d47ecEntityRecord t;
t._ssMode = this._ssMode;
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
if (head == "mode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Mode")) variable.Value = ssMode; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdMode)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdMode)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMode) {
return ssMode;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMode.Key.AsGuid) {
return ssMode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssMode = (string) other.AttributeGet(IdMode);
ChangedAttributes[0] = other.ChangedAttributeGet(IdMode);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMode);
}
} // EN_7a28bfa00272cf999603d060780d47ecEntityRecord

/// <summary>
/// RecordList type <code>DropdownTypeList</code> that represents a record list of
///  <code>DropdownType</code>
/// </summary>
public partial class RL_946153d1b4948e5eab31756e5c1159f1 : GenericRecordList<EN_7a28bfa00272cf999603d060780d47ecEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_7a28bfa00272cf999603d060780d47ecEntityRecord GetElementDefaultValue() {
return new EN_7a28bfa00272cf999603d060780d47ecEntityRecord();
}

public T[] ToArray<T>(Func<EN_7a28bfa00272cf999603d060780d47ecEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_946153d1b4948e5eab31756e5c1159f1 recordList, Func<EN_7a28bfa00272cf999603d060780d47ecEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_946153d1b4948e5eab31756e5c1159f1(EN_7a28bfa00272cf999603d060780d47ecEntityRecord[] array) {
  RL_946153d1b4948e5eab31756e5c1159f1 result = new RL_946153d1b4948e5eab31756e5c1159f1();
result.InnerFromArray(array);
    return result;
}

public static RL_946153d1b4948e5eab31756e5c1159f1 ToList<T>(T[] array, Func <T, EN_7a28bfa00272cf999603d060780d47ecEntityRecord> converter) {
  RL_946153d1b4948e5eab31756e5c1159f1 result = new RL_946153d1b4948e5eab31756e5c1159f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_946153d1b4948e5eab31756e5c1159f1 FromRestList<T>(RestList<T> restList, Func <T, EN_7a28bfa00272cf999603d060780d47ecEntityRecord> converter) {
  RL_946153d1b4948e5eab31756e5c1159f1 result = new RL_946153d1b4948e5eab31756e5c1159f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_946153d1b4948e5eab31756e5c1159f1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7a28bfa00272cf999603d060780d47ecEntityRecord> NewList() {
return new RL_946153d1b4948e5eab31756e5c1159f1();
}


} // RL_946153d1b4948e5eab31756e5c1159f1
}
