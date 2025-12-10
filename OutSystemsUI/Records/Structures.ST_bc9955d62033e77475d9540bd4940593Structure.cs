namespace ssOutSystemsUI {
/// <summary>
/// [Structure] InlineSVG_InternalConfig (Y5QFDx_yXEqPll_eLyli+A)
///  <code>ST_bc9955d62033e77475d9540bd4940593Structure</code> that represent
/// s <code>InlineSVG_InternalConfig</code> <p>Description: Group of internal configurations for the
///  InlineSVG block. </p>
/// </summary>
// Name: InlineSVG_InternalConfig
public partial struct ST_bc9955d62033e77475d9540bd4940593Structure : ITypedRecord<ST_bc9955d62033e77475d9540bd4940593Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Bm55a7vuCE+U00AXHmFQRQ");
internal static readonly GlobalObjectKey IdSVGCode = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*WSA_nquRcUmpxI2TybCd7A");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*T8ycpNkyZ0ykEl+wZWFYWg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("SVGCode")]
public string ssSVGCode;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_bc9955d62033e77475d9540bd4940593Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssSVGCode = "";
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
ssUniqueId = r.ReadText(index++, "InlineSVG_InternalConfig.UniqueId", "");
ssSVGCode = r.ReadText(index++, "InlineSVG_InternalConfig.SVGCode", "");
ssExtendedClass = r.ReadText(index++, "InlineSVG_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_bc9955d62033e77475d9540bd4940593Structure r) {
this = r;
}


public static bool operator == (ST_bc9955d62033e77475d9540bd4940593Structure a, ST_bc9955d62033e77475d9540bd4940593Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssSVGCode != b.ssSVGCode) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_bc9955d62033e77475d9540bd4940593Structure a, ST_bc9955d62033e77475d9540bd4940593Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_bc9955d62033e77475d9540bd4940593Structure)) return false;
return (this == (ST_bc9955d62033e77475d9540bd4940593Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssSVGCode.GetHashCode()
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


public ST_bc9955d62033e77475d9540bd4940593Structure Duplicate() {
ST_bc9955d62033e77475d9540bd4940593Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssSVGCode = this.ssSVGCode;
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
} else if (head == "svgcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SVGCode")) variable.Value = ssSVGCode; else variable.Optimized = true;
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
if (key == IdSVGCode) {
return ssSVGCode;
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
if (attributeKey == IdSVGCode.Key.AsGuid) {
return ssSVGCode;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssSVGCode = (string) other.AttributeGet(IdSVGCode);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_bc9955d62033e77475d9540bd4940593Structure
/// <summary>
/// RecordList type <code>InlineSVG_InternalConfigList</code> that represents a record list of
///  <code>InlineSVG_InternalConfig</code>
/// </summary>
public partial class RL_1d5d9a16261edaf52587231a41469a09 : GenericRecordList<ST_bc9955d62033e77475d9540bd4940593Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_bc9955d62033e77475d9540bd4940593Structure GetElementDefaultValue() {
return new ST_bc9955d62033e77475d9540bd4940593Structure();
}

public T[] ToArray<T>(Func<ST_bc9955d62033e77475d9540bd4940593Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1d5d9a16261edaf52587231a41469a09 recordList, Func<ST_bc9955d62033e77475d9540bd4940593Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1d5d9a16261edaf52587231a41469a09(ST_bc9955d62033e77475d9540bd4940593Structure[] array) {
  RL_1d5d9a16261edaf52587231a41469a09 result = new RL_1d5d9a16261edaf52587231a41469a09();
result.InnerFromArray(array);
    return result;
}

public static RL_1d5d9a16261edaf52587231a41469a09 ToList<T>(T[] array, Func <T, ST_bc9955d62033e77475d9540bd4940593Structure> converter) {
  RL_1d5d9a16261edaf52587231a41469a09 result = new RL_1d5d9a16261edaf52587231a41469a09();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1d5d9a16261edaf52587231a41469a09 FromRestList<T>(RestList<T> restList, Func <T, ST_bc9955d62033e77475d9540bd4940593Structure> converter) {
  RL_1d5d9a16261edaf52587231a41469a09 result = new RL_1d5d9a16261edaf52587231a41469a09();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1d5d9a16261edaf52587231a41469a09() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_bc9955d62033e77475d9540bd4940593Structure> NewList() {
return new RL_1d5d9a16261edaf52587231a41469a09();
}


} // RL_1d5d9a16261edaf52587231a41469a09
}

