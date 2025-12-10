namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (FDiiJTcVBkWP3hDEu2htPw)
///  <code>RC_f4b8704cebd53b0a2ed361a846fc1b0e</code> that represent
/// s <code>ButtonLoading_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: ButtonLoading_InternalConfigRecord
public partial struct RC_f4b8704cebd53b0a2ed361a846fc1b0e : ITypedRecord<RC_f4b8704cebd53b0a2ed361a846fc1b0e> {
internal static readonly GlobalObjectKey IdButtonLoading_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*THC49NXrCjsu02GoRvwbDg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ButtonLoading_InternalConfig")]
public ST_2b510eefd88959a00bf486cfc856fa96Structure ssSTButtonLoading_InternalConfig;


public static implicit operator ST_2b510eefd88959a00bf486cfc856fa96Structure( RC_f4b8704cebd53b0a2ed361a846fc1b0e r) {
return r.ssSTButtonLoading_InternalConfig;
}

public static implicit operator RC_f4b8704cebd53b0a2ed361a846fc1b0e (ST_2b510eefd88959a00bf486cfc856fa96Structure r) {
RC_f4b8704cebd53b0a2ed361a846fc1b0e res = new RC_f4b8704cebd53b0a2ed361a846fc1b0e ();
res.ssSTButtonLoading_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f4b8704cebd53b0a2ed361a846fc1b0e() {
OptimizedAttributes = null;
ssSTButtonLoading_InternalConfig = new ST_2b510eefd88959a00bf486cfc856fa96Structure();
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
    ssSTButtonLoading_InternalConfig.OptimizedAttributes = value[0];
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
ssSTButtonLoading_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_f4b8704cebd53b0a2ed361a846fc1b0e r) {
this = r;
}


public static bool operator == (RC_f4b8704cebd53b0a2ed361a846fc1b0e a, RC_f4b8704cebd53b0a2ed361a846fc1b0e b) {
if (a.ssSTButtonLoading_InternalConfig != b.ssSTButtonLoading_InternalConfig) return false;
return true;
}

public static bool operator != (RC_f4b8704cebd53b0a2ed361a846fc1b0e a, RC_f4b8704cebd53b0a2ed361a846fc1b0e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f4b8704cebd53b0a2ed361a846fc1b0e)) return false;
return (this == (RC_f4b8704cebd53b0a2ed361a846fc1b0e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTButtonLoading_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTButtonLoading_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTButtonLoading_InternalConfig.InternalRecursiveSave();
}


public RC_f4b8704cebd53b0a2ed361a846fc1b0e Duplicate() {
RC_f4b8704cebd53b0a2ed361a846fc1b0e t;
t.ssSTButtonLoading_InternalConfig = (ST_2b510eefd88959a00bf486cfc856fa96Structure)this.ssSTButtonLoading_InternalConfig.Duplicate();
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
if (head == "buttonloading_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ButtonLoading_InternalConfig")) variable.Value = ssSTButtonLoading_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("buttonloading_internalconfig");
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
if (key == IdButtonLoading_InternalConfig) {
return ssSTButtonLoading_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdButtonLoading_InternalConfig.Key.AsGuid) {
return ssSTButtonLoading_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTButtonLoading_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdButtonLoading_InternalConfig));
}
} // RC_f4b8704cebd53b0a2ed361a846fc1b0e
/// <summary>
/// RecordList type <code>ButtonLoading_InternalConfigRecordList</code> that represents a record list
///  of <code>ButtonLoading_InternalConfig</code>
/// </summary>
public partial class RL_6e6a0f055ae42ad0262990e3c814fca5 : GenericRecordList<RC_f4b8704cebd53b0a2ed361a846fc1b0e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f4b8704cebd53b0a2ed361a846fc1b0e GetElementDefaultValue() {
return new RC_f4b8704cebd53b0a2ed361a846fc1b0e();
}

public T[] ToArray<T>(Func<RC_f4b8704cebd53b0a2ed361a846fc1b0e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6e6a0f055ae42ad0262990e3c814fca5 recordList, Func<RC_f4b8704cebd53b0a2ed361a846fc1b0e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6e6a0f055ae42ad0262990e3c814fca5(RC_f4b8704cebd53b0a2ed361a846fc1b0e[] array) {
  RL_6e6a0f055ae42ad0262990e3c814fca5 result = new RL_6e6a0f055ae42ad0262990e3c814fca5();
result.InnerFromArray(array);
    return result;
}

public static RL_6e6a0f055ae42ad0262990e3c814fca5 ToList<T>(T[] array, Func <T, RC_f4b8704cebd53b0a2ed361a846fc1b0e> converter) {
  RL_6e6a0f055ae42ad0262990e3c814fca5 result = new RL_6e6a0f055ae42ad0262990e3c814fca5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6e6a0f055ae42ad0262990e3c814fca5 FromRestList<T>(RestList<T> restList, Func <T, RC_f4b8704cebd53b0a2ed361a846fc1b0e> converter) {
  RL_6e6a0f055ae42ad0262990e3c814fca5 result = new RL_6e6a0f055ae42ad0262990e3c814fca5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6e6a0f055ae42ad0262990e3c814fca5() : base() {
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
protected override OSList<RC_f4b8704cebd53b0a2ed361a846fc1b0e> NewList() {
return new RL_6e6a0f055ae42ad0262990e3c814fca5();
}


} // RL_6e6a0f055ae42ad0262990e3c814fca5
}

