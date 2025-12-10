namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (qtJZrvKq6k6PzliTU_12lQ)
///  <code>RC_b31d17ba3ccc14eaadd4d2faf9371f2d</code> that represent
/// s <code>DropdownProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownProviderRecord
public partial struct RC_b31d17ba3ccc14eaadd4d2faf9371f2d : ITypedRecord<RC_b31d17ba3ccc14eaadd4d2faf9371f2d> {
internal static readonly GlobalObjectKey IdDropdownProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uhcds8w86hSt1NL6+TcfLQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownProvider")]
public EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord ssENDropdownProvider;


public static implicit operator EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord( RC_b31d17ba3ccc14eaadd4d2faf9371f2d r) {
return r.ssENDropdownProvider;
}

public static implicit operator RC_b31d17ba3ccc14eaadd4d2faf9371f2d (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord r) {
RC_b31d17ba3ccc14eaadd4d2faf9371f2d res = new RC_b31d17ba3ccc14eaadd4d2faf9371f2d ();
res.ssENDropdownProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDropdownProvider.ChangedAttributes = value;
}
get {
    return ssENDropdownProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b31d17ba3ccc14eaadd4d2faf9371f2d() {
OptimizedAttributes = null;
ssENDropdownProvider = new EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDropdownProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDropdownProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDropdownProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDropdownProvider.Read( r, ref index);
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
public void ReadIM(RC_b31d17ba3ccc14eaadd4d2faf9371f2d r) {
this = r;
}


public static bool operator == (RC_b31d17ba3ccc14eaadd4d2faf9371f2d a, RC_b31d17ba3ccc14eaadd4d2faf9371f2d b) {
if (a.ssENDropdownProvider != b.ssENDropdownProvider) return false;
return true;
}

public static bool operator != (RC_b31d17ba3ccc14eaadd4d2faf9371f2d a, RC_b31d17ba3ccc14eaadd4d2faf9371f2d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b31d17ba3ccc14eaadd4d2faf9371f2d)) return false;
return (this == (RC_b31d17ba3ccc14eaadd4d2faf9371f2d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDropdownProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDropdownProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDropdownProvider.InternalRecursiveSave();
}


public RC_b31d17ba3ccc14eaadd4d2faf9371f2d Duplicate() {
RC_b31d17ba3ccc14eaadd4d2faf9371f2d t;
t.ssENDropdownProvider = (EN_1f7daead8658b6d9bc2681468edc5e3fEntityRecord)this.ssENDropdownProvider.Duplicate();
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
if (head == "dropdownprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownProvider")) variable.Value = ssENDropdownProvider; else variable.Optimized = true;
variable.SetFieldName("dropdownprovider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDropdownProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDropdownProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDropdownProvider) {
return ssENDropdownProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownProvider.Key.AsGuid) {
return ssENDropdownProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDropdownProvider.FillFromOther((IRecord) other.AttributeGet(IdDropdownProvider));
}
} // RC_b31d17ba3ccc14eaadd4d2faf9371f2d
/// <summary>
/// RecordList type <code>DropdownProviderRecordList</code> that represents a record list of
///  <code>DropdownProvider</code>
/// </summary>
public partial class RL_a4d3e7059d940ae293c84c03c23eb5be : GenericRecordList<RC_b31d17ba3ccc14eaadd4d2faf9371f2d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b31d17ba3ccc14eaadd4d2faf9371f2d GetElementDefaultValue() {
return new RC_b31d17ba3ccc14eaadd4d2faf9371f2d();
}

public T[] ToArray<T>(Func<RC_b31d17ba3ccc14eaadd4d2faf9371f2d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a4d3e7059d940ae293c84c03c23eb5be recordList, Func<RC_b31d17ba3ccc14eaadd4d2faf9371f2d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a4d3e7059d940ae293c84c03c23eb5be(RC_b31d17ba3ccc14eaadd4d2faf9371f2d[] array) {
  RL_a4d3e7059d940ae293c84c03c23eb5be result = new RL_a4d3e7059d940ae293c84c03c23eb5be();
result.InnerFromArray(array);
    return result;
}

public static RL_a4d3e7059d940ae293c84c03c23eb5be ToList<T>(T[] array, Func <T, RC_b31d17ba3ccc14eaadd4d2faf9371f2d> converter) {
  RL_a4d3e7059d940ae293c84c03c23eb5be result = new RL_a4d3e7059d940ae293c84c03c23eb5be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a4d3e7059d940ae293c84c03c23eb5be FromRestList<T>(RestList<T> restList, Func <T, RC_b31d17ba3ccc14eaadd4d2faf9371f2d> converter) {
  RL_a4d3e7059d940ae293c84c03c23eb5be result = new RL_a4d3e7059d940ae293c84c03c23eb5be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a4d3e7059d940ae293c84c03c23eb5be() : base() {
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
protected override OSList<RC_b31d17ba3ccc14eaadd4d2faf9371f2d> NewList() {
return new RL_a4d3e7059d940ae293c84c03c23eb5be();
}


} // RL_a4d3e7059d940ae293c84c03c23eb5be
}

