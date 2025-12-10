namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (FqvZJ39lEUiMSDvTp9zltg)
///  <code>RC_60f7027c05b269e64f9c4c41640d4643</code> that represent
/// s <code>MonthPicker_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: MonthPicker_InternalConfigRecord
public partial struct RC_60f7027c05b269e64f9c4c41640d4643 : ITypedRecord<RC_60f7027c05b269e64f9c4c41640d4643> {
internal static readonly GlobalObjectKey IdMonthPicker_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fAL3YLIF5mlPnExBZA1GQw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MonthPicker_InternalConfig")]
public ST_6f97d9724e66f51b47133aa003a9e610Structure ssSTMonthPicker_InternalConfig;


public static implicit operator ST_6f97d9724e66f51b47133aa003a9e610Structure( RC_60f7027c05b269e64f9c4c41640d4643 r) {
return r.ssSTMonthPicker_InternalConfig;
}

public static implicit operator RC_60f7027c05b269e64f9c4c41640d4643 (ST_6f97d9724e66f51b47133aa003a9e610Structure r) {
RC_60f7027c05b269e64f9c4c41640d4643 res = new RC_60f7027c05b269e64f9c4c41640d4643 ();
res.ssSTMonthPicker_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_60f7027c05b269e64f9c4c41640d4643() {
OptimizedAttributes = null;
ssSTMonthPicker_InternalConfig = new ST_6f97d9724e66f51b47133aa003a9e610Structure();
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
    ssSTMonthPicker_InternalConfig.OptimizedAttributes = value[0];
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
ssSTMonthPicker_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_60f7027c05b269e64f9c4c41640d4643 r) {
this = r;
}


public static bool operator == (RC_60f7027c05b269e64f9c4c41640d4643 a, RC_60f7027c05b269e64f9c4c41640d4643 b) {
if (a.ssSTMonthPicker_InternalConfig != b.ssSTMonthPicker_InternalConfig) return false;
return true;
}

public static bool operator != (RC_60f7027c05b269e64f9c4c41640d4643 a, RC_60f7027c05b269e64f9c4c41640d4643 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_60f7027c05b269e64f9c4c41640d4643)) return false;
return (this == (RC_60f7027c05b269e64f9c4c41640d4643)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMonthPicker_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMonthPicker_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMonthPicker_InternalConfig.InternalRecursiveSave();
}


public RC_60f7027c05b269e64f9c4c41640d4643 Duplicate() {
RC_60f7027c05b269e64f9c4c41640d4643 t;
t.ssSTMonthPicker_InternalConfig = (ST_6f97d9724e66f51b47133aa003a9e610Structure)this.ssSTMonthPicker_InternalConfig.Duplicate();
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
if (head == "monthpicker_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MonthPicker_InternalConfig")) variable.Value = ssSTMonthPicker_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("monthpicker_internalconfig");
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
if (key == IdMonthPicker_InternalConfig) {
return ssSTMonthPicker_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonthPicker_InternalConfig.Key.AsGuid) {
return ssSTMonthPicker_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMonthPicker_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdMonthPicker_InternalConfig));
}
} // RC_60f7027c05b269e64f9c4c41640d4643
/// <summary>
/// RecordList type <code>MonthPicker_InternalConfigRecordList</code> that represents a record list of
///  <code>MonthPicker_InternalConfig</code>
/// </summary>
public partial class RL_c2447e636d62746c6aa3e6af8767d31e : GenericRecordList<RC_60f7027c05b269e64f9c4c41640d4643>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_60f7027c05b269e64f9c4c41640d4643 GetElementDefaultValue() {
return new RC_60f7027c05b269e64f9c4c41640d4643();
}

public T[] ToArray<T>(Func<RC_60f7027c05b269e64f9c4c41640d4643, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c2447e636d62746c6aa3e6af8767d31e recordList, Func<RC_60f7027c05b269e64f9c4c41640d4643, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c2447e636d62746c6aa3e6af8767d31e(RC_60f7027c05b269e64f9c4c41640d4643[] array) {
  RL_c2447e636d62746c6aa3e6af8767d31e result = new RL_c2447e636d62746c6aa3e6af8767d31e();
result.InnerFromArray(array);
    return result;
}

public static RL_c2447e636d62746c6aa3e6af8767d31e ToList<T>(T[] array, Func <T, RC_60f7027c05b269e64f9c4c41640d4643> converter) {
  RL_c2447e636d62746c6aa3e6af8767d31e result = new RL_c2447e636d62746c6aa3e6af8767d31e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c2447e636d62746c6aa3e6af8767d31e FromRestList<T>(RestList<T> restList, Func <T, RC_60f7027c05b269e64f9c4c41640d4643> converter) {
  RL_c2447e636d62746c6aa3e6af8767d31e result = new RL_c2447e636d62746c6aa3e6af8767d31e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c2447e636d62746c6aa3e6af8767d31e() : base() {
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
protected override OSList<RC_60f7027c05b269e64f9c4c41640d4643> NewList() {
return new RL_c2447e636d62746c6aa3e6af8767d31e();
}


} // RL_c2447e636d62746c6aa3e6af8767d31e
}

