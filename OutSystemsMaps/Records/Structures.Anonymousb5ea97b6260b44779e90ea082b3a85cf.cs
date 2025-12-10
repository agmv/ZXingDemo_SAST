namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (tpfqtQsmd0SekOoIKzqFzw)
///  <code>RC_003de7652ef70684ee40ecb9c31ff117</code> that represent
/// s <code>OptionalStaticMapConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalStaticMapConfigsRecord
public partial struct RC_003de7652ef70684ee40ecb9c31ff117 : ITypedRecord<RC_003de7652ef70684ee40ecb9c31ff117> {
internal static readonly GlobalObjectKey IdOptionalStaticMapConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Zec9APcuhAbuQOy5wx_xFw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalStaticMapConfigs")]
public ST_b2c05afcf4810ad0d4384a01306bb0f3Structure ssSTOptionalStaticMapConfigs;


public static implicit operator ST_b2c05afcf4810ad0d4384a01306bb0f3Structure( RC_003de7652ef70684ee40ecb9c31ff117 r) {
return r.ssSTOptionalStaticMapConfigs;
}

public static implicit operator RC_003de7652ef70684ee40ecb9c31ff117 (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure r) {
RC_003de7652ef70684ee40ecb9c31ff117 res = new RC_003de7652ef70684ee40ecb9c31ff117 ();
res.ssSTOptionalStaticMapConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_003de7652ef70684ee40ecb9c31ff117() {
OptimizedAttributes = null;
ssSTOptionalStaticMapConfigs = new ST_b2c05afcf4810ad0d4384a01306bb0f3Structure();
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
    ssSTOptionalStaticMapConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalStaticMapConfigs.Read( r, ref index);
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
public void ReadIM(RC_003de7652ef70684ee40ecb9c31ff117 r) {
this = r;
}


public static bool operator == (RC_003de7652ef70684ee40ecb9c31ff117 a, RC_003de7652ef70684ee40ecb9c31ff117 b) {
if (a.ssSTOptionalStaticMapConfigs != b.ssSTOptionalStaticMapConfigs) return false;
return true;
}

public static bool operator != (RC_003de7652ef70684ee40ecb9c31ff117 a, RC_003de7652ef70684ee40ecb9c31ff117 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_003de7652ef70684ee40ecb9c31ff117)) return false;
return (this == (RC_003de7652ef70684ee40ecb9c31ff117)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalStaticMapConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalStaticMapConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalStaticMapConfigs.InternalRecursiveSave();
}


public RC_003de7652ef70684ee40ecb9c31ff117 Duplicate() {
RC_003de7652ef70684ee40ecb9c31ff117 t;
t.ssSTOptionalStaticMapConfigs = (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure)this.ssSTOptionalStaticMapConfigs.Duplicate();
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
if (head == "optionalstaticmapconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalStaticMapConfigs")) variable.Value = ssSTOptionalStaticMapConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalstaticmapconfigs");
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
if (key == IdOptionalStaticMapConfigs) {
return ssSTOptionalStaticMapConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalStaticMapConfigs.Key.AsGuid) {
return ssSTOptionalStaticMapConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalStaticMapConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalStaticMapConfigs));
}
} // RC_003de7652ef70684ee40ecb9c31ff117
/// <summary>
/// RecordList type <code>OptionalStaticMapConfigsRecordList</code> that represents a record list of
///  <code>OptionalStaticMapConfigs</code>
/// </summary>
public partial class RL_5e5ee9ae0fcac1f142b0849f5cd91a60 : GenericRecordList<RC_003de7652ef70684ee40ecb9c31ff117>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_003de7652ef70684ee40ecb9c31ff117 GetElementDefaultValue() {
return new RC_003de7652ef70684ee40ecb9c31ff117();
}

public T[] ToArray<T>(Func<RC_003de7652ef70684ee40ecb9c31ff117, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5e5ee9ae0fcac1f142b0849f5cd91a60 recordList, Func<RC_003de7652ef70684ee40ecb9c31ff117, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5e5ee9ae0fcac1f142b0849f5cd91a60(RC_003de7652ef70684ee40ecb9c31ff117[] array) {
  RL_5e5ee9ae0fcac1f142b0849f5cd91a60 result = new RL_5e5ee9ae0fcac1f142b0849f5cd91a60();
result.InnerFromArray(array);
    return result;
}

public static RL_5e5ee9ae0fcac1f142b0849f5cd91a60 ToList<T>(T[] array, Func <T, RC_003de7652ef70684ee40ecb9c31ff117> converter) {
  RL_5e5ee9ae0fcac1f142b0849f5cd91a60 result = new RL_5e5ee9ae0fcac1f142b0849f5cd91a60();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5e5ee9ae0fcac1f142b0849f5cd91a60 FromRestList<T>(RestList<T> restList, Func <T, RC_003de7652ef70684ee40ecb9c31ff117> converter) {
  RL_5e5ee9ae0fcac1f142b0849f5cd91a60 result = new RL_5e5ee9ae0fcac1f142b0849f5cd91a60();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5e5ee9ae0fcac1f142b0849f5cd91a60() : base() {
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
protected override OSList<RC_003de7652ef70684ee40ecb9c31ff117> NewList() {
return new RL_5e5ee9ae0fcac1f142b0849f5cd91a60();
}


} // RL_5e5ee9ae0fcac1f142b0849f5cd91a60
}

