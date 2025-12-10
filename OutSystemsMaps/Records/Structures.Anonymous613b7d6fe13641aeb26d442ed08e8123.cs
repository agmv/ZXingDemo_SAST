namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (b307YTbhrkGybUQu0I6BIw)
///  <code>RC_3f581e27c2f72d4f78b5674dc475102b</code> that represent
/// s <code>Internal_to_provider_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_configsRecord
public partial struct RC_3f581e27c2f72d4f78b5674dc475102b : ITypedRecord<RC_3f581e27c2f72d4f78b5674dc475102b> {
internal static readonly GlobalObjectKey IdInternal_to_provider_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jx5YP_fCTy14tWdNxHUQKw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_configs")]
public ST_5baae74ed57e3bb61180aff1dadec4e1Structure ssSTInternal_to_provider_configs;


public static implicit operator ST_5baae74ed57e3bb61180aff1dadec4e1Structure( RC_3f581e27c2f72d4f78b5674dc475102b r) {
return r.ssSTInternal_to_provider_configs;
}

public static implicit operator RC_3f581e27c2f72d4f78b5674dc475102b (ST_5baae74ed57e3bb61180aff1dadec4e1Structure r) {
RC_3f581e27c2f72d4f78b5674dc475102b res = new RC_3f581e27c2f72d4f78b5674dc475102b ();
res.ssSTInternal_to_provider_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3f581e27c2f72d4f78b5674dc475102b() {
OptimizedAttributes = null;
ssSTInternal_to_provider_configs = new ST_5baae74ed57e3bb61180aff1dadec4e1Structure();
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
    ssSTInternal_to_provider_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_configs.Read( r, ref index);
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
public void ReadIM(RC_3f581e27c2f72d4f78b5674dc475102b r) {
this = r;
}


public static bool operator == (RC_3f581e27c2f72d4f78b5674dc475102b a, RC_3f581e27c2f72d4f78b5674dc475102b b) {
if (a.ssSTInternal_to_provider_configs != b.ssSTInternal_to_provider_configs) return false;
return true;
}

public static bool operator != (RC_3f581e27c2f72d4f78b5674dc475102b a, RC_3f581e27c2f72d4f78b5674dc475102b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3f581e27c2f72d4f78b5674dc475102b)) return false;
return (this == (RC_3f581e27c2f72d4f78b5674dc475102b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_configs.InternalRecursiveSave();
}


public RC_3f581e27c2f72d4f78b5674dc475102b Duplicate() {
RC_3f581e27c2f72d4f78b5674dc475102b t;
t.ssSTInternal_to_provider_configs = (ST_5baae74ed57e3bb61180aff1dadec4e1Structure)this.ssSTInternal_to_provider_configs.Duplicate();
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
if (head == "internal_to_provider_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_configs")) variable.Value = ssSTInternal_to_provider_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_configs");
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
if (key == IdInternal_to_provider_configs) {
return ssSTInternal_to_provider_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_configs.Key.AsGuid) {
return ssSTInternal_to_provider_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_configs));
}
} // RC_3f581e27c2f72d4f78b5674dc475102b
/// <summary>
/// RecordList type <code>Internal_to_provider_configsRecordList</code> that represents a record list
///  of <code>Internal_to_provider_configs</code>
/// </summary>
public partial class RL_212aa4d4c8fbd8bd92eb665c5f5a19bc : GenericRecordList<RC_3f581e27c2f72d4f78b5674dc475102b>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3f581e27c2f72d4f78b5674dc475102b GetElementDefaultValue() {
return new RC_3f581e27c2f72d4f78b5674dc475102b();
}

public T[] ToArray<T>(Func<RC_3f581e27c2f72d4f78b5674dc475102b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_212aa4d4c8fbd8bd92eb665c5f5a19bc recordList, Func<RC_3f581e27c2f72d4f78b5674dc475102b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_212aa4d4c8fbd8bd92eb665c5f5a19bc(RC_3f581e27c2f72d4f78b5674dc475102b[] array) {
  RL_212aa4d4c8fbd8bd92eb665c5f5a19bc result = new RL_212aa4d4c8fbd8bd92eb665c5f5a19bc();
result.InnerFromArray(array);
    return result;
}

public static RL_212aa4d4c8fbd8bd92eb665c5f5a19bc ToList<T>(T[] array, Func <T, RC_3f581e27c2f72d4f78b5674dc475102b> converter) {
  RL_212aa4d4c8fbd8bd92eb665c5f5a19bc result = new RL_212aa4d4c8fbd8bd92eb665c5f5a19bc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_212aa4d4c8fbd8bd92eb665c5f5a19bc FromRestList<T>(RestList<T> restList, Func <T, RC_3f581e27c2f72d4f78b5674dc475102b> converter) {
  RL_212aa4d4c8fbd8bd92eb665c5f5a19bc result = new RL_212aa4d4c8fbd8bd92eb665c5f5a19bc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_212aa4d4c8fbd8bd92eb665c5f5a19bc() : base() {
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
protected override OSList<RC_3f581e27c2f72d4f78b5674dc475102b> NewList() {
return new RL_212aa4d4c8fbd8bd92eb665c5f5a19bc();
}


} // RL_212aa4d4c8fbd8bd92eb665c5f5a19bc
}

