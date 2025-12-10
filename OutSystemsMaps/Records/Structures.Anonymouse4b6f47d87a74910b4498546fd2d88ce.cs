namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (ffS25KeHEEm0SYVG_S2Izg)
///  <code>RC_2e794e9950648fb781740aa3223ba10d</code> that represents <code>StaticMarkerRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StaticMarkerRecord
public partial struct RC_2e794e9950648fb781740aa3223ba10d : ITypedRecord<RC_2e794e9950648fb781740aa3223ba10d> {
internal static readonly GlobalObjectKey IdStaticMarker = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mU55LmRQt4+BdAqjIjuhDQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StaticMarker")]
public ST_832344699c82a4f799a423f89bbe7297Structure ssSTStaticMarker;


public static implicit operator ST_832344699c82a4f799a423f89bbe7297Structure( RC_2e794e9950648fb781740aa3223ba10d r) {
return r.ssSTStaticMarker;
}

public static implicit operator RC_2e794e9950648fb781740aa3223ba10d (ST_832344699c82a4f799a423f89bbe7297Structure r) {
RC_2e794e9950648fb781740aa3223ba10d res = new RC_2e794e9950648fb781740aa3223ba10d ();
res.ssSTStaticMarker = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2e794e9950648fb781740aa3223ba10d() {
OptimizedAttributes = null;
ssSTStaticMarker = new ST_832344699c82a4f799a423f89bbe7297Structure();
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
    ssSTStaticMarker.OptimizedAttributes = value[0];
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
ssSTStaticMarker.Read( r, ref index);
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
public void ReadIM(RC_2e794e9950648fb781740aa3223ba10d r) {
this = r;
}


public static bool operator == (RC_2e794e9950648fb781740aa3223ba10d a, RC_2e794e9950648fb781740aa3223ba10d b) {
if (a.ssSTStaticMarker != b.ssSTStaticMarker) return false;
return true;
}

public static bool operator != (RC_2e794e9950648fb781740aa3223ba10d a, RC_2e794e9950648fb781740aa3223ba10d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2e794e9950648fb781740aa3223ba10d)) return false;
return (this == (RC_2e794e9950648fb781740aa3223ba10d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStaticMarker.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStaticMarker.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStaticMarker.InternalRecursiveSave();
}


public RC_2e794e9950648fb781740aa3223ba10d Duplicate() {
RC_2e794e9950648fb781740aa3223ba10d t;
t.ssSTStaticMarker = (ST_832344699c82a4f799a423f89bbe7297Structure)this.ssSTStaticMarker.Duplicate();
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
if (head == "staticmarker") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StaticMarker")) variable.Value = ssSTStaticMarker; else variable.Optimized = true;
variable.SetFieldName("staticmarker");
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
if (key == IdStaticMarker) {
return ssSTStaticMarker;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStaticMarker.Key.AsGuid) {
return ssSTStaticMarker;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStaticMarker.FillFromOther((IRecord) other.AttributeGet(IdStaticMarker));
}
} // RC_2e794e9950648fb781740aa3223ba10d
/// <summary>
/// RecordList type <code>StaticMarkerRecordList</code> that represents a record list of
///  <code>StaticMarker</code>
/// </summary>
public partial class RL_fa6777019e2dac1120f9271e79b32cf7 : GenericRecordList<RC_2e794e9950648fb781740aa3223ba10d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2e794e9950648fb781740aa3223ba10d GetElementDefaultValue() {
return new RC_2e794e9950648fb781740aa3223ba10d();
}

public T[] ToArray<T>(Func<RC_2e794e9950648fb781740aa3223ba10d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fa6777019e2dac1120f9271e79b32cf7 recordList, Func<RC_2e794e9950648fb781740aa3223ba10d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fa6777019e2dac1120f9271e79b32cf7(RC_2e794e9950648fb781740aa3223ba10d[] array) {
  RL_fa6777019e2dac1120f9271e79b32cf7 result = new RL_fa6777019e2dac1120f9271e79b32cf7();
result.InnerFromArray(array);
    return result;
}

public static RL_fa6777019e2dac1120f9271e79b32cf7 ToList<T>(T[] array, Func <T, RC_2e794e9950648fb781740aa3223ba10d> converter) {
  RL_fa6777019e2dac1120f9271e79b32cf7 result = new RL_fa6777019e2dac1120f9271e79b32cf7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fa6777019e2dac1120f9271e79b32cf7 FromRestList<T>(RestList<T> restList, Func <T, RC_2e794e9950648fb781740aa3223ba10d> converter) {
  RL_fa6777019e2dac1120f9271e79b32cf7 result = new RL_fa6777019e2dac1120f9271e79b32cf7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fa6777019e2dac1120f9271e79b32cf7() : base() {
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
protected override OSList<RC_2e794e9950648fb781740aa3223ba10d> NewList() {
return new RL_fa6777019e2dac1120f9271e79b32cf7();
}


} // RL_fa6777019e2dac1120f9271e79b32cf7
}

