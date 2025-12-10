namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (eYcZciWhPUWBUn9cuvmERw)
///  <code>RC_9c493adade9ae0a5806b7a20eb12f1e0</code> that represent
/// s <code>DirectionsProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: DirectionsProviderRecord
public partial struct RC_9c493adade9ae0a5806b7a20eb12f1e0 : ITypedRecord<RC_9c493adade9ae0a5806b7a20eb12f1e0> {
internal static readonly GlobalObjectKey IdDirectionsProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2jpJnJrepeCAa3og6xLx4A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DirectionsProvider")]
public EN_714295b6f712e509405abbf66debf617EntityRecord ssENDirectionsProvider;


public static implicit operator EN_714295b6f712e509405abbf66debf617EntityRecord( RC_9c493adade9ae0a5806b7a20eb12f1e0 r) {
return r.ssENDirectionsProvider;
}

public static implicit operator RC_9c493adade9ae0a5806b7a20eb12f1e0 (EN_714295b6f712e509405abbf66debf617EntityRecord r) {
RC_9c493adade9ae0a5806b7a20eb12f1e0 res = new RC_9c493adade9ae0a5806b7a20eb12f1e0 ();
res.ssENDirectionsProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDirectionsProvider.ChangedAttributes = value;
}
get {
    return ssENDirectionsProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_9c493adade9ae0a5806b7a20eb12f1e0() {
OptimizedAttributes = null;
ssENDirectionsProvider = new EN_714295b6f712e509405abbf66debf617EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDirectionsProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDirectionsProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDirectionsProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDirectionsProvider.Read( r, ref index);
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
public void ReadIM(RC_9c493adade9ae0a5806b7a20eb12f1e0 r) {
this = r;
}


public static bool operator == (RC_9c493adade9ae0a5806b7a20eb12f1e0 a, RC_9c493adade9ae0a5806b7a20eb12f1e0 b) {
if (a.ssENDirectionsProvider != b.ssENDirectionsProvider) return false;
return true;
}

public static bool operator != (RC_9c493adade9ae0a5806b7a20eb12f1e0 a, RC_9c493adade9ae0a5806b7a20eb12f1e0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9c493adade9ae0a5806b7a20eb12f1e0)) return false;
return (this == (RC_9c493adade9ae0a5806b7a20eb12f1e0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDirectionsProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDirectionsProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDirectionsProvider.InternalRecursiveSave();
}


public RC_9c493adade9ae0a5806b7a20eb12f1e0 Duplicate() {
RC_9c493adade9ae0a5806b7a20eb12f1e0 t;
t.ssENDirectionsProvider = (EN_714295b6f712e509405abbf66debf617EntityRecord)this.ssENDirectionsProvider.Duplicate();
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
if (head == "directionsprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectionsProvider")) variable.Value = ssENDirectionsProvider; else variable.Optimized = true;
variable.SetFieldName("directionsprovider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDirectionsProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDirectionsProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDirectionsProvider) {
return ssENDirectionsProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirectionsProvider.Key.AsGuid) {
return ssENDirectionsProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDirectionsProvider.FillFromOther((IRecord) other.AttributeGet(IdDirectionsProvider));
}
} // RC_9c493adade9ae0a5806b7a20eb12f1e0
/// <summary>
/// RecordList type <code>DirectionsProviderRecordList</code> that represents a record list of
///  <code>DirectionsProvider</code>
/// </summary>
public partial class RL_9f824e61b67438726b0ca6d8a584e2cb : GenericRecordList<RC_9c493adade9ae0a5806b7a20eb12f1e0>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_9c493adade9ae0a5806b7a20eb12f1e0 GetElementDefaultValue() {
return new RC_9c493adade9ae0a5806b7a20eb12f1e0();
}

public T[] ToArray<T>(Func<RC_9c493adade9ae0a5806b7a20eb12f1e0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f824e61b67438726b0ca6d8a584e2cb recordList, Func<RC_9c493adade9ae0a5806b7a20eb12f1e0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f824e61b67438726b0ca6d8a584e2cb(RC_9c493adade9ae0a5806b7a20eb12f1e0[] array) {
  RL_9f824e61b67438726b0ca6d8a584e2cb result = new RL_9f824e61b67438726b0ca6d8a584e2cb();
result.InnerFromArray(array);
    return result;
}

public static RL_9f824e61b67438726b0ca6d8a584e2cb ToList<T>(T[] array, Func <T, RC_9c493adade9ae0a5806b7a20eb12f1e0> converter) {
  RL_9f824e61b67438726b0ca6d8a584e2cb result = new RL_9f824e61b67438726b0ca6d8a584e2cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f824e61b67438726b0ca6d8a584e2cb FromRestList<T>(RestList<T> restList, Func <T, RC_9c493adade9ae0a5806b7a20eb12f1e0> converter) {
  RL_9f824e61b67438726b0ca6d8a584e2cb result = new RL_9f824e61b67438726b0ca6d8a584e2cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f824e61b67438726b0ca6d8a584e2cb() : base() {
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
protected override OSList<RC_9c493adade9ae0a5806b7a20eb12f1e0> NewList() {
return new RL_9f824e61b67438726b0ca6d8a584e2cb();
}


} // RL_9f824e61b67438726b0ca6d8a584e2cb
}

