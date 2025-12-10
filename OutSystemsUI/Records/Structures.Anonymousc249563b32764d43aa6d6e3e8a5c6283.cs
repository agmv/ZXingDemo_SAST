namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (O1ZJwnYyQ02qbW4+ilxigw)
///  <code>RC_4835a3b0a2d4ab28e154f8a8831a00ef</code> that represents <code>MonthYearRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MonthYearRecord
public partial struct RC_4835a3b0a2d4ab28e154f8a8831a00ef : ITypedRecord<RC_4835a3b0a2d4ab28e154f8a8831a00ef> {
internal static readonly GlobalObjectKey IdMonthYear = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sKM1SNSiKKvhVPiogxoA7w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MonthYear")]
public ST_5c08eaa15b890a2d617cabe547c34f0bStructure ssSTMonthYear;


public static implicit operator ST_5c08eaa15b890a2d617cabe547c34f0bStructure( RC_4835a3b0a2d4ab28e154f8a8831a00ef r) {
return r.ssSTMonthYear;
}

public static implicit operator RC_4835a3b0a2d4ab28e154f8a8831a00ef (ST_5c08eaa15b890a2d617cabe547c34f0bStructure r) {
RC_4835a3b0a2d4ab28e154f8a8831a00ef res = new RC_4835a3b0a2d4ab28e154f8a8831a00ef ();
res.ssSTMonthYear = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4835a3b0a2d4ab28e154f8a8831a00ef() {
OptimizedAttributes = null;
ssSTMonthYear = new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
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
    ssSTMonthYear.OptimizedAttributes = value[0];
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
ssSTMonthYear.Read( r, ref index);
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
public void ReadIM(RC_4835a3b0a2d4ab28e154f8a8831a00ef r) {
this = r;
}


public static bool operator == (RC_4835a3b0a2d4ab28e154f8a8831a00ef a, RC_4835a3b0a2d4ab28e154f8a8831a00ef b) {
if (a.ssSTMonthYear != b.ssSTMonthYear) return false;
return true;
}

public static bool operator != (RC_4835a3b0a2d4ab28e154f8a8831a00ef a, RC_4835a3b0a2d4ab28e154f8a8831a00ef b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4835a3b0a2d4ab28e154f8a8831a00ef)) return false;
return (this == (RC_4835a3b0a2d4ab28e154f8a8831a00ef)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMonthYear.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMonthYear.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMonthYear.InternalRecursiveSave();
}


public RC_4835a3b0a2d4ab28e154f8a8831a00ef Duplicate() {
RC_4835a3b0a2d4ab28e154f8a8831a00ef t;
t.ssSTMonthYear = (ST_5c08eaa15b890a2d617cabe547c34f0bStructure)this.ssSTMonthYear.Duplicate();
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
if (head == "monthyear") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MonthYear")) variable.Value = ssSTMonthYear; else variable.Optimized = true;
variable.SetFieldName("monthyear");
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
if (key == IdMonthYear) {
return ssSTMonthYear;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonthYear.Key.AsGuid) {
return ssSTMonthYear;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMonthYear.FillFromOther((IRecord) other.AttributeGet(IdMonthYear));
}
} // RC_4835a3b0a2d4ab28e154f8a8831a00ef
/// <summary>
/// RecordList type <code>MonthYearRecordList</code> that represents a record list of
///  <code>MonthYear</code>
/// </summary>
public partial class RL_f895ce68953fdb97b2f37d55699f4e66 : GenericRecordList<RC_4835a3b0a2d4ab28e154f8a8831a00ef>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_4835a3b0a2d4ab28e154f8a8831a00ef GetElementDefaultValue() {
return new RC_4835a3b0a2d4ab28e154f8a8831a00ef();
}

public T[] ToArray<T>(Func<RC_4835a3b0a2d4ab28e154f8a8831a00ef, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f895ce68953fdb97b2f37d55699f4e66 recordList, Func<RC_4835a3b0a2d4ab28e154f8a8831a00ef, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f895ce68953fdb97b2f37d55699f4e66(RC_4835a3b0a2d4ab28e154f8a8831a00ef[] array) {
  RL_f895ce68953fdb97b2f37d55699f4e66 result = new RL_f895ce68953fdb97b2f37d55699f4e66();
result.InnerFromArray(array);
    return result;
}

public static RL_f895ce68953fdb97b2f37d55699f4e66 ToList<T>(T[] array, Func <T, RC_4835a3b0a2d4ab28e154f8a8831a00ef> converter) {
  RL_f895ce68953fdb97b2f37d55699f4e66 result = new RL_f895ce68953fdb97b2f37d55699f4e66();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f895ce68953fdb97b2f37d55699f4e66 FromRestList<T>(RestList<T> restList, Func <T, RC_4835a3b0a2d4ab28e154f8a8831a00ef> converter) {
  RL_f895ce68953fdb97b2f37d55699f4e66 result = new RL_f895ce68953fdb97b2f37d55699f4e66();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f895ce68953fdb97b2f37d55699f4e66() : base() {
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
protected override OSList<RC_4835a3b0a2d4ab28e154f8a8831a00ef> NewList() {
return new RL_f895ce68953fdb97b2f37d55699f4e66();
}


} // RL_f895ce68953fdb97b2f37d55699f4e66
}

