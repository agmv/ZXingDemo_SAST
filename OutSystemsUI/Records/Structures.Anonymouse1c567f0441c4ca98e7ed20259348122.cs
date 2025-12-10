namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (8GfF4RxEqUyOftICWTSBIg)
///  <code>RC_28eb7999f57ca2adfa805d40364c85b5</code> that represent
/// s <code>AccordionItem_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: AccordionItem_InternalConfigsRecord
public partial struct RC_28eb7999f57ca2adfa805d40364c85b5 : ITypedRecord<RC_28eb7999f57ca2adfa805d40364c85b5> {
internal static readonly GlobalObjectKey IdAccordionItem_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mXnrKHz1raL6gF1ANkyFtQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AccordionItem_InternalConfigs")]
public ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure ssSTAccordionItem_InternalConfigs;


public static implicit operator ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure( RC_28eb7999f57ca2adfa805d40364c85b5 r) {
return r.ssSTAccordionItem_InternalConfigs;
}

public static implicit operator RC_28eb7999f57ca2adfa805d40364c85b5 (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure r) {
RC_28eb7999f57ca2adfa805d40364c85b5 res = new RC_28eb7999f57ca2adfa805d40364c85b5 ();
res.ssSTAccordionItem_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_28eb7999f57ca2adfa805d40364c85b5() {
OptimizedAttributes = null;
ssSTAccordionItem_InternalConfigs = new ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure();
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
    ssSTAccordionItem_InternalConfigs.OptimizedAttributes = value[0];
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
ssSTAccordionItem_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_28eb7999f57ca2adfa805d40364c85b5 r) {
this = r;
}


public static bool operator == (RC_28eb7999f57ca2adfa805d40364c85b5 a, RC_28eb7999f57ca2adfa805d40364c85b5 b) {
if (a.ssSTAccordionItem_InternalConfigs != b.ssSTAccordionItem_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_28eb7999f57ca2adfa805d40364c85b5 a, RC_28eb7999f57ca2adfa805d40364c85b5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_28eb7999f57ca2adfa805d40364c85b5)) return false;
return (this == (RC_28eb7999f57ca2adfa805d40364c85b5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAccordionItem_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAccordionItem_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAccordionItem_InternalConfigs.InternalRecursiveSave();
}


public RC_28eb7999f57ca2adfa805d40364c85b5 Duplicate() {
RC_28eb7999f57ca2adfa805d40364c85b5 t;
t.ssSTAccordionItem_InternalConfigs = (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure)this.ssSTAccordionItem_InternalConfigs.Duplicate();
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
if (head == "accordionitem_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccordionItem_InternalConfigs")) variable.Value = ssSTAccordionItem_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("accordionitem_internalconfigs");
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
if (key == IdAccordionItem_InternalConfigs) {
return ssSTAccordionItem_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccordionItem_InternalConfigs.Key.AsGuid) {
return ssSTAccordionItem_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAccordionItem_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdAccordionItem_InternalConfigs));
}
} // RC_28eb7999f57ca2adfa805d40364c85b5
/// <summary>
/// RecordList type <code>AccordionItem_InternalConfigsRecordList</code> that represents a record list
///  of <code>AccordionItem_InternalConfigs</code>
/// </summary>
public partial class RL_26fff94a649decd44865005d77fa1ed8 : GenericRecordList<RC_28eb7999f57ca2adfa805d40364c85b5>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_28eb7999f57ca2adfa805d40364c85b5 GetElementDefaultValue() {
return new RC_28eb7999f57ca2adfa805d40364c85b5();
}

public T[] ToArray<T>(Func<RC_28eb7999f57ca2adfa805d40364c85b5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26fff94a649decd44865005d77fa1ed8 recordList, Func<RC_28eb7999f57ca2adfa805d40364c85b5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26fff94a649decd44865005d77fa1ed8(RC_28eb7999f57ca2adfa805d40364c85b5[] array) {
  RL_26fff94a649decd44865005d77fa1ed8 result = new RL_26fff94a649decd44865005d77fa1ed8();
result.InnerFromArray(array);
    return result;
}

public static RL_26fff94a649decd44865005d77fa1ed8 ToList<T>(T[] array, Func <T, RC_28eb7999f57ca2adfa805d40364c85b5> converter) {
  RL_26fff94a649decd44865005d77fa1ed8 result = new RL_26fff94a649decd44865005d77fa1ed8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26fff94a649decd44865005d77fa1ed8 FromRestList<T>(RestList<T> restList, Func <T, RC_28eb7999f57ca2adfa805d40364c85b5> converter) {
  RL_26fff94a649decd44865005d77fa1ed8 result = new RL_26fff94a649decd44865005d77fa1ed8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26fff94a649decd44865005d77fa1ed8() : base() {
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
protected override OSList<RC_28eb7999f57ca2adfa805d40364c85b5> NewList() {
return new RL_26fff94a649decd44865005d77fa1ed8();
}


} // RL_26fff94a649decd44865005d77fa1ed8
}

