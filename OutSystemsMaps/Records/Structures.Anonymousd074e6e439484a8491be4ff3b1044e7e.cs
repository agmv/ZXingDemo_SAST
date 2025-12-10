namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (5OZ00Eg5hEqRvk_zsQROfg)
///  <code>RC_c97612a27be85a5532e2b3b5ddfcfa27</code> that represent
/// s <code>OptionalMarkerConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalMarkerConfigsRecord
public partial struct RC_c97612a27be85a5532e2b3b5ddfcfa27 : ITypedRecord<RC_c97612a27be85a5532e2b3b5ddfcfa27> {
internal static readonly GlobalObjectKey IdOptionalMarkerConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ohJ2yeh7VVoy4rO13fz6Jw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalMarkerConfigs")]
public ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure ssSTOptionalMarkerConfigs;


public static implicit operator ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure( RC_c97612a27be85a5532e2b3b5ddfcfa27 r) {
return r.ssSTOptionalMarkerConfigs;
}

public static implicit operator RC_c97612a27be85a5532e2b3b5ddfcfa27 (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure r) {
RC_c97612a27be85a5532e2b3b5ddfcfa27 res = new RC_c97612a27be85a5532e2b3b5ddfcfa27 ();
res.ssSTOptionalMarkerConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c97612a27be85a5532e2b3b5ddfcfa27() {
OptimizedAttributes = null;
ssSTOptionalMarkerConfigs = new ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure();
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
    ssSTOptionalMarkerConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalMarkerConfigs.Read( r, ref index);
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
public void ReadIM(RC_c97612a27be85a5532e2b3b5ddfcfa27 r) {
this = r;
}


public static bool operator == (RC_c97612a27be85a5532e2b3b5ddfcfa27 a, RC_c97612a27be85a5532e2b3b5ddfcfa27 b) {
if (a.ssSTOptionalMarkerConfigs != b.ssSTOptionalMarkerConfigs) return false;
return true;
}

public static bool operator != (RC_c97612a27be85a5532e2b3b5ddfcfa27 a, RC_c97612a27be85a5532e2b3b5ddfcfa27 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c97612a27be85a5532e2b3b5ddfcfa27)) return false;
return (this == (RC_c97612a27be85a5532e2b3b5ddfcfa27)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalMarkerConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalMarkerConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalMarkerConfigs.InternalRecursiveSave();
}


public RC_c97612a27be85a5532e2b3b5ddfcfa27 Duplicate() {
RC_c97612a27be85a5532e2b3b5ddfcfa27 t;
t.ssSTOptionalMarkerConfigs = (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure)this.ssSTOptionalMarkerConfigs.Duplicate();
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
if (head == "optionalmarkerconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalMarkerConfigs")) variable.Value = ssSTOptionalMarkerConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalmarkerconfigs");
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
if (key == IdOptionalMarkerConfigs) {
return ssSTOptionalMarkerConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalMarkerConfigs.Key.AsGuid) {
return ssSTOptionalMarkerConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalMarkerConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalMarkerConfigs));
}
} // RC_c97612a27be85a5532e2b3b5ddfcfa27
/// <summary>
/// RecordList type <code>OptionalMarkerConfigsRecordList</code> that represents a record list of
///  <code>OptionalMarkerConfigs</code>
/// </summary>
public partial class RL_745f22a3ada550afdd2fd2cbc8fe0793 : GenericRecordList<RC_c97612a27be85a5532e2b3b5ddfcfa27>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c97612a27be85a5532e2b3b5ddfcfa27 GetElementDefaultValue() {
return new RC_c97612a27be85a5532e2b3b5ddfcfa27();
}

public T[] ToArray<T>(Func<RC_c97612a27be85a5532e2b3b5ddfcfa27, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_745f22a3ada550afdd2fd2cbc8fe0793 recordList, Func<RC_c97612a27be85a5532e2b3b5ddfcfa27, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_745f22a3ada550afdd2fd2cbc8fe0793(RC_c97612a27be85a5532e2b3b5ddfcfa27[] array) {
  RL_745f22a3ada550afdd2fd2cbc8fe0793 result = new RL_745f22a3ada550afdd2fd2cbc8fe0793();
result.InnerFromArray(array);
    return result;
}

public static RL_745f22a3ada550afdd2fd2cbc8fe0793 ToList<T>(T[] array, Func <T, RC_c97612a27be85a5532e2b3b5ddfcfa27> converter) {
  RL_745f22a3ada550afdd2fd2cbc8fe0793 result = new RL_745f22a3ada550afdd2fd2cbc8fe0793();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_745f22a3ada550afdd2fd2cbc8fe0793 FromRestList<T>(RestList<T> restList, Func <T, RC_c97612a27be85a5532e2b3b5ddfcfa27> converter) {
  RL_745f22a3ada550afdd2fd2cbc8fe0793 result = new RL_745f22a3ada550afdd2fd2cbc8fe0793();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_745f22a3ada550afdd2fd2cbc8fe0793() : base() {
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
protected override OSList<RC_c97612a27be85a5532e2b3b5ddfcfa27> NewList() {
return new RL_745f22a3ada550afdd2fd2cbc8fe0793();
}


} // RL_745f22a3ada550afdd2fd2cbc8fe0793
}

