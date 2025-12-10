namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (dCTOCTQLgUuPwF5inw+q_g)
///  <code>RC_b12957472059fa384384c2ddc449560e</code> that represent
/// s <code>OverflowMenu_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OverflowMenu_InternalConfigsRecord
public partial struct RC_b12957472059fa384384c2ddc449560e : ITypedRecord<RC_b12957472059fa384384c2ddc449560e> {
internal static readonly GlobalObjectKey IdOverflowMenu_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*R1cpsVkgOPpDhMLdxElWDg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OverflowMenu_InternalConfigs")]
public ST_6e6632cfd831e4e0f6a401872bea6eccStructure ssSTOverflowMenu_InternalConfigs;


public static implicit operator ST_6e6632cfd831e4e0f6a401872bea6eccStructure( RC_b12957472059fa384384c2ddc449560e r) {
return r.ssSTOverflowMenu_InternalConfigs;
}

public static implicit operator RC_b12957472059fa384384c2ddc449560e (ST_6e6632cfd831e4e0f6a401872bea6eccStructure r) {
RC_b12957472059fa384384c2ddc449560e res = new RC_b12957472059fa384384c2ddc449560e ();
res.ssSTOverflowMenu_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b12957472059fa384384c2ddc449560e() {
OptimizedAttributes = null;
ssSTOverflowMenu_InternalConfigs = new ST_6e6632cfd831e4e0f6a401872bea6eccStructure();
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
    ssSTOverflowMenu_InternalConfigs.OptimizedAttributes = value[0];
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
ssSTOverflowMenu_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_b12957472059fa384384c2ddc449560e r) {
this = r;
}


public static bool operator == (RC_b12957472059fa384384c2ddc449560e a, RC_b12957472059fa384384c2ddc449560e b) {
if (a.ssSTOverflowMenu_InternalConfigs != b.ssSTOverflowMenu_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_b12957472059fa384384c2ddc449560e a, RC_b12957472059fa384384c2ddc449560e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b12957472059fa384384c2ddc449560e)) return false;
return (this == (RC_b12957472059fa384384c2ddc449560e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOverflowMenu_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOverflowMenu_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOverflowMenu_InternalConfigs.InternalRecursiveSave();
}


public RC_b12957472059fa384384c2ddc449560e Duplicate() {
RC_b12957472059fa384384c2ddc449560e t;
t.ssSTOverflowMenu_InternalConfigs = (ST_6e6632cfd831e4e0f6a401872bea6eccStructure)this.ssSTOverflowMenu_InternalConfigs.Duplicate();
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
if (head == "overflowmenu_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OverflowMenu_InternalConfigs")) variable.Value = ssSTOverflowMenu_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("overflowmenu_internalconfigs");
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
if (key == IdOverflowMenu_InternalConfigs) {
return ssSTOverflowMenu_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOverflowMenu_InternalConfigs.Key.AsGuid) {
return ssSTOverflowMenu_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOverflowMenu_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdOverflowMenu_InternalConfigs));
}
} // RC_b12957472059fa384384c2ddc449560e
/// <summary>
/// RecordList type <code>OverflowMenu_InternalConfigsRecordList</code> that represents a record list
///  of <code>OverflowMenu_InternalConfigs</code>
/// </summary>
public partial class RL_32b9c5ca43955ecaca6bde26d91b8bcf : GenericRecordList<RC_b12957472059fa384384c2ddc449560e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b12957472059fa384384c2ddc449560e GetElementDefaultValue() {
return new RC_b12957472059fa384384c2ddc449560e();
}

public T[] ToArray<T>(Func<RC_b12957472059fa384384c2ddc449560e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_32b9c5ca43955ecaca6bde26d91b8bcf recordList, Func<RC_b12957472059fa384384c2ddc449560e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_32b9c5ca43955ecaca6bde26d91b8bcf(RC_b12957472059fa384384c2ddc449560e[] array) {
  RL_32b9c5ca43955ecaca6bde26d91b8bcf result = new RL_32b9c5ca43955ecaca6bde26d91b8bcf();
result.InnerFromArray(array);
    return result;
}

public static RL_32b9c5ca43955ecaca6bde26d91b8bcf ToList<T>(T[] array, Func <T, RC_b12957472059fa384384c2ddc449560e> converter) {
  RL_32b9c5ca43955ecaca6bde26d91b8bcf result = new RL_32b9c5ca43955ecaca6bde26d91b8bcf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_32b9c5ca43955ecaca6bde26d91b8bcf FromRestList<T>(RestList<T> restList, Func <T, RC_b12957472059fa384384c2ddc449560e> converter) {
  RL_32b9c5ca43955ecaca6bde26d91b8bcf result = new RL_32b9c5ca43955ecaca6bde26d91b8bcf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_32b9c5ca43955ecaca6bde26d91b8bcf() : base() {
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
protected override OSList<RC_b12957472059fa384384c2ddc449560e> NewList() {
return new RL_32b9c5ca43955ecaca6bde26d91b8bcf();
}


} // RL_32b9c5ca43955ecaca6bde26d91b8bcf
}

