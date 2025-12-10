namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (Gtm9qSpsY02mrgSA7wh6jA)
///  <code>RC_098ae17f520233165dd0526529ff8852</code> that represent
/// s <code>Carousel_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Carousel_InternalConfigRecord
public partial struct RC_098ae17f520233165dd0526529ff8852 : ITypedRecord<RC_098ae17f520233165dd0526529ff8852> {
internal static readonly GlobalObjectKey IdCarousel_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*f+GKCQJSFjNd0FJlKf+IUg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Carousel_InternalConfig")]
public ST_736a0a0e931f1e6cffc1de4b3ad94539Structure ssSTCarousel_InternalConfig;


public static implicit operator ST_736a0a0e931f1e6cffc1de4b3ad94539Structure( RC_098ae17f520233165dd0526529ff8852 r) {
return r.ssSTCarousel_InternalConfig;
}

public static implicit operator RC_098ae17f520233165dd0526529ff8852 (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure r) {
RC_098ae17f520233165dd0526529ff8852 res = new RC_098ae17f520233165dd0526529ff8852 ();
res.ssSTCarousel_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_098ae17f520233165dd0526529ff8852() {
OptimizedAttributes = null;
ssSTCarousel_InternalConfig = new ST_736a0a0e931f1e6cffc1de4b3ad94539Structure();
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
    ssSTCarousel_InternalConfig.OptimizedAttributes = value[0];
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
ssSTCarousel_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_098ae17f520233165dd0526529ff8852 r) {
this = r;
}


public static bool operator == (RC_098ae17f520233165dd0526529ff8852 a, RC_098ae17f520233165dd0526529ff8852 b) {
if (a.ssSTCarousel_InternalConfig != b.ssSTCarousel_InternalConfig) return false;
return true;
}

public static bool operator != (RC_098ae17f520233165dd0526529ff8852 a, RC_098ae17f520233165dd0526529ff8852 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_098ae17f520233165dd0526529ff8852)) return false;
return (this == (RC_098ae17f520233165dd0526529ff8852)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCarousel_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCarousel_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCarousel_InternalConfig.InternalRecursiveSave();
}


public RC_098ae17f520233165dd0526529ff8852 Duplicate() {
RC_098ae17f520233165dd0526529ff8852 t;
t.ssSTCarousel_InternalConfig = (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure)this.ssSTCarousel_InternalConfig.Duplicate();
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
if (head == "carousel_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Carousel_InternalConfig")) variable.Value = ssSTCarousel_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("carousel_internalconfig");
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
if (key == IdCarousel_InternalConfig) {
return ssSTCarousel_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCarousel_InternalConfig.Key.AsGuid) {
return ssSTCarousel_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCarousel_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdCarousel_InternalConfig));
}
} // RC_098ae17f520233165dd0526529ff8852
/// <summary>
/// RecordList type <code>Carousel_InternalConfigRecordList</code> that represents a record list of
///  <code>Carousel_InternalConfig</code>
/// </summary>
public partial class RL_9218ab2195edc65f2e39b1f9240d7383 : GenericRecordList<RC_098ae17f520233165dd0526529ff8852>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_098ae17f520233165dd0526529ff8852 GetElementDefaultValue() {
return new RC_098ae17f520233165dd0526529ff8852();
}

public T[] ToArray<T>(Func<RC_098ae17f520233165dd0526529ff8852, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9218ab2195edc65f2e39b1f9240d7383 recordList, Func<RC_098ae17f520233165dd0526529ff8852, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9218ab2195edc65f2e39b1f9240d7383(RC_098ae17f520233165dd0526529ff8852[] array) {
  RL_9218ab2195edc65f2e39b1f9240d7383 result = new RL_9218ab2195edc65f2e39b1f9240d7383();
result.InnerFromArray(array);
    return result;
}

public static RL_9218ab2195edc65f2e39b1f9240d7383 ToList<T>(T[] array, Func <T, RC_098ae17f520233165dd0526529ff8852> converter) {
  RL_9218ab2195edc65f2e39b1f9240d7383 result = new RL_9218ab2195edc65f2e39b1f9240d7383();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9218ab2195edc65f2e39b1f9240d7383 FromRestList<T>(RestList<T> restList, Func <T, RC_098ae17f520233165dd0526529ff8852> converter) {
  RL_9218ab2195edc65f2e39b1f9240d7383 result = new RL_9218ab2195edc65f2e39b1f9240d7383();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9218ab2195edc65f2e39b1f9240d7383() : base() {
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
protected override OSList<RC_098ae17f520233165dd0526529ff8852> NewList() {
return new RL_9218ab2195edc65f2e39b1f9240d7383();
}


} // RL_9218ab2195edc65f2e39b1f9240d7383
}

