namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (ejCLtTsnm0et3+XxAIT6wg)
///  <code>RC_d566c0a27b8928cd9ecc06f062d869f4</code> that represent
/// s <code>Internal_to_provider_shape_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_shape_configsRecord
public partial struct RC_d566c0a27b8928cd9ecc06f062d869f4 : ITypedRecord<RC_d566c0a27b8928cd9ecc06f062d869f4> {
internal static readonly GlobalObjectKey IdInternal_to_provider_shape_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osBm1Yl7zSiezAbwYthp9A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_shape_configs")]
public ST_4d96f69748c4f35fb433f7995d061407Structure ssSTInternal_to_provider_shape_configs;


public static implicit operator ST_4d96f69748c4f35fb433f7995d061407Structure( RC_d566c0a27b8928cd9ecc06f062d869f4 r) {
return r.ssSTInternal_to_provider_shape_configs;
}

public static implicit operator RC_d566c0a27b8928cd9ecc06f062d869f4 (ST_4d96f69748c4f35fb433f7995d061407Structure r) {
RC_d566c0a27b8928cd9ecc06f062d869f4 res = new RC_d566c0a27b8928cd9ecc06f062d869f4 ();
res.ssSTInternal_to_provider_shape_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d566c0a27b8928cd9ecc06f062d869f4() {
OptimizedAttributes = null;
ssSTInternal_to_provider_shape_configs = new ST_4d96f69748c4f35fb433f7995d061407Structure();
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
    ssSTInternal_to_provider_shape_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_shape_configs.Read( r, ref index);
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
public void ReadIM(RC_d566c0a27b8928cd9ecc06f062d869f4 r) {
this = r;
}


public static bool operator == (RC_d566c0a27b8928cd9ecc06f062d869f4 a, RC_d566c0a27b8928cd9ecc06f062d869f4 b) {
if (a.ssSTInternal_to_provider_shape_configs != b.ssSTInternal_to_provider_shape_configs) return false;
return true;
}

public static bool operator != (RC_d566c0a27b8928cd9ecc06f062d869f4 a, RC_d566c0a27b8928cd9ecc06f062d869f4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d566c0a27b8928cd9ecc06f062d869f4)) return false;
return (this == (RC_d566c0a27b8928cd9ecc06f062d869f4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_shape_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_shape_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_shape_configs.InternalRecursiveSave();
}


public RC_d566c0a27b8928cd9ecc06f062d869f4 Duplicate() {
RC_d566c0a27b8928cd9ecc06f062d869f4 t;
t.ssSTInternal_to_provider_shape_configs = (ST_4d96f69748c4f35fb433f7995d061407Structure)this.ssSTInternal_to_provider_shape_configs.Duplicate();
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
if (head == "internal_to_provider_shape_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_shape_configs")) variable.Value = ssSTInternal_to_provider_shape_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_shape_configs");
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
if (key == IdInternal_to_provider_shape_configs) {
return ssSTInternal_to_provider_shape_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_shape_configs.Key.AsGuid) {
return ssSTInternal_to_provider_shape_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_shape_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_shape_configs));
}
} // RC_d566c0a27b8928cd9ecc06f062d869f4
/// <summary>
/// RecordList type <code>Internal_to_provider_shape_configsRecordList</code> that represents a record
///  list of <code>Internal_to_provider_shape_configs</code>
/// </summary>
public partial class RL_026241dd021d92fba8dbd1e2ecd28058 : GenericRecordList<RC_d566c0a27b8928cd9ecc06f062d869f4>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d566c0a27b8928cd9ecc06f062d869f4 GetElementDefaultValue() {
return new RC_d566c0a27b8928cd9ecc06f062d869f4();
}

public T[] ToArray<T>(Func<RC_d566c0a27b8928cd9ecc06f062d869f4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_026241dd021d92fba8dbd1e2ecd28058 recordList, Func<RC_d566c0a27b8928cd9ecc06f062d869f4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_026241dd021d92fba8dbd1e2ecd28058(RC_d566c0a27b8928cd9ecc06f062d869f4[] array) {
  RL_026241dd021d92fba8dbd1e2ecd28058 result = new RL_026241dd021d92fba8dbd1e2ecd28058();
result.InnerFromArray(array);
    return result;
}

public static RL_026241dd021d92fba8dbd1e2ecd28058 ToList<T>(T[] array, Func <T, RC_d566c0a27b8928cd9ecc06f062d869f4> converter) {
  RL_026241dd021d92fba8dbd1e2ecd28058 result = new RL_026241dd021d92fba8dbd1e2ecd28058();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_026241dd021d92fba8dbd1e2ecd28058 FromRestList<T>(RestList<T> restList, Func <T, RC_d566c0a27b8928cd9ecc06f062d869f4> converter) {
  RL_026241dd021d92fba8dbd1e2ecd28058 result = new RL_026241dd021d92fba8dbd1e2ecd28058();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_026241dd021d92fba8dbd1e2ecd28058() : base() {
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
protected override OSList<RC_d566c0a27b8928cd9ecc06f062d869f4> NewList() {
return new RL_026241dd021d92fba8dbd1e2ecd28058();
}


} // RL_026241dd021d92fba8dbd1e2ecd28058
}

