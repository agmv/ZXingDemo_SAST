namespace ssOutSystemsUI {
/// <summary>
/// [Structure] FlipContent_InternalConfig (5xNXKqjCNEWkNemSMKsP3A)
///  <code>ST_e828cdbd51e0c1ef095bd323f6e2875aStructure</code> that represent
/// s <code>FlipContent_InternalConfig</code> <p>Description: Group of internal configurations for the
///  FlipContent block. </p>
/// </summary>
// Name: FlipContent_InternalConfig
public partial struct ST_e828cdbd51e0c1ef095bd323f6e2875aStructure : ITypedRecord<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*0oAZzKFp+kS3Yp69qTvTng");
internal static readonly GlobalObjectKey IdIsFlipped = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Bx62wKwLhEyMA72oB7k3Lg");
internal static readonly GlobalObjectKey IdFlipSelf = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tGukuMTKB0Ox1WJV1OgalA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ul_iyd3EkE2xAROy3poiOA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("IsFlipped")]
public bool ssIsFlipped;

[System.Xml.Serialization.XmlElement("FlipSelf")]
public bool ssFlipSelf;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_e828cdbd51e0c1ef095bd323f6e2875aStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssIsFlipped = false;
ssFlipSelf = true;
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
ssUniqueId = r.ReadText(index++, "FlipContent_InternalConfig.UniqueId", "");
ssIsFlipped = r.ReadBoolean(index++, "FlipContent_InternalConfig.IsFlipped", false);
ssFlipSelf = r.ReadBoolean(index++, "FlipContent_InternalConfig.FlipSelf", false);
ssExtendedClass = r.ReadText(index++, "FlipContent_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_e828cdbd51e0c1ef095bd323f6e2875aStructure r) {
this = r;
}


public static bool operator == (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure a, ST_e828cdbd51e0c1ef095bd323f6e2875aStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssIsFlipped != b.ssIsFlipped) return false;
if (a.ssFlipSelf != b.ssFlipSelf) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure a, ST_e828cdbd51e0c1ef095bd323f6e2875aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure)) return false;
return (this == (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssIsFlipped.GetHashCode()
 ^ ssFlipSelf.GetHashCode()
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


public ST_e828cdbd51e0c1ef095bd323f6e2875aStructure Duplicate() {
ST_e828cdbd51e0c1ef095bd323f6e2875aStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssIsFlipped = this.ssIsFlipped;
t.ssFlipSelf = this.ssFlipSelf;
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
} else if (head == "isflipped") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFlipped")) variable.Value = ssIsFlipped; else variable.Optimized = true;
} else if (head == "flipself") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FlipSelf")) variable.Value = ssFlipSelf; else variable.Optimized = true;
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
if (key == IdIsFlipped) {
return ssIsFlipped;
}
if (key == IdFlipSelf) {
return ssFlipSelf;
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
if (attributeKey == IdIsFlipped.Key.AsGuid) {
return ssIsFlipped;
}
if (attributeKey == IdFlipSelf.Key.AsGuid) {
return ssFlipSelf;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssIsFlipped = (bool) other.AttributeGet(IdIsFlipped);
ssFlipSelf = (bool) other.AttributeGet(IdFlipSelf);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_e828cdbd51e0c1ef095bd323f6e2875aStructure
/// <summary>
/// RecordList type <code>FlipContent_InternalConfigList</code> that represents a record list of
///  <code>FlipContent_InternalConfig</code>
/// </summary>
public partial class RL_51f9ee8496afba68bd62021ef774d312 : GenericRecordList<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_e828cdbd51e0c1ef095bd323f6e2875aStructure GetElementDefaultValue() {
return new ST_e828cdbd51e0c1ef095bd323f6e2875aStructure();
}

public T[] ToArray<T>(Func<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_51f9ee8496afba68bd62021ef774d312 recordList, Func<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_51f9ee8496afba68bd62021ef774d312(ST_e828cdbd51e0c1ef095bd323f6e2875aStructure[] array) {
  RL_51f9ee8496afba68bd62021ef774d312 result = new RL_51f9ee8496afba68bd62021ef774d312();
result.InnerFromArray(array);
    return result;
}

public static RL_51f9ee8496afba68bd62021ef774d312 ToList<T>(T[] array, Func <T, ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> converter) {
  RL_51f9ee8496afba68bd62021ef774d312 result = new RL_51f9ee8496afba68bd62021ef774d312();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_51f9ee8496afba68bd62021ef774d312 FromRestList<T>(RestList<T> restList, Func <T, ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> converter) {
  RL_51f9ee8496afba68bd62021ef774d312 result = new RL_51f9ee8496afba68bd62021ef774d312();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_51f9ee8496afba68bd62021ef774d312() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e828cdbd51e0c1ef095bd323f6e2875aStructure> NewList() {
return new RL_51f9ee8496afba68bd62021ef774d312();
}


} // RL_51f9ee8496afba68bd62021ef774d312
}

