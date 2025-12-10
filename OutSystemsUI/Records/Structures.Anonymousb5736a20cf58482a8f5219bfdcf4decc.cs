namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (IGpztVjPKkiPUhm_3PTezA)
///  <code>RC_11d8167e3fa15e3043cb2afdd0778cf2</code> that represent
/// s <code>Sidebar_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Sidebar_InternalConfigRecord
public partial struct RC_11d8167e3fa15e3043cb2afdd0778cf2 : ITypedRecord<RC_11d8167e3fa15e3043cb2afdd0778cf2> {
internal static readonly GlobalObjectKey IdSidebar_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fhbYEaE_MF5Dyyr90HeM8g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Sidebar_InternalConfig")]
public ST_963c357dbc45b19fade654e21b1521d0Structure ssSTSidebar_InternalConfig;


public static implicit operator ST_963c357dbc45b19fade654e21b1521d0Structure( RC_11d8167e3fa15e3043cb2afdd0778cf2 r) {
return r.ssSTSidebar_InternalConfig;
}

public static implicit operator RC_11d8167e3fa15e3043cb2afdd0778cf2 (ST_963c357dbc45b19fade654e21b1521d0Structure r) {
RC_11d8167e3fa15e3043cb2afdd0778cf2 res = new RC_11d8167e3fa15e3043cb2afdd0778cf2 ();
res.ssSTSidebar_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_11d8167e3fa15e3043cb2afdd0778cf2() {
OptimizedAttributes = null;
ssSTSidebar_InternalConfig = new ST_963c357dbc45b19fade654e21b1521d0Structure();
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
    ssSTSidebar_InternalConfig.OptimizedAttributes = value[0];
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
ssSTSidebar_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_11d8167e3fa15e3043cb2afdd0778cf2 r) {
this = r;
}


public static bool operator == (RC_11d8167e3fa15e3043cb2afdd0778cf2 a, RC_11d8167e3fa15e3043cb2afdd0778cf2 b) {
if (a.ssSTSidebar_InternalConfig != b.ssSTSidebar_InternalConfig) return false;
return true;
}

public static bool operator != (RC_11d8167e3fa15e3043cb2afdd0778cf2 a, RC_11d8167e3fa15e3043cb2afdd0778cf2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_11d8167e3fa15e3043cb2afdd0778cf2)) return false;
return (this == (RC_11d8167e3fa15e3043cb2afdd0778cf2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSidebar_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSidebar_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSidebar_InternalConfig.InternalRecursiveSave();
}


public RC_11d8167e3fa15e3043cb2afdd0778cf2 Duplicate() {
RC_11d8167e3fa15e3043cb2afdd0778cf2 t;
t.ssSTSidebar_InternalConfig = (ST_963c357dbc45b19fade654e21b1521d0Structure)this.ssSTSidebar_InternalConfig.Duplicate();
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
if (head == "sidebar_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sidebar_InternalConfig")) variable.Value = ssSTSidebar_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("sidebar_internalconfig");
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
if (key == IdSidebar_InternalConfig) {
return ssSTSidebar_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSidebar_InternalConfig.Key.AsGuid) {
return ssSTSidebar_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSidebar_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdSidebar_InternalConfig));
}
} // RC_11d8167e3fa15e3043cb2afdd0778cf2
/// <summary>
/// RecordList type <code>Sidebar_InternalConfigRecordList</code> that represents a record list of
///  <code>Sidebar_InternalConfig</code>
/// </summary>
public partial class RL_af46fd5f455422e07d0fa67a99656193 : GenericRecordList<RC_11d8167e3fa15e3043cb2afdd0778cf2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_11d8167e3fa15e3043cb2afdd0778cf2 GetElementDefaultValue() {
return new RC_11d8167e3fa15e3043cb2afdd0778cf2();
}

public T[] ToArray<T>(Func<RC_11d8167e3fa15e3043cb2afdd0778cf2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_af46fd5f455422e07d0fa67a99656193 recordList, Func<RC_11d8167e3fa15e3043cb2afdd0778cf2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_af46fd5f455422e07d0fa67a99656193(RC_11d8167e3fa15e3043cb2afdd0778cf2[] array) {
  RL_af46fd5f455422e07d0fa67a99656193 result = new RL_af46fd5f455422e07d0fa67a99656193();
result.InnerFromArray(array);
    return result;
}

public static RL_af46fd5f455422e07d0fa67a99656193 ToList<T>(T[] array, Func <T, RC_11d8167e3fa15e3043cb2afdd0778cf2> converter) {
  RL_af46fd5f455422e07d0fa67a99656193 result = new RL_af46fd5f455422e07d0fa67a99656193();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_af46fd5f455422e07d0fa67a99656193 FromRestList<T>(RestList<T> restList, Func <T, RC_11d8167e3fa15e3043cb2afdd0778cf2> converter) {
  RL_af46fd5f455422e07d0fa67a99656193 result = new RL_af46fd5f455422e07d0fa67a99656193();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_af46fd5f455422e07d0fa67a99656193() : base() {
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
protected override OSList<RC_11d8167e3fa15e3043cb2afdd0778cf2> NewList() {
return new RL_af46fd5f455422e07d0fa67a99656193();
}


} // RL_af46fd5f455422e07d0fa67a99656193
}

