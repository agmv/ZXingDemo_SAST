using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] DropdownProvider (OrEyxBB7iEqZPHF0jzTX_w)
///  <code>EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord</code> that represent
/// s <code>DropdownProvider</code> <p>Description: Sets which is the Dropdown provider.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DropdownProvider","OrEyxBB7iEqZPHF0jzTX_w","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: DropdownProvider
public partial struct EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord : ITypedRecord<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> {
internal static readonly GlobalObjectKey IdProvider = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*aFrwht_CdUGuQI90N+uDHA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROVIDER",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Provider")]
private string _ssProvider;
public string ssProvider{
  get{
      return _ssProvider;
  }
  set{
      if((_ssProvider!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssProvider = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssProvider = "";
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
ssProvider = r.ReadText(index++, "DropdownProvider.Provider", "");
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
public void ReadIM(EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord r) {
this = r;
}


public static bool operator == (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord a, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord b) {
if (a.ssProvider != b.ssProvider) return false;
return true;
}

public static bool operator != (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord a, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord)) return false;
return (this == (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord Duplicate() {
EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord t;
t._ssProvider = this._ssProvider;
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
if (head == "provider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Provider")) variable.Value = ssProvider; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdProvider)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdProvider)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProvider) {
return ssProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProvider.Key.AsGuid) {
return ssProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssProvider = (string) other.AttributeGet(IdProvider);
ChangedAttributes[0] = other.ChangedAttributeGet(IdProvider);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdProvider);
}
} // EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord

/// <summary>
/// RecordList type <code>DropdownProviderList</code> that represents a record list of
///  <code>DropdownProvider</code>
/// </summary>
public partial class RL_1cbee159281ed82f6e5bc7a8b9325c58 : GenericRecordList<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord GetElementDefaultValue() {
return new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord();
}

public T[] ToArray<T>(Func<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1cbee159281ed82f6e5bc7a8b9325c58 recordList, Func<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1cbee159281ed82f6e5bc7a8b9325c58(EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord[] array) {
  RL_1cbee159281ed82f6e5bc7a8b9325c58 result = new RL_1cbee159281ed82f6e5bc7a8b9325c58();
result.InnerFromArray(array);
    return result;
}

public static RL_1cbee159281ed82f6e5bc7a8b9325c58 ToList<T>(T[] array, Func <T, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> converter) {
  RL_1cbee159281ed82f6e5bc7a8b9325c58 result = new RL_1cbee159281ed82f6e5bc7a8b9325c58();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1cbee159281ed82f6e5bc7a8b9325c58 FromRestList<T>(RestList<T> restList, Func <T, EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> converter) {
  RL_1cbee159281ed82f6e5bc7a8b9325c58 result = new RL_1cbee159281ed82f6e5bc7a8b9325c58();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1cbee159281ed82f6e5bc7a8b9325c58() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord> NewList() {
return new RL_1cbee159281ed82f6e5bc7a8b9325c58();
}


} // RL_1cbee159281ed82f6e5bc7a8b9325c58
}
