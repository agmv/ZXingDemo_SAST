namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (STetvfx51EeTuizP+UBh9w)
///  <code>RC_7d9f2e2bc8ad21193b3b806a3a092d80</code> that represent
/// s <code>DropdownServerSide_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownServerSide_InternalConfigsRecord
public partial struct RC_7d9f2e2bc8ad21193b3b806a3a092d80 : ITypedRecord<RC_7d9f2e2bc8ad21193b3b806a3a092d80> {
internal static readonly GlobalObjectKey IdDropdownServerSide_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ky6ffa3IGSE7O4BqOgktgA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownServerSide_InternalConfigs")]
public ST_0d18385ed976d2d74e8cea1d77078409Structure ssSTDropdownServerSide_InternalConfigs;


public static implicit operator ST_0d18385ed976d2d74e8cea1d77078409Structure( RC_7d9f2e2bc8ad21193b3b806a3a092d80 r) {
return r.ssSTDropdownServerSide_InternalConfigs;
}

public static implicit operator RC_7d9f2e2bc8ad21193b3b806a3a092d80 (ST_0d18385ed976d2d74e8cea1d77078409Structure r) {
RC_7d9f2e2bc8ad21193b3b806a3a092d80 res = new RC_7d9f2e2bc8ad21193b3b806a3a092d80 ();
res.ssSTDropdownServerSide_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7d9f2e2bc8ad21193b3b806a3a092d80() {
OptimizedAttributes = null;
ssSTDropdownServerSide_InternalConfigs = new ST_0d18385ed976d2d74e8cea1d77078409Structure();
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
    ssSTDropdownServerSide_InternalConfigs.OptimizedAttributes = value[0];
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
ssSTDropdownServerSide_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_7d9f2e2bc8ad21193b3b806a3a092d80 r) {
this = r;
}


public static bool operator == (RC_7d9f2e2bc8ad21193b3b806a3a092d80 a, RC_7d9f2e2bc8ad21193b3b806a3a092d80 b) {
if (a.ssSTDropdownServerSide_InternalConfigs != b.ssSTDropdownServerSide_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_7d9f2e2bc8ad21193b3b806a3a092d80 a, RC_7d9f2e2bc8ad21193b3b806a3a092d80 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7d9f2e2bc8ad21193b3b806a3a092d80)) return false;
return (this == (RC_7d9f2e2bc8ad21193b3b806a3a092d80)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownServerSide_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownServerSide_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownServerSide_InternalConfigs.InternalRecursiveSave();
}


public RC_7d9f2e2bc8ad21193b3b806a3a092d80 Duplicate() {
RC_7d9f2e2bc8ad21193b3b806a3a092d80 t;
t.ssSTDropdownServerSide_InternalConfigs = (ST_0d18385ed976d2d74e8cea1d77078409Structure)this.ssSTDropdownServerSide_InternalConfigs.Duplicate();
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
if (head == "dropdownserverside_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownServerSide_InternalConfigs")) variable.Value = ssSTDropdownServerSide_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("dropdownserverside_internalconfigs");
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
if (key == IdDropdownServerSide_InternalConfigs) {
return ssSTDropdownServerSide_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownServerSide_InternalConfigs.Key.AsGuid) {
return ssSTDropdownServerSide_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownServerSide_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDropdownServerSide_InternalConfigs));
}
} // RC_7d9f2e2bc8ad21193b3b806a3a092d80
/// <summary>
/// RecordList type <code>DropdownServerSide_InternalConfigsRecordList</code> that represents a record
///  list of <code>DropdownServerSide_InternalConfigs</code>
/// </summary>
public partial class RL_b4ddbbd05f91618f48b2747b1bedf987 : GenericRecordList<RC_7d9f2e2bc8ad21193b3b806a3a092d80>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7d9f2e2bc8ad21193b3b806a3a092d80 GetElementDefaultValue() {
return new RC_7d9f2e2bc8ad21193b3b806a3a092d80();
}

public T[] ToArray<T>(Func<RC_7d9f2e2bc8ad21193b3b806a3a092d80, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b4ddbbd05f91618f48b2747b1bedf987 recordList, Func<RC_7d9f2e2bc8ad21193b3b806a3a092d80, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b4ddbbd05f91618f48b2747b1bedf987(RC_7d9f2e2bc8ad21193b3b806a3a092d80[] array) {
  RL_b4ddbbd05f91618f48b2747b1bedf987 result = new RL_b4ddbbd05f91618f48b2747b1bedf987();
result.InnerFromArray(array);
    return result;
}

public static RL_b4ddbbd05f91618f48b2747b1bedf987 ToList<T>(T[] array, Func <T, RC_7d9f2e2bc8ad21193b3b806a3a092d80> converter) {
  RL_b4ddbbd05f91618f48b2747b1bedf987 result = new RL_b4ddbbd05f91618f48b2747b1bedf987();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b4ddbbd05f91618f48b2747b1bedf987 FromRestList<T>(RestList<T> restList, Func <T, RC_7d9f2e2bc8ad21193b3b806a3a092d80> converter) {
  RL_b4ddbbd05f91618f48b2747b1bedf987 result = new RL_b4ddbbd05f91618f48b2747b1bedf987();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b4ddbbd05f91618f48b2747b1bedf987() : base() {
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
protected override OSList<RC_7d9f2e2bc8ad21193b3b806a3a092d80> NewList() {
return new RL_b4ddbbd05f91618f48b2747b1bedf987();
}


} // RL_b4ddbbd05f91618f48b2747b1bedf987
}

