namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (22J0R3u9TkK9MRFzBCyHlw)
///  <code>RC_ac174f96b960b9152d73b4583f3f4d43</code> that represent
/// s <code>Internal_DrawPolyline_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawPolyline_ConfigsRecord
public partial struct RC_ac174f96b960b9152d73b4583f3f4d43 : ITypedRecord<RC_ac174f96b960b9152d73b4583f3f4d43> {
internal static readonly GlobalObjectKey IdInternal_DrawPolyline_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lk8XrGC5Fbktc7RYPz9NQw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawPolyline_Configs")]
public ST_5223ca706bfb3de574fb0b39ebba3fb6Structure ssSTInternal_DrawPolyline_Configs;


public static implicit operator ST_5223ca706bfb3de574fb0b39ebba3fb6Structure( RC_ac174f96b960b9152d73b4583f3f4d43 r) {
return r.ssSTInternal_DrawPolyline_Configs;
}

public static implicit operator RC_ac174f96b960b9152d73b4583f3f4d43 (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure r) {
RC_ac174f96b960b9152d73b4583f3f4d43 res = new RC_ac174f96b960b9152d73b4583f3f4d43 ();
res.ssSTInternal_DrawPolyline_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ac174f96b960b9152d73b4583f3f4d43() {
OptimizedAttributes = null;
ssSTInternal_DrawPolyline_Configs = new ST_5223ca706bfb3de574fb0b39ebba3fb6Structure();
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
    ssSTInternal_DrawPolyline_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_DrawPolyline_Configs.Read( r, ref index);
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
public void ReadIM(RC_ac174f96b960b9152d73b4583f3f4d43 r) {
this = r;
}


public static bool operator == (RC_ac174f96b960b9152d73b4583f3f4d43 a, RC_ac174f96b960b9152d73b4583f3f4d43 b) {
if (a.ssSTInternal_DrawPolyline_Configs != b.ssSTInternal_DrawPolyline_Configs) return false;
return true;
}

public static bool operator != (RC_ac174f96b960b9152d73b4583f3f4d43 a, RC_ac174f96b960b9152d73b4583f3f4d43 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ac174f96b960b9152d73b4583f3f4d43)) return false;
return (this == (RC_ac174f96b960b9152d73b4583f3f4d43)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawPolyline_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawPolyline_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawPolyline_Configs.InternalRecursiveSave();
}


public RC_ac174f96b960b9152d73b4583f3f4d43 Duplicate() {
RC_ac174f96b960b9152d73b4583f3f4d43 t;
t.ssSTInternal_DrawPolyline_Configs = (ST_5223ca706bfb3de574fb0b39ebba3fb6Structure)this.ssSTInternal_DrawPolyline_Configs.Duplicate();
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
if (head == "internal_drawpolyline_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawPolyline_Configs")) variable.Value = ssSTInternal_DrawPolyline_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_drawpolyline_configs");
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
if (key == IdInternal_DrawPolyline_Configs) {
return ssSTInternal_DrawPolyline_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawPolyline_Configs.Key.AsGuid) {
return ssSTInternal_DrawPolyline_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawPolyline_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawPolyline_Configs));
}
} // RC_ac174f96b960b9152d73b4583f3f4d43
/// <summary>
/// RecordList type <code>Internal_DrawPolyline_ConfigsRecordList</code> that represents a record list
///  of <code>Internal_DrawPolyline_Configs</code>
/// </summary>
public partial class RL_3d32ef0bcad58dedcfa8b601d0da2302 : GenericRecordList<RC_ac174f96b960b9152d73b4583f3f4d43>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_ac174f96b960b9152d73b4583f3f4d43 GetElementDefaultValue() {
return new RC_ac174f96b960b9152d73b4583f3f4d43();
}

public T[] ToArray<T>(Func<RC_ac174f96b960b9152d73b4583f3f4d43, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d32ef0bcad58dedcfa8b601d0da2302 recordList, Func<RC_ac174f96b960b9152d73b4583f3f4d43, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d32ef0bcad58dedcfa8b601d0da2302(RC_ac174f96b960b9152d73b4583f3f4d43[] array) {
  RL_3d32ef0bcad58dedcfa8b601d0da2302 result = new RL_3d32ef0bcad58dedcfa8b601d0da2302();
result.InnerFromArray(array);
    return result;
}

public static RL_3d32ef0bcad58dedcfa8b601d0da2302 ToList<T>(T[] array, Func <T, RC_ac174f96b960b9152d73b4583f3f4d43> converter) {
  RL_3d32ef0bcad58dedcfa8b601d0da2302 result = new RL_3d32ef0bcad58dedcfa8b601d0da2302();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d32ef0bcad58dedcfa8b601d0da2302 FromRestList<T>(RestList<T> restList, Func <T, RC_ac174f96b960b9152d73b4583f3f4d43> converter) {
  RL_3d32ef0bcad58dedcfa8b601d0da2302 result = new RL_3d32ef0bcad58dedcfa8b601d0da2302();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d32ef0bcad58dedcfa8b601d0da2302() : base() {
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
protected override OSList<RC_ac174f96b960b9152d73b4583f3f4d43> NewList() {
return new RL_3d32ef0bcad58dedcfa8b601d0da2302();
}


} // RL_3d32ef0bcad58dedcfa8b601d0da2302
}

