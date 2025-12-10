namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (l5ae+XI_YUCq6aVp5fAd7Q)
///  <code>RC_9ca6a18cc49ca7246c44c0f7c2cef62a</code> that represents <code>AlertRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AlertRecord
public partial struct RC_9ca6a18cc49ca7246c44c0f7c2cef62a : ITypedRecord<RC_9ca6a18cc49ca7246c44c0f7c2cef62a> {
internal static readonly GlobalObjectKey IdAlert = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jKGmnJzEJKdsRMD3ws72Kg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Alert")]
public EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord ssENAlert;


public static implicit operator EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord( RC_9ca6a18cc49ca7246c44c0f7c2cef62a r) {
return r.ssENAlert;
}

public static implicit operator RC_9ca6a18cc49ca7246c44c0f7c2cef62a (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord r) {
RC_9ca6a18cc49ca7246c44c0f7c2cef62a res = new RC_9ca6a18cc49ca7246c44c0f7c2cef62a ();
res.ssENAlert = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAlert.ChangedAttributes = value;
}
get {
    return ssENAlert.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_9ca6a18cc49ca7246c44c0f7c2cef62a() {
OptimizedAttributes = null;
ssENAlert = new EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAlert.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAlert.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAlert.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAlert.Read( r, ref index);
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
public void ReadIM(RC_9ca6a18cc49ca7246c44c0f7c2cef62a r) {
this = r;
}


public static bool operator == (RC_9ca6a18cc49ca7246c44c0f7c2cef62a a, RC_9ca6a18cc49ca7246c44c0f7c2cef62a b) {
if (a.ssENAlert != b.ssENAlert) return false;
return true;
}

public static bool operator != (RC_9ca6a18cc49ca7246c44c0f7c2cef62a a, RC_9ca6a18cc49ca7246c44c0f7c2cef62a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9ca6a18cc49ca7246c44c0f7c2cef62a)) return false;
return (this == (RC_9ca6a18cc49ca7246c44c0f7c2cef62a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAlert.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAlert.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAlert.InternalRecursiveSave();
}


public RC_9ca6a18cc49ca7246c44c0f7c2cef62a Duplicate() {
RC_9ca6a18cc49ca7246c44c0f7c2cef62a t;
t.ssENAlert = (EN_adf11bcbc411b5a0f498d25dd0ea882fEntityRecord)this.ssENAlert.Duplicate();
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
if (head == "alert") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Alert")) variable.Value = ssENAlert; else variable.Optimized = true;
variable.SetFieldName("alert");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAlert.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAlert.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAlert) {
return ssENAlert;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAlert.Key.AsGuid) {
return ssENAlert;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAlert.FillFromOther((IRecord) other.AttributeGet(IdAlert));
}
} // RC_9ca6a18cc49ca7246c44c0f7c2cef62a
/// <summary>
/// RecordList type <code>AlertRecordList</code> that represents a record list of <code>Alert</code>
/// </summary>
public partial class RL_f51d1b2f3972179080ca5027bc7c8f43 : GenericRecordList<RC_9ca6a18cc49ca7246c44c0f7c2cef62a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_9ca6a18cc49ca7246c44c0f7c2cef62a GetElementDefaultValue() {
return new RC_9ca6a18cc49ca7246c44c0f7c2cef62a();
}

public T[] ToArray<T>(Func<RC_9ca6a18cc49ca7246c44c0f7c2cef62a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f51d1b2f3972179080ca5027bc7c8f43 recordList, Func<RC_9ca6a18cc49ca7246c44c0f7c2cef62a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f51d1b2f3972179080ca5027bc7c8f43(RC_9ca6a18cc49ca7246c44c0f7c2cef62a[] array) {
  RL_f51d1b2f3972179080ca5027bc7c8f43 result = new RL_f51d1b2f3972179080ca5027bc7c8f43();
result.InnerFromArray(array);
    return result;
}

public static RL_f51d1b2f3972179080ca5027bc7c8f43 ToList<T>(T[] array, Func <T, RC_9ca6a18cc49ca7246c44c0f7c2cef62a> converter) {
  RL_f51d1b2f3972179080ca5027bc7c8f43 result = new RL_f51d1b2f3972179080ca5027bc7c8f43();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f51d1b2f3972179080ca5027bc7c8f43 FromRestList<T>(RestList<T> restList, Func <T, RC_9ca6a18cc49ca7246c44c0f7c2cef62a> converter) {
  RL_f51d1b2f3972179080ca5027bc7c8f43 result = new RL_f51d1b2f3972179080ca5027bc7c8f43();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f51d1b2f3972179080ca5027bc7c8f43() : base() {
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
protected override OSList<RC_9ca6a18cc49ca7246c44c0f7c2cef62a> NewList() {
return new RL_f51d1b2f3972179080ca5027bc7c8f43();
}


} // RL_f51d1b2f3972179080ca5027bc7c8f43
}

