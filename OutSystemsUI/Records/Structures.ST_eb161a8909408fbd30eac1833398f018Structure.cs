namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ProgressCircleOptionalConfigs (IX4mK1jQ+kaQWhxlHnzoMA)
///  <code>ST_eb161a8909408fbd30eac1833398f018Structure</code> that represent
/// s <code>ProgressCircleOptionalConfigs</code> <p>Description: Group of optional configurations for
///  the ProgressCircle block.</p>
/// </summary>
// Name: ProgressCircleOptionalConfigs
public partial struct ST_eb161a8909408fbd30eac1833398f018Structure : ITypedRecord<ST_eb161a8909408fbd30eac1833398f018Structure> {
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*r+EjvBtP4EKUpoVGWLN5uw");
internal static readonly GlobalObjectKey IdAnimateInitialProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1dwtG5s8DEmcqBc1t5Cgow");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Shape")]
public string ssShape;

[System.Xml.Serialization.XmlElement("AnimateInitialProgress")]
public bool ssAnimateInitialProgress;


public BitArray OptimizedAttributes;

public ST_eb161a8909408fbd30eac1833398f018Structure() {
OptimizedAttributes = null;
ssShape = (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape;
ssAnimateInitialProgress = true;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssShape = r.ReadEntityReferenceText(index++, "ProgressCircleOptionalConfigs.Shape", "");
ssAnimateInitialProgress = r.ReadBoolean(index++, "ProgressCircleOptionalConfigs.AnimateInitialProgress", false);
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
public void ReadIM(ST_eb161a8909408fbd30eac1833398f018Structure r) {
this = r;
}


public static bool operator == (ST_eb161a8909408fbd30eac1833398f018Structure a, ST_eb161a8909408fbd30eac1833398f018Structure b) {
if (a.ssShape != b.ssShape) return false;
if (a.ssAnimateInitialProgress != b.ssAnimateInitialProgress) return false;
return true;
}

public static bool operator != (ST_eb161a8909408fbd30eac1833398f018Structure a, ST_eb161a8909408fbd30eac1833398f018Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_eb161a8909408fbd30eac1833398f018Structure)) return false;
return (this == (ST_eb161a8909408fbd30eac1833398f018Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssShape.GetHashCode()
 ^ ssAnimateInitialProgress.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_eb161a8909408fbd30eac1833398f018Structure Duplicate() {
ST_eb161a8909408fbd30eac1833398f018Structure t;
t.ssShape = this.ssShape;
t.ssAnimateInitialProgress = this.ssAnimateInitialProgress;
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
if (head == "shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Shape")) variable.Value = ssShape; else variable.Optimized = true;
} else if (head == "animateinitialprogress") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AnimateInitialProgress")) variable.Value = ssAnimateInitialProgress; else variable.Optimized = true;
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
if (key == IdShape) {
return ssShape;
}
if (key == IdAnimateInitialProgress) {
return ssAnimateInitialProgress;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShape.Key.AsGuid) {
return ssShape;
}
if (attributeKey == IdAnimateInitialProgress.Key.AsGuid) {
return ssAnimateInitialProgress;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssShape = (string) other.AttributeGet(IdShape);
ssAnimateInitialProgress = (bool) other.AttributeGet(IdAnimateInitialProgress);
}
} // ST_eb161a8909408fbd30eac1833398f018Structure
/// <summary>
/// RecordList type <code>ProgressCircleOptionalConfigsList</code> that represents a record list of
///  <code>ProgressCircleOptionalConfigs</code>
/// </summary>
public partial class RL_c58ca0a921eee43537149b3c5b7a13e2 : GenericRecordList<ST_eb161a8909408fbd30eac1833398f018Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_eb161a8909408fbd30eac1833398f018Structure GetElementDefaultValue() {
return new ST_eb161a8909408fbd30eac1833398f018Structure();
}

public T[] ToArray<T>(Func<ST_eb161a8909408fbd30eac1833398f018Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c58ca0a921eee43537149b3c5b7a13e2 recordList, Func<ST_eb161a8909408fbd30eac1833398f018Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c58ca0a921eee43537149b3c5b7a13e2(ST_eb161a8909408fbd30eac1833398f018Structure[] array) {
  RL_c58ca0a921eee43537149b3c5b7a13e2 result = new RL_c58ca0a921eee43537149b3c5b7a13e2();
result.InnerFromArray(array);
    return result;
}

public static RL_c58ca0a921eee43537149b3c5b7a13e2 ToList<T>(T[] array, Func <T, ST_eb161a8909408fbd30eac1833398f018Structure> converter) {
  RL_c58ca0a921eee43537149b3c5b7a13e2 result = new RL_c58ca0a921eee43537149b3c5b7a13e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c58ca0a921eee43537149b3c5b7a13e2 FromRestList<T>(RestList<T> restList, Func <T, ST_eb161a8909408fbd30eac1833398f018Structure> converter) {
  RL_c58ca0a921eee43537149b3c5b7a13e2 result = new RL_c58ca0a921eee43537149b3c5b7a13e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c58ca0a921eee43537149b3c5b7a13e2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_eb161a8909408fbd30eac1833398f018Structure> NewList() {
return new RL_c58ca0a921eee43537149b3c5b7a13e2();
}


} // RL_c58ca0a921eee43537149b3c5b7a13e2
}

