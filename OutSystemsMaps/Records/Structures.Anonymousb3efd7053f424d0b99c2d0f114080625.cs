namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Bdfvs0I_C02ZwtDxFAgGJQ)
///  <code>RC_dc7b093401bf134dc8399c003cfc6bc0</code> that represents <code>FileLayerEventRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FileLayerEventRecord
public partial struct RC_dc7b093401bf134dc8399c003cfc6bc0 : ITypedRecord<RC_dc7b093401bf134dc8399c003cfc6bc0> {
internal static readonly GlobalObjectKey IdFileLayerEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NAl73L8BTRPIOZwAPPxrwA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FileLayerEvent")]
public EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord ssENFileLayerEvent;


public static implicit operator EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord( RC_dc7b093401bf134dc8399c003cfc6bc0 r) {
return r.ssENFileLayerEvent;
}

public static implicit operator RC_dc7b093401bf134dc8399c003cfc6bc0 (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord r) {
RC_dc7b093401bf134dc8399c003cfc6bc0 res = new RC_dc7b093401bf134dc8399c003cfc6bc0 ();
res.ssENFileLayerEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFileLayerEvent.ChangedAttributes = value;
}
get {
    return ssENFileLayerEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_dc7b093401bf134dc8399c003cfc6bc0() {
OptimizedAttributes = null;
ssENFileLayerEvent = new EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFileLayerEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFileLayerEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFileLayerEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFileLayerEvent.Read( r, ref index);
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
public void ReadIM(RC_dc7b093401bf134dc8399c003cfc6bc0 r) {
this = r;
}


public static bool operator == (RC_dc7b093401bf134dc8399c003cfc6bc0 a, RC_dc7b093401bf134dc8399c003cfc6bc0 b) {
if (a.ssENFileLayerEvent != b.ssENFileLayerEvent) return false;
return true;
}

public static bool operator != (RC_dc7b093401bf134dc8399c003cfc6bc0 a, RC_dc7b093401bf134dc8399c003cfc6bc0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dc7b093401bf134dc8399c003cfc6bc0)) return false;
return (this == (RC_dc7b093401bf134dc8399c003cfc6bc0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFileLayerEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFileLayerEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFileLayerEvent.InternalRecursiveSave();
}


public RC_dc7b093401bf134dc8399c003cfc6bc0 Duplicate() {
RC_dc7b093401bf134dc8399c003cfc6bc0 t;
t.ssENFileLayerEvent = (EN_03e1c2ea04d7f49cbc09fc7d6f681f53EntityRecord)this.ssENFileLayerEvent.Duplicate();
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
if (head == "filelayerevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileLayerEvent")) variable.Value = ssENFileLayerEvent; else variable.Optimized = true;
variable.SetFieldName("filelayerevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFileLayerEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFileLayerEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFileLayerEvent) {
return ssENFileLayerEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileLayerEvent.Key.AsGuid) {
return ssENFileLayerEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFileLayerEvent.FillFromOther((IRecord) other.AttributeGet(IdFileLayerEvent));
}
} // RC_dc7b093401bf134dc8399c003cfc6bc0
/// <summary>
/// RecordList type <code>FileLayerEventRecordList</code> that represents a record list of
///  <code>FileLayerEvent</code>
/// </summary>
public partial class RL_86fbed1618008cdc1ffb40212b2c9089 : GenericRecordList<RC_dc7b093401bf134dc8399c003cfc6bc0>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_dc7b093401bf134dc8399c003cfc6bc0 GetElementDefaultValue() {
return new RC_dc7b093401bf134dc8399c003cfc6bc0();
}

public T[] ToArray<T>(Func<RC_dc7b093401bf134dc8399c003cfc6bc0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_86fbed1618008cdc1ffb40212b2c9089 recordList, Func<RC_dc7b093401bf134dc8399c003cfc6bc0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_86fbed1618008cdc1ffb40212b2c9089(RC_dc7b093401bf134dc8399c003cfc6bc0[] array) {
  RL_86fbed1618008cdc1ffb40212b2c9089 result = new RL_86fbed1618008cdc1ffb40212b2c9089();
result.InnerFromArray(array);
    return result;
}

public static RL_86fbed1618008cdc1ffb40212b2c9089 ToList<T>(T[] array, Func <T, RC_dc7b093401bf134dc8399c003cfc6bc0> converter) {
  RL_86fbed1618008cdc1ffb40212b2c9089 result = new RL_86fbed1618008cdc1ffb40212b2c9089();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_86fbed1618008cdc1ffb40212b2c9089 FromRestList<T>(RestList<T> restList, Func <T, RC_dc7b093401bf134dc8399c003cfc6bc0> converter) {
  RL_86fbed1618008cdc1ffb40212b2c9089 result = new RL_86fbed1618008cdc1ffb40212b2c9089();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_86fbed1618008cdc1ffb40212b2c9089() : base() {
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
protected override OSList<RC_dc7b093401bf134dc8399c003cfc6bc0> NewList() {
return new RL_86fbed1618008cdc1ffb40212b2c9089();
}


} // RL_86fbed1618008cdc1ffb40212b2c9089
}

