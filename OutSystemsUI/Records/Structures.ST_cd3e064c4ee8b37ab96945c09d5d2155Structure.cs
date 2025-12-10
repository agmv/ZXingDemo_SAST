namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DatePicker_InternalConfig (qcXxoqw0yUK6iTecf65ciQ)
///  <code>ST_cd3e064c4ee8b37ab96945c09d5d2155Structure</code> that represent
/// s <code>DatePicker_InternalConfig</code> <p>Description: Group of internal configurations for the
///  DatePicker block. </p>
/// </summary>
// Name: DatePicker_InternalConfig
public partial struct ST_cd3e064c4ee8b37ab96945c09d5d2155Structure : ITypedRecord<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*IZxo9PS030qFNloNt3w9Ig");
internal static readonly GlobalObjectKey IdDateFormat = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5mQvvxu0R0WNMsP_Xiw8Ew");
internal static readonly GlobalObjectKey IdInitialDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*AM2+cdkH_UG+1VZqfg0vFw");
internal static readonly GlobalObjectKey IdTimeFormat = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*k6leKjIl5EiRekZiOxuKEw");
internal static readonly GlobalObjectKey IdShowTodayButton = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ssT6jTgsSEuwQv+8VlWTmw");
internal static readonly GlobalObjectKey IdFirstWeekDay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*LU3JW0OAykyttQKpNncrug");
internal static readonly GlobalObjectKey IdMinDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*FmrEpJ92k0KWCmFhnFG_MQ");
internal static readonly GlobalObjectKey IdMaxDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*XrF_uOeNjUOrnu9M7m_qxQ");
internal static readonly GlobalObjectKey IdShowWeekNumbers = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*P+VrO4Yqo0S7vVUgfqBPNA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*RYcg0I80QEGj3m8JD1QHig");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("DateFormat")]
public string ssDateFormat;

[System.Xml.Serialization.XmlElement("InitialDate")]
public DateTime ssInitialDate;

[System.Xml.Serialization.XmlElement("TimeFormat")]
public string ssTimeFormat;

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

