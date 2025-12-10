using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] Alert (wIZEkprd6katdCz5rAyE2Q)
///  <code>EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord</code> that represents <code>Alert</code
/// > <p>Description: Different types of alert messages</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Alert","wIZEkprd6katdCz5rAyE2Q","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: Alert
public partial struct EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord : ITypedRecord<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> {
internal static readonly GlobalObjectKey IdAlert = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*XuaMuhRkgU2h2zQHSPHoIw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ALERT",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Alert")]
private string _ssAlert;
public string ssAlert{
  get{
      return _ssAlert;
  }
  set{
      if((_ssAlert!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssAlert = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssAlert = "";
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
ssAlert = r.ReadText(index++, "Alert.Alert", "");
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
public void ReadIM(EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord r) {
this = r;
}


public static bool operator == (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord a, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord b) {
if (a.ssAlert != b.ssAlert) return false;
return true;
}

public static bool operator != (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord a, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord)) return false;
return (this == (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAlert.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord Duplicate() {
EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord t;
t._ssAlert = this._ssAlert;
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
if (head == "alert") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Alert")) variable.Value = ssAlert; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAlert)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAlert)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAlert) {
return ssAlert;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAlert.Key.AsGuid) {
return ssAlert;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssAlert = (string) other.AttributeGet(IdAlert);
ChangedAttributes[0] = other.ChangedAttributeGet(IdAlert);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAlert);
}
} // EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord

/// <summary>
/// RecordList type <code>AlertList</code> that represents a record list of <code>Alert</code>
/// </summary>
public partial class RL_af071f8b45f2932e1364f15bc3e90819 : GenericRecordList<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord GetElementDefaultValue() {
return new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord();
}

public T[] ToArray<T>(Func<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_af071f8b45f2932e1364f15bc3e90819 recordList, Func<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_af071f8b45f2932e1364f15bc3e90819(EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord[] array) {
  RL_af071f8b45f2932e1364f15bc3e90819 result = new RL_af071f8b45f2932e1364f15bc3e90819();
result.InnerFromArray(array);
    return result;
}

public static RL_af071f8b45f2932e1364f15bc3e90819 ToList<T>(T[] array, Func <T, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> converter) {
  RL_af071f8b45f2932e1364f15bc3e90819 result = new RL_af071f8b45f2932e1364f15bc3e90819();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_af071f8b45f2932e1364f15bc3e90819 FromRestList<T>(RestList<T> restList, Func <T, EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> converter) {
  RL_af071f8b45f2932e1364f15bc3e90819 result = new RL_af071f8b45f2932e1364f15bc3e90819();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_af071f8b45f2932e1364f15bc3e90819() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord> NewList() {
return new RL_af071f8b45f2932e1364f15bc3e90819();
}


} // RL_af071f8b45f2932e1364f15bc3e90819
}
