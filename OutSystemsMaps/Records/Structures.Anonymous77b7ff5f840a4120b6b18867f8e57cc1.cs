namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (X_+3dwqEIEG2sYhn+OV8wQ)
///  <code>RC_59608f6fdf263bd270d8edd0a1db0f3c</code> that represent
/// s <code>OptionalHeatmapLayerConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalHeatmapLayerConfigsRecord
public partial struct RC_59608f6fdf263bd270d8edd0a1db0f3c : ITypedRecord<RC_59608f6fdf263bd270d8edd0a1db0f3c> {
internal static readonly GlobalObjectKey IdOptionalHeatmapLayerConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*b49gWSbf0jtw2O3QodsPPA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalHeatmapLayerConfigs")]
public ST_c84e2ea85c3f77e3b083b2b79806c17aStructure ssSTOptionalHeatmapLayerConfigs;


public static implicit operator ST_c84e2ea85c3f77e3b083b2b79806c17aStructure( RC_59608f6fdf263bd270d8edd0a1db0f3c r) {
return r.ssSTOptionalHeatmapLayerConfigs;
}

public static implicit operator RC_59608f6fdf263bd270d8edd0a1db0f3c (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure r) {
RC_59608f6fdf263bd270d8edd0a1db0f3c res = new RC_59608f6fdf263bd270d8edd0a1db0f3c ();
res.ssSTOptionalHeatmapLayerConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_59608f6fdf263bd270d8edd0a1db0f3c() {
OptimizedAttributes = null;
ssSTOptionalHeatmapLayerConfigs = new ST_c84e2ea85c3f77e3b083b2b79806c17aStructure();
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
    ssSTOptionalHeatmapLayerConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalHeatmapLayerConfigs.Read( r, ref index);
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
public void ReadIM(RC_59608f6fdf263bd270d8edd0a1db0f3c r) {
this = r;
}


public static bool operator == (RC_59608f6fdf263bd270d8edd0a1db0f3c a, RC_59608f6fdf263bd270d8edd0a1db0f3c b) {
if (a.ssSTOptionalHeatmapLayerConfigs != b.ssSTOptionalHeatmapLayerConfigs) return false;
return true;
}

public static bool operator != (RC_59608f6fdf263bd270d8edd0a1db0f3c a, RC_59608f6fdf263bd270d8edd0a1db0f3c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_59608f6fdf263bd270d8edd0a1db0f3c)) return false;
return (this == (RC_59608f6fdf263bd270d8edd0a1db0f3c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalHeatmapLayerConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalHeatmapLayerConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalHeatmapLayerConfigs.InternalRecursiveSave();
}


public RC_59608f6fdf263bd270d8edd0a1db0f3c Duplicate() {
RC_59608f6fdf263bd270d8edd0a1db0f3c t;
t.ssSTOptionalHeatmapLayerConfigs = (ST_c84e2ea85c3f77e3b083b2b79806c17aStructure)this.ssSTOptionalHeatmapLayerConfigs.Duplicate();
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
if (head == "optionalheatmaplayerconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalHeatmapLayerConfigs")) variable.Value = ssSTOptionalHeatmapLayerConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalheatmaplayerconfigs");
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
if (key == IdOptionalHeatmapLayerConfigs) {
return ssSTOptionalHeatmapLayerConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalHeatmapLayerConfigs.Key.AsGuid) {
return ssSTOptionalHeatmapLayerConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalHeatmapLayerConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalHeatmapLayerConfigs));
}
} // RC_59608f6fdf263bd270d8edd0a1db0f3c
/// <summary>
/// RecordList type <code>OptionalHeatmapLayerConfigsRecordList</code> that represents a record list of
///  <code>OptionalHeatmapLayerConfigs</code>
/// </summary>
public partial class RL_ff93ddb23ad1a28af46fae42cf98bb8c : GenericRecordList<RC_59608f6fdf263bd270d8edd0a1db0f3c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_59608f6fdf263bd270d8edd0a1db0f3c GetElementDefaultValue() {
return new RC_59608f6fdf263bd270d8edd0a1db0f3c();
}

public T[] ToArray<T>(Func<RC_59608f6fdf263bd270d8edd0a1db0f3c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff93ddb23ad1a28af46fae42cf98bb8c recordList, Func<RC_59608f6fdf263bd270d8edd0a1db0f3c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff93ddb23ad1a28af46fae42cf98bb8c(RC_59608f6fdf263bd270d8edd0a1db0f3c[] array) {
  RL_ff93ddb23ad1a28af46fae42cf98bb8c result = new RL_ff93ddb23ad1a28af46fae42cf98bb8c();
result.InnerFromArray(array);
    return result;
}

public static RL_ff93ddb23ad1a28af46fae42cf98bb8c ToList<T>(T[] array, Func <T, RC_59608f6fdf263bd270d8edd0a1db0f3c> converter) {
  RL_ff93ddb23ad1a28af46fae42cf98bb8c result = new RL_ff93ddb23ad1a28af46fae42cf98bb8c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff93ddb23ad1a28af46fae42cf98bb8c FromRestList<T>(RestList<T> restList, Func <T, RC_59608f6fdf263bd270d8edd0a1db0f3c> converter) {
  RL_ff93ddb23ad1a28af46fae42cf98bb8c result = new RL_ff93ddb23ad1a28af46fae42cf98bb8c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff93ddb23ad1a28af46fae42cf98bb8c() : base() {
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
protected override OSList<RC_59608f6fdf263bd270d8edd0a1db0f3c> NewList() {
return new RL_ff93ddb23ad1a28af46fae42cf98bb8c();
}


} // RL_ff93ddb23ad1a28af46fae42cf98bb8c
}

