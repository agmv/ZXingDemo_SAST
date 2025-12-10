namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (v+h9pZCHVkyF8AeDmEOfTg)
///  <code>RC_a7db230a655a3c54e1e9a992db69e805</code> that represent
/// s <code>Internal_DrawPolygon_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawPolygon_ConfigsRecord
public partial struct RC_a7db230a655a3c54e1e9a992db69e805 : ITypedRecord<RC_a7db230a655a3c54e1e9a992db69e805> {
internal static readonly GlobalObjectKey IdInternal_DrawPolygon_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CiPbp1plVDzh6amS22noBQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawPolygon_Configs")]
public ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure ssSTInternal_DrawPolygon_Configs;


public static implicit operator ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure( RC_a7db230a655a3c54e1e9a992db69e805 r) {
return r.ssSTInternal_DrawPolygon_Configs;
}

public static implicit operator RC_a7db230a655a3c54e1e9a992db69e805 (ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure r) {
RC_a7db230a655a3c54e1e9a992db69e805 res = new RC_a7db230a655a3c54e1e9a992db69e805 ();
res.ssSTInternal_DrawPolygon_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a7db230a655a3c54e1e9a992db69e805() {
OptimizedAttributes = null;
ssSTInternal_DrawPolygon_Configs = new ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure();
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
    ssSTInternal_DrawPolygon_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_DrawPolygon_Configs.Read( r, ref index);
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
public void ReadIM(RC_a7db230a655a3c54e1e9a992db69e805 r) {
this = r;
}


public static bool operator == (RC_a7db230a655a3c54e1e9a992db69e805 a, RC_a7db230a655a3c54e1e9a992db69e805 b) {
if (a.ssSTInternal_DrawPolygon_Configs != b.ssSTInternal_DrawPolygon_Configs) return false;
return true;
}

public static bool operator != (RC_a7db230a655a3c54e1e9a992db69e805 a, RC_a7db230a655a3c54e1e9a992db69e805 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a7db230a655a3c54e1e9a992db69e805)) return false;
return (this == (RC_a7db230a655a3c54e1e9a992db69e805)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawPolygon_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawPolygon_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawPolygon_Configs.InternalRecursiveSave();
}


public RC_a7db230a655a3c54e1e9a992db69e805 Duplicate() {
RC_a7db230a655a3c54e1e9a992db69e805 t;
t.ssSTInternal_DrawPolygon_Configs = (ST_707b1ead9a0d000606d8b9e0cca3c3f9Structure)this.ssSTInternal_DrawPolygon_Configs.Duplicate();
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
if (head == "internal_drawpolygon_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawPolygon_Configs")) variable.Value = ssSTInternal_DrawPolygon_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_drawpolygon_configs");
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
if (key == IdInternal_DrawPolygon_Configs) {
return ssSTInternal_DrawPolygon_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawPolygon_Configs.Key.AsGuid) {
return ssSTInternal_DrawPolygon_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawPolygon_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawPolygon_Configs));
}
} // RC_a7db230a655a3c54e1e9a992db69e805
/// <summary>
/// RecordList type <code>Internal_DrawPolygon_ConfigsRecordList</code> that represents a record list
///  of <code>Internal_DrawPolygon_Configs</code>
/// </summary>
public partial class RL_7a74e72b910069480737293f8c18c808 : GenericRecordList<RC_a7db230a655a3c54e1e9a992db69e805>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a7db230a655a3c54e1e9a992db69e805 GetElementDefaultValue() {
return new RC_a7db230a655a3c54e1e9a992db69e805();
}

public T[] ToArray<T>(Func<RC_a7db230a655a3c54e1e9a992db69e805, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7a74e72b910069480737293f8c18c808 recordList, Func<RC_a7db230a655a3c54e1e9a992db69e805, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7a74e72b910069480737293f8c18c808(RC_a7db230a655a3c54e1e9a992db69e805[] array) {
  RL_7a74e72b910069480737293f8c18c808 result = new RL_7a74e72b910069480737293f8c18c808();
result.InnerFromArray(array);
    return result;
}

public static RL_7a74e72b910069480737293f8c18c808 ToList<T>(T[] array, Func <T, RC_a7db230a655a3c54e1e9a992db69e805> converter) {
  RL_7a74e72b910069480737293f8c18c808 result = new RL_7a74e72b910069480737293f8c18c808();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7a74e72b910069480737293f8c18c808 FromRestList<T>(RestList<T> restList, Func <T, RC_a7db230a655a3c54e1e9a992db69e805> converter) {
  RL_7a74e72b910069480737293f8c18c808 result = new RL_7a74e72b910069480737293f8c18c808();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7a74e72b910069480737293f8c18c808() : base() {
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
protected override OSList<RC_a7db230a655a3c54e1e9a992db69e805> NewList() {
return new RL_7a74e72b910069480737293f8c18c808();
}


} // RL_7a74e72b910069480737293f8c18c808
}

