namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (OsyebG88YUy62BgNPRREYQ)
///  <code>RC_d15ba8cc56cc5ee58bd8acaffd974239</code> that represents <code>SpeedRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SpeedRecord
public partial struct RC_d15ba8cc56cc5ee58bd8acaffd974239 : ITypedRecord<RC_d15ba8cc56cc5ee58bd8acaffd974239> {
internal static readonly GlobalObjectKey IdSpeed = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zKhb0cxW5V6L2Kyv_ZdCOQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Speed")]
public EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord ssENSpeed;


public static implicit operator EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord( RC_d15ba8cc56cc5ee58bd8acaffd974239 r) {
return r.ssENSpeed;
}

public static implicit operator RC_d15ba8cc56cc5ee58bd8acaffd974239 (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord r) {
RC_d15ba8cc56cc5ee58bd8acaffd974239 res = new RC_d15ba8cc56cc5ee58bd8acaffd974239 ();
res.ssENSpeed = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSpeed.ChangedAttributes = value;
}
get {
    return ssENSpeed.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d15ba8cc56cc5ee58bd8acaffd974239() {
OptimizedAttributes = null;
ssENSpeed = new EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSpeed.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSpeed.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSpeed.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSpeed.Read( r, ref index);
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
public void ReadIM(RC_d15ba8cc56cc5ee58bd8acaffd974239 r) {
this = r;
}


public static bool operator == (RC_d15ba8cc56cc5ee58bd8acaffd974239 a, RC_d15ba8cc56cc5ee58bd8acaffd974239 b) {
if (a.ssENSpeed != b.ssENSpeed) return false;
return true;
}

public static bool operator != (RC_d15ba8cc56cc5ee58bd8acaffd974239 a, RC_d15ba8cc56cc5ee58bd8acaffd974239 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d15ba8cc56cc5ee58bd8acaffd974239)) return false;
return (this == (RC_d15ba8cc56cc5ee58bd8acaffd974239)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSpeed.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSpeed.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSpeed.InternalRecursiveSave();
}


public RC_d15ba8cc56cc5ee58bd8acaffd974239 Duplicate() {
RC_d15ba8cc56cc5ee58bd8acaffd974239 t;
t.ssENSpeed = (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord)this.ssENSpeed.Duplicate();
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
if (head == "speed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Speed")) variable.Value = ssENSpeed; else variable.Optimized = true;
variable.SetFieldName("speed");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSpeed.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSpeed.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpeed) {
return ssENSpeed;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpeed.Key.AsGuid) {
return ssENSpeed;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSpeed.FillFromOther((IRecord) other.AttributeGet(IdSpeed));
}
} // RC_d15ba8cc56cc5ee58bd8acaffd974239
/// <summary>
/// RecordList type <code>SpeedRecordList</code> that represents a record list of <code>Speed</code>
/// </summary>
public partial class RL_f523c7921013f0781080fba3bca3beb7 : GenericRecordList<RC_d15ba8cc56cc5ee58bd8acaffd974239>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d15ba8cc56cc5ee58bd8acaffd974239 GetElementDefaultValue() {
return new RC_d15ba8cc56cc5ee58bd8acaffd974239();
}

public T[] ToArray<T>(Func<RC_d15ba8cc56cc5ee58bd8acaffd974239, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f523c7921013f0781080fba3bca3beb7 recordList, Func<RC_d15ba8cc56cc5ee58bd8acaffd974239, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f523c7921013f0781080fba3bca3beb7(RC_d15ba8cc56cc5ee58bd8acaffd974239[] array) {
  RL_f523c7921013f0781080fba3bca3beb7 result = new RL_f523c7921013f0781080fba3bca3beb7();
result.InnerFromArray(array);
    return result;
}

public static RL_f523c7921013f0781080fba3bca3beb7 ToList<T>(T[] array, Func <T, RC_d15ba8cc56cc5ee58bd8acaffd974239> converter) {
  RL_f523c7921013f0781080fba3bca3beb7 result = new RL_f523c7921013f0781080fba3bca3beb7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f523c7921013f0781080fba3bca3beb7 FromRestList<T>(RestList<T> restList, Func <T, RC_d15ba8cc56cc5ee58bd8acaffd974239> converter) {
  RL_f523c7921013f0781080fba3bca3beb7 result = new RL_f523c7921013f0781080fba3bca3beb7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f523c7921013f0781080fba3bca3beb7() : base() {
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
protected override OSList<RC_d15ba8cc56cc5ee58bd8acaffd974239> NewList() {
return new RL_f523c7921013f0781080fba3bca3beb7();
}


} // RL_f523c7921013f0781080fba3bca3beb7
}

