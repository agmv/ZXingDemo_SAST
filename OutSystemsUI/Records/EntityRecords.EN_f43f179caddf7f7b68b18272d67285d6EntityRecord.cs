using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] MenuAction (gyjBnKsG8EyZl+3nxsAtZw)
///  <code>EN_f43f179caddf7f7b68b18272d67285d6EntityRecord</code> that represent
/// s <code>MenuAction</code> <p>Description: Sets the menu behavior for devices with small
///  screens.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("MenuAction","gyjBnKsG8EyZl+3nxsAtZw","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: MenuAction
public partial struct EN_f43f179caddf7f7b68b18272d67285d6EntityRecord : ITypedRecord<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> {
internal static readonly GlobalObjectKey IdMenuAction = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*RjqhIau1_k+wN6MKeuDZ+Q");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MENUACTION",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("MenuAction")]
private string _ssMenuAction;
public string ssMenuAction{
  get{
      return _ssMenuAction;
  }
  set{
      if((_ssMenuAction!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssMenuAction = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f43f179caddf7f7b68b18272d67285d6EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssMenuAction = "";
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
ssMenuAction = r.ReadText(index++, "MenuAction.MenuAction", "");
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
public void ReadIM(EN_f43f179caddf7f7b68b18272d67285d6EntityRecord r) {
this = r;
}


public static bool operator == (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord a, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord b) {
if (a.ssMenuAction != b.ssMenuAction) return false;
return true;
}

public static bool operator != (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord a, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord)) return false;
return (this == (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMenuAction.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f43f179caddf7f7b68b18272d67285d6EntityRecord Duplicate() {
EN_f43f179caddf7f7b68b18272d67285d6EntityRecord t;
t._ssMenuAction = this._ssMenuAction;
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
if (head == "menuaction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MenuAction")) variable.Value = ssMenuAction; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdMenuAction)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdMenuAction)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMenuAction) {
return ssMenuAction;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMenuAction.Key.AsGuid) {
return ssMenuAction;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssMenuAction = (string) other.AttributeGet(IdMenuAction);
ChangedAttributes[0] = other.ChangedAttributeGet(IdMenuAction);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMenuAction);
}
} // EN_f43f179caddf7f7b68b18272d67285d6EntityRecord

/// <summary>
/// RecordList type <code>MenuActionList</code> that represents a record list of
///  <code>MenuAction</code>
/// </summary>
public partial class RL_4aa1509142da7c0b9e4be414c8f7c6f5 : GenericRecordList<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_f43f179caddf7f7b68b18272d67285d6EntityRecord GetElementDefaultValue() {
return new EN_f43f179caddf7f7b68b18272d67285d6EntityRecord();
}

public T[] ToArray<T>(Func<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4aa1509142da7c0b9e4be414c8f7c6f5 recordList, Func<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4aa1509142da7c0b9e4be414c8f7c6f5(EN_f43f179caddf7f7b68b18272d67285d6EntityRecord[] array) {
  RL_4aa1509142da7c0b9e4be414c8f7c6f5 result = new RL_4aa1509142da7c0b9e4be414c8f7c6f5();
result.InnerFromArray(array);
    return result;
}

public static RL_4aa1509142da7c0b9e4be414c8f7c6f5 ToList<T>(T[] array, Func <T, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> converter) {
  RL_4aa1509142da7c0b9e4be414c8f7c6f5 result = new RL_4aa1509142da7c0b9e4be414c8f7c6f5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4aa1509142da7c0b9e4be414c8f7c6f5 FromRestList<T>(RestList<T> restList, Func <T, EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> converter) {
  RL_4aa1509142da7c0b9e4be414c8f7c6f5 result = new RL_4aa1509142da7c0b9e4be414c8f7c6f5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4aa1509142da7c0b9e4be414c8f7c6f5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f43f179caddf7f7b68b18272d67285d6EntityRecord> NewList() {
return new RL_4aa1509142da7c0b9e4be414c8f7c6f5();
}


} // RL_4aa1509142da7c0b9e4be414c8f7c6f5
}
