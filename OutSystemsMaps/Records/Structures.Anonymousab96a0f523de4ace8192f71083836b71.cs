namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (9aCWq94jzkqBkvcQg4NrcQ)
///  <code>RC_6e989af6610cf33b5d07b40b7d0a9306</code> that represent
/// s <code>Internal_DrawCircle_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawCircle_ConfigsRecord
public partial struct RC_6e989af6610cf33b5d07b40b7d0a9306 : ITypedRecord<RC_6e989af6610cf33b5d07b40b7d0a9306> {
internal static readonly GlobalObjectKey IdInternal_DrawCircle_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9pqYbgxhO_NdB7QLfQqTBg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawCircle_Configs")]
public ST_5d8d0b250562ec29250400c2b0c3eb66Structure ssSTInternal_DrawCircle_Configs;


public static implicit operator ST_5d8d0b250562ec29250400c2b0c3eb66Structure( RC_6e989af6610cf33b5d07b40b7d0a9306 r) {
return r.ssSTInternal_DrawCircle_Configs;
}

public static implicit operator RC_6e989af6610cf33b5d07b40b7d0a9306 (ST_5d8d0b250562ec29250400c2b0c3eb66Structure r) {
RC_6e989af6610cf33b5d07b40b7d0a9306 res = new RC_6e989af6610cf33b5d07b40b7d0a9306 ();
res.ssSTInternal_DrawCircle_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6e989af6610cf33b5d07b40b7d0a9306() {
OptimizedAttributes = null;
ssSTInternal_DrawCircle_Configs = new ST_5d8d0b250562ec29250400c2b0c3eb66Structure();
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
    ssSTInternal_DrawCircle_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_DrawCircle_Configs.Read( r, ref index);
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
public void ReadIM(RC_6e989af6610cf33b5d07b40b7d0a9306 r) {
this = r;
}


public static bool operator == (RC_6e989af6610cf33b5d07b40b7d0a9306 a, RC_6e989af6610cf33b5d07b40b7d0a9306 b) {
if (a.ssSTInternal_DrawCircle_Configs != b.ssSTInternal_DrawCircle_Configs) return false;
return true;
}

public static bool operator != (RC_6e989af6610cf33b5d07b40b7d0a9306 a, RC_6e989af6610cf33b5d07b40b7d0a9306 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6e989af6610cf33b5d07b40b7d0a9306)) return false;
return (this == (RC_6e989af6610cf33b5d07b40b7d0a9306)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawCircle_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawCircle_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawCircle_Configs.InternalRecursiveSave();
}


public RC_6e989af6610cf33b5d07b40b7d0a9306 Duplicate() {
RC_6e989af6610cf33b5d07b40b7d0a9306 t;
t.ssSTInternal_DrawCircle_Configs = (ST_5d8d0b250562ec29250400c2b0c3eb66Structure)this.ssSTInternal_DrawCircle_Configs.Duplicate();
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
if (head == "internal_drawcircle_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawCircle_Configs")) variable.Value = ssSTInternal_DrawCircle_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_drawcircle_configs");
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
if (key == IdInternal_DrawCircle_Configs) {
return ssSTInternal_DrawCircle_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawCircle_Configs.Key.AsGuid) {
return ssSTInternal_DrawCircle_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawCircle_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawCircle_Configs));
}
} // RC_6e989af6610cf33b5d07b40b7d0a9306
/// <summary>
/// RecordList type <code>Internal_DrawCircle_ConfigsRecordList</code> that represents a record list of
///  <code>Internal_DrawCircle_Configs</code>
/// </summary>
public partial class RL_b6eda930a695560d8402033f001880cd : GenericRecordList<RC_6e989af6610cf33b5d07b40b7d0a9306>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_6e989af6610cf33b5d07b40b7d0a9306 GetElementDefaultValue() {
return new RC_6e989af6610cf33b5d07b40b7d0a9306();
}

public T[] ToArray<T>(Func<RC_6e989af6610cf33b5d07b40b7d0a9306, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b6eda930a695560d8402033f001880cd recordList, Func<RC_6e989af6610cf33b5d07b40b7d0a9306, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b6eda930a695560d8402033f001880cd(RC_6e989af6610cf33b5d07b40b7d0a9306[] array) {
  RL_b6eda930a695560d8402033f001880cd result = new RL_b6eda930a695560d8402033f001880cd();
result.InnerFromArray(array);
    return result;
}

public static RL_b6eda930a695560d8402033f001880cd ToList<T>(T[] array, Func <T, RC_6e989af6610cf33b5d07b40b7d0a9306> converter) {
  RL_b6eda930a695560d8402033f001880cd result = new RL_b6eda930a695560d8402033f001880cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b6eda930a695560d8402033f001880cd FromRestList<T>(RestList<T> restList, Func <T, RC_6e989af6610cf33b5d07b40b7d0a9306> converter) {
  RL_b6eda930a695560d8402033f001880cd result = new RL_b6eda930a695560d8402033f001880cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b6eda930a695560d8402033f001880cd() : base() {
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
protected override OSList<RC_6e989af6610cf33b5d07b40b7d0a9306> NewList() {
return new RL_b6eda930a695560d8402033f001880cd();
}


} // RL_b6eda930a695560d8402033f001880cd
}

