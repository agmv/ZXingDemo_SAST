namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (KfCndHecCUiZ4tv0OQBHbw)
///  <code>RC_de3deb221a4b1656cc37f0db973c4e9a</code> that represent
/// s <code>DatePickerCalendarTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerCalendarTypeRecord
public partial struct RC_de3deb221a4b1656cc37f0db973c4e9a : ITypedRecord<RC_de3deb221a4b1656cc37f0db973c4e9a> {
internal static readonly GlobalObjectKey IdDatePickerCalendarType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ius93ksaVhbMN_DblzxOmg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DatePickerCalendarType")]
public EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord ssENDatePickerCalendarType;


public static implicit operator EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord( RC_de3deb221a4b1656cc37f0db973c4e9a r) {
return r.ssENDatePickerCalendarType;
}

public static implicit operator RC_de3deb221a4b1656cc37f0db973c4e9a (EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord r) {
RC_de3deb221a4b1656cc37f0db973c4e9a res = new RC_de3deb221a4b1656cc37f0db973c4e9a ();
res.ssENDatePickerCalendarType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDatePickerCalendarType.ChangedAttributes = value;
}
get {
    return ssENDatePickerCalendarType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_de3deb221a4b1656cc37f0db973c4e9a() {
OptimizedAttributes = null;
ssENDatePickerCalendarType = new EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDatePickerCalendarType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDatePickerCalendarType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDatePickerCalendarType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDatePickerCalendarType.Read( r, ref index);
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
public void ReadIM(RC_de3deb221a4b1656cc37f0db973c4e9a r) {
this = r;
}


public static bool operator == (RC_de3deb221a4b1656cc37f0db973c4e9a a, RC_de3deb221a4b1656cc37f0db973c4e9a b) {
if (a.ssENDatePickerCalendarType != b.ssENDatePickerCalendarType) return false;
return true;
}

public static bool operator != (RC_de3deb221a4b1656cc37f0db973c4e9a a, RC_de3deb221a4b1656cc37f0db973c4e9a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_de3deb221a4b1656cc37f0db973c4e9a)) return false;
return (this == (RC_de3deb221a4b1656cc37f0db973c4e9a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDatePickerCalendarType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDatePickerCalendarType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDatePickerCalendarType.InternalRecursiveSave();
}


public RC_de3deb221a4b1656cc37f0db973c4e9a Duplicate() {
RC_de3deb221a4b1656cc37f0db973c4e9a t;
t.ssENDatePickerCalendarType = (EN_c521eea762e9dd37e04340f2864e8aa0EntityRecord)this.ssENDatePickerCalendarType.Duplicate();
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
if (head == "datepickercalendartype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerCalendarType")) variable.Value = ssENDatePickerCalendarType; else variable.Optimized = true;
variable.SetFieldName("datepickercalendartype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerCalendarType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerCalendarType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDatePickerCalendarType) {
return ssENDatePickerCalendarType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerCalendarType.Key.AsGuid) {
return ssENDatePickerCalendarType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDatePickerCalendarType.FillFromOther((IRecord) other.AttributeGet(IdDatePickerCalendarType));
}
} // RC_de3deb221a4b1656cc37f0db973c4e9a
/// <summary>
/// RecordList type <code>DatePickerCalendarTypeRecordList</code> that represents a record list of
///  <code>DatePickerCalendarType</code>
/// </summary>
public partial class RL_f05e8ae3043c6c2ac7e0d3791d45935e : GenericRecordList<RC_de3deb221a4b1656cc37f0db973c4e9a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_de3deb221a4b1656cc37f0db973c4e9a GetElementDefaultValue() {
return new RC_de3deb221a4b1656cc37f0db973c4e9a();
}

public T[] ToArray<T>(Func<RC_de3deb221a4b1656cc37f0db973c4e9a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f05e8ae3043c6c2ac7e0d3791d45935e recordList, Func<RC_de3deb221a4b1656cc37f0db973c4e9a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f05e8ae3043c6c2ac7e0d3791d45935e(RC_de3deb221a4b1656cc37f0db973c4e9a[] array) {
  RL_f05e8ae3043c6c2ac7e0d3791d45935e result = new RL_f05e8ae3043c6c2ac7e0d3791d45935e();
result.InnerFromArray(array);
    return result;
}

public static RL_f05e8ae3043c6c2ac7e0d3791d45935e ToList<T>(T[] array, Func <T, RC_de3deb221a4b1656cc37f0db973c4e9a> converter) {
  RL_f05e8ae3043c6c2ac7e0d3791d45935e result = new RL_f05e8ae3043c6c2ac7e0d3791d45935e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f05e8ae3043c6c2ac7e0d3791d45935e FromRestList<T>(RestList<T> restList, Func <T, RC_de3deb221a4b1656cc37f0db973c4e9a> converter) {
  RL_f05e8ae3043c6c2ac7e0d3791d45935e result = new RL_f05e8ae3043c6c2ac7e0d3791d45935e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f05e8ae3043c6c2ac7e0d3791d45935e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_de3deb221a4b1656cc37f0db973c4e9a> NewList() {
return new RL_f05e8ae3043c6c2ac7e0d3791d45935e();
}


} // RL_f05e8ae3043c6c2ac7e0d3791d45935e
}

