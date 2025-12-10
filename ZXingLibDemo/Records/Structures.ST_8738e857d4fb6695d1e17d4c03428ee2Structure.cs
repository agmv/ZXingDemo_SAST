namespace ssZXingLibDemo {
/// <summary>
/// [ReferenceStructure] CalendarEvent (1Kf8lWg8OkSfjXv6x72B6A)
///  <code>ST_8738e857d4fb6695d1e17d4c03428ee2Structure</code> that represent
/// s <code>CalendarEvent</code> <p>Description: Defines a calendar event to be shared as a QR code</p>
/// </summary>
// Name: CalendarEvent
public partial struct ST_8738e857d4fb6695d1e17d4c03428ee2Structure : ITypedRecord<ST_8738e857d4fb6695d1e17d4c03428ee2Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey Idtitle = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*FPM7o6CB8fbp1GDvEGZbrg");
internal static readonly GlobalObjectKey IdisAllDay = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*MxmG3idI0LwLC_+jaiUKmA");
internal static readonly GlobalObjectKey IdstartDateTime = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*fRhTP08EIJtOIlx5sqfenQ");
internal static readonly GlobalObjectKey IdendDateTime = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*Ygq2u+KmxknGAwy+eBugMw");
internal static readonly GlobalObjectKey Idlocation = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*jkFDj0oGhhjJNTat0FtsYg");
internal static readonly GlobalObjectKey Iddescription = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*ad19xTS8LzAhRLF+gx5hcg");
internal static readonly GlobalObjectKey IdeventClass = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*1QNiypAwMkPLkhEOExUD3A");
internal static readonly GlobalObjectKey Idorganizer = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*638XSTWhAwOIDrVuAj7UXQ");
internal static readonly GlobalObjectKey Idpriority = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*dgtrxF+9rhM6qUe_5ik+_Q");
internal static readonly GlobalObjectKey IdshowAsBusy = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*L_nOJLkmrQkZmIfiljju_A");

public static void EnsureInitialized(){}

static ST_8738e857d4fb6695d1e17d4c03428ee2Structure() {
ST_8738e857d4fb6695d1e17d4c03428ee2StructureTypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("title")]
public string sstitle;

[System.Xml.Serialization.XmlElement("isAllDay")]
public bool ssisAllDay;

[System.Xml.Serialization.XmlElement("startDateTime")]
public DateTime ssstartDateTime;

[System.Xml.Serialization.XmlElement("endDateTime")]
public DateTime ssendDateTime;

[System.Xml.Serialization.XmlElement("location")]
public string sslocation;

[System.Xml.Serialization.XmlElement("description")]
public string ssdescription;

[System.Xml.Serialization.XmlElement("eventClass")]
public string sseventClass;

[System.Xml.Serialization.XmlElement("organizer")]
public string ssorganizer;

[System.Xml.Serialization.XmlElement("priority")]
public int sspriority;

[System.Xml.Serialization.XmlElement("showAsBusy")]
public bool ssshowAsBusy;


public BitArray OptimizedAttributes;

public ST_8738e857d4fb6695d1e17d4c03428ee2Structure() {
OptimizedAttributes = null;
sstitle = "";
ssisAllDay = false;
ssstartDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssendDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
sslocation = "";
ssdescription = "";
sseventClass = "";
ssorganizer = "";
sspriority = 0;
ssshowAsBusy = false;
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
sstitle = r.ReadText(index++, "CalendarEvent.title", "");
ssisAllDay = r.ReadBoolean(index++, "CalendarEvent.isAllDay", false);
ssstartDateTime = r.ReadDateTime(index++, "CalendarEvent.startDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssendDateTime = r.ReadDateTime(index++, "CalendarEvent.endDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
sslocation = r.ReadText(index++, "CalendarEvent.location", "");
ssdescription = r.ReadText(index++, "CalendarEvent.description", "");
sseventClass = r.ReadText(index++, "CalendarEvent.eventClass", "");
ssorganizer = r.ReadText(index++, "CalendarEvent.organizer", "");
sspriority = r.ReadInteger(index++, "CalendarEvent.priority", 0);
ssshowAsBusy = r.ReadBoolean(index++, "CalendarEvent.showAsBusy", false);
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
public void ReadIM(ST_8738e857d4fb6695d1e17d4c03428ee2Structure r) {
this = r;
}


public static bool operator == (ST_8738e857d4fb6695d1e17d4c03428ee2Structure a, ST_8738e857d4fb6695d1e17d4c03428ee2Structure b) {
if (a.sstitle != b.sstitle) return false;
if (a.ssisAllDay != b.ssisAllDay) return false;
if (a.ssstartDateTime != b.ssstartDateTime) return false;
if (a.ssendDateTime != b.ssendDateTime) return false;
if (a.sslocation != b.sslocation) return false;
if (a.ssdescription != b.ssdescription) return false;
if (a.sseventClass != b.sseventClass) return false;
if (a.ssorganizer != b.ssorganizer) return false;
if (a.sspriority != b.sspriority) return false;
if (a.ssshowAsBusy != b.ssshowAsBusy) return false;
return true;
}

public static bool operator != (ST_8738e857d4fb6695d1e17d4c03428ee2Structure a, ST_8738e857d4fb6695d1e17d4c03428ee2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8738e857d4fb6695d1e17d4c03428ee2Structure)) return false;
return (this == (ST_8738e857d4fb6695d1e17d4c03428ee2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sstitle.GetHashCode()
 ^ ssisAllDay.GetHashCode()
 ^ ssstartDateTime.GetHashCode()
 ^ ssendDateTime.GetHashCode()
 ^ sslocation.GetHashCode()
 ^ ssdescription.GetHashCode()
 ^ sseventClass.GetHashCode()
 ^ ssorganizer.GetHashCode()
 ^ sspriority.GetHashCode()
 ^ ssshowAsBusy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8738e857d4fb6695d1e17d4c03428ee2Structure Duplicate() {
ST_8738e857d4fb6695d1e17d4c03428ee2Structure t;
t.sstitle = this.sstitle;
t.ssisAllDay = this.ssisAllDay;
t.ssstartDateTime = this.ssstartDateTime;
t.ssendDateTime = this.ssendDateTime;
t.sslocation = this.sslocation;
t.ssdescription = this.ssdescription;
t.sseventClass = this.sseventClass;
t.ssorganizer = this.ssorganizer;
t.sspriority = this.sspriority;
t.ssshowAsBusy = this.ssshowAsBusy;
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
if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".title")) variable.Value = sstitle; else variable.Optimized = true;
} else if (head == "isallday") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".isAllDay")) variable.Value = ssisAllDay; else variable.Optimized = true;
} else if (head == "startdatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".startDateTime")) variable.Value = ssstartDateTime; else variable.Optimized = true;
} else if (head == "enddatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".endDateTime")) variable.Value = ssendDateTime; else variable.Optimized = true;
} else if (head == "location") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".location")) variable.Value = sslocation; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".description")) variable.Value = ssdescription; else variable.Optimized = true;
} else if (head == "eventclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".eventClass")) variable.Value = sseventClass; else variable.Optimized = true;
} else if (head == "organizer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".organizer")) variable.Value = ssorganizer; else variable.Optimized = true;
} else if (head == "priority") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".priority")) variable.Value = sspriority; else variable.Optimized = true;
} else if (head == "showasbusy") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".showAsBusy")) variable.Value = ssshowAsBusy; else variable.Optimized = true;
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
if (key == Idtitle) {
return sstitle;
}
if (key == IdisAllDay) {
return ssisAllDay;
}
if (key == IdstartDateTime) {
return ssstartDateTime;
}
if (key == IdendDateTime) {
return ssendDateTime;
}
if (key == Idlocation) {
return sslocation;
}
if (key == Iddescription) {
return ssdescription;
}
if (key == IdeventClass) {
return sseventClass;
}
if (key == Idorganizer) {
return ssorganizer;
}
if (key == Idpriority) {
return sspriority;
}
if (key == IdshowAsBusy) {
return ssshowAsBusy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idtitle.Key.AsGuid) {
return sstitle;
}
if (attributeKey == IdisAllDay.Key.AsGuid) {
return ssisAllDay;
}
if (attributeKey == IdstartDateTime.Key.AsGuid) {
return ssstartDateTime;
}
if (attributeKey == IdendDateTime.Key.AsGuid) {
return ssendDateTime;
}
if (attributeKey == Idlocation.Key.AsGuid) {
return sslocation;
}
if (attributeKey == Iddescription.Key.AsGuid) {
return ssdescription;
}
if (attributeKey == IdeventClass.Key.AsGuid) {
return sseventClass;
}
if (attributeKey == Idorganizer.Key.AsGuid) {
return ssorganizer;
}
if (attributeKey == Idpriority.Key.AsGuid) {
return sspriority;
}
if (attributeKey == IdshowAsBusy.Key.AsGuid) {
return ssshowAsBusy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
sstitle = (string) other.AttributeGet(Idtitle);
ssisAllDay = (bool) other.AttributeGet(IdisAllDay);
ssstartDateTime = (DateTime) other.AttributeGet(IdstartDateTime);
ssendDateTime = (DateTime) other.AttributeGet(IdendDateTime);
sslocation = (string) other.AttributeGet(Idlocation);
ssdescription = (string) other.AttributeGet(Iddescription);
sseventClass = (string) other.AttributeGet(IdeventClass);
ssorganizer = (string) other.AttributeGet(Idorganizer);
sspriority = (int) other.AttributeGet(Idpriority);
ssshowAsBusy = (bool) other.AttributeGet(IdshowAsBusy);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
sstitle = (string) other.GetAttribute(Idtitle.Key.AsGuid);
ssisAllDay = (bool) other.GetAttribute(IdisAllDay.Key.AsGuid);
ssstartDateTime = (DateTime) other.GetAttribute(IdstartDateTime.Key.AsGuid);
ssendDateTime = (DateTime) other.GetAttribute(IdendDateTime.Key.AsGuid);
sslocation = (string) other.GetAttribute(Idlocation.Key.AsGuid);
ssdescription = (string) other.GetAttribute(Iddescription.Key.AsGuid);
sseventClass = (string) other.GetAttribute(IdeventClass.Key.AsGuid);
ssorganizer = (string) other.GetAttribute(Idorganizer.Key.AsGuid);
sspriority = (int) other.GetAttribute(Idpriority.Key.AsGuid);
ssshowAsBusy = (bool) other.GetAttribute(IdshowAsBusy.Key.AsGuid);
}
} // ST_8738e857d4fb6695d1e17d4c03428ee2Structure
/// <summary>
/// RecordList type <code>CalendarEventList</code> that represents a record list of
///  <code>CalendarEvent</code>
/// </summary>
public partial class RL_6f7ab57f83d7daa4875f05a1a23f434b : GenericRecordList<ST_8738e857d4fb6695d1e17d4c03428ee2Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_8738e857d4fb6695d1e17d4c03428ee2Structure GetElementDefaultValue() {
return new ST_8738e857d4fb6695d1e17d4c03428ee2Structure();
}

