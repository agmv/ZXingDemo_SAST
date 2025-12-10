namespace ssOutSystemsUI {
/// <summary>
/// [Structure] OverflowMenu_InternalConfigs (nsim2H_SGEuGhJ3UjaFH4g)
///  <code>ST_6e6632cfd831e4e0f6a401872bea6eccStructure</code> that represent
/// s <code>OverflowMenu_InternalConfigs</code> <p>Description: Group of internal configurations for
///  the Balloon block. </p>
/// </summary>
// Name: OverflowMenu_InternalConfigs
public partial struct ST_6e6632cfd831e4e0f6a401872bea6eccStructure : ITypedRecord<ST_6e6632cfd831e4e0f6a401872bea6eccStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*SnhV4arKy0OMJtnYLjEVoQ");
internal static readonly GlobalObjectKey IdBalloonPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Yso5j7md8k6pcSDQ3B+xNQ");
internal static readonly GlobalObjectKey IdBalloonShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*h4qJwaKADkeprcg+Mg8VIg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*GnXKeH91HUOeX4yKEgfRAA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("BalloonPosition")]
public string ssBalloonPosition;

[System.Xml.Serialization.XmlElement("BalloonShape")]
public string ssBalloonShape;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_6e6632cfd831e4e0f6a401872bea6eccStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssBalloonPosition = (ENFloatingPositionEntity.GetRecordByKey(ObjectKey.Parse("iXgvXFSndk6SAnThrfZKqA"))).ssPosition;
ssBalloonShape = (ENShapeEntity.GetRecordByKey(ObjectKey.Parse("OTUJ0X3XnUONUwPS4AU6Ug"))).ssShape;
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
ssUniqueId = r.ReadText(index++, "OverflowMenu_InternalConfigs.UniqueId", "");
ssBalloonPosition = r.ReadEntityReferenceText(index++, "OverflowMenu_InternalConfigs.BalloonPosition", "");
ssBalloonShape = r.ReadEntityReferenceText(index++, "OverflowMenu_InternalConfigs.BalloonShape", "");
ssExtendedClass = r.ReadText(index++, "OverflowMenu_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_6e6632cfd831e4e0f6a401872bea6eccStructure r) {
this = r;
}


public static bool operator == (ST_6e6632cfd831e4e0f6a401872bea6eccStructure a, ST_6e6632cfd831e4e0f6a401872bea6eccStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssBalloonPosition != b.ssBalloonPosition) return false;
if (a.ssBalloonShape != b.ssBalloonShape) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_6e6632cfd831e4e0f6a401872bea6eccStructure a, ST_6e6632cfd831e4e0f6a401872bea6eccStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6e6632cfd831e4e0f6a401872bea6eccStructure)) return false;
return (this == (ST_6e6632cfd831e4e0f6a401872bea6eccStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssBalloonPosition.GetHashCode()
 ^ ssBalloonShape.GetHashCode()
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


public ST_6e6632cfd831e4e0f6a401872bea6eccStructure Duplicate() {
ST_6e6632cfd831e4e0f6a401872bea6eccStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssBalloonPosition = this.ssBalloonPosition;
t.ssBalloonShape = this.ssBalloonShape;
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
} else if (head == "balloonposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BalloonPosition")) variable.Value = ssBalloonPosition; else variable.Optimized = true;
} else if (head == "balloonshape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BalloonShape")) variable.Value = ssBalloonShape; else variable.Optimized = true;
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
if (key == IdBalloonPosition) {
return ssBalloonPosition;
}
if (key == IdBalloonShape) {
return ssBalloonShape;
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
if (attributeKey == IdBalloonPosition.Key.AsGuid) {
return ssBalloonPosition;
}
if (attributeKey == IdBalloonShape.Key.AsGuid) {
return ssBalloonShape;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssBalloonPosition = (string) other.AttributeGet(IdBalloonPosition);
ssBalloonShape = (string) other.AttributeGet(IdBalloonShape);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_6e6632cfd831e4e0f6a401872bea6eccStructure
/// <summary>
/// RecordList type <code>OverflowMenu_InternalConfigsList</code> that represents a record list of
///  <code>OverflowMenu_InternalConfigs</code>
/// </summary>
public partial class RL_5214147e7fe1d47d32e4d5dbafdf5f0a : GenericRecordList<ST_6e6632cfd831e4e0f6a401872bea6eccStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_6e6632cfd831e4e0f6a401872bea6eccStructure GetElementDefaultValue() {
return new ST_6e6632cfd831e4e0f6a401872bea6eccStructure();
}

public T[] ToArray<T>(Func<ST_6e6632cfd831e4e0f6a401872bea6eccStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5214147e7fe1d47d32e4d5dbafdf5f0a recordList, Func<ST_6e6632cfd831e4e0f6a401872bea6eccStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5214147e7fe1d47d32e4d5dbafdf5f0a(ST_6e6632cfd831e4e0f6a401872bea6eccStructure[] array) {
  RL_5214147e7fe1d47d32e4d5dbafdf5f0a result = new RL_5214147e7fe1d47d32e4d5dbafdf5f0a();
result.InnerFromArray(array);
    return result;
}

public static RL_5214147e7fe1d47d32e4d5dbafdf5f0a ToList<T>(T[] array, Func <T, ST_6e6632cfd831e4e0f6a401872bea6eccStructure> converter) {
  RL_5214147e7fe1d47d32e4d5dbafdf5f0a result = new RL_5214147e7fe1d47d32e4d5dbafdf5f0a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5214147e7fe1d47d32e4d5dbafdf5f0a FromRestList<T>(RestList<T> restList, Func <T, ST_6e6632cfd831e4e0f6a401872bea6eccStructure> converter) {
  RL_5214147e7fe1d47d32e4d5dbafdf5f0a result = new RL_5214147e7fe1d47d32e4d5dbafdf5f0a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5214147e7fe1d47d32e4d5dbafdf5f0a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6e6632cfd831e4e0f6a401872bea6eccStructure> NewList() {
return new RL_5214147e7fe1d47d32e4d5dbafdf5f0a();
}


} // RL_5214147e7fe1d47d32e4d5dbafdf5f0a
}

