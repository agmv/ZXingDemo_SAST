namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (T5jYoUBeYESUTnwx6BKGPA)
///  <code>RC_ba003b5de3d2da83898f81e428002fdb</code> that represent
/// s <code>OptionalCircleConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalCircleConfigsRecord
public partial struct RC_ba003b5de3d2da83898f81e428002fdb : ITypedRecord<RC_ba003b5de3d2da83898f81e428002fdb> {
internal static readonly GlobalObjectKey IdOptionalCircleConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XTsAutLjg9qJj4HkKAAv2w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalCircleConfigs")]
public ST_9a87c036f8540c84242b92bb54609014Structure ssSTOptionalCircleConfigs;


public static implicit operator ST_9a87c036f8540c84242b92bb54609014Structure( RC_ba003b5de3d2da83898f81e428002fdb r) {
return r.ssSTOptionalCircleConfigs;
}

public static implicit operator RC_ba003b5de3d2da83898f81e428002fdb (ST_9a87c036f8540c84242b92bb54609014Structure r) {
RC_ba003b5de3d2da83898f81e428002fdb res = new RC_ba003b5de3d2da83898f81e428002fdb ();
res.ssSTOptionalCircleConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ba003b5de3d2da83898f81e428002fdb() {
OptimizedAttributes = null;
ssSTOptionalCircleConfigs = new ST_9a87c036f8540c84242b92bb54609014Structure();
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
    ssSTOptionalCircleConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalCircleConfigs.Read( r, ref index);
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
public void ReadIM(RC_ba003b5de3d2da83898f81e428002fdb r) {
this = r;
}


public static bool operator == (RC_ba003b5de3d2da83898f81e428002fdb a, RC_ba003b5de3d2da83898f81e428002fdb b) {
if (a.ssSTOptionalCircleConfigs != b.ssSTOptionalCircleConfigs) return false;
return true;
}

public static bool operator != (RC_ba003b5de3d2da83898f81e428002fdb a, RC_ba003b5de3d2da83898f81e428002fdb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ba003b5de3d2da83898f81e428002fdb)) return false;
return (this == (RC_ba003b5de3d2da83898f81e428002fdb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalCircleConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalCircleConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalCircleConfigs.InternalRecursiveSave();
}


public RC_ba003b5de3d2da83898f81e428002fdb Duplicate() {
RC_ba003b5de3d2da83898f81e428002fdb t;
t.ssSTOptionalCircleConfigs = (ST_9a87c036f8540c84242b92bb54609014Structure)this.ssSTOptionalCircleConfigs.Duplicate();
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
if (head == "optionalcircleconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalCircleConfigs")) variable.Value = ssSTOptionalCircleConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalcircleconfigs");
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
if (key == IdOptionalCircleConfigs) {
return ssSTOptionalCircleConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalCircleConfigs.Key.AsGuid) {
return ssSTOptionalCircleConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalCircleConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalCircleConfigs));
}
} // RC_ba003b5de3d2da83898f81e428002fdb
/// <summary>
/// RecordList type <code>OptionalCircleConfigsRecordList</code> that represents a record list of
///  <code>OptionalCircleConfigs</code>
/// </summary>
public partial class RL_d8d4258d680fd287c9ccf9006eaca84a : GenericRecordList<RC_ba003b5de3d2da83898f81e428002fdb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_ba003b5de3d2da83898f81e428002fdb GetElementDefaultValue() {
return new RC_ba003b5de3d2da83898f81e428002fdb();
}

public T[] ToArray<T>(Func<RC_ba003b5de3d2da83898f81e428002fdb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8d4258d680fd287c9ccf9006eaca84a recordList, Func<RC_ba003b5de3d2da83898f81e428002fdb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8d4258d680fd287c9ccf9006eaca84a(RC_ba003b5de3d2da83898f81e428002fdb[] array) {
  RL_d8d4258d680fd287c9ccf9006eaca84a result = new RL_d8d4258d680fd287c9ccf9006eaca84a();
result.InnerFromArray(array);
    return result;
}

public static RL_d8d4258d680fd287c9ccf9006eaca84a ToList<T>(T[] array, Func <T, RC_ba003b5de3d2da83898f81e428002fdb> converter) {
  RL_d8d4258d680fd287c9ccf9006eaca84a result = new RL_d8d4258d680fd287c9ccf9006eaca84a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8d4258d680fd287c9ccf9006eaca84a FromRestList<T>(RestList<T> restList, Func <T, RC_ba003b5de3d2da83898f81e428002fdb> converter) {
  RL_d8d4258d680fd287c9ccf9006eaca84a result = new RL_d8d4258d680fd287c9ccf9006eaca84a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8d4258d680fd287c9ccf9006eaca84a() : base() {
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
protected override OSList<RC_ba003b5de3d2da83898f81e428002fdb> NewList() {
return new RL_d8d4258d680fd287c9ccf9006eaca84a();
}


} // RL_d8d4258d680fd287c9ccf9006eaca84a
}

