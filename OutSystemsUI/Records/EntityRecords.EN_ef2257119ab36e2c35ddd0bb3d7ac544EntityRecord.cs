using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] ColumnBreak (IazmzCqUL0mLRmTF5uoFew)
///  <code>EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord</code> that represent
/// s <code>ColumnBreak</code> <p>Description: Contains different types of collumn formatting.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ColumnBreak","IazmzCqUL0mLRmTF5uoFew","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: ColumnBreak
public partial struct EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord : ITypedRecord<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> {
internal static readonly GlobalObjectKey IdColumnBreak = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6yxylCyNKEC5vaGupZ7_Vw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("COLUMNBREAK",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("ColumnBreak")]
private string _ssColumnBreak;
public string ssColumnBreak{
  get{
      return _ssColumnBreak;
  }
  set{
      if((_ssColumnBreak!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssColumnBreak = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssColumnBreak = "";
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
ssColumnBreak = r.ReadText(index++, "ColumnBreak.ColumnBreak", "");
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
public void ReadIM(EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord r) {
this = r;
}


public static bool operator == (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord a, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord b) {
if (a.ssColumnBreak != b.ssColumnBreak) return false;
return true;
}

public static bool operator != (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord a, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord)) return false;
return (this == (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssColumnBreak.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord Duplicate() {
EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord t;
t._ssColumnBreak = this._ssColumnBreak;
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
if (head == "columnbreak") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ColumnBreak")) variable.Value = ssColumnBreak; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdColumnBreak)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdColumnBreak)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdColumnBreak) {
return ssColumnBreak;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColumnBreak.Key.AsGuid) {
return ssColumnBreak;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssColumnBreak = (string) other.AttributeGet(IdColumnBreak);
ChangedAttributes[0] = other.ChangedAttributeGet(IdColumnBreak);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdColumnBreak);
}
} // EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord

/// <summary>
/// RecordList type <code>ColumnBreakList</code> that represents a record list of
///  <code>ColumnBreak</code>
/// </summary>
public partial class RL_362950b7d5d9798e12950648533599a1 : GenericRecordList<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord GetElementDefaultValue() {
return new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord();
}

public T[] ToArray<T>(Func<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_362950b7d5d9798e12950648533599a1 recordList, Func<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_362950b7d5d9798e12950648533599a1(EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord[] array) {
  RL_362950b7d5d9798e12950648533599a1 result = new RL_362950b7d5d9798e12950648533599a1();
result.InnerFromArray(array);
    return result;
}

public static RL_362950b7d5d9798e12950648533599a1 ToList<T>(T[] array, Func <T, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> converter) {
  RL_362950b7d5d9798e12950648533599a1 result = new RL_362950b7d5d9798e12950648533599a1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_362950b7d5d9798e12950648533599a1 FromRestList<T>(RestList<T> restList, Func <T, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> converter) {
  RL_362950b7d5d9798e12950648533599a1 result = new RL_362950b7d5d9798e12950648533599a1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_362950b7d5d9798e12950648533599a1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> NewList() {
return new RL_362950b7d5d9798e12950648533599a1();
}


} // RL_362950b7d5d9798e12950648533599a1
}
