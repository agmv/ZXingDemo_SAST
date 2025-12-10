namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (I6RMFwtP20GU+CrEB7qUsA)
///  <code>RC_d761bc5f1b0fe2debf1c3edffd0efd3c</code> that represent
/// s <code>OptionalMapConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalMapConfigsRecord
public partial struct RC_d761bc5f1b0fe2debf1c3edffd0efd3c : ITypedRecord<RC_d761bc5f1b0fe2debf1c3edffd0efd3c> {
internal static readonly GlobalObjectKey IdOptionalMapConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*X7xh1w8b3uK_HD7f_Q79PA");

public static void EnsureInitialized(){}

static RC_d761bc5f1b0fe2debf1c3edffd0efd3c() {
RC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("OptionalMapConfigs")]
public ST_d609eacb476c603df8b92eb374da99faStructure ssSTOptionalMapConfigs;


public static implicit operator ST_d609eacb476c603df8b92eb374da99faStructure( RC_d761bc5f1b0fe2debf1c3edffd0efd3c r) {
return r.ssSTOptionalMapConfigs;
}

public static implicit operator RC_d761bc5f1b0fe2debf1c3edffd0efd3c (ST_d609eacb476c603df8b92eb374da99faStructure r) {
RC_d761bc5f1b0fe2debf1c3edffd0efd3c res = new RC_d761bc5f1b0fe2debf1c3edffd0efd3c ();
res.ssSTOptionalMapConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d761bc5f1b0fe2debf1c3edffd0efd3c() {
OptimizedAttributes = null;
ssSTOptionalMapConfigs = new ST_d609eacb476c603df8b92eb374da99faStructure();
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
    ssSTOptionalMapConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalMapConfigs.Read( r, ref index);
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
public void ReadIM(RC_d761bc5f1b0fe2debf1c3edffd0efd3c r) {
this = r;
}


public static bool operator == (RC_d761bc5f1b0fe2debf1c3edffd0efd3c a, RC_d761bc5f1b0fe2debf1c3edffd0efd3c b) {
if (a.ssSTOptionalMapConfigs != b.ssSTOptionalMapConfigs) return false;
return true;
}

public static bool operator != (RC_d761bc5f1b0fe2debf1c3edffd0efd3c a, RC_d761bc5f1b0fe2debf1c3edffd0efd3c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d761bc5f1b0fe2debf1c3edffd0efd3c)) return false;
return (this == (RC_d761bc5f1b0fe2debf1c3edffd0efd3c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalMapConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalMapConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalMapConfigs.InternalRecursiveSave();
}


public RC_d761bc5f1b0fe2debf1c3edffd0efd3c Duplicate() {
RC_d761bc5f1b0fe2debf1c3edffd0efd3c t;
t.ssSTOptionalMapConfigs = (ST_d609eacb476c603df8b92eb374da99faStructure)this.ssSTOptionalMapConfigs.Duplicate();
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
if (head == "optionalmapconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalMapConfigs")) variable.Value = ssSTOptionalMapConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalmapconfigs");
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
if (key == IdOptionalMapConfigs) {
return ssSTOptionalMapConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalMapConfigs.Key.AsGuid) {
return ssSTOptionalMapConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalMapConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalMapConfigs));
}
} // RC_d761bc5f1b0fe2debf1c3edffd0efd3c
/// <summary>
/// RecordList type <code>OptionalMapConfigsRecordList</code> that represents a record list of
///  <code>OptionalMapConfigs</code>
/// </summary>
public partial class RL_0352d07492c0bc1610ae95bac5df94b5 : GenericRecordList<RC_d761bc5f1b0fe2debf1c3edffd0efd3c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d761bc5f1b0fe2debf1c3edffd0efd3c GetElementDefaultValue() {
return new RC_d761bc5f1b0fe2debf1c3edffd0efd3c();
}

public T[] ToArray<T>(Func<RC_d761bc5f1b0fe2debf1c3edffd0efd3c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0352d07492c0bc1610ae95bac5df94b5 recordList, Func<RC_d761bc5f1b0fe2debf1c3edffd0efd3c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0352d07492c0bc1610ae95bac5df94b5(RC_d761bc5f1b0fe2debf1c3edffd0efd3c[] array) {
  RL_0352d07492c0bc1610ae95bac5df94b5 result = new RL_0352d07492c0bc1610ae95bac5df94b5();
result.InnerFromArray(array);
    return result;
}

public static RL_0352d07492c0bc1610ae95bac5df94b5 ToList<T>(T[] array, Func <T, RC_d761bc5f1b0fe2debf1c3edffd0efd3c> converter) {
  RL_0352d07492c0bc1610ae95bac5df94b5 result = new RL_0352d07492c0bc1610ae95bac5df94b5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0352d07492c0bc1610ae95bac5df94b5 FromRestList<T>(RestList<T> restList, Func <T, RC_d761bc5f1b0fe2debf1c3edffd0efd3c> converter) {
  RL_0352d07492c0bc1610ae95bac5df94b5 result = new RL_0352d07492c0bc1610ae95bac5df94b5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0352d07492c0bc1610ae95bac5df94b5() : base() {
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
protected override OSList<RC_d761bc5f1b0fe2debf1c3edffd0efd3c> NewList() {
return new RL_0352d07492c0bc1610ae95bac5df94b5();
}


} // RL_0352d07492c0bc1610ae95bac5df94b5
}

