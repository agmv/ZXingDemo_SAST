namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (+OqSrnwtikG5nxaNC82Row)
///  <code>RC_468bdef36a83c5e44a35aa87e6093ad0</code> that represent
/// s <code>Internal_to_provider_heatmapLayer_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_heatmapLayer_configsRecord
public partial struct RC_468bdef36a83c5e44a35aa87e6093ad0 : ITypedRecord<RC_468bdef36a83c5e44a35aa87e6093ad0> {
internal static readonly GlobalObjectKey IdInternal_to_provider_heatmapLayer_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*896LRoNq5MVKNaqH5gk60A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_heatmapLayer_configs")]
public ST_ca5fecbdf222b72d179909c1f030119cStructure ssSTInternal_to_provider_heatmapLayer_configs;


public static implicit operator ST_ca5fecbdf222b72d179909c1f030119cStructure( RC_468bdef36a83c5e44a35aa87e6093ad0 r) {
return r.ssSTInternal_to_provider_heatmapLayer_configs;
}

public static implicit operator RC_468bdef36a83c5e44a35aa87e6093ad0 (ST_ca5fecbdf222b72d179909c1f030119cStructure r) {
RC_468bdef36a83c5e44a35aa87e6093ad0 res = new RC_468bdef36a83c5e44a35aa87e6093ad0 ();
res.ssSTInternal_to_provider_heatmapLayer_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_468bdef36a83c5e44a35aa87e6093ad0() {
OptimizedAttributes = null;
ssSTInternal_to_provider_heatmapLayer_configs = new ST_ca5fecbdf222b72d179909c1f030119cStructure();
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
    ssSTInternal_to_provider_heatmapLayer_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_heatmapLayer_configs.Read( r, ref index);
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
public void ReadIM(RC_468bdef36a83c5e44a35aa87e6093ad0 r) {
this = r;
}


public static bool operator == (RC_468bdef36a83c5e44a35aa87e6093ad0 a, RC_468bdef36a83c5e44a35aa87e6093ad0 b) {
if (a.ssSTInternal_to_provider_heatmapLayer_configs != b.ssSTInternal_to_provider_heatmapLayer_configs) return false;
return true;
}

public static bool operator != (RC_468bdef36a83c5e44a35aa87e6093ad0 a, RC_468bdef36a83c5e44a35aa87e6093ad0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_468bdef36a83c5e44a35aa87e6093ad0)) return false;
return (this == (RC_468bdef36a83c5e44a35aa87e6093ad0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_heatmapLayer_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_heatmapLayer_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_heatmapLayer_configs.InternalRecursiveSave();
}


public RC_468bdef36a83c5e44a35aa87e6093ad0 Duplicate() {
RC_468bdef36a83c5e44a35aa87e6093ad0 t;
t.ssSTInternal_to_provider_heatmapLayer_configs = (ST_ca5fecbdf222b72d179909c1f030119cStructure)this.ssSTInternal_to_provider_heatmapLayer_configs.Duplicate();
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
if (head == "internal_to_provider_heatmaplayer_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_heatmapLayer_configs")) variable.Value = ssSTInternal_to_provider_heatmapLayer_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_heatmaplayer_configs");
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
if (key == IdInternal_to_provider_heatmapLayer_configs) {
return ssSTInternal_to_provider_heatmapLayer_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_heatmapLayer_configs.Key.AsGuid) {
return ssSTInternal_to_provider_heatmapLayer_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_heatmapLayer_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_heatmapLayer_configs));
}
} // RC_468bdef36a83c5e44a35aa87e6093ad0
/// <summary>
/// RecordList type <code>Internal_to_provider_heatmapLayer_configsRecordList</code> that represents a
///  record list of <code>Internal_to_provider_heatmapLayer_configs</code>
/// </summary>
public partial class RL_1531f144004a1f036454b8eceea3fafa : GenericRecordList<RC_468bdef36a83c5e44a35aa87e6093ad0>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_468bdef36a83c5e44a35aa87e6093ad0 GetElementDefaultValue() {
return new RC_468bdef36a83c5e44a35aa87e6093ad0();
}

public T[] ToArray<T>(Func<RC_468bdef36a83c5e44a35aa87e6093ad0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1531f144004a1f036454b8eceea3fafa recordList, Func<RC_468bdef36a83c5e44a35aa87e6093ad0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1531f144004a1f036454b8eceea3fafa(RC_468bdef36a83c5e44a35aa87e6093ad0[] array) {
  RL_1531f144004a1f036454b8eceea3fafa result = new RL_1531f144004a1f036454b8eceea3fafa();
result.InnerFromArray(array);
    return result;
}

public static RL_1531f144004a1f036454b8eceea3fafa ToList<T>(T[] array, Func <T, RC_468bdef36a83c5e44a35aa87e6093ad0> converter) {
  RL_1531f144004a1f036454b8eceea3fafa result = new RL_1531f144004a1f036454b8eceea3fafa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1531f144004a1f036454b8eceea3fafa FromRestList<T>(RestList<T> restList, Func <T, RC_468bdef36a83c5e44a35aa87e6093ad0> converter) {
  RL_1531f144004a1f036454b8eceea3fafa result = new RL_1531f144004a1f036454b8eceea3fafa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1531f144004a1f036454b8eceea3fafa() : base() {
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
protected override OSList<RC_468bdef36a83c5e44a35aa87e6093ad0> NewList() {
return new RL_1531f144004a1f036454b8eceea3fafa();
}


} // RL_1531f144004a1f036454b8eceea3fafa
}

