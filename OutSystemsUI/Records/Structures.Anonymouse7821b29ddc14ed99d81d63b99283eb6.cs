namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (KRuC58Hd2U6dgdY7mSg+tg)
///  <code>RC_bbab5f70da1d7251909f44ce9efe20fa</code> that represent
/// s
///  <code>WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Re
/// cord</code> <p>Description: </p>
/// </summary>
// Name: WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record
public partial struct RC_bbab5f70da1d7251909f44ce9efe20fa : ITypedRecord<RC_bbab5f70da1d7251909f44ce9efe20fa> {
internal static readonly GlobalObjectKey IdWeekdayShort1 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9VjG1Vx7zpHCk3y3pGBVxA");
internal static readonly GlobalObjectKey IdWeekdayShort2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_13ksPIQwAZg4t8qZBbMxQ");
internal static readonly GlobalObjectKey IdWeekdayShort3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S9Tu4zZ5rBnxLpjQvv7CJQ");
internal static readonly GlobalObjectKey IdWeekdayShort4 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KeziFII2_1YYfhLSblknQg");
internal static readonly GlobalObjectKey IdWeekdayShort5 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UsdgjDfSca_IuYckhuPRcw");
internal static readonly GlobalObjectKey IdWeekdayShort6 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*REaRxyFglscwnyU5_1mYsQ");
internal static readonly GlobalObjectKey IdWeekdayShort7 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*V8daf8V49KRMl6DVfYBZPw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("WeekdayShort1")]
public string ssWeekdayShort1;

[System.Xml.Serialization.XmlElement("WeekdayShort2")]
public string ssWeekdayShort2;

[System.Xml.Serialization.XmlElement("WeekdayShort3")]
public string ssWeekdayShort3;

[System.Xml.Serialization.XmlElement("WeekdayShort4")]
public string ssWeekdayShort4;

[System.Xml.Serialization.XmlElement("WeekdayShort5")]
public string ssWeekdayShort5;

[System.Xml.Serialization.XmlElement("WeekdayShort6")]
public string ssWeekdayShort6;

[System.Xml.Serialization.XmlElement("WeekdayShort7")]
public string ssWeekdayShort7;


public BitArray OptimizedAttributes;

