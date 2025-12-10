namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (VLT0x26CLk+hjrJplJU0nA)
///  <code>RC_646e6c02297b69c2ac8936bd87cff545</code> that represent
/// s <code>ProgressCircleOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: ProgressCircleOptionalConfigsRecord
public partial struct RC_646e6c02297b69c2ac8936bd87cff545 : ITypedRecord<RC_646e6c02297b69c2ac8936bd87cff545> {
internal static readonly GlobalObjectKey IdProgressCircleOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AmxuZHspwmmsiTa9h8_1RQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProgressCircleOptionalConfigs")]
public ST_eb161a8909408fbd30eac1833398f018Structure ssSTProgressCircleOptionalConfigs;


public static implicit operator ST_eb161a8909408fbd30eac1833398f018Structure( RC_646e6c02297b69c2ac8936bd87cff545 r) {
return r.ssSTProgressCircleOptionalConfigs;
}

public static implicit operator RC_646e6c02297b69c2ac8936bd87cff545 (ST_eb161a8909408fbd30eac1833398f018Structure r) {
RC_646e6c02297b69c2ac8936bd87cff545 res = new RC_646e6c02297b69c2ac8936bd87cff545 ();
res.ssSTProgressCircleOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_646e6c02297b69c2ac8936bd87cff545() {
OptimizedAttributes = null;
ssSTProgressCircleOptionalConfigs = new ST_eb161a8909408fbd30eac1833398f018Structure();
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
    ssSTProgressCircleOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTProgressCircleOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_646e6c02297b69c2ac8936bd87cff545 r) {
this = r;
}


public static bool operator == (RC_646e6c02297b69c2ac8936bd87cff545 a, RC_646e6c02297b69c2ac8936bd87cff545 b) {
if (a.ssSTProgressCircleOptionalConfigs != b.ssSTProgressCircleOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_646e6c02297b69c2ac8936bd87cff545 a, RC_646e6c02297b69c2ac8936bd87cff545 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_646e6c02297b69c2ac8936bd87cff545)) return false;
return (this == (RC_646e6c02297b69c2ac8936bd87cff545)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTProgressCircleOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTProgressCircleOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTProgressCircleOptionalConfigs.InternalRecursiveSave();
}


public RC_646e6c02297b69c2ac8936bd87cff545 Duplicate() {
RC_646e6c02297b69c2ac8936bd87cff545 t;
t.ssSTProgressCircleOptionalConfigs = (ST_eb161a8909408fbd30eac1833398f018Structure)this.ssSTProgressCircleOptionalConfigs.Duplicate();
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
if (head == "progresscircleoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressCircleOptionalConfigs")) variable.Value = ssSTProgressCircleOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("progresscircleoptionalconfigs");
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
if (key == IdProgressCircleOptionalConfigs) {
return ssSTProgressCircleOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProgressCircleOptionalConfigs.Key.AsGuid) {
return ssSTProgressCircleOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTProgressCircleOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdProgressCircleOptionalConfigs));
}
} // RC_646e6c02297b69c2ac8936bd87cff545
/// <summary>
/// RecordList type <code>ProgressCircleOptionalConfigsRecordList</code> that represents a record list
///  of <code>ProgressCircleOptionalConfigs</code>
/// </summary>
public partial class RL_9797ec0d56ee4ca8b93bd458944f1a08 : GenericRecordList<RC_646e6c02297b69c2ac8936bd87cff545>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_646e6c02297b69c2ac8936bd87cff545 GetElementDefaultValue() {
return new RC_646e6c02297b69c2ac8936bd87cff545();
}

public T[] ToArray<T>(Func<RC_646e6c02297b69c2ac8936bd87cff545, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9797ec0d56ee4ca8b93bd458944f1a08 recordList, Func<RC_646e6c02297b69c2ac8936bd87cff545, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9797ec0d56ee4ca8b93bd458944f1a08(RC_646e6c02297b69c2ac8936bd87cff545[] array) {
  RL_9797ec0d56ee4ca8b93bd458944f1a08 result = new RL_9797ec0d56ee4ca8b93bd458944f1a08();
result.InnerFromArray(array);
    return result;
}

public static RL_9797ec0d56ee4ca8b93bd458944f1a08 ToList<T>(T[] array, Func <T, RC_646e6c02297b69c2ac8936bd87cff545> converter) {
  RL_9797ec0d56ee4ca8b93bd458944f1a08 result = new RL_9797ec0d56ee4ca8b93bd458944f1a08();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9797ec0d56ee4ca8b93bd458944f1a08 FromRestList<T>(RestList<T> restList, Func <T, RC_646e6c02297b69c2ac8936bd87cff545> converter) {
  RL_9797ec0d56ee4ca8b93bd458944f1a08 result = new RL_9797ec0d56ee4ca8b93bd458944f1a08();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9797ec0d56ee4ca8b93bd458944f1a08() : base() {
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
protected override OSList<RC_646e6c02297b69c2ac8936bd87cff545> NewList() {
return new RL_9797ec0d56ee4ca8b93bd458944f1a08();
}


} // RL_9797ec0d56ee4ca8b93bd458944f1a08
}

