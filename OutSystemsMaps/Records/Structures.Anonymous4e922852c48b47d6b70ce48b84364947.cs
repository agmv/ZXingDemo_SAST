namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (UiiSTovE1ke3DOSLhDZJRw)
///  <code>RC_f1764d7c40e4f0543f1781c01f8cbcf5</code> that represent
/// s <code>SearchPlacesEventRecord</code> <p>Description: </p>
/// </summary>
// Name: SearchPlacesEventRecord
public partial struct RC_f1764d7c40e4f0543f1781c01f8cbcf5 : ITypedRecord<RC_f1764d7c40e4f0543f1781c01f8cbcf5> {
internal static readonly GlobalObjectKey IdSearchPlacesEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fE128eRAVPA_F4HAH4y89Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SearchPlacesEvent")]
public EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord ssENSearchPlacesEvent;


public static implicit operator EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord( RC_f1764d7c40e4f0543f1781c01f8cbcf5 r) {
return r.ssENSearchPlacesEvent;
}

public static implicit operator RC_f1764d7c40e4f0543f1781c01f8cbcf5 (EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord r) {
RC_f1764d7c40e4f0543f1781c01f8cbcf5 res = new RC_f1764d7c40e4f0543f1781c01f8cbcf5 ();
res.ssENSearchPlacesEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSearchPlacesEvent.ChangedAttributes = value;
}
get {
    return ssENSearchPlacesEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f1764d7c40e4f0543f1781c01f8cbcf5() {
OptimizedAttributes = null;
ssENSearchPlacesEvent = new EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSearchPlacesEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSearchPlacesEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSearchPlacesEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSearchPlacesEvent.Read( r, ref index);
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
public void ReadIM(RC_f1764d7c40e4f0543f1781c01f8cbcf5 r) {
this = r;
}


public static bool operator == (RC_f1764d7c40e4f0543f1781c01f8cbcf5 a, RC_f1764d7c40e4f0543f1781c01f8cbcf5 b) {
if (a.ssENSearchPlacesEvent != b.ssENSearchPlacesEvent) return false;
return true;
}

public static bool operator != (RC_f1764d7c40e4f0543f1781c01f8cbcf5 a, RC_f1764d7c40e4f0543f1781c01f8cbcf5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f1764d7c40e4f0543f1781c01f8cbcf5)) return false;
return (this == (RC_f1764d7c40e4f0543f1781c01f8cbcf5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSearchPlacesEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSearchPlacesEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSearchPlacesEvent.InternalRecursiveSave();
}


public RC_f1764d7c40e4f0543f1781c01f8cbcf5 Duplicate() {
RC_f1764d7c40e4f0543f1781c01f8cbcf5 t;
t.ssENSearchPlacesEvent = (EN_8fe01ec881aca02efe3d0db98080a5e2EntityRecord)this.ssENSearchPlacesEvent.Duplicate();
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
if (head == "searchplacesevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchPlacesEvent")) variable.Value = ssENSearchPlacesEvent; else variable.Optimized = true;
variable.SetFieldName("searchplacesevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSearchPlacesEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSearchPlacesEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSearchPlacesEvent) {
return ssENSearchPlacesEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSearchPlacesEvent.Key.AsGuid) {
return ssENSearchPlacesEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSearchPlacesEvent.FillFromOther((IRecord) other.AttributeGet(IdSearchPlacesEvent));
}
} // RC_f1764d7c40e4f0543f1781c01f8cbcf5
/// <summary>
/// RecordList type <code>SearchPlacesEventRecordList</code> that represents a record list of
///  <code>SearchPlacesEvent</code>
/// </summary>
public partial class RL_9521475d97508001d029535eefb032a9 : GenericRecordList<RC_f1764d7c40e4f0543f1781c01f8cbcf5>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f1764d7c40e4f0543f1781c01f8cbcf5 GetElementDefaultValue() {
return new RC_f1764d7c40e4f0543f1781c01f8cbcf5();
}

public T[] ToArray<T>(Func<RC_f1764d7c40e4f0543f1781c01f8cbcf5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9521475d97508001d029535eefb032a9 recordList, Func<RC_f1764d7c40e4f0543f1781c01f8cbcf5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9521475d97508001d029535eefb032a9(RC_f1764d7c40e4f0543f1781c01f8cbcf5[] array) {
  RL_9521475d97508001d029535eefb032a9 result = new RL_9521475d97508001d029535eefb032a9();
result.InnerFromArray(array);
    return result;
}

public static RL_9521475d97508001d029535eefb032a9 ToList<T>(T[] array, Func <T, RC_f1764d7c40e4f0543f1781c01f8cbcf5> converter) {
  RL_9521475d97508001d029535eefb032a9 result = new RL_9521475d97508001d029535eefb032a9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9521475d97508001d029535eefb032a9 FromRestList<T>(RestList<T> restList, Func <T, RC_f1764d7c40e4f0543f1781c01f8cbcf5> converter) {
  RL_9521475d97508001d029535eefb032a9 result = new RL_9521475d97508001d029535eefb032a9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9521475d97508001d029535eefb032a9() : base() {
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
protected override OSList<RC_f1764d7c40e4f0543f1781c01f8cbcf5> NewList() {
return new RL_9521475d97508001d029535eefb032a9();
}


} // RL_9521475d97508001d029535eefb032a9
}

