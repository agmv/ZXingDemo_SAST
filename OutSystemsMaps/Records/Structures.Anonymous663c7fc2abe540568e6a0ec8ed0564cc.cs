namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (wn88ZuWrVkCOag7I7QVkzA)
///  <code>RC_3836c6494dc01a6dca1bf0597beb32bb</code> that represent
/// s <code>OptionalPolylineConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalPolylineConfigsRecord
public partial struct RC_3836c6494dc01a6dca1bf0597beb32bb : ITypedRecord<RC_3836c6494dc01a6dca1bf0597beb32bb> {
internal static readonly GlobalObjectKey IdOptionalPolylineConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ScY2OMBNbRrKG_BZe+syuw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalPolylineConfigs")]
public ST_f85923824a33f65ded14770af5377402Structure ssSTOptionalPolylineConfigs;


public static implicit operator ST_f85923824a33f65ded14770af5377402Structure( RC_3836c6494dc01a6dca1bf0597beb32bb r) {
return r.ssSTOptionalPolylineConfigs;
}

public static implicit operator RC_3836c6494dc01a6dca1bf0597beb32bb (ST_f85923824a33f65ded14770af5377402Structure r) {
RC_3836c6494dc01a6dca1bf0597beb32bb res = new RC_3836c6494dc01a6dca1bf0597beb32bb ();
res.ssSTOptionalPolylineConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3836c6494dc01a6dca1bf0597beb32bb() {
OptimizedAttributes = null;
ssSTOptionalPolylineConfigs = new ST_f85923824a33f65ded14770af5377402Structure();
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
    ssSTOptionalPolylineConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalPolylineConfigs.Read( r, ref index);
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
public void ReadIM(RC_3836c6494dc01a6dca1bf0597beb32bb r) {
this = r;
}


public static bool operator == (RC_3836c6494dc01a6dca1bf0597beb32bb a, RC_3836c6494dc01a6dca1bf0597beb32bb b) {
if (a.ssSTOptionalPolylineConfigs != b.ssSTOptionalPolylineConfigs) return false;
return true;
}

public static bool operator != (RC_3836c6494dc01a6dca1bf0597beb32bb a, RC_3836c6494dc01a6dca1bf0597beb32bb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3836c6494dc01a6dca1bf0597beb32bb)) return false;
return (this == (RC_3836c6494dc01a6dca1bf0597beb32bb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalPolylineConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalPolylineConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalPolylineConfigs.InternalRecursiveSave();
}


public RC_3836c6494dc01a6dca1bf0597beb32bb Duplicate() {
RC_3836c6494dc01a6dca1bf0597beb32bb t;
t.ssSTOptionalPolylineConfigs = (ST_f85923824a33f65ded14770af5377402Structure)this.ssSTOptionalPolylineConfigs.Duplicate();
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
if (head == "optionalpolylineconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalPolylineConfigs")) variable.Value = ssSTOptionalPolylineConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalpolylineconfigs");
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
if (key == IdOptionalPolylineConfigs) {
return ssSTOptionalPolylineConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalPolylineConfigs.Key.AsGuid) {
return ssSTOptionalPolylineConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalPolylineConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalPolylineConfigs));
}
} // RC_3836c6494dc01a6dca1bf0597beb32bb
/// <summary>
/// RecordList type <code>OptionalPolylineConfigsRecordList</code> that represents a record list of
///  <code>OptionalPolylineConfigs</code>
/// </summary>
public partial class RL_28b1907e8293683af0c45f54c4d2b8d8 : GenericRecordList<RC_3836c6494dc01a6dca1bf0597beb32bb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3836c6494dc01a6dca1bf0597beb32bb GetElementDefaultValue() {
return new RC_3836c6494dc01a6dca1bf0597beb32bb();
}

public T[] ToArray<T>(Func<RC_3836c6494dc01a6dca1bf0597beb32bb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_28b1907e8293683af0c45f54c4d2b8d8 recordList, Func<RC_3836c6494dc01a6dca1bf0597beb32bb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_28b1907e8293683af0c45f54c4d2b8d8(RC_3836c6494dc01a6dca1bf0597beb32bb[] array) {
  RL_28b1907e8293683af0c45f54c4d2b8d8 result = new RL_28b1907e8293683af0c45f54c4d2b8d8();
result.InnerFromArray(array);
    return result;
}

public static RL_28b1907e8293683af0c45f54c4d2b8d8 ToList<T>(T[] array, Func <T, RC_3836c6494dc01a6dca1bf0597beb32bb> converter) {
  RL_28b1907e8293683af0c45f54c4d2b8d8 result = new RL_28b1907e8293683af0c45f54c4d2b8d8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_28b1907e8293683af0c45f54c4d2b8d8 FromRestList<T>(RestList<T> restList, Func <T, RC_3836c6494dc01a6dca1bf0597beb32bb> converter) {
  RL_28b1907e8293683af0c45f54c4d2b8d8 result = new RL_28b1907e8293683af0c45f54c4d2b8d8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_28b1907e8293683af0c45f54c4d2b8d8() : base() {
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
protected override OSList<RC_3836c6494dc01a6dca1bf0597beb32bb> NewList() {
return new RL_28b1907e8293683af0c45f54c4d2b8d8();
}


} // RL_28b1907e8293683af0c45f54c4d2b8d8
}

