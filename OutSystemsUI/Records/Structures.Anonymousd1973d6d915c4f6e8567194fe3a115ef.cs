namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (bT2X0VyRbk+FZxlP46EV7w)
///  <code>RC_a52e1739b8f4600af03587813c6346bb</code> that represent
/// s <code>RangeSlider_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: RangeSlider_InternalConfigRecord
public partial struct RC_a52e1739b8f4600af03587813c6346bb : ITypedRecord<RC_a52e1739b8f4600af03587813c6346bb> {
internal static readonly GlobalObjectKey IdRangeSlider_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ORcupfS4CmDwNYeBPGNGuw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RangeSlider_InternalConfig")]
public ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure ssSTRangeSlider_InternalConfig;


public static implicit operator ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure( RC_a52e1739b8f4600af03587813c6346bb r) {
return r.ssSTRangeSlider_InternalConfig;
}

public static implicit operator RC_a52e1739b8f4600af03587813c6346bb (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure r) {
RC_a52e1739b8f4600af03587813c6346bb res = new RC_a52e1739b8f4600af03587813c6346bb ();
res.ssSTRangeSlider_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a52e1739b8f4600af03587813c6346bb() {
OptimizedAttributes = null;
ssSTRangeSlider_InternalConfig = new ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure();
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
    ssSTRangeSlider_InternalConfig.OptimizedAttributes = value[0];
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
ssSTRangeSlider_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_a52e1739b8f4600af03587813c6346bb r) {
this = r;
}


public static bool operator == (RC_a52e1739b8f4600af03587813c6346bb a, RC_a52e1739b8f4600af03587813c6346bb b) {
if (a.ssSTRangeSlider_InternalConfig != b.ssSTRangeSlider_InternalConfig) return false;
return true;
}

public static bool operator != (RC_a52e1739b8f4600af03587813c6346bb a, RC_a52e1739b8f4600af03587813c6346bb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a52e1739b8f4600af03587813c6346bb)) return false;
return (this == (RC_a52e1739b8f4600af03587813c6346bb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRangeSlider_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRangeSlider_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRangeSlider_InternalConfig.InternalRecursiveSave();
}


public RC_a52e1739b8f4600af03587813c6346bb Duplicate() {
RC_a52e1739b8f4600af03587813c6346bb t;
t.ssSTRangeSlider_InternalConfig = (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure)this.ssSTRangeSlider_InternalConfig.Duplicate();
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
if (head == "rangeslider_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RangeSlider_InternalConfig")) variable.Value = ssSTRangeSlider_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("rangeslider_internalconfig");
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
if (key == IdRangeSlider_InternalConfig) {
return ssSTRangeSlider_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRangeSlider_InternalConfig.Key.AsGuid) {
return ssSTRangeSlider_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRangeSlider_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdRangeSlider_InternalConfig));
}
} // RC_a52e1739b8f4600af03587813c6346bb
/// <summary>
/// RecordList type <code>RangeSlider_InternalConfigRecordList</code> that represents a record list of
///  <code>RangeSlider_InternalConfig</code>
/// </summary>
public partial class RL_a500b87435ba92088f423cd3cb985687 : GenericRecordList<RC_a52e1739b8f4600af03587813c6346bb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a52e1739b8f4600af03587813c6346bb GetElementDefaultValue() {
return new RC_a52e1739b8f4600af03587813c6346bb();
}

public T[] ToArray<T>(Func<RC_a52e1739b8f4600af03587813c6346bb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a500b87435ba92088f423cd3cb985687 recordList, Func<RC_a52e1739b8f4600af03587813c6346bb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a500b87435ba92088f423cd3cb985687(RC_a52e1739b8f4600af03587813c6346bb[] array) {
  RL_a500b87435ba92088f423cd3cb985687 result = new RL_a500b87435ba92088f423cd3cb985687();
result.InnerFromArray(array);
    return result;
}

public static RL_a500b87435ba92088f423cd3cb985687 ToList<T>(T[] array, Func <T, RC_a52e1739b8f4600af03587813c6346bb> converter) {
  RL_a500b87435ba92088f423cd3cb985687 result = new RL_a500b87435ba92088f423cd3cb985687();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a500b87435ba92088f423cd3cb985687 FromRestList<T>(RestList<T> restList, Func <T, RC_a52e1739b8f4600af03587813c6346bb> converter) {
  RL_a500b87435ba92088f423cd3cb985687 result = new RL_a500b87435ba92088f423cd3cb985687();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a500b87435ba92088f423cd3cb985687() : base() {
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
protected override OSList<RC_a52e1739b8f4600af03587813c6346bb> NewList() {
return new RL_a500b87435ba92088f423cd3cb985687();
}


} // RL_a500b87435ba92088f423cd3cb985687
}

