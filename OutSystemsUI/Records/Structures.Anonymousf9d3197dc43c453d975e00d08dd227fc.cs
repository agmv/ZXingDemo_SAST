namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (fRnT+TzEPUWXXgDQjdIn_A)
///  <code>RC_d3d7d244571ed038dbfee008e77e8c11</code> that represent
/// s <code>Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record</code> <p>Description: </p>
/// </summary>
// Name: Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record
public partial struct RC_d3d7d244571ed038dbfee008e77e8c11 : ITypedRecord<RC_d3d7d244571ed038dbfee008e77e8c11> {
internal static readonly GlobalObjectKey IdWeekday1 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*I9jCEkYucF28nGEdSK94Bg");
internal static readonly GlobalObjectKey IdWeekday2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SZgBqBKq7dP3K+uyPtNTnw");
internal static readonly GlobalObjectKey IdWeekday3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0gdBlKC1UhudTxxrHjP4QQ");
internal static readonly GlobalObjectKey IdWeekday4 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XDi8bgAw0JGkAvDxTaP1zg");
internal static readonly GlobalObjectKey IdWeekday5 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kWrlarsiDnoEAzXMBMLiVQ");
internal static readonly GlobalObjectKey IdWeekday6 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C5_uqVfpQCE5KrZ6lk58WA");
internal static readonly GlobalObjectKey IdWeekday7 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D52XJq36Em7CabiiBFnmxw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Weekday1")]
public string ssWeekday1;

[System.Xml.Serialization.XmlElement("Weekday2")]
public string ssWeekday2;

[System.Xml.Serialization.XmlElement("Weekday3")]
public string ssWeekday3;

[System.Xml.Serialization.XmlElement("Weekday4")]
public string ssWeekday4;

[System.Xml.Serialization.XmlElement("Weekday5")]
public string ssWeekday5;

[System.Xml.Serialization.XmlElement("Weekday6")]
public string ssWeekday6;

[System.Xml.Serialization.XmlElement("Weekday7")]
public string ssWeekday7;


public BitArray OptimizedAttributes;

public RC_d3d7d244571ed038dbfee008e77e8c11() {
OptimizedAttributes = null;
ssWeekday1 = "";
ssWeekday2 = "";
ssWeekday3 = "";
ssWeekday4 = "";
ssWeekday5 = "";
ssWeekday6 = "";
ssWeekday7 = "";
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
ssWeekday1 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday1", "");
ssWeekday2 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday2", "");
ssWeekday3 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday3", "");
ssWeekday4 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday4", "");
ssWeekday5 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday5", "");
ssWeekday6 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday6", "");
ssWeekday7 = r.ReadText(index++, "Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7Record.Weekday7", "");
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
public void ReadIM(RC_d3d7d244571ed038dbfee008e77e8c11 r) {
this = r;
}


public static bool operator == (RC_d3d7d244571ed038dbfee008e77e8c11 a, RC_d3d7d244571ed038dbfee008e77e8c11 b) {
if (a.ssWeekday1 != b.ssWeekday1) return false;
if (a.ssWeekday2 != b.ssWeekday2) return false;
if (a.ssWeekday3 != b.ssWeekday3) return false;
if (a.ssWeekday4 != b.ssWeekday4) return false;
if (a.ssWeekday5 != b.ssWeekday5) return false;
if (a.ssWeekday6 != b.ssWeekday6) return false;
if (a.ssWeekday7 != b.ssWeekday7) return false;
return true;
}

public static bool operator != (RC_d3d7d244571ed038dbfee008e77e8c11 a, RC_d3d7d244571ed038dbfee008e77e8c11 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d3d7d244571ed038dbfee008e77e8c11)) return false;
return (this == (RC_d3d7d244571ed038dbfee008e77e8c11)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssWeekday1.GetHashCode()
 ^ ssWeekday2.GetHashCode()
 ^ ssWeekday3.GetHashCode()
 ^ ssWeekday4.GetHashCode()
 ^ ssWeekday5.GetHashCode()
 ^ ssWeekday6.GetHashCode()
 ^ ssWeekday7.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d3d7d244571ed038dbfee008e77e8c11 Duplicate() {
RC_d3d7d244571ed038dbfee008e77e8c11 t;
t.ssWeekday1 = this.ssWeekday1;
t.ssWeekday2 = this.ssWeekday2;
t.ssWeekday3 = this.ssWeekday3;
t.ssWeekday4 = this.ssWeekday4;
t.ssWeekday5 = this.ssWeekday5;
t.ssWeekday6 = this.ssWeekday6;
t.ssWeekday7 = this.ssWeekday7;
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
if (head == "weekday1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday1")) variable.Value = ssWeekday1; else variable.Optimized = true;
} else if (head == "weekday2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday2")) variable.Value = ssWeekday2; else variable.Optimized = true;
} else if (head == "weekday3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday3")) variable.Value = ssWeekday3; else variable.Optimized = true;
} else if (head == "weekday4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday4")) variable.Value = ssWeekday4; else variable.Optimized = true;
} else if (head == "weekday5") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday5")) variable.Value = ssWeekday5; else variable.Optimized = true;
} else if (head == "weekday6") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday6")) variable.Value = ssWeekday6; else variable.Optimized = true;
} else if (head == "weekday7") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Weekday7")) variable.Value = ssWeekday7; else variable.Optimized = true;
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
if (key == IdWeekday1) {
return ssWeekday1;
}
if (key == IdWeekday2) {
return ssWeekday2;
}
if (key == IdWeekday3) {
return ssWeekday3;
}
if (key == IdWeekday4) {
return ssWeekday4;
}
if (key == IdWeekday5) {
return ssWeekday5;
}
if (key == IdWeekday6) {
return ssWeekday6;
}
if (key == IdWeekday7) {
return ssWeekday7;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWeekday1.Key.AsGuid) {
return ssWeekday1;
}
if (attributeKey == IdWeekday2.Key.AsGuid) {
return ssWeekday2;
}
if (attributeKey == IdWeekday3.Key.AsGuid) {
return ssWeekday3;
}
if (attributeKey == IdWeekday4.Key.AsGuid) {
return ssWeekday4;
}
if (attributeKey == IdWeekday5.Key.AsGuid) {
return ssWeekday5;
}
if (attributeKey == IdWeekday6.Key.AsGuid) {
return ssWeekday6;
}
if (attributeKey == IdWeekday7.Key.AsGuid) {
return ssWeekday7;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssWeekday1 = (string) other.AttributeGet(IdWeekday1);
ssWeekday2 = (string) other.AttributeGet(IdWeekday2);
ssWeekday3 = (string) other.AttributeGet(IdWeekday3);
ssWeekday4 = (string) other.AttributeGet(IdWeekday4);
ssWeekday5 = (string) other.AttributeGet(IdWeekday5);
ssWeekday6 = (string) other.AttributeGet(IdWeekday6);
ssWeekday7 = (string) other.AttributeGet(IdWeekday7);
}
} // RC_d3d7d244571ed038dbfee008e77e8c11
/// <summary>
/// RecordList type <code>Weekday1Weekday2Weekday3Weekday4Weekday5Weekday6Weekday7RecordList</code>
///  that represents a record list of <code>Text, Text, Text, Text, Text, Text, Text</code>
/// </summary>
public partial class RL_1729600b673fd0870291732dd16f0147 : GenericRecordList<RC_d3d7d244571ed038dbfee008e77e8c11>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d3d7d244571ed038dbfee008e77e8c11 GetElementDefaultValue() {
return new RC_d3d7d244571ed038dbfee008e77e8c11();
}

