namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ProgressBar_InternalConfig (FwTVwnVKr0Wcy+6AIacVxg)
///  <code>ST_b29bdecfa7956bb3d5bee97678e39fb0Structure</code> that represent
/// s <code>ProgressBar_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Progress block. </p>
/// </summary>
// Name: ProgressBar_InternalConfig
public partial struct ST_b29bdecfa7956bb3d5bee97678e39fb0Structure : ITypedRecord<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*efjhaviYdUqV+czjXqpD2Q");
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*aN6q9+rIak+tp8exgPapLA");
internal static readonly GlobalObjectKey IdProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*T1pGFaneWES76TSy0+7yZQ");
internal static readonly GlobalObjectKey IdProgressColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*smuFvomOgk6TfPNpKj4v7w");
internal static readonly GlobalObjectKey IdTrailColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Ec_FPW7zdE6_3Y2aqSGO6A");
internal static readonly GlobalObjectKey IdThickness = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*rj7qKVCogUWlNSS90iDWpQ");
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*XekV2C_f20icPboW81EpIA");
internal static readonly GlobalObjectKey IdAnimateInitialProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*LK4nkdb_tUW1iNHNTGlQRA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tjR6WX7RhU+fvGzozsgmVA");
internal static readonly GlobalObjectKey IdInitialProgress = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*iUR62BrFqUeaoBCFrW_8Dw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("Type")]
public string ssType;

[System.Xml.Serialization.XmlElement("Progress")]
public int ssProgress;

[System.Xml.Serialization.XmlElement("ProgressColor")]
public string ssProgressColor;

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

public ST_b29bdecfa7956bb3d5bee97678e39fb0Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssType = "";
ssProgress = 0;
ssProgressColor = "";
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
ssUniqueId = r.ReadText(index++, "ProgressBar_InternalConfig.UniqueId", "");
ssType = r.ReadEntityReferenceText(index++, "ProgressBar_InternalConfig.Type", "");
ssProgress = r.ReadInteger(index++, "ProgressBar_InternalConfig.Progress", 0);
ssProgressColor = r.ReadEntityReferenceText(index++, "ProgressBar_InternalConfig.ProgressColor", "");
ssTrailColor = r.ReadEntityReferenceText(index++, "ProgressBar_InternalConfig.TrailColor", "");
ssThickness = r.ReadInteger(index++, "ProgressBar_InternalConfig.Thickness", 0);
ssShape = r.ReadEntityReferenceText(index++, "ProgressBar_InternalConfig.Shape", "");
ssAnimateInitialProgress = r.ReadBoolean(index++, "ProgressBar_InternalConfig.AnimateInitialProgress", false);
ssExtendedClass = r.ReadText(index++, "ProgressBar_InternalConfig.ExtendedClass", "");
ssInitialProgress = r.ReadInteger(index++, "ProgressBar_InternalConfig.InitialProgress", 0);
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
public void ReadIM(ST_b29bdecfa7956bb3d5bee97678e39fb0Structure r) {
this = r;
}


public static bool operator == (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure a, ST_b29bdecfa7956bb3d5bee97678e39fb0Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssType != b.ssType) return false;
if (a.ssProgress != b.ssProgress) return false;
if (a.ssProgressColor != b.ssProgressColor) return false;
if (a.ssTrailColor != b.ssTrailColor) return false;
if (a.ssThickness != b.ssThickness) return false;
if (a.ssShape != b.ssShape) return false;
if (a.ssAnimateInitialProgress != b.ssAnimateInitialProgress) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssInitialProgress != b.ssInitialProgress) return false;
return true;
}

public static bool operator != (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure a, ST_b29bdecfa7956bb3d5bee97678e39fb0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure)) return false;
return (this == (ST_b29bdecfa7956bb3d5bee97678e39fb0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssType.GetHashCode()
 ^ ssProgress.GetHashCode()
 ^ ssProgressColor.GetHashCode()
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


public ST_b29bdecfa7956bb3d5bee97678e39fb0Structure Duplicate() {
ST_b29bdecfa7956bb3d5bee97678e39fb0Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssType = this.ssType;
t.ssProgress = this.ssProgress;
t.ssProgressColor = this.ssProgressColor;
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
ssTrailColor = (string) other.AttributeGet(IdTrailColor);
ssThickness = (int) other.AttributeGet(IdThickness);
ssShape = (string) other.AttributeGet(IdShape);
ssAnimateInitialProgress = (bool) other.AttributeGet(IdAnimateInitialProgress);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssInitialProgress = (int) other.AttributeGet(IdInitialProgress);
}
} // ST_b29bdecfa7956bb3d5bee97678e39fb0Structure
/// <summary>
/// RecordList type <code>ProgressBar_InternalConfigList</code> that represents a record list of
///  <code>ProgressBar_InternalConfig</code>
/// </summary>
public partial class RL_d9087525544a5398e32fd1eb2f3e8818 : GenericRecordList<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b29bdecfa7956bb3d5bee97678e39fb0Structure GetElementDefaultValue() {
return new ST_b29bdecfa7956bb3d5bee97678e39fb0Structure();
}

public T[] ToArray<T>(Func<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d9087525544a5398e32fd1eb2f3e8818 recordList, Func<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d9087525544a5398e32fd1eb2f3e8818(ST_b29bdecfa7956bb3d5bee97678e39fb0Structure[] array) {
  RL_d9087525544a5398e32fd1eb2f3e8818 result = new RL_d9087525544a5398e32fd1eb2f3e8818();
result.InnerFromArray(array);
    return result;
}

public static RL_d9087525544a5398e32fd1eb2f3e8818 ToList<T>(T[] array, Func <T, ST_b29bdecfa7956bb3d5bee97678e39fb0Structure> converter) {
  RL_d9087525544a5398e32fd1eb2f3e8818 result = new RL_d9087525544a5398e32fd1eb2f3e8818();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d9087525544a5398e32fd1eb2f3e8818 FromRestList<T>(RestList<T> restList, Func <T, ST_b29bdecfa7956bb3d5bee97678e39fb0Structure> converter) {
  RL_d9087525544a5398e32fd1eb2f3e8818 result = new RL_d9087525544a5398e32fd1eb2f3e8818();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d9087525544a5398e32fd1eb2f3e8818() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b29bdecfa7956bb3d5bee97678e39fb0Structure> NewList() {
return new RL_d9087525544a5398e32fd1eb2f3e8818();
}


} // RL_d9087525544a5398e32fd1eb2f3e8818
}

