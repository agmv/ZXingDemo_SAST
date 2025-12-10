namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (_vQICzLsJUy9oQwJ9bp9Nw)
///  <code>RC_fdf568550fb18a6ec270df7466fa0d20</code> that represents <code>BoundsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: BoundsRecord
public partial struct RC_fdf568550fb18a6ec270df7466fa0d20 : ITypedRecord<RC_fdf568550fb18a6ec270df7466fa0d20> {
internal static readonly GlobalObjectKey IdBounds = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VWj1_bEPborCcN90ZvoNIA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Bounds")]
public ST_5fb6f64676b0133fcb572480a766fc9cStructure ssSTBounds;


public static implicit operator ST_5fb6f64676b0133fcb572480a766fc9cStructure( RC_fdf568550fb18a6ec270df7466fa0d20 r) {
return r.ssSTBounds;
}

public static implicit operator RC_fdf568550fb18a6ec270df7466fa0d20 (ST_5fb6f64676b0133fcb572480a766fc9cStructure r) {
RC_fdf568550fb18a6ec270df7466fa0d20 res = new RC_fdf568550fb18a6ec270df7466fa0d20 ();
res.ssSTBounds = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fdf568550fb18a6ec270df7466fa0d20() {
OptimizedAttributes = null;
ssSTBounds = new ST_5fb6f64676b0133fcb572480a766fc9cStructure();
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
    ssSTBounds.OptimizedAttributes = value[0];
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
ssSTBounds.Read( r, ref index);
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
public void ReadIM(RC_fdf568550fb18a6ec270df7466fa0d20 r) {
this = r;
}


public static bool operator == (RC_fdf568550fb18a6ec270df7466fa0d20 a, RC_fdf568550fb18a6ec270df7466fa0d20 b) {
if (a.ssSTBounds != b.ssSTBounds) return false;
return true;
}

public static bool operator != (RC_fdf568550fb18a6ec270df7466fa0d20 a, RC_fdf568550fb18a6ec270df7466fa0d20 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fdf568550fb18a6ec270df7466fa0d20)) return false;
return (this == (RC_fdf568550fb18a6ec270df7466fa0d20)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBounds.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBounds.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBounds.InternalRecursiveSave();
}


public RC_fdf568550fb18a6ec270df7466fa0d20 Duplicate() {
RC_fdf568550fb18a6ec270df7466fa0d20 t;
t.ssSTBounds = (ST_5fb6f64676b0133fcb572480a766fc9cStructure)this.ssSTBounds.Duplicate();
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
if (head == "bounds") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bounds")) variable.Value = ssSTBounds; else variable.Optimized = true;
variable.SetFieldName("bounds");
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
if (key == IdBounds) {
return ssSTBounds;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBounds.Key.AsGuid) {
return ssSTBounds;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBounds.FillFromOther((IRecord) other.AttributeGet(IdBounds));
}
} // RC_fdf568550fb18a6ec270df7466fa0d20
/// <summary>
/// RecordList type <code>BoundsRecordList</code> that represents a record list of <code>Bounds</code>
/// </summary>
public partial class RL_0e72f02e1a6410320f8b97edcbb7dcb3 : GenericRecordList<RC_fdf568550fb18a6ec270df7466fa0d20>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_fdf568550fb18a6ec270df7466fa0d20 GetElementDefaultValue() {
return new RC_fdf568550fb18a6ec270df7466fa0d20();
}

public T[] ToArray<T>(Func<RC_fdf568550fb18a6ec270df7466fa0d20, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0e72f02e1a6410320f8b97edcbb7dcb3 recordList, Func<RC_fdf568550fb18a6ec270df7466fa0d20, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0e72f02e1a6410320f8b97edcbb7dcb3(RC_fdf568550fb18a6ec270df7466fa0d20[] array) {
  RL_0e72f02e1a6410320f8b97edcbb7dcb3 result = new RL_0e72f02e1a6410320f8b97edcbb7dcb3();
result.InnerFromArray(array);
    return result;
}

public static RL_0e72f02e1a6410320f8b97edcbb7dcb3 ToList<T>(T[] array, Func <T, RC_fdf568550fb18a6ec270df7466fa0d20> converter) {
  RL_0e72f02e1a6410320f8b97edcbb7dcb3 result = new RL_0e72f02e1a6410320f8b97edcbb7dcb3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0e72f02e1a6410320f8b97edcbb7dcb3 FromRestList<T>(RestList<T> restList, Func <T, RC_fdf568550fb18a6ec270df7466fa0d20> converter) {
  RL_0e72f02e1a6410320f8b97edcbb7dcb3 result = new RL_0e72f02e1a6410320f8b97edcbb7dcb3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0e72f02e1a6410320f8b97edcbb7dcb3() : base() {
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
protected override OSList<RC_fdf568550fb18a6ec270df7466fa0d20> NewList() {
return new RL_0e72f02e1a6410320f8b97edcbb7dcb3();
}


} // RL_0e72f02e1a6410320f8b97edcbb7dcb3
}

