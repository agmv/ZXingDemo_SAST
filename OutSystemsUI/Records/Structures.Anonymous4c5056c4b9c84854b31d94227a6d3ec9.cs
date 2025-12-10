namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (xFZQTMi5VEizHZQiem0+yQ)
///  <code>RC_673cc0a63dbc3f5836f7732ba0712544</code> that represent
/// s <code>DatePickerLanguageRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerLanguageRecord
public partial struct RC_673cc0a63dbc3f5836f7732ba0712544 : ITypedRecord<RC_673cc0a63dbc3f5836f7732ba0712544> {
internal static readonly GlobalObjectKey IdDatePickerLanguage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*psA8Z7w9WD8293MroHElRA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DatePickerLanguage")]
public EN_ac6f62956e278d5390a5f27c607338d0EntityRecord ssENDatePickerLanguage;


public static implicit operator EN_ac6f62956e278d5390a5f27c607338d0EntityRecord( RC_673cc0a63dbc3f5836f7732ba0712544 r) {
return r.ssENDatePickerLanguage;
}

public static implicit operator RC_673cc0a63dbc3f5836f7732ba0712544 (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord r) {
RC_673cc0a63dbc3f5836f7732ba0712544 res = new RC_673cc0a63dbc3f5836f7732ba0712544 ();
res.ssENDatePickerLanguage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDatePickerLanguage.ChangedAttributes = value;
}
get {
    return ssENDatePickerLanguage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_673cc0a63dbc3f5836f7732ba0712544() {
OptimizedAttributes = null;
ssENDatePickerLanguage = new EN_ac6f62956e278d5390a5f27c607338d0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDatePickerLanguage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDatePickerLanguage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDatePickerLanguage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDatePickerLanguage.Read( r, ref index);
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
public void ReadIM(RC_673cc0a63dbc3f5836f7732ba0712544 r) {
this = r;
}


public static bool operator == (RC_673cc0a63dbc3f5836f7732ba0712544 a, RC_673cc0a63dbc3f5836f7732ba0712544 b) {
if (a.ssENDatePickerLanguage != b.ssENDatePickerLanguage) return false;
return true;
}

public static bool operator != (RC_673cc0a63dbc3f5836f7732ba0712544 a, RC_673cc0a63dbc3f5836f7732ba0712544 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_673cc0a63dbc3f5836f7732ba0712544)) return false;
return (this == (RC_673cc0a63dbc3f5836f7732ba0712544)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDatePickerLanguage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDatePickerLanguage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDatePickerLanguage.InternalRecursiveSave();
}


public RC_673cc0a63dbc3f5836f7732ba0712544 Duplicate() {
RC_673cc0a63dbc3f5836f7732ba0712544 t;
t.ssENDatePickerLanguage = (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord)this.ssENDatePickerLanguage.Duplicate();
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
if (head == "datepickerlanguage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerLanguage")) variable.Value = ssENDatePickerLanguage; else variable.Optimized = true;
variable.SetFieldName("datepickerlanguage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerLanguage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerLanguage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDatePickerLanguage) {
return ssENDatePickerLanguage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerLanguage.Key.AsGuid) {
return ssENDatePickerLanguage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDatePickerLanguage.FillFromOther((IRecord) other.AttributeGet(IdDatePickerLanguage));
}
} // RC_673cc0a63dbc3f5836f7732ba0712544
/// <summary>
/// RecordList type <code>DatePickerLanguageRecordList</code> that represents a record list of
///  <code>DatePickerLanguage</code>
/// </summary>
public partial class RL_eafe76043375465a898a3d00608f23b6 : GenericRecordList<RC_673cc0a63dbc3f5836f7732ba0712544>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_673cc0a63dbc3f5836f7732ba0712544 GetElementDefaultValue() {
return new RC_673cc0a63dbc3f5836f7732ba0712544();
}

public T[] ToArray<T>(Func<RC_673cc0a63dbc3f5836f7732ba0712544, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eafe76043375465a898a3d00608f23b6 recordList, Func<RC_673cc0a63dbc3f5836f7732ba0712544, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eafe76043375465a898a3d00608f23b6(RC_673cc0a63dbc3f5836f7732ba0712544[] array) {
  RL_eafe76043375465a898a3d00608f23b6 result = new RL_eafe76043375465a898a3d00608f23b6();
result.InnerFromArray(array);
    return result;
}

public static RL_eafe76043375465a898a3d00608f23b6 ToList<T>(T[] array, Func <T, RC_673cc0a63dbc3f5836f7732ba0712544> converter) {
  RL_eafe76043375465a898a3d00608f23b6 result = new RL_eafe76043375465a898a3d00608f23b6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eafe76043375465a898a3d00608f23b6 FromRestList<T>(RestList<T> restList, Func <T, RC_673cc0a63dbc3f5836f7732ba0712544> converter) {
  RL_eafe76043375465a898a3d00608f23b6 result = new RL_eafe76043375465a898a3d00608f23b6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eafe76043375465a898a3d00608f23b6() : base() {
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
protected override OSList<RC_673cc0a63dbc3f5836f7732ba0712544> NewList() {
return new RL_eafe76043375465a898a3d00608f23b6();
}


} // RL_eafe76043375465a898a3d00608f23b6
}

