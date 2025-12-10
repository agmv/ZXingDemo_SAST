namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (IJlU+GJimUqLCWGOOH8+zw)
///  <code>RC_fd916ed3e439afbf2b3a8036c2de75ba</code> that represents <code>TravelModeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TravelModeRecord
public partial struct RC_fd916ed3e439afbf2b3a8036c2de75ba : ITypedRecord<RC_fd916ed3e439afbf2b3a8036c2de75ba> {
internal static readonly GlobalObjectKey IdTravelMode = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*026R_Tnkv68rOoA2wt51ug");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("TravelMode")]
public EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord ssENTravelMode;


public static implicit operator EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord( RC_fd916ed3e439afbf2b3a8036c2de75ba r) {
return r.ssENTravelMode;
}

public static implicit operator RC_fd916ed3e439afbf2b3a8036c2de75ba (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord r) {
RC_fd916ed3e439afbf2b3a8036c2de75ba res = new RC_fd916ed3e439afbf2b3a8036c2de75ba ();
res.ssENTravelMode = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENTravelMode.ChangedAttributes = value;
}
get {
    return ssENTravelMode.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_fd916ed3e439afbf2b3a8036c2de75ba() {
OptimizedAttributes = null;
ssENTravelMode = new EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENTravelMode.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENTravelMode.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENTravelMode.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENTravelMode.Read( r, ref index);
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
public void ReadIM(RC_fd916ed3e439afbf2b3a8036c2de75ba r) {
this = r;
}


public static bool operator == (RC_fd916ed3e439afbf2b3a8036c2de75ba a, RC_fd916ed3e439afbf2b3a8036c2de75ba b) {
if (a.ssENTravelMode != b.ssENTravelMode) return false;
return true;
}

public static bool operator != (RC_fd916ed3e439afbf2b3a8036c2de75ba a, RC_fd916ed3e439afbf2b3a8036c2de75ba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fd916ed3e439afbf2b3a8036c2de75ba)) return false;
return (this == (RC_fd916ed3e439afbf2b3a8036c2de75ba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENTravelMode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENTravelMode.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENTravelMode.InternalRecursiveSave();
}


public RC_fd916ed3e439afbf2b3a8036c2de75ba Duplicate() {
RC_fd916ed3e439afbf2b3a8036c2de75ba t;
t.ssENTravelMode = (EN_66bd367690762fecfd8fe2f2e4080f5dEntityRecord)this.ssENTravelMode.Duplicate();
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
if (head == "travelmode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TravelMode")) variable.Value = ssENTravelMode; else variable.Optimized = true;
variable.SetFieldName("travelmode");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENTravelMode.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENTravelMode.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTravelMode) {
return ssENTravelMode;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTravelMode.Key.AsGuid) {
return ssENTravelMode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENTravelMode.FillFromOther((IRecord) other.AttributeGet(IdTravelMode));
}
} // RC_fd916ed3e439afbf2b3a8036c2de75ba
/// <summary>
/// RecordList type <code>TravelModeRecordList</code> that represents a record list of
///  <code>TravelMode</code>
/// </summary>
public partial class RL_ae0575ea17d8ab65a3c4f4247d2336cf : GenericRecordList<RC_fd916ed3e439afbf2b3a8036c2de75ba>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_fd916ed3e439afbf2b3a8036c2de75ba GetElementDefaultValue() {
return new RC_fd916ed3e439afbf2b3a8036c2de75ba();
}

public T[] ToArray<T>(Func<RC_fd916ed3e439afbf2b3a8036c2de75ba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae0575ea17d8ab65a3c4f4247d2336cf recordList, Func<RC_fd916ed3e439afbf2b3a8036c2de75ba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae0575ea17d8ab65a3c4f4247d2336cf(RC_fd916ed3e439afbf2b3a8036c2de75ba[] array) {
  RL_ae0575ea17d8ab65a3c4f4247d2336cf result = new RL_ae0575ea17d8ab65a3c4f4247d2336cf();
result.InnerFromArray(array);
    return result;
}

public static RL_ae0575ea17d8ab65a3c4f4247d2336cf ToList<T>(T[] array, Func <T, RC_fd916ed3e439afbf2b3a8036c2de75ba> converter) {
  RL_ae0575ea17d8ab65a3c4f4247d2336cf result = new RL_ae0575ea17d8ab65a3c4f4247d2336cf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae0575ea17d8ab65a3c4f4247d2336cf FromRestList<T>(RestList<T> restList, Func <T, RC_fd916ed3e439afbf2b3a8036c2de75ba> converter) {
  RL_ae0575ea17d8ab65a3c4f4247d2336cf result = new RL_ae0575ea17d8ab65a3c4f4247d2336cf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae0575ea17d8ab65a3c4f4247d2336cf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fd916ed3e439afbf2b3a8036c2de75ba> NewList() {
return new RL_ae0575ea17d8ab65a3c4f4247d2336cf();
}


} // RL_ae0575ea17d8ab65a3c4f4247d2336cf
}

