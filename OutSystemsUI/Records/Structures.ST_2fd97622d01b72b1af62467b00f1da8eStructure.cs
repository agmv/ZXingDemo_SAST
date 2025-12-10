namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ProgressCircle_InternalConfig (uYX1Y5o6eEyg+FMLec303w)
///  <code>ST_2fd97622d01b72b1af62467b00f1da8eStructure</code> that represent
/// s <code>ProgressCircle_InternalConfig</code> <p>Description: Group of internal configurations for
///  the Progress block. </p>
/// </summary>
// Name: ProgressCircle_InternalConfig
public partial struct ST_2fd97622d01b72b1af62467b00f1da8eStructure : ITypedRecord<ST_2fd97622d01b72b1af62467b00f1da8eStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*3oKwLMlZDUmQcbWIKR3qhA");
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*evxhuLVOjkCVqXM_0_8Jgg");
internal static readonly GlobalObjectKey IdProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*g6nIIWXM10eK2LF8_gV5ug");
internal static readonly GlobalObjectKey IdProgressColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*o2TTZoE6CEyAQXc9iPWrtA");
internal static readonly GlobalObjectKey IdProgressCircleSize = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*OSmSf12Rr0G7RKfncrV_5g");
internal static readonly GlobalObjectKey IdTrailColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KZw8QvuqAkWB8oQGU8G5HA");
internal static readonly GlobalObjectKey IdThickness = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*nd6DCLVzPUG_dkHotczWwQ");
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*GjS2ROQ5z02Q+I6SwUAYAQ");
internal static readonly GlobalObjectKey IdAnimateInitialProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*DWC77mJmw0ul5eTyod9_5Q");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*PL8A3AhWtEm5FBl56dpP1w");
internal static readonly GlobalObjectKey IdInitialProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*bnQVQZfDA0a_AVUHGw88lw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("Type")]
public string ssType;

[System.Xml.Serialization.XmlElement("Progress")]
public int ssProgress;

[System.Xml.Serialization.XmlElement("ProgressColor")]
public string ssProgressColor;

[System.Xml.Serialization.XmlElement("ProgressCircleSize")]
public string ssProgressCircleSize;

[System.Xml.Serialization.XmlElement("TrailColor")]
public string ssTrailColor;

[System.Xml.Serialization.XmlElement("Thickness")]
public int ssThickness;

[System.Xml.Serialization.XmlElement("Shape")]
public string ssShape;

[System.Xml.Serialization.XmlElement("AnimateInitialProgress")]
public bool ssAnimateInitialProgress;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("InitialProgress")]
public int ssInitialProgress;


public BitArray OptimizedAttributes;

public ST_2fd97622d01b72b1af62467b00f1da8eStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssType = "";
ssProgress = 0;
ssProgressColor = "";
ssProgressCircleSize = "";
ssTrailColor = "";
ssThickness = 0;
ssShape = (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("aSIM8gonskO6Kb2Pv_JRnw"))).ssShape;
ssAnimateInitialProgress = true;
ssExtendedClass = "";
ssInitialProgress = 0;
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
ssUniqueId = r.ReadText(index++, "ProgressCircle_InternalConfig.UniqueId", "");
ssType = r.ReadEntityReferenceText(index++, "ProgressCircle_InternalConfig.Type", "");
ssProgress = r.ReadInteger(index++, "ProgressCircle_InternalConfig.Progress", 0);
ssProgressColor = r.ReadEntityReferenceText(index++, "ProgressCircle_InternalConfig.ProgressColor", "");
ssProgressCircleSize = r.ReadText(index++, "ProgressCircle_InternalConfig.ProgressCircleSize", "");
ssTrailColor = r.ReadEntityReferenceText(index++, "ProgressCircle_InternalConfig.TrailColor", "");
ssThickness = r.ReadInteger(index++, "ProgressCircle_InternalConfig.Thickness", 0);
ssShape = r.ReadEntityReferenceText(index++, "ProgressCircle_InternalConfig.Shape", "");
ssAnimateInitialProgress = r.ReadBoolean(index++, "ProgressCircle_InternalConfig.AnimateInitialProgress", false);
ssExtendedClass = r.ReadText(index++, "ProgressCircle_InternalConfig.ExtendedClass", "");
ssInitialProgress = r.ReadInteger(index++, "ProgressCircle_InternalConfig.InitialProgress", 0);
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
public void ReadIM(ST_2fd97622d01b72b1af62467b00f1da8eStructure r) {
this = r;
}


