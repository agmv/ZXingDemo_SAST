namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (MlYu1Nue6USoE2FB77IZtg)
///  <code>RC_35ce9df1ad7a89533b2e8a49a8413520</code> that represent
/// s <code>Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record</code>
///  <p>Description: </p>
/// </summary>
// Name: Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record
public partial struct RC_35ce9df1ad7a89533b2e8a49a8413520 : ITypedRecord<RC_35ce9df1ad7a89533b2e8a49a8413520> {
internal static readonly GlobalObjectKey IdMonth1 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*We_dYPWngvnwBev0AYsl1g");
internal static readonly GlobalObjectKey IdMonth10 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iQyXr6rZOv9YqyOhVtVj4w");
internal static readonly GlobalObjectKey IdMonth11 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*h2ply_vkBymIKCVNMQuKbw");
internal static readonly GlobalObjectKey IdMonth12 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ciyCnaSS60eTjKR9io2buQ");
internal static readonly GlobalObjectKey IdMonth2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rhELD_P7j64ReFrgoeYGqg");
internal static readonly GlobalObjectKey IdMonth3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Qb0yKaMzNDSkmd2_Rrw22w");
internal static readonly GlobalObjectKey IdMonth4 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NT6SlCpbzwVRlQnnvrJKrA");
internal static readonly GlobalObjectKey IdMonth5 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fovKaq68IPLxLk61fbI9dA");
internal static readonly GlobalObjectKey IdMonth6 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*r8eDdd0tehAQti2IcvLa3w");
internal static readonly GlobalObjectKey IdMonth7 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*990ksMqyRneo81VmyGXUKg");
internal static readonly GlobalObjectKey IdMonth8 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*g_icP2yDIGHJ1gch6pUf2g");
internal static readonly GlobalObjectKey IdMonth9 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AjxbsA1EzaAj6orCRuuAVg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Month1")]
public string ssMonth1;

[System.Xml.Serialization.XmlElement("Month10")]
public string ssMonth10;

[System.Xml.Serialization.XmlElement("Month11")]
public string ssMonth11;

[System.Xml.Serialization.XmlElement("Month12")]
public string ssMonth12;

[System.Xml.Serialization.XmlElement("Month2")]
public string ssMonth2;

[System.Xml.Serialization.XmlElement("Month3")]
public string ssMonth3;

[System.Xml.Serialization.XmlElement("Month4")]
public string ssMonth4;

[System.Xml.Serialization.XmlElement("Month5")]
public string ssMonth5;

[System.Xml.Serialization.XmlElement("Month6")]
public string ssMonth6;

[System.Xml.Serialization.XmlElement("Month7")]
public string ssMonth7;

[System.Xml.Serialization.XmlElement("Month8")]
public string ssMonth8;

[System.Xml.Serialization.XmlElement("Month9")]
public string ssMonth9;


public BitArray OptimizedAttributes;

public RC_35ce9df1ad7a89533b2e8a49a8413520() {
OptimizedAttributes = null;
ssMonth1 = "";
ssMonth10 = "";
ssMonth11 = "";
ssMonth12 = "";
ssMonth2 = "";
ssMonth3 = "";
ssMonth4 = "";
ssMonth5 = "";
ssMonth6 = "";
ssMonth7 = "";
ssMonth8 = "";
ssMonth9 = "";
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
ssMonth1 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month1", "");
ssMonth10 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month10", "");
ssMonth11 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month11", "");
ssMonth12 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month12", "");
ssMonth2 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month2", "");
ssMonth3 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month3", "");
ssMonth4 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month4", "");
ssMonth5 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month5", "");
ssMonth6 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month6", "");
ssMonth7 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month7", "");
ssMonth8 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month8", "");
ssMonth9 = r.ReadText(index++, "Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9Record.Month9", "");
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
public void ReadIM(RC_35ce9df1ad7a89533b2e8a49a8413520 r) {
this = r;
}


public static bool operator == (RC_35ce9df1ad7a89533b2e8a49a8413520 a, RC_35ce9df1ad7a89533b2e8a49a8413520 b) {
if (a.ssMonth1 != b.ssMonth1) return false;
if (a.ssMonth10 != b.ssMonth10) return false;
if (a.ssMonth11 != b.ssMonth11) return false;
if (a.ssMonth12 != b.ssMonth12) return false;
if (a.ssMonth2 != b.ssMonth2) return false;
if (a.ssMonth3 != b.ssMonth3) return false;
if (a.ssMonth4 != b.ssMonth4) return false;
if (a.ssMonth5 != b.ssMonth5) return false;
if (a.ssMonth6 != b.ssMonth6) return false;
if (a.ssMonth7 != b.ssMonth7) return false;
if (a.ssMonth8 != b.ssMonth8) return false;
if (a.ssMonth9 != b.ssMonth9) return false;
return true;
}

public static bool operator != (RC_35ce9df1ad7a89533b2e8a49a8413520 a, RC_35ce9df1ad7a89533b2e8a49a8413520 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_35ce9df1ad7a89533b2e8a49a8413520)) return false;
return (this == (RC_35ce9df1ad7a89533b2e8a49a8413520)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMonth1.GetHashCode()
 ^ ssMonth10.GetHashCode()
 ^ ssMonth11.GetHashCode()
 ^ ssMonth12.GetHashCode()
 ^ ssMonth2.GetHashCode()
 ^ ssMonth3.GetHashCode()
 ^ ssMonth4.GetHashCode()
 ^ ssMonth5.GetHashCode()
 ^ ssMonth6.GetHashCode()
 ^ ssMonth7.GetHashCode()
 ^ ssMonth8.GetHashCode()
 ^ ssMonth9.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_35ce9df1ad7a89533b2e8a49a8413520 Duplicate() {
RC_35ce9df1ad7a89533b2e8a49a8413520 t;
t.ssMonth1 = this.ssMonth1;
t.ssMonth10 = this.ssMonth10;
t.ssMonth11 = this.ssMonth11;
t.ssMonth12 = this.ssMonth12;
t.ssMonth2 = this.ssMonth2;
t.ssMonth3 = this.ssMonth3;
t.ssMonth4 = this.ssMonth4;
t.ssMonth5 = this.ssMonth5;
t.ssMonth6 = this.ssMonth6;
t.ssMonth7 = this.ssMonth7;
t.ssMonth8 = this.ssMonth8;
t.ssMonth9 = this.ssMonth9;
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
if (head == "month1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month1")) variable.Value = ssMonth1; else variable.Optimized = true;
} else if (head == "month10") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month10")) variable.Value = ssMonth10; else variable.Optimized = true;
} else if (head == "month11") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month11")) variable.Value = ssMonth11; else variable.Optimized = true;
} else if (head == "month12") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month12")) variable.Value = ssMonth12; else variable.Optimized = true;
} else if (head == "month2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month2")) variable.Value = ssMonth2; else variable.Optimized = true;
} else if (head == "month3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month3")) variable.Value = ssMonth3; else variable.Optimized = true;
} else if (head == "month4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month4")) variable.Value = ssMonth4; else variable.Optimized = true;
} else if (head == "month5") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month5")) variable.Value = ssMonth5; else variable.Optimized = true;
} else if (head == "month6") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month6")) variable.Value = ssMonth6; else variable.Optimized = true;
} else if (head == "month7") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month7")) variable.Value = ssMonth7; else variable.Optimized = true;
} else if (head == "month8") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month8")) variable.Value = ssMonth8; else variable.Optimized = true;
} else if (head == "month9") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month9")) variable.Value = ssMonth9; else variable.Optimized = true;
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
if (key == IdMonth1) {
return ssMonth1;
}
if (key == IdMonth10) {
return ssMonth10;
}
if (key == IdMonth11) {
return ssMonth11;
}
if (key == IdMonth12) {
return ssMonth12;
}
if (key == IdMonth2) {
return ssMonth2;
}
if (key == IdMonth3) {
return ssMonth3;
}
if (key == IdMonth4) {
return ssMonth4;
}
if (key == IdMonth5) {
return ssMonth5;
}
if (key == IdMonth6) {
return ssMonth6;
}
if (key == IdMonth7) {
return ssMonth7;
}
if (key == IdMonth8) {
return ssMonth8;
}
if (key == IdMonth9) {
return ssMonth9;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonth1.Key.AsGuid) {
return ssMonth1;
}
if (attributeKey == IdMonth10.Key.AsGuid) {
return ssMonth10;
}
if (attributeKey == IdMonth11.Key.AsGuid) {
return ssMonth11;
}
if (attributeKey == IdMonth12.Key.AsGuid) {
return ssMonth12;
}
if (attributeKey == IdMonth2.Key.AsGuid) {
return ssMonth2;
}
if (attributeKey == IdMonth3.Key.AsGuid) {
return ssMonth3;
}
if (attributeKey == IdMonth4.Key.AsGuid) {
return ssMonth4;
}
if (attributeKey == IdMonth5.Key.AsGuid) {
return ssMonth5;
}
if (attributeKey == IdMonth6.Key.AsGuid) {
return ssMonth6;
}
if (attributeKey == IdMonth7.Key.AsGuid) {
return ssMonth7;
}
if (attributeKey == IdMonth8.Key.AsGuid) {
return ssMonth8;
}
if (attributeKey == IdMonth9.Key.AsGuid) {
return ssMonth9;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMonth1 = (string) other.AttributeGet(IdMonth1);
ssMonth10 = (string) other.AttributeGet(IdMonth10);
ssMonth11 = (string) other.AttributeGet(IdMonth11);
ssMonth12 = (string) other.AttributeGet(IdMonth12);
ssMonth2 = (string) other.AttributeGet(IdMonth2);
ssMonth3 = (string) other.AttributeGet(IdMonth3);
ssMonth4 = (string) other.AttributeGet(IdMonth4);
ssMonth5 = (string) other.AttributeGet(IdMonth5);
ssMonth6 = (string) other.AttributeGet(IdMonth6);
ssMonth7 = (string) other.AttributeGet(IdMonth7);
ssMonth8 = (string) other.AttributeGet(IdMonth8);
ssMonth9 = (string) other.AttributeGet(IdMonth9);
}
} // RC_35ce9df1ad7a89533b2e8a49a8413520
/// <summary>
/// RecordList type
///  <code>Month1Month10Month11Month12Month2Month3Month4Month5Month6Month7Month8Month9RecordList</code
/// > that represents a record list of <code>Text, Text, Text, Text, Text, Text, Text, Text, Text,
///  Text, Text, Text</code>
/// </summary>
public partial class RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 : GenericRecordList<RC_35ce9df1ad7a89533b2e8a49a8413520>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_35ce9df1ad7a89533b2e8a49a8413520 GetElementDefaultValue() {
return new RC_35ce9df1ad7a89533b2e8a49a8413520();
}

