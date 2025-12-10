namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (qcKD0bos8E+3KlTwKgX0RQ)
///  <code>RC_4028c83435ff8f3fa19c27e5a3252dd5</code> that represent
/// s <code>CarouselOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: CarouselOptionalConfigsRecord
public partial struct RC_4028c83435ff8f3fa19c27e5a3252dd5 : ITypedRecord<RC_4028c83435ff8f3fa19c27e5a3252dd5> {
internal static readonly GlobalObjectKey IdCarouselOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NMgoQP81P4+hnCfloyUt1Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CarouselOptionalConfigs")]
public ST_7d99fd1de65649f174aff6854b052539Structure ssSTCarouselOptionalConfigs;


public static implicit operator ST_7d99fd1de65649f174aff6854b052539Structure( RC_4028c83435ff8f3fa19c27e5a3252dd5 r) {
return r.ssSTCarouselOptionalConfigs;
}

public static implicit operator RC_4028c83435ff8f3fa19c27e5a3252dd5 (ST_7d99fd1de65649f174aff6854b052539Structure r) {
RC_4028c83435ff8f3fa19c27e5a3252dd5 res = new RC_4028c83435ff8f3fa19c27e5a3252dd5 ();
res.ssSTCarouselOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4028c83435ff8f3fa19c27e5a3252dd5() {
OptimizedAttributes = null;
ssSTCarouselOptionalConfigs = new ST_7d99fd1de65649f174aff6854b052539Structure();
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
    ssSTCarouselOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTCarouselOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_4028c83435ff8f3fa19c27e5a3252dd5 r) {
this = r;
}


public static bool operator == (RC_4028c83435ff8f3fa19c27e5a3252dd5 a, RC_4028c83435ff8f3fa19c27e5a3252dd5 b) {
if (a.ssSTCarouselOptionalConfigs != b.ssSTCarouselOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_4028c83435ff8f3fa19c27e5a3252dd5 a, RC_4028c83435ff8f3fa19c27e5a3252dd5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4028c83435ff8f3fa19c27e5a3252dd5)) return false;
return (this == (RC_4028c83435ff8f3fa19c27e5a3252dd5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCarouselOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCarouselOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCarouselOptionalConfigs.InternalRecursiveSave();
}


public RC_4028c83435ff8f3fa19c27e5a3252dd5 Duplicate() {
RC_4028c83435ff8f3fa19c27e5a3252dd5 t;
t.ssSTCarouselOptionalConfigs = (ST_7d99fd1de65649f174aff6854b052539Structure)this.ssSTCarouselOptionalConfigs.Duplicate();
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
if (head == "carouseloptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CarouselOptionalConfigs")) variable.Value = ssSTCarouselOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("carouseloptionalconfigs");
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
if (key == IdCarouselOptionalConfigs) {
return ssSTCarouselOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCarouselOptionalConfigs.Key.AsGuid) {
return ssSTCarouselOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCarouselOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdCarouselOptionalConfigs));
}
} // RC_4028c83435ff8f3fa19c27e5a3252dd5
/// <summary>
/// RecordList type <code>CarouselOptionalConfigsRecordList</code> that represents a record list of
///  <code>CarouselOptionalConfigs</code>
/// </summary>
public partial class RL_9155b46cc5c187efb7cc10c67b592005 : GenericRecordList<RC_4028c83435ff8f3fa19c27e5a3252dd5>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_4028c83435ff8f3fa19c27e5a3252dd5 GetElementDefaultValue() {
return new RC_4028c83435ff8f3fa19c27e5a3252dd5();
}

public T[] ToArray<T>(Func<RC_4028c83435ff8f3fa19c27e5a3252dd5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9155b46cc5c187efb7cc10c67b592005 recordList, Func<RC_4028c83435ff8f3fa19c27e5a3252dd5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9155b46cc5c187efb7cc10c67b592005(RC_4028c83435ff8f3fa19c27e5a3252dd5[] array) {
  RL_9155b46cc5c187efb7cc10c67b592005 result = new RL_9155b46cc5c187efb7cc10c67b592005();
result.InnerFromArray(array);
    return result;
}

public static RL_9155b46cc5c187efb7cc10c67b592005 ToList<T>(T[] array, Func <T, RC_4028c83435ff8f3fa19c27e5a3252dd5> converter) {
  RL_9155b46cc5c187efb7cc10c67b592005 result = new RL_9155b46cc5c187efb7cc10c67b592005();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9155b46cc5c187efb7cc10c67b592005 FromRestList<T>(RestList<T> restList, Func <T, RC_4028c83435ff8f3fa19c27e5a3252dd5> converter) {
  RL_9155b46cc5c187efb7cc10c67b592005 result = new RL_9155b46cc5c187efb7cc10c67b592005();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9155b46cc5c187efb7cc10c67b592005() : base() {
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
protected override OSList<RC_4028c83435ff8f3fa19c27e5a3252dd5> NewList() {
return new RL_9155b46cc5c187efb7cc10c67b592005();
}


} // RL_9155b46cc5c187efb7cc10c67b592005
}

