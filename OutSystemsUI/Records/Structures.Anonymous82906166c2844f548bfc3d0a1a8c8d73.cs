namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (ZmGQgoTCVE+L_D0KGoyNcw)
///  <code>RC_a2f63a3e27000ea7c800cf727f8ecfba</code> that represent
/// s <code>BottomSheet_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: BottomSheet_InternalConfigRecord
public partial struct RC_a2f63a3e27000ea7c800cf727f8ecfba : ITypedRecord<RC_a2f63a3e27000ea7c800cf727f8ecfba> {
internal static readonly GlobalObjectKey IdBottomSheet_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pjr2ogAnpw7IAM9yf47Pug");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("BottomSheet_InternalConfig")]
public ST_106b6e385f5e89b0a7d76e23b14f61a0Structure ssSTBottomSheet_InternalConfig;


public static implicit operator ST_106b6e385f5e89b0a7d76e23b14f61a0Structure( RC_a2f63a3e27000ea7c800cf727f8ecfba r) {
return r.ssSTBottomSheet_InternalConfig;
}

public static implicit operator RC_a2f63a3e27000ea7c800cf727f8ecfba (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure r) {
RC_a2f63a3e27000ea7c800cf727f8ecfba res = new RC_a2f63a3e27000ea7c800cf727f8ecfba ();
res.ssSTBottomSheet_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a2f63a3e27000ea7c800cf727f8ecfba() {
OptimizedAttributes = null;
ssSTBottomSheet_InternalConfig = new ST_106b6e385f5e89b0a7d76e23b14f61a0Structure();
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
    ssSTBottomSheet_InternalConfig.OptimizedAttributes = value[0];
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
ssSTBottomSheet_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_a2f63a3e27000ea7c800cf727f8ecfba r) {
this = r;
}


public static bool operator == (RC_a2f63a3e27000ea7c800cf727f8ecfba a, RC_a2f63a3e27000ea7c800cf727f8ecfba b) {
if (a.ssSTBottomSheet_InternalConfig != b.ssSTBottomSheet_InternalConfig) return false;
return true;
}

public static bool operator != (RC_a2f63a3e27000ea7c800cf727f8ecfba a, RC_a2f63a3e27000ea7c800cf727f8ecfba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a2f63a3e27000ea7c800cf727f8ecfba)) return false;
return (this == (RC_a2f63a3e27000ea7c800cf727f8ecfba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBottomSheet_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBottomSheet_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBottomSheet_InternalConfig.InternalRecursiveSave();
}


public RC_a2f63a3e27000ea7c800cf727f8ecfba Duplicate() {
RC_a2f63a3e27000ea7c800cf727f8ecfba t;
t.ssSTBottomSheet_InternalConfig = (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure)this.ssSTBottomSheet_InternalConfig.Duplicate();
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
if (head == "bottomsheet_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BottomSheet_InternalConfig")) variable.Value = ssSTBottomSheet_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("bottomsheet_internalconfig");
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
if (key == IdBottomSheet_InternalConfig) {
return ssSTBottomSheet_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBottomSheet_InternalConfig.Key.AsGuid) {
return ssSTBottomSheet_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBottomSheet_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdBottomSheet_InternalConfig));
}
} // RC_a2f63a3e27000ea7c800cf727f8ecfba
/// <summary>
/// RecordList type <code>BottomSheet_InternalConfigRecordList</code> that represents a record list of
///  <code>BottomSheet_InternalConfig</code>
/// </summary>
public partial class RL_26fe7e35cc8af3671f82a7f722857f76 : GenericRecordList<RC_a2f63a3e27000ea7c800cf727f8ecfba>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a2f63a3e27000ea7c800cf727f8ecfba GetElementDefaultValue() {
return new RC_a2f63a3e27000ea7c800cf727f8ecfba();
}

public T[] ToArray<T>(Func<RC_a2f63a3e27000ea7c800cf727f8ecfba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26fe7e35cc8af3671f82a7f722857f76 recordList, Func<RC_a2f63a3e27000ea7c800cf727f8ecfba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26fe7e35cc8af3671f82a7f722857f76(RC_a2f63a3e27000ea7c800cf727f8ecfba[] array) {
  RL_26fe7e35cc8af3671f82a7f722857f76 result = new RL_26fe7e35cc8af3671f82a7f722857f76();
result.InnerFromArray(array);
    return result;
}

public static RL_26fe7e35cc8af3671f82a7f722857f76 ToList<T>(T[] array, Func <T, RC_a2f63a3e27000ea7c800cf727f8ecfba> converter) {
  RL_26fe7e35cc8af3671f82a7f722857f76 result = new RL_26fe7e35cc8af3671f82a7f722857f76();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26fe7e35cc8af3671f82a7f722857f76 FromRestList<T>(RestList<T> restList, Func <T, RC_a2f63a3e27000ea7c800cf727f8ecfba> converter) {
  RL_26fe7e35cc8af3671f82a7f722857f76 result = new RL_26fe7e35cc8af3671f82a7f722857f76();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26fe7e35cc8af3671f82a7f722857f76() : base() {
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
protected override OSList<RC_a2f63a3e27000ea7c800cf727f8ecfba> NewList() {
return new RL_26fe7e35cc8af3671f82a7f722857f76();
}


} // RL_26fe7e35cc8af3671f82a7f722857f76
}

