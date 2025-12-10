using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] DatePickerLanguage (5C5ARb9zokK1+Dca6UC_Tw)
///  <code>EN_ac6f62956e278d5390a5f27c607338d0EntityRecord</code> that represent
/// s <code>DatePickerLanguage</code> <p>Description: Used to define the DatePicker default
///  language.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("DatePickerLanguage","5C5ARb9zokK1+Dca6UC_Tw","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: DatePickerLanguage
public partial struct EN_ac6f62956e278d5390a5f27c607338d0EntityRecord : ITypedRecord<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> {
internal static readonly GlobalObjectKey IdAlpha2Code = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*AyPXL84AGk2uWHeQFfbeTw");
internal static readonly GlobalObjectKey IdLanguageName = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*b6PwbhOyq0aOZ9kq8WJjmA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ALPHA2CODE",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Alpha2Code")]
private string _ssAlpha2Code;
public string ssAlpha2Code{
  get{
      return _ssAlpha2Code;
  }
  set{
      if((_ssAlpha2Code!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssAlpha2Code = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LANGUAGENAME",100,false,false,false,true)]
[System.Xml.Serialization.XmlElement("LanguageName")]
private string _ssLanguageName;
public string ssLanguageName{
  get{
      return _ssLanguageName;
  }
  set{
      if((_ssLanguageName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssLanguageName = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ac6f62956e278d5390a5f27c607338d0EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssAlpha2Code = "";
_ssLanguageName = "";
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
ssAlpha2Code = r.ReadText(index++, "DatePickerLanguage.Alpha2Code", "");
ssLanguageName = r.ReadText(index++, "DatePickerLanguage.LanguageName", "");
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(EN_ac6f62956e278d5390a5f27c607338d0EntityRecord r) {
this = r;
}


public static bool operator == (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord a, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord b) {
if (a.ssAlpha2Code != b.ssAlpha2Code) return false;
if (a.ssLanguageName != b.ssLanguageName) return false;
return true;
}

public static bool operator != (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord a, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord)) return false;
return (this == (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAlpha2Code.GetHashCode()
 ^ ssLanguageName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_ac6f62956e278d5390a5f27c607338d0EntityRecord Duplicate() {
EN_ac6f62956e278d5390a5f27c607338d0EntityRecord t;
t._ssAlpha2Code = this._ssAlpha2Code;
t._ssLanguageName = this._ssLanguageName;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
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
if (head == "alpha2code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Alpha2Code")) variable.Value = ssAlpha2Code; else variable.Optimized = true;
} else if (head == "languagename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LanguageName")) variable.Value = ssLanguageName; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAlpha2Code)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLanguageName)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdAlpha2Code)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLanguageName)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAlpha2Code) {
return ssAlpha2Code;
}
if (key == IdLanguageName) {
return ssLanguageName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAlpha2Code.Key.AsGuid) {
return ssAlpha2Code;
}
if (attributeKey == IdLanguageName.Key.AsGuid) {
return ssLanguageName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssAlpha2Code = (string) other.AttributeGet(IdAlpha2Code);
ChangedAttributes[0] = other.ChangedAttributeGet(IdAlpha2Code);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAlpha2Code);
ssLanguageName = (string) other.AttributeGet(IdLanguageName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLanguageName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLanguageName);
}
} // EN_ac6f62956e278d5390a5f27c607338d0EntityRecord

/// <summary>
/// RecordList type <code>DatePickerLanguageList</code> that represents a record list of
///  <code>DatePickerLanguage</code>
/// </summary>
public partial class RL_d656c399e70b60822640f73b89cbc71f : GenericRecordList<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_ac6f62956e278d5390a5f27c607338d0EntityRecord GetElementDefaultValue() {
return new EN_ac6f62956e278d5390a5f27c607338d0EntityRecord();
}

public T[] ToArray<T>(Func<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d656c399e70b60822640f73b89cbc71f recordList, Func<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d656c399e70b60822640f73b89cbc71f(EN_ac6f62956e278d5390a5f27c607338d0EntityRecord[] array) {
  RL_d656c399e70b60822640f73b89cbc71f result = new RL_d656c399e70b60822640f73b89cbc71f();
result.InnerFromArray(array);
    return result;
}

public static RL_d656c399e70b60822640f73b89cbc71f ToList<T>(T[] array, Func <T, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> converter) {
  RL_d656c399e70b60822640f73b89cbc71f result = new RL_d656c399e70b60822640f73b89cbc71f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d656c399e70b60822640f73b89cbc71f FromRestList<T>(RestList<T> restList, Func <T, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> converter) {
  RL_d656c399e70b60822640f73b89cbc71f result = new RL_d656c399e70b60822640f73b89cbc71f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d656c399e70b60822640f73b89cbc71f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> NewList() {
return new RL_d656c399e70b60822640f73b89cbc71f();
}


} // RL_d656c399e70b60822640f73b89cbc71f
}
