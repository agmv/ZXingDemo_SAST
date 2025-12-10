namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (CsvSeQS0ukKA7yS_jRPf+w)
///  <code>RC_fc0e8940fcfc7ecaecb548b5cf8eab5d</code> that represent
/// s <code>Internal_to_provider_marker_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_marker_configsRecord
public partial struct RC_fc0e8940fcfc7ecaecb548b5cf8eab5d : ITypedRecord<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> {
internal static readonly GlobalObjectKey IdInternal_to_provider_marker_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QIkO_Pz8yn7stUi1z46rXQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_marker_configs")]
public ST_51ef6a78944132edc56aa7bf7c4ea240Structure ssSTInternal_to_provider_marker_configs;


public static implicit operator ST_51ef6a78944132edc56aa7bf7c4ea240Structure( RC_fc0e8940fcfc7ecaecb548b5cf8eab5d r) {
return r.ssSTInternal_to_provider_marker_configs;
}

public static implicit operator RC_fc0e8940fcfc7ecaecb548b5cf8eab5d (ST_51ef6a78944132edc56aa7bf7c4ea240Structure r) {
RC_fc0e8940fcfc7ecaecb548b5cf8eab5d res = new RC_fc0e8940fcfc7ecaecb548b5cf8eab5d ();
res.ssSTInternal_to_provider_marker_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fc0e8940fcfc7ecaecb548b5cf8eab5d() {
OptimizedAttributes = null;
ssSTInternal_to_provider_marker_configs = new ST_51ef6a78944132edc56aa7bf7c4ea240Structure();
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
    ssSTInternal_to_provider_marker_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_marker_configs.Read( r, ref index);
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
public void ReadIM(RC_fc0e8940fcfc7ecaecb548b5cf8eab5d r) {
this = r;
}


public static bool operator == (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d a, RC_fc0e8940fcfc7ecaecb548b5cf8eab5d b) {
if (a.ssSTInternal_to_provider_marker_configs != b.ssSTInternal_to_provider_marker_configs) return false;
return true;
}

public static bool operator != (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d a, RC_fc0e8940fcfc7ecaecb548b5cf8eab5d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d)) return false;
return (this == (RC_fc0e8940fcfc7ecaecb548b5cf8eab5d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_marker_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_marker_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_marker_configs.InternalRecursiveSave();
}


public RC_fc0e8940fcfc7ecaecb548b5cf8eab5d Duplicate() {
RC_fc0e8940fcfc7ecaecb548b5cf8eab5d t;
t.ssSTInternal_to_provider_marker_configs = (ST_51ef6a78944132edc56aa7bf7c4ea240Structure)this.ssSTInternal_to_provider_marker_configs.Duplicate();
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
if (head == "internal_to_provider_marker_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_marker_configs")) variable.Value = ssSTInternal_to_provider_marker_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_marker_configs");
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
if (key == IdInternal_to_provider_marker_configs) {
return ssSTInternal_to_provider_marker_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_marker_configs.Key.AsGuid) {
return ssSTInternal_to_provider_marker_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_marker_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_marker_configs));
}
} // RC_fc0e8940fcfc7ecaecb548b5cf8eab5d
/// <summary>
/// RecordList type <code>Internal_to_provider_marker_configsRecordList</code> that represents a record
///  list of <code>Internal_to_provider_marker_configs</code>
/// </summary>
public partial class RL_cad5f90c9ef8be32dc11b1b88fcde135 : GenericRecordList<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_fc0e8940fcfc7ecaecb548b5cf8eab5d GetElementDefaultValue() {
return new RC_fc0e8940fcfc7ecaecb548b5cf8eab5d();
}

public T[] ToArray<T>(Func<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cad5f90c9ef8be32dc11b1b88fcde135 recordList, Func<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cad5f90c9ef8be32dc11b1b88fcde135(RC_fc0e8940fcfc7ecaecb548b5cf8eab5d[] array) {
  RL_cad5f90c9ef8be32dc11b1b88fcde135 result = new RL_cad5f90c9ef8be32dc11b1b88fcde135();
result.InnerFromArray(array);
    return result;
}

public static RL_cad5f90c9ef8be32dc11b1b88fcde135 ToList<T>(T[] array, Func <T, RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> converter) {
  RL_cad5f90c9ef8be32dc11b1b88fcde135 result = new RL_cad5f90c9ef8be32dc11b1b88fcde135();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cad5f90c9ef8be32dc11b1b88fcde135 FromRestList<T>(RestList<T> restList, Func <T, RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> converter) {
  RL_cad5f90c9ef8be32dc11b1b88fcde135 result = new RL_cad5f90c9ef8be32dc11b1b88fcde135();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cad5f90c9ef8be32dc11b1b88fcde135() : base() {
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
protected override OSList<RC_fc0e8940fcfc7ecaecb548b5cf8eab5d> NewList() {
return new RL_cad5f90c9ef8be32dc11b1b88fcde135();
}


} // RL_cad5f90c9ef8be32dc11b1b88fcde135
}

