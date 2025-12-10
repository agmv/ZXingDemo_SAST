namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (LPW79hMqWk65k6xzOqZbsg)
///  <code>RC_9b61cb371b118ff2b906c01399dcb602</code> that represents <code>LocalizationRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LocalizationRecord
public partial struct RC_9b61cb371b118ff2b906c01399dcb602 : ITypedRecord<RC_9b61cb371b118ff2b906c01399dcb602> {
internal static readonly GlobalObjectKey IdLocalization = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*N8thmxEb8o+5BsATmdy2Ag");

public static void EnsureInitialized(){}

static RC_9b61cb371b118ff2b906c01399dcb602() {
RC_9b61cb371b118ff2b906c01399dcb602TypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("Localization")]
public ST_59c2aa6a35b14343cc78f655810f9ce8Structure ssSTLocalization;


public static implicit operator ST_59c2aa6a35b14343cc78f655810f9ce8Structure( RC_9b61cb371b118ff2b906c01399dcb602 r) {
return r.ssSTLocalization;
}

public static implicit operator RC_9b61cb371b118ff2b906c01399dcb602 (ST_59c2aa6a35b14343cc78f655810f9ce8Structure r) {
RC_9b61cb371b118ff2b906c01399dcb602 res = new RC_9b61cb371b118ff2b906c01399dcb602 ();
res.ssSTLocalization = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9b61cb371b118ff2b906c01399dcb602() {
OptimizedAttributes = null;
ssSTLocalization = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
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
    ssSTLocalization.OptimizedAttributes = value[0];
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
ssSTLocalization.Read( r, ref index);
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
public void ReadIM(RC_9b61cb371b118ff2b906c01399dcb602 r) {
this = r;
}


public static bool operator == (RC_9b61cb371b118ff2b906c01399dcb602 a, RC_9b61cb371b118ff2b906c01399dcb602 b) {
if (a.ssSTLocalization != b.ssSTLocalization) return false;
return true;
}

public static bool operator != (RC_9b61cb371b118ff2b906c01399dcb602 a, RC_9b61cb371b118ff2b906c01399dcb602 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9b61cb371b118ff2b906c01399dcb602)) return false;
return (this == (RC_9b61cb371b118ff2b906c01399dcb602)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTLocalization.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTLocalization.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTLocalization.InternalRecursiveSave();
}


public RC_9b61cb371b118ff2b906c01399dcb602 Duplicate() {
RC_9b61cb371b118ff2b906c01399dcb602 t;
t.ssSTLocalization = (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)this.ssSTLocalization.Duplicate();
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
if (head == "localization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Localization")) variable.Value = ssSTLocalization; else variable.Optimized = true;
variable.SetFieldName("localization");
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
if (key == IdLocalization) {
return ssSTLocalization;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLocalization.Key.AsGuid) {
return ssSTLocalization;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTLocalization.FillFromOther((IRecord) other.AttributeGet(IdLocalization));
}
} // RC_9b61cb371b118ff2b906c01399dcb602
/// <summary>
/// RecordList type <code>LocalizationRecordList</code> that represents a record list of
///  <code>Localization</code>
/// </summary>
public partial class RL_a277b145fddcc6cdec59e1810589290e : GenericRecordList<RC_9b61cb371b118ff2b906c01399dcb602>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_9b61cb371b118ff2b906c01399dcb602 GetElementDefaultValue() {
return new RC_9b61cb371b118ff2b906c01399dcb602();
}

public T[] ToArray<T>(Func<RC_9b61cb371b118ff2b906c01399dcb602, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a277b145fddcc6cdec59e1810589290e recordList, Func<RC_9b61cb371b118ff2b906c01399dcb602, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a277b145fddcc6cdec59e1810589290e(RC_9b61cb371b118ff2b906c01399dcb602[] array) {
  RL_a277b145fddcc6cdec59e1810589290e result = new RL_a277b145fddcc6cdec59e1810589290e();
result.InnerFromArray(array);
    return result;
}

public static RL_a277b145fddcc6cdec59e1810589290e ToList<T>(T[] array, Func <T, RC_9b61cb371b118ff2b906c01399dcb602> converter) {
  RL_a277b145fddcc6cdec59e1810589290e result = new RL_a277b145fddcc6cdec59e1810589290e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a277b145fddcc6cdec59e1810589290e FromRestList<T>(RestList<T> restList, Func <T, RC_9b61cb371b118ff2b906c01399dcb602> converter) {
  RL_a277b145fddcc6cdec59e1810589290e result = new RL_a277b145fddcc6cdec59e1810589290e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a277b145fddcc6cdec59e1810589290e() : base() {
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
protected override OSList<RC_9b61cb371b118ff2b906c01399dcb602> NewList() {
return new RL_a277b145fddcc6cdec59e1810589290e();
}


} // RL_a277b145fddcc6cdec59e1810589290e
}

