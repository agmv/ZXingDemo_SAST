namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (y3xz6QiFO0OoXXa1gr_yEw)
///  <code>RC_f6c2f142af073709395973c555ac9ddc</code> that represents <code>PointsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PointsRecord
public partial struct RC_f6c2f142af073709395973c555ac9ddc : ITypedRecord<RC_f6c2f142af073709395973c555ac9ddc> {
internal static readonly GlobalObjectKey IdPoints = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QvHC9gevCTc5WXPFVayd3A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Points")]
public ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure ssSTPoints;


public static implicit operator ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure( RC_f6c2f142af073709395973c555ac9ddc r) {
return r.ssSTPoints;
}

public static implicit operator RC_f6c2f142af073709395973c555ac9ddc (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure r) {
RC_f6c2f142af073709395973c555ac9ddc res = new RC_f6c2f142af073709395973c555ac9ddc ();
res.ssSTPoints = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f6c2f142af073709395973c555ac9ddc() {
OptimizedAttributes = null;
ssSTPoints = new ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure();
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
    ssSTPoints.OptimizedAttributes = value[0];
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
ssSTPoints.Read( r, ref index);
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
public void ReadIM(RC_f6c2f142af073709395973c555ac9ddc r) {
this = r;
}


public static bool operator == (RC_f6c2f142af073709395973c555ac9ddc a, RC_f6c2f142af073709395973c555ac9ddc b) {
if (a.ssSTPoints != b.ssSTPoints) return false;
return true;
}

public static bool operator != (RC_f6c2f142af073709395973c555ac9ddc a, RC_f6c2f142af073709395973c555ac9ddc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f6c2f142af073709395973c555ac9ddc)) return false;
return (this == (RC_f6c2f142af073709395973c555ac9ddc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPoints.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPoints.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPoints.InternalRecursiveSave();
}


public RC_f6c2f142af073709395973c555ac9ddc Duplicate() {
RC_f6c2f142af073709395973c555ac9ddc t;
t.ssSTPoints = (ST_ca9f1e36e4f2b1c8cabc0fd0c956ac77Structure)this.ssSTPoints.Duplicate();
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
if (head == "points") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Points")) variable.Value = ssSTPoints; else variable.Optimized = true;
variable.SetFieldName("points");
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
if (key == IdPoints) {
return ssSTPoints;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPoints.Key.AsGuid) {
return ssSTPoints;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPoints.FillFromOther((IRecord) other.AttributeGet(IdPoints));
}
} // RC_f6c2f142af073709395973c555ac9ddc
/// <summary>
/// RecordList type <code>PointsRecordList</code> that represents a record list of <code>Points</code>
/// </summary>
public partial class RL_73ee209cf0a78b1590dcc8cc4fe17b9e : GenericRecordList<RC_f6c2f142af073709395973c555ac9ddc>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f6c2f142af073709395973c555ac9ddc GetElementDefaultValue() {
return new RC_f6c2f142af073709395973c555ac9ddc();
}

public T[] ToArray<T>(Func<RC_f6c2f142af073709395973c555ac9ddc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_73ee209cf0a78b1590dcc8cc4fe17b9e recordList, Func<RC_f6c2f142af073709395973c555ac9ddc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_73ee209cf0a78b1590dcc8cc4fe17b9e(RC_f6c2f142af073709395973c555ac9ddc[] array) {
  RL_73ee209cf0a78b1590dcc8cc4fe17b9e result = new RL_73ee209cf0a78b1590dcc8cc4fe17b9e();
result.InnerFromArray(array);
    return result;
}

public static RL_73ee209cf0a78b1590dcc8cc4fe17b9e ToList<T>(T[] array, Func <T, RC_f6c2f142af073709395973c555ac9ddc> converter) {
  RL_73ee209cf0a78b1590dcc8cc4fe17b9e result = new RL_73ee209cf0a78b1590dcc8cc4fe17b9e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_73ee209cf0a78b1590dcc8cc4fe17b9e FromRestList<T>(RestList<T> restList, Func <T, RC_f6c2f142af073709395973c555ac9ddc> converter) {
  RL_73ee209cf0a78b1590dcc8cc4fe17b9e result = new RL_73ee209cf0a78b1590dcc8cc4fe17b9e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_73ee209cf0a78b1590dcc8cc4fe17b9e() : base() {
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
protected override OSList<RC_f6c2f142af073709395973c555ac9ddc> NewList() {
return new RL_73ee209cf0a78b1590dcc8cc4fe17b9e();
}


} // RL_73ee209cf0a78b1590dcc8cc4fe17b9e
}

