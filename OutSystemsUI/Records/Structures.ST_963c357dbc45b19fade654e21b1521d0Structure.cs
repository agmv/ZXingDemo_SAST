namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Sidebar_InternalConfig (uy9IfgsjWUuQ4uDwNPw9rw)
///  <code>ST_963c357dbc45b19fade654e21b1521d0Structure</code> that represent
/// s <code>Sidebar_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Sidebar block. </p>
/// </summary>
// Name: Sidebar_InternalConfig
public partial struct ST_963c357dbc45b19fade654e21b1521d0Structure : ITypedRecord<ST_963c357dbc45b19fade654e21b1521d0Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*rwjDvQBbqUiB3Vp8dyANvw");
internal static readonly GlobalObjectKey IdStartsOpen = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*An+bHe5HmkGltBMhfZhw3Q");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*CbYbF63kiU+L6Z6d0qnWgA");
internal static readonly GlobalObjectKey IdWidth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*uHYynQOhN024CigZ6Xp_Dw");
internal static readonly GlobalObjectKey IdHasOverlay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_WLSvXaR_Eu6jx9huuLtqQ");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6hlcXGgzAkGuYsz45Mz8sA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("StartsOpen")]
public bool ssStartsOpen;

[System.Xml.Serialization.XmlElement("Direction")]
public string ssDirection;

[System.Xml.Serialization.XmlElement("Width")]
public string ssWidth;

[System.Xml.Serialization.XmlElement("HasOverlay")]
public bool ssHasOverlay;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_963c357dbc45b19fade654e21b1521d0Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssStartsOpen = false;
ssDirection = "";
ssWidth = "";
ssHasOverlay = false;
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
ssUniqueId = r.ReadText(index++, "Sidebar_InternalConfig.UniqueId", "");
ssStartsOpen = r.ReadBoolean(index++, "Sidebar_InternalConfig.StartsOpen", false);
ssDirection = r.ReadEntityReferenceText(index++, "Sidebar_InternalConfig.Direction", "");
ssWidth = r.ReadText(index++, "Sidebar_InternalConfig.Width", "");
ssHasOverlay = r.ReadBoolean(index++, "Sidebar_InternalConfig.HasOverlay", false);
ssExtendedClass = r.ReadText(index++, "Sidebar_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_963c357dbc45b19fade654e21b1521d0Structure r) {
this = r;
}


public static bool operator == (ST_963c357dbc45b19fade654e21b1521d0Structure a, ST_963c357dbc45b19fade654e21b1521d0Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssStartsOpen != b.ssStartsOpen) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssWidth != b.ssWidth) return false;
if (a.ssHasOverlay != b.ssHasOverlay) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_963c357dbc45b19fade654e21b1521d0Structure a, ST_963c357dbc45b19fade654e21b1521d0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_963c357dbc45b19fade654e21b1521d0Structure)) return false;
return (this == (ST_963c357dbc45b19fade654e21b1521d0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssStartsOpen.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssWidth.GetHashCode()
 ^ ssHasOverlay.GetHashCode()
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


public ST_963c357dbc45b19fade654e21b1521d0Structure Duplicate() {
ST_963c357dbc45b19fade654e21b1521d0Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssStartsOpen = this.ssStartsOpen;
t.ssDirection = this.ssDirection;
t.ssWidth = this.ssWidth;
t.ssHasOverlay = this.ssHasOverlay;
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
} else if (head == "startsopen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartsOpen")) variable.Value = ssStartsOpen; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "width") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Width")) variable.Value = ssWidth; else variable.Optimized = true;
} else if (head == "hasoverlay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasOverlay")) variable.Value = ssHasOverlay; else variable.Optimized = true;
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
if (key == IdStartsOpen) {
return ssStartsOpen;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdWidth) {
return ssWidth;
}
if (key == IdHasOverlay) {
return ssHasOverlay;
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
if (attributeKey == IdStartsOpen.Key.AsGuid) {
return ssStartsOpen;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdWidth.Key.AsGuid) {
return ssWidth;
}
if (attributeKey == IdHasOverlay.Key.AsGuid) {
return ssHasOverlay;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssStartsOpen = (bool) other.AttributeGet(IdStartsOpen);
ssDirection = (string) other.AttributeGet(IdDirection);
ssWidth = (string) other.AttributeGet(IdWidth);
ssHasOverlay = (bool) other.AttributeGet(IdHasOverlay);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_963c357dbc45b19fade654e21b1521d0Structure
/// <summary>
/// RecordList type <code>Sidebar_InternalConfigList</code> that represents a record list of
///  <code>Sidebar_InternalConfig</code>
/// </summary>
public partial class RL_88055e7d64e095cc2917570a8093617e : GenericRecordList<ST_963c357dbc45b19fade654e21b1521d0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_963c357dbc45b19fade654e21b1521d0Structure GetElementDefaultValue() {
return new ST_963c357dbc45b19fade654e21b1521d0Structure();
}

public T[] ToArray<T>(Func<ST_963c357dbc45b19fade654e21b1521d0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_88055e7d64e095cc2917570a8093617e recordList, Func<ST_963c357dbc45b19fade654e21b1521d0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_88055e7d64e095cc2917570a8093617e(ST_963c357dbc45b19fade654e21b1521d0Structure[] array) {
  RL_88055e7d64e095cc2917570a8093617e result = new RL_88055e7d64e095cc2917570a8093617e();
result.InnerFromArray(array);
    return result;
}

public static RL_88055e7d64e095cc2917570a8093617e ToList<T>(T[] array, Func <T, ST_963c357dbc45b19fade654e21b1521d0Structure> converter) {
  RL_88055e7d64e095cc2917570a8093617e result = new RL_88055e7d64e095cc2917570a8093617e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_88055e7d64e095cc2917570a8093617e FromRestList<T>(RestList<T> restList, Func <T, ST_963c357dbc45b19fade654e21b1521d0Structure> converter) {
  RL_88055e7d64e095cc2917570a8093617e result = new RL_88055e7d64e095cc2917570a8093617e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_88055e7d64e095cc2917570a8093617e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_963c357dbc45b19fade654e21b1521d0Structure> NewList() {
return new RL_88055e7d64e095cc2917570a8093617e();
}


} // RL_88055e7d64e095cc2917570a8093617e
}

