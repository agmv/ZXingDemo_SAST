namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (eyiZCk1+nkeBvC5qN71rnA)
///  <code>RC_3d151c63adf137bd3c85eaa462bbbe0c</code> that represents <code>MapErrorsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MapErrorsRecord
public partial struct RC_3d151c63adf137bd3c85eaa462bbbe0c : ITypedRecord<RC_3d151c63adf137bd3c85eaa462bbbe0c> {
internal static readonly GlobalObjectKey IdMapErrors = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YxwVPfGtvTc8heqkYru+DA");

public static void EnsureInitialized(){}

static RC_3d151c63adf137bd3c85eaa462bbbe0c() {
RC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("MapErrors")]
public EN_4d0e07d9538530f68924ab612d15f82bEntityRecord ssENMapErrors;


public static implicit operator EN_4d0e07d9538530f68924ab612d15f82bEntityRecord( RC_3d151c63adf137bd3c85eaa462bbbe0c r) {
return r.ssENMapErrors;
}

public static implicit operator RC_3d151c63adf137bd3c85eaa462bbbe0c (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord r) {
RC_3d151c63adf137bd3c85eaa462bbbe0c res = new RC_3d151c63adf137bd3c85eaa462bbbe0c ();
res.ssENMapErrors = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMapErrors.ChangedAttributes = value;
}
get {
    return ssENMapErrors.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3d151c63adf137bd3c85eaa462bbbe0c() {
OptimizedAttributes = null;
ssENMapErrors = new EN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMapErrors.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMapErrors.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMapErrors.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMapErrors.Read( r, ref index);
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
public void ReadIM(RC_3d151c63adf137bd3c85eaa462bbbe0c r) {
this = r;
}


public static bool operator == (RC_3d151c63adf137bd3c85eaa462bbbe0c a, RC_3d151c63adf137bd3c85eaa462bbbe0c b) {
if (a.ssENMapErrors != b.ssENMapErrors) return false;
return true;
}

public static bool operator != (RC_3d151c63adf137bd3c85eaa462bbbe0c a, RC_3d151c63adf137bd3c85eaa462bbbe0c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3d151c63adf137bd3c85eaa462bbbe0c)) return false;
return (this == (RC_3d151c63adf137bd3c85eaa462bbbe0c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMapErrors.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMapErrors.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMapErrors.InternalRecursiveSave();
}


public RC_3d151c63adf137bd3c85eaa462bbbe0c Duplicate() {
RC_3d151c63adf137bd3c85eaa462bbbe0c t;
t.ssENMapErrors = (EN_4d0e07d9538530f68924ab612d15f82bEntityRecord)this.ssENMapErrors.Duplicate();
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
if (head == "maperrors") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MapErrors")) variable.Value = ssENMapErrors; else variable.Optimized = true;
variable.SetFieldName("maperrors");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMapErrors.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMapErrors.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMapErrors) {
return ssENMapErrors;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMapErrors.Key.AsGuid) {
return ssENMapErrors;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMapErrors.FillFromOther((IRecord) other.AttributeGet(IdMapErrors));
}
} // RC_3d151c63adf137bd3c85eaa462bbbe0c
/// <summary>
/// RecordList type <code>MapErrorsRecordList</code> that represents a record list of
///  <code>MapErrors</code>
/// </summary>
public partial class RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 : GenericRecordList<RC_3d151c63adf137bd3c85eaa462bbbe0c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3d151c63adf137bd3c85eaa462bbbe0c GetElementDefaultValue() {
return new RC_3d151c63adf137bd3c85eaa462bbbe0c();
}

public T[] ToArray<T>(Func<RC_3d151c63adf137bd3c85eaa462bbbe0c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 recordList, Func<RC_3d151c63adf137bd3c85eaa462bbbe0c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_624b2d57a77bb97d27ae6a8a9d8e8ee6(RC_3d151c63adf137bd3c85eaa462bbbe0c[] array) {
  RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 result = new RL_624b2d57a77bb97d27ae6a8a9d8e8ee6();
result.InnerFromArray(array);
    return result;
}

public static RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 ToList<T>(T[] array, Func <T, RC_3d151c63adf137bd3c85eaa462bbbe0c> converter) {
  RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 result = new RL_624b2d57a77bb97d27ae6a8a9d8e8ee6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 FromRestList<T>(RestList<T> restList, Func <T, RC_3d151c63adf137bd3c85eaa462bbbe0c> converter) {
  RL_624b2d57a77bb97d27ae6a8a9d8e8ee6 result = new RL_624b2d57a77bb97d27ae6a8a9d8e8ee6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_624b2d57a77bb97d27ae6a8a9d8e8ee6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3d151c63adf137bd3c85eaa462bbbe0c> NewList() {
return new RL_624b2d57a77bb97d27ae6a8a9d8e8ee6();
}


} // RL_624b2d57a77bb97d27ae6a8a9d8e8ee6
}

