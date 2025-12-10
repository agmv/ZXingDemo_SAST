namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (VmeKvuBKJkOZDu7QelyEbQ)
///  <code>RC_b2eeb8f69cd26079c0c421f6fd8d6d1f</code> that represent
/// s <code>RegisteredCallbackEventsRecord</code> <p>Description: </p>
/// </summary>
// Name: RegisteredCallbackEventsRecord
public partial struct RC_b2eeb8f69cd26079c0c421f6fd8d6d1f : ITypedRecord<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> {
internal static readonly GlobalObjectKey IdRegisteredCallbackEvents = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9rjustKceWDAxCH2_Y1tHw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RegisteredCallbackEvents")]
public EN_df70a614ae02fde4029645a728b2909cEntityRecord ssENRegisteredCallbackEvents;


public static implicit operator EN_df70a614ae02fde4029645a728b2909cEntityRecord( RC_b2eeb8f69cd26079c0c421f6fd8d6d1f r) {
return r.ssENRegisteredCallbackEvents;
}

public static implicit operator RC_b2eeb8f69cd26079c0c421f6fd8d6d1f (EN_df70a614ae02fde4029645a728b2909cEntityRecord r) {
RC_b2eeb8f69cd26079c0c421f6fd8d6d1f res = new RC_b2eeb8f69cd26079c0c421f6fd8d6d1f ();
res.ssENRegisteredCallbackEvents = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRegisteredCallbackEvents.ChangedAttributes = value;
}
get {
    return ssENRegisteredCallbackEvents.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b2eeb8f69cd26079c0c421f6fd8d6d1f() {
OptimizedAttributes = null;
ssENRegisteredCallbackEvents = new EN_df70a614ae02fde4029645a728b2909cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRegisteredCallbackEvents.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRegisteredCallbackEvents.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRegisteredCallbackEvents.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRegisteredCallbackEvents.Read( r, ref index);
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
public void ReadIM(RC_b2eeb8f69cd26079c0c421f6fd8d6d1f r) {
this = r;
}


public static bool operator == (RC_b2eeb8f69cd26079c0c421f6fd8d6d1f a, RC_b2eeb8f69cd26079c0c421f6fd8d6d1f b) {
if (a.ssENRegisteredCallbackEvents != b.ssENRegisteredCallbackEvents) return false;
return true;
}

public static bool operator != (RC_b2eeb8f69cd26079c0c421f6fd8d6d1f a, RC_b2eeb8f69cd26079c0c421f6fd8d6d1f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b2eeb8f69cd26079c0c421f6fd8d6d1f)) return false;
return (this == (RC_b2eeb8f69cd26079c0c421f6fd8d6d1f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRegisteredCallbackEvents.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRegisteredCallbackEvents.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRegisteredCallbackEvents.InternalRecursiveSave();
}


public RC_b2eeb8f69cd26079c0c421f6fd8d6d1f Duplicate() {
RC_b2eeb8f69cd26079c0c421f6fd8d6d1f t;
t.ssENRegisteredCallbackEvents = (EN_df70a614ae02fde4029645a728b2909cEntityRecord)this.ssENRegisteredCallbackEvents.Duplicate();
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
if (head == "registeredcallbackevents") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegisteredCallbackEvents")) variable.Value = ssENRegisteredCallbackEvents; else variable.Optimized = true;
variable.SetFieldName("registeredcallbackevents");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRegisteredCallbackEvents.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRegisteredCallbackEvents.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRegisteredCallbackEvents) {
return ssENRegisteredCallbackEvents;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRegisteredCallbackEvents.Key.AsGuid) {
return ssENRegisteredCallbackEvents;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRegisteredCallbackEvents.FillFromOther((IRecord) other.AttributeGet(IdRegisteredCallbackEvents));
}
} // RC_b2eeb8f69cd26079c0c421f6fd8d6d1f
/// <summary>
/// RecordList type <code>RegisteredCallbackEventsRecordList</code> that represents a record list of
///  <code>RegisteredCallbackEvents</code>
/// </summary>
public partial class RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 : GenericRecordList<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b2eeb8f69cd26079c0c421f6fd8d6d1f GetElementDefaultValue() {
return new RC_b2eeb8f69cd26079c0c421f6fd8d6d1f();
}

public T[] ToArray<T>(Func<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 recordList, Func<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87(RC_b2eeb8f69cd26079c0c421f6fd8d6d1f[] array) {
  RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 result = new RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87();
result.InnerFromArray(array);
    return result;
}

public static RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 ToList<T>(T[] array, Func <T, RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> converter) {
  RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 result = new RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 FromRestList<T>(RestList<T> restList, Func <T, RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> converter) {
  RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87 result = new RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87() : base() {
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
protected override OSList<RC_b2eeb8f69cd26079c0c421f6fd8d6d1f> NewList() {
return new RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87();
}


} // RL_6ee4774b8ebf7f4bd9b3c05eedd6dd87
}

