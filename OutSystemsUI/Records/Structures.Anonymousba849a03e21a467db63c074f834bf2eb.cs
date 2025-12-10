namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (A5qEuhrifUa2PAdPg0vy6w)
///  <code>RC_78b6d6ed7d52800a8a68e7d796ec6850</code> that represents <code>AnimationTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AnimationTypeRecord
public partial struct RC_78b6d6ed7d52800a8a68e7d796ec6850 : ITypedRecord<RC_78b6d6ed7d52800a8a68e7d796ec6850> {
internal static readonly GlobalObjectKey IdAnimationType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7da2eFJ9CoCKaOfXluxoUA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AnimationType")]
public EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord ssENAnimationType;


public static implicit operator EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord( RC_78b6d6ed7d52800a8a68e7d796ec6850 r) {
return r.ssENAnimationType;
}

public static implicit operator RC_78b6d6ed7d52800a8a68e7d796ec6850 (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord r) {
RC_78b6d6ed7d52800a8a68e7d796ec6850 res = new RC_78b6d6ed7d52800a8a68e7d796ec6850 ();
res.ssENAnimationType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAnimationType.ChangedAttributes = value;
}
get {
    return ssENAnimationType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_78b6d6ed7d52800a8a68e7d796ec6850() {
OptimizedAttributes = null;
ssENAnimationType = new EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAnimationType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAnimationType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAnimationType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAnimationType.Read( r, ref index);
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
public void ReadIM(RC_78b6d6ed7d52800a8a68e7d796ec6850 r) {
this = r;
}


public static bool operator == (RC_78b6d6ed7d52800a8a68e7d796ec6850 a, RC_78b6d6ed7d52800a8a68e7d796ec6850 b) {
if (a.ssENAnimationType != b.ssENAnimationType) return false;
return true;
}

public static bool operator != (RC_78b6d6ed7d52800a8a68e7d796ec6850 a, RC_78b6d6ed7d52800a8a68e7d796ec6850 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_78b6d6ed7d52800a8a68e7d796ec6850)) return false;
return (this == (RC_78b6d6ed7d52800a8a68e7d796ec6850)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAnimationType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAnimationType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAnimationType.InternalRecursiveSave();
}


public RC_78b6d6ed7d52800a8a68e7d796ec6850 Duplicate() {
RC_78b6d6ed7d52800a8a68e7d796ec6850 t;
t.ssENAnimationType = (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord)this.ssENAnimationType.Duplicate();
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
if (head == "animationtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AnimationType")) variable.Value = ssENAnimationType; else variable.Optimized = true;
variable.SetFieldName("animationtype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAnimationType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAnimationType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAnimationType) {
return ssENAnimationType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAnimationType.Key.AsGuid) {
return ssENAnimationType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAnimationType.FillFromOther((IRecord) other.AttributeGet(IdAnimationType));
}
} // RC_78b6d6ed7d52800a8a68e7d796ec6850
/// <summary>
/// RecordList type <code>AnimationTypeRecordList</code> that represents a record list of
///  <code>AnimationType</code>
/// </summary>
public partial class RL_13dce2cada552f2b003eedebc4cfbf64 : GenericRecordList<RC_78b6d6ed7d52800a8a68e7d796ec6850>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_78b6d6ed7d52800a8a68e7d796ec6850 GetElementDefaultValue() {
return new RC_78b6d6ed7d52800a8a68e7d796ec6850();
}

public T[] ToArray<T>(Func<RC_78b6d6ed7d52800a8a68e7d796ec6850, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_13dce2cada552f2b003eedebc4cfbf64 recordList, Func<RC_78b6d6ed7d52800a8a68e7d796ec6850, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_13dce2cada552f2b003eedebc4cfbf64(RC_78b6d6ed7d52800a8a68e7d796ec6850[] array) {
  RL_13dce2cada552f2b003eedebc4cfbf64 result = new RL_13dce2cada552f2b003eedebc4cfbf64();
result.InnerFromArray(array);
    return result;
}

public static RL_13dce2cada552f2b003eedebc4cfbf64 ToList<T>(T[] array, Func <T, RC_78b6d6ed7d52800a8a68e7d796ec6850> converter) {
  RL_13dce2cada552f2b003eedebc4cfbf64 result = new RL_13dce2cada552f2b003eedebc4cfbf64();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_13dce2cada552f2b003eedebc4cfbf64 FromRestList<T>(RestList<T> restList, Func <T, RC_78b6d6ed7d52800a8a68e7d796ec6850> converter) {
  RL_13dce2cada552f2b003eedebc4cfbf64 result = new RL_13dce2cada552f2b003eedebc4cfbf64();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_13dce2cada552f2b003eedebc4cfbf64() : base() {
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
protected override OSList<RC_78b6d6ed7d52800a8a68e7d796ec6850> NewList() {
return new RL_13dce2cada552f2b003eedebc4cfbf64();
}


} // RL_13dce2cada552f2b003eedebc4cfbf64
}

