namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (E7IArXJDGU+v9DGPtEDDMw)
///  <code>RC_86c442a46c095f494cab514734ffc71c</code> that represent
/// s <code>Internal_to_provider_drawingTools_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_drawingTools_configsRecord
public partial struct RC_86c442a46c095f494cab514734ffc71c : ITypedRecord<RC_86c442a46c095f494cab514734ffc71c> {
internal static readonly GlobalObjectKey IdInternal_to_provider_drawingTools_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pELEhglsSV9Mq1FHNP_HHA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_drawingTools_configs")]
public ST_3f16cd459ccd861deffd4483bc1bbac3Structure ssSTInternal_to_provider_drawingTools_configs;


public static implicit operator ST_3f16cd459ccd861deffd4483bc1bbac3Structure( RC_86c442a46c095f494cab514734ffc71c r) {
return r.ssSTInternal_to_provider_drawingTools_configs;
}

public static implicit operator RC_86c442a46c095f494cab514734ffc71c (ST_3f16cd459ccd861deffd4483bc1bbac3Structure r) {
RC_86c442a46c095f494cab514734ffc71c res = new RC_86c442a46c095f494cab514734ffc71c ();
res.ssSTInternal_to_provider_drawingTools_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_86c442a46c095f494cab514734ffc71c() {
OptimizedAttributes = null;
ssSTInternal_to_provider_drawingTools_configs = new ST_3f16cd459ccd861deffd4483bc1bbac3Structure();
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
    ssSTInternal_to_provider_drawingTools_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_drawingTools_configs.Read( r, ref index);
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
public void ReadIM(RC_86c442a46c095f494cab514734ffc71c r) {
this = r;
}


public static bool operator == (RC_86c442a46c095f494cab514734ffc71c a, RC_86c442a46c095f494cab514734ffc71c b) {
if (a.ssSTInternal_to_provider_drawingTools_configs != b.ssSTInternal_to_provider_drawingTools_configs) return false;
return true;
}

public static bool operator != (RC_86c442a46c095f494cab514734ffc71c a, RC_86c442a46c095f494cab514734ffc71c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_86c442a46c095f494cab514734ffc71c)) return false;
return (this == (RC_86c442a46c095f494cab514734ffc71c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_drawingTools_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_drawingTools_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_drawingTools_configs.InternalRecursiveSave();
}


public RC_86c442a46c095f494cab514734ffc71c Duplicate() {
RC_86c442a46c095f494cab514734ffc71c t;
t.ssSTInternal_to_provider_drawingTools_configs = (ST_3f16cd459ccd861deffd4483bc1bbac3Structure)this.ssSTInternal_to_provider_drawingTools_configs.Duplicate();
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
if (head == "internal_to_provider_drawingtools_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_drawingTools_configs")) variable.Value = ssSTInternal_to_provider_drawingTools_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_drawingtools_configs");
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
if (key == IdInternal_to_provider_drawingTools_configs) {
return ssSTInternal_to_provider_drawingTools_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_drawingTools_configs.Key.AsGuid) {
return ssSTInternal_to_provider_drawingTools_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_drawingTools_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_drawingTools_configs));
}
} // RC_86c442a46c095f494cab514734ffc71c
/// <summary>
/// RecordList type <code>Internal_to_provider_drawingTools_configsRecordList</code> that represents a
///  record list of <code>Internal_to_provider_drawingTools_configs</code>
/// </summary>
public partial class RL_b9b66c74d55f9ac4e9a13b2ed98048a5 : GenericRecordList<RC_86c442a46c095f494cab514734ffc71c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_86c442a46c095f494cab514734ffc71c GetElementDefaultValue() {
return new RC_86c442a46c095f494cab514734ffc71c();
}

public T[] ToArray<T>(Func<RC_86c442a46c095f494cab514734ffc71c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b9b66c74d55f9ac4e9a13b2ed98048a5 recordList, Func<RC_86c442a46c095f494cab514734ffc71c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b9b66c74d55f9ac4e9a13b2ed98048a5(RC_86c442a46c095f494cab514734ffc71c[] array) {
  RL_b9b66c74d55f9ac4e9a13b2ed98048a5 result = new RL_b9b66c74d55f9ac4e9a13b2ed98048a5();
result.InnerFromArray(array);
    return result;
}

public static RL_b9b66c74d55f9ac4e9a13b2ed98048a5 ToList<T>(T[] array, Func <T, RC_86c442a46c095f494cab514734ffc71c> converter) {
  RL_b9b66c74d55f9ac4e9a13b2ed98048a5 result = new RL_b9b66c74d55f9ac4e9a13b2ed98048a5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b9b66c74d55f9ac4e9a13b2ed98048a5 FromRestList<T>(RestList<T> restList, Func <T, RC_86c442a46c095f494cab514734ffc71c> converter) {
  RL_b9b66c74d55f9ac4e9a13b2ed98048a5 result = new RL_b9b66c74d55f9ac4e9a13b2ed98048a5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b9b66c74d55f9ac4e9a13b2ed98048a5() : base() {
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
protected override OSList<RC_86c442a46c095f494cab514734ffc71c> NewList() {
return new RL_b9b66c74d55f9ac4e9a13b2ed98048a5();
}


} // RL_b9b66c74d55f9ac4e9a13b2ed98048a5
}

