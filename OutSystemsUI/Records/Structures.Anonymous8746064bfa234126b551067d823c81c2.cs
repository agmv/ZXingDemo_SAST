namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (SwZGhyP6JkG1UQZ9gjyBwg)
///  <code>RC_1583be5d90a94b6a73170ffa868eecc5</code> that represent
/// s <code>DeviceResponsiveRecord</code> <p>Description: </p>
/// </summary>
// Name: DeviceResponsiveRecord
public partial struct RC_1583be5d90a94b6a73170ffa868eecc5 : ITypedRecord<RC_1583be5d90a94b6a73170ffa868eecc5> {
internal static readonly GlobalObjectKey IdDeviceResponsive = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Xb6DFamQaktzFw_6ho7sxQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DeviceResponsive")]
public EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord ssENDeviceResponsive;


public static implicit operator EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord( RC_1583be5d90a94b6a73170ffa868eecc5 r) {
return r.ssENDeviceResponsive;
}

public static implicit operator RC_1583be5d90a94b6a73170ffa868eecc5 (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord r) {
RC_1583be5d90a94b6a73170ffa868eecc5 res = new RC_1583be5d90a94b6a73170ffa868eecc5 ();
res.ssENDeviceResponsive = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDeviceResponsive.ChangedAttributes = value;
}
get {
    return ssENDeviceResponsive.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1583be5d90a94b6a73170ffa868eecc5() {
OptimizedAttributes = null;
ssENDeviceResponsive = new EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDeviceResponsive.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDeviceResponsive.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDeviceResponsive.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDeviceResponsive.Read( r, ref index);
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
public void ReadIM(RC_1583be5d90a94b6a73170ffa868eecc5 r) {
this = r;
}


public static bool operator == (RC_1583be5d90a94b6a73170ffa868eecc5 a, RC_1583be5d90a94b6a73170ffa868eecc5 b) {
if (a.ssENDeviceResponsive != b.ssENDeviceResponsive) return false;
return true;
}

public static bool operator != (RC_1583be5d90a94b6a73170ffa868eecc5 a, RC_1583be5d90a94b6a73170ffa868eecc5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1583be5d90a94b6a73170ffa868eecc5)) return false;
return (this == (RC_1583be5d90a94b6a73170ffa868eecc5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDeviceResponsive.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDeviceResponsive.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDeviceResponsive.InternalRecursiveSave();
}


public RC_1583be5d90a94b6a73170ffa868eecc5 Duplicate() {
RC_1583be5d90a94b6a73170ffa868eecc5 t;
t.ssENDeviceResponsive = (EN_ede7f8abbe990a3b2c1a9cfd79dc5b0fEntityRecord)this.ssENDeviceResponsive.Duplicate();
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
if (head == "deviceresponsive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeviceResponsive")) variable.Value = ssENDeviceResponsive; else variable.Optimized = true;
variable.SetFieldName("deviceresponsive");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDeviceResponsive.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDeviceResponsive.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDeviceResponsive) {
return ssENDeviceResponsive;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDeviceResponsive.Key.AsGuid) {
return ssENDeviceResponsive;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDeviceResponsive.FillFromOther((IRecord) other.AttributeGet(IdDeviceResponsive));
}
} // RC_1583be5d90a94b6a73170ffa868eecc5
/// <summary>
/// RecordList type <code>DeviceResponsiveRecordList</code> that represents a record list of
///  <code>DeviceResponsive</code>
/// </summary>
public partial class RL_7afe2e3802b1138fe7c019f238334de4 : GenericRecordList<RC_1583be5d90a94b6a73170ffa868eecc5>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_1583be5d90a94b6a73170ffa868eecc5 GetElementDefaultValue() {
return new RC_1583be5d90a94b6a73170ffa868eecc5();
}

public T[] ToArray<T>(Func<RC_1583be5d90a94b6a73170ffa868eecc5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7afe2e3802b1138fe7c019f238334de4 recordList, Func<RC_1583be5d90a94b6a73170ffa868eecc5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7afe2e3802b1138fe7c019f238334de4(RC_1583be5d90a94b6a73170ffa868eecc5[] array) {
  RL_7afe2e3802b1138fe7c019f238334de4 result = new RL_7afe2e3802b1138fe7c019f238334de4();
result.InnerFromArray(array);
    return result;
}

public static RL_7afe2e3802b1138fe7c019f238334de4 ToList<T>(T[] array, Func <T, RC_1583be5d90a94b6a73170ffa868eecc5> converter) {
  RL_7afe2e3802b1138fe7c019f238334de4 result = new RL_7afe2e3802b1138fe7c019f238334de4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7afe2e3802b1138fe7c019f238334de4 FromRestList<T>(RestList<T> restList, Func <T, RC_1583be5d90a94b6a73170ffa868eecc5> converter) {
  RL_7afe2e3802b1138fe7c019f238334de4 result = new RL_7afe2e3802b1138fe7c019f238334de4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7afe2e3802b1138fe7c019f238334de4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1583be5d90a94b6a73170ffa868eecc5> NewList() {
return new RL_7afe2e3802b1138fe7c019f238334de4();
}


} // RL_7afe2e3802b1138fe7c019f238334de4
}

