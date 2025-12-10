namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (KSZGKOq+N0OqZ0gWkbw6zg)
///  <code>RC_7d204fba4e0a277c99c007d6b7af7b72</code> that represent
/// s <code>Internal_DrawingTools_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawingTools_ConfigsRecord
public partial struct RC_7d204fba4e0a277c99c007d6b7af7b72 : ITypedRecord<RC_7d204fba4e0a277c99c007d6b7af7b72> {
internal static readonly GlobalObjectKey IdInternal_DrawingTools_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uk8gfQpOfCeZwAfWt697cg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawingTools_Configs")]
public ST_61db11323cabca5a5fb3b6c7b9d63842Structure ssSTInternal_DrawingTools_Configs;


public static implicit operator ST_61db11323cabca5a5fb3b6c7b9d63842Structure( RC_7d204fba4e0a277c99c007d6b7af7b72 r) {
return r.ssSTInternal_DrawingTools_Configs;
}

public static implicit operator RC_7d204fba4e0a277c99c007d6b7af7b72 (ST_61db11323cabca5a5fb3b6c7b9d63842Structure r) {
RC_7d204fba4e0a277c99c007d6b7af7b72 res = new RC_7d204fba4e0a277c99c007d6b7af7b72 ();
res.ssSTInternal_DrawingTools_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7d204fba4e0a277c99c007d6b7af7b72() {
OptimizedAttributes = null;
ssSTInternal_DrawingTools_Configs = new ST_61db11323cabca5a5fb3b6c7b9d63842Structure();
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
    ssSTInternal_DrawingTools_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_DrawingTools_Configs.Read( r, ref index);
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
public void ReadIM(RC_7d204fba4e0a277c99c007d6b7af7b72 r) {
this = r;
}


public static bool operator == (RC_7d204fba4e0a277c99c007d6b7af7b72 a, RC_7d204fba4e0a277c99c007d6b7af7b72 b) {
if (a.ssSTInternal_DrawingTools_Configs != b.ssSTInternal_DrawingTools_Configs) return false;
return true;
}

public static bool operator != (RC_7d204fba4e0a277c99c007d6b7af7b72 a, RC_7d204fba4e0a277c99c007d6b7af7b72 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7d204fba4e0a277c99c007d6b7af7b72)) return false;
return (this == (RC_7d204fba4e0a277c99c007d6b7af7b72)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawingTools_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawingTools_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawingTools_Configs.InternalRecursiveSave();
}


public RC_7d204fba4e0a277c99c007d6b7af7b72 Duplicate() {
RC_7d204fba4e0a277c99c007d6b7af7b72 t;
t.ssSTInternal_DrawingTools_Configs = (ST_61db11323cabca5a5fb3b6c7b9d63842Structure)this.ssSTInternal_DrawingTools_Configs.Duplicate();
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
if (head == "internal_drawingtools_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawingTools_Configs")) variable.Value = ssSTInternal_DrawingTools_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_drawingtools_configs");
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
if (key == IdInternal_DrawingTools_Configs) {
return ssSTInternal_DrawingTools_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawingTools_Configs.Key.AsGuid) {
return ssSTInternal_DrawingTools_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawingTools_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawingTools_Configs));
}
} // RC_7d204fba4e0a277c99c007d6b7af7b72
/// <summary>
/// RecordList type <code>Internal_DrawingTools_ConfigsRecordList</code> that represents a record list
///  of <code>Internal_DrawingTools_Configs</code>
/// </summary>
public partial class RL_e61a5d2bba7bf23acfe2713fb1292435 : GenericRecordList<RC_7d204fba4e0a277c99c007d6b7af7b72>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7d204fba4e0a277c99c007d6b7af7b72 GetElementDefaultValue() {
return new RC_7d204fba4e0a277c99c007d6b7af7b72();
}

public T[] ToArray<T>(Func<RC_7d204fba4e0a277c99c007d6b7af7b72, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e61a5d2bba7bf23acfe2713fb1292435 recordList, Func<RC_7d204fba4e0a277c99c007d6b7af7b72, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e61a5d2bba7bf23acfe2713fb1292435(RC_7d204fba4e0a277c99c007d6b7af7b72[] array) {
  RL_e61a5d2bba7bf23acfe2713fb1292435 result = new RL_e61a5d2bba7bf23acfe2713fb1292435();
result.InnerFromArray(array);
    return result;
}

public static RL_e61a5d2bba7bf23acfe2713fb1292435 ToList<T>(T[] array, Func <T, RC_7d204fba4e0a277c99c007d6b7af7b72> converter) {
  RL_e61a5d2bba7bf23acfe2713fb1292435 result = new RL_e61a5d2bba7bf23acfe2713fb1292435();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e61a5d2bba7bf23acfe2713fb1292435 FromRestList<T>(RestList<T> restList, Func <T, RC_7d204fba4e0a277c99c007d6b7af7b72> converter) {
  RL_e61a5d2bba7bf23acfe2713fb1292435 result = new RL_e61a5d2bba7bf23acfe2713fb1292435();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e61a5d2bba7bf23acfe2713fb1292435() : base() {
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
protected override OSList<RC_7d204fba4e0a277c99c007d6b7af7b72> NewList() {
return new RL_e61a5d2bba7bf23acfe2713fb1292435();
}


} // RL_e61a5d2bba7bf23acfe2713fb1292435
}

