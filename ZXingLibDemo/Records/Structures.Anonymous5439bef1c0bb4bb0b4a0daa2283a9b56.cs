namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (8b45VLvAsEu0oNqiKDqbVg)
///  <code>RC_957e93eddd28d08c07d4a328c870138a</code> that represents <code>ComposedNameRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ComposedNameRecord
public partial struct RC_957e93eddd28d08c07d4a328c870138a : ITypedRecord<RC_957e93eddd28d08c07d4a328c870138a>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdComposedName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7ZN+lSjdjNAH1KMoyHATig");

public static void EnsureInitialized(){}

static RC_957e93eddd28d08c07d4a328c870138a() {
RC_957e93eddd28d08c07d4a328c870138aTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("ComposedName")]
public ST_2f980670f450ae43af56386ae46715c7Structure ssSTComposedName;


public static implicit operator ST_2f980670f450ae43af56386ae46715c7Structure( RC_957e93eddd28d08c07d4a328c870138a r) {
return r.ssSTComposedName;
}

public static implicit operator RC_957e93eddd28d08c07d4a328c870138a (ST_2f980670f450ae43af56386ae46715c7Structure r) {
RC_957e93eddd28d08c07d4a328c870138a res = new RC_957e93eddd28d08c07d4a328c870138a ();
res.ssSTComposedName = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_957e93eddd28d08c07d4a328c870138a() {
OptimizedAttributes = null;
ssSTComposedName = new ST_2f980670f450ae43af56386ae46715c7Structure();
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
    ssSTComposedName.OptimizedAttributes = value[0];
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
ssSTComposedName.Read( r, ref index);
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
public void ReadIM(RC_957e93eddd28d08c07d4a328c870138a r) {
this = r;
}


public static bool operator == (RC_957e93eddd28d08c07d4a328c870138a a, RC_957e93eddd28d08c07d4a328c870138a b) {
if (a.ssSTComposedName != b.ssSTComposedName) return false;
return true;
}

public static bool operator != (RC_957e93eddd28d08c07d4a328c870138a a, RC_957e93eddd28d08c07d4a328c870138a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_957e93eddd28d08c07d4a328c870138a)) return false;
return (this == (RC_957e93eddd28d08c07d4a328c870138a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTComposedName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTComposedName.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTComposedName.InternalRecursiveSave();
}


public RC_957e93eddd28d08c07d4a328c870138a Duplicate() {
RC_957e93eddd28d08c07d4a328c870138a t;
t.ssSTComposedName = (ST_2f980670f450ae43af56386ae46715c7Structure)this.ssSTComposedName.Duplicate();
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
if (head == "composedname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ComposedName")) variable.Value = ssSTComposedName; else variable.Optimized = true;
variable.SetFieldName("composedname");
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
if (key == IdComposedName) {
return ssSTComposedName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdComposedName.Key.AsGuid) {
return ssSTComposedName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTComposedName.FillFromOther((IRecord) other.AttributeGet(IdComposedName));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTComposedName.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdComposedName.Key.AsGuid));
}
} // RC_957e93eddd28d08c07d4a328c870138a
/// <summary>
/// RecordList type <code>ComposedNameRecordList</code> that represents a record list of
///  <code>ComposedName</code>
/// </summary>
public partial class RL_cafc5d628b0edf8d22dc7011568d1819 : GenericRecordList<RC_957e93eddd28d08c07d4a328c870138a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_957e93eddd28d08c07d4a328c870138a GetElementDefaultValue() {
return new RC_957e93eddd28d08c07d4a328c870138a();
}

public T[] ToArray<T>(Func<RC_957e93eddd28d08c07d4a328c870138a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cafc5d628b0edf8d22dc7011568d1819 recordList, Func<RC_957e93eddd28d08c07d4a328c870138a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cafc5d628b0edf8d22dc7011568d1819(RC_957e93eddd28d08c07d4a328c870138a[] array) {
  RL_cafc5d628b0edf8d22dc7011568d1819 result = new RL_cafc5d628b0edf8d22dc7011568d1819();
result.InnerFromArray(array);
    return result;
}

public static RL_cafc5d628b0edf8d22dc7011568d1819 ToList<T>(T[] array, Func <T, RC_957e93eddd28d08c07d4a328c870138a> converter) {
  RL_cafc5d628b0edf8d22dc7011568d1819 result = new RL_cafc5d628b0edf8d22dc7011568d1819();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cafc5d628b0edf8d22dc7011568d1819 FromRestList<T>(RestList<T> restList, Func <T, RC_957e93eddd28d08c07d4a328c870138a> converter) {
  RL_cafc5d628b0edf8d22dc7011568d1819 result = new RL_cafc5d628b0edf8d22dc7011568d1819();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cafc5d628b0edf8d22dc7011568d1819() : base() {
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
protected override OSList<RC_957e93eddd28d08c07d4a328c870138a> NewList() {
return new RL_cafc5d628b0edf8d22dc7011568d1819();
}


} // RL_cafc5d628b0edf8d22dc7011568d1819
}

