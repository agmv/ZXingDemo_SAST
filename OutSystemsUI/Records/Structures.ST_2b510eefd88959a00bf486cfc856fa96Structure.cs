namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ButtonLoading_InternalConfig (gsThAqMe20ya_yRw4Ey_rw)
///  <code>ST_2b510eefd88959a00bf486cfc856fa96Structure</code> that represent
/// s <code>ButtonLoading_InternalConfig</code> <p>Description: Group of internal configurations for
///  the ButtonLoading block. </p>
/// </summary>
// Name: ButtonLoading_InternalConfig
public partial struct ST_2b510eefd88959a00bf486cfc856fa96Structure : ITypedRecord<ST_2b510eefd88959a00bf486cfc856fa96Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KdWcGOtXJ0SeaJBx6X3nGw");
internal static readonly GlobalObjectKey IdIsLoading = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*kRZEt_Zaw0yW1mTFAO1l3Q");
internal static readonly GlobalObjectKey IdShowLoadingAndLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xLRJz9ipVkm3sshJN2in7g");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*flmtKjV+ok2h7SD0VhN5ew");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("IsLoading")]
public bool ssIsLoading;

[System.Xml.Serialization.XmlElement("ShowLoadingAndLabel")]
public bool ssShowLoadingAndLabel;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_2b510eefd88959a00bf486cfc856fa96Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssIsLoading = false;
ssShowLoadingAndLabel = false;
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
ssUniqueId = r.ReadText(index++, "ButtonLoading_InternalConfig.UniqueId", "");
ssIsLoading = r.ReadBoolean(index++, "ButtonLoading_InternalConfig.IsLoading", false);
ssShowLoadingAndLabel = r.ReadBoolean(index++, "ButtonLoading_InternalConfig.ShowLoadingAndLabel", false);
ssExtendedClass = r.ReadText(index++, "ButtonLoading_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_2b510eefd88959a00bf486cfc856fa96Structure r) {
this = r;
}


public static bool operator == (ST_2b510eefd88959a00bf486cfc856fa96Structure a, ST_2b510eefd88959a00bf486cfc856fa96Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssIsLoading != b.ssIsLoading) return false;
if (a.ssShowLoadingAndLabel != b.ssShowLoadingAndLabel) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_2b510eefd88959a00bf486cfc856fa96Structure a, ST_2b510eefd88959a00bf486cfc856fa96Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2b510eefd88959a00bf486cfc856fa96Structure)) return false;
return (this == (ST_2b510eefd88959a00bf486cfc856fa96Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssIsLoading.GetHashCode()
 ^ ssShowLoadingAndLabel.GetHashCode()
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


public ST_2b510eefd88959a00bf486cfc856fa96Structure Duplicate() {
ST_2b510eefd88959a00bf486cfc856fa96Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssIsLoading = this.ssIsLoading;
t.ssShowLoadingAndLabel = this.ssShowLoadingAndLabel;
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
} else if (head == "isloading") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsLoading")) variable.Value = ssIsLoading; else variable.Optimized = true;
} else if (head == "showloadingandlabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowLoadingAndLabel")) variable.Value = ssShowLoadingAndLabel; else variable.Optimized = true;
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
if (key == IdIsLoading) {
return ssIsLoading;
}
if (key == IdShowLoadingAndLabel) {
return ssShowLoadingAndLabel;
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
if (attributeKey == IdIsLoading.Key.AsGuid) {
return ssIsLoading;
}
if (attributeKey == IdShowLoadingAndLabel.Key.AsGuid) {
return ssShowLoadingAndLabel;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssIsLoading = (bool) other.AttributeGet(IdIsLoading);
ssShowLoadingAndLabel = (bool) other.AttributeGet(IdShowLoadingAndLabel);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_2b510eefd88959a00bf486cfc856fa96Structure
/// <summary>
/// RecordList type <code>ButtonLoading_InternalConfigList</code> that represents a record list of
///  <code>ButtonLoading_InternalConfig</code>
/// </summary>
public partial class RL_b99a910a43a035ae4af35109fcbd78bb : GenericRecordList<ST_2b510eefd88959a00bf486cfc856fa96Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_2b510eefd88959a00bf486cfc856fa96Structure GetElementDefaultValue() {
return new ST_2b510eefd88959a00bf486cfc856fa96Structure();
}

public T[] ToArray<T>(Func<ST_2b510eefd88959a00bf486cfc856fa96Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b99a910a43a035ae4af35109fcbd78bb recordList, Func<ST_2b510eefd88959a00bf486cfc856fa96Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b99a910a43a035ae4af35109fcbd78bb(ST_2b510eefd88959a00bf486cfc856fa96Structure[] array) {
  RL_b99a910a43a035ae4af35109fcbd78bb result = new RL_b99a910a43a035ae4af35109fcbd78bb();
result.InnerFromArray(array);
    return result;
}

public static RL_b99a910a43a035ae4af35109fcbd78bb ToList<T>(T[] array, Func <T, ST_2b510eefd88959a00bf486cfc856fa96Structure> converter) {
  RL_b99a910a43a035ae4af35109fcbd78bb result = new RL_b99a910a43a035ae4af35109fcbd78bb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b99a910a43a035ae4af35109fcbd78bb FromRestList<T>(RestList<T> restList, Func <T, ST_2b510eefd88959a00bf486cfc856fa96Structure> converter) {
  RL_b99a910a43a035ae4af35109fcbd78bb result = new RL_b99a910a43a035ae4af35109fcbd78bb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b99a910a43a035ae4af35109fcbd78bb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2b510eefd88959a00bf486cfc856fa96Structure> NewList() {
return new RL_b99a910a43a035ae4af35109fcbd78bb();
}


} // RL_b99a910a43a035ae4af35109fcbd78bb
}

