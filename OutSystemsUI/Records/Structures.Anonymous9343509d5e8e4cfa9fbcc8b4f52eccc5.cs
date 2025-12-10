namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (nVBDk45e+kyfvMi09S7MxQ)
///  <code>RC_4fc16da695108ad1b034b7256ffa868d</code> that represent
/// s <code>RangeSliderOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: RangeSliderOptionalConfigsRecord
public partial struct RC_4fc16da695108ad1b034b7256ffa868d : ITypedRecord<RC_4fc16da695108ad1b034b7256ffa868d> {
internal static readonly GlobalObjectKey IdRangeSliderOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pm3BTxCV0YqwNLclb_qGjQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RangeSliderOptionalConfigs")]
public ST_7167810326c75456a7ce120ed2dbd76bStructure ssSTRangeSliderOptionalConfigs;


public static implicit operator ST_7167810326c75456a7ce120ed2dbd76bStructure( RC_4fc16da695108ad1b034b7256ffa868d r) {
return r.ssSTRangeSliderOptionalConfigs;
}

public static implicit operator RC_4fc16da695108ad1b034b7256ffa868d (ST_7167810326c75456a7ce120ed2dbd76bStructure r) {
RC_4fc16da695108ad1b034b7256ffa868d res = new RC_4fc16da695108ad1b034b7256ffa868d ();
res.ssSTRangeSliderOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4fc16da695108ad1b034b7256ffa868d() {
OptimizedAttributes = null;
ssSTRangeSliderOptionalConfigs = new ST_7167810326c75456a7ce120ed2dbd76bStructure();
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
    ssSTRangeSliderOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTRangeSliderOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_4fc16da695108ad1b034b7256ffa868d r) {
this = r;
}


public static bool operator == (RC_4fc16da695108ad1b034b7256ffa868d a, RC_4fc16da695108ad1b034b7256ffa868d b) {
if (a.ssSTRangeSliderOptionalConfigs != b.ssSTRangeSliderOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_4fc16da695108ad1b034b7256ffa868d a, RC_4fc16da695108ad1b034b7256ffa868d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4fc16da695108ad1b034b7256ffa868d)) return false;
return (this == (RC_4fc16da695108ad1b034b7256ffa868d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRangeSliderOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRangeSliderOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRangeSliderOptionalConfigs.InternalRecursiveSave();
}


public RC_4fc16da695108ad1b034b7256ffa868d Duplicate() {
RC_4fc16da695108ad1b034b7256ffa868d t;
t.ssSTRangeSliderOptionalConfigs = (ST_7167810326c75456a7ce120ed2dbd76bStructure)this.ssSTRangeSliderOptionalConfigs.Duplicate();
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
if (head == "rangeslideroptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RangeSliderOptionalConfigs")) variable.Value = ssSTRangeSliderOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("rangeslideroptionalconfigs");
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
if (key == IdRangeSliderOptionalConfigs) {
return ssSTRangeSliderOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRangeSliderOptionalConfigs.Key.AsGuid) {
return ssSTRangeSliderOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRangeSliderOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdRangeSliderOptionalConfigs));
}
} // RC_4fc16da695108ad1b034b7256ffa868d
/// <summary>
/// RecordList type <code>RangeSliderOptionalConfigsRecordList</code> that represents a record list of
///  <code>RangeSliderOptionalConfigs</code>
/// </summary>
public partial class RL_80cc885cccb8696830df8ec337645f92 : GenericRecordList<RC_4fc16da695108ad1b034b7256ffa868d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_4fc16da695108ad1b034b7256ffa868d GetElementDefaultValue() {
return new RC_4fc16da695108ad1b034b7256ffa868d();
}

public T[] ToArray<T>(Func<RC_4fc16da695108ad1b034b7256ffa868d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_80cc885cccb8696830df8ec337645f92 recordList, Func<RC_4fc16da695108ad1b034b7256ffa868d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_80cc885cccb8696830df8ec337645f92(RC_4fc16da695108ad1b034b7256ffa868d[] array) {
  RL_80cc885cccb8696830df8ec337645f92 result = new RL_80cc885cccb8696830df8ec337645f92();
result.InnerFromArray(array);
    return result;
}

public static RL_80cc885cccb8696830df8ec337645f92 ToList<T>(T[] array, Func <T, RC_4fc16da695108ad1b034b7256ffa868d> converter) {
  RL_80cc885cccb8696830df8ec337645f92 result = new RL_80cc885cccb8696830df8ec337645f92();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_80cc885cccb8696830df8ec337645f92 FromRestList<T>(RestList<T> restList, Func <T, RC_4fc16da695108ad1b034b7256ffa868d> converter) {
  RL_80cc885cccb8696830df8ec337645f92 result = new RL_80cc885cccb8696830df8ec337645f92();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_80cc885cccb8696830df8ec337645f92() : base() {
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
protected override OSList<RC_4fc16da695108ad1b034b7256ffa868d> NewList() {
return new RL_80cc885cccb8696830df8ec337645f92();
}


} // RL_80cc885cccb8696830df8ec337645f92
}

