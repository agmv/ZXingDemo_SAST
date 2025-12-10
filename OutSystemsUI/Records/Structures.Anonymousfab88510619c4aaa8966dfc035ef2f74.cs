namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (EIW4+pxhqkqJZt_ANe8vdA)
///  <code>RC_34326cf8cbe6cf38d907603fa07c4c09</code> that represent
/// s <code>Accordion_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Accordion_InternalConfigsRecord
public partial struct RC_34326cf8cbe6cf38d907603fa07c4c09 : ITypedRecord<RC_34326cf8cbe6cf38d907603fa07c4c09> {
internal static readonly GlobalObjectKey IdAccordion_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+GwyNObLOM_ZB2A_oHxMCQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Accordion_InternalConfigs")]
public ST_0f0a5319963cb5bf3b0eab53b2781088Structure ssSTAccordion_InternalConfigs;


public static implicit operator ST_0f0a5319963cb5bf3b0eab53b2781088Structure( RC_34326cf8cbe6cf38d907603fa07c4c09 r) {
return r.ssSTAccordion_InternalConfigs;
}

public static implicit operator RC_34326cf8cbe6cf38d907603fa07c4c09 (ST_0f0a5319963cb5bf3b0eab53b2781088Structure r) {
RC_34326cf8cbe6cf38d907603fa07c4c09 res = new RC_34326cf8cbe6cf38d907603fa07c4c09 ();
res.ssSTAccordion_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_34326cf8cbe6cf38d907603fa07c4c09() {
OptimizedAttributes = null;
ssSTAccordion_InternalConfigs = new ST_0f0a5319963cb5bf3b0eab53b2781088Structure();
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
    ssSTAccordion_InternalConfigs.OptimizedAttributes = value[0];
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
ssSTAccordion_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_34326cf8cbe6cf38d907603fa07c4c09 r) {
this = r;
}


public static bool operator == (RC_34326cf8cbe6cf38d907603fa07c4c09 a, RC_34326cf8cbe6cf38d907603fa07c4c09 b) {
if (a.ssSTAccordion_InternalConfigs != b.ssSTAccordion_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_34326cf8cbe6cf38d907603fa07c4c09 a, RC_34326cf8cbe6cf38d907603fa07c4c09 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_34326cf8cbe6cf38d907603fa07c4c09)) return false;
return (this == (RC_34326cf8cbe6cf38d907603fa07c4c09)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAccordion_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAccordion_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAccordion_InternalConfigs.InternalRecursiveSave();
}


public RC_34326cf8cbe6cf38d907603fa07c4c09 Duplicate() {
RC_34326cf8cbe6cf38d907603fa07c4c09 t;
t.ssSTAccordion_InternalConfigs = (ST_0f0a5319963cb5bf3b0eab53b2781088Structure)this.ssSTAccordion_InternalConfigs.Duplicate();
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
if (head == "accordion_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Accordion_InternalConfigs")) variable.Value = ssSTAccordion_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("accordion_internalconfigs");
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
if (key == IdAccordion_InternalConfigs) {
return ssSTAccordion_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccordion_InternalConfigs.Key.AsGuid) {
return ssSTAccordion_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAccordion_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdAccordion_InternalConfigs));
}
} // RC_34326cf8cbe6cf38d907603fa07c4c09
/// <summary>
/// RecordList type <code>Accordion_InternalConfigsRecordList</code> that represents a record list of
///  <code>Accordion_InternalConfigs</code>
/// </summary>
public partial class RL_092cda9d13f093285c4b5f836ca5d119 : GenericRecordList<RC_34326cf8cbe6cf38d907603fa07c4c09>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_34326cf8cbe6cf38d907603fa07c4c09 GetElementDefaultValue() {
return new RC_34326cf8cbe6cf38d907603fa07c4c09();
}

public T[] ToArray<T>(Func<RC_34326cf8cbe6cf38d907603fa07c4c09, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_092cda9d13f093285c4b5f836ca5d119 recordList, Func<RC_34326cf8cbe6cf38d907603fa07c4c09, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_092cda9d13f093285c4b5f836ca5d119(RC_34326cf8cbe6cf38d907603fa07c4c09[] array) {
  RL_092cda9d13f093285c4b5f836ca5d119 result = new RL_092cda9d13f093285c4b5f836ca5d119();
result.InnerFromArray(array);
    return result;
}

public static RL_092cda9d13f093285c4b5f836ca5d119 ToList<T>(T[] array, Func <T, RC_34326cf8cbe6cf38d907603fa07c4c09> converter) {
  RL_092cda9d13f093285c4b5f836ca5d119 result = new RL_092cda9d13f093285c4b5f836ca5d119();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_092cda9d13f093285c4b5f836ca5d119 FromRestList<T>(RestList<T> restList, Func <T, RC_34326cf8cbe6cf38d907603fa07c4c09> converter) {
  RL_092cda9d13f093285c4b5f836ca5d119 result = new RL_092cda9d13f093285c4b5f836ca5d119();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_092cda9d13f093285c4b5f836ca5d119() : base() {
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
protected override OSList<RC_34326cf8cbe6cf38d907603fa07c4c09> NewList() {
return new RL_092cda9d13f093285c4b5f836ca5d119();
}


} // RL_092cda9d13f093285c4b5f836ca5d119
}

