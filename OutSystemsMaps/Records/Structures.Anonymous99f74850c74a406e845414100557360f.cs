namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (UEj3mUrHbkCEVBQQBVc2Dw)
///  <code>RC_a13c14b9ba27332cf1eb1f7147c42c92</code> that represent
/// s <code>OptionalFileLayerConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalFileLayerConfigsRecord
public partial struct RC_a13c14b9ba27332cf1eb1f7147c42c92 : ITypedRecord<RC_a13c14b9ba27332cf1eb1f7147c42c92> {
internal static readonly GlobalObjectKey IdOptionalFileLayerConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uRQ8oSe6LDPx6x9xR8Qskg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalFileLayerConfigs")]
public ST_2bb06e37aea9715ba999f70106cf37a5Structure ssSTOptionalFileLayerConfigs;


public static implicit operator ST_2bb06e37aea9715ba999f70106cf37a5Structure( RC_a13c14b9ba27332cf1eb1f7147c42c92 r) {
return r.ssSTOptionalFileLayerConfigs;
}

public static implicit operator RC_a13c14b9ba27332cf1eb1f7147c42c92 (ST_2bb06e37aea9715ba999f70106cf37a5Structure r) {
RC_a13c14b9ba27332cf1eb1f7147c42c92 res = new RC_a13c14b9ba27332cf1eb1f7147c42c92 ();
res.ssSTOptionalFileLayerConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a13c14b9ba27332cf1eb1f7147c42c92() {
OptimizedAttributes = null;
ssSTOptionalFileLayerConfigs = new ST_2bb06e37aea9715ba999f70106cf37a5Structure();
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
    ssSTOptionalFileLayerConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalFileLayerConfigs.Read( r, ref index);
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
public void ReadIM(RC_a13c14b9ba27332cf1eb1f7147c42c92 r) {
this = r;
}


public static bool operator == (RC_a13c14b9ba27332cf1eb1f7147c42c92 a, RC_a13c14b9ba27332cf1eb1f7147c42c92 b) {
if (a.ssSTOptionalFileLayerConfigs != b.ssSTOptionalFileLayerConfigs) return false;
return true;
}

public static bool operator != (RC_a13c14b9ba27332cf1eb1f7147c42c92 a, RC_a13c14b9ba27332cf1eb1f7147c42c92 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a13c14b9ba27332cf1eb1f7147c42c92)) return false;
return (this == (RC_a13c14b9ba27332cf1eb1f7147c42c92)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalFileLayerConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalFileLayerConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalFileLayerConfigs.InternalRecursiveSave();
}


public RC_a13c14b9ba27332cf1eb1f7147c42c92 Duplicate() {
RC_a13c14b9ba27332cf1eb1f7147c42c92 t;
t.ssSTOptionalFileLayerConfigs = (ST_2bb06e37aea9715ba999f70106cf37a5Structure)this.ssSTOptionalFileLayerConfigs.Duplicate();
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
if (head == "optionalfilelayerconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalFileLayerConfigs")) variable.Value = ssSTOptionalFileLayerConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalfilelayerconfigs");
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
if (key == IdOptionalFileLayerConfigs) {
return ssSTOptionalFileLayerConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalFileLayerConfigs.Key.AsGuid) {
return ssSTOptionalFileLayerConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalFileLayerConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalFileLayerConfigs));
}
} // RC_a13c14b9ba27332cf1eb1f7147c42c92
/// <summary>
/// RecordList type <code>OptionalFileLayerConfigsRecordList</code> that represents a record list of
///  <code>OptionalFileLayerConfigs</code>
/// </summary>
public partial class RL_c741a57cf499ba291dad3ca452914290 : GenericRecordList<RC_a13c14b9ba27332cf1eb1f7147c42c92>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a13c14b9ba27332cf1eb1f7147c42c92 GetElementDefaultValue() {
return new RC_a13c14b9ba27332cf1eb1f7147c42c92();
}

public T[] ToArray<T>(Func<RC_a13c14b9ba27332cf1eb1f7147c42c92, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c741a57cf499ba291dad3ca452914290 recordList, Func<RC_a13c14b9ba27332cf1eb1f7147c42c92, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c741a57cf499ba291dad3ca452914290(RC_a13c14b9ba27332cf1eb1f7147c42c92[] array) {
  RL_c741a57cf499ba291dad3ca452914290 result = new RL_c741a57cf499ba291dad3ca452914290();
result.InnerFromArray(array);
    return result;
}

public static RL_c741a57cf499ba291dad3ca452914290 ToList<T>(T[] array, Func <T, RC_a13c14b9ba27332cf1eb1f7147c42c92> converter) {
  RL_c741a57cf499ba291dad3ca452914290 result = new RL_c741a57cf499ba291dad3ca452914290();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c741a57cf499ba291dad3ca452914290 FromRestList<T>(RestList<T> restList, Func <T, RC_a13c14b9ba27332cf1eb1f7147c42c92> converter) {
  RL_c741a57cf499ba291dad3ca452914290 result = new RL_c741a57cf499ba291dad3ca452914290();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c741a57cf499ba291dad3ca452914290() : base() {
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
protected override OSList<RC_a13c14b9ba27332cf1eb1f7147c42c92> NewList() {
return new RL_c741a57cf499ba291dad3ca452914290();
}


} // RL_c741a57cf499ba291dad3ca452914290
}

