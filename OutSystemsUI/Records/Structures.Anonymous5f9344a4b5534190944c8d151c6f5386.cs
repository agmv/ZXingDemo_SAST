namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (pESTX1O1kEGUTI0VHG9Thg)
///  <code>RC_b6adbbf4e08bad2975a6f8f796279b71</code> that represents <code>ColumnBreakRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ColumnBreakRecord
public partial struct RC_b6adbbf4e08bad2975a6f8f796279b71 : ITypedRecord<RC_b6adbbf4e08bad2975a6f8f796279b71> {
internal static readonly GlobalObjectKey IdColumnBreak = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9LuttovgKa11pvj3liebcQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ColumnBreak")]
public EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord ssENColumnBreak;


public static implicit operator EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord( RC_b6adbbf4e08bad2975a6f8f796279b71 r) {
return r.ssENColumnBreak;
}

public static implicit operator RC_b6adbbf4e08bad2975a6f8f796279b71 (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord r) {
RC_b6adbbf4e08bad2975a6f8f796279b71 res = new RC_b6adbbf4e08bad2975a6f8f796279b71 ();
res.ssENColumnBreak = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENColumnBreak.ChangedAttributes = value;
}
get {
    return ssENColumnBreak.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b6adbbf4e08bad2975a6f8f796279b71() {
OptimizedAttributes = null;
ssENColumnBreak = new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENColumnBreak.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENColumnBreak.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENColumnBreak.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENColumnBreak.Read( r, ref index);
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
public void ReadIM(RC_b6adbbf4e08bad2975a6f8f796279b71 r) {
this = r;
}


public static bool operator == (RC_b6adbbf4e08bad2975a6f8f796279b71 a, RC_b6adbbf4e08bad2975a6f8f796279b71 b) {
if (a.ssENColumnBreak != b.ssENColumnBreak) return false;
return true;
}

public static bool operator != (RC_b6adbbf4e08bad2975a6f8f796279b71 a, RC_b6adbbf4e08bad2975a6f8f796279b71 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b6adbbf4e08bad2975a6f8f796279b71)) return false;
return (this == (RC_b6adbbf4e08bad2975a6f8f796279b71)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENColumnBreak.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENColumnBreak.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENColumnBreak.InternalRecursiveSave();
}


public RC_b6adbbf4e08bad2975a6f8f796279b71 Duplicate() {
RC_b6adbbf4e08bad2975a6f8f796279b71 t;
t.ssENColumnBreak = (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord)this.ssENColumnBreak.Duplicate();
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
if (head == "columnbreak") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ColumnBreak")) variable.Value = ssENColumnBreak; else variable.Optimized = true;
variable.SetFieldName("columnbreak");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENColumnBreak.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENColumnBreak.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdColumnBreak) {
return ssENColumnBreak;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColumnBreak.Key.AsGuid) {
return ssENColumnBreak;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENColumnBreak.FillFromOther((IRecord) other.AttributeGet(IdColumnBreak));
}
} // RC_b6adbbf4e08bad2975a6f8f796279b71
/// <summary>
/// RecordList type <code>ColumnBreakRecordList</code> that represents a record list of
///  <code>ColumnBreak</code>
/// </summary>
public partial class RL_b2003a063523641b68ecff9e50755bc3 : GenericRecordList<RC_b6adbbf4e08bad2975a6f8f796279b71>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b6adbbf4e08bad2975a6f8f796279b71 GetElementDefaultValue() {
return new RC_b6adbbf4e08bad2975a6f8f796279b71();
}

public T[] ToArray<T>(Func<RC_b6adbbf4e08bad2975a6f8f796279b71, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b2003a063523641b68ecff9e50755bc3 recordList, Func<RC_b6adbbf4e08bad2975a6f8f796279b71, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b2003a063523641b68ecff9e50755bc3(RC_b6adbbf4e08bad2975a6f8f796279b71[] array) {
  RL_b2003a063523641b68ecff9e50755bc3 result = new RL_b2003a063523641b68ecff9e50755bc3();
result.InnerFromArray(array);
    return result;
}

public static RL_b2003a063523641b68ecff9e50755bc3 ToList<T>(T[] array, Func <T, RC_b6adbbf4e08bad2975a6f8f796279b71> converter) {
  RL_b2003a063523641b68ecff9e50755bc3 result = new RL_b2003a063523641b68ecff9e50755bc3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b2003a063523641b68ecff9e50755bc3 FromRestList<T>(RestList<T> restList, Func <T, RC_b6adbbf4e08bad2975a6f8f796279b71> converter) {
  RL_b2003a063523641b68ecff9e50755bc3 result = new RL_b2003a063523641b68ecff9e50755bc3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b2003a063523641b68ecff9e50755bc3() : base() {
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
protected override OSList<RC_b6adbbf4e08bad2975a6f8f796279b71> NewList() {
return new RL_b2003a063523641b68ecff9e50755bc3();
}


} // RL_b2003a063523641b68ecff9e50755bc3
}

