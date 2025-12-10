namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (q0cg9FefdUWbgLKha_vjrg)
///  <code>RC_c506c74ca8aaa04b11f3b2041bb6669f</code> that represent
/// s <code>Tooltip_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Tooltip_InternalConfigRecord
public partial struct RC_c506c74ca8aaa04b11f3b2041bb6669f : ITypedRecord<RC_c506c74ca8aaa04b11f3b2041bb6669f> {
internal static readonly GlobalObjectKey IdTooltip_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TMcGxaqoS6AR87IEG7Zmnw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Tooltip_InternalConfig")]
public ST_9cac82fc47e32e1503b2dbc00140aa98Structure ssSTTooltip_InternalConfig;


public static implicit operator ST_9cac82fc47e32e1503b2dbc00140aa98Structure( RC_c506c74ca8aaa04b11f3b2041bb6669f r) {
return r.ssSTTooltip_InternalConfig;
}

public static implicit operator RC_c506c74ca8aaa04b11f3b2041bb6669f (ST_9cac82fc47e32e1503b2dbc00140aa98Structure r) {
RC_c506c74ca8aaa04b11f3b2041bb6669f res = new RC_c506c74ca8aaa04b11f3b2041bb6669f ();
res.ssSTTooltip_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c506c74ca8aaa04b11f3b2041bb6669f() {
OptimizedAttributes = null;
ssSTTooltip_InternalConfig = new ST_9cac82fc47e32e1503b2dbc00140aa98Structure();
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
    ssSTTooltip_InternalConfig.OptimizedAttributes = value[0];
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
ssSTTooltip_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_c506c74ca8aaa04b11f3b2041bb6669f r) {
this = r;
}


public static bool operator == (RC_c506c74ca8aaa04b11f3b2041bb6669f a, RC_c506c74ca8aaa04b11f3b2041bb6669f b) {
if (a.ssSTTooltip_InternalConfig != b.ssSTTooltip_InternalConfig) return false;
return true;
}

public static bool operator != (RC_c506c74ca8aaa04b11f3b2041bb6669f a, RC_c506c74ca8aaa04b11f3b2041bb6669f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c506c74ca8aaa04b11f3b2041bb6669f)) return false;
return (this == (RC_c506c74ca8aaa04b11f3b2041bb6669f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTooltip_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTooltip_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTooltip_InternalConfig.InternalRecursiveSave();
}


public RC_c506c74ca8aaa04b11f3b2041bb6669f Duplicate() {
RC_c506c74ca8aaa04b11f3b2041bb6669f t;
t.ssSTTooltip_InternalConfig = (ST_9cac82fc47e32e1503b2dbc00140aa98Structure)this.ssSTTooltip_InternalConfig.Duplicate();
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
if (head == "tooltip_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tooltip_InternalConfig")) variable.Value = ssSTTooltip_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("tooltip_internalconfig");
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
if (key == IdTooltip_InternalConfig) {
return ssSTTooltip_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTooltip_InternalConfig.Key.AsGuid) {
return ssSTTooltip_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTooltip_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdTooltip_InternalConfig));
}
} // RC_c506c74ca8aaa04b11f3b2041bb6669f
/// <summary>
/// RecordList type <code>Tooltip_InternalConfigRecordList</code> that represents a record list of
///  <code>Tooltip_InternalConfig</code>
/// </summary>
public partial class RL_9bf017f1e701e51f079aa12b453a76f1 : GenericRecordList<RC_c506c74ca8aaa04b11f3b2041bb6669f>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c506c74ca8aaa04b11f3b2041bb6669f GetElementDefaultValue() {
return new RC_c506c74ca8aaa04b11f3b2041bb6669f();
}

public T[] ToArray<T>(Func<RC_c506c74ca8aaa04b11f3b2041bb6669f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9bf017f1e701e51f079aa12b453a76f1 recordList, Func<RC_c506c74ca8aaa04b11f3b2041bb6669f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9bf017f1e701e51f079aa12b453a76f1(RC_c506c74ca8aaa04b11f3b2041bb6669f[] array) {
  RL_9bf017f1e701e51f079aa12b453a76f1 result = new RL_9bf017f1e701e51f079aa12b453a76f1();
result.InnerFromArray(array);
    return result;
}

public static RL_9bf017f1e701e51f079aa12b453a76f1 ToList<T>(T[] array, Func <T, RC_c506c74ca8aaa04b11f3b2041bb6669f> converter) {
  RL_9bf017f1e701e51f079aa12b453a76f1 result = new RL_9bf017f1e701e51f079aa12b453a76f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9bf017f1e701e51f079aa12b453a76f1 FromRestList<T>(RestList<T> restList, Func <T, RC_c506c74ca8aaa04b11f3b2041bb6669f> converter) {
  RL_9bf017f1e701e51f079aa12b453a76f1 result = new RL_9bf017f1e701e51f079aa12b453a76f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9bf017f1e701e51f079aa12b453a76f1() : base() {
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
protected override OSList<RC_c506c74ca8aaa04b11f3b2041bb6669f> NewList() {
return new RL_9bf017f1e701e51f079aa12b453a76f1();
}


} // RL_9bf017f1e701e51f079aa12b453a76f1
}

