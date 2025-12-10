namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Rating_InternalConfig (odJ0Q5xPt0+ln+z32WVTwA)
///  <code>ST_69c22c095aca285f3fb706e10e473ba5Structure</code> that represent
/// s <code>Rating_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Rating block. </p>
/// </summary>
// Name: Rating_InternalConfig
public partial struct ST_69c22c095aca285f3fb706e10e473ba5Structure : ITypedRecord<ST_69c22c095aca285f3fb706e10e473ba5Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*dy4dmbGOuk2JxjW+BWePqg");
internal static readonly GlobalObjectKey IdRatingValue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*C12btMp5EESo5znIY8qTCg");
internal static readonly GlobalObjectKey IdRatingScale = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*OEiu1MsjOk62jlulFMH5XQ");
internal static readonly GlobalObjectKey IdIsEdit = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*DyVQ_XQPx0OOvnQUUuxAjQ");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*P5kVS2FS+0i7NAZU9C7y+g");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_eClqlbLb02_EmtbQF8j_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("RatingValue")]
public decimal ssRatingValue;

[System.Xml.Serialization.XmlElement("RatingScale")]
public int ssRatingScale;

[System.Xml.Serialization.XmlElement("IsEdit")]
public bool ssIsEdit;

[System.Xml.Serialization.XmlElement("Size")]
public string ssSize;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_69c22c095aca285f3fb706e10e473ba5Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssRatingValue = 0.0M;
ssRatingScale = 0;
ssIsEdit = false;
ssSize = "";
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
ssUniqueId = r.ReadText(index++, "Rating_InternalConfig.UniqueId", "");
ssRatingValue = r.ReadDecimal(index++, "Rating_InternalConfig.RatingValue", 0.0M);
ssRatingScale = r.ReadInteger(index++, "Rating_InternalConfig.RatingScale", 0);
ssIsEdit = r.ReadBoolean(index++, "Rating_InternalConfig.IsEdit", false);
ssSize = r.ReadEntityReferenceText(index++, "Rating_InternalConfig.Size", "");
ssExtendedClass = r.ReadText(index++, "Rating_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_69c22c095aca285f3fb706e10e473ba5Structure r) {
this = r;
}


public static bool operator == (ST_69c22c095aca285f3fb706e10e473ba5Structure a, ST_69c22c095aca285f3fb706e10e473ba5Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssRatingValue != b.ssRatingValue) return false;
if (a.ssRatingScale != b.ssRatingScale) return false;
if (a.ssIsEdit != b.ssIsEdit) return false;
if (a.ssSize != b.ssSize) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_69c22c095aca285f3fb706e10e473ba5Structure a, ST_69c22c095aca285f3fb706e10e473ba5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_69c22c095aca285f3fb706e10e473ba5Structure)) return false;
return (this == (ST_69c22c095aca285f3fb706e10e473ba5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssRatingValue.GetHashCode()
 ^ ssRatingScale.GetHashCode()
 ^ ssIsEdit.GetHashCode()
 ^ ssSize.GetHashCode()
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


public ST_69c22c095aca285f3fb706e10e473ba5Structure Duplicate() {
ST_69c22c095aca285f3fb706e10e473ba5Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssRatingValue = this.ssRatingValue;
t.ssRatingScale = this.ssRatingScale;
t.ssIsEdit = this.ssIsEdit;
t.ssSize = this.ssSize;
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
} else if (head == "ratingvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RatingValue")) variable.Value = ssRatingValue; else variable.Optimized = true;
} else if (head == "ratingscale") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RatingScale")) variable.Value = ssRatingScale; else variable.Optimized = true;
} else if (head == "isedit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsEdit")) variable.Value = ssIsEdit; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
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
if (key == IdRatingValue) {
return ssRatingValue;
}
if (key == IdRatingScale) {
return ssRatingScale;
}
if (key == IdIsEdit) {
return ssIsEdit;
}
if (key == IdSize) {
return ssSize;
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
if (attributeKey == IdRatingValue.Key.AsGuid) {
return ssRatingValue;
}
if (attributeKey == IdRatingScale.Key.AsGuid) {
return ssRatingScale;
}
if (attributeKey == IdIsEdit.Key.AsGuid) {
return ssIsEdit;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssRatingValue = (decimal) other.AttributeGet(IdRatingValue);
ssRatingScale = (int) other.AttributeGet(IdRatingScale);
ssIsEdit = (bool) other.AttributeGet(IdIsEdit);
ssSize = (string) other.AttributeGet(IdSize);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_69c22c095aca285f3fb706e10e473ba5Structure
/// <summary>
/// RecordList type <code>Rating_InternalConfigList</code> that represents a record list of
///  <code>Rating_InternalConfig</code>
/// </summary>
public partial class RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 : GenericRecordList<ST_69c22c095aca285f3fb706e10e473ba5Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_69c22c095aca285f3fb706e10e473ba5Structure GetElementDefaultValue() {
return new ST_69c22c095aca285f3fb706e10e473ba5Structure();
}

public T[] ToArray<T>(Func<ST_69c22c095aca285f3fb706e10e473ba5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 recordList, Func<ST_69c22c095aca285f3fb706e10e473ba5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a4cc67046f3ef5e3ecf39d571c1b1e6(ST_69c22c095aca285f3fb706e10e473ba5Structure[] array) {
  RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 result = new RL_0a4cc67046f3ef5e3ecf39d571c1b1e6();
result.InnerFromArray(array);
    return result;
}

public static RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 ToList<T>(T[] array, Func <T, ST_69c22c095aca285f3fb706e10e473ba5Structure> converter) {
  RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 result = new RL_0a4cc67046f3ef5e3ecf39d571c1b1e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 FromRestList<T>(RestList<T> restList, Func <T, ST_69c22c095aca285f3fb706e10e473ba5Structure> converter) {
  RL_0a4cc67046f3ef5e3ecf39d571c1b1e6 result = new RL_0a4cc67046f3ef5e3ecf39d571c1b1e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a4cc67046f3ef5e3ecf39d571c1b1e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_69c22c095aca285f3fb706e10e473ba5Structure> NewList() {
return new RL_0a4cc67046f3ef5e3ecf39d571c1b1e6();
}


} // RL_0a4cc67046f3ef5e3ecf39d571c1b1e6
}

