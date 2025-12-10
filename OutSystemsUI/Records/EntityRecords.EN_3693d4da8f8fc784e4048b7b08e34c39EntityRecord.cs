using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] CarouselProvider (o9ytAbqGb0OVDuSNdOosrA)
///  <code>EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord</code> that represent
/// s <code>CarouselProvider</code> <p>Description: </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("CarouselProvider","o9ytAbqGb0OVDuSNdOosrA","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: CarouselProvider
public partial struct EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord : ITypedRecord<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> {
internal static readonly GlobalObjectKey IdProvider = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*dI4fSW_NhUCjzT0_t2_uOA");

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

public EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord() {
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
ssProvider = r.ReadText(index++, "CarouselProvider.Provider", "");
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
public void ReadIM(EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord r) {
this = r;
}


public static bool operator == (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord a, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord b) {
if (a.ssProvider != b.ssProvider) return false;
return true;
}

public static bool operator != (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord a, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord)) return false;
return (this == (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord)o);
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


public EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord Duplicate() {
EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord t;
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
} // EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord

/// <summary>
/// RecordList type <code>CarouselProviderList</code> that represents a record list of
///  <code>CarouselProvider</code>
/// </summary>
public partial class RL_a30d2539b4ff7ed1b19c3e6514d069cf : GenericRecordList<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord GetElementDefaultValue() {
return new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord();
}

public T[] ToArray<T>(Func<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a30d2539b4ff7ed1b19c3e6514d069cf recordList, Func<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a30d2539b4ff7ed1b19c3e6514d069cf(EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord[] array) {
  RL_a30d2539b4ff7ed1b19c3e6514d069cf result = new RL_a30d2539b4ff7ed1b19c3e6514d069cf();
result.InnerFromArray(array);
    return result;
}

public static RL_a30d2539b4ff7ed1b19c3e6514d069cf ToList<T>(T[] array, Func <T, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> converter) {
  RL_a30d2539b4ff7ed1b19c3e6514d069cf result = new RL_a30d2539b4ff7ed1b19c3e6514d069cf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a30d2539b4ff7ed1b19c3e6514d069cf FromRestList<T>(RestList<T> restList, Func <T, EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> converter) {
  RL_a30d2539b4ff7ed1b19c3e6514d069cf result = new RL_a30d2539b4ff7ed1b19c3e6514d069cf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a30d2539b4ff7ed1b19c3e6514d069cf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord> NewList() {
return new RL_a30d2539b4ff7ed1b19c3e6514d069cf();
}


} // RL_a30d2539b4ff7ed1b19c3e6514d069cf
}
