namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (Fjkktb7QN0K9AilsOhietQ)
///  <code>RC_8f31728044d1321864213488837bc67a</code> that represent
/// s <code>TimePicker_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: TimePicker_InternalConfigRecord
public partial struct RC_8f31728044d1321864213488837bc67a : ITypedRecord<RC_8f31728044d1321864213488837bc67a> {
internal static readonly GlobalObjectKey IdTimePicker_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gHIxj9FEGDJkITSIg3vGeg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("TimePicker_InternalConfig")]
public ST_613242ff7dd22d356200cb1f89298a39Structure ssSTTimePicker_InternalConfig;


public static implicit operator ST_613242ff7dd22d356200cb1f89298a39Structure( RC_8f31728044d1321864213488837bc67a r) {
return r.ssSTTimePicker_InternalConfig;
}

public static implicit operator RC_8f31728044d1321864213488837bc67a (ST_613242ff7dd22d356200cb1f89298a39Structure r) {
RC_8f31728044d1321864213488837bc67a res = new RC_8f31728044d1321864213488837bc67a ();
res.ssSTTimePicker_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8f31728044d1321864213488837bc67a() {
OptimizedAttributes = null;
ssSTTimePicker_InternalConfig = new ST_613242ff7dd22d356200cb1f89298a39Structure();
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
    ssSTTimePicker_InternalConfig.OptimizedAttributes = value[0];
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
ssSTTimePicker_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_8f31728044d1321864213488837bc67a r) {
this = r;
}


public static bool operator == (RC_8f31728044d1321864213488837bc67a a, RC_8f31728044d1321864213488837bc67a b) {
if (a.ssSTTimePicker_InternalConfig != b.ssSTTimePicker_InternalConfig) return false;
return true;
}

public static bool operator != (RC_8f31728044d1321864213488837bc67a a, RC_8f31728044d1321864213488837bc67a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8f31728044d1321864213488837bc67a)) return false;
return (this == (RC_8f31728044d1321864213488837bc67a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTimePicker_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTimePicker_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTimePicker_InternalConfig.InternalRecursiveSave();
}


public RC_8f31728044d1321864213488837bc67a Duplicate() {
RC_8f31728044d1321864213488837bc67a t;
t.ssSTTimePicker_InternalConfig = (ST_613242ff7dd22d356200cb1f89298a39Structure)this.ssSTTimePicker_InternalConfig.Duplicate();
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
if (head == "timepicker_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimePicker_InternalConfig")) variable.Value = ssSTTimePicker_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("timepicker_internalconfig");
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
if (key == IdTimePicker_InternalConfig) {
return ssSTTimePicker_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTimePicker_InternalConfig.Key.AsGuid) {
return ssSTTimePicker_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTimePicker_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdTimePicker_InternalConfig));
}
} // RC_8f31728044d1321864213488837bc67a
/// <summary>
/// RecordList type <code>TimePicker_InternalConfigRecordList</code> that represents a record list of
///  <code>TimePicker_InternalConfig</code>
/// </summary>
public partial class RL_e7b86a113e8a30ffc58a70e6ee41afc1 : GenericRecordList<RC_8f31728044d1321864213488837bc67a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8f31728044d1321864213488837bc67a GetElementDefaultValue() {
return new RC_8f31728044d1321864213488837bc67a();
}

public T[] ToArray<T>(Func<RC_8f31728044d1321864213488837bc67a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e7b86a113e8a30ffc58a70e6ee41afc1 recordList, Func<RC_8f31728044d1321864213488837bc67a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e7b86a113e8a30ffc58a70e6ee41afc1(RC_8f31728044d1321864213488837bc67a[] array) {
  RL_e7b86a113e8a30ffc58a70e6ee41afc1 result = new RL_e7b86a113e8a30ffc58a70e6ee41afc1();
result.InnerFromArray(array);
    return result;
}

public static RL_e7b86a113e8a30ffc58a70e6ee41afc1 ToList<T>(T[] array, Func <T, RC_8f31728044d1321864213488837bc67a> converter) {
  RL_e7b86a113e8a30ffc58a70e6ee41afc1 result = new RL_e7b86a113e8a30ffc58a70e6ee41afc1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e7b86a113e8a30ffc58a70e6ee41afc1 FromRestList<T>(RestList<T> restList, Func <T, RC_8f31728044d1321864213488837bc67a> converter) {
  RL_e7b86a113e8a30ffc58a70e6ee41afc1 result = new RL_e7b86a113e8a30ffc58a70e6ee41afc1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e7b86a113e8a30ffc58a70e6ee41afc1() : base() {
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
protected override OSList<RC_8f31728044d1321864213488837bc67a> NewList() {
return new RL_e7b86a113e8a30ffc58a70e6ee41afc1();
}


} // RL_e7b86a113e8a30ffc58a70e6ee41afc1
}

