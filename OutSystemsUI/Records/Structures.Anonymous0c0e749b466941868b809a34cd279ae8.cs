namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (m3QODGlGhkGLgJo0zSea6A)
///  <code>RC_373fec8a2329a8b1ecd55cf717893131</code> that represent
/// s <code>CarouselNavigationRecord</code> <p>Description: </p>
/// </summary>
// Name: CarouselNavigationRecord
public partial struct RC_373fec8a2329a8b1ecd55cf717893131 : ITypedRecord<RC_373fec8a2329a8b1ecd55cf717893131> {
internal static readonly GlobalObjectKey IdCarouselNavigation = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iuw_Nykjsajs1Vz3F4kxMQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CarouselNavigation")]
public EN_59aacee1cb91627a0f497366b24e4500EntityRecord ssENCarouselNavigation;


public static implicit operator EN_59aacee1cb91627a0f497366b24e4500EntityRecord( RC_373fec8a2329a8b1ecd55cf717893131 r) {
return r.ssENCarouselNavigation;
}

public static implicit operator RC_373fec8a2329a8b1ecd55cf717893131 (EN_59aacee1cb91627a0f497366b24e4500EntityRecord r) {
RC_373fec8a2329a8b1ecd55cf717893131 res = new RC_373fec8a2329a8b1ecd55cf717893131 ();
res.ssENCarouselNavigation = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCarouselNavigation.ChangedAttributes = value;
}
get {
    return ssENCarouselNavigation.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_373fec8a2329a8b1ecd55cf717893131() {
OptimizedAttributes = null;
ssENCarouselNavigation = new EN_59aacee1cb91627a0f497366b24e4500EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCarouselNavigation.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCarouselNavigation.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCarouselNavigation.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCarouselNavigation.Read( r, ref index);
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
public void ReadIM(RC_373fec8a2329a8b1ecd55cf717893131 r) {
this = r;
}


public static bool operator == (RC_373fec8a2329a8b1ecd55cf717893131 a, RC_373fec8a2329a8b1ecd55cf717893131 b) {
if (a.ssENCarouselNavigation != b.ssENCarouselNavigation) return false;
return true;
}

public static bool operator != (RC_373fec8a2329a8b1ecd55cf717893131 a, RC_373fec8a2329a8b1ecd55cf717893131 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_373fec8a2329a8b1ecd55cf717893131)) return false;
return (this == (RC_373fec8a2329a8b1ecd55cf717893131)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCarouselNavigation.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCarouselNavigation.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCarouselNavigation.InternalRecursiveSave();
}


public RC_373fec8a2329a8b1ecd55cf717893131 Duplicate() {
RC_373fec8a2329a8b1ecd55cf717893131 t;
t.ssENCarouselNavigation = (EN_59aacee1cb91627a0f497366b24e4500EntityRecord)this.ssENCarouselNavigation.Duplicate();
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
if (head == "carouselnavigation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CarouselNavigation")) variable.Value = ssENCarouselNavigation; else variable.Optimized = true;
variable.SetFieldName("carouselnavigation");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCarouselNavigation.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCarouselNavigation.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCarouselNavigation) {
return ssENCarouselNavigation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCarouselNavigation.Key.AsGuid) {
return ssENCarouselNavigation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCarouselNavigation.FillFromOther((IRecord) other.AttributeGet(IdCarouselNavigation));
}
} // RC_373fec8a2329a8b1ecd55cf717893131
/// <summary>
/// RecordList type <code>CarouselNavigationRecordList</code> that represents a record list of
///  <code>CarouselNavigation</code>
/// </summary>
public partial class RL_4feb2fb00f9cd7e5ee8abc58513e6f4d : GenericRecordList<RC_373fec8a2329a8b1ecd55cf717893131>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_373fec8a2329a8b1ecd55cf717893131 GetElementDefaultValue() {
return new RC_373fec8a2329a8b1ecd55cf717893131();
}

public T[] ToArray<T>(Func<RC_373fec8a2329a8b1ecd55cf717893131, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4feb2fb00f9cd7e5ee8abc58513e6f4d recordList, Func<RC_373fec8a2329a8b1ecd55cf717893131, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4feb2fb00f9cd7e5ee8abc58513e6f4d(RC_373fec8a2329a8b1ecd55cf717893131[] array) {
  RL_4feb2fb00f9cd7e5ee8abc58513e6f4d result = new RL_4feb2fb00f9cd7e5ee8abc58513e6f4d();
result.InnerFromArray(array);
    return result;
}

public static RL_4feb2fb00f9cd7e5ee8abc58513e6f4d ToList<T>(T[] array, Func <T, RC_373fec8a2329a8b1ecd55cf717893131> converter) {
  RL_4feb2fb00f9cd7e5ee8abc58513e6f4d result = new RL_4feb2fb00f9cd7e5ee8abc58513e6f4d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4feb2fb00f9cd7e5ee8abc58513e6f4d FromRestList<T>(RestList<T> restList, Func <T, RC_373fec8a2329a8b1ecd55cf717893131> converter) {
  RL_4feb2fb00f9cd7e5ee8abc58513e6f4d result = new RL_4feb2fb00f9cd7e5ee8abc58513e6f4d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4feb2fb00f9cd7e5ee8abc58513e6f4d() : base() {
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
protected override OSList<RC_373fec8a2329a8b1ecd55cf717893131> NewList() {
return new RL_4feb2fb00f9cd7e5ee8abc58513e6f4d();
}


} // RL_4feb2fb00f9cd7e5ee8abc58513e6f4d
}

