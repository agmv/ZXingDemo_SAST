namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (yJzONFFvNUmJM9tEjkAWng)
///  <code>RC_0a10b180e32034e48747aceb3ee25eef</code> that represent
/// s <code>SectionIndex_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: SectionIndex_InternalConfigRecord
public partial struct RC_0a10b180e32034e48747aceb3ee25eef : ITypedRecord<RC_0a10b180e32034e48747aceb3ee25eef> {
internal static readonly GlobalObjectKey IdSectionIndex_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gLEQCiDj5DSHR6zrPuJe7w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SectionIndex_InternalConfig")]
public ST_3b9304e9875ccc71ec31b003d76d44c7Structure ssSTSectionIndex_InternalConfig;


public static implicit operator ST_3b9304e9875ccc71ec31b003d76d44c7Structure( RC_0a10b180e32034e48747aceb3ee25eef r) {
return r.ssSTSectionIndex_InternalConfig;
}

public static implicit operator RC_0a10b180e32034e48747aceb3ee25eef (ST_3b9304e9875ccc71ec31b003d76d44c7Structure r) {
RC_0a10b180e32034e48747aceb3ee25eef res = new RC_0a10b180e32034e48747aceb3ee25eef ();
res.ssSTSectionIndex_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0a10b180e32034e48747aceb3ee25eef() {
OptimizedAttributes = null;
ssSTSectionIndex_InternalConfig = new ST_3b9304e9875ccc71ec31b003d76d44c7Structure();
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
    ssSTSectionIndex_InternalConfig.OptimizedAttributes = value[0];
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
ssSTSectionIndex_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_0a10b180e32034e48747aceb3ee25eef r) {
this = r;
}


public static bool operator == (RC_0a10b180e32034e48747aceb3ee25eef a, RC_0a10b180e32034e48747aceb3ee25eef b) {
if (a.ssSTSectionIndex_InternalConfig != b.ssSTSectionIndex_InternalConfig) return false;
return true;
}

public static bool operator != (RC_0a10b180e32034e48747aceb3ee25eef a, RC_0a10b180e32034e48747aceb3ee25eef b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0a10b180e32034e48747aceb3ee25eef)) return false;
return (this == (RC_0a10b180e32034e48747aceb3ee25eef)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSectionIndex_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSectionIndex_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSectionIndex_InternalConfig.InternalRecursiveSave();
}


public RC_0a10b180e32034e48747aceb3ee25eef Duplicate() {
RC_0a10b180e32034e48747aceb3ee25eef t;
t.ssSTSectionIndex_InternalConfig = (ST_3b9304e9875ccc71ec31b003d76d44c7Structure)this.ssSTSectionIndex_InternalConfig.Duplicate();
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
if (head == "sectionindex_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SectionIndex_InternalConfig")) variable.Value = ssSTSectionIndex_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("sectionindex_internalconfig");
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
if (key == IdSectionIndex_InternalConfig) {
return ssSTSectionIndex_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSectionIndex_InternalConfig.Key.AsGuid) {
return ssSTSectionIndex_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSectionIndex_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdSectionIndex_InternalConfig));
}
} // RC_0a10b180e32034e48747aceb3ee25eef
/// <summary>
/// RecordList type <code>SectionIndex_InternalConfigRecordList</code> that represents a record list of
///  <code>SectionIndex_InternalConfig</code>
/// </summary>
public partial class RL_e601dea76a3baf75374a012b5b214ad7 : GenericRecordList<RC_0a10b180e32034e48747aceb3ee25eef>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0a10b180e32034e48747aceb3ee25eef GetElementDefaultValue() {
return new RC_0a10b180e32034e48747aceb3ee25eef();
}

public T[] ToArray<T>(Func<RC_0a10b180e32034e48747aceb3ee25eef, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e601dea76a3baf75374a012b5b214ad7 recordList, Func<RC_0a10b180e32034e48747aceb3ee25eef, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e601dea76a3baf75374a012b5b214ad7(RC_0a10b180e32034e48747aceb3ee25eef[] array) {
  RL_e601dea76a3baf75374a012b5b214ad7 result = new RL_e601dea76a3baf75374a012b5b214ad7();
result.InnerFromArray(array);
    return result;
}

public static RL_e601dea76a3baf75374a012b5b214ad7 ToList<T>(T[] array, Func <T, RC_0a10b180e32034e48747aceb3ee25eef> converter) {
  RL_e601dea76a3baf75374a012b5b214ad7 result = new RL_e601dea76a3baf75374a012b5b214ad7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e601dea76a3baf75374a012b5b214ad7 FromRestList<T>(RestList<T> restList, Func <T, RC_0a10b180e32034e48747aceb3ee25eef> converter) {
  RL_e601dea76a3baf75374a012b5b214ad7 result = new RL_e601dea76a3baf75374a012b5b214ad7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e601dea76a3baf75374a012b5b214ad7() : base() {
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
protected override OSList<RC_0a10b180e32034e48747aceb3ee25eef> NewList() {
return new RL_e601dea76a3baf75374a012b5b214ad7();
}


} // RL_e601dea76a3baf75374a012b5b214ad7
}

