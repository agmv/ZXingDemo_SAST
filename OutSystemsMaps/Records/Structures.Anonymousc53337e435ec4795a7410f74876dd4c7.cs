namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (5Dczxew1lUenQQ90h23Uxw)
///  <code>RC_f413938d99b2f109b9b51d646a4937af</code> that represent
/// s <code>OptionalShapeConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalShapeConfigsRecord
public partial struct RC_f413938d99b2f109b9b51d646a4937af : ITypedRecord<RC_f413938d99b2f109b9b51d646a4937af> {
internal static readonly GlobalObjectKey IdOptionalShapeConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jZMT9LKZCfG5tR1kakk3rw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalShapeConfigs")]
public ST_f021741499f997a32540fab3dfcdbbfaStructure ssSTOptionalShapeConfigs;


public static implicit operator ST_f021741499f997a32540fab3dfcdbbfaStructure( RC_f413938d99b2f109b9b51d646a4937af r) {
return r.ssSTOptionalShapeConfigs;
}

public static implicit operator RC_f413938d99b2f109b9b51d646a4937af (ST_f021741499f997a32540fab3dfcdbbfaStructure r) {
RC_f413938d99b2f109b9b51d646a4937af res = new RC_f413938d99b2f109b9b51d646a4937af ();
res.ssSTOptionalShapeConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f413938d99b2f109b9b51d646a4937af() {
OptimizedAttributes = null;
ssSTOptionalShapeConfigs = new ST_f021741499f997a32540fab3dfcdbbfaStructure();
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
    ssSTOptionalShapeConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalShapeConfigs.Read( r, ref index);
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
public void ReadIM(RC_f413938d99b2f109b9b51d646a4937af r) {
this = r;
}


public static bool operator == (RC_f413938d99b2f109b9b51d646a4937af a, RC_f413938d99b2f109b9b51d646a4937af b) {
if (a.ssSTOptionalShapeConfigs != b.ssSTOptionalShapeConfigs) return false;
return true;
}

public static bool operator != (RC_f413938d99b2f109b9b51d646a4937af a, RC_f413938d99b2f109b9b51d646a4937af b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f413938d99b2f109b9b51d646a4937af)) return false;
return (this == (RC_f413938d99b2f109b9b51d646a4937af)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalShapeConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalShapeConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalShapeConfigs.InternalRecursiveSave();
}


public RC_f413938d99b2f109b9b51d646a4937af Duplicate() {
RC_f413938d99b2f109b9b51d646a4937af t;
t.ssSTOptionalShapeConfigs = (ST_f021741499f997a32540fab3dfcdbbfaStructure)this.ssSTOptionalShapeConfigs.Duplicate();
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
if (head == "optionalshapeconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalShapeConfigs")) variable.Value = ssSTOptionalShapeConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalshapeconfigs");
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
if (key == IdOptionalShapeConfigs) {
return ssSTOptionalShapeConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalShapeConfigs.Key.AsGuid) {
return ssSTOptionalShapeConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalShapeConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalShapeConfigs));
}
} // RC_f413938d99b2f109b9b51d646a4937af
/// <summary>
/// RecordList type <code>OptionalShapeConfigsRecordList</code> that represents a record list of
///  <code>OptionalShapeConfigs</code>
/// </summary>
public partial class RL_137b896072b61ef2961aafb3d62ca98e : GenericRecordList<RC_f413938d99b2f109b9b51d646a4937af>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f413938d99b2f109b9b51d646a4937af GetElementDefaultValue() {
return new RC_f413938d99b2f109b9b51d646a4937af();
}

public T[] ToArray<T>(Func<RC_f413938d99b2f109b9b51d646a4937af, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_137b896072b61ef2961aafb3d62ca98e recordList, Func<RC_f413938d99b2f109b9b51d646a4937af, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_137b896072b61ef2961aafb3d62ca98e(RC_f413938d99b2f109b9b51d646a4937af[] array) {
  RL_137b896072b61ef2961aafb3d62ca98e result = new RL_137b896072b61ef2961aafb3d62ca98e();
result.InnerFromArray(array);
    return result;
}

public static RL_137b896072b61ef2961aafb3d62ca98e ToList<T>(T[] array, Func <T, RC_f413938d99b2f109b9b51d646a4937af> converter) {
  RL_137b896072b61ef2961aafb3d62ca98e result = new RL_137b896072b61ef2961aafb3d62ca98e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_137b896072b61ef2961aafb3d62ca98e FromRestList<T>(RestList<T> restList, Func <T, RC_f413938d99b2f109b9b51d646a4937af> converter) {
  RL_137b896072b61ef2961aafb3d62ca98e result = new RL_137b896072b61ef2961aafb3d62ca98e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_137b896072b61ef2961aafb3d62ca98e() : base() {
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
protected override OSList<RC_f413938d99b2f109b9b51d646a4937af> NewList() {
return new RL_137b896072b61ef2961aafb3d62ca98e();
}


} // RL_137b896072b61ef2961aafb3d62ca98e
}