public RC_bbab5f70da1d7251909f44ce9efe20fa() {
OptimizedAttributes = null;
ssWeekdayShort1 = "";
ssWeekdayShort2 = "";
ssWeekdayShort3 = "";
ssWeekdayShort4 = "";
ssWeekdayShort5 = "";
ssWeekdayShort6 = "";
ssWeekdayShort7 = "";
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
ssWeekdayShort1 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort1", "");
ssWeekdayShort2 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort2", "");
ssWeekdayShort3 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort3", "");
ssWeekdayShort4 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort4", "");
ssWeekdayShort5 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort5", "");
ssWeekdayShort6 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort6", "");
ssWeekdayShort7 = r.ReadText(index++, "WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Record.WeekdayShort7", "");
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
public void ReadIM(RC_bbab5f70da1d7251909f44ce9efe20fa r) {
this = r;
}


public static bool operator == (RC_bbab5f70da1d7251909f44ce9efe20fa a, RC_bbab5f70da1d7251909f44ce9efe20fa b) {
if (a.ssWeekdayShort1 != b.ssWeekdayShort1) return false;
if (a.ssWeekdayShort2 != b.ssWeekdayShort2) return false;
if (a.ssWeekdayShort3 != b.ssWeekdayShort3) return false;
if (a.ssWeekdayShort4 != b.ssWeekdayShort4) return false;
if (a.ssWeekdayShort5 != b.ssWeekdayShort5) return false;
if (a.ssWeekdayShort6 != b.ssWeekdayShort6) return false;
if (a.ssWeekdayShort7 != b.ssWeekdayShort7) return false;
return true;
}

public static bool operator != (RC_bbab5f70da1d7251909f44ce9efe20fa a, RC_bbab5f70da1d7251909f44ce9efe20fa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bbab5f70da1d7251909f44ce9efe20fa)) return false;
return (this == (RC_bbab5f70da1d7251909f44ce9efe20fa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssWeekdayShort1.GetHashCode()
 ^ ssWeekdayShort2.GetHashCode()
 ^ ssWeekdayShort3.GetHashCode()
 ^ ssWeekdayShort4.GetHashCode()
 ^ ssWeekdayShort5.GetHashCode()
 ^ ssWeekdayShort6.GetHashCode()
 ^ ssWeekdayShort7.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_bbab5f70da1d7251909f44ce9efe20fa Duplicate() {
RC_bbab5f70da1d7251909f44ce9efe20fa t;
t.ssWeekdayShort1 = this.ssWeekdayShort1;
t.ssWeekdayShort2 = this.ssWeekdayShort2;
t.ssWeekdayShort3 = this.ssWeekdayShort3;
t.ssWeekdayShort4 = this.ssWeekdayShort4;
t.ssWeekdayShort5 = this.ssWeekdayShort5;
t.ssWeekdayShort6 = this.ssWeekdayShort6;
t.ssWeekdayShort7 = this.ssWeekdayShort7;
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
if (head == "weekdayshort1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort1")) variable.Value = ssWeekdayShort1; else variable.Optimized = true;
} else if (head == "weekdayshort2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort2")) variable.Value = ssWeekdayShort2; else variable.Optimized = true;
} else if (head == "weekdayshort3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort3")) variable.Value = ssWeekdayShort3; else variable.Optimized = true;
} else if (head == "weekdayshort4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort4")) variable.Value = ssWeekdayShort4; else variable.Optimized = true;
} else if (head == "weekdayshort5") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort5")) variable.Value = ssWeekdayShort5; else variable.Optimized = true;
} else if (head == "weekdayshort6") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort6")) variable.Value = ssWeekdayShort6; else variable.Optimized = true;
} else if (head == "weekdayshort7") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekdayShort7")) variable.Value = ssWeekdayShort7; else variable.Optimized = true;
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
if (key == IdWeekdayShort1) {
return ssWeekdayShort1;
}
if (key == IdWeekdayShort2) {
return ssWeekdayShort2;
}
if (key == IdWeekdayShort3) {
return ssWeekdayShort3;
}
if (key == IdWeekdayShort4) {
return ssWeekdayShort4;
}
if (key == IdWeekdayShort5) {
return ssWeekdayShort5;
}
if (key == IdWeekdayShort6) {
return ssWeekdayShort6;
}
if (key == IdWeekdayShort7) {
return ssWeekdayShort7;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWeekdayShort1.Key.AsGuid) {
return ssWeekdayShort1;
}
if (attributeKey == IdWeekdayShort2.Key.AsGuid) {
return ssWeekdayShort2;
}
if (attributeKey == IdWeekdayShort3.Key.AsGuid) {
return ssWeekdayShort3;
}
if (attributeKey == IdWeekdayShort4.Key.AsGuid) {
return ssWeekdayShort4;
}
if (attributeKey == IdWeekdayShort5.Key.AsGuid) {
return ssWeekdayShort5;
}
if (attributeKey == IdWeekdayShort6.Key.AsGuid) {
return ssWeekdayShort6;
}
if (attributeKey == IdWeekdayShort7.Key.AsGuid) {
return ssWeekdayShort7;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssWeekdayShort1 = (string) other.AttributeGet(IdWeekdayShort1);
ssWeekdayShort2 = (string) other.AttributeGet(IdWeekdayShort2);
ssWeekdayShort3 = (string) other.AttributeGet(IdWeekdayShort3);
ssWeekdayShort4 = (string) other.AttributeGet(IdWeekdayShort4);
ssWeekdayShort5 = (string) other.AttributeGet(IdWeekdayShort5);
ssWeekdayShort6 = (string) other.AttributeGet(IdWeekdayShort6);
ssWeekdayShort7 = (string) other.AttributeGet(IdWeekdayShort7);
}
} // RC_bbab5f70da1d7251909f44ce9efe20fa
/// <summary>
/// RecordList type
///  <code>WeekdayShort1WeekdayShort2WeekdayShort3WeekdayShort4WeekdayShort5WeekdayShort6WeekdayShort7Re
/// cordList</code> that represents a record list of <code>Text, Text, Text, Text, Text, Text,
///  Text</code>
/// </summary>
public partial class RL_4260c6c2a6b32d80f4d763c795bd8980 : GenericRecordList<RC_bbab5f70da1d7251909f44ce9efe20fa>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_bbab5f70da1d7251909f44ce9efe20fa GetElementDefaultValue() {
return new RC_bbab5f70da1d7251909f44ce9efe20fa();
}

public T[] ToArray<T>(Func<RC_bbab5f70da1d7251909f44ce9efe20fa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4260c6c2a6b32d80f4d763c795bd8980 recordList, Func<RC_bbab5f70da1d7251909f44ce9efe20fa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4260c6c2a6b32d80f4d763c795bd8980(RC_bbab5f70da1d7251909f44ce9efe20fa[] array) {
  RL_4260c6c2a6b32d80f4d763c795bd8980 result = new RL_4260c6c2a6b32d80f4d763c795bd8980();
result.InnerFromArray(array);
    return result;
}

public static RL_4260c6c2a6b32d80f4d763c795bd8980 ToList<T>(T[] array, Func <T, RC_bbab5f70da1d7251909f44ce9efe20fa> converter) {
  RL_4260c6c2a6b32d80f4d763c795bd8980 result = new RL_4260c6c2a6b32d80f4d763c795bd8980();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4260c6c2a6b32d80f4d763c795bd8980 FromRestList<T>(RestList<T> restList, Func <T, RC_bbab5f70da1d7251909f44ce9efe20fa> converter) {
  RL_4260c6c2a6b32d80f4d763c795bd8980 result = new RL_4260c6c2a6b32d80f4d763c795bd8980();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4260c6c2a6b32d80f4d763c795bd8980() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bbab5f70da1d7251909f44ce9efe20fa> NewList() {
return new RL_4260c6c2a6b32d80f4d763c795bd8980();
}


} // RL_4260c6c2a6b32d80f4d763c795bd8980
}

