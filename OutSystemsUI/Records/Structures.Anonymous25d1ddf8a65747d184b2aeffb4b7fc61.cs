namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (+N3RJVem0UeEsq7_tLf8YQ)
///  <code>RC_b5f68720e8ed79c9aa70970bcdd12b24</code> that represent
/// s <code>TabsContentItem_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: TabsContentItem_InternalConfigRecord
public partial struct RC_b5f68720e8ed79c9aa70970bcdd12b24 : ITypedRecord<RC_b5f68720e8ed79c9aa70970bcdd12b24> {
internal static readonly GlobalObjectKey IdTabsContentItem_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IIf2te3oyXmqcJcLzdErJA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("TabsContentItem_InternalConfig")]
public ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure ssSTTabsContentItem_InternalConfig;


public static implicit operator ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure( RC_b5f68720e8ed79c9aa70970bcdd12b24 r) {
return r.ssSTTabsContentItem_InternalConfig;
}

public static implicit operator RC_b5f68720e8ed79c9aa70970bcdd12b24 (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure r) {
RC_b5f68720e8ed79c9aa70970bcdd12b24 res = new RC_b5f68720e8ed79c9aa70970bcdd12b24 ();
res.ssSTTabsContentItem_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b5f68720e8ed79c9aa70970bcdd12b24() {
OptimizedAttributes = null;
ssSTTabsContentItem_InternalConfig = new ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure();
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
    ssSTTabsContentItem_InternalConfig.OptimizedAttributes = value[0];
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
ssSTTabsContentItem_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_b5f68720e8ed79c9aa70970bcdd12b24 r) {
this = r;
}


public static bool operator == (RC_b5f68720e8ed79c9aa70970bcdd12b24 a, RC_b5f68720e8ed79c9aa70970bcdd12b24 b) {
if (a.ssSTTabsContentItem_InternalConfig != b.ssSTTabsContentItem_InternalConfig) return false;
return true;
}

public static bool operator != (RC_b5f68720e8ed79c9aa70970bcdd12b24 a, RC_b5f68720e8ed79c9aa70970bcdd12b24 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b5f68720e8ed79c9aa70970bcdd12b24)) return false;
return (this == (RC_b5f68720e8ed79c9aa70970bcdd12b24)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTabsContentItem_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTabsContentItem_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTabsContentItem_InternalConfig.InternalRecursiveSave();
}


public RC_b5f68720e8ed79c9aa70970bcdd12b24 Duplicate() {
RC_b5f68720e8ed79c9aa70970bcdd12b24 t;
t.ssSTTabsContentItem_InternalConfig = (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure)this.ssSTTabsContentItem_InternalConfig.Duplicate();
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
if (head == "tabscontentitem_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabsContentItem_InternalConfig")) variable.Value = ssSTTabsContentItem_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("tabscontentitem_internalconfig");
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
if (key == IdTabsContentItem_InternalConfig) {
return ssSTTabsContentItem_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTabsContentItem_InternalConfig.Key.AsGuid) {
return ssSTTabsContentItem_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTabsContentItem_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdTabsContentItem_InternalConfig));
}
} // RC_b5f68720e8ed79c9aa70970bcdd12b24
/// <summary>
/// RecordList type <code>TabsContentItem_InternalConfigRecordList</code> that represents a record list
///  of <code>TabsContentItem_InternalConfig</code>
/// </summary>
public partial class RL_7e9847cbd460e629ebec5413d11b35ed : GenericRecordList<RC_b5f68720e8ed79c9aa70970bcdd12b24>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b5f68720e8ed79c9aa70970bcdd12b24 GetElementDefaultValue() {
return new RC_b5f68720e8ed79c9aa70970bcdd12b24();
}

public T[] ToArray<T>(Func<RC_b5f68720e8ed79c9aa70970bcdd12b24, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7e9847cbd460e629ebec5413d11b35ed recordList, Func<RC_b5f68720e8ed79c9aa70970bcdd12b24, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7e9847cbd460e629ebec5413d11b35ed(RC_b5f68720e8ed79c9aa70970bcdd12b24[] array) {
  RL_7e9847cbd460e629ebec5413d11b35ed result = new RL_7e9847cbd460e629ebec5413d11b35ed();
result.InnerFromArray(array);
    return result;
}

public static RL_7e9847cbd460e629ebec5413d11b35ed ToList<T>(T[] array, Func <T, RC_b5f68720e8ed79c9aa70970bcdd12b24> converter) {
  RL_7e9847cbd460e629ebec5413d11b35ed result = new RL_7e9847cbd460e629ebec5413d11b35ed();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7e9847cbd460e629ebec5413d11b35ed FromRestList<T>(RestList<T> restList, Func <T, RC_b5f68720e8ed79c9aa70970bcdd12b24> converter) {
  RL_7e9847cbd460e629ebec5413d11b35ed result = new RL_7e9847cbd460e629ebec5413d11b35ed();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7e9847cbd460e629ebec5413d11b35ed() : base() {
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
protected override OSList<RC_b5f68720e8ed79c9aa70970bcdd12b24> NewList() {
return new RL_7e9847cbd460e629ebec5413d11b35ed();
}


} // RL_7e9847cbd460e629ebec5413d11b35ed
}

