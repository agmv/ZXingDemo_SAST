namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (R28oQYbTGEyIuNqct4MMAQ)
///  <code>RC_7c416001ce979a5857a1237e54d11a88</code> that represent
/// s <code>InlineSVG_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: InlineSVG_InternalConfigRecord
public partial struct RC_7c416001ce979a5857a1237e54d11a88 : ITypedRecord<RC_7c416001ce979a5857a1237e54d11a88> {
internal static readonly GlobalObjectKey IdInlineSVG_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AWBBfJfOWJpXoSN+VNEaiA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("InlineSVG_InternalConfig")]
public ST_bc9955d62033e77475d9540bd4940593Structure ssSTInlineSVG_InternalConfig;


public static implicit operator ST_bc9955d62033e77475d9540bd4940593Structure( RC_7c416001ce979a5857a1237e54d11a88 r) {
return r.ssSTInlineSVG_InternalConfig;
}

public static implicit operator RC_7c416001ce979a5857a1237e54d11a88 (ST_bc9955d62033e77475d9540bd4940593Structure r) {
RC_7c416001ce979a5857a1237e54d11a88 res = new RC_7c416001ce979a5857a1237e54d11a88 ();
res.ssSTInlineSVG_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7c416001ce979a5857a1237e54d11a88() {
OptimizedAttributes = null;
ssSTInlineSVG_InternalConfig = new ST_bc9955d62033e77475d9540bd4940593Structure();
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
    ssSTInlineSVG_InternalConfig.OptimizedAttributes = value[0];
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
ssSTInlineSVG_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_7c416001ce979a5857a1237e54d11a88 r) {
this = r;
}


public static bool operator == (RC_7c416001ce979a5857a1237e54d11a88 a, RC_7c416001ce979a5857a1237e54d11a88 b) {
if (a.ssSTInlineSVG_InternalConfig != b.ssSTInlineSVG_InternalConfig) return false;
return true;
}

public static bool operator != (RC_7c416001ce979a5857a1237e54d11a88 a, RC_7c416001ce979a5857a1237e54d11a88 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7c416001ce979a5857a1237e54d11a88)) return false;
return (this == (RC_7c416001ce979a5857a1237e54d11a88)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInlineSVG_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInlineSVG_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInlineSVG_InternalConfig.InternalRecursiveSave();
}


public RC_7c416001ce979a5857a1237e54d11a88 Duplicate() {
RC_7c416001ce979a5857a1237e54d11a88 t;
t.ssSTInlineSVG_InternalConfig = (ST_bc9955d62033e77475d9540bd4940593Structure)this.ssSTInlineSVG_InternalConfig.Duplicate();
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
if (head == "inlinesvg_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InlineSVG_InternalConfig")) variable.Value = ssSTInlineSVG_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("inlinesvg_internalconfig");
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
if (key == IdInlineSVG_InternalConfig) {
return ssSTInlineSVG_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInlineSVG_InternalConfig.Key.AsGuid) {
return ssSTInlineSVG_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInlineSVG_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdInlineSVG_InternalConfig));
}
} // RC_7c416001ce979a5857a1237e54d11a88
/// <summary>
/// RecordList type <code>InlineSVG_InternalConfigRecordList</code> that represents a record list of
///  <code>InlineSVG_InternalConfig</code>
/// </summary>
public partial class RL_74a608cd4da094ed2430bedab2c84160 : GenericRecordList<RC_7c416001ce979a5857a1237e54d11a88>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7c416001ce979a5857a1237e54d11a88 GetElementDefaultValue() {
return new RC_7c416001ce979a5857a1237e54d11a88();
}

public T[] ToArray<T>(Func<RC_7c416001ce979a5857a1237e54d11a88, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_74a608cd4da094ed2430bedab2c84160 recordList, Func<RC_7c416001ce979a5857a1237e54d11a88, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_74a608cd4da094ed2430bedab2c84160(RC_7c416001ce979a5857a1237e54d11a88[] array) {
  RL_74a608cd4da094ed2430bedab2c84160 result = new RL_74a608cd4da094ed2430bedab2c84160();
result.InnerFromArray(array);
    return result;
}

public static RL_74a608cd4da094ed2430bedab2c84160 ToList<T>(T[] array, Func <T, RC_7c416001ce979a5857a1237e54d11a88> converter) {
  RL_74a608cd4da094ed2430bedab2c84160 result = new RL_74a608cd4da094ed2430bedab2c84160();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_74a608cd4da094ed2430bedab2c84160 FromRestList<T>(RestList<T> restList, Func <T, RC_7c416001ce979a5857a1237e54d11a88> converter) {
  RL_74a608cd4da094ed2430bedab2c84160 result = new RL_74a608cd4da094ed2430bedab2c84160();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_74a608cd4da094ed2430bedab2c84160() : base() {
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
protected override OSList<RC_7c416001ce979a5857a1237e54d11a88> NewList() {
return new RL_74a608cd4da094ed2430bedab2c84160();
}


} // RL_74a608cd4da094ed2430bedab2c84160
}

