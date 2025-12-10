namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (egm1CfNqCUiDl5+sEVw45w)
///  <code>RC_96c340f5ac620f54674641c63eb91876</code> that represents <code>IconSizeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: IconSizeRecord
public partial struct RC_96c340f5ac620f54674641c63eb91876 : ITypedRecord<RC_96c340f5ac620f54674641c63eb91876> {
internal static readonly GlobalObjectKey IdIconSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9UDDlmKsVA9nRkHGPrkYdg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IconSize")]
public ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure ssSTIconSize;


public static implicit operator ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure( RC_96c340f5ac620f54674641c63eb91876 r) {
return r.ssSTIconSize;
}

public static implicit operator RC_96c340f5ac620f54674641c63eb91876 (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure r) {
RC_96c340f5ac620f54674641c63eb91876 res = new RC_96c340f5ac620f54674641c63eb91876 ();
res.ssSTIconSize = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_96c340f5ac620f54674641c63eb91876() {
OptimizedAttributes = null;
ssSTIconSize = new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure();
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
    ssSTIconSize.OptimizedAttributes = value[0];
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
ssSTIconSize.Read( r, ref index);
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
public void ReadIM(RC_96c340f5ac620f54674641c63eb91876 r) {
this = r;
}


public static bool operator == (RC_96c340f5ac620f54674641c63eb91876 a, RC_96c340f5ac620f54674641c63eb91876 b) {
if (a.ssSTIconSize != b.ssSTIconSize) return false;
return true;
}

public static bool operator != (RC_96c340f5ac620f54674641c63eb91876 a, RC_96c340f5ac620f54674641c63eb91876 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_96c340f5ac620f54674641c63eb91876)) return false;
return (this == (RC_96c340f5ac620f54674641c63eb91876)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTIconSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTIconSize.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTIconSize.InternalRecursiveSave();
}


public RC_96c340f5ac620f54674641c63eb91876 Duplicate() {
RC_96c340f5ac620f54674641c63eb91876 t;
t.ssSTIconSize = (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure)this.ssSTIconSize.Duplicate();
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
if (head == "iconsize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IconSize")) variable.Value = ssSTIconSize; else variable.Optimized = true;
variable.SetFieldName("iconsize");
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
if (key == IdIconSize) {
return ssSTIconSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIconSize.Key.AsGuid) {
return ssSTIconSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTIconSize.FillFromOther((IRecord) other.AttributeGet(IdIconSize));
}
} // RC_96c340f5ac620f54674641c63eb91876
/// <summary>
/// RecordList type <code>IconSizeRecordList</code> that represents a record list of
///  <code>IconSize</code>
/// </summary>
public partial class RL_ddac7ae82399019b6b9f96af5f5696e1 : GenericRecordList<RC_96c340f5ac620f54674641c63eb91876>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_96c340f5ac620f54674641c63eb91876 GetElementDefaultValue() {
return new RC_96c340f5ac620f54674641c63eb91876();
}

public T[] ToArray<T>(Func<RC_96c340f5ac620f54674641c63eb91876, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ddac7ae82399019b6b9f96af5f5696e1 recordList, Func<RC_96c340f5ac620f54674641c63eb91876, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ddac7ae82399019b6b9f96af5f5696e1(RC_96c340f5ac620f54674641c63eb91876[] array) {
  RL_ddac7ae82399019b6b9f96af5f5696e1 result = new RL_ddac7ae82399019b6b9f96af5f5696e1();
result.InnerFromArray(array);
    return result;
}

public static RL_ddac7ae82399019b6b9f96af5f5696e1 ToList<T>(T[] array, Func <T, RC_96c340f5ac620f54674641c63eb91876> converter) {
  RL_ddac7ae82399019b6b9f96af5f5696e1 result = new RL_ddac7ae82399019b6b9f96af5f5696e1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ddac7ae82399019b6b9f96af5f5696e1 FromRestList<T>(RestList<T> restList, Func <T, RC_96c340f5ac620f54674641c63eb91876> converter) {
  RL_ddac7ae82399019b6b9f96af5f5696e1 result = new RL_ddac7ae82399019b6b9f96af5f5696e1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ddac7ae82399019b6b9f96af5f5696e1() : base() {
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
protected override OSList<RC_96c340f5ac620f54674641c63eb91876> NewList() {
return new RL_ddac7ae82399019b6b9f96af5f5696e1();
}


} // RL_ddac7ae82399019b6b9f96af5f5696e1
}

