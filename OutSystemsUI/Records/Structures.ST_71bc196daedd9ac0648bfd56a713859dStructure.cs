namespace ssOutSystemsUI {
/// <summary>
/// [Structure] MonthOrderYear (IEKMqKLYpkqqO+CGuDduBw)
///  <code>ST_71bc196daedd9ac0648bfd56a713859dStructure</code> that represent
/// s <code>MonthOrderYear</code> <p>Description: Structure with information about a month and
///  corresponding year. For each month, it contains information about its name and number.</p>
/// </summary>
// Name: MonthOrderYear
public partial struct ST_71bc196daedd9ac0648bfd56a713859dStructure : ITypedRecord<ST_71bc196daedd9ac0648bfd56a713859dStructure> {
internal static readonly GlobalObjectKey IdMonth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Gzazaw5G8EqGPjqTrnx_6A");
internal static readonly GlobalObjectKey IdMonthOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MBbjezKS5UKGvP2j6hRCag");
internal static readonly GlobalObjectKey IdYear = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*m65top3KEESkehr2xa3o2g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Month")]
public string ssMonth;

[System.Xml.Serialization.XmlElement("MonthOrder")]
public int ssMonthOrder;

[System.Xml.Serialization.XmlElement("Year")]
public int ssYear;


public BitArray OptimizedAttributes;

public ST_71bc196daedd9ac0648bfd56a713859dStructure() {
OptimizedAttributes = null;
ssMonth = "";
ssMonthOrder = 0;
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
ssMonth = r.ReadEntityReferenceText(index++, "MonthOrderYear.Month", "");
ssMonthOrder = r.ReadInteger(index++, "MonthOrderYear.MonthOrder", 0);
ssYear = r.ReadInteger(index++, "MonthOrderYear.Year", 0);
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
public void ReadIM(ST_71bc196daedd9ac0648bfd56a713859dStructure r) {
this = r;
}


public static bool operator == (ST_71bc196daedd9ac0648bfd56a713859dStructure a, ST_71bc196daedd9ac0648bfd56a713859dStructure b) {
if (a.ssMonth != b.ssMonth) return false;
if (a.ssMonthOrder != b.ssMonthOrder) return false;
if (a.ssYear != b.ssYear) return false;
return true;
}

public static bool operator != (ST_71bc196daedd9ac0648bfd56a713859dStructure a, ST_71bc196daedd9ac0648bfd56a713859dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_71bc196daedd9ac0648bfd56a713859dStructure)) return false;
return (this == (ST_71bc196daedd9ac0648bfd56a713859dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMonth.GetHashCode()
 ^ ssMonthOrder.GetHashCode()
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


public ST_71bc196daedd9ac0648bfd56a713859dStructure Duplicate() {
ST_71bc196daedd9ac0648bfd56a713859dStructure t;
t.ssMonth = this.ssMonth;
t.ssMonthOrder = this.ssMonthOrder;
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
} else if (head == "monthorder") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MonthOrder")) variable.Value = ssMonthOrder; else variable.Optimized = true;
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
if (key == IdMonthOrder) {
return ssMonthOrder;
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
if (attributeKey == IdMonthOrder.Key.AsGuid) {
return ssMonthOrder;
}
if (attributeKey == IdYear.Key.AsGuid) {
return ssYear;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssMonth = (string) other.AttributeGet(IdMonth);
ssMonthOrder = (int) other.AttributeGet(IdMonthOrder);
ssYear = (int) other.AttributeGet(IdYear);
}
} // ST_71bc196daedd9ac0648bfd56a713859dStructure
/// <summary>
/// RecordList type <code>MonthOrderYearList</code> that represents a record list of
///  <code>MonthOrderYear</code>
/// </summary>
public partial class RL_c542301ba033767f97d37c7ac8f0f71c : GenericRecordList<ST_71bc196daedd9ac0648bfd56a713859dStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_71bc196daedd9ac0648bfd56a713859dStructure GetElementDefaultValue() {
return new ST_71bc196daedd9ac0648bfd56a713859dStructure();
}

public T[] ToArray<T>(Func<ST_71bc196daedd9ac0648bfd56a713859dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c542301ba033767f97d37c7ac8f0f71c recordList, Func<ST_71bc196daedd9ac0648bfd56a713859dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c542301ba033767f97d37c7ac8f0f71c(ST_71bc196daedd9ac0648bfd56a713859dStructure[] array) {
  RL_c542301ba033767f97d37c7ac8f0f71c result = new RL_c542301ba033767f97d37c7ac8f0f71c();
result.InnerFromArray(array);
    return result;
}

public static RL_c542301ba033767f97d37c7ac8f0f71c ToList<T>(T[] array, Func <T, ST_71bc196daedd9ac0648bfd56a713859dStructure> converter) {
  RL_c542301ba033767f97d37c7ac8f0f71c result = new RL_c542301ba033767f97d37c7ac8f0f71c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c542301ba033767f97d37c7ac8f0f71c FromRestList<T>(RestList<T> restList, Func <T, ST_71bc196daedd9ac0648bfd56a713859dStructure> converter) {
  RL_c542301ba033767f97d37c7ac8f0f71c result = new RL_c542301ba033767f97d37c7ac8f0f71c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c542301ba033767f97d37c7ac8f0f71c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_71bc196daedd9ac0648bfd56a713859dStructure> NewList() {
return new RL_c542301ba033767f97d37c7ac8f0f71c();
}


} // RL_c542301ba033767f97d37c7ac8f0f71c
}

