using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] CarouselDirection (ZuLLccX3+0K+rna8Ml2Z6g)
///  <code>EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord</code> that represent
/// s <code>CarouselDirection</code> <p>Description: Sets the direction in which the Carousel
///  moves.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("CarouselDirection","ZuLLccX3+0K+rna8Ml2Z6g","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: CarouselDirection
public partial struct EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord : ITypedRecord<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*2nZmChRvLECkQ8PuZnjyIA");

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

public EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord() {
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
ssType = r.ReadText(index++, "CarouselDirection.Type", "");
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
public void ReadIM(EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord r) {
this = r;
}


public static bool operator == (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord a, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord b) {
if (a.ssType != b.ssType) return false;
return true;
}

public static bool operator != (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord a, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord)) return false;
return (this == (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord)o);
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


public EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord Duplicate() {
EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord t;
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
} // EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord

/// <summary>
/// RecordList type <code>CarouselDirectionList</code> that represents a record list of
///  <code>CarouselDirection</code>
/// </summary>
public partial class RL_adbfc30c899ef88f92a4ffb0fe1c08d9 : GenericRecordList<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord GetElementDefaultValue() {
return new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord();
}

public T[] ToArray<T>(Func<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_adbfc30c899ef88f92a4ffb0fe1c08d9 recordList, Func<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_adbfc30c899ef88f92a4ffb0fe1c08d9(EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord[] array) {
  RL_adbfc30c899ef88f92a4ffb0fe1c08d9 result = new RL_adbfc30c899ef88f92a4ffb0fe1c08d9();
result.InnerFromArray(array);
    return result;
}

public static RL_adbfc30c899ef88f92a4ffb0fe1c08d9 ToList<T>(T[] array, Func <T, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> converter) {
  RL_adbfc30c899ef88f92a4ffb0fe1c08d9 result = new RL_adbfc30c899ef88f92a4ffb0fe1c08d9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_adbfc30c899ef88f92a4ffb0fe1c08d9 FromRestList<T>(RestList<T> restList, Func <T, EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> converter) {
  RL_adbfc30c899ef88f92a4ffb0fe1c08d9 result = new RL_adbfc30c899ef88f92a4ffb0fe1c08d9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_adbfc30c899ef88f92a4ffb0fe1c08d9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord> NewList() {
return new RL_adbfc30c899ef88f92a4ffb0fe1c08d9();
}


} // RL_adbfc30c899ef88f92a4ffb0fe1c08d9
}
