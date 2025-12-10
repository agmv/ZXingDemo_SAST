namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Na4TydQ9R0SNY8CO7Psn+Q)
///  <code>RC_6cdb4a5361f01d77ad1b8152ec45fc2a</code> that represents <code>AuthorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AuthorRecord
public partial struct RC_6cdb4a5361f01d77ad1b8152ec45fc2a : ITypedRecord<RC_6cdb4a5361f01d77ad1b8152ec45fc2a> {
internal static readonly GlobalObjectKey IdAuthor = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U0rbbPBhdx2tG4FS7EX8Kg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Author")]
public ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure ssSTAuthor;


public static implicit operator ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure( RC_6cdb4a5361f01d77ad1b8152ec45fc2a r) {
return r.ssSTAuthor;
}

public static implicit operator RC_6cdb4a5361f01d77ad1b8152ec45fc2a (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure r) {
RC_6cdb4a5361f01d77ad1b8152ec45fc2a res = new RC_6cdb4a5361f01d77ad1b8152ec45fc2a ();
res.ssSTAuthor = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6cdb4a5361f01d77ad1b8152ec45fc2a() {
OptimizedAttributes = null;
ssSTAuthor = new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure();
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
    ssSTAuthor.OptimizedAttributes = value[0];
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
ssSTAuthor.Read( r, ref index);
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
public void ReadIM(RC_6cdb4a5361f01d77ad1b8152ec45fc2a r) {
this = r;
}


public static bool operator == (RC_6cdb4a5361f01d77ad1b8152ec45fc2a a, RC_6cdb4a5361f01d77ad1b8152ec45fc2a b) {
if (a.ssSTAuthor != b.ssSTAuthor) return false;
return true;
}

public static bool operator != (RC_6cdb4a5361f01d77ad1b8152ec45fc2a a, RC_6cdb4a5361f01d77ad1b8152ec45fc2a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6cdb4a5361f01d77ad1b8152ec45fc2a)) return false;
return (this == (RC_6cdb4a5361f01d77ad1b8152ec45fc2a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAuthor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAuthor.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAuthor.InternalRecursiveSave();
}


public RC_6cdb4a5361f01d77ad1b8152ec45fc2a Duplicate() {
RC_6cdb4a5361f01d77ad1b8152ec45fc2a t;
t.ssSTAuthor = (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure)this.ssSTAuthor.Duplicate();
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
if (head == "author") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Author")) variable.Value = ssSTAuthor; else variable.Optimized = true;
variable.SetFieldName("author");
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
if (key == IdAuthor) {
return ssSTAuthor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAuthor.Key.AsGuid) {
return ssSTAuthor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAuthor.FillFromOther((IRecord) other.AttributeGet(IdAuthor));
}
} // RC_6cdb4a5361f01d77ad1b8152ec45fc2a
/// <summary>
/// RecordList type <code>AuthorRecordList</code> that represents a record list of <code>Author</code>
/// </summary>
public partial class RL_4be67e3d3448f372fc9ddf138a8d2ee2 : GenericRecordList<RC_6cdb4a5361f01d77ad1b8152ec45fc2a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_6cdb4a5361f01d77ad1b8152ec45fc2a GetElementDefaultValue() {
return new RC_6cdb4a5361f01d77ad1b8152ec45fc2a();
}

public T[] ToArray<T>(Func<RC_6cdb4a5361f01d77ad1b8152ec45fc2a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4be67e3d3448f372fc9ddf138a8d2ee2 recordList, Func<RC_6cdb4a5361f01d77ad1b8152ec45fc2a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4be67e3d3448f372fc9ddf138a8d2ee2(RC_6cdb4a5361f01d77ad1b8152ec45fc2a[] array) {
  RL_4be67e3d3448f372fc9ddf138a8d2ee2 result = new RL_4be67e3d3448f372fc9ddf138a8d2ee2();
result.InnerFromArray(array);
    return result;
}

public static RL_4be67e3d3448f372fc9ddf138a8d2ee2 ToList<T>(T[] array, Func <T, RC_6cdb4a5361f01d77ad1b8152ec45fc2a> converter) {
  RL_4be67e3d3448f372fc9ddf138a8d2ee2 result = new RL_4be67e3d3448f372fc9ddf138a8d2ee2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4be67e3d3448f372fc9ddf138a8d2ee2 FromRestList<T>(RestList<T> restList, Func <T, RC_6cdb4a5361f01d77ad1b8152ec45fc2a> converter) {
  RL_4be67e3d3448f372fc9ddf138a8d2ee2 result = new RL_4be67e3d3448f372fc9ddf138a8d2ee2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4be67e3d3448f372fc9ddf138a8d2ee2() : base() {
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
protected override OSList<RC_6cdb4a5361f01d77ad1b8152ec45fc2a> NewList() {
return new RL_4be67e3d3448f372fc9ddf138a8d2ee2();
}


} // RL_4be67e3d3448f372fc9ddf138a8d2ee2
}

