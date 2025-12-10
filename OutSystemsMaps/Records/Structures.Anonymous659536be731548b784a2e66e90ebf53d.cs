namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (vjaVZRVzt0iEouZukOv1PQ)
///  <code>RC_7f3fab599cac29adb40d23996cbe5a3b</code> that represent
/// s <code>Internal__Marker_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal__Marker_ConfigsRecord
public partial struct RC_7f3fab599cac29adb40d23996cbe5a3b : ITypedRecord<RC_7f3fab599cac29adb40d23996cbe5a3b> {
internal static readonly GlobalObjectKey IdInternal__Marker_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Was_f6ycrSm0DSOZbL5aOw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal__Marker_Configs")]
public ST_3d593ae1aad35ac58e1616049bb8da2cStructure ssSTInternal__Marker_Configs;


public static implicit operator ST_3d593ae1aad35ac58e1616049bb8da2cStructure( RC_7f3fab599cac29adb40d23996cbe5a3b r) {
return r.ssSTInternal__Marker_Configs;
}

public static implicit operator RC_7f3fab599cac29adb40d23996cbe5a3b (ST_3d593ae1aad35ac58e1616049bb8da2cStructure r) {
RC_7f3fab599cac29adb40d23996cbe5a3b res = new RC_7f3fab599cac29adb40d23996cbe5a3b ();
res.ssSTInternal__Marker_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7f3fab599cac29adb40d23996cbe5a3b() {
OptimizedAttributes = null;
ssSTInternal__Marker_Configs = new ST_3d593ae1aad35ac58e1616049bb8da2cStructure();
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
    ssSTInternal__Marker_Configs.OptimizedAttributes = value[0];
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
ssSTInternal__Marker_Configs.Read( r, ref index);
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
public void ReadIM(RC_7f3fab599cac29adb40d23996cbe5a3b r) {
this = r;
}


public static bool operator == (RC_7f3fab599cac29adb40d23996cbe5a3b a, RC_7f3fab599cac29adb40d23996cbe5a3b b) {
if (a.ssSTInternal__Marker_Configs != b.ssSTInternal__Marker_Configs) return false;
return true;
}

public static bool operator != (RC_7f3fab599cac29adb40d23996cbe5a3b a, RC_7f3fab599cac29adb40d23996cbe5a3b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7f3fab599cac29adb40d23996cbe5a3b)) return false;
return (this == (RC_7f3fab599cac29adb40d23996cbe5a3b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal__Marker_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal__Marker_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal__Marker_Configs.InternalRecursiveSave();
}


public RC_7f3fab599cac29adb40d23996cbe5a3b Duplicate() {
RC_7f3fab599cac29adb40d23996cbe5a3b t;
t.ssSTInternal__Marker_Configs = (ST_3d593ae1aad35ac58e1616049bb8da2cStructure)this.ssSTInternal__Marker_Configs.Duplicate();
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
if (head == "internal__marker_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal__Marker_Configs")) variable.Value = ssSTInternal__Marker_Configs; else variable.Optimized = true;
variable.SetFieldName("internal__marker_configs");
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
if (key == IdInternal__Marker_Configs) {
return ssSTInternal__Marker_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal__Marker_Configs.Key.AsGuid) {
return ssSTInternal__Marker_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal__Marker_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal__Marker_Configs));
}
} // RC_7f3fab599cac29adb40d23996cbe5a3b
/// <summary>
/// RecordList type <code>Internal__Marker_ConfigsRecordList</code> that represents a record list of
///  <code>Internal__Marker_Configs</code>
/// </summary>
public partial class RL_3cd1e9f4dc129b616317a614e87a04d1 : GenericRecordList<RC_7f3fab599cac29adb40d23996cbe5a3b>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7f3fab599cac29adb40d23996cbe5a3b GetElementDefaultValue() {
return new RC_7f3fab599cac29adb40d23996cbe5a3b();
}

public T[] ToArray<T>(Func<RC_7f3fab599cac29adb40d23996cbe5a3b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3cd1e9f4dc129b616317a614e87a04d1 recordList, Func<RC_7f3fab599cac29adb40d23996cbe5a3b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3cd1e9f4dc129b616317a614e87a04d1(RC_7f3fab599cac29adb40d23996cbe5a3b[] array) {
  RL_3cd1e9f4dc129b616317a614e87a04d1 result = new RL_3cd1e9f4dc129b616317a614e87a04d1();
result.InnerFromArray(array);
    return result;
}

public static RL_3cd1e9f4dc129b616317a614e87a04d1 ToList<T>(T[] array, Func <T, RC_7f3fab599cac29adb40d23996cbe5a3b> converter) {
  RL_3cd1e9f4dc129b616317a614e87a04d1 result = new RL_3cd1e9f4dc129b616317a614e87a04d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3cd1e9f4dc129b616317a614e87a04d1 FromRestList<T>(RestList<T> restList, Func <T, RC_7f3fab599cac29adb40d23996cbe5a3b> converter) {
  RL_3cd1e9f4dc129b616317a614e87a04d1 result = new RL_3cd1e9f4dc129b616317a614e87a04d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3cd1e9f4dc129b616317a614e87a04d1() : base() {
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
protected override OSList<RC_7f3fab599cac29adb40d23996cbe5a3b> NewList() {
return new RL_3cd1e9f4dc129b616317a614e87a04d1();
}


} // RL_3cd1e9f4dc129b616317a614e87a04d1
}

