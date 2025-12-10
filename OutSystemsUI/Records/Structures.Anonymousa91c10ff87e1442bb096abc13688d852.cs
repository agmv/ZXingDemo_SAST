namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (_xAcqeGHK0SwlqvBNojYUg)
///  <code>RC_dd0070f225e242673216fed1481d0a20</code> that represent
/// s <code>Gallery_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Gallery_InternalConfigRecord
public partial struct RC_dd0070f225e242673216fed1481d0a20 : ITypedRecord<RC_dd0070f225e242673216fed1481d0a20> {
internal static readonly GlobalObjectKey IdGallery_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8nAA3eIlZ0IyFv7RSB0KIA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Gallery_InternalConfig")]
public ST_546a3060996e070a522a708cd2d94c23Structure ssSTGallery_InternalConfig;


public static implicit operator ST_546a3060996e070a522a708cd2d94c23Structure( RC_dd0070f225e242673216fed1481d0a20 r) {
return r.ssSTGallery_InternalConfig;
}

public static implicit operator RC_dd0070f225e242673216fed1481d0a20 (ST_546a3060996e070a522a708cd2d94c23Structure r) {
RC_dd0070f225e242673216fed1481d0a20 res = new RC_dd0070f225e242673216fed1481d0a20 ();
res.ssSTGallery_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dd0070f225e242673216fed1481d0a20() {
OptimizedAttributes = null;
ssSTGallery_InternalConfig = new ST_546a3060996e070a522a708cd2d94c23Structure();
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
    ssSTGallery_InternalConfig.OptimizedAttributes = value[0];
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
ssSTGallery_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_dd0070f225e242673216fed1481d0a20 r) {
this = r;
}


public static bool operator == (RC_dd0070f225e242673216fed1481d0a20 a, RC_dd0070f225e242673216fed1481d0a20 b) {
if (a.ssSTGallery_InternalConfig != b.ssSTGallery_InternalConfig) return false;
return true;
}

public static bool operator != (RC_dd0070f225e242673216fed1481d0a20 a, RC_dd0070f225e242673216fed1481d0a20 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dd0070f225e242673216fed1481d0a20)) return false;
return (this == (RC_dd0070f225e242673216fed1481d0a20)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTGallery_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTGallery_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTGallery_InternalConfig.InternalRecursiveSave();
}


public RC_dd0070f225e242673216fed1481d0a20 Duplicate() {
RC_dd0070f225e242673216fed1481d0a20 t;
t.ssSTGallery_InternalConfig = (ST_546a3060996e070a522a708cd2d94c23Structure)this.ssSTGallery_InternalConfig.Duplicate();
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
if (head == "gallery_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Gallery_InternalConfig")) variable.Value = ssSTGallery_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("gallery_internalconfig");
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
if (key == IdGallery_InternalConfig) {
return ssSTGallery_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGallery_InternalConfig.Key.AsGuid) {
return ssSTGallery_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTGallery_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdGallery_InternalConfig));
}
} // RC_dd0070f225e242673216fed1481d0a20
/// <summary>
/// RecordList type <code>Gallery_InternalConfigRecordList</code> that represents a record list of
///  <code>Gallery_InternalConfig</code>
/// </summary>
public partial class RL_ef0927b1b88ce156242cd5fb3fc4da55 : GenericRecordList<RC_dd0070f225e242673216fed1481d0a20>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_dd0070f225e242673216fed1481d0a20 GetElementDefaultValue() {
return new RC_dd0070f225e242673216fed1481d0a20();
}

public T[] ToArray<T>(Func<RC_dd0070f225e242673216fed1481d0a20, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ef0927b1b88ce156242cd5fb3fc4da55 recordList, Func<RC_dd0070f225e242673216fed1481d0a20, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ef0927b1b88ce156242cd5fb3fc4da55(RC_dd0070f225e242673216fed1481d0a20[] array) {
  RL_ef0927b1b88ce156242cd5fb3fc4da55 result = new RL_ef0927b1b88ce156242cd5fb3fc4da55();
result.InnerFromArray(array);
    return result;
}

public static RL_ef0927b1b88ce156242cd5fb3fc4da55 ToList<T>(T[] array, Func <T, RC_dd0070f225e242673216fed1481d0a20> converter) {
  RL_ef0927b1b88ce156242cd5fb3fc4da55 result = new RL_ef0927b1b88ce156242cd5fb3fc4da55();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ef0927b1b88ce156242cd5fb3fc4da55 FromRestList<T>(RestList<T> restList, Func <T, RC_dd0070f225e242673216fed1481d0a20> converter) {
  RL_ef0927b1b88ce156242cd5fb3fc4da55 result = new RL_ef0927b1b88ce156242cd5fb3fc4da55();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ef0927b1b88ce156242cd5fb3fc4da55() : base() {
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
protected override OSList<RC_dd0070f225e242673216fed1481d0a20> NewList() {
return new RL_ef0927b1b88ce156242cd5fb3fc4da55();
}


} // RL_ef0927b1b88ce156242cd5fb3fc4da55
}

