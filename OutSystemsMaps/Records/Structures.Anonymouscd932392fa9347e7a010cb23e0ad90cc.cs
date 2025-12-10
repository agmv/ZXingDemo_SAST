namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (kiOTzZP650egEMsj4K2QzA)
///  <code>RC_b426a0d7aa8f7cff1977eb04da864b0f</code> that represents <code>PopupEventRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PopupEventRecord
public partial struct RC_b426a0d7aa8f7cff1977eb04da864b0f : ITypedRecord<RC_b426a0d7aa8f7cff1977eb04da864b0f> {
internal static readonly GlobalObjectKey IdPopupEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*16AmtI+q_3wZd+sE2oZLDw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("PopupEvent")]
public EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord ssENPopupEvent;


public static implicit operator EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord( RC_b426a0d7aa8f7cff1977eb04da864b0f r) {
return r.ssENPopupEvent;
}

public static implicit operator RC_b426a0d7aa8f7cff1977eb04da864b0f (EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord r) {
RC_b426a0d7aa8f7cff1977eb04da864b0f res = new RC_b426a0d7aa8f7cff1977eb04da864b0f ();
res.ssENPopupEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPopupEvent.ChangedAttributes = value;
}
get {
    return ssENPopupEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b426a0d7aa8f7cff1977eb04da864b0f() {
OptimizedAttributes = null;
ssENPopupEvent = new EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPopupEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPopupEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPopupEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPopupEvent.Read( r, ref index);
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
public void ReadIM(RC_b426a0d7aa8f7cff1977eb04da864b0f r) {
this = r;
}


public static bool operator == (RC_b426a0d7aa8f7cff1977eb04da864b0f a, RC_b426a0d7aa8f7cff1977eb04da864b0f b) {
if (a.ssENPopupEvent != b.ssENPopupEvent) return false;
return true;
}

public static bool operator != (RC_b426a0d7aa8f7cff1977eb04da864b0f a, RC_b426a0d7aa8f7cff1977eb04da864b0f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b426a0d7aa8f7cff1977eb04da864b0f)) return false;
return (this == (RC_b426a0d7aa8f7cff1977eb04da864b0f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPopupEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPopupEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPopupEvent.InternalRecursiveSave();
}


public RC_b426a0d7aa8f7cff1977eb04da864b0f Duplicate() {
RC_b426a0d7aa8f7cff1977eb04da864b0f t;
t.ssENPopupEvent = (EN_6b2476596efdad1a294f5d1a6e21f7e1EntityRecord)this.ssENPopupEvent.Duplicate();
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
if (head == "popupevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PopupEvent")) variable.Value = ssENPopupEvent; else variable.Optimized = true;
variable.SetFieldName("popupevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPopupEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPopupEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPopupEvent) {
return ssENPopupEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPopupEvent.Key.AsGuid) {
return ssENPopupEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPopupEvent.FillFromOther((IRecord) other.AttributeGet(IdPopupEvent));
}
} // RC_b426a0d7aa8f7cff1977eb04da864b0f
/// <summary>
/// RecordList type <code>PopupEventRecordList</code> that represents a record list of
///  <code>PopupEvent</code>
/// </summary>
public partial class RL_42ccc6dea7262d1c5960d9d9edeca153 : GenericRecordList<RC_b426a0d7aa8f7cff1977eb04da864b0f>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b426a0d7aa8f7cff1977eb04da864b0f GetElementDefaultValue() {
return new RC_b426a0d7aa8f7cff1977eb04da864b0f();
}

public T[] ToArray<T>(Func<RC_b426a0d7aa8f7cff1977eb04da864b0f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_42ccc6dea7262d1c5960d9d9edeca153 recordList, Func<RC_b426a0d7aa8f7cff1977eb04da864b0f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_42ccc6dea7262d1c5960d9d9edeca153(RC_b426a0d7aa8f7cff1977eb04da864b0f[] array) {
  RL_42ccc6dea7262d1c5960d9d9edeca153 result = new RL_42ccc6dea7262d1c5960d9d9edeca153();
result.InnerFromArray(array);
    return result;
}

public static RL_42ccc6dea7262d1c5960d9d9edeca153 ToList<T>(T[] array, Func <T, RC_b426a0d7aa8f7cff1977eb04da864b0f> converter) {
  RL_42ccc6dea7262d1c5960d9d9edeca153 result = new RL_42ccc6dea7262d1c5960d9d9edeca153();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_42ccc6dea7262d1c5960d9d9edeca153 FromRestList<T>(RestList<T> restList, Func <T, RC_b426a0d7aa8f7cff1977eb04da864b0f> converter) {
  RL_42ccc6dea7262d1c5960d9d9edeca153 result = new RL_42ccc6dea7262d1c5960d9d9edeca153();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_42ccc6dea7262d1c5960d9d9edeca153() : base() {
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
protected override OSList<RC_b426a0d7aa8f7cff1977eb04da864b0f> NewList() {
return new RL_42ccc6dea7262d1c5960d9d9edeca153();
}


} // RL_42ccc6dea7262d1c5960d9d9edeca153
}

