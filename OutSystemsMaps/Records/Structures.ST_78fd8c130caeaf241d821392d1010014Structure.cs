namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] ExcludeCriteria (dq+8fPsfK0i172uTcv1VNw)
///  <code>ST_78fd8c130caeaf241d821392d1010014Structure</code> that represent
/// s <code>ExcludeCriteria</code> <p>Description: Structure to handle the exclusion criteria for
///  directions.</p>
/// </summary>
// Name: ExcludeCriteria
public partial struct ST_78fd8c130caeaf241d821392d1010014Structure : ITypedRecord<ST_78fd8c130caeaf241d821392d1010014Structure> {
internal static readonly GlobalObjectKey IdAvoidTolls = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*tBrTDR4KxUqgll7bngLWlA");
internal static readonly GlobalObjectKey IdAvoidHighways = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*hHQHQh2GjEeS0yPr5dOn+Q");
internal static readonly GlobalObjectKey IdAvoidFerries = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*F6eICNEa40a+9Tcoz5onUg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AvoidTolls")]
public bool ssAvoidTolls;

[System.Xml.Serialization.XmlElement("AvoidHighways")]
public bool ssAvoidHighways;

[System.Xml.Serialization.XmlElement("AvoidFerries")]
public bool ssAvoidFerries;


public BitArray OptimizedAttributes;

public ST_78fd8c130caeaf241d821392d1010014Structure() {
OptimizedAttributes = null;
ssAvoidTolls = false;
ssAvoidHighways = false;
ssAvoidFerries = false;
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
ssAvoidTolls = r.ReadBoolean(index++, "ExcludeCriteria.AvoidTolls", false);
ssAvoidHighways = r.ReadBoolean(index++, "ExcludeCriteria.AvoidHighways", false);
ssAvoidFerries = r.ReadBoolean(index++, "ExcludeCriteria.AvoidFerries", false);
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
public void ReadIM(ST_78fd8c130caeaf241d821392d1010014Structure r) {
this = r;
}


public static bool operator == (ST_78fd8c130caeaf241d821392d1010014Structure a, ST_78fd8c130caeaf241d821392d1010014Structure b) {
if (a.ssAvoidTolls != b.ssAvoidTolls) return false;
if (a.ssAvoidHighways != b.ssAvoidHighways) return false;
if (a.ssAvoidFerries != b.ssAvoidFerries) return false;
return true;
}

public static bool operator != (ST_78fd8c130caeaf241d821392d1010014Structure a, ST_78fd8c130caeaf241d821392d1010014Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_78fd8c130caeaf241d821392d1010014Structure)) return false;
return (this == (ST_78fd8c130caeaf241d821392d1010014Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAvoidTolls.GetHashCode()
 ^ ssAvoidHighways.GetHashCode()
 ^ ssAvoidFerries.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_78fd8c130caeaf241d821392d1010014Structure Duplicate() {
ST_78fd8c130caeaf241d821392d1010014Structure t;
t.ssAvoidTolls = this.ssAvoidTolls;
t.ssAvoidHighways = this.ssAvoidHighways;
t.ssAvoidFerries = this.ssAvoidFerries;
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
if (head == "avoidtolls") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AvoidTolls")) variable.Value = ssAvoidTolls; else variable.Optimized = true;
} else if (head == "avoidhighways") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AvoidHighways")) variable.Value = ssAvoidHighways; else variable.Optimized = true;
} else if (head == "avoidferries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AvoidFerries")) variable.Value = ssAvoidFerries; else variable.Optimized = true;
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
if (key == IdAvoidTolls) {
return ssAvoidTolls;
}
if (key == IdAvoidHighways) {
return ssAvoidHighways;
}
if (key == IdAvoidFerries) {
return ssAvoidFerries;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAvoidTolls.Key.AsGuid) {
return ssAvoidTolls;
}
if (attributeKey == IdAvoidHighways.Key.AsGuid) {
return ssAvoidHighways;
}
if (attributeKey == IdAvoidFerries.Key.AsGuid) {
return ssAvoidFerries;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAvoidTolls = (bool) other.AttributeGet(IdAvoidTolls);
ssAvoidHighways = (bool) other.AttributeGet(IdAvoidHighways);
ssAvoidFerries = (bool) other.AttributeGet(IdAvoidFerries);
}
} // ST_78fd8c130caeaf241d821392d1010014Structure
/// <summary>
/// RecordList type <code>ExcludeCriteriaList</code> that represents a record list of
///  <code>ExcludeCriteria</code>
/// </summary>
public partial class RL_9d995883b5323069f271add818c11d4e : GenericRecordList<ST_78fd8c130caeaf241d821392d1010014Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_78fd8c130caeaf241d821392d1010014Structure GetElementDefaultValue() {
return new ST_78fd8c130caeaf241d821392d1010014Structure();
}

public T[] ToArray<T>(Func<ST_78fd8c130caeaf241d821392d1010014Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9d995883b5323069f271add818c11d4e recordList, Func<ST_78fd8c130caeaf241d821392d1010014Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9d995883b5323069f271add818c11d4e(ST_78fd8c130caeaf241d821392d1010014Structure[] array) {
  RL_9d995883b5323069f271add818c11d4e result = new RL_9d995883b5323069f271add818c11d4e();
result.InnerFromArray(array);
    return result;
}

public static RL_9d995883b5323069f271add818c11d4e ToList<T>(T[] array, Func <T, ST_78fd8c130caeaf241d821392d1010014Structure> converter) {
  RL_9d995883b5323069f271add818c11d4e result = new RL_9d995883b5323069f271add818c11d4e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9d995883b5323069f271add818c11d4e FromRestList<T>(RestList<T> restList, Func <T, ST_78fd8c130caeaf241d821392d1010014Structure> converter) {
  RL_9d995883b5323069f271add818c11d4e result = new RL_9d995883b5323069f271add818c11d4e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9d995883b5323069f271add818c11d4e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_78fd8c130caeaf241d821392d1010014Structure> NewList() {
return new RL_9d995883b5323069f271add818c11d4e();
}


} // RL_9d995883b5323069f271add818c11d4e
}

