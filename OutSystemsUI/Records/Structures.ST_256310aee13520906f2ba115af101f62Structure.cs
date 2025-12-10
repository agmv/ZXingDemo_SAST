namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DatePickerRange_InternalConfig (M7RRGRGKP0SLWAEcNwHH2w)
///  <code>ST_256310aee13520906f2ba115af101f62Structure</code> that represent
/// s <code>DatePickerRange_InternalConfig</code> <p>Description: Group of internal configurations for
///  the DatePickerRange block. </p>
/// </summary>
// Name: DatePickerRange_InternalConfig
public partial struct ST_256310aee13520906f2ba115af101f62Structure : ITypedRecord<ST_256310aee13520906f2ba115af101f62Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Ggo0hQnnxkakoqjS6t_3yw");
internal static readonly GlobalObjectKey IdDateFormat = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*B9QMfHypMkCZYn59uVXB5g");
internal static readonly GlobalObjectKey IdInitialStartDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ioE9IgDcvkelWFgzmmG7tQ");
internal static readonly GlobalObjectKey IdInitialEndDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*wJEykphqCk2yDxCY5B7lmA");
internal static readonly GlobalObjectKey IdShowTodayButton = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*d4KUsFgzJEam9uONAE92bA");
internal static readonly GlobalObjectKey IdFirstWeekDay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*US3vuezpnUCFNuNXuKQd+g");
internal static readonly GlobalObjectKey IdMinDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*XPMk3HuRqkW71u4ejv19Fg");
internal static readonly GlobalObjectKey IdMaxDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*frRMVbw+T0iUodzo_EdHzw");
internal static readonly GlobalObjectKey IdShowWeekNumbers = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*kuWkOe4fGEO7WAzT6ckM1g");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*O1_jEkHYb0um_kI1J0+Mmw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("DateFormat")]
public string ssDateFormat;

[System.Xml.Serialization.XmlElement("InitialStartDate")]
public DateTime ssInitialStartDate;

[System.Xml.Serialization.XmlElement("InitialEndDate")]
public DateTime ssInitialEndDate;

[System.Xml.Serialization.XmlElement("ShowTodayButton")]
public bool ssShowTodayButton;

[System.Xml.Serialization.XmlElement("FirstWeekDay")]
public int ssFirstWeekDay;

[System.Xml.Serialization.XmlElement("MinDate")]
public DateTime ssMinDate;

[System.Xml.Serialization.XmlElement("MaxDate")]
public DateTime ssMaxDate;

