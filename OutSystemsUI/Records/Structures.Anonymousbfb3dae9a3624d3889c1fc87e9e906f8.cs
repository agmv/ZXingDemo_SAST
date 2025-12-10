namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (6dqzv2KjOE2JwfyH6ekG+A)
///  <code>RC_60ed22b1487b1e18edb2fceb277aa5d1</code> that represent
/// s <code>CarouselProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: CarouselProviderRecord
public partial struct RC_60ed22b1487b1e18edb2fceb277aa5d1 : ITypedRecord<RC_60ed22b1487b1e18edb2fceb277aa5d1> {
internal static readonly GlobalObjectKey IdCarouselProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sSLtYHtIGB7tsvzrJ3ql0Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CarouselProvider")]
public EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord ssENCarouselProvider;


public static implicit operator EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord( RC_60ed22b1487b1e18edb2fceb277aa5d1 r) {
return r.ssENCarouselProvider;
}

public static implicit operator RC_60ed22b1487b1e18edb2fceb277aa5d1 (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord r) {
RC_60ed22b1487b1e18edb2fceb277aa5d1 res = new RC_60ed22b1487b1e18edb2fceb277aa5d1 ();
res.ssENCarouselProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCarouselProvider.ChangedAttributes = value;
}
get {
    return ssENCarouselProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_60ed22b1487b1e18edb2fceb277aa5d1() {
OptimizedAttributes = null;
ssENCarouselProvider = new EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCarouselProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCarouselProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCarouselProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCarouselProvider.Read( r, ref index);
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
public void ReadIM(RC_60ed22b1487b1e18edb2fceb277aa5d1 r) {
this = r;
}


public static bool operator == (RC_60ed22b1487b1e18edb2fceb277aa5d1 a, RC_60ed22b1487b1e18edb2fceb277aa5d1 b) {
if (a.ssENCarouselProvider != b.ssENCarouselProvider) return false;
return true;
}

public static bool operator != (RC_60ed22b1487b1e18edb2fceb277aa5d1 a, RC_60ed22b1487b1e18edb2fceb277aa5d1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_60ed22b1487b1e18edb2fceb277aa5d1)) return false;
return (this == (RC_60ed22b1487b1e18edb2fceb277aa5d1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCarouselProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCarouselProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCarouselProvider.InternalRecursiveSave();
}


public RC_60ed22b1487b1e18edb2fceb277aa5d1 Duplicate() {
RC_60ed22b1487b1e18edb2fceb277aa5d1 t;
t.ssENCarouselProvider = (EN_3693d4da8f8fc784e4048b7b08e34c39EntityRecord)this.ssENCarouselProvider.Duplicate();
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
if (head == "carouselprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CarouselProvider")) variable.Value = ssENCarouselProvider; else variable.Optimized = true;
variable.SetFieldName("carouselprovider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCarouselProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCarouselProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCarouselProvider) {
return ssENCarouselProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCarouselProvider.Key.AsGuid) {
return ssENCarouselProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCarouselProvider.FillFromOther((IRecord) other.AttributeGet(IdCarouselProvider));
}
} // RC_60ed22b1487b1e18edb2fceb277aa5d1
/// <summary>
/// RecordList type <code>CarouselProviderRecordList</code> that represents a record list of
///  <code>CarouselProvider</code>
/// </summary>
public partial class RL_f969515e188a563eaaeb32adf64a4b13 : GenericRecordList<RC_60ed22b1487b1e18edb2fceb277aa5d1>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_60ed22b1487b1e18edb2fceb277aa5d1 GetElementDefaultValue() {
return new RC_60ed22b1487b1e18edb2fceb277aa5d1();
}

public T[] ToArray<T>(Func<RC_60ed22b1487b1e18edb2fceb277aa5d1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f969515e188a563eaaeb32adf64a4b13 recordList, Func<RC_60ed22b1487b1e18edb2fceb277aa5d1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f969515e188a563eaaeb32adf64a4b13(RC_60ed22b1487b1e18edb2fceb277aa5d1[] array) {
  RL_f969515e188a563eaaeb32adf64a4b13 result = new RL_f969515e188a563eaaeb32adf64a4b13();
result.InnerFromArray(array);
    return result;
}

public static RL_f969515e188a563eaaeb32adf64a4b13 ToList<T>(T[] array, Func <T, RC_60ed22b1487b1e18edb2fceb277aa5d1> converter) {
  RL_f969515e188a563eaaeb32adf64a4b13 result = new RL_f969515e188a563eaaeb32adf64a4b13();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f969515e188a563eaaeb32adf64a4b13 FromRestList<T>(RestList<T> restList, Func <T, RC_60ed22b1487b1e18edb2fceb277aa5d1> converter) {
  RL_f969515e188a563eaaeb32adf64a4b13 result = new RL_f969515e188a563eaaeb32adf64a4b13();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f969515e188a563eaaeb32adf64a4b13() : base() {
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
protected override OSList<RC_60ed22b1487b1e18edb2fceb277aa5d1> NewList() {
return new RL_f969515e188a563eaaeb32adf64a4b13();
}


} // RL_f969515e188a563eaaeb32adf64a4b13
}

