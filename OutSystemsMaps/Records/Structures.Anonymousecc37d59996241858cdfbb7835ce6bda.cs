namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (WX3D7GKZhUGM37t4Nc5r2g)
///  <code>RC_708103c95439cc3f1448414527622b7c</code> that represent
/// s <code>OptionalLeafletMapConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalLeafletMapConfigsRecord
public partial struct RC_708103c95439cc3f1448414527622b7c : ITypedRecord<RC_708103c95439cc3f1448414527622b7c> {
internal static readonly GlobalObjectKey IdOptionalLeafletMapConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yQOBcDlUP8wUSEFFJ2IrfA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalLeafletMapConfigs")]
public ST_597877eac22877030461f6d98995be4aStructure ssSTOptionalLeafletMapConfigs;


public static implicit operator ST_597877eac22877030461f6d98995be4aStructure( RC_708103c95439cc3f1448414527622b7c r) {
return r.ssSTOptionalLeafletMapConfigs;
}

public static implicit operator RC_708103c95439cc3f1448414527622b7c (ST_597877eac22877030461f6d98995be4aStructure r) {
RC_708103c95439cc3f1448414527622b7c res = new RC_708103c95439cc3f1448414527622b7c ();
res.ssSTOptionalLeafletMapConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_708103c95439cc3f1448414527622b7c() {
OptimizedAttributes = null;
ssSTOptionalLeafletMapConfigs = new ST_597877eac22877030461f6d98995be4aStructure();
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
    ssSTOptionalLeafletMapConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalLeafletMapConfigs.Read( r, ref index);
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
public void ReadIM(RC_708103c95439cc3f1448414527622b7c r) {
this = r;
}


public static bool operator == (RC_708103c95439cc3f1448414527622b7c a, RC_708103c95439cc3f1448414527622b7c b) {
if (a.ssSTOptionalLeafletMapConfigs != b.ssSTOptionalLeafletMapConfigs) return false;
return true;
}

public static bool operator != (RC_708103c95439cc3f1448414527622b7c a, RC_708103c95439cc3f1448414527622b7c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_708103c95439cc3f1448414527622b7c)) return false;
return (this == (RC_708103c95439cc3f1448414527622b7c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalLeafletMapConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalLeafletMapConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalLeafletMapConfigs.InternalRecursiveSave();
}


public RC_708103c95439cc3f1448414527622b7c Duplicate() {
RC_708103c95439cc3f1448414527622b7c t;
t.ssSTOptionalLeafletMapConfigs = (ST_597877eac22877030461f6d98995be4aStructure)this.ssSTOptionalLeafletMapConfigs.Duplicate();
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
if (head == "optionalleafletmapconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalLeafletMapConfigs")) variable.Value = ssSTOptionalLeafletMapConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalleafletmapconfigs");
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
if (key == IdOptionalLeafletMapConfigs) {
return ssSTOptionalLeafletMapConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalLeafletMapConfigs.Key.AsGuid) {
return ssSTOptionalLeafletMapConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalLeafletMapConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalLeafletMapConfigs));
}
} // RC_708103c95439cc3f1448414527622b7c
/// <summary>
/// RecordList type <code>OptionalLeafletMapConfigsRecordList</code> that represents a record list of
///  <code>OptionalLeafletMapConfigs</code>
/// </summary>
public partial class RL_072e9a99378a3fe4c1e19c5a7956268f : GenericRecordList<RC_708103c95439cc3f1448414527622b7c>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_708103c95439cc3f1448414527622b7c GetElementDefaultValue() {
return new RC_708103c95439cc3f1448414527622b7c();
}

public T[] ToArray<T>(Func<RC_708103c95439cc3f1448414527622b7c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_072e9a99378a3fe4c1e19c5a7956268f recordList, Func<RC_708103c95439cc3f1448414527622b7c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_072e9a99378a3fe4c1e19c5a7956268f(RC_708103c95439cc3f1448414527622b7c[] array) {
  RL_072e9a99378a3fe4c1e19c5a7956268f result = new RL_072e9a99378a3fe4c1e19c5a7956268f();
result.InnerFromArray(array);
    return result;
}

public static RL_072e9a99378a3fe4c1e19c5a7956268f ToList<T>(T[] array, Func <T, RC_708103c95439cc3f1448414527622b7c> converter) {
  RL_072e9a99378a3fe4c1e19c5a7956268f result = new RL_072e9a99378a3fe4c1e19c5a7956268f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_072e9a99378a3fe4c1e19c5a7956268f FromRestList<T>(RestList<T> restList, Func <T, RC_708103c95439cc3f1448414527622b7c> converter) {
  RL_072e9a99378a3fe4c1e19c5a7956268f result = new RL_072e9a99378a3fe4c1e19c5a7956268f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_072e9a99378a3fe4c1e19c5a7956268f() : base() {
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
protected override OSList<RC_708103c95439cc3f1448414527622b7c> NewList() {
return new RL_072e9a99378a3fe4c1e19c5a7956268f();
}


} // RL_072e9a99378a3fe4c1e19c5a7956268f
}

