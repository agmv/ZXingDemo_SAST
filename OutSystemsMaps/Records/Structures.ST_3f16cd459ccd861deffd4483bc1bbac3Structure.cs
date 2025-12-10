namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_drawingTools_configs (vMXVXxhRf0OSeEgSgCezCw)
///  <code>ST_3f16cd459ccd861deffd4483bc1bbac3Structure</code> that represent
/// s <code>Internal_to_provider_drawingTools_configs</code> <p>Description: Structure to handle
///  internal configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_to_provider_drawingTools_configs
public partial struct ST_3f16cd459ccd861deffd4483bc1bbac3Structure : ITypedRecord<ST_3f16cd459ccd861deffd4483bc1bbac3Structure> {
internal static readonly GlobalObjectKey Idposition = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*B0NYzpkTYkWlpSx6_Ndbtw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("position")]
public string ssposition;


public BitArray OptimizedAttributes;

public ST_3f16cd459ccd861deffd4483bc1bbac3Structure() {
OptimizedAttributes = null;
ssposition = (ENDrawingToolsPositionEntity.GetRecordByKey(ObjectKey.Parse("jXpYIpUqhU62k_i9ABfxVQ"))).ssId;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssposition = r.ReadEntityReferenceText(index++, "Internal_to_provider_drawingTools_configs.position", "");
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
public void ReadIM(ST_3f16cd459ccd861deffd4483bc1bbac3Structure r) {
this = r;
}


public static bool operator == (ST_3f16cd459ccd861deffd4483bc1bbac3Structure a, ST_3f16cd459ccd861deffd4483bc1bbac3Structure b) {
if (a.ssposition != b.ssposition) return false;
return true;
}

public static bool operator != (ST_3f16cd459ccd861deffd4483bc1bbac3Structure a, ST_3f16cd459ccd861deffd4483bc1bbac3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3f16cd459ccd861deffd4483bc1bbac3Structure)) return false;
return (this == (ST_3f16cd459ccd861deffd4483bc1bbac3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssposition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3f16cd459ccd861deffd4483bc1bbac3Structure Duplicate() {
ST_3f16cd459ccd861deffd4483bc1bbac3Structure t;
t.ssposition = this.ssposition;
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
if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".position")) variable.Value = ssposition; else variable.Optimized = true;
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
if (key == Idposition) {
return ssposition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idposition.Key.AsGuid) {
return ssposition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssposition = (string) other.AttributeGet(Idposition);
}
} // ST_3f16cd459ccd861deffd4483bc1bbac3Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_drawingTools_configsList</code> that represents a record
///  list of <code>Internal_to_provider_drawingTools_configs</code>
/// </summary>
public partial class RL_18137c78c83e8eb0c8f8ec08bffbb968 : GenericRecordList<ST_3f16cd459ccd861deffd4483bc1bbac3Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_3f16cd459ccd861deffd4483bc1bbac3Structure GetElementDefaultValue() {
return new ST_3f16cd459ccd861deffd4483bc1bbac3Structure();
}

public T[] ToArray<T>(Func<ST_3f16cd459ccd861deffd4483bc1bbac3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_18137c78c83e8eb0c8f8ec08bffbb968 recordList, Func<ST_3f16cd459ccd861deffd4483bc1bbac3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_18137c78c83e8eb0c8f8ec08bffbb968(ST_3f16cd459ccd861deffd4483bc1bbac3Structure[] array) {
  RL_18137c78c83e8eb0c8f8ec08bffbb968 result = new RL_18137c78c83e8eb0c8f8ec08bffbb968();
result.InnerFromArray(array);
    return result;
}

public static RL_18137c78c83e8eb0c8f8ec08bffbb968 ToList<T>(T[] array, Func <T, ST_3f16cd459ccd861deffd4483bc1bbac3Structure> converter) {
  RL_18137c78c83e8eb0c8f8ec08bffbb968 result = new RL_18137c78c83e8eb0c8f8ec08bffbb968();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_18137c78c83e8eb0c8f8ec08bffbb968 FromRestList<T>(RestList<T> restList, Func <T, ST_3f16cd459ccd861deffd4483bc1bbac3Structure> converter) {
  RL_18137c78c83e8eb0c8f8ec08bffbb968 result = new RL_18137c78c83e8eb0c8f8ec08bffbb968();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_18137c78c83e8eb0c8f8ec08bffbb968() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3f16cd459ccd861deffd4483bc1bbac3Structure> NewList() {
return new RL_18137c78c83e8eb0c8f8ec08bffbb968();
}


} // RL_18137c78c83e8eb0c8f8ec08bffbb968
}

