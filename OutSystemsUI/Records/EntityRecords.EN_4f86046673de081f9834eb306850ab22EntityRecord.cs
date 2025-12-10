using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] FloatingPosition (KotrkgYJb06O9eGP3OS1rw)
///  <code>EN_4f86046673de081f9834eb306850ab22EntityRecord</code> that represent
/// s <code>FloatingPosition</code> <p>Description: Contains different element position types.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("FloatingPosition","KotrkgYJb06O9eGP3OS1rw","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: FloatingPosition
public partial struct EN_4f86046673de081f9834eb306850ab22EntityRecord : ITypedRecord<EN_4f86046673de081f9834eb306850ab22EntityRecord> {
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*zH+nG3IcBUiIYuc_aOIpVw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("POSITION",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Position")]
private string _ssPosition;
public string ssPosition{
  get{
      return _ssPosition;
  }
  set{
      if((_ssPosition!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssPosition = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4f86046673de081f9834eb306850ab22EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssPosition = "";
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
ssPosition = r.ReadText(index++, "FloatingPosition.Position", "");
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
public void ReadIM(EN_4f86046673de081f9834eb306850ab22EntityRecord r) {
this = r;
}


public static bool operator == (EN_4f86046673de081f9834eb306850ab22EntityRecord a, EN_4f86046673de081f9834eb306850ab22EntityRecord b) {
if (a.ssPosition != b.ssPosition) return false;
return true;
}

public static bool operator != (EN_4f86046673de081f9834eb306850ab22EntityRecord a, EN_4f86046673de081f9834eb306850ab22EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4f86046673de081f9834eb306850ab22EntityRecord)) return false;
return (this == (EN_4f86046673de081f9834eb306850ab22EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_4f86046673de081f9834eb306850ab22EntityRecord Duplicate() {
EN_4f86046673de081f9834eb306850ab22EntityRecord t;
t._ssPosition = this._ssPosition;
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
if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdPosition)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdPosition)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPosition) {
return ssPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssPosition = (string) other.AttributeGet(IdPosition);
ChangedAttributes[0] = other.ChangedAttributeGet(IdPosition);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdPosition);
}
} // EN_4f86046673de081f9834eb306850ab22EntityRecord

/// <summary>
/// RecordList type <code>FloatingPositionList</code> that represents a record list of
///  <code>FloatingPosition</code>
/// </summary>
public partial class RL_799b7146a2a08781a419c46b161fba52 : GenericRecordList<EN_4f86046673de081f9834eb306850ab22EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_4f86046673de081f9834eb306850ab22EntityRecord GetElementDefaultValue() {
return new EN_4f86046673de081f9834eb306850ab22EntityRecord();
}

public T[] ToArray<T>(Func<EN_4f86046673de081f9834eb306850ab22EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_799b7146a2a08781a419c46b161fba52 recordList, Func<EN_4f86046673de081f9834eb306850ab22EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_799b7146a2a08781a419c46b161fba52(EN_4f86046673de081f9834eb306850ab22EntityRecord[] array) {
  RL_799b7146a2a08781a419c46b161fba52 result = new RL_799b7146a2a08781a419c46b161fba52();
result.InnerFromArray(array);
    return result;
}

public static RL_799b7146a2a08781a419c46b161fba52 ToList<T>(T[] array, Func <T, EN_4f86046673de081f9834eb306850ab22EntityRecord> converter) {
  RL_799b7146a2a08781a419c46b161fba52 result = new RL_799b7146a2a08781a419c46b161fba52();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_799b7146a2a08781a419c46b161fba52 FromRestList<T>(RestList<T> restList, Func <T, EN_4f86046673de081f9834eb306850ab22EntityRecord> converter) {
  RL_799b7146a2a08781a419c46b161fba52 result = new RL_799b7146a2a08781a419c46b161fba52();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_799b7146a2a08781a419c46b161fba52() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4f86046673de081f9834eb306850ab22EntityRecord> NewList() {
return new RL_799b7146a2a08781a419c46b161fba52();
}


} // RL_799b7146a2a08781a419c46b161fba52
}
