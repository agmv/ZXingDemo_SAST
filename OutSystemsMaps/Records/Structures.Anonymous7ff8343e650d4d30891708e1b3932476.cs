namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (PjT4fw1lME2JFwjhs5Mkdg)
///  <code>RC_2f373495341cd6d1bc0753ee5c713769</code> that represent
/// s <code>Internal_HeatmapLayer_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_HeatmapLayer_ConfigsRecord
public partial struct RC_2f373495341cd6d1bc0753ee5c713769 : ITypedRecord<RC_2f373495341cd6d1bc0753ee5c713769> {
internal static readonly GlobalObjectKey IdInternal_HeatmapLayer_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lTQ3Lxw00da8B1PuXHE3aQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_HeatmapLayer_Configs")]
public ST_f2c047cd8082950bd1961446a5ec1949Structure ssSTInternal_HeatmapLayer_Configs;


public static implicit operator ST_f2c047cd8082950bd1961446a5ec1949Structure( RC_2f373495341cd6d1bc0753ee5c713769 r) {
return r.ssSTInternal_HeatmapLayer_Configs;
}

public static implicit operator RC_2f373495341cd6d1bc0753ee5c713769 (ST_f2c047cd8082950bd1961446a5ec1949Structure r) {
RC_2f373495341cd6d1bc0753ee5c713769 res = new RC_2f373495341cd6d1bc0753ee5c713769 ();
res.ssSTInternal_HeatmapLayer_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2f373495341cd6d1bc0753ee5c713769() {
OptimizedAttributes = null;
ssSTInternal_HeatmapLayer_Configs = new ST_f2c047cd8082950bd1961446a5ec1949Structure();
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
    ssSTInternal_HeatmapLayer_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_HeatmapLayer_Configs.Read( r, ref index);
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
public void ReadIM(RC_2f373495341cd6d1bc0753ee5c713769 r) {
this = r;
}


public static bool operator == (RC_2f373495341cd6d1bc0753ee5c713769 a, RC_2f373495341cd6d1bc0753ee5c713769 b) {
if (a.ssSTInternal_HeatmapLayer_Configs != b.ssSTInternal_HeatmapLayer_Configs) return false;
return true;
}

public static bool operator != (RC_2f373495341cd6d1bc0753ee5c713769 a, RC_2f373495341cd6d1bc0753ee5c713769 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2f373495341cd6d1bc0753ee5c713769)) return false;
return (this == (RC_2f373495341cd6d1bc0753ee5c713769)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_HeatmapLayer_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_HeatmapLayer_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_HeatmapLayer_Configs.InternalRecursiveSave();
}


public RC_2f373495341cd6d1bc0753ee5c713769 Duplicate() {
RC_2f373495341cd6d1bc0753ee5c713769 t;
t.ssSTInternal_HeatmapLayer_Configs = (ST_f2c047cd8082950bd1961446a5ec1949Structure)this.ssSTInternal_HeatmapLayer_Configs.Duplicate();
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
if (head == "internal_heatmaplayer_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_HeatmapLayer_Configs")) variable.Value = ssSTInternal_HeatmapLayer_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_heatmaplayer_configs");
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
if (key == IdInternal_HeatmapLayer_Configs) {
return ssSTInternal_HeatmapLayer_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_HeatmapLayer_Configs.Key.AsGuid) {
return ssSTInternal_HeatmapLayer_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_HeatmapLayer_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_HeatmapLayer_Configs));
}
} // RC_2f373495341cd6d1bc0753ee5c713769
/// <summary>
/// RecordList type <code>Internal_HeatmapLayer_ConfigsRecordList</code> that represents a record list
///  of <code>Internal_HeatmapLayer_Configs</code>
/// </summary>
public partial class RL_e2e6af3569ea21958dbed7a8ee6756e7 : GenericRecordList<RC_2f373495341cd6d1bc0753ee5c713769>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2f373495341cd6d1bc0753ee5c713769 GetElementDefaultValue() {
return new RC_2f373495341cd6d1bc0753ee5c713769();
}

public T[] ToArray<T>(Func<RC_2f373495341cd6d1bc0753ee5c713769, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2e6af3569ea21958dbed7a8ee6756e7 recordList, Func<RC_2f373495341cd6d1bc0753ee5c713769, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2e6af3569ea21958dbed7a8ee6756e7(RC_2f373495341cd6d1bc0753ee5c713769[] array) {
  RL_e2e6af3569ea21958dbed7a8ee6756e7 result = new RL_e2e6af3569ea21958dbed7a8ee6756e7();
result.InnerFromArray(array);
    return result;
}

public static RL_e2e6af3569ea21958dbed7a8ee6756e7 ToList<T>(T[] array, Func <T, RC_2f373495341cd6d1bc0753ee5c713769> converter) {
  RL_e2e6af3569ea21958dbed7a8ee6756e7 result = new RL_e2e6af3569ea21958dbed7a8ee6756e7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2e6af3569ea21958dbed7a8ee6756e7 FromRestList<T>(RestList<T> restList, Func <T, RC_2f373495341cd6d1bc0753ee5c713769> converter) {
  RL_e2e6af3569ea21958dbed7a8ee6756e7 result = new RL_e2e6af3569ea21958dbed7a8ee6756e7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2e6af3569ea21958dbed7a8ee6756e7() : base() {
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
protected override OSList<RC_2f373495341cd6d1bc0753ee5c713769> NewList() {
return new RL_e2e6af3569ea21958dbed7a8ee6756e7();
}


} // RL_e2e6af3569ea21958dbed7a8ee6756e7
}

