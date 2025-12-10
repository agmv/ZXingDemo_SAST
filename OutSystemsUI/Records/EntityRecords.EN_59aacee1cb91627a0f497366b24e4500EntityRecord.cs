using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] CarouselNavigation (ye867jfk+0mGogwtBlbtQw)
///  <code>EN_59aacee1cb91627a0f497366b24e4500EntityRecord</code> that represent
/// s <code>CarouselNavigation</code> <p>Description: Sets the navigation type of the Carousel. </p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("CarouselNavigation","ye867jfk+0mGogwtBlbtQw","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: CarouselNavigation
public partial struct EN_59aacee1cb91627a0f497366b24e4500EntityRecord : ITypedRecord<EN_59aacee1cb91627a0f497366b24e4500EntityRecord> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*JQYubU6NmUuxnuGCf0F7mg");

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
          ChangedAttributes = new BitArray(1,true);
          _ssType = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_59aacee1cb91627a0f497366b24e4500EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssType = "";
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
ssType = r.ReadText(index++, "CarouselNavigation.Type", "");
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
public void ReadIM(EN_59aacee1cb91627a0f497366b24e4500EntityRecord r) {
this = r;
}


public static bool operator == (EN_59aacee1cb91627a0f497366b24e4500EntityRecord a, EN_59aacee1cb91627a0f497366b24e4500EntityRecord b) {
if (a.ssType != b.ssType) return false;
return true;
}

public static bool operator != (EN_59aacee1cb91627a0f497366b24e4500EntityRecord a, EN_59aacee1cb91627a0f497366b24e4500EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_59aacee1cb91627a0f497366b24e4500EntityRecord)) return false;
return (this == (EN_59aacee1cb91627a0f497366b24e4500EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_59aacee1cb91627a0f497366b24e4500EntityRecord Duplicate() {
EN_59aacee1cb91627a0f497366b24e4500EntityRecord t;
t._ssType = this._ssType;
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
if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdType)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdType)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdType) {
return ssType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssType = (string) other.AttributeGet(IdType);
ChangedAttributes[0] = other.ChangedAttributeGet(IdType);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdType);
}
} // EN_59aacee1cb91627a0f497366b24e4500EntityRecord

/// <summary>
/// RecordList type <code>CarouselNavigationList</code> that represents a record list of
///  <code>CarouselNavigation</code>
/// </summary>
public partial class RL_7c155d6f9991d43524221e40a2ecb02b : GenericRecordList<EN_59aacee1cb91627a0f497366b24e4500EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_59aacee1cb91627a0f497366b24e4500EntityRecord GetElementDefaultValue() {
return new EN_59aacee1cb91627a0f497366b24e4500EntityRecord();
}

public T[] ToArray<T>(Func<EN_59aacee1cb91627a0f497366b24e4500EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7c155d6f9991d43524221e40a2ecb02b recordList, Func<EN_59aacee1cb91627a0f497366b24e4500EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7c155d6f9991d43524221e40a2ecb02b(EN_59aacee1cb91627a0f497366b24e4500EntityRecord[] array) {
  RL_7c155d6f9991d43524221e40a2ecb02b result = new RL_7c155d6f9991d43524221e40a2ecb02b();
result.InnerFromArray(array);
    return result;
}

public static RL_7c155d6f9991d43524221e40a2ecb02b ToList<T>(T[] array, Func <T, EN_59aacee1cb91627a0f497366b24e4500EntityRecord> converter) {
  RL_7c155d6f9991d43524221e40a2ecb02b result = new RL_7c155d6f9991d43524221e40a2ecb02b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7c155d6f9991d43524221e40a2ecb02b FromRestList<T>(RestList<T> restList, Func <T, EN_59aacee1cb91627a0f497366b24e4500EntityRecord> converter) {
  RL_7c155d6f9991d43524221e40a2ecb02b result = new RL_7c155d6f9991d43524221e40a2ecb02b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7c155d6f9991d43524221e40a2ecb02b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_59aacee1cb91627a0f497366b24e4500EntityRecord> NewList() {
return new RL_7c155d6f9991d43524221e40a2ecb02b();
}


} // RL_7c155d6f9991d43524221e40a2ecb02b
}
