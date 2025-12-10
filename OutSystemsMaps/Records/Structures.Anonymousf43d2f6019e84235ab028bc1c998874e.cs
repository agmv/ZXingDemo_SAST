namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (YC899OgZNUKrAovByZiHTg)
///  <code>RC_227974ef92f7b64b18b95570fef9abe3</code> that represents <code>MapEventRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MapEventRecord
public partial struct RC_227974ef92f7b64b18b95570fef9abe3 : ITypedRecord<RC_227974ef92f7b64b18b95570fef9abe3> {
internal static readonly GlobalObjectKey IdMapEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*73R5IveSS7YYuVVw_vmr4w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MapEvent")]
public EN_e5ca0002e0338a827923cc311de3f95cEntityRecord ssENMapEvent;


public static implicit operator EN_e5ca0002e0338a827923cc311de3f95cEntityRecord( RC_227974ef92f7b64b18b95570fef9abe3 r) {
return r.ssENMapEvent;
}

public static implicit operator RC_227974ef92f7b64b18b95570fef9abe3 (EN_e5ca0002e0338a827923cc311de3f95cEntityRecord r) {
RC_227974ef92f7b64b18b95570fef9abe3 res = new RC_227974ef92f7b64b18b95570fef9abe3 ();
res.ssENMapEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMapEvent.ChangedAttributes = value;
}
get {
    return ssENMapEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_227974ef92f7b64b18b95570fef9abe3() {
OptimizedAttributes = null;
ssENMapEvent = new EN_e5ca0002e0338a827923cc311de3f95cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMapEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMapEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMapEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMapEvent.Read( r, ref index);
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
public void ReadIM(RC_227974ef92f7b64b18b95570fef9abe3 r) {
this = r;
}


public static bool operator == (RC_227974ef92f7b64b18b95570fef9abe3 a, RC_227974ef92f7b64b18b95570fef9abe3 b) {
if (a.ssENMapEvent != b.ssENMapEvent) return false;
return true;
}

public static bool operator != (RC_227974ef92f7b64b18b95570fef9abe3 a, RC_227974ef92f7b64b18b95570fef9abe3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_227974ef92f7b64b18b95570fef9abe3)) return false;
return (this == (RC_227974ef92f7b64b18b95570fef9abe3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMapEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMapEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMapEvent.InternalRecursiveSave();
}


public RC_227974ef92f7b64b18b95570fef9abe3 Duplicate() {
RC_227974ef92f7b64b18b95570fef9abe3 t;
t.ssENMapEvent = (EN_e5ca0002e0338a827923cc311de3f95cEntityRecord)this.ssENMapEvent.Duplicate();
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
if (head == "mapevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MapEvent")) variable.Value = ssENMapEvent; else variable.Optimized = true;
variable.SetFieldName("mapevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMapEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMapEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMapEvent) {
return ssENMapEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMapEvent.Key.AsGuid) {
return ssENMapEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMapEvent.FillFromOther((IRecord) other.AttributeGet(IdMapEvent));
}
} // RC_227974ef92f7b64b18b95570fef9abe3
/// <summary>
/// RecordList type <code>MapEventRecordList</code> that represents a record list of
///  <code>MapEvent</code>
/// </summary>
public partial class RL_f220b279cf20ca20ab24e3c41cf84e9a : GenericRecordList<RC_227974ef92f7b64b18b95570fef9abe3>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_227974ef92f7b64b18b95570fef9abe3 GetElementDefaultValue() {
return new RC_227974ef92f7b64b18b95570fef9abe3();
}

public T[] ToArray<T>(Func<RC_227974ef92f7b64b18b95570fef9abe3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f220b279cf20ca20ab24e3c41cf84e9a recordList, Func<RC_227974ef92f7b64b18b95570fef9abe3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f220b279cf20ca20ab24e3c41cf84e9a(RC_227974ef92f7b64b18b95570fef9abe3[] array) {
  RL_f220b279cf20ca20ab24e3c41cf84e9a result = new RL_f220b279cf20ca20ab24e3c41cf84e9a();
result.InnerFromArray(array);
    return result;
}

public static RL_f220b279cf20ca20ab24e3c41cf84e9a ToList<T>(T[] array, Func <T, RC_227974ef92f7b64b18b95570fef9abe3> converter) {
  RL_f220b279cf20ca20ab24e3c41cf84e9a result = new RL_f220b279cf20ca20ab24e3c41cf84e9a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f220b279cf20ca20ab24e3c41cf84e9a FromRestList<T>(RestList<T> restList, Func <T, RC_227974ef92f7b64b18b95570fef9abe3> converter) {
  RL_f220b279cf20ca20ab24e3c41cf84e9a result = new RL_f220b279cf20ca20ab24e3c41cf84e9a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f220b279cf20ca20ab24e3c41cf84e9a() : base() {
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
protected override OSList<RC_227974ef92f7b64b18b95570fef9abe3> NewList() {
return new RL_f220b279cf20ca20ab24e3c41cf84e9a();
}


} // RL_f220b279cf20ca20ab24e3c41cf84e9a
}

