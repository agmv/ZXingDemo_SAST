namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (OhoKuW9NsUewx28qLHyJ5w)
///  <code>RC_28b5debce9c04e64c6dd40275449bf6c</code> that represent
/// s <code>SearchPlacesErrorsRecord</code> <p>Description: </p>
/// </summary>
// Name: SearchPlacesErrorsRecord
public partial struct RC_28b5debce9c04e64c6dd40275449bf6c : ITypedRecord<RC_28b5debce9c04e64c6dd40275449bf6c> {
internal static readonly GlobalObjectKey IdSearchPlacesErrors = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vN61KMDpZE7G3UAnVEm_bA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SearchPlacesErrors")]
public EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord ssENSearchPlacesErrors;


public static implicit operator EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord( RC_28b5debce9c04e64c6dd40275449bf6c r) {
return r.ssENSearchPlacesErrors;
}

public static implicit operator RC_28b5debce9c04e64c6dd40275449bf6c (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord r) {
RC_28b5debce9c04e64c6dd40275449bf6c res = new RC_28b5debce9c04e64c6dd40275449bf6c ();
res.ssENSearchPlacesErrors = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSearchPlacesErrors.ChangedAttributes = value;
}
get {
    return ssENSearchPlacesErrors.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_28b5debce9c04e64c6dd40275449bf6c() {
OptimizedAttributes = null;
ssENSearchPlacesErrors = new EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSearchPlacesErrors.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSearchPlacesErrors.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSearchPlacesErrors.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSearchPlacesErrors.Read( r, ref index);
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
public void ReadIM(RC_28b5debce9c04e64c6dd40275449bf6c r) {
this = r;
}


public static bool operator == (RC_28b5debce9c04e64c6dd40275449bf6c a, RC_28b5debce9c04e64c6dd40275449bf6c b) {
if (a.ssENSearchPlacesErrors != b.ssENSearchPlacesErrors) return false;
return true;
}

public static bool operator != (RC_28b5debce9c04e64c6dd40275449bf6c a, RC_28b5debce9c04e64c6dd40275449bf6c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_28b5debce9c04e64c6dd40275449bf6c)) return false;
return (this == (RC_28b5debce9c04e64c6dd40275449bf6c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSearchPlacesErrors.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSearchPlacesErrors.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSearchPlacesErrors.InternalRecursiveSave();
}


public RC_28b5debce9c04e64c6dd40275449bf6c Duplicate() {
RC_28b5debce9c04e64c6dd40275449bf6c t;
t.ssENSearchPlacesErrors = (EN_ddceb9a0506316e12e8b49777be81ba4EntityRecord)this.ssENSearchPlacesErrors.Duplicate();
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
if (head == "searchplaceserrors") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchPlacesErrors")) variable.Value = ssENSearchPlacesErrors; else variable.Optimized = true;
variable.SetFieldName("searchplaceserrors");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSearchPlacesErrors.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSearchPlacesErrors.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSearchPlacesErrors) {
return ssENSearchPlacesErrors;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSearchPlacesErrors.Key.AsGuid) {
return ssENSearchPlacesErrors;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSearchPlacesErrors.FillFromOther((IRecord) other.AttributeGet(IdSearchPlacesErrors));
}
} // RC_28b5debce9c04e64c6dd40275449bf6c
/// <summary>
/// RecordList type <code>SearchPlacesErrorsRecordList</code> that represents a record list of
///  <code>SearchPlacesErrors</code>
/// </summary>
public partial class RL_3d15fde051d0f445d11317bbc8751458 : GenericRecordList<RC_28b5debce9c04e64c6dd40275449bf6c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_28b5debce9c04e64c6dd40275449bf6c GetElementDefaultValue() {
return new RC_28b5debce9c04e64c6dd40275449bf6c();
}

public T[] ToArray<T>(Func<RC_28b5debce9c04e64c6dd40275449bf6c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d15fde051d0f445d11317bbc8751458 recordList, Func<RC_28b5debce9c04e64c6dd40275449bf6c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d15fde051d0f445d11317bbc8751458(RC_28b5debce9c04e64c6dd40275449bf6c[] array) {
  RL_3d15fde051d0f445d11317bbc8751458 result = new RL_3d15fde051d0f445d11317bbc8751458();
result.InnerFromArray(array);
    return result;
}

public static RL_3d15fde051d0f445d11317bbc8751458 ToList<T>(T[] array, Func <T, RC_28b5debce9c04e64c6dd40275449bf6c> converter) {
  RL_3d15fde051d0f445d11317bbc8751458 result = new RL_3d15fde051d0f445d11317bbc8751458();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d15fde051d0f445d11317bbc8751458 FromRestList<T>(RestList<T> restList, Func <T, RC_28b5debce9c04e64c6dd40275449bf6c> converter) {
  RL_3d15fde051d0f445d11317bbc8751458 result = new RL_3d15fde051d0f445d11317bbc8751458();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d15fde051d0f445d11317bbc8751458() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_28b5debce9c04e64c6dd40275449bf6c> NewList() {
return new RL_3d15fde051d0f445d11317bbc8751458();
}


} // RL_3d15fde051d0f445d11317bbc8751458
}

