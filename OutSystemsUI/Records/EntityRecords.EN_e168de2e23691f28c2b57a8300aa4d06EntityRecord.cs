using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] ProgressType (QifDsW5gPk6ZIxwubmmrbA)
///  <code>EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord</code> that represent
/// s <code>ProgressType</code> <p>Description: Define the progress types that could be used.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProgressType","QifDsW5gPk6ZIxwubmmrbA","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: ProgressType
public partial struct EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord : ITypedRecord<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*wUr0q21vNU2Tr00lTpLVZg");

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

public EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord() {
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
ssType = r.ReadText(index++, "ProgressType.Type", "");
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
public void ReadIM(EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord r) {
this = r;
}


public static bool operator == (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord a, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord b) {
if (a.ssType != b.ssType) return false;
return true;
}

public static bool operator != (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord a, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord)) return false;
return (this == (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord)o);
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


public EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord Duplicate() {
EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord t;
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
} // EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord

/// <summary>
/// RecordList type <code>ProgressTypeList</code> that represents a record list of
///  <code>ProgressType</code>
/// </summary>
public partial class RL_65d9a4311a8786a7162dbd4fc605ecd0 : GenericRecordList<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord GetElementDefaultValue() {
return new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord();
}

public T[] ToArray<T>(Func<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_65d9a4311a8786a7162dbd4fc605ecd0 recordList, Func<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_65d9a4311a8786a7162dbd4fc605ecd0(EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord[] array) {
  RL_65d9a4311a8786a7162dbd4fc605ecd0 result = new RL_65d9a4311a8786a7162dbd4fc605ecd0();
result.InnerFromArray(array);
    return result;
}

public static RL_65d9a4311a8786a7162dbd4fc605ecd0 ToList<T>(T[] array, Func <T, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> converter) {
  RL_65d9a4311a8786a7162dbd4fc605ecd0 result = new RL_65d9a4311a8786a7162dbd4fc605ecd0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_65d9a4311a8786a7162dbd4fc605ecd0 FromRestList<T>(RestList<T> restList, Func <T, EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> converter) {
  RL_65d9a4311a8786a7162dbd4fc605ecd0 result = new RL_65d9a4311a8786a7162dbd4fc605ecd0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_65d9a4311a8786a7162dbd4fc605ecd0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord> NewList() {
return new RL_65d9a4311a8786a7162dbd4fc605ecd0();
}


} // RL_65d9a4311a8786a7162dbd4fc605ecd0
}
