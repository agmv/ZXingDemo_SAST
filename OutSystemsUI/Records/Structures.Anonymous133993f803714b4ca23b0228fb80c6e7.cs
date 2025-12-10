namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (+JM5E3EDTEuiOwIo+4DG5w)
///  <code>RC_1d16add6c65a995967ac402e66fde3ff</code> that represent
/// s <code>DatePickerRange_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerRange_InternalConfigRecord
public partial struct RC_1d16add6c65a995967ac402e66fde3ff : ITypedRecord<RC_1d16add6c65a995967ac402e66fde3ff> {
internal static readonly GlobalObjectKey IdDatePickerRange_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1q0WHVrGWZlnrEAuZv3j_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DatePickerRange_InternalConfig")]
public ST_256310aee13520906f2ba115af101f62Structure ssSTDatePickerRange_InternalConfig;


public static implicit operator ST_256310aee13520906f2ba115af101f62Structure( RC_1d16add6c65a995967ac402e66fde3ff r) {
return r.ssSTDatePickerRange_InternalConfig;
}

public static implicit operator RC_1d16add6c65a995967ac402e66fde3ff (ST_256310aee13520906f2ba115af101f62Structure r) {
RC_1d16add6c65a995967ac402e66fde3ff res = new RC_1d16add6c65a995967ac402e66fde3ff ();
res.ssSTDatePickerRange_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1d16add6c65a995967ac402e66fde3ff() {
OptimizedAttributes = null;
ssSTDatePickerRange_InternalConfig = new ST_256310aee13520906f2ba115af101f62Structure();
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
    ssSTDatePickerRange_InternalConfig.OptimizedAttributes = value[0];
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
ssSTDatePickerRange_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_1d16add6c65a995967ac402e66fde3ff r) {
this = r;
}


public static bool operator == (RC_1d16add6c65a995967ac402e66fde3ff a, RC_1d16add6c65a995967ac402e66fde3ff b) {
if (a.ssSTDatePickerRange_InternalConfig != b.ssSTDatePickerRange_InternalConfig) return false;
return true;
}

public static bool operator != (RC_1d16add6c65a995967ac402e66fde3ff a, RC_1d16add6c65a995967ac402e66fde3ff b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1d16add6c65a995967ac402e66fde3ff)) return false;
return (this == (RC_1d16add6c65a995967ac402e66fde3ff)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDatePickerRange_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDatePickerRange_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDatePickerRange_InternalConfig.InternalRecursiveSave();
}


public RC_1d16add6c65a995967ac402e66fde3ff Duplicate() {
RC_1d16add6c65a995967ac402e66fde3ff t;
t.ssSTDatePickerRange_InternalConfig = (ST_256310aee13520906f2ba115af101f62Structure)this.ssSTDatePickerRange_InternalConfig.Duplicate();
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
if (head == "datepickerrange_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerRange_InternalConfig")) variable.Value = ssSTDatePickerRange_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("datepickerrange_internalconfig");
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
if (key == IdDatePickerRange_InternalConfig) {
return ssSTDatePickerRange_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerRange_InternalConfig.Key.AsGuid) {
return ssSTDatePickerRange_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDatePickerRange_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdDatePickerRange_InternalConfig));
}
} // RC_1d16add6c65a995967ac402e66fde3ff
/// <summary>
/// RecordList type <code>DatePickerRange_InternalConfigRecordList</code> that represents a record list
///  of <code>DatePickerRange_InternalConfig</code>
/// </summary>
public partial class RL_d6c0b448038896edf0289bb81122c411 : GenericRecordList<RC_1d16add6c65a995967ac402e66fde3ff>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_1d16add6c65a995967ac402e66fde3ff GetElementDefaultValue() {
return new RC_1d16add6c65a995967ac402e66fde3ff();
}

public T[] ToArray<T>(Func<RC_1d16add6c65a995967ac402e66fde3ff, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d6c0b448038896edf0289bb81122c411 recordList, Func<RC_1d16add6c65a995967ac402e66fde3ff, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d6c0b448038896edf0289bb81122c411(RC_1d16add6c65a995967ac402e66fde3ff[] array) {
  RL_d6c0b448038896edf0289bb81122c411 result = new RL_d6c0b448038896edf0289bb81122c411();
result.InnerFromArray(array);
    return result;
}

public static RL_d6c0b448038896edf0289bb81122c411 ToList<T>(T[] array, Func <T, RC_1d16add6c65a995967ac402e66fde3ff> converter) {
  RL_d6c0b448038896edf0289bb81122c411 result = new RL_d6c0b448038896edf0289bb81122c411();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d6c0b448038896edf0289bb81122c411 FromRestList<T>(RestList<T> restList, Func <T, RC_1d16add6c65a995967ac402e66fde3ff> converter) {
  RL_d6c0b448038896edf0289bb81122c411 result = new RL_d6c0b448038896edf0289bb81122c411();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d6c0b448038896edf0289bb81122c411() : base() {
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
protected override OSList<RC_1d16add6c65a995967ac402e66fde3ff> NewList() {
return new RL_d6c0b448038896edf0289bb81122c411();
}


} // RL_d6c0b448038896edf0289bb81122c411
}

