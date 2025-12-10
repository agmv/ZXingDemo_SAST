namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (9iVvDNxexE22ZyZlu+pB3Q)
///  <code>RC_45a33caf5ebb3dedd109c21fe6ae3d86</code> that represent
/// s <code>RangeSliderProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: RangeSliderProviderRecord
public partial struct RC_45a33caf5ebb3dedd109c21fe6ae3d86 : ITypedRecord<RC_45a33caf5ebb3dedd109c21fe6ae3d86> {
internal static readonly GlobalObjectKey IdRangeSliderProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rzyjRbte7T3RCcIf5q49hg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RangeSliderProvider")]
public EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord ssENRangeSliderProvider;


public static implicit operator EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord( RC_45a33caf5ebb3dedd109c21fe6ae3d86 r) {
return r.ssENRangeSliderProvider;
}

public static implicit operator RC_45a33caf5ebb3dedd109c21fe6ae3d86 (EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord r) {
RC_45a33caf5ebb3dedd109c21fe6ae3d86 res = new RC_45a33caf5ebb3dedd109c21fe6ae3d86 ();
res.ssENRangeSliderProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRangeSliderProvider.ChangedAttributes = value;
}
get {
    return ssENRangeSliderProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_45a33caf5ebb3dedd109c21fe6ae3d86() {
OptimizedAttributes = null;
ssENRangeSliderProvider = new EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRangeSliderProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRangeSliderProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRangeSliderProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRangeSliderProvider.Read( r, ref index);
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
public void ReadIM(RC_45a33caf5ebb3dedd109c21fe6ae3d86 r) {
this = r;
}


public static bool operator == (RC_45a33caf5ebb3dedd109c21fe6ae3d86 a, RC_45a33caf5ebb3dedd109c21fe6ae3d86 b) {
if (a.ssENRangeSliderProvider != b.ssENRangeSliderProvider) return false;
return true;
}

public static bool operator != (RC_45a33caf5ebb3dedd109c21fe6ae3d86 a, RC_45a33caf5ebb3dedd109c21fe6ae3d86 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_45a33caf5ebb3dedd109c21fe6ae3d86)) return false;
return (this == (RC_45a33caf5ebb3dedd109c21fe6ae3d86)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRangeSliderProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRangeSliderProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRangeSliderProvider.InternalRecursiveSave();
}


public RC_45a33caf5ebb3dedd109c21fe6ae3d86 Duplicate() {
RC_45a33caf5ebb3dedd109c21fe6ae3d86 t;
t.ssENRangeSliderProvider = (EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord)this.ssENRangeSliderProvider.Duplicate();
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
if (head == "rangesliderprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RangeSliderProvider")) variable.Value = ssENRangeSliderProvider; else variable.Optimized = true;
variable.SetFieldName("rangesliderprovider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRangeSliderProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRangeSliderProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRangeSliderProvider) {
return ssENRangeSliderProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRangeSliderProvider.Key.AsGuid) {
return ssENRangeSliderProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRangeSliderProvider.FillFromOther((IRecord) other.AttributeGet(IdRangeSliderProvider));
}
} // RC_45a33caf5ebb3dedd109c21fe6ae3d86
/// <summary>
/// RecordList type <code>RangeSliderProviderRecordList</code> that represents a record list of
///  <code>RangeSliderProvider</code>
/// </summary>
public partial class RL_90540fb356a9f06dc487d0623c648999 : GenericRecordList<RC_45a33caf5ebb3dedd109c21fe6ae3d86>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_45a33caf5ebb3dedd109c21fe6ae3d86 GetElementDefaultValue() {
return new RC_45a33caf5ebb3dedd109c21fe6ae3d86();
}

public T[] ToArray<T>(Func<RC_45a33caf5ebb3dedd109c21fe6ae3d86, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_90540fb356a9f06dc487d0623c648999 recordList, Func<RC_45a33caf5ebb3dedd109c21fe6ae3d86, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_90540fb356a9f06dc487d0623c648999(RC_45a33caf5ebb3dedd109c21fe6ae3d86[] array) {
  RL_90540fb356a9f06dc487d0623c648999 result = new RL_90540fb356a9f06dc487d0623c648999();
result.InnerFromArray(array);
    return result;
}

public static RL_90540fb356a9f06dc487d0623c648999 ToList<T>(T[] array, Func <T, RC_45a33caf5ebb3dedd109c21fe6ae3d86> converter) {
  RL_90540fb356a9f06dc487d0623c648999 result = new RL_90540fb356a9f06dc487d0623c648999();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_90540fb356a9f06dc487d0623c648999 FromRestList<T>(RestList<T> restList, Func <T, RC_45a33caf5ebb3dedd109c21fe6ae3d86> converter) {
  RL_90540fb356a9f06dc487d0623c648999 result = new RL_90540fb356a9f06dc487d0623c648999();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_90540fb356a9f06dc487d0623c648999() : base() {
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
protected override OSList<RC_45a33caf5ebb3dedd109c21fe6ae3d86> NewList() {
return new RL_90540fb356a9f06dc487d0623c648999();
}


} // RL_90540fb356a9f06dc487d0623c648999
}

