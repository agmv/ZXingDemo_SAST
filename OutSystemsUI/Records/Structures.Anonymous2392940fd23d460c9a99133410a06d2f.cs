namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (D5SSIz3SDEaamRM0EKBtLw)
///  <code>RC_824809bf8c57cb0db3f5d42bbea4d2cf</code> that represent
/// s <code>Video_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Video_InternalConfigRecord
public partial struct RC_824809bf8c57cb0db3f5d42bbea4d2cf : ITypedRecord<RC_824809bf8c57cb0db3f5d42bbea4d2cf> {
internal static readonly GlobalObjectKey IdVideo_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vwlIgleMDcuz9dQrvqTSzw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Video_InternalConfig")]
public ST_87ed820dae13f311d79f7f394fc3790aStructure ssSTVideo_InternalConfig;


public static implicit operator ST_87ed820dae13f311d79f7f394fc3790aStructure( RC_824809bf8c57cb0db3f5d42bbea4d2cf r) {
return r.ssSTVideo_InternalConfig;
}

public static implicit operator RC_824809bf8c57cb0db3f5d42bbea4d2cf (ST_87ed820dae13f311d79f7f394fc3790aStructure r) {
RC_824809bf8c57cb0db3f5d42bbea4d2cf res = new RC_824809bf8c57cb0db3f5d42bbea4d2cf ();
res.ssSTVideo_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_824809bf8c57cb0db3f5d42bbea4d2cf() {
OptimizedAttributes = null;
ssSTVideo_InternalConfig = new ST_87ed820dae13f311d79f7f394fc3790aStructure();
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
    ssSTVideo_InternalConfig.OptimizedAttributes = value[0];
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
ssSTVideo_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_824809bf8c57cb0db3f5d42bbea4d2cf r) {
this = r;
}


public static bool operator == (RC_824809bf8c57cb0db3f5d42bbea4d2cf a, RC_824809bf8c57cb0db3f5d42bbea4d2cf b) {
if (a.ssSTVideo_InternalConfig != b.ssSTVideo_InternalConfig) return false;
return true;
}

public static bool operator != (RC_824809bf8c57cb0db3f5d42bbea4d2cf a, RC_824809bf8c57cb0db3f5d42bbea4d2cf b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_824809bf8c57cb0db3f5d42bbea4d2cf)) return false;
return (this == (RC_824809bf8c57cb0db3f5d42bbea4d2cf)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTVideo_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTVideo_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTVideo_InternalConfig.InternalRecursiveSave();
}


public RC_824809bf8c57cb0db3f5d42bbea4d2cf Duplicate() {
RC_824809bf8c57cb0db3f5d42bbea4d2cf t;
t.ssSTVideo_InternalConfig = (ST_87ed820dae13f311d79f7f394fc3790aStructure)this.ssSTVideo_InternalConfig.Duplicate();
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
if (head == "video_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Video_InternalConfig")) variable.Value = ssSTVideo_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("video_internalconfig");
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
if (key == IdVideo_InternalConfig) {
return ssSTVideo_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVideo_InternalConfig.Key.AsGuid) {
return ssSTVideo_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTVideo_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdVideo_InternalConfig));
}
} // RC_824809bf8c57cb0db3f5d42bbea4d2cf
/// <summary>
/// RecordList type <code>Video_InternalConfigRecordList</code> that represents a record list of
///  <code>Video_InternalConfig</code>
/// </summary>
public partial class RL_1cf429e8bab27b0a835794d4d352252f : GenericRecordList<RC_824809bf8c57cb0db3f5d42bbea4d2cf>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_824809bf8c57cb0db3f5d42bbea4d2cf GetElementDefaultValue() {
return new RC_824809bf8c57cb0db3f5d42bbea4d2cf();
}

public T[] ToArray<T>(Func<RC_824809bf8c57cb0db3f5d42bbea4d2cf, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1cf429e8bab27b0a835794d4d352252f recordList, Func<RC_824809bf8c57cb0db3f5d42bbea4d2cf, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1cf429e8bab27b0a835794d4d352252f(RC_824809bf8c57cb0db3f5d42bbea4d2cf[] array) {
  RL_1cf429e8bab27b0a835794d4d352252f result = new RL_1cf429e8bab27b0a835794d4d352252f();
result.InnerFromArray(array);
    return result;
}

public static RL_1cf429e8bab27b0a835794d4d352252f ToList<T>(T[] array, Func <T, RC_824809bf8c57cb0db3f5d42bbea4d2cf> converter) {
  RL_1cf429e8bab27b0a835794d4d352252f result = new RL_1cf429e8bab27b0a835794d4d352252f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1cf429e8bab27b0a835794d4d352252f FromRestList<T>(RestList<T> restList, Func <T, RC_824809bf8c57cb0db3f5d42bbea4d2cf> converter) {
  RL_1cf429e8bab27b0a835794d4d352252f result = new RL_1cf429e8bab27b0a835794d4d352252f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1cf429e8bab27b0a835794d4d352252f() : base() {
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
protected override OSList<RC_824809bf8c57cb0db3f5d42bbea4d2cf> NewList() {
return new RL_1cf429e8bab27b0a835794d4d352252f();
}


} // RL_1cf429e8bab27b0a835794d4d352252f
}

