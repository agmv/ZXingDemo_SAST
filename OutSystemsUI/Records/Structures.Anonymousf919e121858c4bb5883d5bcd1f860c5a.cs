namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (IeEZ+YyFtUuIPVvNH4YMWg)
///  <code>RC_7f56ea63061432843ab4dd16f4578b32</code> that represents <code>DropdownTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DropdownTypeRecord
public partial struct RC_7f56ea63061432843ab4dd16f4578b32 : ITypedRecord<RC_7f56ea63061432843ab4dd16f4578b32> {
internal static readonly GlobalObjectKey IdDropdownType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y+pWfxQGhDI6tN0W9FeLMg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownType")]
public EN_7a28bfa00272cf999603d060780d47ecEntityRecord ssENDropdownType;


public static implicit operator EN_7a28bfa00272cf999603d060780d47ecEntityRecord( RC_7f56ea63061432843ab4dd16f4578b32 r) {
return r.ssENDropdownType;
}

public static implicit operator RC_7f56ea63061432843ab4dd16f4578b32 (EN_7a28bfa00272cf999603d060780d47ecEntityRecord r) {
RC_7f56ea63061432843ab4dd16f4578b32 res = new RC_7f56ea63061432843ab4dd16f4578b32 ();
res.ssENDropdownType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDropdownType.ChangedAttributes = value;
}
get {
    return ssENDropdownType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_7f56ea63061432843ab4dd16f4578b32() {
OptimizedAttributes = null;
ssENDropdownType = new EN_7a28bfa00272cf999603d060780d47ecEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDropdownType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDropdownType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDropdownType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDropdownType.Read( r, ref index);
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
public void ReadIM(RC_7f56ea63061432843ab4dd16f4578b32 r) {
this = r;
}


public static bool operator == (RC_7f56ea63061432843ab4dd16f4578b32 a, RC_7f56ea63061432843ab4dd16f4578b32 b) {
if (a.ssENDropdownType != b.ssENDropdownType) return false;
return true;
}

public static bool operator != (RC_7f56ea63061432843ab4dd16f4578b32 a, RC_7f56ea63061432843ab4dd16f4578b32 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7f56ea63061432843ab4dd16f4578b32)) return false;
return (this == (RC_7f56ea63061432843ab4dd16f4578b32)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDropdownType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDropdownType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDropdownType.InternalRecursiveSave();
}


public RC_7f56ea63061432843ab4dd16f4578b32 Duplicate() {
RC_7f56ea63061432843ab4dd16f4578b32 t;
t.ssENDropdownType = (EN_7a28bfa00272cf999603d060780d47ecEntityRecord)this.ssENDropdownType.Duplicate();
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
if (head == "dropdowntype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownType")) variable.Value = ssENDropdownType; else variable.Optimized = true;
variable.SetFieldName("dropdowntype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDropdownType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDropdownType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDropdownType) {
return ssENDropdownType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownType.Key.AsGuid) {
return ssENDropdownType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDropdownType.FillFromOther((IRecord) other.AttributeGet(IdDropdownType));
}
} // RC_7f56ea63061432843ab4dd16f4578b32
/// <summary>
/// RecordList type <code>DropdownTypeRecordList</code> that represents a record list of
///  <code>DropdownType</code>
/// </summary>
public partial class RL_f40eb24837dbd8351714c4d6350d54cb : GenericRecordList<RC_7f56ea63061432843ab4dd16f4578b32>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7f56ea63061432843ab4dd16f4578b32 GetElementDefaultValue() {
return new RC_7f56ea63061432843ab4dd16f4578b32();
}

public T[] ToArray<T>(Func<RC_7f56ea63061432843ab4dd16f4578b32, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f40eb24837dbd8351714c4d6350d54cb recordList, Func<RC_7f56ea63061432843ab4dd16f4578b32, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f40eb24837dbd8351714c4d6350d54cb(RC_7f56ea63061432843ab4dd16f4578b32[] array) {
  RL_f40eb24837dbd8351714c4d6350d54cb result = new RL_f40eb24837dbd8351714c4d6350d54cb();
result.InnerFromArray(array);
    return result;
}

public static RL_f40eb24837dbd8351714c4d6350d54cb ToList<T>(T[] array, Func <T, RC_7f56ea63061432843ab4dd16f4578b32> converter) {
  RL_f40eb24837dbd8351714c4d6350d54cb result = new RL_f40eb24837dbd8351714c4d6350d54cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f40eb24837dbd8351714c4d6350d54cb FromRestList<T>(RestList<T> restList, Func <T, RC_7f56ea63061432843ab4dd16f4578b32> converter) {
  RL_f40eb24837dbd8351714c4d6350d54cb result = new RL_f40eb24837dbd8351714c4d6350d54cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f40eb24837dbd8351714c4d6350d54cb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7f56ea63061432843ab4dd16f4578b32> NewList() {
return new RL_f40eb24837dbd8351714c4d6350d54cb();
}


} // RL_f40eb24837dbd8351714c4d6350d54cb
}

