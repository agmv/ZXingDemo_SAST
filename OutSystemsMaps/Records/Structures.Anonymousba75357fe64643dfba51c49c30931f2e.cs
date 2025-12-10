namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (fzV1ukbm30O6UcScMJMfLg)
///  <code>RC_97843bcb52146db1681dfc816cff70a0</code> that represents <code>StyleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StyleRecord
public partial struct RC_97843bcb52146db1681dfc816cff70a0 : ITypedRecord<RC_97843bcb52146db1681dfc816cff70a0> {
internal static readonly GlobalObjectKey IdStyle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yzuElxRSsW1oHfyBbP9woA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Style")]
public EN_e7686de199fbd20281899419f0b6ff11EntityRecord ssENStyle;


public static implicit operator EN_e7686de199fbd20281899419f0b6ff11EntityRecord( RC_97843bcb52146db1681dfc816cff70a0 r) {
return r.ssENStyle;
}

public static implicit operator RC_97843bcb52146db1681dfc816cff70a0 (EN_e7686de199fbd20281899419f0b6ff11EntityRecord r) {
RC_97843bcb52146db1681dfc816cff70a0 res = new RC_97843bcb52146db1681dfc816cff70a0 ();
res.ssENStyle = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENStyle.ChangedAttributes = value;
}
get {
    return ssENStyle.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_97843bcb52146db1681dfc816cff70a0() {
OptimizedAttributes = null;
ssENStyle = new EN_e7686de199fbd20281899419f0b6ff11EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENStyle.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENStyle.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENStyle.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENStyle.Read( r, ref index);
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
public void ReadIM(RC_97843bcb52146db1681dfc816cff70a0 r) {
this = r;
}


public static bool operator == (RC_97843bcb52146db1681dfc816cff70a0 a, RC_97843bcb52146db1681dfc816cff70a0 b) {
if (a.ssENStyle != b.ssENStyle) return false;
return true;
}

public static bool operator != (RC_97843bcb52146db1681dfc816cff70a0 a, RC_97843bcb52146db1681dfc816cff70a0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_97843bcb52146db1681dfc816cff70a0)) return false;
return (this == (RC_97843bcb52146db1681dfc816cff70a0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENStyle.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENStyle.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENStyle.InternalRecursiveSave();
}


public RC_97843bcb52146db1681dfc816cff70a0 Duplicate() {
RC_97843bcb52146db1681dfc816cff70a0 t;
t.ssENStyle = (EN_e7686de199fbd20281899419f0b6ff11EntityRecord)this.ssENStyle.Duplicate();
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
if (head == "style") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Style")) variable.Value = ssENStyle; else variable.Optimized = true;
variable.SetFieldName("style");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENStyle.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENStyle.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdStyle) {
return ssENStyle;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStyle.Key.AsGuid) {
return ssENStyle;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENStyle.FillFromOther((IRecord) other.AttributeGet(IdStyle));
}
} // RC_97843bcb52146db1681dfc816cff70a0
/// <summary>
/// RecordList type <code>StyleRecordList</code> that represents a record list of <code>Style</code>
/// </summary>
public partial class RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 : GenericRecordList<RC_97843bcb52146db1681dfc816cff70a0>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_97843bcb52146db1681dfc816cff70a0 GetElementDefaultValue() {
return new RC_97843bcb52146db1681dfc816cff70a0();
}

public T[] ToArray<T>(Func<RC_97843bcb52146db1681dfc816cff70a0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 recordList, Func<RC_97843bcb52146db1681dfc816cff70a0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0(RC_97843bcb52146db1681dfc816cff70a0[] array) {
  RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 result = new RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0();
result.InnerFromArray(array);
    return result;
}

public static RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 ToList<T>(T[] array, Func <T, RC_97843bcb52146db1681dfc816cff70a0> converter) {
  RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 result = new RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 FromRestList<T>(RestList<T> restList, Func <T, RC_97843bcb52146db1681dfc816cff70a0> converter) {
  RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0 result = new RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_97843bcb52146db1681dfc816cff70a0> NewList() {
return new RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0();
}


} // RL_1e8f93f5e9d6c1aa9b732c047fc0e7d0
}

