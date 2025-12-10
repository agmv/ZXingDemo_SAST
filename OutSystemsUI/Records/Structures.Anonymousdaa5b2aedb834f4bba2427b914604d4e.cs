namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (rrKl2oPbS0+6JCe5FGBNTg)
///  <code>RC_81cffcb474124022b5e4e9bef9a608da</code> that represent
/// s <code>TabsHeaderItem_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: TabsHeaderItem_InternalConfigRecord
public partial struct RC_81cffcb474124022b5e4e9bef9a608da : ITypedRecord<RC_81cffcb474124022b5e4e9bef9a608da> {
internal static readonly GlobalObjectKey IdTabsHeaderItem_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tPzPgRJ0IkC15Om++aYI2g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("TabsHeaderItem_InternalConfig")]
public ST_4f70c42b393d853a53e093e196f4b683Structure ssSTTabsHeaderItem_InternalConfig;


public static implicit operator ST_4f70c42b393d853a53e093e196f4b683Structure( RC_81cffcb474124022b5e4e9bef9a608da r) {
return r.ssSTTabsHeaderItem_InternalConfig;
}

public static implicit operator RC_81cffcb474124022b5e4e9bef9a608da (ST_4f70c42b393d853a53e093e196f4b683Structure r) {
RC_81cffcb474124022b5e4e9bef9a608da res = new RC_81cffcb474124022b5e4e9bef9a608da ();
res.ssSTTabsHeaderItem_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_81cffcb474124022b5e4e9bef9a608da() {
OptimizedAttributes = null;
ssSTTabsHeaderItem_InternalConfig = new ST_4f70c42b393d853a53e093e196f4b683Structure();
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
    ssSTTabsHeaderItem_InternalConfig.OptimizedAttributes = value[0];
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
ssSTTabsHeaderItem_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_81cffcb474124022b5e4e9bef9a608da r) {
this = r;
}


public static bool operator == (RC_81cffcb474124022b5e4e9bef9a608da a, RC_81cffcb474124022b5e4e9bef9a608da b) {
if (a.ssSTTabsHeaderItem_InternalConfig != b.ssSTTabsHeaderItem_InternalConfig) return false;
return true;
}

public static bool operator != (RC_81cffcb474124022b5e4e9bef9a608da a, RC_81cffcb474124022b5e4e9bef9a608da b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_81cffcb474124022b5e4e9bef9a608da)) return false;
return (this == (RC_81cffcb474124022b5e4e9bef9a608da)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTabsHeaderItem_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTabsHeaderItem_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTabsHeaderItem_InternalConfig.InternalRecursiveSave();
}


public RC_81cffcb474124022b5e4e9bef9a608da Duplicate() {
RC_81cffcb474124022b5e4e9bef9a608da t;
t.ssSTTabsHeaderItem_InternalConfig = (ST_4f70c42b393d853a53e093e196f4b683Structure)this.ssSTTabsHeaderItem_InternalConfig.Duplicate();
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
if (head == "tabsheaderitem_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabsHeaderItem_InternalConfig")) variable.Value = ssSTTabsHeaderItem_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("tabsheaderitem_internalconfig");
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
if (key == IdTabsHeaderItem_InternalConfig) {
return ssSTTabsHeaderItem_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTabsHeaderItem_InternalConfig.Key.AsGuid) {
return ssSTTabsHeaderItem_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTabsHeaderItem_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdTabsHeaderItem_InternalConfig));
}
} // RC_81cffcb474124022b5e4e9bef9a608da
/// <summary>
/// RecordList type <code>TabsHeaderItem_InternalConfigRecordList</code> that represents a record list
///  of <code>TabsHeaderItem_InternalConfig</code>
/// </summary>
public partial class RL_e643032e067ed027c126907d7206bcdd : GenericRecordList<RC_81cffcb474124022b5e4e9bef9a608da>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_81cffcb474124022b5e4e9bef9a608da GetElementDefaultValue() {
return new RC_81cffcb474124022b5e4e9bef9a608da();
}

public T[] ToArray<T>(Func<RC_81cffcb474124022b5e4e9bef9a608da, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e643032e067ed027c126907d7206bcdd recordList, Func<RC_81cffcb474124022b5e4e9bef9a608da, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e643032e067ed027c126907d7206bcdd(RC_81cffcb474124022b5e4e9bef9a608da[] array) {
  RL_e643032e067ed027c126907d7206bcdd result = new RL_e643032e067ed027c126907d7206bcdd();
result.InnerFromArray(array);
    return result;
}

public static RL_e643032e067ed027c126907d7206bcdd ToList<T>(T[] array, Func <T, RC_81cffcb474124022b5e4e9bef9a608da> converter) {
  RL_e643032e067ed027c126907d7206bcdd result = new RL_e643032e067ed027c126907d7206bcdd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e643032e067ed027c126907d7206bcdd FromRestList<T>(RestList<T> restList, Func <T, RC_81cffcb474124022b5e4e9bef9a608da> converter) {
  RL_e643032e067ed027c126907d7206bcdd result = new RL_e643032e067ed027c126907d7206bcdd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e643032e067ed027c126907d7206bcdd() : base() {
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
protected override OSList<RC_81cffcb474124022b5e4e9bef9a608da> NewList() {
return new RL_e643032e067ed027c126907d7206bcdd();
}


} // RL_e643032e067ed027c126907d7206bcdd
}

