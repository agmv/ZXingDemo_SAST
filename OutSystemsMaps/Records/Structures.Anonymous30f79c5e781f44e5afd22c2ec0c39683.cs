namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Xpz3MB945USv0iwuwMOWgw)
///  <code>RC_d18425d8035234c443ecbdefa0da8210</code> that represent
/// s <code>MarkerEventTriggeredRecord</code> <p>Description: </p>
/// </summary>
// Name: MarkerEventTriggeredRecord
public partial struct RC_d18425d8035234c443ecbdefa0da8210 : ITypedRecord<RC_d18425d8035234c443ecbdefa0da8210> {
internal static readonly GlobalObjectKey IdMarkerEventTriggered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2CWE0VIDxDRD7L3voNqCEA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MarkerEventTriggered")]
public EN_d9c97e718205f8627d74b06df54e3543EntityRecord ssENMarkerEventTriggered;


public static implicit operator EN_d9c97e718205f8627d74b06df54e3543EntityRecord( RC_d18425d8035234c443ecbdefa0da8210 r) {
return r.ssENMarkerEventTriggered;
}

public static implicit operator RC_d18425d8035234c443ecbdefa0da8210 (EN_d9c97e718205f8627d74b06df54e3543EntityRecord r) {
RC_d18425d8035234c443ecbdefa0da8210 res = new RC_d18425d8035234c443ecbdefa0da8210 ();
res.ssENMarkerEventTriggered = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMarkerEventTriggered.ChangedAttributes = value;
}
get {
    return ssENMarkerEventTriggered.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d18425d8035234c443ecbdefa0da8210() {
OptimizedAttributes = null;
ssENMarkerEventTriggered = new EN_d9c97e718205f8627d74b06df54e3543EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMarkerEventTriggered.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMarkerEventTriggered.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMarkerEventTriggered.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMarkerEventTriggered.Read( r, ref index);
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
public void ReadIM(RC_d18425d8035234c443ecbdefa0da8210 r) {
this = r;
}


public static bool operator == (RC_d18425d8035234c443ecbdefa0da8210 a, RC_d18425d8035234c443ecbdefa0da8210 b) {
if (a.ssENMarkerEventTriggered != b.ssENMarkerEventTriggered) return false;
return true;
}

public static bool operator != (RC_d18425d8035234c443ecbdefa0da8210 a, RC_d18425d8035234c443ecbdefa0da8210 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d18425d8035234c443ecbdefa0da8210)) return false;
return (this == (RC_d18425d8035234c443ecbdefa0da8210)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMarkerEventTriggered.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMarkerEventTriggered.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMarkerEventTriggered.InternalRecursiveSave();
}


public RC_d18425d8035234c443ecbdefa0da8210 Duplicate() {
RC_d18425d8035234c443ecbdefa0da8210 t;
t.ssENMarkerEventTriggered = (EN_d9c97e718205f8627d74b06df54e3543EntityRecord)this.ssENMarkerEventTriggered.Duplicate();
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
if (head == "markereventtriggered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkerEventTriggered")) variable.Value = ssENMarkerEventTriggered; else variable.Optimized = true;
variable.SetFieldName("markereventtriggered");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMarkerEventTriggered.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMarkerEventTriggered.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMarkerEventTriggered) {
return ssENMarkerEventTriggered;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMarkerEventTriggered.Key.AsGuid) {
return ssENMarkerEventTriggered;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMarkerEventTriggered.FillFromOther((IRecord) other.AttributeGet(IdMarkerEventTriggered));
}
} // RC_d18425d8035234c443ecbdefa0da8210
/// <summary>
/// RecordList type <code>MarkerEventTriggeredRecordList</code> that represents a record list of
///  <code>MarkerEventTriggered</code>
/// </summary>
public partial class RL_768ac2f95f2438d51b1f08cac04338dd : GenericRecordList<RC_d18425d8035234c443ecbdefa0da8210>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d18425d8035234c443ecbdefa0da8210 GetElementDefaultValue() {
return new RC_d18425d8035234c443ecbdefa0da8210();
}

public T[] ToArray<T>(Func<RC_d18425d8035234c443ecbdefa0da8210, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_768ac2f95f2438d51b1f08cac04338dd recordList, Func<RC_d18425d8035234c443ecbdefa0da8210, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_768ac2f95f2438d51b1f08cac04338dd(RC_d18425d8035234c443ecbdefa0da8210[] array) {
  RL_768ac2f95f2438d51b1f08cac04338dd result = new RL_768ac2f95f2438d51b1f08cac04338dd();
result.InnerFromArray(array);
    return result;
}

public static RL_768ac2f95f2438d51b1f08cac04338dd ToList<T>(T[] array, Func <T, RC_d18425d8035234c443ecbdefa0da8210> converter) {
  RL_768ac2f95f2438d51b1f08cac04338dd result = new RL_768ac2f95f2438d51b1f08cac04338dd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_768ac2f95f2438d51b1f08cac04338dd FromRestList<T>(RestList<T> restList, Func <T, RC_d18425d8035234c443ecbdefa0da8210> converter) {
  RL_768ac2f95f2438d51b1f08cac04338dd result = new RL_768ac2f95f2438d51b1f08cac04338dd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_768ac2f95f2438d51b1f08cac04338dd() : base() {
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
protected override OSList<RC_d18425d8035234c443ecbdefa0da8210> NewList() {
return new RL_768ac2f95f2438d51b1f08cac04338dd();
}


} // RL_768ac2f95f2438d51b1f08cac04338dd
}

