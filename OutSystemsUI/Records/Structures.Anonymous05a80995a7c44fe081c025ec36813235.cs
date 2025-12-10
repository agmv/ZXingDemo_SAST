namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (lQmoBcSn4E+BwCXsNoEyNQ)
///  <code>RC_3f6426aeecbfa4af19e279847df746cc</code> that represents <code>GradientRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: GradientRecord
public partial struct RC_3f6426aeecbfa4af19e279847df746cc : ITypedRecord<RC_3f6426aeecbfa4af19e279847df746cc> {
internal static readonly GlobalObjectKey IdGradient = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*riZkP7_sr6QZ4nmEffdGzA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Gradient")]
public EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord ssENGradient;


public static implicit operator EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord( RC_3f6426aeecbfa4af19e279847df746cc r) {
return r.ssENGradient;
}

public static implicit operator RC_3f6426aeecbfa4af19e279847df746cc (EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord r) {
RC_3f6426aeecbfa4af19e279847df746cc res = new RC_3f6426aeecbfa4af19e279847df746cc ();
res.ssENGradient = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENGradient.ChangedAttributes = value;
}
get {
    return ssENGradient.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3f6426aeecbfa4af19e279847df746cc() {
OptimizedAttributes = null;
ssENGradient = new EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENGradient.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENGradient.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENGradient.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENGradient.Read( r, ref index);
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
public void ReadIM(RC_3f6426aeecbfa4af19e279847df746cc r) {
this = r;
}


public static bool operator == (RC_3f6426aeecbfa4af19e279847df746cc a, RC_3f6426aeecbfa4af19e279847df746cc b) {
if (a.ssENGradient != b.ssENGradient) return false;
return true;
}

public static bool operator != (RC_3f6426aeecbfa4af19e279847df746cc a, RC_3f6426aeecbfa4af19e279847df746cc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3f6426aeecbfa4af19e279847df746cc)) return false;
return (this == (RC_3f6426aeecbfa4af19e279847df746cc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENGradient.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENGradient.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENGradient.InternalRecursiveSave();
}


public RC_3f6426aeecbfa4af19e279847df746cc Duplicate() {
RC_3f6426aeecbfa4af19e279847df746cc t;
t.ssENGradient = (EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord)this.ssENGradient.Duplicate();
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
if (head == "gradient") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Gradient")) variable.Value = ssENGradient; else variable.Optimized = true;
variable.SetFieldName("gradient");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENGradient.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENGradient.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdGradient) {
return ssENGradient;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGradient.Key.AsGuid) {
return ssENGradient;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENGradient.FillFromOther((IRecord) other.AttributeGet(IdGradient));
}
} // RC_3f6426aeecbfa4af19e279847df746cc
/// <summary>
/// RecordList type <code>GradientRecordList</code> that represents a record list of
///  <code>Gradient</code>
/// </summary>
public partial class RL_f6f369139dd0b4b991cc52257bf57277 : GenericRecordList<RC_3f6426aeecbfa4af19e279847df746cc>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3f6426aeecbfa4af19e279847df746cc GetElementDefaultValue() {
return new RC_3f6426aeecbfa4af19e279847df746cc();
}

public T[] ToArray<T>(Func<RC_3f6426aeecbfa4af19e279847df746cc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6f369139dd0b4b991cc52257bf57277 recordList, Func<RC_3f6426aeecbfa4af19e279847df746cc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6f369139dd0b4b991cc52257bf57277(RC_3f6426aeecbfa4af19e279847df746cc[] array) {
  RL_f6f369139dd0b4b991cc52257bf57277 result = new RL_f6f369139dd0b4b991cc52257bf57277();
result.InnerFromArray(array);
    return result;
}

public static RL_f6f369139dd0b4b991cc52257bf57277 ToList<T>(T[] array, Func <T, RC_3f6426aeecbfa4af19e279847df746cc> converter) {
  RL_f6f369139dd0b4b991cc52257bf57277 result = new RL_f6f369139dd0b4b991cc52257bf57277();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6f369139dd0b4b991cc52257bf57277 FromRestList<T>(RestList<T> restList, Func <T, RC_3f6426aeecbfa4af19e279847df746cc> converter) {
  RL_f6f369139dd0b4b991cc52257bf57277 result = new RL_f6f369139dd0b4b991cc52257bf57277();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6f369139dd0b4b991cc52257bf57277() : base() {
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
protected override OSList<RC_3f6426aeecbfa4af19e279847df746cc> NewList() {
return new RL_f6f369139dd0b4b991cc52257bf57277();
}


} // RL_f6f369139dd0b4b991cc52257bf57277
}

