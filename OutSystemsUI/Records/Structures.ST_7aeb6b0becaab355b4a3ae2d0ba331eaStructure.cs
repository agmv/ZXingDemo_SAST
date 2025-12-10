namespace ssOutSystemsUI {
/// <summary>
/// [Structure] TabsContentItem_InternalConfig (PiTDu4MlhEiA2ilpa_j_Vg)
///  <code>ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure</code> that represent
/// s <code>TabsContentItem_InternalConfig</code> <p>Description: Group of internal configurations for
///  the TabsContentItem block. </p>
/// </summary>
// Name: TabsContentItem_InternalConfig
public partial struct ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure : ITypedRecord<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*rPVssoSp7kS54iKKeNy2Xw");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xc5Z50fFk0K6SymI4OsVHA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure() {
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
ssUniqueId = r.ReadText(index++, "TabsContentItem_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "TabsContentItem_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure r) {
this = r;
}


public static bool operator == (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure a, ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure a, ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure)) return false;
return (this == (ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure)o);
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


public ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure Duplicate() {
ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure t;
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
} // ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure
/// <summary>
/// RecordList type <code>TabsContentItem_InternalConfigList</code> that represents a record list of
///  <code>TabsContentItem_InternalConfig</code>
/// </summary>
public partial class RL_254e9acf50e8fbb70295a333c7fc6cd2 : GenericRecordList<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure GetElementDefaultValue() {
return new ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure();
}

public T[] ToArray<T>(Func<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_254e9acf50e8fbb70295a333c7fc6cd2 recordList, Func<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_254e9acf50e8fbb70295a333c7fc6cd2(ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure[] array) {
  RL_254e9acf50e8fbb70295a333c7fc6cd2 result = new RL_254e9acf50e8fbb70295a333c7fc6cd2();
result.InnerFromArray(array);
    return result;
}

public static RL_254e9acf50e8fbb70295a333c7fc6cd2 ToList<T>(T[] array, Func <T, ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> converter) {
  RL_254e9acf50e8fbb70295a333c7fc6cd2 result = new RL_254e9acf50e8fbb70295a333c7fc6cd2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_254e9acf50e8fbb70295a333c7fc6cd2 FromRestList<T>(RestList<T> restList, Func <T, ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> converter) {
  RL_254e9acf50e8fbb70295a333c7fc6cd2 result = new RL_254e9acf50e8fbb70295a333c7fc6cd2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_254e9acf50e8fbb70295a333c7fc6cd2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7aeb6b0becaab355b4a3ae2d0ba331eaStructure> NewList() {
return new RL_254e9acf50e8fbb70295a333c7fc6cd2();
}


} // RL_254e9acf50e8fbb70295a333c7fc6cd2
}

