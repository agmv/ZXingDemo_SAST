namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (xP6KJqUAG0eT8JJYZjvtEg)
///  <code>RC_dae4b4e9efc938bf677d8f92dec29722</code> that represent
/// s <code>ProviderEventReturnMessageRecord</code> <p>Description: </p>
/// </summary>
// Name: ProviderEventReturnMessageRecord
public partial struct RC_dae4b4e9efc938bf677d8f92dec29722 : ITypedRecord<RC_dae4b4e9efc938bf677d8f92dec29722> {
internal static readonly GlobalObjectKey IdProviderEventReturnMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6bTk2snvvzhnfY+S3sKXIg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProviderEventReturnMessage")]
public ST_0995bd60993005a912f016117c0f5fd9Structure ssSTProviderEventReturnMessage;


public static implicit operator ST_0995bd60993005a912f016117c0f5fd9Structure( RC_dae4b4e9efc938bf677d8f92dec29722 r) {
return r.ssSTProviderEventReturnMessage;
}

public static implicit operator RC_dae4b4e9efc938bf677d8f92dec29722 (ST_0995bd60993005a912f016117c0f5fd9Structure r) {
RC_dae4b4e9efc938bf677d8f92dec29722 res = new RC_dae4b4e9efc938bf677d8f92dec29722 ();
res.ssSTProviderEventReturnMessage = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dae4b4e9efc938bf677d8f92dec29722() {
OptimizedAttributes = null;
ssSTProviderEventReturnMessage = new ST_0995bd60993005a912f016117c0f5fd9Structure();
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
    ssSTProviderEventReturnMessage.OptimizedAttributes = value[0];
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
ssSTProviderEventReturnMessage.Read( r, ref index);
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
public void ReadIM(RC_dae4b4e9efc938bf677d8f92dec29722 r) {
this = r;
}


public static bool operator == (RC_dae4b4e9efc938bf677d8f92dec29722 a, RC_dae4b4e9efc938bf677d8f92dec29722 b) {
if (a.ssSTProviderEventReturnMessage != b.ssSTProviderEventReturnMessage) return false;
return true;
}

public static bool operator != (RC_dae4b4e9efc938bf677d8f92dec29722 a, RC_dae4b4e9efc938bf677d8f92dec29722 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dae4b4e9efc938bf677d8f92dec29722)) return false;
return (this == (RC_dae4b4e9efc938bf677d8f92dec29722)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTProviderEventReturnMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTProviderEventReturnMessage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTProviderEventReturnMessage.InternalRecursiveSave();
}


public RC_dae4b4e9efc938bf677d8f92dec29722 Duplicate() {
RC_dae4b4e9efc938bf677d8f92dec29722 t;
t.ssSTProviderEventReturnMessage = (ST_0995bd60993005a912f016117c0f5fd9Structure)this.ssSTProviderEventReturnMessage.Duplicate();
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
if (head == "providereventreturnmessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProviderEventReturnMessage")) variable.Value = ssSTProviderEventReturnMessage; else variable.Optimized = true;
variable.SetFieldName("providereventreturnmessage");
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
if (key == IdProviderEventReturnMessage) {
return ssSTProviderEventReturnMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProviderEventReturnMessage.Key.AsGuid) {
return ssSTProviderEventReturnMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTProviderEventReturnMessage.FillFromOther((IRecord) other.AttributeGet(IdProviderEventReturnMessage));
}
} // RC_dae4b4e9efc938bf677d8f92dec29722
/// <summary>
/// RecordList type <code>ProviderEventReturnMessageRecordList</code> that represents a record list of
///  <code>ProviderEventReturnMessage</code>
/// </summary>
public partial class RL_1088f1545d2e7aa029bcf18435e48f7c : GenericRecordList<RC_dae4b4e9efc938bf677d8f92dec29722>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_dae4b4e9efc938bf677d8f92dec29722 GetElementDefaultValue() {
return new RC_dae4b4e9efc938bf677d8f92dec29722();
}

public T[] ToArray<T>(Func<RC_dae4b4e9efc938bf677d8f92dec29722, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1088f1545d2e7aa029bcf18435e48f7c recordList, Func<RC_dae4b4e9efc938bf677d8f92dec29722, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1088f1545d2e7aa029bcf18435e48f7c(RC_dae4b4e9efc938bf677d8f92dec29722[] array) {
  RL_1088f1545d2e7aa029bcf18435e48f7c result = new RL_1088f1545d2e7aa029bcf18435e48f7c();
result.InnerFromArray(array);
    return result;
}

public static RL_1088f1545d2e7aa029bcf18435e48f7c ToList<T>(T[] array, Func <T, RC_dae4b4e9efc938bf677d8f92dec29722> converter) {
  RL_1088f1545d2e7aa029bcf18435e48f7c result = new RL_1088f1545d2e7aa029bcf18435e48f7c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1088f1545d2e7aa029bcf18435e48f7c FromRestList<T>(RestList<T> restList, Func <T, RC_dae4b4e9efc938bf677d8f92dec29722> converter) {
  RL_1088f1545d2e7aa029bcf18435e48f7c result = new RL_1088f1545d2e7aa029bcf18435e48f7c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1088f1545d2e7aa029bcf18435e48f7c() : base() {
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
protected override OSList<RC_dae4b4e9efc938bf677d8f92dec29722> NewList() {
return new RL_1088f1545d2e7aa029bcf18435e48f7c();
}


} // RL_1088f1545d2e7aa029bcf18435e48f7c
}

