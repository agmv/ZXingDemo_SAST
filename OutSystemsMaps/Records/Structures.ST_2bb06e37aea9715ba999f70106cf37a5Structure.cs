namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalFileLayerConfigs (+1Ij3AB1Ski+PJs4qpHSWw)
///  <code>ST_2bb06e37aea9715ba999f70106cf37a5Structure</code> that represent
/// s <code>OptionalFileLayerConfigs</code> <p>Description: Set additional parameters to customize the
///  file layer behavior and functionality.</p>
/// </summary>
// Name: OptionalFileLayerConfigs
public partial struct ST_2bb06e37aea9715ba999f70106cf37a5Structure : ITypedRecord<ST_2bb06e37aea9715ba999f70106cf37a5Structure> {
internal static readonly GlobalObjectKey IdSuppressPopups = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Yev1OnQU1kuoBrNr9ynkZw");
internal static readonly GlobalObjectKey IdPreserveViewport = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*x9xctjoc_kmUnMElDFSHiA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SuppressPopups")]
public bool ssSuppressPopups;

[System.Xml.Serialization.XmlElement("PreserveViewport")]
public bool ssPreserveViewport;


public BitArray OptimizedAttributes;

public ST_2bb06e37aea9715ba999f70106cf37a5Structure() {
OptimizedAttributes = null;
ssSuppressPopups = false;
ssPreserveViewport = false;
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
ssSuppressPopups = r.ReadBoolean(index++, "OptionalFileLayerConfigs.SuppressPopups", false);
ssPreserveViewport = r.ReadBoolean(index++, "OptionalFileLayerConfigs.PreserveViewport", false);
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
public void ReadIM(ST_2bb06e37aea9715ba999f70106cf37a5Structure r) {
this = r;
}


public static bool operator == (ST_2bb06e37aea9715ba999f70106cf37a5Structure a, ST_2bb06e37aea9715ba999f70106cf37a5Structure b) {
if (a.ssSuppressPopups != b.ssSuppressPopups) return false;
if (a.ssPreserveViewport != b.ssPreserveViewport) return false;
return true;
}

public static bool operator != (ST_2bb06e37aea9715ba999f70106cf37a5Structure a, ST_2bb06e37aea9715ba999f70106cf37a5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2bb06e37aea9715ba999f70106cf37a5Structure)) return false;
return (this == (ST_2bb06e37aea9715ba999f70106cf37a5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuppressPopups.GetHashCode()
 ^ ssPreserveViewport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_2bb06e37aea9715ba999f70106cf37a5Structure Duplicate() {
ST_2bb06e37aea9715ba999f70106cf37a5Structure t;
t.ssSuppressPopups = this.ssSuppressPopups;
t.ssPreserveViewport = this.ssPreserveViewport;
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
if (head == "suppresspopups") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SuppressPopups")) variable.Value = ssSuppressPopups; else variable.Optimized = true;
} else if (head == "preserveviewport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PreserveViewport")) variable.Value = ssPreserveViewport; else variable.Optimized = true;
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
if (key == IdSuppressPopups) {
return ssSuppressPopups;
}
if (key == IdPreserveViewport) {
return ssPreserveViewport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuppressPopups.Key.AsGuid) {
return ssSuppressPopups;
}
if (attributeKey == IdPreserveViewport.Key.AsGuid) {
return ssPreserveViewport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuppressPopups = (bool) other.AttributeGet(IdSuppressPopups);
ssPreserveViewport = (bool) other.AttributeGet(IdPreserveViewport);
}
} // ST_2bb06e37aea9715ba999f70106cf37a5Structure
/// <summary>
/// RecordList type <code>OptionalFileLayerConfigsList</code> that represents a record list of
///  <code>OptionalFileLayerConfigs</code>
/// </summary>
public partial class RL_5a159bcaeb1a211c3c97752d6b3cfae5 : GenericRecordList<ST_2bb06e37aea9715ba999f70106cf37a5Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_2bb06e37aea9715ba999f70106cf37a5Structure GetElementDefaultValue() {
return new ST_2bb06e37aea9715ba999f70106cf37a5Structure();
}

public T[] ToArray<T>(Func<ST_2bb06e37aea9715ba999f70106cf37a5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a159bcaeb1a211c3c97752d6b3cfae5 recordList, Func<ST_2bb06e37aea9715ba999f70106cf37a5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a159bcaeb1a211c3c97752d6b3cfae5(ST_2bb06e37aea9715ba999f70106cf37a5Structure[] array) {
  RL_5a159bcaeb1a211c3c97752d6b3cfae5 result = new RL_5a159bcaeb1a211c3c97752d6b3cfae5();
result.InnerFromArray(array);
    return result;
}

public static RL_5a159bcaeb1a211c3c97752d6b3cfae5 ToList<T>(T[] array, Func <T, ST_2bb06e37aea9715ba999f70106cf37a5Structure> converter) {
  RL_5a159bcaeb1a211c3c97752d6b3cfae5 result = new RL_5a159bcaeb1a211c3c97752d6b3cfae5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a159bcaeb1a211c3c97752d6b3cfae5 FromRestList<T>(RestList<T> restList, Func <T, ST_2bb06e37aea9715ba999f70106cf37a5Structure> converter) {
  RL_5a159bcaeb1a211c3c97752d6b3cfae5 result = new RL_5a159bcaeb1a211c3c97752d6b3cfae5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a159bcaeb1a211c3c97752d6b3cfae5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2bb06e37aea9715ba999f70106cf37a5Structure> NewList() {
return new RL_5a159bcaeb1a211c3c97752d6b3cfae5();
}


} // RL_5a159bcaeb1a211c3c97752d6b3cfae5
}

