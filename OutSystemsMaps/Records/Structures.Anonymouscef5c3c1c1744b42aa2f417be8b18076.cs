namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (wcP1znTBQkuqL0F76LGAdg)
///  <code>RC_68b38ef52a6c43d6a00c9748c6ced1ca</code> that represent
/// s <code>Internal_to_provider_drawMarker_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_drawMarker_configsRecord
public partial struct RC_68b38ef52a6c43d6a00c9748c6ced1ca : ITypedRecord<RC_68b38ef52a6c43d6a00c9748c6ced1ca> {
internal static readonly GlobalObjectKey IdInternal_to_provider_drawMarker_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9Y6zaGwq1kOgDJdIxs7Ryg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_drawMarker_configs")]
public ST_f121435b3edb481ee03ab7ef58e5b805Structure ssSTInternal_to_provider_drawMarker_configs;


public static implicit operator ST_f121435b3edb481ee03ab7ef58e5b805Structure( RC_68b38ef52a6c43d6a00c9748c6ced1ca r) {
return r.ssSTInternal_to_provider_drawMarker_configs;
}

public static implicit operator RC_68b38ef52a6c43d6a00c9748c6ced1ca (ST_f121435b3edb481ee03ab7ef58e5b805Structure r) {
RC_68b38ef52a6c43d6a00c9748c6ced1ca res = new RC_68b38ef52a6c43d6a00c9748c6ced1ca ();
res.ssSTInternal_to_provider_drawMarker_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_68b38ef52a6c43d6a00c9748c6ced1ca() {
OptimizedAttributes = null;
ssSTInternal_to_provider_drawMarker_configs = new ST_f121435b3edb481ee03ab7ef58e5b805Structure();
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
    ssSTInternal_to_provider_drawMarker_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_drawMarker_configs.Read( r, ref index);
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
public void ReadIM(RC_68b38ef52a6c43d6a00c9748c6ced1ca r) {
this = r;
}


public static bool operator == (RC_68b38ef52a6c43d6a00c9748c6ced1ca a, RC_68b38ef52a6c43d6a00c9748c6ced1ca b) {
if (a.ssSTInternal_to_provider_drawMarker_configs != b.ssSTInternal_to_provider_drawMarker_configs) return false;
return true;
}

public static bool operator != (RC_68b38ef52a6c43d6a00c9748c6ced1ca a, RC_68b38ef52a6c43d6a00c9748c6ced1ca b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_68b38ef52a6c43d6a00c9748c6ced1ca)) return false;
return (this == (RC_68b38ef52a6c43d6a00c9748c6ced1ca)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_drawMarker_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_drawMarker_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_drawMarker_configs.InternalRecursiveSave();
}


public RC_68b38ef52a6c43d6a00c9748c6ced1ca Duplicate() {
RC_68b38ef52a6c43d6a00c9748c6ced1ca t;
t.ssSTInternal_to_provider_drawMarker_configs = (ST_f121435b3edb481ee03ab7ef58e5b805Structure)this.ssSTInternal_to_provider_drawMarker_configs.Duplicate();
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
if (head == "internal_to_provider_drawmarker_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_drawMarker_configs")) variable.Value = ssSTInternal_to_provider_drawMarker_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_drawmarker_configs");
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
if (key == IdInternal_to_provider_drawMarker_configs) {
return ssSTInternal_to_provider_drawMarker_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_drawMarker_configs.Key.AsGuid) {
return ssSTInternal_to_provider_drawMarker_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_drawMarker_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_drawMarker_configs));
}
} // RC_68b38ef52a6c43d6a00c9748c6ced1ca
/// <summary>
/// RecordList type <code>Internal_to_provider_drawMarker_configsRecordList</code> that represents a
///  record list of <code>Internal_to_provider_drawMarker_configs</code>
/// </summary>
public partial class RL_9ab0c2094cafdfad27b30d8f4aaeb896 : GenericRecordList<RC_68b38ef52a6c43d6a00c9748c6ced1ca>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_68b38ef52a6c43d6a00c9748c6ced1ca GetElementDefaultValue() {
return new RC_68b38ef52a6c43d6a00c9748c6ced1ca();
}

public T[] ToArray<T>(Func<RC_68b38ef52a6c43d6a00c9748c6ced1ca, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9ab0c2094cafdfad27b30d8f4aaeb896 recordList, Func<RC_68b38ef52a6c43d6a00c9748c6ced1ca, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9ab0c2094cafdfad27b30d8f4aaeb896(RC_68b38ef52a6c43d6a00c9748c6ced1ca[] array) {
  RL_9ab0c2094cafdfad27b30d8f4aaeb896 result = new RL_9ab0c2094cafdfad27b30d8f4aaeb896();
result.InnerFromArray(array);
    return result;
}

public static RL_9ab0c2094cafdfad27b30d8f4aaeb896 ToList<T>(T[] array, Func <T, RC_68b38ef52a6c43d6a00c9748c6ced1ca> converter) {
  RL_9ab0c2094cafdfad27b30d8f4aaeb896 result = new RL_9ab0c2094cafdfad27b30d8f4aaeb896();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9ab0c2094cafdfad27b30d8f4aaeb896 FromRestList<T>(RestList<T> restList, Func <T, RC_68b38ef52a6c43d6a00c9748c6ced1ca> converter) {
  RL_9ab0c2094cafdfad27b30d8f4aaeb896 result = new RL_9ab0c2094cafdfad27b30d8f4aaeb896();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9ab0c2094cafdfad27b30d8f4aaeb896() : base() {
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
protected override OSList<RC_68b38ef52a6c43d6a00c9748c6ced1ca> NewList() {
return new RL_9ab0c2094cafdfad27b30d8f4aaeb896();
}


} // RL_9ab0c2094cafdfad27b30d8f4aaeb896
}

