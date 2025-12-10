namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (mDcpVtXgP0SXN7BHMM85OQ)
///  <code>RC_b6f4f6f58cf9d7e93da0322d7951765a</code> that represent
/// s <code>ProgressCircle_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: ProgressCircle_InternalConfigRecord
public partial struct RC_b6f4f6f58cf9d7e93da0322d7951765a : ITypedRecord<RC_b6f4f6f58cf9d7e93da0322d7951765a> {
internal static readonly GlobalObjectKey IdProgressCircle_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9fb0tvmM6dc9oDIteVF2Wg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProgressCircle_InternalConfig")]
public ST_2fd97622d01b72b1af62467b00f1da8eStructure ssSTProgressCircle_InternalConfig;


public static implicit operator ST_2fd97622d01b72b1af62467b00f1da8eStructure( RC_b6f4f6f58cf9d7e93da0322d7951765a r) {
return r.ssSTProgressCircle_InternalConfig;
}

public static implicit operator RC_b6f4f6f58cf9d7e93da0322d7951765a (ST_2fd97622d01b72b1af62467b00f1da8eStructure r) {
RC_b6f4f6f58cf9d7e93da0322d7951765a res = new RC_b6f4f6f58cf9d7e93da0322d7951765a ();
res.ssSTProgressCircle_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b6f4f6f58cf9d7e93da0322d7951765a() {
OptimizedAttributes = null;
ssSTProgressCircle_InternalConfig = new ST_2fd97622d01b72b1af62467b00f1da8eStructure();
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
    ssSTProgressCircle_InternalConfig.OptimizedAttributes = value[0];
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
ssSTProgressCircle_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_b6f4f6f58cf9d7e93da0322d7951765a r) {
this = r;
}


public static bool operator == (RC_b6f4f6f58cf9d7e93da0322d7951765a a, RC_b6f4f6f58cf9d7e93da0322d7951765a b) {
if (a.ssSTProgressCircle_InternalConfig != b.ssSTProgressCircle_InternalConfig) return false;
return true;
}

public static bool operator != (RC_b6f4f6f58cf9d7e93da0322d7951765a a, RC_b6f4f6f58cf9d7e93da0322d7951765a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b6f4f6f58cf9d7e93da0322d7951765a)) return false;
return (this == (RC_b6f4f6f58cf9d7e93da0322d7951765a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTProgressCircle_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTProgressCircle_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTProgressCircle_InternalConfig.InternalRecursiveSave();
}


public RC_b6f4f6f58cf9d7e93da0322d7951765a Duplicate() {
RC_b6f4f6f58cf9d7e93da0322d7951765a t;
t.ssSTProgressCircle_InternalConfig = (ST_2fd97622d01b72b1af62467b00f1da8eStructure)this.ssSTProgressCircle_InternalConfig.Duplicate();
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
if (head == "progresscircle_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressCircle_InternalConfig")) variable.Value = ssSTProgressCircle_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("progresscircle_internalconfig");
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
if (key == IdProgressCircle_InternalConfig) {
return ssSTProgressCircle_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProgressCircle_InternalConfig.Key.AsGuid) {
return ssSTProgressCircle_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTProgressCircle_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdProgressCircle_InternalConfig));
}
} // RC_b6f4f6f58cf9d7e93da0322d7951765a
/// <summary>
/// RecordList type <code>ProgressCircle_InternalConfigRecordList</code> that represents a record list
///  of <code>ProgressCircle_InternalConfig</code>
/// </summary>
public partial class RL_12ed4bb13edbb334bdf47b5f3e8430f7 : GenericRecordList<RC_b6f4f6f58cf9d7e93da0322d7951765a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b6f4f6f58cf9d7e93da0322d7951765a GetElementDefaultValue() {
return new RC_b6f4f6f58cf9d7e93da0322d7951765a();
}

public T[] ToArray<T>(Func<RC_b6f4f6f58cf9d7e93da0322d7951765a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_12ed4bb13edbb334bdf47b5f3e8430f7 recordList, Func<RC_b6f4f6f58cf9d7e93da0322d7951765a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_12ed4bb13edbb334bdf47b5f3e8430f7(RC_b6f4f6f58cf9d7e93da0322d7951765a[] array) {
  RL_12ed4bb13edbb334bdf47b5f3e8430f7 result = new RL_12ed4bb13edbb334bdf47b5f3e8430f7();
result.InnerFromArray(array);
    return result;
}

public static RL_12ed4bb13edbb334bdf47b5f3e8430f7 ToList<T>(T[] array, Func <T, RC_b6f4f6f58cf9d7e93da0322d7951765a> converter) {
  RL_12ed4bb13edbb334bdf47b5f3e8430f7 result = new RL_12ed4bb13edbb334bdf47b5f3e8430f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_12ed4bb13edbb334bdf47b5f3e8430f7 FromRestList<T>(RestList<T> restList, Func <T, RC_b6f4f6f58cf9d7e93da0322d7951765a> converter) {
  RL_12ed4bb13edbb334bdf47b5f3e8430f7 result = new RL_12ed4bb13edbb334bdf47b5f3e8430f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_12ed4bb13edbb334bdf47b5f3e8430f7() : base() {
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
protected override OSList<RC_b6f4f6f58cf9d7e93da0322d7951765a> NewList() {
return new RL_12ed4bb13edbb334bdf47b5f3e8430f7();
}


} // RL_12ed4bb13edbb334bdf47b5f3e8430f7
}

