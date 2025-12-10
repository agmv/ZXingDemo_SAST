using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] AnimationType (SdRjBDRo1UCBez100acbsg)
///  <code>EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord</code> that represent
/// s <code>AnimationType</code> <p>Description: Contains different types of element animations.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("AnimationType","SdRjBDRo1UCBez100acbsg","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: AnimationType
public partial struct EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord : ITypedRecord<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> {
internal static readonly GlobalObjectKey IdAnimationType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*k_KtN+QN1EaWVABzbTk1jw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ANIMATIONTYPE",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("AnimationType")]
private string _ssAnimationType;
public string ssAnimationType{
  get{
      return _ssAnimationType;
  }
  set{
      if((_ssAnimationType!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssAnimationType = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssAnimationType = "";
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
ssAnimationType = r.ReadText(index++, "AnimationType.AnimationType", "");
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
public void ReadIM(EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord r) {
this = r;
}


public static bool operator == (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord a, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord b) {
if (a.ssAnimationType != b.ssAnimationType) return false;
return true;
}

public static bool operator != (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord a, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord)) return false;
return (this == (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAnimationType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord Duplicate() {
EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord t;
t._ssAnimationType = this._ssAnimationType;
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
if (head == "animationtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AnimationType")) variable.Value = ssAnimationType; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAnimationType)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAnimationType)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAnimationType) {
return ssAnimationType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAnimationType.Key.AsGuid) {
return ssAnimationType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssAnimationType = (string) other.AttributeGet(IdAnimationType);
ChangedAttributes[0] = other.ChangedAttributeGet(IdAnimationType);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAnimationType);
}
} // EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord

/// <summary>
/// RecordList type <code>AnimationTypeList</code> that represents a record list of
///  <code>AnimationType</code>
/// </summary>
public partial class RL_a3746675e7afa0a411750081849db606 : GenericRecordList<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord GetElementDefaultValue() {
return new EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord();
}

public T[] ToArray<T>(Func<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a3746675e7afa0a411750081849db606 recordList, Func<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a3746675e7afa0a411750081849db606(EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord[] array) {
  RL_a3746675e7afa0a411750081849db606 result = new RL_a3746675e7afa0a411750081849db606();
result.InnerFromArray(array);
    return result;
}

public static RL_a3746675e7afa0a411750081849db606 ToList<T>(T[] array, Func <T, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> converter) {
  RL_a3746675e7afa0a411750081849db606 result = new RL_a3746675e7afa0a411750081849db606();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a3746675e7afa0a411750081849db606 FromRestList<T>(RestList<T> restList, Func <T, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> converter) {
  RL_a3746675e7afa0a411750081849db606 result = new RL_a3746675e7afa0a411750081849db606();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a3746675e7afa0a411750081849db606() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> NewList() {
return new RL_a3746675e7afa0a411750081849db606();
}


} // RL_a3746675e7afa0a411750081849db606
}
