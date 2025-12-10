namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (jRnDouk_XUGowNTe6tcc9A)
///  <code>RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1</code> that represents <code>MonthOrderYearRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MonthOrderYearRecord
public partial struct RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 : ITypedRecord<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> {
internal static readonly GlobalObjectKey IdMonthOrderYear = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dzxP4U+tLXx_ytFPwKub8Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MonthOrderYear")]
public ST_71bc196daedd9ac0648bfd56a713859dStructure ssSTMonthOrderYear;


public static implicit operator ST_71bc196daedd9ac0648bfd56a713859dStructure( RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 r) {
return r.ssSTMonthOrderYear;
}

public static implicit operator RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 (ST_71bc196daedd9ac0648bfd56a713859dStructure r) {
RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 res = new RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 ();
res.ssSTMonthOrderYear = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1() {
OptimizedAttributes = null;
ssSTMonthOrderYear = new ST_71bc196daedd9ac0648bfd56a713859dStructure();
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
    ssSTMonthOrderYear.OptimizedAttributes = value[0];
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
ssSTMonthOrderYear.Read( r, ref index);
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
public void ReadIM(RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 r) {
this = r;
}


public static bool operator == (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 a, RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 b) {
if (a.ssSTMonthOrderYear != b.ssSTMonthOrderYear) return false;
return true;
}

public static bool operator != (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 a, RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1)) return false;
return (this == (RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMonthOrderYear.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMonthOrderYear.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMonthOrderYear.InternalRecursiveSave();
}


public RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 Duplicate() {
RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 t;
t.ssSTMonthOrderYear = (ST_71bc196daedd9ac0648bfd56a713859dStructure)this.ssSTMonthOrderYear.Duplicate();
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
if (head == "monthorderyear") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MonthOrderYear")) variable.Value = ssSTMonthOrderYear; else variable.Optimized = true;
variable.SetFieldName("monthorderyear");
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
if (key == IdMonthOrderYear) {
return ssSTMonthOrderYear;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonthOrderYear.Key.AsGuid) {
return ssSTMonthOrderYear;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMonthOrderYear.FillFromOther((IRecord) other.AttributeGet(IdMonthOrderYear));
}
} // RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1
/// <summary>
/// RecordList type <code>MonthOrderYearRecordList</code> that represents a record list of
///  <code>MonthOrderYear</code>
/// </summary>
public partial class RL_7682dd80718b550d6c5a921d5990d04e : GenericRecordList<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1 GetElementDefaultValue() {
return new RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1();
}

public T[] ToArray<T>(Func<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7682dd80718b550d6c5a921d5990d04e recordList, Func<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7682dd80718b550d6c5a921d5990d04e(RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1[] array) {
  RL_7682dd80718b550d6c5a921d5990d04e result = new RL_7682dd80718b550d6c5a921d5990d04e();
result.InnerFromArray(array);
    return result;
}

public static RL_7682dd80718b550d6c5a921d5990d04e ToList<T>(T[] array, Func <T, RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> converter) {
  RL_7682dd80718b550d6c5a921d5990d04e result = new RL_7682dd80718b550d6c5a921d5990d04e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7682dd80718b550d6c5a921d5990d04e FromRestList<T>(RestList<T> restList, Func <T, RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> converter) {
  RL_7682dd80718b550d6c5a921d5990d04e result = new RL_7682dd80718b550d6c5a921d5990d04e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7682dd80718b550d6c5a921d5990d04e() : base() {
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
protected override OSList<RC_e14f3c77ad4f7c2d7fcad14fc0ab9bf1> NewList() {
return new RL_7682dd80718b550d6c5a921d5990d04e();
}


} // RL_7682dd80718b550d6c5a921d5990d04e
}

