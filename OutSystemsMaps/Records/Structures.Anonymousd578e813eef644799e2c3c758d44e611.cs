namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (E+h41fbueUSeLDx1jUTmEQ)
///  <code>RC_794e39fc977eff2817cb99ab6af38d57</code> that represent
/// s <code>Internal_to_provider_drawFilledShape_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_drawFilledShape_configsRecord
public partial struct RC_794e39fc977eff2817cb99ab6af38d57 : ITypedRecord<RC_794e39fc977eff2817cb99ab6af38d57> {
internal static readonly GlobalObjectKey IdInternal_to_provider_drawFilledShape_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_DlOeX6XKP8Xy5mravONVw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_drawFilledShape_configs")]
public ST_d25262c67f1be04c1df274811b8c7ee4Structure ssSTInternal_to_provider_drawFilledShape_configs;


public static implicit operator ST_d25262c67f1be04c1df274811b8c7ee4Structure( RC_794e39fc977eff2817cb99ab6af38d57 r) {
return r.ssSTInternal_to_provider_drawFilledShape_configs;
}

public static implicit operator RC_794e39fc977eff2817cb99ab6af38d57 (ST_d25262c67f1be04c1df274811b8c7ee4Structure r) {
RC_794e39fc977eff2817cb99ab6af38d57 res = new RC_794e39fc977eff2817cb99ab6af38d57 ();
res.ssSTInternal_to_provider_drawFilledShape_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_794e39fc977eff2817cb99ab6af38d57() {
OptimizedAttributes = null;
ssSTInternal_to_provider_drawFilledShape_configs = new ST_d25262c67f1be04c1df274811b8c7ee4Structure();
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
    ssSTInternal_to_provider_drawFilledShape_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_drawFilledShape_configs.Read( r, ref index);
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
public void ReadIM(RC_794e39fc977eff2817cb99ab6af38d57 r) {
this = r;
}


public static bool operator == (RC_794e39fc977eff2817cb99ab6af38d57 a, RC_794e39fc977eff2817cb99ab6af38d57 b) {
if (a.ssSTInternal_to_provider_drawFilledShape_configs != b.ssSTInternal_to_provider_drawFilledShape_configs) return false;
return true;
}

public static bool operator != (RC_794e39fc977eff2817cb99ab6af38d57 a, RC_794e39fc977eff2817cb99ab6af38d57 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_794e39fc977eff2817cb99ab6af38d57)) return false;
return (this == (RC_794e39fc977eff2817cb99ab6af38d57)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_drawFilledShape_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_drawFilledShape_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_drawFilledShape_configs.InternalRecursiveSave();
}


public RC_794e39fc977eff2817cb99ab6af38d57 Duplicate() {
RC_794e39fc977eff2817cb99ab6af38d57 t;
t.ssSTInternal_to_provider_drawFilledShape_configs = (ST_d25262c67f1be04c1df274811b8c7ee4Structure)this.ssSTInternal_to_provider_drawFilledShape_configs.Duplicate();
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
if (head == "internal_to_provider_drawfilledshape_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_drawFilledShape_configs")) variable.Value = ssSTInternal_to_provider_drawFilledShape_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_drawfilledshape_configs");
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
if (key == IdInternal_to_provider_drawFilledShape_configs) {
return ssSTInternal_to_provider_drawFilledShape_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_drawFilledShape_configs.Key.AsGuid) {
return ssSTInternal_to_provider_drawFilledShape_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_drawFilledShape_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_drawFilledShape_configs));
}
} // RC_794e39fc977eff2817cb99ab6af38d57
/// <summary>
/// RecordList type <code>Internal_to_provider_drawFilledShape_configsRecordList</code> that represents
///  a record list of <code>Internal_to_provider_drawFilledShape_configs</code>
/// </summary>
public partial class RL_b06b1ca48ce3e669f6d11bd7bb1c0609 : GenericRecordList<RC_794e39fc977eff2817cb99ab6af38d57>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_794e39fc977eff2817cb99ab6af38d57 GetElementDefaultValue() {
return new RC_794e39fc977eff2817cb99ab6af38d57();
}

public T[] ToArray<T>(Func<RC_794e39fc977eff2817cb99ab6af38d57, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b06b1ca48ce3e669f6d11bd7bb1c0609 recordList, Func<RC_794e39fc977eff2817cb99ab6af38d57, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b06b1ca48ce3e669f6d11bd7bb1c0609(RC_794e39fc977eff2817cb99ab6af38d57[] array) {
  RL_b06b1ca48ce3e669f6d11bd7bb1c0609 result = new RL_b06b1ca48ce3e669f6d11bd7bb1c0609();
result.InnerFromArray(array);
    return result;
}

public static RL_b06b1ca48ce3e669f6d11bd7bb1c0609 ToList<T>(T[] array, Func <T, RC_794e39fc977eff2817cb99ab6af38d57> converter) {
  RL_b06b1ca48ce3e669f6d11bd7bb1c0609 result = new RL_b06b1ca48ce3e669f6d11bd7bb1c0609();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b06b1ca48ce3e669f6d11bd7bb1c0609 FromRestList<T>(RestList<T> restList, Func <T, RC_794e39fc977eff2817cb99ab6af38d57> converter) {
  RL_b06b1ca48ce3e669f6d11bd7bb1c0609 result = new RL_b06b1ca48ce3e669f6d11bd7bb1c0609();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b06b1ca48ce3e669f6d11bd7bb1c0609() : base() {
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
protected override OSList<RC_794e39fc977eff2817cb99ab6af38d57> NewList() {
return new RL_b06b1ca48ce3e669f6d11bd7bb1c0609();
}


} // RL_b06b1ca48ce3e669f6d11bd7bb1c0609
}

