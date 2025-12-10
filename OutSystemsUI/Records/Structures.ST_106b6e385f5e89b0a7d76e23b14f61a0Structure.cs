namespace ssOutSystemsUI {
/// <summary>
/// [Structure] BottomSheet_InternalConfig (78TYRSJmsU+8W4a7RZTjXg)
///  <code>ST_106b6e385f5e89b0a7d76e23b14f61a0Structure</code> that represent
/// s <code>BottomSheet_InternalConfig</code> <p>Description: Group of internal configurations for the
///  BottomSheet block. </p>
/// </summary>
// Name: BottomSheet_InternalConfig
public partial struct ST_106b6e385f5e89b0a7d76e23b14f61a0Structure : ITypedRecord<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KVsnIjwSH0uC1tCpEONBrQ");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_HgJrb4kDEqKnWC8V3gZTw");
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ZkdKi6AIq0mEilQsG_2_Dg");
internal static readonly GlobalObjectKey IdShowHandler = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*f0TsyEKKDkOfemjKR4torQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("Shape")]
public string ssShape;

[System.Xml.Serialization.XmlElement("ShowHandler")]
public bool ssShowHandler;


public BitArray OptimizedAttributes;

public ST_106b6e385f5e89b0a7d76e23b14f61a0Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssExtendedClass = "";
ssShape = (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"))).ssShape;
ssShowHandler = true;
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
ssUniqueId = r.ReadText(index++, "BottomSheet_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "BottomSheet_InternalConfig.ExtendedClass", "");
ssShape = r.ReadEntityReferenceText(index++, "BottomSheet_InternalConfig.Shape", "");
ssShowHandler = r.ReadBoolean(index++, "BottomSheet_InternalConfig.ShowHandler", false);
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
public void ReadIM(ST_106b6e385f5e89b0a7d76e23b14f61a0Structure r) {
this = r;
}


public static bool operator == (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure a, ST_106b6e385f5e89b0a7d76e23b14f61a0Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssShape != b.ssShape) return false;
if (a.ssShowHandler != b.ssShowHandler) return false;
return true;
}

public static bool operator != (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure a, ST_106b6e385f5e89b0a7d76e23b14f61a0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure)) return false;
return (this == (ST_106b6e385f5e89b0a7d76e23b14f61a0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssShape.GetHashCode()
 ^ ssShowHandler.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_106b6e385f5e89b0a7d76e23b14f61a0Structure Duplicate() {
ST_106b6e385f5e89b0a7d76e23b14f61a0Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssExtendedClass = this.ssExtendedClass;
t.ssShape = this.ssShape;
t.ssShowHandler = this.ssShowHandler;
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
} else if (head == "shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Shape")) variable.Value = ssShape; else variable.Optimized = true;
} else if (head == "showhandler") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowHandler")) variable.Value = ssShowHandler; else variable.Optimized = true;
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
if (key == IdShape) {
return ssShape;
}
if (key == IdShowHandler) {
return ssShowHandler;
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
if (attributeKey == IdShape.Key.AsGuid) {
return ssShape;
}
if (attributeKey == IdShowHandler.Key.AsGuid) {
return ssShowHandler;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssShape = (string) other.AttributeGet(IdShape);
ssShowHandler = (bool) other.AttributeGet(IdShowHandler);
}
} // ST_106b6e385f5e89b0a7d76e23b14f61a0Structure
/// <summary>
/// RecordList type <code>BottomSheet_InternalConfigList</code> that represents a record list of
///  <code>BottomSheet_InternalConfig</code>
/// </summary>
public partial class RL_c8ee2f82cd0842220547a079f59ee97c : GenericRecordList<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_106b6e385f5e89b0a7d76e23b14f61a0Structure GetElementDefaultValue() {
return new ST_106b6e385f5e89b0a7d76e23b14f61a0Structure();
}

public T[] ToArray<T>(Func<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c8ee2f82cd0842220547a079f59ee97c recordList, Func<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c8ee2f82cd0842220547a079f59ee97c(ST_106b6e385f5e89b0a7d76e23b14f61a0Structure[] array) {
  RL_c8ee2f82cd0842220547a079f59ee97c result = new RL_c8ee2f82cd0842220547a079f59ee97c();
result.InnerFromArray(array);
    return result;
}

public static RL_c8ee2f82cd0842220547a079f59ee97c ToList<T>(T[] array, Func <T, ST_106b6e385f5e89b0a7d76e23b14f61a0Structure> converter) {
  RL_c8ee2f82cd0842220547a079f59ee97c result = new RL_c8ee2f82cd0842220547a079f59ee97c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c8ee2f82cd0842220547a079f59ee97c FromRestList<T>(RestList<T> restList, Func <T, ST_106b6e385f5e89b0a7d76e23b14f61a0Structure> converter) {
  RL_c8ee2f82cd0842220547a079f59ee97c result = new RL_c8ee2f82cd0842220547a079f59ee97c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c8ee2f82cd0842220547a079f59ee97c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_106b6e385f5e89b0a7d76e23b14f61a0Structure> NewList() {
return new RL_c8ee2f82cd0842220547a079f59ee97c();
}


} // RL_c8ee2f82cd0842220547a079f59ee97c
}