public ST_cd3e064c4ee8b37ab96945c09d5d2155Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssDateFormat = "";
ssInitialDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssTimeFormat = (ENDatePickerTimeFormatEntity.GetRecordByKey(ObjectKey.Parse("FTwhSItTIkKj6tE25gilfQ"))).ssTimeformat;
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
ssUniqueId = r.ReadText(index++, "DatePicker_InternalConfig.UniqueId", "");
ssDateFormat = r.ReadText(index++, "DatePicker_InternalConfig.DateFormat", "");
ssInitialDate = r.ReadDateTime(index++, "DatePicker_InternalConfig.InitialDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssTimeFormat = r.ReadEntityReferenceText(index++, "DatePicker_InternalConfig.TimeFormat", "");
ssShowTodayButton = r.ReadBoolean(index++, "DatePicker_InternalConfig.ShowTodayButton", false);
ssFirstWeekDay = r.ReadEntityReference(index++, "DatePicker_InternalConfig.FirstWeekDay", 0);
ssMinDate = r.ReadDateTime(index++, "DatePicker_InternalConfig.MinDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxDate = r.ReadDateTime(index++, "DatePicker_InternalConfig.MaxDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssShowWeekNumbers = r.ReadBoolean(index++, "DatePicker_InternalConfig.ShowWeekNumbers", false);
ssExtendedClass = r.ReadText(index++, "DatePicker_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_cd3e064c4ee8b37ab96945c09d5d2155Structure r) {
this = r;
}


public static bool operator == (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure a, ST_cd3e064c4ee8b37ab96945c09d5d2155Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssDateFormat != b.ssDateFormat) return false;
if (a.ssInitialDate != b.ssInitialDate) return false;
if (a.ssTimeFormat != b.ssTimeFormat) return false;
if (a.ssShowTodayButton != b.ssShowTodayButton) return false;
if (a.ssFirstWeekDay != b.ssFirstWeekDay) return false;
if (a.ssMinDate != b.ssMinDate) return false;
if (a.ssMaxDate != b.ssMaxDate) return false;
if (a.ssShowWeekNumbers != b.ssShowWeekNumbers) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure a, ST_cd3e064c4ee8b37ab96945c09d5d2155Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure)) return false;
return (this == (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssDateFormat.GetHashCode()
 ^ ssInitialDate.GetHashCode()
 ^ ssTimeFormat.GetHashCode()
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


public ST_cd3e064c4ee8b37ab96945c09d5d2155Structure Duplicate() {
ST_cd3e064c4ee8b37ab96945c09d5d2155Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssDateFormat = this.ssDateFormat;
t.ssInitialDate = this.ssInitialDate;
t.ssTimeFormat = this.ssTimeFormat;
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
} else if (head == "initialdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialDate")) variable.Value = ssInitialDate; else variable.Optimized = true;
} else if (head == "timeformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeFormat")) variable.Value = ssTimeFormat; else variable.Optimized = true;
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
if (key == IdInitialDate) {
return ssInitialDate;
}
if (key == IdTimeFormat) {
return ssTimeFormat;
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
if (attributeKey == IdInitialDate.Key.AsGuid) {
return ssInitialDate;
}
if (attributeKey == IdTimeFormat.Key.AsGuid) {
return ssTimeFormat;
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
ssInitialDate = (DateTime) other.AttributeGet(IdInitialDate);
ssTimeFormat = (string) other.AttributeGet(IdTimeFormat);
ssShowTodayButton = (bool) other.AttributeGet(IdShowTodayButton);
ssFirstWeekDay = (int) other.AttributeGet(IdFirstWeekDay);
ssMinDate = (DateTime) other.AttributeGet(IdMinDate);
ssMaxDate = (DateTime) other.AttributeGet(IdMaxDate);
ssShowWeekNumbers = (bool) other.AttributeGet(IdShowWeekNumbers);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_cd3e064c4ee8b37ab96945c09d5d2155Structure
/// <summary>
/// RecordList type <code>DatePicker_InternalConfigList</code> that represents a record list of
///  <code>DatePicker_InternalConfig</code>
/// </summary>
public partial class RL_5a2f2aff27f92e4dd93b1f922d1a7262 : GenericRecordList<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_cd3e064c4ee8b37ab96945c09d5d2155Structure GetElementDefaultValue() {
return new ST_cd3e064c4ee8b37ab96945c09d5d2155Structure();
}

public T[] ToArray<T>(Func<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a2f2aff27f92e4dd93b1f922d1a7262 recordList, Func<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a2f2aff27f92e4dd93b1f922d1a7262(ST_cd3e064c4ee8b37ab96945c09d5d2155Structure[] array) {
  RL_5a2f2aff27f92e4dd93b1f922d1a7262 result = new RL_5a2f2aff27f92e4dd93b1f922d1a7262();
result.InnerFromArray(array);
    return result;
}

public static RL_5a2f2aff27f92e4dd93b1f922d1a7262 ToList<T>(T[] array, Func <T, ST_cd3e064c4ee8b37ab96945c09d5d2155Structure> converter) {
  RL_5a2f2aff27f92e4dd93b1f922d1a7262 result = new RL_5a2f2aff27f92e4dd93b1f922d1a7262();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a2f2aff27f92e4dd93b1f922d1a7262 FromRestList<T>(RestList<T> restList, Func <T, ST_cd3e064c4ee8b37ab96945c09d5d2155Structure> converter) {
  RL_5a2f2aff27f92e4dd93b1f922d1a7262 result = new RL_5a2f2aff27f92e4dd93b1f922d1a7262();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a2f2aff27f92e4dd93b1f922d1a7262() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_cd3e064c4ee8b37ab96945c09d5d2155Structure> NewList() {
return new RL_5a2f2aff27f92e4dd93b1f922d1a7262();
}


} // RL_5a2f2aff27f92e4dd93b1f922d1a7262
}

