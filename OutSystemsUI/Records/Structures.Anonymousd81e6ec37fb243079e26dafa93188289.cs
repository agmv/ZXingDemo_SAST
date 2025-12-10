namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (w24e2LJ_B0OeJtr6kxiCiQ)
///  <code>RC_12cb0160c5b908b286f2418f6f00a5eb</code> that represent
/// s <code>ProgressBar_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: ProgressBar_InternalConfigRecord
public partial struct RC_12cb0160c5b908b286f2418f6f00a5eb : ITypedRecord<RC_12cb0160c5b908b286f2418f6f00a5eb> {
internal static readonly GlobalObjectKey IdProgressBar_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YAHLErnFsgiG8kGPbwCl6w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProgressBar_InternalConfig")]
public ST_b29bdecfa7956bb3d5bee97678e39fb0Structure ssSTProgressBar_InternalConfig;


public static implicit operator ST_b29bdecfa7956bb3d5bee97678e39fb0Structure( RC_12cb0160c5b908b286f2418f6f00a5eb r) {
return r.ssSTProgressBar_InternalConfig;
}

public static implicit operator RC_12cb0160c5b908b286f2418f6f00a5eb (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure r) {
RC_12cb0160c5b908b286f2418f6f00a5eb res = new RC_12cb0160c5b908b286f2418f6f00a5eb ();
res.ssSTProgressBar_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_12cb0160c5b908b286f2418f6f00a5eb() {
OptimizedAttributes = null;
ssSTProgressBar_InternalConfig = new ST_b29bdecfa7956bb3d5bee97678e39fb0Structure();
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
    ssSTProgressBar_InternalConfig.OptimizedAttributes = value[0];
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
ssSTProgressBar_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_12cb0160c5b908b286f2418f6f00a5eb r) {
this = r;
}


public static bool operator == (RC_12cb0160c5b908b286f2418f6f00a5eb a, RC_12cb0160c5b908b286f2418f6f00a5eb b) {
if (a.ssSTProgressBar_InternalConfig != b.ssSTProgressBar_InternalConfig) return false;
return true;
}

public static bool operator != (RC_12cb0160c5b908b286f2418f6f00a5eb a, RC_12cb0160c5b908b286f2418f6f00a5eb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_12cb0160c5b908b286f2418f6f00a5eb)) return false;
return (this == (RC_12cb0160c5b908b286f2418f6f00a5eb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTProgressBar_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTProgressBar_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTProgressBar_InternalConfig.InternalRecursiveSave();
}


public RC_12cb0160c5b908b286f2418f6f00a5eb Duplicate() {
RC_12cb0160c5b908b286f2418f6f00a5eb t;
t.ssSTProgressBar_InternalConfig = (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure)this.ssSTProgressBar_InternalConfig.Duplicate();
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
if (head == "progressbar_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressBar_InternalConfig")) variable.Value = ssSTProgressBar_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("progressbar_internalconfig");
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
if (key == IdProgressBar_InternalConfig) {
return ssSTProgressBar_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProgressBar_InternalConfig.Key.AsGuid) {
return ssSTProgressBar_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTProgressBar_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdProgressBar_InternalConfig));
}
} // RC_12cb0160c5b908b286f2418f6f00a5eb
/// <summary>
/// RecordList type <code>ProgressBar_InternalConfigRecordList</code> that represents a record list of
///  <code>ProgressBar_InternalConfig</code>
/// </summary>
public partial class RL_813e0996d705e3c45deaefe05bef3a22 : GenericRecordList<RC_12cb0160c5b908b286f2418f6f00a5eb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_12cb0160c5b908b286f2418f6f00a5eb GetElementDefaultValue() {
return new RC_12cb0160c5b908b286f2418f6f00a5eb();
}

public T[] ToArray<T>(Func<RC_12cb0160c5b908b286f2418f6f00a5eb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_813e0996d705e3c45deaefe05bef3a22 recordList, Func<RC_12cb0160c5b908b286f2418f6f00a5eb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_813e0996d705e3c45deaefe05bef3a22(RC_12cb0160c5b908b286f2418f6f00a5eb[] array) {
  RL_813e0996d705e3c45deaefe05bef3a22 result = new RL_813e0996d705e3c45deaefe05bef3a22();
result.InnerFromArray(array);
    return result;
}

public static RL_813e0996d705e3c45deaefe05bef3a22 ToList<T>(T[] array, Func <T, RC_12cb0160c5b908b286f2418f6f00a5eb> converter) {
  RL_813e0996d705e3c45deaefe05bef3a22 result = new RL_813e0996d705e3c45deaefe05bef3a22();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_813e0996d705e3c45deaefe05bef3a22 FromRestList<T>(RestList<T> restList, Func <T, RC_12cb0160c5b908b286f2418f6f00a5eb> converter) {
  RL_813e0996d705e3c45deaefe05bef3a22 result = new RL_813e0996d705e3c45deaefe05bef3a22();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_813e0996d705e3c45deaefe05bef3a22() : base() {
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
protected override OSList<RC_12cb0160c5b908b286f2418f6f00a5eb> NewList() {
return new RL_813e0996d705e3c45deaefe05bef3a22();
}


} // RL_813e0996d705e3c45deaefe05bef3a22
}

