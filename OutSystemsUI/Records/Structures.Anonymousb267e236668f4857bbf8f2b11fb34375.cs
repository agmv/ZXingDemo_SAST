namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (NuJnso9mV0i7+PKxH7NDdQ)
///  <code>RC_edb482045d64b0cbbcbf62278fb73c32</code> that represent
/// s <code>MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord
public partial struct RC_edb482045d64b0cbbcbf62278fb73c32 : ITypedRecord<RC_edb482045d64b0cbbcbf62278fb73c32> {
internal static readonly GlobalObjectKey IdMidnight = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rexT8A_euUhtlg55vgoCBw");
internal static readonly GlobalObjectKey IdNextMonth = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+fEvTQonzwfrfen1kHayhw");
internal static readonly GlobalObjectKey IdNoon = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UBAq79HHWCX_IDKNf5k3Og");
internal static readonly GlobalObjectKey IdPreviousMonth = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_PbpZ18ZM8IVP5Kh4Q3gQA");
internal static readonly GlobalObjectKey IdTodayButton = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TvWVDlDoRzfSP42EPsHKsA");
internal static readonly GlobalObjectKey IdWeekdays = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0bd+CF3QoOpeMenLEFAZuQ");
internal static readonly GlobalObjectKey IdWeekdaysShort = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o_+6eG0HLr0AO5zdiFwEOQ");
internal static readonly GlobalObjectKey IdMonths = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hbluGoH3Inz+JPZ81965vA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Midnight")]
public string ssMidnight;

[System.Xml.Serialization.XmlElement("NextMonth")]
public string ssNextMonth;

[System.Xml.Serialization.XmlElement("Noon")]
public string ssNoon;

[System.Xml.Serialization.XmlElement("PreviousMonth")]
public string ssPreviousMonth;

[System.Xml.Serialization.XmlElement("TodayButton")]
public string ssTodayButton;

[System.Xml.Serialization.XmlElement("Weekdays")]
public RL_1729600b673fd0870291732dd16f0147 ssRLWeekdays;

[System.Xml.Serialization.XmlElement("WeekdaysShort")]
public RL_4260c6c2a6b32d80f4d763c795bd8980 ssRLWeekdaysShort;

[System.Xml.Serialization.XmlElement("Months")]
public RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 ssRLMonths;


public BitArray OptimizedAttributes;

public RC_edb482045d64b0cbbcbf62278fb73c32() {
OptimizedAttributes = null;
ssMidnight = "";
ssNextMonth = "";
ssNoon = "";
ssPreviousMonth = "";
ssTodayButton = "";
ssRLWeekdays = new RL_1729600b673fd0870291732dd16f0147();
ssRLWeekdaysShort = new RL_4260c6c2a6b32d80f4d763c795bd8980();
ssRLMonths = new RL_aec2af9ce70ea7e7bfe1e63d0f657cf5();
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
ssMidnight = r.ReadText(index++, "MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord.Midnight", "");
ssNextMonth = r.ReadText(index++, "MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord.NextMonth", "");
ssNoon = r.ReadText(index++, "MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord.Noon", "");
ssPreviousMonth = r.ReadText(index++, "MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord.PreviousMonth", "");
ssTodayButton = r.ReadText(index++, "MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecord.TodayButton", "");
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
public void ReadIM(RC_edb482045d64b0cbbcbf62278fb73c32 r) {
this = r;
}


public static bool operator == (RC_edb482045d64b0cbbcbf62278fb73c32 a, RC_edb482045d64b0cbbcbf62278fb73c32 b) {
if (a.ssMidnight != b.ssMidnight) return false;
if (a.ssNextMonth != b.ssNextMonth) return false;
if (a.ssNoon != b.ssNoon) return false;
if (a.ssPreviousMonth != b.ssPreviousMonth) return false;
if (a.ssTodayButton != b.ssTodayButton) return false;
if (a.ssRLWeekdays != b.ssRLWeekdays) return false;
if (a.ssRLWeekdaysShort != b.ssRLWeekdaysShort) return false;
if (a.ssRLMonths != b.ssRLMonths) return false;
return true;
}

public static bool operator != (RC_edb482045d64b0cbbcbf62278fb73c32 a, RC_edb482045d64b0cbbcbf62278fb73c32 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_edb482045d64b0cbbcbf62278fb73c32)) return false;
return (this == (RC_edb482045d64b0cbbcbf62278fb73c32)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMidnight.GetHashCode()
 ^ ssNextMonth.GetHashCode()
 ^ ssNoon.GetHashCode()
 ^ ssPreviousMonth.GetHashCode()
 ^ ssTodayButton.GetHashCode()
 ^ ssRLWeekdays.GetHashCode()
 ^ ssRLWeekdaysShort.GetHashCode()
 ^ ssRLMonths.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssRLWeekdays.RecursiveReset();
ssRLWeekdaysShort.RecursiveReset();
ssRLMonths.RecursiveReset();
}

public void InternalRecursiveSave() {
ssRLWeekdays.InternalRecursiveSave();
ssRLWeekdaysShort.InternalRecursiveSave();
ssRLMonths.InternalRecursiveSave();
}


public RC_edb482045d64b0cbbcbf62278fb73c32 Duplicate() {
RC_edb482045d64b0cbbcbf62278fb73c32 t;
t.ssMidnight = this.ssMidnight;
t.ssNextMonth = this.ssNextMonth;
t.ssNoon = this.ssNoon;
t.ssPreviousMonth = this.ssPreviousMonth;
t.ssTodayButton = this.ssTodayButton;
t.ssRLWeekdays = (RL_1729600b673fd0870291732dd16f0147)this.ssRLWeekdays.Duplicate();
t.ssRLWeekdaysShort = (RL_4260c6c2a6b32d80f4d763c795bd8980)this.ssRLWeekdaysShort.Duplicate();
t.ssRLMonths = (RL_aec2af9ce70ea7e7bfe1e63d0f657cf5)this.ssRLMonths.Duplicate();
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
if (head == "midnight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Midnight")) variable.Value = ssMidnight; else variable.Optimized = true;
} else if (head == "nextmonth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NextMonth")) variable.Value = ssNextMonth; else variable.Optimized = true;
} else if (head == "noon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Noon")) variable.Value = ssNoon; else variable.Optimized = true;
} else if (head == "previousmonth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PreviousMonth")) variable.Value = ssPreviousMonth; else variable.Optimized = true;
} else if (head == "todaybutton") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TodayButton")) variable.Value = ssTodayButton; else variable.Optimized = true;
} else if (head == "weekdays") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekdays")) variable.Value = ssRLWeekdays; else variable.Optimized = true;
variable.SetFieldName("weekdays");
} else if (head == "weekdaysshort") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdaysShort")) variable.Value = ssRLWeekdaysShort; else variable.Optimized = true;
variable.SetFieldName("weekdaysshort");
} else if (head == "months") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Months")) variable.Value = ssRLMonths; else variable.Optimized = true;
variable.SetFieldName("months");
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
if (key == IdMidnight) {
return ssMidnight;
}
if (key == IdNextMonth) {
return ssNextMonth;
}
if (key == IdNoon) {
return ssNoon;
}
if (key == IdPreviousMonth) {
return ssPreviousMonth;
}
if (key == IdTodayButton) {
return ssTodayButton;
}
if (key == IdWeekdays) {
return ssRLWeekdays;
}
if (key == IdWeekdaysShort) {
return ssRLWeekdaysShort;
}
if (key == IdMonths) {
return ssRLMonths;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMidnight.Key.AsGuid) {
return ssMidnight;
}
if (attributeKey == IdNextMonth.Key.AsGuid) {
return ssNextMonth;
}
if (attributeKey == IdNoon.Key.AsGuid) {
return ssNoon;
}
if (attributeKey == IdPreviousMonth.Key.AsGuid) {
return ssPreviousMonth;
}
if (attributeKey == IdTodayButton.Key.AsGuid) {
return ssTodayButton;
}
if (attributeKey == IdWeekdays.Key.AsGuid) {
return ssRLWeekdays;
}
if (attributeKey == IdWeekdaysShort.Key.AsGuid) {
return ssRLWeekdaysShort;
}
if (attributeKey == IdMonths.Key.AsGuid) {
return ssRLMonths;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMidnight = (string) other.AttributeGet(IdMidnight);
ssNextMonth = (string) other.AttributeGet(IdNextMonth);
ssNoon = (string) other.AttributeGet(IdNoon);
ssPreviousMonth = (string) other.AttributeGet(IdPreviousMonth);
ssTodayButton = (string) other.AttributeGet(IdTodayButton);
ssRLWeekdays = new RL_1729600b673fd0870291732dd16f0147();
ssRLWeekdays.FillFromOther((IOSList) other.AttributeGet(IdWeekdays));
ssRLWeekdaysShort = new RL_4260c6c2a6b32d80f4d763c795bd8980();
ssRLWeekdaysShort.FillFromOther((IOSList) other.AttributeGet(IdWeekdaysShort));
ssRLMonths = new RL_aec2af9ce70ea7e7bfe1e63d0f657cf5();
ssRLMonths.FillFromOther((IOSList) other.AttributeGet(IdMonths));
}
} // RC_edb482045d64b0cbbcbf62278fb73c32
/// <summary>
/// RecordList type
///  <code>MidnightNextMonthNoonPreviousMonthTodayButtonWeekdaysWeekdaysShortMonthsRecordList</code
/// > that represents a record list of <code>Text, Text, Text, Text, Text,
///  Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7RecordList
/// ,
///  WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7RecordLi
/// st, Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9RecordList</code>
/// </summary>
public partial class RL_df229a142c5216bd1ccc062986b28796 : GenericRecordList<RC_edb482045d64b0cbbcbf62278fb73c32>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_edb482045d64b0cbbcbf62278fb73c32 GetElementDefaultValue() {
return new RC_edb482045d64b0cbbcbf62278fb73c32();
}

