namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Gj9KwgP8rUyJKM1ykzybag)
///  <code>RC_3201d1384957542debf3cb5808f51144</code> that represents <code>ShapeTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ShapeTypeRecord
public partial struct RC_3201d1384957542debf3cb5808f51144 : ITypedRecord<RC_3201d1384957542debf3cb5808f51144> {
internal static readonly GlobalObjectKey IdShapeType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ONEBMldJLVTr88tYCPURRA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ShapeType")]
public EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord ssENShapeType;


public static implicit operator EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord( RC_3201d1384957542debf3cb5808f51144 r) {
return r.ssENShapeType;
}

public static implicit operator RC_3201d1384957542debf3cb5808f51144 (EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord r) {
RC_3201d1384957542debf3cb5808f51144 res = new RC_3201d1384957542debf3cb5808f51144 ();
res.ssENShapeType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENShapeType.ChangedAttributes = value;
}
get {
    return ssENShapeType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3201d1384957542debf3cb5808f51144() {
OptimizedAttributes = null;
ssENShapeType = new EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENShapeType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENShapeType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENShapeType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENShapeType.Read( r, ref index);
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
public void ReadIM(RC_3201d1384957542debf3cb5808f51144 r) {
this = r;
}


public static bool operator == (RC_3201d1384957542debf3cb5808f51144 a, RC_3201d1384957542debf3cb5808f51144 b) {
if (a.ssENShapeType != b.ssENShapeType) return false;
return true;
}

public static bool operator != (RC_3201d1384957542debf3cb5808f51144 a, RC_3201d1384957542debf3cb5808f51144 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3201d1384957542debf3cb5808f51144)) return false;
return (this == (RC_3201d1384957542debf3cb5808f51144)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENShapeType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENShapeType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENShapeType.InternalRecursiveSave();
}


public RC_3201d1384957542debf3cb5808f51144 Duplicate() {
RC_3201d1384957542debf3cb5808f51144 t;
t.ssENShapeType = (EN_e8edeefe38d8112c39e64ad89dac6f44EntityRecord)this.ssENShapeType.Duplicate();
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
if (head == "shapetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShapeType")) variable.Value = ssENShapeType; else variable.Optimized = true;
variable.SetFieldName("shapetype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENShapeType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENShapeType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdShapeType) {
return ssENShapeType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShapeType.Key.AsGuid) {
return ssENShapeType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENShapeType.FillFromOther((IRecord) other.AttributeGet(IdShapeType));
}
} // RC_3201d1384957542debf3cb5808f51144
/// <summary>
/// RecordList type <code>ShapeTypeRecordList</code> that represents a record list of
///  <code>ShapeType</code>
/// </summary>
public partial class RL_f6766102ea4dcc3665148ec35fb5cb78 : GenericRecordList<RC_3201d1384957542debf3cb5808f51144>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3201d1384957542debf3cb5808f51144 GetElementDefaultValue() {
return new RC_3201d1384957542debf3cb5808f51144();
}

public T[] ToArray<T>(Func<RC_3201d1384957542debf3cb5808f51144, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6766102ea4dcc3665148ec35fb5cb78 recordList, Func<RC_3201d1384957542debf3cb5808f51144, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6766102ea4dcc3665148ec35fb5cb78(RC_3201d1384957542debf3cb5808f51144[] array) {
  RL_f6766102ea4dcc3665148ec35fb5cb78 result = new RL_f6766102ea4dcc3665148ec35fb5cb78();
result.InnerFromArray(array);
    return result;
}

public static RL_f6766102ea4dcc3665148ec35fb5cb78 ToList<T>(T[] array, Func <T, RC_3201d1384957542debf3cb5808f51144> converter) {
  RL_f6766102ea4dcc3665148ec35fb5cb78 result = new RL_f6766102ea4dcc3665148ec35fb5cb78();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6766102ea4dcc3665148ec35fb5cb78 FromRestList<T>(RestList<T> restList, Func <T, RC_3201d1384957542debf3cb5808f51144> converter) {
  RL_f6766102ea4dcc3665148ec35fb5cb78 result = new RL_f6766102ea4dcc3665148ec35fb5cb78();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6766102ea4dcc3665148ec35fb5cb78() : base() {
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
protected override OSList<RC_3201d1384957542debf3cb5808f51144> NewList() {
return new RL_f6766102ea4dcc3665148ec35fb5cb78();
}


} // RL_f6766102ea4dcc3665148ec35fb5cb78
}

