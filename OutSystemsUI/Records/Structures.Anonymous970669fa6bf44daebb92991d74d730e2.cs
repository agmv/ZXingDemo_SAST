namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (+mkGl_Rrrk27kpkddNcw4g)
///  <code>RC_7925a19e6fd0a09e9058a96c7f19b104</code> that represent
/// s <code>DropdownSearch_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownSearch_InternalConfigsRecord
public partial struct RC_7925a19e6fd0a09e9058a96c7f19b104 : ITypedRecord<RC_7925a19e6fd0a09e9058a96c7f19b104> {
internal static readonly GlobalObjectKey IdDropdownSearch_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nqEledBvnqCQWKlsfxmxBA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownSearch_InternalConfigs")]
public ST_936f99e69df60f5aa2563bbd38e49c98Structure ssSTDropdownSearch_InternalConfigs;


public static implicit operator ST_936f99e69df60f5aa2563bbd38e49c98Structure( RC_7925a19e6fd0a09e9058a96c7f19b104 r) {
return r.ssSTDropdownSearch_InternalConfigs;
}

public static implicit operator RC_7925a19e6fd0a09e9058a96c7f19b104 (ST_936f99e69df60f5aa2563bbd38e49c98Structure r) {
RC_7925a19e6fd0a09e9058a96c7f19b104 res = new RC_7925a19e6fd0a09e9058a96c7f19b104 ();
res.ssSTDropdownSearch_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7925a19e6fd0a09e9058a96c7f19b104() {
OptimizedAttributes = null;
ssSTDropdownSearch_InternalConfigs = new ST_936f99e69df60f5aa2563bbd38e49c98Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTDropdownSearch_InternalConfigs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTDropdownSearch_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_7925a19e6fd0a09e9058a96c7f19b104 r) {
this = r;
}


public static bool operator == (RC_7925a19e6fd0a09e9058a96c7f19b104 a, RC_7925a19e6fd0a09e9058a96c7f19b104 b) {
if (a.ssSTDropdownSearch_InternalConfigs != b.ssSTDropdownSearch_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_7925a19e6fd0a09e9058a96c7f19b104 a, RC_7925a19e6fd0a09e9058a96c7f19b104 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7925a19e6fd0a09e9058a96c7f19b104)) return false;
return (this == (RC_7925a19e6fd0a09e9058a96c7f19b104)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownSearch_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownSearch_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownSearch_InternalConfigs.InternalRecursiveSave();
}


public RC_7925a19e6fd0a09e9058a96c7f19b104 Duplicate() {
RC_7925a19e6fd0a09e9058a96c7f19b104 t;
t.ssSTDropdownSearch_InternalConfigs = (ST_936f99e69df60f5aa2563bbd38e49c98Structure)this.ssSTDropdownSearch_InternalConfigs.Duplicate();
t.OptimizedAttributes = null;
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
if (head == "dropdownsearch_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownSearch_InternalConfigs")) variable.Value = ssSTDropdownSearch_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("dropdownsearch_internalconfigs");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDropdownSearch_InternalConfigs) {
return ssSTDropdownSearch_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownSearch_InternalConfigs.Key.AsGuid) {
return ssSTDropdownSearch_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownSearch_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDropdownSearch_InternalConfigs));
}
} // RC_7925a19e6fd0a09e9058a96c7f19b104
/// <summary>
/// RecordList type <code>DropdownSearch_InternalConfigsRecordList</code> that represents a record list
///  of <code>DropdownSearch_InternalConfigs</code>
/// </summary>
public partial class RL_974e629f62892897fa725e3d52373ce1 : GenericRecordList<RC_7925a19e6fd0a09e9058a96c7f19b104>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7925a19e6fd0a09e9058a96c7f19b104 GetElementDefaultValue() {
return new RC_7925a19e6fd0a09e9058a96c7f19b104();
}

public T[] ToArray<T>(Func<RC_7925a19e6fd0a09e9058a96c7f19b104, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_974e629f62892897fa725e3d52373ce1 recordList, Func<RC_7925a19e6fd0a09e9058a96c7f19b104, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_974e629f62892897fa725e3d52373ce1(RC_7925a19e6fd0a09e9058a96c7f19b104[] array) {
  RL_974e629f62892897fa725e3d52373ce1 result = new RL_974e629f62892897fa725e3d52373ce1();
result.InnerFromArray(array);
    return result;
}

public static RL_974e629f62892897fa725e3d52373ce1 ToList<T>(T[] array, Func <T, RC_7925a19e6fd0a09e9058a96c7f19b104> converter) {
  RL_974e629f62892897fa725e3d52373ce1 result = new RL_974e629f62892897fa725e3d52373ce1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_974e629f62892897fa725e3d52373ce1 FromRestList<T>(RestList<T> restList, Func <T, RC_7925a19e6fd0a09e9058a96c7f19b104> converter) {
  RL_974e629f62892897fa725e3d52373ce1 result = new RL_974e629f62892897fa725e3d52373ce1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_974e629f62892897fa725e3d52373ce1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7925a19e6fd0a09e9058a96c7f19b104> NewList() {
return new RL_974e629f62892897fa725e3d52373ce1();
}


} // RL_974e629f62892897fa725e3d52373ce1
}

