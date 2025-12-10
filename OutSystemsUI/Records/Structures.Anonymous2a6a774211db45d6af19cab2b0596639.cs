namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (QndqKtsR1kWvGcqysFlmOQ)
///  <code>RC_3e7155b32546681d96eaaf8aa39a4f6e</code> that represent
/// s <code>Tabs_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Tabs_InternalConfigRecord
public partial struct RC_3e7155b32546681d96eaaf8aa39a4f6e : ITypedRecord<RC_3e7155b32546681d96eaaf8aa39a4f6e> {
internal static readonly GlobalObjectKey IdTabs_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*s1VxPkYlHWiW6q+Ko5pPbg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Tabs_InternalConfig")]
public ST_235f8a24bba710c13f14db6b69a566bbStructure ssSTTabs_InternalConfig;


public static implicit operator ST_235f8a24bba710c13f14db6b69a566bbStructure( RC_3e7155b32546681d96eaaf8aa39a4f6e r) {
return r.ssSTTabs_InternalConfig;
}

public static implicit operator RC_3e7155b32546681d96eaaf8aa39a4f6e (ST_235f8a24bba710c13f14db6b69a566bbStructure r) {
RC_3e7155b32546681d96eaaf8aa39a4f6e res = new RC_3e7155b32546681d96eaaf8aa39a4f6e ();
res.ssSTTabs_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3e7155b32546681d96eaaf8aa39a4f6e() {
OptimizedAttributes = null;
ssSTTabs_InternalConfig = new ST_235f8a24bba710c13f14db6b69a566bbStructure();
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
    ssSTTabs_InternalConfig.OptimizedAttributes = value[0];
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
ssSTTabs_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_3e7155b32546681d96eaaf8aa39a4f6e r) {
this = r;
}


public static bool operator == (RC_3e7155b32546681d96eaaf8aa39a4f6e a, RC_3e7155b32546681d96eaaf8aa39a4f6e b) {
if (a.ssSTTabs_InternalConfig != b.ssSTTabs_InternalConfig) return false;
return true;
}

public static bool operator != (RC_3e7155b32546681d96eaaf8aa39a4f6e a, RC_3e7155b32546681d96eaaf8aa39a4f6e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3e7155b32546681d96eaaf8aa39a4f6e)) return false;
return (this == (RC_3e7155b32546681d96eaaf8aa39a4f6e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTabs_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTabs_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTabs_InternalConfig.InternalRecursiveSave();
}


public RC_3e7155b32546681d96eaaf8aa39a4f6e Duplicate() {
RC_3e7155b32546681d96eaaf8aa39a4f6e t;
t.ssSTTabs_InternalConfig = (ST_235f8a24bba710c13f14db6b69a566bbStructure)this.ssSTTabs_InternalConfig.Duplicate();
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
if (head == "tabs_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tabs_InternalConfig")) variable.Value = ssSTTabs_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("tabs_internalconfig");
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
if (key == IdTabs_InternalConfig) {
return ssSTTabs_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTabs_InternalConfig.Key.AsGuid) {
return ssSTTabs_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTabs_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdTabs_InternalConfig));
}
} // RC_3e7155b32546681d96eaaf8aa39a4f6e
/// <summary>
/// RecordList type <code>Tabs_InternalConfigRecordList</code> that represents a record list of
///  <code>Tabs_InternalConfig</code>
/// </summary>
public partial class RL_f90b181f5e7da4de036de66a53f72976 : GenericRecordList<RC_3e7155b32546681d96eaaf8aa39a4f6e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3e7155b32546681d96eaaf8aa39a4f6e GetElementDefaultValue() {
return new RC_3e7155b32546681d96eaaf8aa39a4f6e();
}

public T[] ToArray<T>(Func<RC_3e7155b32546681d96eaaf8aa39a4f6e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f90b181f5e7da4de036de66a53f72976 recordList, Func<RC_3e7155b32546681d96eaaf8aa39a4f6e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f90b181f5e7da4de036de66a53f72976(RC_3e7155b32546681d96eaaf8aa39a4f6e[] array) {
  RL_f90b181f5e7da4de036de66a53f72976 result = new RL_f90b181f5e7da4de036de66a53f72976();
result.InnerFromArray(array);
    return result;
}

public static RL_f90b181f5e7da4de036de66a53f72976 ToList<T>(T[] array, Func <T, RC_3e7155b32546681d96eaaf8aa39a4f6e> converter) {
  RL_f90b181f5e7da4de036de66a53f72976 result = new RL_f90b181f5e7da4de036de66a53f72976();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f90b181f5e7da4de036de66a53f72976 FromRestList<T>(RestList<T> restList, Func <T, RC_3e7155b32546681d96eaaf8aa39a4f6e> converter) {
  RL_f90b181f5e7da4de036de66a53f72976 result = new RL_f90b181f5e7da4de036de66a53f72976();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f90b181f5e7da4de036de66a53f72976() : base() {
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
protected override OSList<RC_3e7155b32546681d96eaaf8aa39a4f6e> NewList() {
return new RL_f90b181f5e7da4de036de66a53f72976();
}


} // RL_f90b181f5e7da4de036de66a53f72976
}

