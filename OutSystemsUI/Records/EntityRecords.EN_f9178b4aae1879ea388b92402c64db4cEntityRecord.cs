using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] IdentityProvider (BHDQithJ1kKT0XNyfGmLFA)
///  <code>EN_f9178b4aae1879ea388b92402c64db4cEntityRecord</code> that represent
/// s <code>IdentityProvider</code> <p>Description: Contains different identity providers.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("IdentityProvider","BHDQithJ1kKT0XNyfGmLFA","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: IdentityProvider
public partial struct EN_f9178b4aae1879ea388b92402c64db4cEntityRecord : ITypedRecord<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord> {
internal static readonly GlobalObjectKey IdProvider = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Bale0qXdiUmohL55zQkqHA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PROVIDER",250,false,true,false,true)]
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

public EN_f9178b4aae1879ea388b92402c64db4cEntityRecord() {
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
ssProvider = r.ReadText(index++, "IdentityProvider.Provider", "");
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
public void ReadIM(EN_f9178b4aae1879ea388b92402c64db4cEntityRecord r) {
this = r;
}


public static bool operator == (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord a, EN_f9178b4aae1879ea388b92402c64db4cEntityRecord b) {
if (a.ssProvider != b.ssProvider) return false;
return true;
}

public static bool operator != (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord a, EN_f9178b4aae1879ea388b92402c64db4cEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord)) return false;
return (this == (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord)o);
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


public EN_f9178b4aae1879ea388b92402c64db4cEntityRecord Duplicate() {
EN_f9178b4aae1879ea388b92402c64db4cEntityRecord t;
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
} // EN_f9178b4aae1879ea388b92402c64db4cEntityRecord

/// <summary>
/// RecordList type <code>IdentityProviderList</code> that represents a record list of
///  <code>IdentityProvider</code>
/// </summary>
public partial class RL_b693780c9c2e91ec100b6cde72ab3ad5 : GenericRecordList<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_f9178b4aae1879ea388b92402c64db4cEntityRecord GetElementDefaultValue() {
return new EN_f9178b4aae1879ea388b92402c64db4cEntityRecord();
}

public T[] ToArray<T>(Func<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b693780c9c2e91ec100b6cde72ab3ad5 recordList, Func<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b693780c9c2e91ec100b6cde72ab3ad5(EN_f9178b4aae1879ea388b92402c64db4cEntityRecord[] array) {
  RL_b693780c9c2e91ec100b6cde72ab3ad5 result = new RL_b693780c9c2e91ec100b6cde72ab3ad5();
result.InnerFromArray(array);
    return result;
}

public static RL_b693780c9c2e91ec100b6cde72ab3ad5 ToList<T>(T[] array, Func <T, EN_f9178b4aae1879ea388b92402c64db4cEntityRecord> converter) {
  RL_b693780c9c2e91ec100b6cde72ab3ad5 result = new RL_b693780c9c2e91ec100b6cde72ab3ad5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b693780c9c2e91ec100b6cde72ab3ad5 FromRestList<T>(RestList<T> restList, Func <T, EN_f9178b4aae1879ea388b92402c64db4cEntityRecord> converter) {
  RL_b693780c9c2e91ec100b6cde72ab3ad5 result = new RL_b693780c9c2e91ec100b6cde72ab3ad5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b693780c9c2e91ec100b6cde72ab3ad5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f9178b4aae1879ea388b92402c64db4cEntityRecord> NewList() {
return new RL_b693780c9c2e91ec100b6cde72ab3ad5();
}


} // RL_b693780c9c2e91ec100b6cde72ab3ad5
}
