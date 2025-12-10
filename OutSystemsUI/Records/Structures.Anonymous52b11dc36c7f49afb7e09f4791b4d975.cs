namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (wx2xUn9sr0m34J9HkbTZdQ)
///  <code>RC_c6831d06e579de4edbcf59e128b60b13</code> that represents <code>AutoplayRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AutoplayRecord
public partial struct RC_c6831d06e579de4edbcf59e128b60b13 : ITypedRecord<RC_c6831d06e579de4edbcf59e128b60b13> {
internal static readonly GlobalObjectKey IdAutoplay = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Bh2DxnnlTt7bz1nhKLYLEw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Autoplay")]
public EN_c3a2475ae6370a2f746040280495b4a2EntityRecord ssENAutoplay;


public static implicit operator EN_c3a2475ae6370a2f746040280495b4a2EntityRecord( RC_c6831d06e579de4edbcf59e128b60b13 r) {
return r.ssENAutoplay;
}

public static implicit operator RC_c6831d06e579de4edbcf59e128b60b13 (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord r) {
RC_c6831d06e579de4edbcf59e128b60b13 res = new RC_c6831d06e579de4edbcf59e128b60b13 ();
res.ssENAutoplay = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAutoplay.ChangedAttributes = value;
}
get {
    return ssENAutoplay.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c6831d06e579de4edbcf59e128b60b13() {
OptimizedAttributes = null;
ssENAutoplay = new EN_c3a2475ae6370a2f746040280495b4a2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAutoplay.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAutoplay.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAutoplay.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAutoplay.Read( r, ref index);
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
public void ReadIM(RC_c6831d06e579de4edbcf59e128b60b13 r) {
this = r;
}


public static bool operator == (RC_c6831d06e579de4edbcf59e128b60b13 a, RC_c6831d06e579de4edbcf59e128b60b13 b) {
if (a.ssENAutoplay != b.ssENAutoplay) return false;
return true;
}

public static bool operator != (RC_c6831d06e579de4edbcf59e128b60b13 a, RC_c6831d06e579de4edbcf59e128b60b13 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c6831d06e579de4edbcf59e128b60b13)) return false;
return (this == (RC_c6831d06e579de4edbcf59e128b60b13)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAutoplay.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAutoplay.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAutoplay.InternalRecursiveSave();
}


public RC_c6831d06e579de4edbcf59e128b60b13 Duplicate() {
RC_c6831d06e579de4edbcf59e128b60b13 t;
t.ssENAutoplay = (EN_c3a2475ae6370a2f746040280495b4a2EntityRecord)this.ssENAutoplay.Duplicate();
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
if (head == "autoplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Autoplay")) variable.Value = ssENAutoplay; else variable.Optimized = true;
variable.SetFieldName("autoplay");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAutoplay.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAutoplay.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAutoplay) {
return ssENAutoplay;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAutoplay.Key.AsGuid) {
return ssENAutoplay;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAutoplay.FillFromOther((IRecord) other.AttributeGet(IdAutoplay));
}
} // RC_c6831d06e579de4edbcf59e128b60b13
/// <summary>
/// RecordList type <code>AutoplayRecordList</code> that represents a record list of
///  <code>Autoplay</code>
/// </summary>
public partial class RL_1a211c52d9450d4da06f34c1b8aa3b76 : GenericRecordList<RC_c6831d06e579de4edbcf59e128b60b13>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c6831d06e579de4edbcf59e128b60b13 GetElementDefaultValue() {
return new RC_c6831d06e579de4edbcf59e128b60b13();
}

public T[] ToArray<T>(Func<RC_c6831d06e579de4edbcf59e128b60b13, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1a211c52d9450d4da06f34c1b8aa3b76 recordList, Func<RC_c6831d06e579de4edbcf59e128b60b13, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1a211c52d9450d4da06f34c1b8aa3b76(RC_c6831d06e579de4edbcf59e128b60b13[] array) {
  RL_1a211c52d9450d4da06f34c1b8aa3b76 result = new RL_1a211c52d9450d4da06f34c1b8aa3b76();
result.InnerFromArray(array);
    return result;
}

public static RL_1a211c52d9450d4da06f34c1b8aa3b76 ToList<T>(T[] array, Func <T, RC_c6831d06e579de4edbcf59e128b60b13> converter) {
  RL_1a211c52d9450d4da06f34c1b8aa3b76 result = new RL_1a211c52d9450d4da06f34c1b8aa3b76();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1a211c52d9450d4da06f34c1b8aa3b76 FromRestList<T>(RestList<T> restList, Func <T, RC_c6831d06e579de4edbcf59e128b60b13> converter) {
  RL_1a211c52d9450d4da06f34c1b8aa3b76 result = new RL_1a211c52d9450d4da06f34c1b8aa3b76();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1a211c52d9450d4da06f34c1b8aa3b76() : base() {
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
protected override OSList<RC_c6831d06e579de4edbcf59e128b60b13> NewList() {
return new RL_1a211c52d9450d4da06f34c1b8aa3b76();
}


} // RL_1a211c52d9450d4da06f34c1b8aa3b76
}

