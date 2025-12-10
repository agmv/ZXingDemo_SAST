namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (BK4rV2HgZkKMOKhIvQp63A)
///  <code>RC_5b713573f61d6f7da10c24ba6dcff0a5</code> that represent
/// s <code>Internal_to_provider_searchPlaces_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_searchPlaces_configsRecord
public partial struct RC_5b713573f61d6f7da10c24ba6dcff0a5 : ITypedRecord<RC_5b713573f61d6f7da10c24ba6dcff0a5> {
internal static readonly GlobalObjectKey IdInternal_to_provider_searchPlaces_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*czVxWx32fW+hDCS6bc_wpQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_searchPlaces_configs")]
public ST_d4721898ae8c007cd938074f575e2979Structure ssSTInternal_to_provider_searchPlaces_configs;


public static implicit operator ST_d4721898ae8c007cd938074f575e2979Structure( RC_5b713573f61d6f7da10c24ba6dcff0a5 r) {
return r.ssSTInternal_to_provider_searchPlaces_configs;
}

public static implicit operator RC_5b713573f61d6f7da10c24ba6dcff0a5 (ST_d4721898ae8c007cd938074f575e2979Structure r) {
RC_5b713573f61d6f7da10c24ba6dcff0a5 res = new RC_5b713573f61d6f7da10c24ba6dcff0a5 ();
res.ssSTInternal_to_provider_searchPlaces_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5b713573f61d6f7da10c24ba6dcff0a5() {
OptimizedAttributes = null;
ssSTInternal_to_provider_searchPlaces_configs = new ST_d4721898ae8c007cd938074f575e2979Structure();
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
    ssSTInternal_to_provider_searchPlaces_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_searchPlaces_configs.Read( r, ref index);
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
public void ReadIM(RC_5b713573f61d6f7da10c24ba6dcff0a5 r) {
this = r;
}


public static bool operator == (RC_5b713573f61d6f7da10c24ba6dcff0a5 a, RC_5b713573f61d6f7da10c24ba6dcff0a5 b) {
if (a.ssSTInternal_to_provider_searchPlaces_configs != b.ssSTInternal_to_provider_searchPlaces_configs) return false;
return true;
}

public static bool operator != (RC_5b713573f61d6f7da10c24ba6dcff0a5 a, RC_5b713573f61d6f7da10c24ba6dcff0a5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5b713573f61d6f7da10c24ba6dcff0a5)) return false;
return (this == (RC_5b713573f61d6f7da10c24ba6dcff0a5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_searchPlaces_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_searchPlaces_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_searchPlaces_configs.InternalRecursiveSave();
}


public RC_5b713573f61d6f7da10c24ba6dcff0a5 Duplicate() {
RC_5b713573f61d6f7da10c24ba6dcff0a5 t;
t.ssSTInternal_to_provider_searchPlaces_configs = (ST_d4721898ae8c007cd938074f575e2979Structure)this.ssSTInternal_to_provider_searchPlaces_configs.Duplicate();
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
if (head == "internal_to_provider_searchplaces_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_searchPlaces_configs")) variable.Value = ssSTInternal_to_provider_searchPlaces_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_searchplaces_configs");
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
if (key == IdInternal_to_provider_searchPlaces_configs) {
return ssSTInternal_to_provider_searchPlaces_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_searchPlaces_configs.Key.AsGuid) {
return ssSTInternal_to_provider_searchPlaces_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_searchPlaces_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_searchPlaces_configs));
}
} // RC_5b713573f61d6f7da10c24ba6dcff0a5
/// <summary>
/// RecordList type <code>Internal_to_provider_searchPlaces_configsRecordList</code> that represents a
///  record list of <code>Internal_to_provider_searchPlaces_configs</code>
/// </summary>
public partial class RL_0a6dff1b0ed70563da6da4dc764c9f20 : GenericRecordList<RC_5b713573f61d6f7da10c24ba6dcff0a5>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_5b713573f61d6f7da10c24ba6dcff0a5 GetElementDefaultValue() {
return new RC_5b713573f61d6f7da10c24ba6dcff0a5();
}

public T[] ToArray<T>(Func<RC_5b713573f61d6f7da10c24ba6dcff0a5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a6dff1b0ed70563da6da4dc764c9f20 recordList, Func<RC_5b713573f61d6f7da10c24ba6dcff0a5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a6dff1b0ed70563da6da4dc764c9f20(RC_5b713573f61d6f7da10c24ba6dcff0a5[] array) {
  RL_0a6dff1b0ed70563da6da4dc764c9f20 result = new RL_0a6dff1b0ed70563da6da4dc764c9f20();
result.InnerFromArray(array);
    return result;
}

public static RL_0a6dff1b0ed70563da6da4dc764c9f20 ToList<T>(T[] array, Func <T, RC_5b713573f61d6f7da10c24ba6dcff0a5> converter) {
  RL_0a6dff1b0ed70563da6da4dc764c9f20 result = new RL_0a6dff1b0ed70563da6da4dc764c9f20();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a6dff1b0ed70563da6da4dc764c9f20 FromRestList<T>(RestList<T> restList, Func <T, RC_5b713573f61d6f7da10c24ba6dcff0a5> converter) {
  RL_0a6dff1b0ed70563da6da4dc764c9f20 result = new RL_0a6dff1b0ed70563da6da4dc764c9f20();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a6dff1b0ed70563da6da4dc764c9f20() : base() {
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
protected override OSList<RC_5b713573f61d6f7da10c24ba6dcff0a5> NewList() {
return new RL_0a6dff1b0ed70563da6da4dc764c9f20();
}


} // RL_0a6dff1b0ed70563da6da4dc764c9f20
}

