namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (2DCSfzipqE2D7mP0xB4A+w)
///  <code>RC_80cb2a4451da1d8d8f25a688259024cd</code> that represents <code>StrokeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StrokeRecord
public partial struct RC_80cb2a4451da1d8d8f25a688259024cd : ITypedRecord<RC_80cb2a4451da1d8d8f25a688259024cd> {
internal static readonly GlobalObjectKey IdStroke = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RCrLgNpRjR2PJaaIJZAkzQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Stroke")]
public ST_c2a46cf64d2acc4b38d805712495224cStructure ssSTStroke;


public static implicit operator ST_c2a46cf64d2acc4b38d805712495224cStructure( RC_80cb2a4451da1d8d8f25a688259024cd r) {
return r.ssSTStroke;
}

public static implicit operator RC_80cb2a4451da1d8d8f25a688259024cd (ST_c2a46cf64d2acc4b38d805712495224cStructure r) {
RC_80cb2a4451da1d8d8f25a688259024cd res = new RC_80cb2a4451da1d8d8f25a688259024cd ();
res.ssSTStroke = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_80cb2a4451da1d8d8f25a688259024cd() {
OptimizedAttributes = null;
ssSTStroke = new ST_c2a46cf64d2acc4b38d805712495224cStructure();
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
    ssSTStroke.OptimizedAttributes = value[0];
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
ssSTStroke.Read( r, ref index);
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
public void ReadIM(RC_80cb2a4451da1d8d8f25a688259024cd r) {
this = r;
}


public static bool operator == (RC_80cb2a4451da1d8d8f25a688259024cd a, RC_80cb2a4451da1d8d8f25a688259024cd b) {
if (a.ssSTStroke != b.ssSTStroke) return false;
return true;
}

public static bool operator != (RC_80cb2a4451da1d8d8f25a688259024cd a, RC_80cb2a4451da1d8d8f25a688259024cd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_80cb2a4451da1d8d8f25a688259024cd)) return false;
return (this == (RC_80cb2a4451da1d8d8f25a688259024cd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStroke.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStroke.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStroke.InternalRecursiveSave();
}


public RC_80cb2a4451da1d8d8f25a688259024cd Duplicate() {
RC_80cb2a4451da1d8d8f25a688259024cd t;
t.ssSTStroke = (ST_c2a46cf64d2acc4b38d805712495224cStructure)this.ssSTStroke.Duplicate();
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
if (head == "stroke") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Stroke")) variable.Value = ssSTStroke; else variable.Optimized = true;
variable.SetFieldName("stroke");
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
if (key == IdStroke) {
return ssSTStroke;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStroke.Key.AsGuid) {
return ssSTStroke;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStroke.FillFromOther((IRecord) other.AttributeGet(IdStroke));
}
} // RC_80cb2a4451da1d8d8f25a688259024cd
/// <summary>
/// RecordList type <code>StrokeRecordList</code> that represents a record list of <code>Stroke</code>
/// </summary>
public partial class RL_01101873132d33b7b76cda4800cadf1d : GenericRecordList<RC_80cb2a4451da1d8d8f25a688259024cd>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_80cb2a4451da1d8d8f25a688259024cd GetElementDefaultValue() {
return new RC_80cb2a4451da1d8d8f25a688259024cd();
}

public T[] ToArray<T>(Func<RC_80cb2a4451da1d8d8f25a688259024cd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_01101873132d33b7b76cda4800cadf1d recordList, Func<RC_80cb2a4451da1d8d8f25a688259024cd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_01101873132d33b7b76cda4800cadf1d(RC_80cb2a4451da1d8d8f25a688259024cd[] array) {
  RL_01101873132d33b7b76cda4800cadf1d result = new RL_01101873132d33b7b76cda4800cadf1d();
result.InnerFromArray(array);
    return result;
}

public static RL_01101873132d33b7b76cda4800cadf1d ToList<T>(T[] array, Func <T, RC_80cb2a4451da1d8d8f25a688259024cd> converter) {
  RL_01101873132d33b7b76cda4800cadf1d result = new RL_01101873132d33b7b76cda4800cadf1d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_01101873132d33b7b76cda4800cadf1d FromRestList<T>(RestList<T> restList, Func <T, RC_80cb2a4451da1d8d8f25a688259024cd> converter) {
  RL_01101873132d33b7b76cda4800cadf1d result = new RL_01101873132d33b7b76cda4800cadf1d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_01101873132d33b7b76cda4800cadf1d() : base() {
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
protected override OSList<RC_80cb2a4451da1d8d8f25a688259024cd> NewList() {
return new RL_01101873132d33b7b76cda4800cadf1d();
}


} // RL_01101873132d33b7b76cda4800cadf1d
}

