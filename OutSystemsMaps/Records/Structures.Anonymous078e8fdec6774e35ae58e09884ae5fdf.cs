namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (3o+OB3fGNU6uWOCYhK5f3w)
///  <code>RC_31c29444fafad199d1156f5f03b41f57</code> that represent
/// s <code>Internal_SearchPlaces_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_SearchPlaces_ConfigsRecord
public partial struct RC_31c29444fafad199d1156f5f03b41f57 : ITypedRecord<RC_31c29444fafad199d1156f5f03b41f57> {
internal static readonly GlobalObjectKey IdInternal_SearchPlaces_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RJTCMfr6mdHRFW9fA7QfVw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_SearchPlaces_Configs")]
public ST_b0933bf7957301c22e5d9229ad792ac0Structure ssSTInternal_SearchPlaces_Configs;


public static implicit operator ST_b0933bf7957301c22e5d9229ad792ac0Structure( RC_31c29444fafad199d1156f5f03b41f57 r) {
return r.ssSTInternal_SearchPlaces_Configs;
}

public static implicit operator RC_31c29444fafad199d1156f5f03b41f57 (ST_b0933bf7957301c22e5d9229ad792ac0Structure r) {
RC_31c29444fafad199d1156f5f03b41f57 res = new RC_31c29444fafad199d1156f5f03b41f57 ();
res.ssSTInternal_SearchPlaces_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_31c29444fafad199d1156f5f03b41f57() {
OptimizedAttributes = null;
ssSTInternal_SearchPlaces_Configs = new ST_b0933bf7957301c22e5d9229ad792ac0Structure();
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
    ssSTInternal_SearchPlaces_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_SearchPlaces_Configs.Read( r, ref index);
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
public void ReadIM(RC_31c29444fafad199d1156f5f03b41f57 r) {
this = r;
}


public static bool operator == (RC_31c29444fafad199d1156f5f03b41f57 a, RC_31c29444fafad199d1156f5f03b41f57 b) {
if (a.ssSTInternal_SearchPlaces_Configs != b.ssSTInternal_SearchPlaces_Configs) return false;
return true;
}

public static bool operator != (RC_31c29444fafad199d1156f5f03b41f57 a, RC_31c29444fafad199d1156f5f03b41f57 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_31c29444fafad199d1156f5f03b41f57)) return false;
return (this == (RC_31c29444fafad199d1156f5f03b41f57)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_SearchPlaces_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_SearchPlaces_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_SearchPlaces_Configs.InternalRecursiveSave();
}


public RC_31c29444fafad199d1156f5f03b41f57 Duplicate() {
RC_31c29444fafad199d1156f5f03b41f57 t;
t.ssSTInternal_SearchPlaces_Configs = (ST_b0933bf7957301c22e5d9229ad792ac0Structure)this.ssSTInternal_SearchPlaces_Configs.Duplicate();
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
if (head == "internal_searchplaces_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_SearchPlaces_Configs")) variable.Value = ssSTInternal_SearchPlaces_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_searchplaces_configs");
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
if (key == IdInternal_SearchPlaces_Configs) {
return ssSTInternal_SearchPlaces_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_SearchPlaces_Configs.Key.AsGuid) {
return ssSTInternal_SearchPlaces_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_SearchPlaces_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_SearchPlaces_Configs));
}
} // RC_31c29444fafad199d1156f5f03b41f57
/// <summary>
/// RecordList type <code>Internal_SearchPlaces_ConfigsRecordList</code> that represents a record list
///  of <code>Internal_SearchPlaces_Configs</code>
/// </summary>
public partial class RL_f165a17d72270107d404a3e103dad392 : GenericRecordList<RC_31c29444fafad199d1156f5f03b41f57>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_31c29444fafad199d1156f5f03b41f57 GetElementDefaultValue() {
return new RC_31c29444fafad199d1156f5f03b41f57();
}

public T[] ToArray<T>(Func<RC_31c29444fafad199d1156f5f03b41f57, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f165a17d72270107d404a3e103dad392 recordList, Func<RC_31c29444fafad199d1156f5f03b41f57, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f165a17d72270107d404a3e103dad392(RC_31c29444fafad199d1156f5f03b41f57[] array) {
  RL_f165a17d72270107d404a3e103dad392 result = new RL_f165a17d72270107d404a3e103dad392();
result.InnerFromArray(array);
    return result;
}

public static RL_f165a17d72270107d404a3e103dad392 ToList<T>(T[] array, Func <T, RC_31c29444fafad199d1156f5f03b41f57> converter) {
  RL_f165a17d72270107d404a3e103dad392 result = new RL_f165a17d72270107d404a3e103dad392();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f165a17d72270107d404a3e103dad392 FromRestList<T>(RestList<T> restList, Func <T, RC_31c29444fafad199d1156f5f03b41f57> converter) {
  RL_f165a17d72270107d404a3e103dad392 result = new RL_f165a17d72270107d404a3e103dad392();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f165a17d72270107d404a3e103dad392() : base() {
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
protected override OSList<RC_31c29444fafad199d1156f5f03b41f57> NewList() {
return new RL_f165a17d72270107d404a3e103dad392();
}


} // RL_f165a17d72270107d404a3e103dad392
}

