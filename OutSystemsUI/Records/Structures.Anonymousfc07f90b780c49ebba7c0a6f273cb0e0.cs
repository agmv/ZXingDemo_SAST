namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (C_kH_Ax460m6fApvJzyw4A)
///  <code>RC_5b37cd2bc5a279c3cc9b8640efcc6427</code> that represents <code>ListNavigationRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ListNavigationRecord
public partial struct RC_5b37cd2bc5a279c3cc9b8640efcc6427 : ITypedRecord<RC_5b37cd2bc5a279c3cc9b8640efcc6427> {
internal static readonly GlobalObjectKey IdListNavigation = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K803W6LFw3nMm4ZA78xkJw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ListNavigation")]
public ST_28a47f2e64dd49f0d3d29e55f70be394Structure ssSTListNavigation;


public static implicit operator ST_28a47f2e64dd49f0d3d29e55f70be394Structure( RC_5b37cd2bc5a279c3cc9b8640efcc6427 r) {
return r.ssSTListNavigation;
}

public static implicit operator RC_5b37cd2bc5a279c3cc9b8640efcc6427 (ST_28a47f2e64dd49f0d3d29e55f70be394Structure r) {
RC_5b37cd2bc5a279c3cc9b8640efcc6427 res = new RC_5b37cd2bc5a279c3cc9b8640efcc6427 ();
res.ssSTListNavigation = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5b37cd2bc5a279c3cc9b8640efcc6427() {
OptimizedAttributes = null;
ssSTListNavigation = new ST_28a47f2e64dd49f0d3d29e55f70be394Structure();
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
    ssSTListNavigation.OptimizedAttributes = value[0];
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
ssSTListNavigation.Read( r, ref index);
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
public void ReadIM(RC_5b37cd2bc5a279c3cc9b8640efcc6427 r) {
this = r;
}


public static bool operator == (RC_5b37cd2bc5a279c3cc9b8640efcc6427 a, RC_5b37cd2bc5a279c3cc9b8640efcc6427 b) {
if (a.ssSTListNavigation != b.ssSTListNavigation) return false;
return true;
}

public static bool operator != (RC_5b37cd2bc5a279c3cc9b8640efcc6427 a, RC_5b37cd2bc5a279c3cc9b8640efcc6427 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5b37cd2bc5a279c3cc9b8640efcc6427)) return false;
return (this == (RC_5b37cd2bc5a279c3cc9b8640efcc6427)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTListNavigation.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTListNavigation.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTListNavigation.InternalRecursiveSave();
}


public RC_5b37cd2bc5a279c3cc9b8640efcc6427 Duplicate() {
RC_5b37cd2bc5a279c3cc9b8640efcc6427 t;
t.ssSTListNavigation = (ST_28a47f2e64dd49f0d3d29e55f70be394Structure)this.ssSTListNavigation.Duplicate();
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
if (head == "listnavigation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ListNavigation")) variable.Value = ssSTListNavigation; else variable.Optimized = true;
variable.SetFieldName("listnavigation");
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
if (key == IdListNavigation) {
return ssSTListNavigation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdListNavigation.Key.AsGuid) {
return ssSTListNavigation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTListNavigation.FillFromOther((IRecord) other.AttributeGet(IdListNavigation));
}
} // RC_5b37cd2bc5a279c3cc9b8640efcc6427
/// <summary>
/// RecordList type <code>ListNavigationRecordList</code> that represents a record list of
///  <code>ListNavigation</code>
/// </summary>
public partial class RL_22f5579f76e7c8900c0e0ea6a0d13792 : GenericRecordList<RC_5b37cd2bc5a279c3cc9b8640efcc6427>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_5b37cd2bc5a279c3cc9b8640efcc6427 GetElementDefaultValue() {
return new RC_5b37cd2bc5a279c3cc9b8640efcc6427();
}

public T[] ToArray<T>(Func<RC_5b37cd2bc5a279c3cc9b8640efcc6427, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_22f5579f76e7c8900c0e0ea6a0d13792 recordList, Func<RC_5b37cd2bc5a279c3cc9b8640efcc6427, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_22f5579f76e7c8900c0e0ea6a0d13792(RC_5b37cd2bc5a279c3cc9b8640efcc6427[] array) {
  RL_22f5579f76e7c8900c0e0ea6a0d13792 result = new RL_22f5579f76e7c8900c0e0ea6a0d13792();
result.InnerFromArray(array);
    return result;
}

public static RL_22f5579f76e7c8900c0e0ea6a0d13792 ToList<T>(T[] array, Func <T, RC_5b37cd2bc5a279c3cc9b8640efcc6427> converter) {
  RL_22f5579f76e7c8900c0e0ea6a0d13792 result = new RL_22f5579f76e7c8900c0e0ea6a0d13792();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_22f5579f76e7c8900c0e0ea6a0d13792 FromRestList<T>(RestList<T> restList, Func <T, RC_5b37cd2bc5a279c3cc9b8640efcc6427> converter) {
  RL_22f5579f76e7c8900c0e0ea6a0d13792 result = new RL_22f5579f76e7c8900c0e0ea6a0d13792();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_22f5579f76e7c8900c0e0ea6a0d13792() : base() {
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
protected override OSList<RC_5b37cd2bc5a279c3cc9b8640efcc6427> NewList() {
return new RL_22f5579f76e7c8900c0e0ea6a0d13792();
}


} // RL_22f5579f76e7c8900c0e0ea6a0d13792
}

