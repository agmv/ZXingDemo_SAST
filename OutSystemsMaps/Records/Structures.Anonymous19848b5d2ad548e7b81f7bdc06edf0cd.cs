namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (XYuEGdUq50i4H3vcBu3wzQ)
///  <code>RC_48d7c166849f4c26288a543a51543b8d</code> that represent
/// s <code>OptionalPolygonConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalPolygonConfigsRecord
public partial struct RC_48d7c166849f4c26288a543a51543b8d : ITypedRecord<RC_48d7c166849f4c26288a543a51543b8d> {
internal static readonly GlobalObjectKey IdOptionalPolygonConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZsHXSJ+EJkwoilQ6UVQ7jQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalPolygonConfigs")]
public ST_49045fb6574dc7f29ee1f97116ecb1f6Structure ssSTOptionalPolygonConfigs;


public static implicit operator ST_49045fb6574dc7f29ee1f97116ecb1f6Structure( RC_48d7c166849f4c26288a543a51543b8d r) {
return r.ssSTOptionalPolygonConfigs;
}

public static implicit operator RC_48d7c166849f4c26288a543a51543b8d (ST_49045fb6574dc7f29ee1f97116ecb1f6Structure r) {
RC_48d7c166849f4c26288a543a51543b8d res = new RC_48d7c166849f4c26288a543a51543b8d ();
res.ssSTOptionalPolygonConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_48d7c166849f4c26288a543a51543b8d() {
OptimizedAttributes = null;
ssSTOptionalPolygonConfigs = new ST_49045fb6574dc7f29ee1f97116ecb1f6Structure();
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
    ssSTOptionalPolygonConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalPolygonConfigs.Read( r, ref index);
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
public void ReadIM(RC_48d7c166849f4c26288a543a51543b8d r) {
this = r;
}


public static bool operator == (RC_48d7c166849f4c26288a543a51543b8d a, RC_48d7c166849f4c26288a543a51543b8d b) {
if (a.ssSTOptionalPolygonConfigs != b.ssSTOptionalPolygonConfigs) return false;
return true;
}

public static bool operator != (RC_48d7c166849f4c26288a543a51543b8d a, RC_48d7c166849f4c26288a543a51543b8d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_48d7c166849f4c26288a543a51543b8d)) return false;
return (this == (RC_48d7c166849f4c26288a543a51543b8d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalPolygonConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalPolygonConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalPolygonConfigs.InternalRecursiveSave();
}


public RC_48d7c166849f4c26288a543a51543b8d Duplicate() {
RC_48d7c166849f4c26288a543a51543b8d t;
t.ssSTOptionalPolygonConfigs = (ST_49045fb6574dc7f29ee1f97116ecb1f6Structure)this.ssSTOptionalPolygonConfigs.Duplicate();
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
if (head == "optionalpolygonconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalPolygonConfigs")) variable.Value = ssSTOptionalPolygonConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalpolygonconfigs");
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
if (key == IdOptionalPolygonConfigs) {
return ssSTOptionalPolygonConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalPolygonConfigs.Key.AsGuid) {
return ssSTOptionalPolygonConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalPolygonConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalPolygonConfigs));
}
} // RC_48d7c166849f4c26288a543a51543b8d
/// <summary>
/// RecordList type <code>OptionalPolygonConfigsRecordList</code> that represents a record list of
///  <code>OptionalPolygonConfigs</code>
/// </summary>
public partial class RL_59a4fbf5e364b5bb932d107181ed2455 : GenericRecordList<RC_48d7c166849f4c26288a543a51543b8d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_48d7c166849f4c26288a543a51543b8d GetElementDefaultValue() {
return new RC_48d7c166849f4c26288a543a51543b8d();
}

public T[] ToArray<T>(Func<RC_48d7c166849f4c26288a543a51543b8d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_59a4fbf5e364b5bb932d107181ed2455 recordList, Func<RC_48d7c166849f4c26288a543a51543b8d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_59a4fbf5e364b5bb932d107181ed2455(RC_48d7c166849f4c26288a543a51543b8d[] array) {
  RL_59a4fbf5e364b5bb932d107181ed2455 result = new RL_59a4fbf5e364b5bb932d107181ed2455();
result.InnerFromArray(array);
    return result;
}

public static RL_59a4fbf5e364b5bb932d107181ed2455 ToList<T>(T[] array, Func <T, RC_48d7c166849f4c26288a543a51543b8d> converter) {
  RL_59a4fbf5e364b5bb932d107181ed2455 result = new RL_59a4fbf5e364b5bb932d107181ed2455();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_59a4fbf5e364b5bb932d107181ed2455 FromRestList<T>(RestList<T> restList, Func <T, RC_48d7c166849f4c26288a543a51543b8d> converter) {
  RL_59a4fbf5e364b5bb932d107181ed2455 result = new RL_59a4fbf5e364b5bb932d107181ed2455();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_59a4fbf5e364b5bb932d107181ed2455() : base() {
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
protected override OSList<RC_48d7c166849f4c26288a543a51543b8d> NewList() {
return new RL_59a4fbf5e364b5bb932d107181ed2455();
}


} // RL_59a4fbf5e364b5bb932d107181ed2455
}

