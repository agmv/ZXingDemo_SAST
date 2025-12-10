namespace ssOutSystemsUI {
/// <summary>
/// [Structure] MonthYear (0fcWF_jbQ0ilugRe0GBAnQ)
///  <code>ST_5c08eaa15b890a2d617cabe547c34f0bStructure</code> that represents <code>MonthYear</code
/// > <p>Description: Structure with information about the name month and corresponding year.</p>
/// </summary>
// Name: MonthYear
public partial struct ST_5c08eaa15b890a2d617cabe547c34f0bStructure : ITypedRecord<ST_5c08eaa15b890a2d617cabe547c34f0bStructure> {
internal static readonly GlobalObjectKey IdMonth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*3_J8AYgACk6mP5YRTTbVUQ");
internal static readonly GlobalObjectKey IdYear = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1dfqjbrOr02mrSGiQ0l4Pg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Month")]
public string ssMonth;

[System.Xml.Serialization.XmlElement("Year")]
public int ssYear;


public BitArray OptimizedAttributes;

public ST_5c08eaa15b890a2d617cabe547c34f0bStructure() {
OptimizedAttributes = null;
ssMonth = "";
ssYear = 0;
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
ssMonth = r.ReadEntityReferenceText(index++, "MonthYear.Month", "");
ssYear = r.ReadInteger(index++, "MonthYear.Year", 0);
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
public void ReadIM(ST_5c08eaa15b890a2d617cabe547c34f0bStructure r) {
this = r;
}


public static bool operator == (ST_5c08eaa15b890a2d617cabe547c34f0bStructure a, ST_5c08eaa15b890a2d617cabe547c34f0bStructure b) {
if (a.ssMonth != b.ssMonth) return false;
if (a.ssYear != b.ssYear) return false;
return true;
}

public static bool operator != (ST_5c08eaa15b890a2d617cabe547c34f0bStructure a, ST_5c08eaa15b890a2d617cabe547c34f0bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5c08eaa15b890a2d617cabe547c34f0bStructure)) return false;
return (this == (ST_5c08eaa15b890a2d617cabe547c34f0bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMonth.GetHashCode()
 ^ ssYear.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5c08eaa15b890a2d617cabe547c34f0bStructure Duplicate() {
ST_5c08eaa15b890a2d617cabe547c34f0bStructure t;
t.ssMonth = this.ssMonth;
t.ssYear = this.ssYear;
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
if (head == "month") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month")) variable.Value = ssMonth; else variable.Optimized = true;
} else if (head == "year") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Year")) variable.Value = ssYear; else variable.Optimized = true;
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
if (key == IdMonth) {
return ssMonth;
}
if (key == IdYear) {
return ssYear;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonth.Key.AsGuid) {
return ssMonth;
}
if (attributeKey == IdYear.Key.AsGuid) {
return ssYear;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMonth = (string) other.AttributeGet(IdMonth);
ssYear = (int) other.AttributeGet(IdYear);
}
} // ST_5c08eaa15b890a2d617cabe547c34f0bStructure
/// <summary>
/// RecordList type <code>MonthYearList</code> that represents a record list of <code>MonthYear</code>
/// </summary>
public partial class RL_8f663be7596d4724f6146bc0b1d8cb69 : GenericRecordList<ST_5c08eaa15b890a2d617cabe547c34f0bStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_5c08eaa15b890a2d617cabe547c34f0bStructure GetElementDefaultValue() {
return new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
}

public T[] ToArray<T>(Func<ST_5c08eaa15b890a2d617cabe547c34f0bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8f663be7596d4724f6146bc0b1d8cb69 recordList, Func<ST_5c08eaa15b890a2d617cabe547c34f0bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8f663be7596d4724f6146bc0b1d8cb69(ST_5c08eaa15b890a2d617cabe547c34f0bStructure[] array) {
  RL_8f663be7596d4724f6146bc0b1d8cb69 result = new RL_8f663be7596d4724f6146bc0b1d8cb69();
result.InnerFromArray(array);
    return result;
}

public static RL_8f663be7596d4724f6146bc0b1d8cb69 ToList<T>(T[] array, Func <T, ST_5c08eaa15b890a2d617cabe547c34f0bStructure> converter) {
  RL_8f663be7596d4724f6146bc0b1d8cb69 result = new RL_8f663be7596d4724f6146bc0b1d8cb69();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8f663be7596d4724f6146bc0b1d8cb69 FromRestList<T>(RestList<T> restList, Func <T, ST_5c08eaa15b890a2d617cabe547c34f0bStructure> converter) {
  RL_8f663be7596d4724f6146bc0b1d8cb69 result = new RL_8f663be7596d4724f6146bc0b1d8cb69();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8f663be7596d4724f6146bc0b1d8cb69() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5c08eaa15b890a2d617cabe547c34f0bStructure> NewList() {
return new RL_8f663be7596d4724f6146bc0b1d8cb69();
}


} // RL_8f663be7596d4724f6146bc0b1d8cb69
}

