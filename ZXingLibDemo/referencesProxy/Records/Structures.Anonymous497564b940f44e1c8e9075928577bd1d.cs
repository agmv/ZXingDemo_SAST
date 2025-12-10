namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (uWR1SfRAHE6OkHWShXe9HQ)
///  <code>RC_2796116ff1beb3c001fb57dc12652270</code> that represents <code>CalendarEventRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CalendarEventRecord
public partial struct RC_2796116ff1beb3c001fb57dc12652270 : ITypedRecord<RC_2796116ff1beb3c001fb57dc12652270>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdCalendarEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bxGWJ77xwLMB+1fcEmUicA");

[System.Xml.Serialization.XmlElement("CalendarEvent")]
public ST_8738e857d4fb6695d1e17d4c03428ee2Structure ssSTCalendarEvent;


public static implicit operator ST_8738e857d4fb6695d1e17d4c03428ee2Structure( RC_2796116ff1beb3c001fb57dc12652270 r) {
return r.ssSTCalendarEvent;
}

public static implicit operator RC_2796116ff1beb3c001fb57dc12652270 (ST_8738e857d4fb6695d1e17d4c03428ee2Structure r) {
RC_2796116ff1beb3c001fb57dc12652270 res = new RC_2796116ff1beb3c001fb57dc12652270 ();
res.ssSTCalendarEvent = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2796116ff1beb3c001fb57dc12652270() {
OptimizedAttributes = null;
ssSTCalendarEvent = new ST_8738e857d4fb6695d1e17d4c03428ee2Structure();
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
    ssSTCalendarEvent.OptimizedAttributes = value[0];
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
ssSTCalendarEvent.Read( r, ref index);
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
public void ReadIM(RC_2796116ff1beb3c001fb57dc12652270 r) {
this = r;
}


public static bool operator == (RC_2796116ff1beb3c001fb57dc12652270 a, RC_2796116ff1beb3c001fb57dc12652270 b) {
if (a.ssSTCalendarEvent != b.ssSTCalendarEvent) return false;
return true;
}

public static bool operator != (RC_2796116ff1beb3c001fb57dc12652270 a, RC_2796116ff1beb3c001fb57dc12652270 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2796116ff1beb3c001fb57dc12652270)) return false;
return (this == (RC_2796116ff1beb3c001fb57dc12652270)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCalendarEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCalendarEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCalendarEvent.InternalRecursiveSave();
}


public RC_2796116ff1beb3c001fb57dc12652270 Duplicate() {
RC_2796116ff1beb3c001fb57dc12652270 t;
t.ssSTCalendarEvent = (ST_8738e857d4fb6695d1e17d4c03428ee2Structure)this.ssSTCalendarEvent.Duplicate();
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
if (head == "calendarevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CalendarEvent")) variable.Value = ssSTCalendarEvent; else variable.Optimized = true;
variable.SetFieldName("calendarevent");
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
if (key == IdCalendarEvent) {
return ssSTCalendarEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCalendarEvent.Key.AsGuid) {
return ssSTCalendarEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCalendarEvent.FillFromOther((IRecord) other.AttributeGet(IdCalendarEvent));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTCalendarEvent.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdCalendarEvent.Key.AsGuid));
}
} // RC_2796116ff1beb3c001fb57dc12652270
/// <summary>
/// RecordList type <code>CalendarEventRecordList</code> that represents a record list of
///  <code>CalendarEvent</code>
/// </summary>
public partial class RL_d57a347c50a9dd6ba71955af3532d092 : GenericRecordList<RC_2796116ff1beb3c001fb57dc12652270>, IEnumerable, IEnumerator {

protected override RC_2796116ff1beb3c001fb57dc12652270 GetElementDefaultValue() {
return new RC_2796116ff1beb3c001fb57dc12652270();
}

public T[] ToArray<T>(Func<RC_2796116ff1beb3c001fb57dc12652270, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d57a347c50a9dd6ba71955af3532d092 recordList, Func<RC_2796116ff1beb3c001fb57dc12652270, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d57a347c50a9dd6ba71955af3532d092(RC_2796116ff1beb3c001fb57dc12652270[] array) {
  RL_d57a347c50a9dd6ba71955af3532d092 result = new RL_d57a347c50a9dd6ba71955af3532d092();
result.InnerFromArray(array);
    return result;
}

public static RL_d57a347c50a9dd6ba71955af3532d092 ToList<T>(T[] array, Func <T, RC_2796116ff1beb3c001fb57dc12652270> converter) {
  RL_d57a347c50a9dd6ba71955af3532d092 result = new RL_d57a347c50a9dd6ba71955af3532d092();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d57a347c50a9dd6ba71955af3532d092 FromRestList<T>(RestList<T> restList, Func <T, RC_2796116ff1beb3c001fb57dc12652270> converter) {
  RL_d57a347c50a9dd6ba71955af3532d092 result = new RL_d57a347c50a9dd6ba71955af3532d092();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d57a347c50a9dd6ba71955af3532d092() : base() {
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
protected override OSList<RC_2796116ff1beb3c001fb57dc12652270> NewList() {
return new RL_d57a347c50a9dd6ba71955af3532d092();
}


} // RL_d57a347c50a9dd6ba71955af3532d092
}