public T[] ToArray<T>(Func<RC_edb482045d64b0cbbcbf62278fb73c32, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_df229a142c5216bd1ccc062986b28796 recordList, Func<RC_edb482045d64b0cbbcbf62278fb73c32, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_df229a142c5216bd1ccc062986b28796(RC_edb482045d64b0cbbcbf62278fb73c32[] array) {
  RL_df229a142c5216bd1ccc062986b28796 result = new RL_df229a142c5216bd1ccc062986b28796();
result.InnerFromArray(array);
    return result;
}

public static RL_df229a142c5216bd1ccc062986b28796 ToList<T>(T[] array, Func <T, RC_edb482045d64b0cbbcbf62278fb73c32> converter) {
  RL_df229a142c5216bd1ccc062986b28796 result = new RL_df229a142c5216bd1ccc062986b28796();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_df229a142c5216bd1ccc062986b28796 FromRestList<T>(RestList<T> restList, Func <T, RC_edb482045d64b0cbbcbf62278fb73c32> converter) {
  RL_df229a142c5216bd1ccc062986b28796 result = new RL_df229a142c5216bd1ccc062986b28796();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_df229a142c5216bd1ccc062986b28796() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_edb482045d64b0cbbcbf62278fb73c32> NewList() {
return new RL_df229a142c5216bd1ccc062986b28796();
}


} // RL_df229a142c5216bd1ccc062986b28796
}

