namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (ekDRqWM6_UyL8jpklO9OpQ)
///  <code>RC_fb5d22b1003cff234a588ab54b5367f0</code> that represent
/// s <code>CarouselDirectionRecord</code> <p>Description: </p>
/// </summary>
// Name: CarouselDirectionRecord
public partial struct RC_fb5d22b1003cff234a588ab54b5367f0 : ITypedRecord<RC_fb5d22b1003cff234a588ab54b5367f0> {
internal static readonly GlobalObjectKey IdCarouselDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sSJd+zwAI_9KWIq1S1Nn8A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CarouselDirection")]
public EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord ssENCarouselDirection;


public static implicit operator EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord( RC_fb5d22b1003cff234a588ab54b5367f0 r) {
return r.ssENCarouselDirection;
}

public static implicit operator RC_fb5d22b1003cff234a588ab54b5367f0 (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord r) {
RC_fb5d22b1003cff234a588ab54b5367f0 res = new RC_fb5d22b1003cff234a588ab54b5367f0 ();
res.ssENCarouselDirection = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCarouselDirection.ChangedAttributes = value;
}
get {
    return ssENCarouselDirection.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_fb5d22b1003cff234a588ab54b5367f0() {
OptimizedAttributes = null;
ssENCarouselDirection = new EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCarouselDirection.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCarouselDirection.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCarouselDirection.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCarouselDirection.Read( r, ref index);
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
public void ReadIM(RC_fb5d22b1003cff234a588ab54b5367f0 r) {
this = r;
}


public static bool operator == (RC_fb5d22b1003cff234a588ab54b5367f0 a, RC_fb5d22b1003cff234a588ab54b5367f0 b) {
if (a.ssENCarouselDirection != b.ssENCarouselDirection) return false;
return true;
}

public static bool operator != (RC_fb5d22b1003cff234a588ab54b5367f0 a, RC_fb5d22b1003cff234a588ab54b5367f0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fb5d22b1003cff234a588ab54b5367f0)) return false;
return (this == (RC_fb5d22b1003cff234a588ab54b5367f0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCarouselDirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCarouselDirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCarouselDirection.InternalRecursiveSave();
}


public RC_fb5d22b1003cff234a588ab54b5367f0 Duplicate() {
RC_fb5d22b1003cff234a588ab54b5367f0 t;
t.ssENCarouselDirection = (EN_6b2a66e5a0a888e952c1a6f0d254d48aEntityRecord)this.ssENCarouselDirection.Duplicate();
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
if (head == "carouseldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CarouselDirection")) variable.Value = ssENCarouselDirection; else variable.Optimized = true;
variable.SetFieldName("carouseldirection");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCarouselDirection.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCarouselDirection.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCarouselDirection) {
return ssENCarouselDirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCarouselDirection.Key.AsGuid) {
return ssENCarouselDirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCarouselDirection.FillFromOther((IRecord) other.AttributeGet(IdCarouselDirection));
}
} // RC_fb5d22b1003cff234a588ab54b5367f0
/// <summary>
/// RecordList type <code>CarouselDirectionRecordList</code> that represents a record list of
///  <code>CarouselDirection</code>
/// </summary>
public partial class RL_02cff45c25b99caaf51dba44a0e0b754 : GenericRecordList<RC_fb5d22b1003cff234a588ab54b5367f0>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_fb5d22b1003cff234a588ab54b5367f0 GetElementDefaultValue() {
return new RC_fb5d22b1003cff234a588ab54b5367f0();
}

public T[] ToArray<T>(Func<RC_fb5d22b1003cff234a588ab54b5367f0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_02cff45c25b99caaf51dba44a0e0b754 recordList, Func<RC_fb5d22b1003cff234a588ab54b5367f0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_02cff45c25b99caaf51dba44a0e0b754(RC_fb5d22b1003cff234a588ab54b5367f0[] array) {
  RL_02cff45c25b99caaf51dba44a0e0b754 result = new RL_02cff45c25b99caaf51dba44a0e0b754();
result.InnerFromArray(array);
    return result;
}

public static RL_02cff45c25b99caaf51dba44a0e0b754 ToList<T>(T[] array, Func <T, RC_fb5d22b1003cff234a588ab54b5367f0> converter) {
  RL_02cff45c25b99caaf51dba44a0e0b754 result = new RL_02cff45c25b99caaf51dba44a0e0b754();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_02cff45c25b99caaf51dba44a0e0b754 FromRestList<T>(RestList<T> restList, Func <T, RC_fb5d22b1003cff234a588ab54b5367f0> converter) {
  RL_02cff45c25b99caaf51dba44a0e0b754 result = new RL_02cff45c25b99caaf51dba44a0e0b754();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_02cff45c25b99caaf51dba44a0e0b754() : base() {
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
protected override OSList<RC_fb5d22b1003cff234a588ab54b5367f0> NewList() {
return new RL_02cff45c25b99caaf51dba44a0e0b754();
}


} // RL_02cff45c25b99caaf51dba44a0e0b754
}

