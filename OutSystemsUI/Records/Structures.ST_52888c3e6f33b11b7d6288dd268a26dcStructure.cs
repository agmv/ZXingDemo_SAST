namespace ssOutSystemsUI {
/// <summary>
/// [Structure] AnimatedLabel_InternalConfig (I4iItZoll0mOjwr4m8Ndrg)
///  <code>ST_52888c3e6f33b11b7d6288dd268a26dcStructure</code> that represent
/// s <code>AnimatedLabel_InternalConfig</code> <p>Description: Group of internal configurations for
///  the AnimatedLabel block. </p>
/// </summary>
// Name: AnimatedLabel_InternalConfig
public partial struct ST_52888c3e6f33b11b7d6288dd268a26dcStructure : ITypedRecord<ST_52888c3e6f33b11b7d6288dd268a26dcStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*0mPul2uUdUS4XzNlcuAX2A");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*c2B6p4_xp0ulyadNCqs1og");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_52888c3e6f33b11b7d6288dd268a26dcStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssExtendedClass = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssUniqueId = r.ReadText(index++, "AnimatedLabel_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "AnimatedLabel_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_52888c3e6f33b11b7d6288dd268a26dcStructure r) {
this = r;
}


public static bool operator == (ST_52888c3e6f33b11b7d6288dd268a26dcStructure a, ST_52888c3e6f33b11b7d6288dd268a26dcStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_52888c3e6f33b11b7d6288dd268a26dcStructure a, ST_52888c3e6f33b11b7d6288dd268a26dcStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_52888c3e6f33b11b7d6288dd268a26dcStructure)) return false;
return (this == (ST_52888c3e6f33b11b7d6288dd268a26dcStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_52888c3e6f33b11b7d6288dd268a26dcStructure Duplicate() {
ST_52888c3e6f33b11b7d6288dd268a26dcStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssExtendedClass = this.ssExtendedClass;
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
if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
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
if (key == IdUniqueId) {
return ssUniqueId;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_52888c3e6f33b11b7d6288dd268a26dcStructure
/// <summary>
/// RecordList type <code>AnimatedLabel_InternalConfigList</code> that represents a record list of
///  <code>AnimatedLabel_InternalConfig</code>
/// </summary>
public partial class RL_29abfa51de4d470d3279317a334d5530 : GenericRecordList<ST_52888c3e6f33b11b7d6288dd268a26dcStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_52888c3e6f33b11b7d6288dd268a26dcStructure GetElementDefaultValue() {
return new ST_52888c3e6f33b11b7d6288dd268a26dcStructure();
}

public T[] ToArray<T>(Func<ST_52888c3e6f33b11b7d6288dd268a26dcStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_29abfa51de4d470d3279317a334d5530 recordList, Func<ST_52888c3e6f33b11b7d6288dd268a26dcStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_29abfa51de4d470d3279317a334d5530(ST_52888c3e6f33b11b7d6288dd268a26dcStructure[] array) {
  RL_29abfa51de4d470d3279317a334d5530 result = new RL_29abfa51de4d470d3279317a334d5530();
result.InnerFromArray(array);
    return result;
}

public static RL_29abfa51de4d470d3279317a334d5530 ToList<T>(T[] array, Func <T, ST_52888c3e6f33b11b7d6288dd268a26dcStructure> converter) {
  RL_29abfa51de4d470d3279317a334d5530 result = new RL_29abfa51de4d470d3279317a334d5530();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_29abfa51de4d470d3279317a334d5530 FromRestList<T>(RestList<T> restList, Func <T, ST_52888c3e6f33b11b7d6288dd268a26dcStructure> converter) {
  RL_29abfa51de4d470d3279317a334d5530 result = new RL_29abfa51de4d470d3279317a334d5530();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_29abfa51de4d470d3279317a334d5530() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_52888c3e6f33b11b7d6288dd268a26dcStructure> NewList() {
return new RL_29abfa51de4d470d3279317a334d5530();
}


} // RL_29abfa51de4d470d3279317a334d5530
}

