namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (_vmGi_bs+UiKSa99oElj6A)
///  <code>RC_5eb5daa2af512be51806b390378b7c9a</code> that represent
/// s <code>SectionIndexItem_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: SectionIndexItem_InternalConfigRecord
public partial struct RC_5eb5daa2af512be51806b390378b7c9a : ITypedRecord<RC_5eb5daa2af512be51806b390378b7c9a> {
internal static readonly GlobalObjectKey IdSectionIndexItem_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*otq1XlGv5SsYBrOQN4t8mg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SectionIndexItem_InternalConfig")]
public ST_a783e375273068e4b8f9c122c1661a6aStructure ssSTSectionIndexItem_InternalConfig;


public static implicit operator ST_a783e375273068e4b8f9c122c1661a6aStructure( RC_5eb5daa2af512be51806b390378b7c9a r) {
return r.ssSTSectionIndexItem_InternalConfig;
}

public static implicit operator RC_5eb5daa2af512be51806b390378b7c9a (ST_a783e375273068e4b8f9c122c1661a6aStructure r) {
RC_5eb5daa2af512be51806b390378b7c9a res = new RC_5eb5daa2af512be51806b390378b7c9a ();
res.ssSTSectionIndexItem_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5eb5daa2af512be51806b390378b7c9a() {
OptimizedAttributes = null;
ssSTSectionIndexItem_InternalConfig = new ST_a783e375273068e4b8f9c122c1661a6aStructure();
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
    ssSTSectionIndexItem_InternalConfig.OptimizedAttributes = value[0];
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
ssSTSectionIndexItem_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_5eb5daa2af512be51806b390378b7c9a r) {
this = r;
}


public static bool operator == (RC_5eb5daa2af512be51806b390378b7c9a a, RC_5eb5daa2af512be51806b390378b7c9a b) {
if (a.ssSTSectionIndexItem_InternalConfig != b.ssSTSectionIndexItem_InternalConfig) return false;
return true;
}

public static bool operator != (RC_5eb5daa2af512be51806b390378b7c9a a, RC_5eb5daa2af512be51806b390378b7c9a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5eb5daa2af512be51806b390378b7c9a)) return false;
return (this == (RC_5eb5daa2af512be51806b390378b7c9a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSectionIndexItem_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSectionIndexItem_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSectionIndexItem_InternalConfig.InternalRecursiveSave();
}


public RC_5eb5daa2af512be51806b390378b7c9a Duplicate() {
RC_5eb5daa2af512be51806b390378b7c9a t;
t.ssSTSectionIndexItem_InternalConfig = (ST_a783e375273068e4b8f9c122c1661a6aStructure)this.ssSTSectionIndexItem_InternalConfig.Duplicate();
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
if (head == "sectionindexitem_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SectionIndexItem_InternalConfig")) variable.Value = ssSTSectionIndexItem_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("sectionindexitem_internalconfig");
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
if (key == IdSectionIndexItem_InternalConfig) {
return ssSTSectionIndexItem_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSectionIndexItem_InternalConfig.Key.AsGuid) {
return ssSTSectionIndexItem_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSectionIndexItem_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdSectionIndexItem_InternalConfig));
}
} // RC_5eb5daa2af512be51806b390378b7c9a
/// <summary>
/// RecordList type <code>SectionIndexItem_InternalConfigRecordList</code> that represents a record
///  list of <code>SectionIndexItem_InternalConfig</code>
/// </summary>
public partial class RL_0a025b5603931b44884451ed1f6c9b3c : GenericRecordList<RC_5eb5daa2af512be51806b390378b7c9a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_5eb5daa2af512be51806b390378b7c9a GetElementDefaultValue() {
return new RC_5eb5daa2af512be51806b390378b7c9a();
}

public T[] ToArray<T>(Func<RC_5eb5daa2af512be51806b390378b7c9a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a025b5603931b44884451ed1f6c9b3c recordList, Func<RC_5eb5daa2af512be51806b390378b7c9a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a025b5603931b44884451ed1f6c9b3c(RC_5eb5daa2af512be51806b390378b7c9a[] array) {
  RL_0a025b5603931b44884451ed1f6c9b3c result = new RL_0a025b5603931b44884451ed1f6c9b3c();
result.InnerFromArray(array);
    return result;
}

public static RL_0a025b5603931b44884451ed1f6c9b3c ToList<T>(T[] array, Func <T, RC_5eb5daa2af512be51806b390378b7c9a> converter) {
  RL_0a025b5603931b44884451ed1f6c9b3c result = new RL_0a025b5603931b44884451ed1f6c9b3c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a025b5603931b44884451ed1f6c9b3c FromRestList<T>(RestList<T> restList, Func <T, RC_5eb5daa2af512be51806b390378b7c9a> converter) {
  RL_0a025b5603931b44884451ed1f6c9b3c result = new RL_0a025b5603931b44884451ed1f6c9b3c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a025b5603931b44884451ed1f6c9b3c() : base() {
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
protected override OSList<RC_5eb5daa2af512be51806b390378b7c9a> NewList() {
return new RL_0a025b5603931b44884451ed1f6c9b3c();
}


} // RL_0a025b5603931b44884451ed1f6c9b3c
}

