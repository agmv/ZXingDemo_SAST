namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (FtUcOGMg1UGDCnzLIiyjLw)
///  <code>RC_e092deacf9bc8885dd34714ac00f33e4</code> that represents <code>MonthRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MonthRecord
public partial struct RC_e092deacf9bc8885dd34714ac00f33e4 : ITypedRecord<RC_e092deacf9bc8885dd34714ac00f33e4> {
internal static readonly GlobalObjectKey IdMonth = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rN6S4Lz5hYjdNHFKwA8z5A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Month")]
public EN_5be8b31925746693c09b3f64c4898006EntityRecord ssENMonth;


public static implicit operator EN_5be8b31925746693c09b3f64c4898006EntityRecord( RC_e092deacf9bc8885dd34714ac00f33e4 r) {
return r.ssENMonth;
}

public static implicit operator RC_e092deacf9bc8885dd34714ac00f33e4 (EN_5be8b31925746693c09b3f64c4898006EntityRecord r) {
RC_e092deacf9bc8885dd34714ac00f33e4 res = new RC_e092deacf9bc8885dd34714ac00f33e4 ();
res.ssENMonth = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMonth.ChangedAttributes = value;
}
get {
    return ssENMonth.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e092deacf9bc8885dd34714ac00f33e4() {
OptimizedAttributes = null;
ssENMonth = new EN_5be8b31925746693c09b3f64c4898006EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMonth.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMonth.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMonth.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMonth.Read( r, ref index);
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
public void ReadIM(RC_e092deacf9bc8885dd34714ac00f33e4 r) {
this = r;
}


public static bool operator == (RC_e092deacf9bc8885dd34714ac00f33e4 a, RC_e092deacf9bc8885dd34714ac00f33e4 b) {
if (a.ssENMonth != b.ssENMonth) return false;
return true;
}

public static bool operator != (RC_e092deacf9bc8885dd34714ac00f33e4 a, RC_e092deacf9bc8885dd34714ac00f33e4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e092deacf9bc8885dd34714ac00f33e4)) return false;
return (this == (RC_e092deacf9bc8885dd34714ac00f33e4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMonth.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMonth.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMonth.InternalRecursiveSave();
}


public RC_e092deacf9bc8885dd34714ac00f33e4 Duplicate() {
RC_e092deacf9bc8885dd34714ac00f33e4 t;
t.ssENMonth = (EN_5be8b31925746693c09b3f64c4898006EntityRecord)this.ssENMonth.Duplicate();
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
if (head == "month") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month")) variable.Value = ssENMonth; else variable.Optimized = true;
variable.SetFieldName("month");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMonth.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMonth.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMonth) {
return ssENMonth;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonth.Key.AsGuid) {
return ssENMonth;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMonth.FillFromOther((IRecord) other.AttributeGet(IdMonth));
}
} // RC_e092deacf9bc8885dd34714ac00f33e4
/// <summary>
/// RecordList type <code>MonthRecordList</code> that represents a record list of <code>Month</code>
/// </summary>
public partial class RL_a48ae6e6aedeec60d7b351d47494aa56 : GenericRecordList<RC_e092deacf9bc8885dd34714ac00f33e4>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e092deacf9bc8885dd34714ac00f33e4 GetElementDefaultValue() {
return new RC_e092deacf9bc8885dd34714ac00f33e4();
}

public T[] ToArray<T>(Func<RC_e092deacf9bc8885dd34714ac00f33e4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a48ae6e6aedeec60d7b351d47494aa56 recordList, Func<RC_e092deacf9bc8885dd34714ac00f33e4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a48ae6e6aedeec60d7b351d47494aa56(RC_e092deacf9bc8885dd34714ac00f33e4[] array) {
  RL_a48ae6e6aedeec60d7b351d47494aa56 result = new RL_a48ae6e6aedeec60d7b351d47494aa56();
result.InnerFromArray(array);
    return result;
}

public static RL_a48ae6e6aedeec60d7b351d47494aa56 ToList<T>(T[] array, Func <T, RC_e092deacf9bc8885dd34714ac00f33e4> converter) {
  RL_a48ae6e6aedeec60d7b351d47494aa56 result = new RL_a48ae6e6aedeec60d7b351d47494aa56();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a48ae6e6aedeec60d7b351d47494aa56 FromRestList<T>(RestList<T> restList, Func <T, RC_e092deacf9bc8885dd34714ac00f33e4> converter) {
  RL_a48ae6e6aedeec60d7b351d47494aa56 result = new RL_a48ae6e6aedeec60d7b351d47494aa56();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a48ae6e6aedeec60d7b351d47494aa56() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e092deacf9bc8885dd34714ac00f33e4> NewList() {
return new RL_a48ae6e6aedeec60d7b351d47494aa56();
}


} // RL_a48ae6e6aedeec60d7b351d47494aa56
}

