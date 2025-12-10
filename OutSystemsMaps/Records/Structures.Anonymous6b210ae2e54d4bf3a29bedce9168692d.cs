namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (4goha03l80uim+3OkWhpLQ)
///  <code>RC_0cc9882276464f8a42abc2516db92c70</code> that represent
/// s <code>Internal_FileLayer_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_FileLayer_ConfigsRecord
public partial struct RC_0cc9882276464f8a42abc2516db92c70 : ITypedRecord<RC_0cc9882276464f8a42abc2516db92c70> {
internal static readonly GlobalObjectKey IdInternal_FileLayer_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IojJDEZ2ik9Cq8JRbbkscA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_FileLayer_Configs")]
public ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure ssSTInternal_FileLayer_Configs;


public static implicit operator ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure( RC_0cc9882276464f8a42abc2516db92c70 r) {
return r.ssSTInternal_FileLayer_Configs;
}

public static implicit operator RC_0cc9882276464f8a42abc2516db92c70 (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure r) {
RC_0cc9882276464f8a42abc2516db92c70 res = new RC_0cc9882276464f8a42abc2516db92c70 ();
res.ssSTInternal_FileLayer_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0cc9882276464f8a42abc2516db92c70() {
OptimizedAttributes = null;
ssSTInternal_FileLayer_Configs = new ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure();
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
    ssSTInternal_FileLayer_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_FileLayer_Configs.Read( r, ref index);
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
public void ReadIM(RC_0cc9882276464f8a42abc2516db92c70 r) {
this = r;
}


public static bool operator == (RC_0cc9882276464f8a42abc2516db92c70 a, RC_0cc9882276464f8a42abc2516db92c70 b) {
if (a.ssSTInternal_FileLayer_Configs != b.ssSTInternal_FileLayer_Configs) return false;
return true;
}

public static bool operator != (RC_0cc9882276464f8a42abc2516db92c70 a, RC_0cc9882276464f8a42abc2516db92c70 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0cc9882276464f8a42abc2516db92c70)) return false;
return (this == (RC_0cc9882276464f8a42abc2516db92c70)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_FileLayer_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_FileLayer_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_FileLayer_Configs.InternalRecursiveSave();
}


public RC_0cc9882276464f8a42abc2516db92c70 Duplicate() {
RC_0cc9882276464f8a42abc2516db92c70 t;
t.ssSTInternal_FileLayer_Configs = (ST_1a3d048e7bc3b165cd3ddc45ef640b18Structure)this.ssSTInternal_FileLayer_Configs.Duplicate();
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
if (head == "internal_filelayer_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_FileLayer_Configs")) variable.Value = ssSTInternal_FileLayer_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_filelayer_configs");
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
if (key == IdInternal_FileLayer_Configs) {
return ssSTInternal_FileLayer_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_FileLayer_Configs.Key.AsGuid) {
return ssSTInternal_FileLayer_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_FileLayer_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_FileLayer_Configs));
}
} // RC_0cc9882276464f8a42abc2516db92c70
/// <summary>
/// RecordList type <code>Internal_FileLayer_ConfigsRecordList</code> that represents a record list of
///  <code>Internal_FileLayer_Configs</code>
/// </summary>
public partial class RL_65a208a4b9c539b70f4154cb275ecc23 : GenericRecordList<RC_0cc9882276464f8a42abc2516db92c70>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0cc9882276464f8a42abc2516db92c70 GetElementDefaultValue() {
return new RC_0cc9882276464f8a42abc2516db92c70();
}

public T[] ToArray<T>(Func<RC_0cc9882276464f8a42abc2516db92c70, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_65a208a4b9c539b70f4154cb275ecc23 recordList, Func<RC_0cc9882276464f8a42abc2516db92c70, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_65a208a4b9c539b70f4154cb275ecc23(RC_0cc9882276464f8a42abc2516db92c70[] array) {
  RL_65a208a4b9c539b70f4154cb275ecc23 result = new RL_65a208a4b9c539b70f4154cb275ecc23();
result.InnerFromArray(array);
    return result;
}

public static RL_65a208a4b9c539b70f4154cb275ecc23 ToList<T>(T[] array, Func <T, RC_0cc9882276464f8a42abc2516db92c70> converter) {
  RL_65a208a4b9c539b70f4154cb275ecc23 result = new RL_65a208a4b9c539b70f4154cb275ecc23();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_65a208a4b9c539b70f4154cb275ecc23 FromRestList<T>(RestList<T> restList, Func <T, RC_0cc9882276464f8a42abc2516db92c70> converter) {
  RL_65a208a4b9c539b70f4154cb275ecc23 result = new RL_65a208a4b9c539b70f4154cb275ecc23();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_65a208a4b9c539b70f4154cb275ecc23() : base() {
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
protected override OSList<RC_0cc9882276464f8a42abc2516db92c70> NewList() {
return new RL_65a208a4b9c539b70f4154cb275ecc23();
}


} // RL_65a208a4b9c539b70f4154cb275ecc23
}