public T[] ToArray<T>(Func<ST_8738e857d4fb6695d1e17d4c03428ee2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6f7ab57f83d7daa4875f05a1a23f434b recordList, Func<ST_8738e857d4fb6695d1e17d4c03428ee2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6f7ab57f83d7daa4875f05a1a23f434b(ST_8738e857d4fb6695d1e17d4c03428ee2Structure[] array) {
  RL_6f7ab57f83d7daa4875f05a1a23f434b result = new RL_6f7ab57f83d7daa4875f05a1a23f434b();
result.InnerFromArray(array);
    return result;
}

public static RL_6f7ab57f83d7daa4875f05a1a23f434b ToList<T>(T[] array, Func <T, ST_8738e857d4fb6695d1e17d4c03428ee2Structure> converter) {
  RL_6f7ab57f83d7daa4875f05a1a23f434b result = new RL_6f7ab57f83d7daa4875f05a1a23f434b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6f7ab57f83d7daa4875f05a1a23f434b FromRestList<T>(RestList<T> restList, Func <T, ST_8738e857d4fb6695d1e17d4c03428ee2Structure> converter) {
  RL_6f7ab57f83d7daa4875f05a1a23f434b result = new RL_6f7ab57f83d7daa4875f05a1a23f434b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6f7ab57f83d7daa4875f05a1a23f434b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8738e857d4fb6695d1e17d4c03428ee2Structure> NewList() {
return new RL_6f7ab57f83d7daa4875f05a1a23f434b();
}


} // RL_6f7ab57f83d7daa4875f05a1a23f434b
}

