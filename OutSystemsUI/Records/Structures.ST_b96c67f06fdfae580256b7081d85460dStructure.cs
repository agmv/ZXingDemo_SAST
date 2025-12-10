namespace ssOutSystemsUI {
/// <summary>
/// [Structure] TimePickerOptionalConfigs (S86ifK4baUy+ZoPeWdAqqQ)
///  <code>ST_b96c67f06fdfae580256b7081d85460dStructure</code> that represent
/// s <code>TimePickerOptionalConfigs</code> <p>Description: DatePicker optional internal
///  configurations</p>
/// </summary>
// Name: TimePickerOptionalConfigs
public partial struct ST_b96c67f06fdfae580256b7081d85460dStructure : ITypedRecord<ST_b96c67f06fdfae580256b7081d85460dStructure> {
internal static readonly GlobalObjectKey IdMinTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*w8_8v+hP6k6mUfXfPRrTiQ");
internal static readonly GlobalObjectKey IdMaxTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*E__effw0okSXjZCsfWQAvg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MinTime")]
public DateTime ssMinTime;

[System.Xml.Serialization.XmlElement("MaxTime")]
public DateTime ssMaxTime;


public BitArray OptimizedAttributes;

public ST_b96c67f06fdfae580256b7081d85460dStructure() {
OptimizedAttributes = null;
ssMinTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMaxTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssMinTime = r.ReadTime(index++, "TimePickerOptionalConfigs.MinTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxTime = r.ReadTime(index++, "TimePickerOptionalConfigs.MaxTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_b96c67f06fdfae580256b7081d85460dStructure r) {
this = r;
}


public static bool operator == (ST_b96c67f06fdfae580256b7081d85460dStructure a, ST_b96c67f06fdfae580256b7081d85460dStructure b) {
if (a.ssMinTime != b.ssMinTime) return false;
if (a.ssMaxTime != b.ssMaxTime) return false;
return true;
}

public static bool operator != (ST_b96c67f06fdfae580256b7081d85460dStructure a, ST_b96c67f06fdfae580256b7081d85460dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b96c67f06fdfae580256b7081d85460dStructure)) return false;
return (this == (ST_b96c67f06fdfae580256b7081d85460dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMinTime.GetHashCode()
 ^ ssMaxTime.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b96c67f06fdfae580256b7081d85460dStructure Duplicate() {
ST_b96c67f06fdfae580256b7081d85460dStructure t;
t.ssMinTime = this.ssMinTime;
t.ssMaxTime = this.ssMaxTime;
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
if (head == "mintime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinTime")) variable.Value = ssMinTime; else variable.Optimized = true;
} else if (head == "maxtime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxTime")) variable.Value = ssMaxTime; else variable.Optimized = true;
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
if (key == IdMinTime) {
return ssMinTime;
}
if (key == IdMaxTime) {
return ssMaxTime;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMinTime.Key.AsGuid) {
return ssMinTime;
}
if (attributeKey == IdMaxTime.Key.AsGuid) {
return ssMaxTime;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMinTime = (DateTime) other.AttributeGet(IdMinTime);
ssMaxTime = (DateTime) other.AttributeGet(IdMaxTime);
}
} // ST_b96c67f06fdfae580256b7081d85460dStructure
/// <summary>
/// RecordList type <code>TimePickerOptionalConfigsList</code> that represents a record list of
///  <code>TimePickerOptionalConfigs</code>
/// </summary>
public partial class RL_5f1eb42ec5e25a70109aeb71587a7f0b : GenericRecordList<ST_b96c67f06fdfae580256b7081d85460dStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b96c67f06fdfae580256b7081d85460dStructure GetElementDefaultValue() {
return new ST_b96c67f06fdfae580256b7081d85460dStructure();
}

public T[] ToArray<T>(Func<ST_b96c67f06fdfae580256b7081d85460dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5f1eb42ec5e25a70109aeb71587a7f0b recordList, Func<ST_b96c67f06fdfae580256b7081d85460dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5f1eb42ec5e25a70109aeb71587a7f0b(ST_b96c67f06fdfae580256b7081d85460dStructure[] array) {
  RL_5f1eb42ec5e25a70109aeb71587a7f0b result = new RL_5f1eb42ec5e25a70109aeb71587a7f0b();
result.InnerFromArray(array);
    return result;
}

public static RL_5f1eb42ec5e25a70109aeb71587a7f0b ToList<T>(T[] array, Func <T, ST_b96c67f06fdfae580256b7081d85460dStructure> converter) {
  RL_5f1eb42ec5e25a70109aeb71587a7f0b result = new RL_5f1eb42ec5e25a70109aeb71587a7f0b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5f1eb42ec5e25a70109aeb71587a7f0b FromRestList<T>(RestList<T> restList, Func <T, ST_b96c67f06fdfae580256b7081d85460dStructure> converter) {
  RL_5f1eb42ec5e25a70109aeb71587a7f0b result = new RL_5f1eb42ec5e25a70109aeb71587a7f0b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5f1eb42ec5e25a70109aeb71587a7f0b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b96c67f06fdfae580256b7081d85460dStructure> NewList() {
return new RL_5f1eb42ec5e25a70109aeb71587a7f0b();
}


} // RL_5f1eb42ec5e25a70109aeb71587a7f0b
}

