namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (YRN+OQdMnU69kpjCN+jbdg)
///  <code>RC_6633adb48f346ff9147637b286666408</code> that represents <code>LogTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LogTypeRecord
public partial struct RC_6633adb48f346ff9147637b286666408 : ITypedRecord<RC_6633adb48f346ff9147637b286666408> {
internal static readonly GlobalObjectKey IdLogType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tK0zZjSP+W8UdjeyhmZkCA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("LogType")]
public EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord ssENLogType;


public static implicit operator EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord( RC_6633adb48f346ff9147637b286666408 r) {
return r.ssENLogType;
}

public static implicit operator RC_6633adb48f346ff9147637b286666408 (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord r) {
RC_6633adb48f346ff9147637b286666408 res = new RC_6633adb48f346ff9147637b286666408 ();
res.ssENLogType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENLogType.ChangedAttributes = value;
}
get {
    return ssENLogType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6633adb48f346ff9147637b286666408() {
OptimizedAttributes = null;
ssENLogType = new EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLogType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENLogType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENLogType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLogType.Read( r, ref index);
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
public void ReadIM(RC_6633adb48f346ff9147637b286666408 r) {
this = r;
}


public static bool operator == (RC_6633adb48f346ff9147637b286666408 a, RC_6633adb48f346ff9147637b286666408 b) {
if (a.ssENLogType != b.ssENLogType) return false;
return true;
}

public static bool operator != (RC_6633adb48f346ff9147637b286666408 a, RC_6633adb48f346ff9147637b286666408 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6633adb48f346ff9147637b286666408)) return false;
return (this == (RC_6633adb48f346ff9147637b286666408)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLogType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENLogType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLogType.InternalRecursiveSave();
}


public RC_6633adb48f346ff9147637b286666408 Duplicate() {
RC_6633adb48f346ff9147637b286666408 t;
t.ssENLogType = (EN_120b6e3e471666b0ae15ac3a8f34340fEntityRecord)this.ssENLogType.Duplicate();
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
if (head == "logtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LogType")) variable.Value = ssENLogType; else variable.Optimized = true;
variable.SetFieldName("logtype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENLogType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENLogType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLogType) {
return ssENLogType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLogType.Key.AsGuid) {
return ssENLogType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENLogType.FillFromOther((IRecord) other.AttributeGet(IdLogType));
}
} // RC_6633adb48f346ff9147637b286666408
/// <summary>
/// RecordList type <code>LogTypeRecordList</code> that represents a record list of
///  <code>LogType</code>
/// </summary>
public partial class RL_8be1611c5d10b078eeb854159188fc0f : GenericRecordList<RC_6633adb48f346ff9147637b286666408>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_6633adb48f346ff9147637b286666408 GetElementDefaultValue() {
return new RC_6633adb48f346ff9147637b286666408();
}

public T[] ToArray<T>(Func<RC_6633adb48f346ff9147637b286666408, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8be1611c5d10b078eeb854159188fc0f recordList, Func<RC_6633adb48f346ff9147637b286666408, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8be1611c5d10b078eeb854159188fc0f(RC_6633adb48f346ff9147637b286666408[] array) {
  RL_8be1611c5d10b078eeb854159188fc0f result = new RL_8be1611c5d10b078eeb854159188fc0f();
result.InnerFromArray(array);
    return result;
}

public static RL_8be1611c5d10b078eeb854159188fc0f ToList<T>(T[] array, Func <T, RC_6633adb48f346ff9147637b286666408> converter) {
  RL_8be1611c5d10b078eeb854159188fc0f result = new RL_8be1611c5d10b078eeb854159188fc0f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8be1611c5d10b078eeb854159188fc0f FromRestList<T>(RestList<T> restList, Func <T, RC_6633adb48f346ff9147637b286666408> converter) {
  RL_8be1611c5d10b078eeb854159188fc0f result = new RL_8be1611c5d10b078eeb854159188fc0f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8be1611c5d10b078eeb854159188fc0f() : base() {
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
protected override OSList<RC_6633adb48f346ff9147637b286666408> NewList() {
return new RL_8be1611c5d10b078eeb854159188fc0f();
}


} // RL_8be1611c5d10b078eeb854159188fc0f
}