public T[] ToArray<T>(Func<RC_d3d7d244571ed038dbfee008e77e8c11, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1729600b673fd0870291732dd16f0147 recordList, Func<RC_d3d7d244571ed038dbfee008e77e8c11, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1729600b673fd0870291732dd16f0147(RC_d3d7d244571ed038dbfee008e77e8c11[] array) {
  RL_1729600b673fd0870291732dd16f0147 result = new RL_1729600b673fd0870291732dd16f0147();
result.InnerFromArray(array);
    return result;
}

public static RL_1729600b673fd0870291732dd16f0147 ToList<T>(T[] array, Func <T, RC_d3d7d244571ed038dbfee008e77e8c11> converter) {
  RL_1729600b673fd0870291732dd16f0147 result = new RL_1729600b673fd0870291732dd16f0147();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1729600b673fd0870291732dd16f0147 FromRestList<T>(RestList<T> restList, Func <T, RC_d3d7d244571ed038dbfee008e77e8c11> converter) {
  RL_1729600b673fd0870291732dd16f0147 result = new RL_1729600b673fd0870291732dd16f0147();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1729600b673fd0870291732dd16f0147() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d3d7d244571ed038dbfee008e77e8c11> NewList() {
return new RL_1729600b673fd0870291732dd16f0147();
}


} // RL_1729600b673fd0870291732dd16f0147
}

