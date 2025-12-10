namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (xsP5m2TBB0GQv1dbYwjvlw)
///  <code>RC_2fa6ec01db1a6b09e6b59fa237f21deb</code> that represents <code>FeatureDataRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FeatureDataRecord
public partial struct RC_2fa6ec01db1a6b09e6b59fa237f21deb : ITypedRecord<RC_2fa6ec01db1a6b09e6b59fa237f21deb> {
internal static readonly GlobalObjectKey IdFeatureData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AeymLxrbCWvmtZ+iN_Id6w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FeatureData")]
public ST_87d89cf32a40d309845674355a1bd4e1Structure ssSTFeatureData;


public static implicit operator ST_87d89cf32a40d309845674355a1bd4e1Structure( RC_2fa6ec01db1a6b09e6b59fa237f21deb r) {
return r.ssSTFeatureData;
}

public static implicit operator RC_2fa6ec01db1a6b09e6b59fa237f21deb (ST_87d89cf32a40d309845674355a1bd4e1Structure r) {
RC_2fa6ec01db1a6b09e6b59fa237f21deb res = new RC_2fa6ec01db1a6b09e6b59fa237f21deb ();
res.ssSTFeatureData = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2fa6ec01db1a6b09e6b59fa237f21deb() {
OptimizedAttributes = null;
ssSTFeatureData = new ST_87d89cf32a40d309845674355a1bd4e1Structure();
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
    ssSTFeatureData.OptimizedAttributes = value[0];
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
ssSTFeatureData.Read( r, ref index);
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
public void ReadIM(RC_2fa6ec01db1a6b09e6b59fa237f21deb r) {
this = r;
}


public static bool operator == (RC_2fa6ec01db1a6b09e6b59fa237f21deb a, RC_2fa6ec01db1a6b09e6b59fa237f21deb b) {
if (a.ssSTFeatureData != b.ssSTFeatureData) return false;
return true;
}

public static bool operator != (RC_2fa6ec01db1a6b09e6b59fa237f21deb a, RC_2fa6ec01db1a6b09e6b59fa237f21deb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2fa6ec01db1a6b09e6b59fa237f21deb)) return false;
return (this == (RC_2fa6ec01db1a6b09e6b59fa237f21deb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFeatureData.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFeatureData.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFeatureData.InternalRecursiveSave();
}


public RC_2fa6ec01db1a6b09e6b59fa237f21deb Duplicate() {
RC_2fa6ec01db1a6b09e6b59fa237f21deb t;
t.ssSTFeatureData = (ST_87d89cf32a40d309845674355a1bd4e1Structure)this.ssSTFeatureData.Duplicate();
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
if (head == "featuredata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FeatureData")) variable.Value = ssSTFeatureData; else variable.Optimized = true;
variable.SetFieldName("featuredata");
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
if (key == IdFeatureData) {
return ssSTFeatureData;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFeatureData.Key.AsGuid) {
return ssSTFeatureData;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFeatureData.FillFromOther((IRecord) other.AttributeGet(IdFeatureData));
}
} // RC_2fa6ec01db1a6b09e6b59fa237f21deb
/// <summary>
/// RecordList type <code>FeatureDataRecordList</code> that represents a record list of
///  <code>FeatureData</code>
/// </summary>
public partial class RL_80b90c5e418abe587bc307d0e11b1e76 : GenericRecordList<RC_2fa6ec01db1a6b09e6b59fa237f21deb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2fa6ec01db1a6b09e6b59fa237f21deb GetElementDefaultValue() {
return new RC_2fa6ec01db1a6b09e6b59fa237f21deb();
}

public T[] ToArray<T>(Func<RC_2fa6ec01db1a6b09e6b59fa237f21deb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_80b90c5e418abe587bc307d0e11b1e76 recordList, Func<RC_2fa6ec01db1a6b09e6b59fa237f21deb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_80b90c5e418abe587bc307d0e11b1e76(RC_2fa6ec01db1a6b09e6b59fa237f21deb[] array) {
  RL_80b90c5e418abe587bc307d0e11b1e76 result = new RL_80b90c5e418abe587bc307d0e11b1e76();
result.InnerFromArray(array);
    return result;
}

public static RL_80b90c5e418abe587bc307d0e11b1e76 ToList<T>(T[] array, Func <T, RC_2fa6ec01db1a6b09e6b59fa237f21deb> converter) {
  RL_80b90c5e418abe587bc307d0e11b1e76 result = new RL_80b90c5e418abe587bc307d0e11b1e76();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_80b90c5e418abe587bc307d0e11b1e76 FromRestList<T>(RestList<T> restList, Func <T, RC_2fa6ec01db1a6b09e6b59fa237f21deb> converter) {
  RL_80b90c5e418abe587bc307d0e11b1e76 result = new RL_80b90c5e418abe587bc307d0e11b1e76();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_80b90c5e418abe587bc307d0e11b1e76() : base() {
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
protected override OSList<RC_2fa6ec01db1a6b09e6b59fa237f21deb> NewList() {
return new RL_80b90c5e418abe587bc307d0e11b1e76();
}


} // RL_80b90c5e418abe587bc307d0e11b1e76
}