public T[] ToArray<T>(Func<RC_35ce9df1ad7a89533b2e8a49a8413520, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 recordList, Func<RC_35ce9df1ad7a89533b2e8a49a8413520, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aec2af9ce70ea7e7bfe1e63d0f657cf5(RC_35ce9df1ad7a89533b2e8a49a8413520[] array) {
  RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 result = new RL_aec2af9ce70ea7e7bfe1e63d0f657cf5();
result.InnerFromArray(array);
    return result;
}

public static RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 ToList<T>(T[] array, Func <T, RC_35ce9df1ad7a89533b2e8a49a8413520> converter) {
  RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 result = new RL_aec2af9ce70ea7e7bfe1e63d0f657cf5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 FromRestList<T>(RestList<T> restList, Func <T, RC_35ce9df1ad7a89533b2e8a49a8413520> converter) {
  RL_aec2af9ce70ea7e7bfe1e63d0f657cf5 result = new RL_aec2af9ce70ea7e7bfe1e63d0f657cf5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aec2af9ce70ea7e7bfe1e63d0f657cf5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_35ce9df1ad7a89533b2e8a49a8413520> NewList() {
return new RL_aec2af9ce70ea7e7bfe1e63d0f657cf5();
}


} // RL_aec2af9ce70ea7e7bfe1e63d0f657cf5
}

