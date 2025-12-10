namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Notification_InternalConfig (pJCIqFm75Um6WdudXUPtxA)
///  <code>ST_46bd5f77d899939eaf145ae01d3efd6bStructure</code> that represent
/// s <code>Notification_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Notification block. </p>
/// </summary>
// Name: Notification_InternalConfig
public partial struct ST_46bd5f77d899939eaf145ae01d3efd6bStructure : ITypedRecord<ST_46bd5f77d899939eaf145ae01d3efd6bStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jbopIBgZmUKIqfkV26xxxA");
internal static readonly GlobalObjectKey IdStartsOpen = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*QYQM6eYOj0qkaerJ3zmN+Q");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*B78g8yLL3U2BS7zOy7d_BQ");
internal static readonly GlobalObjectKey IdWidth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6LMBfgM1P0qcJddQ_E6+1w");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*aC8ydDTe20KzFCiQ21d4Gg");
internal static readonly GlobalObjectKey IdCloseAfterTime = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*h8Vinv_9KkSHUWUo0kvjKA");
internal static readonly GlobalObjectKey IdInteractToClose = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MOoR2zdxAUGAL6usOIl5bA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("StartsOpen")]
public bool ssStartsOpen;

[System.Xml.Serialization.XmlElement("Position")]
public string ssPosition;

[System.Xml.Serialization.XmlElement("Width")]
public string ssWidth;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("CloseAfterTime")]
public int ssCloseAfterTime;

[System.Xml.Serialization.XmlElement("InteractToClose")]
public bool ssInteractToClose;


public BitArray OptimizedAttributes;

public ST_46bd5f77d899939eaf145ae01d3efd6bStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssStartsOpen = false;
ssPosition = "";
ssWidth = "";
ssExtendedClass = "";
ssCloseAfterTime = 0;
ssInteractToClose = false;
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
ssUniqueId = r.ReadText(index++, "Notification_InternalConfig.UniqueId", "");
ssStartsOpen = r.ReadBoolean(index++, "Notification_InternalConfig.StartsOpen", false);
ssPosition = r.ReadEntityReferenceText(index++, "Notification_InternalConfig.Position", "");
ssWidth = r.ReadText(index++, "Notification_InternalConfig.Width", "");
ssExtendedClass = r.ReadText(index++, "Notification_InternalConfig.ExtendedClass", "");
ssCloseAfterTime = r.ReadInteger(index++, "Notification_InternalConfig.CloseAfterTime", 0);
ssInteractToClose = r.ReadBoolean(index++, "Notification_InternalConfig.InteractToClose", false);
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
public void ReadIM(ST_46bd5f77d899939eaf145ae01d3efd6bStructure r) {
this = r;
}


public static bool operator == (ST_46bd5f77d899939eaf145ae01d3efd6bStructure a, ST_46bd5f77d899939eaf145ae01d3efd6bStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssStartsOpen != b.ssStartsOpen) return false;
if (a.ssPosition != b.ssPosition) return false;
if (a.ssWidth != b.ssWidth) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssCloseAfterTime != b.ssCloseAfterTime) return false;
if (a.ssInteractToClose != b.ssInteractToClose) return false;
return true;
}

public static bool operator != (ST_46bd5f77d899939eaf145ae01d3efd6bStructure a, ST_46bd5f77d899939eaf145ae01d3efd6bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_46bd5f77d899939eaf145ae01d3efd6bStructure)) return false;
return (this == (ST_46bd5f77d899939eaf145ae01d3efd6bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssStartsOpen.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssWidth.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssCloseAfterTime.GetHashCode()
 ^ ssInteractToClose.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_46bd5f77d899939eaf145ae01d3efd6bStructure Duplicate() {
ST_46bd5f77d899939eaf145ae01d3efd6bStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssStartsOpen = this.ssStartsOpen;
t.ssPosition = this.ssPosition;
t.ssWidth = this.ssWidth;
t.ssExtendedClass = this.ssExtendedClass;
t.ssCloseAfterTime = this.ssCloseAfterTime;
t.ssInteractToClose = this.ssInteractToClose;
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
} else if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
} else if (head == "width") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Width")) variable.Value = ssWidth; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "closeaftertime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CloseAfterTime")) variable.Value = ssCloseAfterTime; else variable.Optimized = true;
} else if (head == "interacttoclose") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InteractToClose")) variable.Value = ssInteractToClose; else variable.Optimized = true;
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
if (key == IdPosition) {
return ssPosition;
}
if (key == IdWidth) {
return ssWidth;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
if (key == IdCloseAfterTime) {
return ssCloseAfterTime;
}
if (key == IdInteractToClose) {
return ssInteractToClose;
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
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
if (attributeKey == IdWidth.Key.AsGuid) {
return ssWidth;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
if (attributeKey == IdCloseAfterTime.Key.AsGuid) {
return ssCloseAfterTime;
}
if (attributeKey == IdInteractToClose.Key.AsGuid) {
return ssInteractToClose;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssStartsOpen = (bool) other.AttributeGet(IdStartsOpen);
ssPosition = (string) other.AttributeGet(IdPosition);
ssWidth = (string) other.AttributeGet(IdWidth);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssCloseAfterTime = (int) other.AttributeGet(IdCloseAfterTime);
ssInteractToClose = (bool) other.AttributeGet(IdInteractToClose);
}
} // ST_46bd5f77d899939eaf145ae01d3efd6bStructure
/// <summary>
/// RecordList type <code>Notification_InternalConfigList</code> that represents a record list of
///  <code>Notification_InternalConfig</code>
/// </summary>
public partial class RL_63ccb429e57f95e7ed9716b41b4e2342 : GenericRecordList<ST_46bd5f77d899939eaf145ae01d3efd6bStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_46bd5f77d899939eaf145ae01d3efd6bStructure GetElementDefaultValue() {
return new ST_46bd5f77d899939eaf145ae01d3efd6bStructure();
}

public T[] ToArray<T>(Func<ST_46bd5f77d899939eaf145ae01d3efd6bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_63ccb429e57f95e7ed9716b41b4e2342 recordList, Func<ST_46bd5f77d899939eaf145ae01d3efd6bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_63ccb429e57f95e7ed9716b41b4e2342(ST_46bd5f77d899939eaf145ae01d3efd6bStructure[] array) {
  RL_63ccb429e57f95e7ed9716b41b4e2342 result = new RL_63ccb429e57f95e7ed9716b41b4e2342();
result.InnerFromArray(array);
    return result;
}

public static RL_63ccb429e57f95e7ed9716b41b4e2342 ToList<T>(T[] array, Func <T, ST_46bd5f77d899939eaf145ae01d3efd6bStructure> converter) {
  RL_63ccb429e57f95e7ed9716b41b4e2342 result = new RL_63ccb429e57f95e7ed9716b41b4e2342();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_63ccb429e57f95e7ed9716b41b4e2342 FromRestList<T>(RestList<T> restList, Func <T, ST_46bd5f77d899939eaf145ae01d3efd6bStructure> converter) {
  RL_63ccb429e57f95e7ed9716b41b4e2342 result = new RL_63ccb429e57f95e7ed9716b41b4e2342();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_63ccb429e57f95e7ed9716b41b4e2342() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_46bd5f77d899939eaf145ae01d3efd6bStructure> NewList() {
return new RL_63ccb429e57f95e7ed9716b41b4e2342();
}


} // RL_63ccb429e57f95e7ed9716b41b4e2342
}

