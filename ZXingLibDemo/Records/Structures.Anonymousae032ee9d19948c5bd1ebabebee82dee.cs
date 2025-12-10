namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (6S4DrpnRxUi9Hrq+vugt7g)
///  <code>RC_8acf1c157094e2761d62d068555c0d1c</code> that represents <code>CodeDefaultsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CodeDefaultsRecord
public partial struct RC_8acf1c157094e2761d62d068555c0d1c : ITypedRecord<RC_8acf1c157094e2761d62d068555c0d1c> {
internal static readonly GlobalObjectKey IdCodeDefaults = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FRzPipRwduIdYtBoVVwNHA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CodeDefaults")]
public EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord ssENCodeDefaults;


public static implicit operator EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord( RC_8acf1c157094e2761d62d068555c0d1c r) {
return r.ssENCodeDefaults;
}

public static implicit operator RC_8acf1c157094e2761d62d068555c0d1c (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord r) {
RC_8acf1c157094e2761d62d068555c0d1c res = new RC_8acf1c157094e2761d62d068555c0d1c ();
res.ssENCodeDefaults = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCodeDefaults.ChangedAttributes = value;
}
get {
    return ssENCodeDefaults.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8acf1c157094e2761d62d068555c0d1c() {
OptimizedAttributes = null;
ssENCodeDefaults = new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCodeDefaults.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCodeDefaults.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCodeDefaults.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCodeDefaults.Read( r, ref index);
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
public void ReadIM(RC_8acf1c157094e2761d62d068555c0d1c r) {
this = r;
}


public static bool operator == (RC_8acf1c157094e2761d62d068555c0d1c a, RC_8acf1c157094e2761d62d068555c0d1c b) {
if (a.ssENCodeDefaults != b.ssENCodeDefaults) return false;
return true;
}

public static bool operator != (RC_8acf1c157094e2761d62d068555c0d1c a, RC_8acf1c157094e2761d62d068555c0d1c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8acf1c157094e2761d62d068555c0d1c)) return false;
return (this == (RC_8acf1c157094e2761d62d068555c0d1c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCodeDefaults.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCodeDefaults.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCodeDefaults.InternalRecursiveSave();
}


public RC_8acf1c157094e2761d62d068555c0d1c Duplicate() {
RC_8acf1c157094e2761d62d068555c0d1c t;
t.ssENCodeDefaults = (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord)this.ssENCodeDefaults.Duplicate();
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
if (head == "codedefaults") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CodeDefaults")) variable.Value = ssENCodeDefaults; else variable.Optimized = true;
variable.SetFieldName("codedefaults");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCodeDefaults.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCodeDefaults.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCodeDefaults) {
return ssENCodeDefaults;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCodeDefaults.Key.AsGuid) {
return ssENCodeDefaults;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCodeDefaults.FillFromOther((IRecord) other.AttributeGet(IdCodeDefaults));
}
} // RC_8acf1c157094e2761d62d068555c0d1c
/// <summary>
/// RecordList type <code>CodeDefaultsRecordList</code> that represents a record list of
///  <code>CodeDefaults</code>
/// </summary>
public partial class RL_389ebe1f107310cdc9de4af24cd413c4 : GenericRecordList<RC_8acf1c157094e2761d62d068555c0d1c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8acf1c157094e2761d62d068555c0d1c GetElementDefaultValue() {
return new RC_8acf1c157094e2761d62d068555c0d1c();
}

public T[] ToArray<T>(Func<RC_8acf1c157094e2761d62d068555c0d1c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_389ebe1f107310cdc9de4af24cd413c4 recordList, Func<RC_8acf1c157094e2761d62d068555c0d1c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_389ebe1f107310cdc9de4af24cd413c4(RC_8acf1c157094e2761d62d068555c0d1c[] array) {
  RL_389ebe1f107310cdc9de4af24cd413c4 result = new RL_389ebe1f107310cdc9de4af24cd413c4();
result.InnerFromArray(array);
    return result;
}

public static RL_389ebe1f107310cdc9de4af24cd413c4 ToList<T>(T[] array, Func <T, RC_8acf1c157094e2761d62d068555c0d1c> converter) {
  RL_389ebe1f107310cdc9de4af24cd413c4 result = new RL_389ebe1f107310cdc9de4af24cd413c4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_389ebe1f107310cdc9de4af24cd413c4 FromRestList<T>(RestList<T> restList, Func <T, RC_8acf1c157094e2761d62d068555c0d1c> converter) {
  RL_389ebe1f107310cdc9de4af24cd413c4 result = new RL_389ebe1f107310cdc9de4af24cd413c4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_389ebe1f107310cdc9de4af24cd413c4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8acf1c157094e2761d62d068555c0d1c> NewList() {
return new RL_389ebe1f107310cdc9de4af24cd413c4();
}


} // RL_389ebe1f107310cdc9de4af24cd413c4
}

