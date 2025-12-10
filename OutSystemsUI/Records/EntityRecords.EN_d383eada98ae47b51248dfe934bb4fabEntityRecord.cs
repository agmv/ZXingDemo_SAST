using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] DEPRECATED_Color (jTtbSudEA0ybiUU_ov7uIA)
///  <code>EN_d383eada98ae47b51248dfe934bb4fabEntityRecord</code> that represent
/// s <code>DEPRECATED_Color</code> <p>Description: Collection of curated colors which match with the
///  respective CSS classes.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DEPRECATED_Color","jTtbSudEA0ybiUU_ov7uIA","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: DEPRECATED_Color
public partial struct EN_d383eada98ae47b51248dfe934bb4fabEntityRecord : ITypedRecord<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> {
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*VJ8JX8KSS0qSQZJ_G9MJWw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("COLOR",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Color")]
private string _ssColor;
public string ssColor{
  get{
      return _ssColor;
  }
  set{
      if((_ssColor!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssColor = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d383eada98ae47b51248dfe934bb4fabEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssColor = "";
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
ssColor = r.ReadText(index++, "DEPRECATED_Color.Color", "");
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
public void ReadIM(EN_d383eada98ae47b51248dfe934bb4fabEntityRecord r) {
this = r;
}


public static bool operator == (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord a, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord b) {
if (a.ssColor != b.ssColor) return false;
return true;
}

public static bool operator != (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord a, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord)) return false;
return (this == (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssColor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d383eada98ae47b51248dfe934bb4fabEntityRecord Duplicate() {
EN_d383eada98ae47b51248dfe934bb4fabEntityRecord t;
t._ssColor = this._ssColor;
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
if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssColor; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdColor)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdColor)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdColor) {
return ssColor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColor.Key.AsGuid) {
return ssColor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssColor = (string) other.AttributeGet(IdColor);
ChangedAttributes[0] = other.ChangedAttributeGet(IdColor);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdColor);
}
} // EN_d383eada98ae47b51248dfe934bb4fabEntityRecord

/// <summary>
/// RecordList type <code>DEPRECATED_ColorList</code> that represents a record list of
///  <code>DEPRECATED_Color</code>
/// </summary>
public partial class RL_3be527befbeca9c3042c1440ecab7d56 : GenericRecordList<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_d383eada98ae47b51248dfe934bb4fabEntityRecord GetElementDefaultValue() {
return new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord();
}

public T[] ToArray<T>(Func<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3be527befbeca9c3042c1440ecab7d56 recordList, Func<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3be527befbeca9c3042c1440ecab7d56(EN_d383eada98ae47b51248dfe934bb4fabEntityRecord[] array) {
  RL_3be527befbeca9c3042c1440ecab7d56 result = new RL_3be527befbeca9c3042c1440ecab7d56();
result.InnerFromArray(array);
    return result;
}

public static RL_3be527befbeca9c3042c1440ecab7d56 ToList<T>(T[] array, Func <T, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> converter) {
  RL_3be527befbeca9c3042c1440ecab7d56 result = new RL_3be527befbeca9c3042c1440ecab7d56();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3be527befbeca9c3042c1440ecab7d56 FromRestList<T>(RestList<T> restList, Func <T, EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> converter) {
  RL_3be527befbeca9c3042c1440ecab7d56 result = new RL_3be527befbeca9c3042c1440ecab7d56();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3be527befbeca9c3042c1440ecab7d56() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d383eada98ae47b51248dfe934bb4fabEntityRecord> NewList() {
return new RL_3be527befbeca9c3042c1440ecab7d56();
}


} // RL_3be527befbeca9c3042c1440ecab7d56
}
