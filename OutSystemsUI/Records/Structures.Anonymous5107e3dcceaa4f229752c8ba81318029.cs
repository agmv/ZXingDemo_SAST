namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (3OMHUarOIk+XUsi6gTGAKQ)
///  <code>RC_dac62773434cf92b52368fd089bbfc2a</code> that represents <code>CarouselItemsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CarouselItemsRecord
public partial struct RC_dac62773434cf92b52368fd089bbfc2a : ITypedRecord<RC_dac62773434cf92b52368fd089bbfc2a> {
internal static readonly GlobalObjectKey IdCarouselItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cyfG2kxDK_lSNo_Qibv8Kg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CarouselItems")]
public ST_660adb7a9db48bff1b12c6e03515b415Structure ssSTCarouselItems;


public static implicit operator ST_660adb7a9db48bff1b12c6e03515b415Structure( RC_dac62773434cf92b52368fd089bbfc2a r) {
return r.ssSTCarouselItems;
}

public static implicit operator RC_dac62773434cf92b52368fd089bbfc2a (ST_660adb7a9db48bff1b12c6e03515b415Structure r) {
RC_dac62773434cf92b52368fd089bbfc2a res = new RC_dac62773434cf92b52368fd089bbfc2a ();
res.ssSTCarouselItems = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dac62773434cf92b52368fd089bbfc2a() {
OptimizedAttributes = null;
ssSTCarouselItems = new ST_660adb7a9db48bff1b12c6e03515b415Structure();
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
    ssSTCarouselItems.OptimizedAttributes = value[0];
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
ssSTCarouselItems.Read( r, ref index);
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
public void ReadIM(RC_dac62773434cf92b52368fd089bbfc2a r) {
this = r;
}


public static bool operator == (RC_dac62773434cf92b52368fd089bbfc2a a, RC_dac62773434cf92b52368fd089bbfc2a b) {
if (a.ssSTCarouselItems != b.ssSTCarouselItems) return false;
return true;
}

public static bool operator != (RC_dac62773434cf92b52368fd089bbfc2a a, RC_dac62773434cf92b52368fd089bbfc2a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dac62773434cf92b52368fd089bbfc2a)) return false;
return (this == (RC_dac62773434cf92b52368fd089bbfc2a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCarouselItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCarouselItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCarouselItems.InternalRecursiveSave();
}


public RC_dac62773434cf92b52368fd089bbfc2a Duplicate() {
RC_dac62773434cf92b52368fd089bbfc2a t;
t.ssSTCarouselItems = (ST_660adb7a9db48bff1b12c6e03515b415Structure)this.ssSTCarouselItems.Duplicate();
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
if (head == "carouselitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CarouselItems")) variable.Value = ssSTCarouselItems; else variable.Optimized = true;
variable.SetFieldName("carouselitems");
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
if (key == IdCarouselItems) {
return ssSTCarouselItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCarouselItems.Key.AsGuid) {
return ssSTCarouselItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCarouselItems.FillFromOther((IRecord) other.AttributeGet(IdCarouselItems));
}
} // RC_dac62773434cf92b52368fd089bbfc2a
/// <summary>
/// RecordList type <code>CarouselItemsRecordList</code> that represents a record list of
///  <code>CarouselItems</code>
/// </summary>
public partial class RL_e42632965fbacac756c3d935f97df7a8 : GenericRecordList<RC_dac62773434cf92b52368fd089bbfc2a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_dac62773434cf92b52368fd089bbfc2a GetElementDefaultValue() {
return new RC_dac62773434cf92b52368fd089bbfc2a();
}

public T[] ToArray<T>(Func<RC_dac62773434cf92b52368fd089bbfc2a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e42632965fbacac756c3d935f97df7a8 recordList, Func<RC_dac62773434cf92b52368fd089bbfc2a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e42632965fbacac756c3d935f97df7a8(RC_dac62773434cf92b52368fd089bbfc2a[] array) {
  RL_e42632965fbacac756c3d935f97df7a8 result = new RL_e42632965fbacac756c3d935f97df7a8();
result.InnerFromArray(array);
    return result;
}

public static RL_e42632965fbacac756c3d935f97df7a8 ToList<T>(T[] array, Func <T, RC_dac62773434cf92b52368fd089bbfc2a> converter) {
  RL_e42632965fbacac756c3d935f97df7a8 result = new RL_e42632965fbacac756c3d935f97df7a8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e42632965fbacac756c3d935f97df7a8 FromRestList<T>(RestList<T> restList, Func <T, RC_dac62773434cf92b52368fd089bbfc2a> converter) {
  RL_e42632965fbacac756c3d935f97df7a8 result = new RL_e42632965fbacac756c3d935f97df7a8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e42632965fbacac756c3d935f97df7a8() : base() {
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
protected override OSList<RC_dac62773434cf92b52368fd089bbfc2a> NewList() {
return new RL_e42632965fbacac756c3d935f97df7a8();
}


} // RL_e42632965fbacac756c3d935f97df7a8
}

