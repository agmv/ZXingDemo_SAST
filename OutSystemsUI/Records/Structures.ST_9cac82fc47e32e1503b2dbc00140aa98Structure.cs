namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Tooltip_InternalConfig (wUuRFsR33EqobF1Yv3UOBg)
///  <code>ST_9cac82fc47e32e1503b2dbc00140aa98Structure</code> that represent
/// s <code>Tooltip_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Tooltip block. </p>
/// </summary>
// Name: Tooltip_InternalConfig
public partial struct ST_9cac82fc47e32e1503b2dbc00140aa98Structure : ITypedRecord<ST_9cac82fc47e32e1503b2dbc00140aa98Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*wHkyyaL96kqepsumDgoryA");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*su71DROCzkWD9+MgjMfp6Q");
internal static readonly GlobalObjectKey IdStartVisible = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_dGB97Wm6UmNEj7ZNmV32w");
internal static readonly GlobalObjectKey IdIsHover = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*rpKjThyGGkeexuUeXMCugw");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*e+cCxX7BS0Od8FNPo0_22w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("Position")]
public string ssPosition;

[System.Xml.Serialization.XmlElement("StartVisible")]
public bool ssStartVisible;

[System.Xml.Serialization.XmlElement("IsHover")]
public bool ssIsHover;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_9cac82fc47e32e1503b2dbc00140aa98Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssPosition = "";
ssStartVisible = false;
ssIsHover = false;
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
ssUniqueId = r.ReadText(index++, "Tooltip_InternalConfig.UniqueId", "");
ssPosition = r.ReadEntityReferenceText(index++, "Tooltip_InternalConfig.Position", "");
ssStartVisible = r.ReadBoolean(index++, "Tooltip_InternalConfig.StartVisible", false);
ssIsHover = r.ReadBoolean(index++, "Tooltip_InternalConfig.IsHover", false);
ssExtendedClass = r.ReadText(index++, "Tooltip_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_9cac82fc47e32e1503b2dbc00140aa98Structure r) {
this = r;
}


public static bool operator == (ST_9cac82fc47e32e1503b2dbc00140aa98Structure a, ST_9cac82fc47e32e1503b2dbc00140aa98Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssPosition != b.ssPosition) return false;
if (a.ssStartVisible != b.ssStartVisible) return false;
if (a.ssIsHover != b.ssIsHover) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_9cac82fc47e32e1503b2dbc00140aa98Structure a, ST_9cac82fc47e32e1503b2dbc00140aa98Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9cac82fc47e32e1503b2dbc00140aa98Structure)) return false;
return (this == (ST_9cac82fc47e32e1503b2dbc00140aa98Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssStartVisible.GetHashCode()
 ^ ssIsHover.GetHashCode()
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


public ST_9cac82fc47e32e1503b2dbc00140aa98Structure Duplicate() {
ST_9cac82fc47e32e1503b2dbc00140aa98Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssPosition = this.ssPosition;
t.ssStartVisible = this.ssStartVisible;
t.ssIsHover = this.ssIsHover;
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
} else if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
} else if (head == "startvisible") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartVisible")) variable.Value = ssStartVisible; else variable.Optimized = true;
} else if (head == "ishover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsHover")) variable.Value = ssIsHover; else variable.Optimized = true;
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
if (key == IdPosition) {
return ssPosition;
}
if (key == IdStartVisible) {
return ssStartVisible;
}
if (key == IdIsHover) {
return ssIsHover;
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
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
if (attributeKey == IdStartVisible.Key.AsGuid) {
return ssStartVisible;
}
if (attributeKey == IdIsHover.Key.AsGuid) {
return ssIsHover;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssPosition = (string) other.AttributeGet(IdPosition);
ssStartVisible = (bool) other.AttributeGet(IdStartVisible);
ssIsHover = (bool) other.AttributeGet(IdIsHover);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_9cac82fc47e32e1503b2dbc00140aa98Structure
/// <summary>
/// RecordList type <code>Tooltip_InternalConfigList</code> that represents a record list of
///  <code>Tooltip_InternalConfig</code>
/// </summary>
public partial class RL_51838c970a5f5ffd90e6f16dae1511f6 : GenericRecordList<ST_9cac82fc47e32e1503b2dbc00140aa98Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_9cac82fc47e32e1503b2dbc00140aa98Structure GetElementDefaultValue() {
return new ST_9cac82fc47e32e1503b2dbc00140aa98Structure();
}

public T[] ToArray<T>(Func<ST_9cac82fc47e32e1503b2dbc00140aa98Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_51838c970a5f5ffd90e6f16dae1511f6 recordList, Func<ST_9cac82fc47e32e1503b2dbc00140aa98Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_51838c970a5f5ffd90e6f16dae1511f6(ST_9cac82fc47e32e1503b2dbc00140aa98Structure[] array) {
  RL_51838c970a5f5ffd90e6f16dae1511f6 result = new RL_51838c970a5f5ffd90e6f16dae1511f6();
result.InnerFromArray(array);
    return result;
}

public static RL_51838c970a5f5ffd90e6f16dae1511f6 ToList<T>(T[] array, Func <T, ST_9cac82fc47e32e1503b2dbc00140aa98Structure> converter) {
  RL_51838c970a5f5ffd90e6f16dae1511f6 result = new RL_51838c970a5f5ffd90e6f16dae1511f6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_51838c970a5f5ffd90e6f16dae1511f6 FromRestList<T>(RestList<T> restList, Func <T, ST_9cac82fc47e32e1503b2dbc00140aa98Structure> converter) {
  RL_51838c970a5f5ffd90e6f16dae1511f6 result = new RL_51838c970a5f5ffd90e6f16dae1511f6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_51838c970a5f5ffd90e6f16dae1511f6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9cac82fc47e32e1503b2dbc00140aa98Structure> NewList() {
return new RL_51838c970a5f5ffd90e6f16dae1511f6();
}


} // RL_51838c970a5f5ffd90e6f16dae1511f6
}

