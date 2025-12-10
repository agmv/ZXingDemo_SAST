using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] Autoplay (tFiqgruLGU2StilEr_rQLA)
///  <code>EN_c3a2475ae6370a2f746040280495b4a2EntityRecord</code> that represents <code>Autoplay</code
/// > <p>Description: Contains different autoplay speed settings on elements and animations.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Autoplay","tFiqgruLGU2StilEr_rQLA","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: Autoplay
public partial struct EN_c3a2475ae6370a2f746040280495b4a2EntityRecord : ITypedRecord<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> {
internal static readonly GlobalObjectKey IdAutoplay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*TvPdUtkJNEKeOsFqo4GRYA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("AUTOPLAY",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Autoplay")]
private string _ssAutoplay;
public string ssAutoplay{
  get{
      return _ssAutoplay;
  }
  set{
      if((_ssAutoplay!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssAutoplay = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c3a2475ae6370a2f746040280495b4a2EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssAutoplay = "";
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
ssAutoplay = r.ReadText(index++, "Autoplay.Autoplay", "");
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
public void ReadIM(EN_c3a2475ae6370a2f746040280495b4a2EntityRecord r) {
this = r;
}


public static bool operator == (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord a, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord b) {
if (a.ssAutoplay != b.ssAutoplay) return false;
return true;
}

public static bool operator != (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord a, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord)) return false;
return (this == (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAutoplay.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c3a2475ae6370a2f746040280495b4a2EntityRecord Duplicate() {
EN_c3a2475ae6370a2f746040280495b4a2EntityRecord t;
t._ssAutoplay = this._ssAutoplay;
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
if (head == "autoplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Autoplay")) variable.Value = ssAutoplay; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAutoplay)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAutoplay)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAutoplay) {
return ssAutoplay;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAutoplay.Key.AsGuid) {
return ssAutoplay;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssAutoplay = (string) other.AttributeGet(IdAutoplay);
ChangedAttributes[0] = other.ChangedAttributeGet(IdAutoplay);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAutoplay);
}
} // EN_c3a2475ae6370a2f746040280495b4a2EntityRecord

/// <summary>
/// RecordList type <code>AutoplayList</code> that represents a record list of <code>Autoplay</code>
/// </summary>
public partial class RL_dce031541ffd7ddb60ff42662d8a6be6 : GenericRecordList<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_c3a2475ae6370a2f746040280495b4a2EntityRecord GetElementDefaultValue() {
return new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord();
}

public T[] ToArray<T>(Func<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dce031541ffd7ddb60ff42662d8a6be6 recordList, Func<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dce031541ffd7ddb60ff42662d8a6be6(EN_c3a2475ae6370a2f746040280495b4a2EntityRecord[] array) {
  RL_dce031541ffd7ddb60ff42662d8a6be6 result = new RL_dce031541ffd7ddb60ff42662d8a6be6();
result.InnerFromArray(array);
    return result;
}

public static RL_dce031541ffd7ddb60ff42662d8a6be6 ToList<T>(T[] array, Func <T, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> converter) {
  RL_dce031541ffd7ddb60ff42662d8a6be6 result = new RL_dce031541ffd7ddb60ff42662d8a6be6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dce031541ffd7ddb60ff42662d8a6be6 FromRestList<T>(RestList<T> restList, Func <T, EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> converter) {
  RL_dce031541ffd7ddb60ff42662d8a6be6 result = new RL_dce031541ffd7ddb60ff42662d8a6be6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dce031541ffd7ddb60ff42662d8a6be6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c3a2475ae6370a2f746040280495b4a2EntityRecord> NewList() {
return new RL_dce031541ffd7ddb60ff42662d8a6be6();
}


} // RL_dce031541ffd7ddb60ff42662d8a6be6
}
