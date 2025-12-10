namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (WcCnvZXDtEa2arHHOvSgGA)
///  <code>RC_9590e411027a378334a242a620d3f27e</code> that represent
/// s <code>Internal_to_provider_fileLayer_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_fileLayer_configsRecord
public partial struct RC_9590e411027a378334a242a620d3f27e : ITypedRecord<RC_9590e411027a378334a242a620d3f27e> {
internal static readonly GlobalObjectKey IdInternal_to_provider_fileLayer_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*EeSQlXoCgzc0okKmINPyfg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_fileLayer_configs")]
public ST_793e574f3ddb64f39831eacf8a4462b0Structure ssSTInternal_to_provider_fileLayer_configs;


public static implicit operator ST_793e574f3ddb64f39831eacf8a4462b0Structure( RC_9590e411027a378334a242a620d3f27e r) {
return r.ssSTInternal_to_provider_fileLayer_configs;
}

public static implicit operator RC_9590e411027a378334a242a620d3f27e (ST_793e574f3ddb64f39831eacf8a4462b0Structure r) {
RC_9590e411027a378334a242a620d3f27e res = new RC_9590e411027a378334a242a620d3f27e ();
res.ssSTInternal_to_provider_fileLayer_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9590e411027a378334a242a620d3f27e() {
OptimizedAttributes = null;
ssSTInternal_to_provider_fileLayer_configs = new ST_793e574f3ddb64f39831eacf8a4462b0Structure();
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
    ssSTInternal_to_provider_fileLayer_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_fileLayer_configs.Read( r, ref index);
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
public void ReadIM(RC_9590e411027a378334a242a620d3f27e r) {
this = r;
}


public static bool operator == (RC_9590e411027a378334a242a620d3f27e a, RC_9590e411027a378334a242a620d3f27e b) {
if (a.ssSTInternal_to_provider_fileLayer_configs != b.ssSTInternal_to_provider_fileLayer_configs) return false;
return true;
}

public static bool operator != (RC_9590e411027a378334a242a620d3f27e a, RC_9590e411027a378334a242a620d3f27e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9590e411027a378334a242a620d3f27e)) return false;
return (this == (RC_9590e411027a378334a242a620d3f27e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_fileLayer_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_fileLayer_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_fileLayer_configs.InternalRecursiveSave();
}


public RC_9590e411027a378334a242a620d3f27e Duplicate() {
RC_9590e411027a378334a242a620d3f27e t;
t.ssSTInternal_to_provider_fileLayer_configs = (ST_793e574f3ddb64f39831eacf8a4462b0Structure)this.ssSTInternal_to_provider_fileLayer_configs.Duplicate();
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
if (head == "internal_to_provider_filelayer_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_fileLayer_configs")) variable.Value = ssSTInternal_to_provider_fileLayer_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_filelayer_configs");
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
if (key == IdInternal_to_provider_fileLayer_configs) {
return ssSTInternal_to_provider_fileLayer_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_fileLayer_configs.Key.AsGuid) {
return ssSTInternal_to_provider_fileLayer_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_fileLayer_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_fileLayer_configs));
}
} // RC_9590e411027a378334a242a620d3f27e
/// <summary>
/// RecordList type <code>Internal_to_provider_fileLayer_configsRecordList</code> that represents a
///  record list of <code>Internal_to_provider_fileLayer_configs</code>
/// </summary>
public partial class RL_29bde35723297e54bb4953d87ba5d82b : GenericRecordList<RC_9590e411027a378334a242a620d3f27e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_9590e411027a378334a242a620d3f27e GetElementDefaultValue() {
return new RC_9590e411027a378334a242a620d3f27e();
}

public T[] ToArray<T>(Func<RC_9590e411027a378334a242a620d3f27e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_29bde35723297e54bb4953d87ba5d82b recordList, Func<RC_9590e411027a378334a242a620d3f27e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_29bde35723297e54bb4953d87ba5d82b(RC_9590e411027a378334a242a620d3f27e[] array) {
  RL_29bde35723297e54bb4953d87ba5d82b result = new RL_29bde35723297e54bb4953d87ba5d82b();
result.InnerFromArray(array);
    return result;
}

public static RL_29bde35723297e54bb4953d87ba5d82b ToList<T>(T[] array, Func <T, RC_9590e411027a378334a242a620d3f27e> converter) {
  RL_29bde35723297e54bb4953d87ba5d82b result = new RL_29bde35723297e54bb4953d87ba5d82b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_29bde35723297e54bb4953d87ba5d82b FromRestList<T>(RestList<T> restList, Func <T, RC_9590e411027a378334a242a620d3f27e> converter) {
  RL_29bde35723297e54bb4953d87ba5d82b result = new RL_29bde35723297e54bb4953d87ba5d82b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_29bde35723297e54bb4953d87ba5d82b() : base() {
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
protected override OSList<RC_9590e411027a378334a242a620d3f27e> NewList() {
return new RL_29bde35723297e54bb4953d87ba5d82b();
}


} // RL_29bde35723297e54bb4953d87ba5d82b
}

