namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] DirectionLegs (8qH49DaSqU+7_humffgOKA)
///  <code>ST_2c6551904cfa95c93fa24da37b55d320Structure</code> that represent
/// s <code>DirectionLegs</code> <p>Description: Legs from Direction (when direction contains
///  waypoints, each leg is one step from a point to the next)</p>
/// </summary>
// Name: DirectionLegs
public partial struct ST_2c6551904cfa95c93fa24da37b55d320Structure : ITypedRecord<ST_2c6551904cfa95c93fa24da37b55d320Structure> {
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*KGwxBsYCGk6l7cPL+5F24A");
internal static readonly GlobalObjectKey IdDestination = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*tG2n9PMChkCe7_FTTwk+cw");
internal static readonly GlobalObjectKey IdDistance = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*0yB7itorjUK6ZUvOJtKvew");
internal static readonly GlobalObjectKey IdDuration = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*2TIcTBaSTEK8seu4t9b5Bw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Origin")]
public ST_0e474756a4be14d378c73cd05f602bcdStructure ssOrigin;

[System.Xml.Serialization.XmlElement("Destination")]
public ST_0e474756a4be14d378c73cd05f602bcdStructure ssDestination;

[System.Xml.Serialization.XmlElement("Distance")]
public int ssDistance;

[System.Xml.Serialization.XmlElement("Duration")]
public int ssDuration;


public BitArray OptimizedAttributes;

public ST_2c6551904cfa95c93fa24da37b55d320Structure() {
OptimizedAttributes = null;
ssOrigin = new ST_0e474756a4be14d378c73cd05f602bcdStructure();
ssDestination = new ST_0e474756a4be14d378c73cd05f602bcdStructure();
ssDistance = 0;
ssDuration = 0;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssOrigin.OptimizedAttributes = value[0];
    ssDestination.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssDistance = r.ReadInteger(index++, "DirectionLegs.Distance", 0);
ssDuration = r.ReadInteger(index++, "DirectionLegs.Duration", 0);
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
public void ReadIM(ST_2c6551904cfa95c93fa24da37b55d320Structure r) {
this = r;
}


public static bool operator == (ST_2c6551904cfa95c93fa24da37b55d320Structure a, ST_2c6551904cfa95c93fa24da37b55d320Structure b) {
if (a.ssOrigin != b.ssOrigin) return false;
if (a.ssDestination != b.ssDestination) return false;
if (a.ssDistance != b.ssDistance) return false;
if (a.ssDuration != b.ssDuration) return false;
return true;
}

public static bool operator != (ST_2c6551904cfa95c93fa24da37b55d320Structure a, ST_2c6551904cfa95c93fa24da37b55d320Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2c6551904cfa95c93fa24da37b55d320Structure)) return false;
return (this == (ST_2c6551904cfa95c93fa24da37b55d320Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrigin.GetHashCode()
 ^ ssDestination.GetHashCode()
 ^ ssDistance.GetHashCode()
 ^ ssDuration.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOrigin.RecursiveReset();
ssDestination.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOrigin.InternalRecursiveSave();
ssDestination.InternalRecursiveSave();
}


public ST_2c6551904cfa95c93fa24da37b55d320Structure Duplicate() {
ST_2c6551904cfa95c93fa24da37b55d320Structure t;
t.ssOrigin = (ST_0e474756a4be14d378c73cd05f602bcdStructure)this.ssOrigin.Duplicate();
t.ssDestination = (ST_0e474756a4be14d378c73cd05f602bcdStructure)this.ssDestination.Duplicate();
t.ssDistance = this.ssDistance;
t.ssDuration = this.ssDuration;
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
if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssOrigin; else variable.Optimized = true;
variable.SetFieldName("origin");
} else if (head == "destination") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Destination")) variable.Value = ssDestination; else variable.Optimized = true;
variable.SetFieldName("destination");
} else if (head == "distance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Distance")) variable.Value = ssDistance; else variable.Optimized = true;
} else if (head == "duration") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Duration")) variable.Value = ssDuration; else variable.Optimized = true;
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
if (key == IdOrigin) {
return ssOrigin;
}
if (key == IdDestination) {
return ssDestination;
}
if (key == IdDistance) {
return ssDistance;
}
if (key == IdDuration) {
return ssDuration;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssOrigin;
}
if (attributeKey == IdDestination.Key.AsGuid) {
return ssDestination;
}
if (attributeKey == IdDistance.Key.AsGuid) {
return ssDistance;
}
if (attributeKey == IdDuration.Key.AsGuid) {
return ssDuration;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrigin.FillFromOther((IRecord) other.AttributeGet(IdOrigin));
ssDestination.FillFromOther((IRecord) other.AttributeGet(IdDestination));
ssDistance = (int) other.AttributeGet(IdDistance);
ssDuration = (int) other.AttributeGet(IdDuration);
}
} // ST_2c6551904cfa95c93fa24da37b55d320Structure
/// <summary>
/// RecordList type <code>DirectionLegsList</code> that represents a record list of
///  <code>DirectionLegs</code>
/// </summary>
public partial class RL_23d0968d2ab1f8eb693cff9d043fd342 : GenericRecordList<ST_2c6551904cfa95c93fa24da37b55d320Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_2c6551904cfa95c93fa24da37b55d320Structure GetElementDefaultValue() {
return new ST_2c6551904cfa95c93fa24da37b55d320Structure();
}

public T[] ToArray<T>(Func<ST_2c6551904cfa95c93fa24da37b55d320Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_23d0968d2ab1f8eb693cff9d043fd342 recordList, Func<ST_2c6551904cfa95c93fa24da37b55d320Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_23d0968d2ab1f8eb693cff9d043fd342(ST_2c6551904cfa95c93fa24da37b55d320Structure[] array) {
  RL_23d0968d2ab1f8eb693cff9d043fd342 result = new RL_23d0968d2ab1f8eb693cff9d043fd342();
result.InnerFromArray(array);
    return result;
}

public static RL_23d0968d2ab1f8eb693cff9d043fd342 ToList<T>(T[] array, Func <T, ST_2c6551904cfa95c93fa24da37b55d320Structure> converter) {
  RL_23d0968d2ab1f8eb693cff9d043fd342 result = new RL_23d0968d2ab1f8eb693cff9d043fd342();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_23d0968d2ab1f8eb693cff9d043fd342 FromRestList<T>(RestList<T> restList, Func <T, ST_2c6551904cfa95c93fa24da37b55d320Structure> converter) {
  RL_23d0968d2ab1f8eb693cff9d043fd342 result = new RL_23d0968d2ab1f8eb693cff9d043fd342();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_23d0968d2ab1f8eb693cff9d043fd342() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2c6551904cfa95c93fa24da37b55d320Structure> NewList() {
return new RL_23d0968d2ab1f8eb693cff9d043fd342();
}


} // RL_23d0968d2ab1f8eb693cff9d043fd342
}