public static bool operator == (ST_2fd97622d01b72b1af62467b00f1da8eStructure a, ST_2fd97622d01b72b1af62467b00f1da8eStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssType != b.ssType) return false;
if (a.ssProgress != b.ssProgress) return false;
if (a.ssProgressColor != b.ssProgressColor) return false;
if (a.ssProgressCircleSize != b.ssProgressCircleSize) return false;
if (a.ssTrailColor != b.ssTrailColor) return false;
if (a.ssThickness != b.ssThickness) return false;
if (a.ssShape != b.ssShape) return false;
if (a.ssAnimateInitialProgress != b.ssAnimateInitialProgress) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssInitialProgress != b.ssInitialProgress) return false;
return true;
}

public static bool operator != (ST_2fd97622d01b72b1af62467b00f1da8eStructure a, ST_2fd97622d01b72b1af62467b00f1da8eStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2fd97622d01b72b1af62467b00f1da8eStructure)) return false;
return (this == (ST_2fd97622d01b72b1af62467b00f1da8eStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssType.GetHashCode()
 ^ ssProgress.GetHashCode()
 ^ ssProgressColor.GetHashCode()
 ^ ssProgressCircleSize.GetHashCode()
 ^ ssTrailColor.GetHashCode()
 ^ ssThickness.GetHashCode()
 ^ ssShape.GetHashCode()
 ^ ssAnimateInitialProgress.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssInitialProgress.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_2fd97622d01b72b1af62467b00f1da8eStructure Duplicate() {
ST_2fd97622d01b72b1af62467b00f1da8eStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssType = this.ssType;
t.ssProgress = this.ssProgress;
t.ssProgressColor = this.ssProgressColor;
t.ssProgressCircleSize = this.ssProgressCircleSize;
t.ssTrailColor = this.ssTrailColor;
t.ssThickness = this.ssThickness;
t.ssShape = this.ssShape;
t.ssAnimateInitialProgress = this.ssAnimateInitialProgress;
t.ssExtendedClass = this.ssExtendedClass;
t.ssInitialProgress = this.ssInitialProgress;
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
} else if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
} else if (head == "progress") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Progress")) variable.Value = ssProgress; else variable.Optimized = true;
} else if (head == "progresscolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressColor")) variable.Value = ssProgressColor; else variable.Optimized = true;
} else if (head == "progresscirclesize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressCircleSize")) variable.Value = ssProgressCircleSize; else variable.Optimized = true;
} else if (head == "trailcolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TrailColor")) variable.Value = ssTrailColor; else variable.Optimized = true;
} else if (head == "thickness") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Thickness")) variable.Value = ssThickness; else variable.Optimized = true;
} else if (head == "shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Shape")) variable.Value = ssShape; else variable.Optimized = true;
} else if (head == "animateinitialprogress") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AnimateInitialProgress")) variable.Value = ssAnimateInitialProgress; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "initialprogress") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialProgress")) variable.Value = ssInitialProgress; else variable.Optimized = true;
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
if (key == IdType) {
return ssType;
}
if (key == IdProgress) {
return ssProgress;
}
if (key == IdProgressColor) {
return ssProgressColor;
}
if (key == IdProgressCircleSize) {
return ssProgressCircleSize;
}
if (key == IdTrailColor) {
return ssTrailColor;
}
if (key == IdThickness) {
return ssThickness;
}
if (key == IdShape) {
return ssShape;
}
if (key == IdAnimateInitialProgress) {
return ssAnimateInitialProgress;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
if (key == IdInitialProgress) {
return ssInitialProgress;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
}
if (attributeKey == IdProgress.Key.AsGuid) {
return ssProgress;
}
if (attributeKey == IdProgressColor.Key.AsGuid) {
return ssProgressColor;
}
if (attributeKey == IdProgressCircleSize.Key.AsGuid) {
return ssProgressCircleSize;
}
if (attributeKey == IdTrailColor.Key.AsGuid) {
return ssTrailColor;
}
if (attributeKey == IdThickness.Key.AsGuid) {
return ssThickness;
}
if (attributeKey == IdShape.Key.AsGuid) {
return ssShape;
}
if (attributeKey == IdAnimateInitialProgress.Key.AsGuid) {
return ssAnimateInitialProgress;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
if (attributeKey == IdInitialProgress.Key.AsGuid) {
return ssInitialProgress;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssType = (string) other.AttributeGet(IdType);
ssProgress = (int) other.AttributeGet(IdProgress);
ssProgressColor = (string) other.AttributeGet(IdProgressColor);
ssProgressCircleSize = (string) other.AttributeGet(IdProgressCircleSize);
ssTrailColor = (string) other.AttributeGet(IdTrailColor);
ssThickness = (int) other.AttributeGet(IdThickness);
ssShape = (string) other.AttributeGet(IdShape);
ssAnimateInitialProgress = (bool) other.AttributeGet(IdAnimateInitialProgress);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssInitialProgress = (int) other.AttributeGet(IdInitialProgress);
}
} // ST_2fd97622d01b72b1af62467b00f1da8eStructure
/// <summary>
/// RecordList type <code>ProgressCircle_InternalConfigList</code> that represents a record list of
///  <code>ProgressCircle_InternalConfig</code>
/// </summary>
public partial class RL_331fdaa66f00c258aa64e18fe67ccb9e : GenericRecordList<ST_2fd97622d01b72b1af62467b00f1da8eStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_2fd97622d01b72b1af62467b00f1da8eStructure GetElementDefaultValue() {
return new ST_2fd97622d01b72b1af62467b00f1da8eStructure();
}

public T[] ToArray<T>(Func<ST_2fd97622d01b72b1af62467b00f1da8eStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_331fdaa66f00c258aa64e18fe67ccb9e recordList, Func<ST_2fd97622d01b72b1af62467b00f1da8eStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_331fdaa66f00c258aa64e18fe67ccb9e(ST_2fd97622d01b72b1af62467b00f1da8eStructure[] array) {
  RL_331fdaa66f00c258aa64e18fe67ccb9e result = new RL_331fdaa66f00c258aa64e18fe67ccb9e();
result.InnerFromArray(array);
    return result;
}

public static RL_331fdaa66f00c258aa64e18fe67ccb9e ToList<T>(T[] array, Func <T, ST_2fd97622d01b72b1af62467b00f1da8eStructure> converter) {
  RL_331fdaa66f00c258aa64e18fe67ccb9e result = new RL_331fdaa66f00c258aa64e18fe67ccb9e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_331fdaa66f00c258aa64e18fe67ccb9e FromRestList<T>(RestList<T> restList, Func <T, ST_2fd97622d01b72b1af62467b00f1da8eStructure> converter) {
  RL_331fdaa66f00c258aa64e18fe67ccb9e result = new RL_331fdaa66f00c258aa64e18fe67ccb9e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_331fdaa66f00c258aa64e18fe67ccb9e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2fd97622d01b72b1af62467b00f1da8eStructure> NewList() {
return new RL_331fdaa66f00c258aa64e18fe67ccb9e();
}


} // RL_331fdaa66f00c258aa64e18fe67ccb9e
}