[System.Xml.Serialization.XmlElement("ShowWeekNumbers")]
public bool ssShowWeekNumbers;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_256310aee13520906f2ba115af101f62Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssDateFormat = "";
ssInitialStartDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssInitialEndDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssShowTodayButton = false;
ssFirstWeekDay = (ENDatePickerWeekDayEntity.GetRecordByKey(ObjectKey.Parse("0CEPV769vkukUgLjN29p2A"))).ssWeekDay;
ssMinDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMaxDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssShowWeekNumbers = false;
ssExtendedClass = "";
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
ssUniqueId = r.ReadText(index++, "DatePickerRange_InternalConfig.UniqueId", "");
ssDateFormat = r.ReadText(index++, "DatePickerRange_InternalConfig.DateFormat", "");
ssInitialStartDate = r.ReadDateTime(index++, "DatePickerRange_InternalConfig.InitialStartDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssInitialEndDate = r.ReadDateTime(index++, "DatePickerRange_InternalConfig.InitialEndDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssShowTodayButton = r.ReadBoolean(index++, "DatePickerRange_InternalConfig.ShowTodayButton", false);
ssFirstWeekDay = r.ReadEntityReference(index++, "DatePickerRange_InternalConfig.FirstWeekDay", 0);
ssMinDate = r.ReadDateTime(index++, "DatePickerRange_InternalConfig.MinDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxDate = r.ReadDateTime(index++, "DatePickerRange_InternalConfig.MaxDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssShowWeekNumbers = r.ReadBoolean(index++, "DatePickerRange_InternalConfig.ShowWeekNumbers", false);
ssExtendedClass = r.ReadText(index++, "DatePickerRange_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_256310aee13520906f2ba115af101f62Structure r) {
this = r;
}


public static bool operator == (ST_256310aee13520906f2ba115af101f62Structure a, ST_256310aee13520906f2ba115af101f62Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssDateFormat != b.ssDateFormat) return false;
if (a.ssInitialStartDate != b.ssInitialStartDate) return false;
if (a.ssInitialEndDate != b.ssInitialEndDate) return false;
if (a.ssShowTodayButton != b.ssShowTodayButton) return false;
if (a.ssFirstWeekDay != b.ssFirstWeekDay) return false;
if (a.ssMinDate != b.ssMinDate) return false;
if (a.ssMaxDate != b.ssMaxDate) return false;
if (a.ssShowWeekNumbers != b.ssShowWeekNumbers) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_256310aee13520906f2ba115af101f62Structure a, ST_256310aee13520906f2ba115af101f62Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_256310aee13520906f2ba115af101f62Structure)) return false;
return (this == (ST_256310aee13520906f2ba115af101f62Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssDateFormat.GetHashCode()
 ^ ssInitialStartDate.GetHashCode()
 ^ ssInitialEndDate.GetHashCode()
 ^ ssShowTodayButton.GetHashCode()
 ^ ssFirstWeekDay.GetHashCode()
 ^ ssMinDate.GetHashCode()
 ^ ssMaxDate.GetHashCode()
 ^ ssShowWeekNumbers.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_256310aee13520906f2ba115af101f62Structure Duplicate() {
ST_256310aee13520906f2ba115af101f62Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssDateFormat = this.ssDateFormat;
t.ssInitialStartDate = this.ssInitialStartDate;
t.ssInitialEndDate = this.ssInitialEndDate;
t.ssShowTodayButton = this.ssShowTodayButton;
t.ssFirstWeekDay = this.ssFirstWeekDay;
t.ssMinDate = this.ssMinDate;
t.ssMaxDate = this.ssMaxDate;
t.ssShowWeekNumbers = this.ssShowWeekNumbers;
t.ssExtendedClass = this.ssExtendedClass;
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
if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
} else if (head == "dateformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateFormat")) variable.Value = ssDateFormat; else variable.Optimized = true;
} else if (head == "initialstartdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialStartDate")) variable.Value = ssInitialStartDate; else variable.Optimized = true;
} else if (head == "initialenddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialEndDate")) variable.Value = ssInitialEndDate; else variable.Optimized = true;
} else if (head == "showtodaybutton") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowTodayButton")) variable.Value = ssShowTodayButton; else variable.Optimized = true;
} else if (head == "firstweekday") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstWeekDay")) variable.Value = ssFirstWeekDay; else variable.Optimized = true;
} else if (head == "mindate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinDate")) variable.Value = ssMinDate; else variable.Optimized = true;
} else if (head == "maxdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxDate")) variable.Value = ssMaxDate; else variable.Optimized = true;
} else if (head == "showweeknumbers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowWeekNumbers")) variable.Value = ssShowWeekNumbers; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
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
if (key == IdUniqueId) {
return ssUniqueId;
}
if (key == IdDateFormat) {
return ssDateFormat;
}
if (key == IdInitialStartDate) {
return ssInitialStartDate;
}
if (key == IdInitialEndDate) {
return ssInitialEndDate;
}
if (key == IdShowTodayButton) {
return ssShowTodayButton;
}
if (key == IdFirstWeekDay) {
return ssFirstWeekDay;
}
if (key == IdMinDate) {
return ssMinDate;
}
if (key == IdMaxDate) {
return ssMaxDate;
}
if (key == IdShowWeekNumbers) {
return ssShowWeekNumbers;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdDateFormat.Key.AsGuid) {
return ssDateFormat;
}
if (attributeKey == IdInitialStartDate.Key.AsGuid) {
return ssInitialStartDate;
}
if (attributeKey == IdInitialEndDate.Key.AsGuid) {
return ssInitialEndDate;
}
if (attributeKey == IdShowTodayButton.Key.AsGuid) {
return ssShowTodayButton;
}
if (attributeKey == IdFirstWeekDay.Key.AsGuid) {
return ssFirstWeekDay;
}
if (attributeKey == IdMinDate.Key.AsGuid) {
return ssMinDate;
}
if (attributeKey == IdMaxDate.Key.AsGuid) {
return ssMaxDate;
}
if (attributeKey == IdShowWeekNumbers.Key.AsGuid) {
return ssShowWeekNumbers;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssDateFormat = (string) other.AttributeGet(IdDateFormat);
ssInitialStartDate = (DateTime) other.AttributeGet(IdInitialStartDate);
ssInitialEndDate = (DateTime) other.AttributeGet(IdInitialEndDate);
ssShowTodayButton = (bool) other.AttributeGet(IdShowTodayButton);
ssFirstWeekDay = (int) other.AttributeGet(IdFirstWeekDay);
ssMinDate = (DateTime) other.AttributeGet(IdMinDate);
ssMaxDate = (DateTime) other.AttributeGet(IdMaxDate);
ssShowWeekNumbers = (bool) other.AttributeGet(IdShowWeekNumbers);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_256310aee13520906f2ba115af101f62Structure
/// <summary>
/// RecordList type <code>DatePickerRange_InternalConfigList</code> that represents a record list of
///  <code>DatePickerRange_InternalConfig</code>
/// </summary>
public partial class RL_8434dd7ea7e3ca102ba9242db03d7a59 : GenericRecordList<ST_256310aee13520906f2ba115af101f62Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_256310aee13520906f2ba115af101f62Structure GetElementDefaultValue() {
return new ST_256310aee13520906f2ba115af101f62Structure();
}

public T[] ToArray<T>(Func<ST_256310aee13520906f2ba115af101f62Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8434dd7ea7e3ca102ba9242db03d7a59 recordList, Func<ST_256310aee13520906f2ba115af101f62Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8434dd7ea7e3ca102ba9242db03d7a59(ST_256310aee13520906f2ba115af101f62Structure[] array) {
  RL_8434dd7ea7e3ca102ba9242db03d7a59 result = new RL_8434dd7ea7e3ca102ba9242db03d7a59();
result.InnerFromArray(array);
    return result;
}

public static RL_8434dd7ea7e3ca102ba9242db03d7a59 ToList<T>(T[] array, Func <T, ST_256310aee13520906f2ba115af101f62Structure> converter) {
  RL_8434dd7ea7e3ca102ba9242db03d7a59 result = new RL_8434dd7ea7e3ca102ba9242db03d7a59();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8434dd7ea7e3ca102ba9242db03d7a59 FromRestList<T>(RestList<T> restList, Func <T, ST_256310aee13520906f2ba115af101f62Structure> converter) {
  RL_8434dd7ea7e3ca102ba9242db03d7a59 result = new RL_8434dd7ea7e3ca102ba9242db03d7a59();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8434dd7ea7e3ca102ba9242db03d7a59() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_256310aee13520906f2ba115af101f62Structure> NewList() {
return new RL_8434dd7ea7e3ca102ba9242db03d7a59();
}


} // RL_8434dd7ea7e3ca102ba9242db03d7a59
}

