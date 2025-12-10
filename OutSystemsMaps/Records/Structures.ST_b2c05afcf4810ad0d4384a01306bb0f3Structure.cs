namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalStaticMapConfigs (JZvz4YYXi0KWFxIRoNqGBQ)
///  <code>ST_b2c05afcf4810ad0d4384a01306bb0f3Structure</code> that represent
/// s <code>OptionalStaticMapConfigs</code> <p>Description: Set additional parameters to customize
///  static map's behavior and functionality.</p>
/// </summary>
// Name: OptionalStaticMapConfigs
public partial struct ST_b2c05afcf4810ad0d4384a01306bb0f3Structure : ITypedRecord<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure> {
internal static readonly GlobalObjectKey IdZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*93jsEsBhv0eMF3CrHy1quw");
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*9lyOYWGsxE2aaN6z90q9jg");
internal static readonly GlobalObjectKey IdLocalization = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*FTzNTSQQo0WMCD4b4rU5Tg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Zoom")]
public int ssZoom;

[System.Xml.Serialization.XmlElement("Type")]
public string ssType;

[System.Xml.Serialization.XmlElement("Localization")]
public ST_59c2aa6a35b14343cc78f655810f9ce8Structure ssLocalization;


public BitArray OptimizedAttributes;

public ST_b2c05afcf4810ad0d4384a01306bb0f3Structure() {
OptimizedAttributes = null;
ssZoom = (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId;
ssType = (ENTypeEntity.GetRecordByKey(ObjectKey.Parse("ovetaFeGuE6McBWDcnLLEg"))).ssMapType;
ssLocalization = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssLocalization.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssZoom = r.ReadEntityReference(index++, "OptionalStaticMapConfigs.Zoom", 0);
ssType = r.ReadEntityReferenceText(index++, "OptionalStaticMapConfigs.Type", "");
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
public void ReadIM(ST_b2c05afcf4810ad0d4384a01306bb0f3Structure r) {
this = r;
}


public static bool operator == (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure a, ST_b2c05afcf4810ad0d4384a01306bb0f3Structure b) {
if (a.ssZoom != b.ssZoom) return false;
if (a.ssType != b.ssType) return false;
if (a.ssLocalization != b.ssLocalization) return false;
return true;
}

public static bool operator != (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure a, ST_b2c05afcf4810ad0d4384a01306bb0f3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure)) return false;
return (this == (ST_b2c05afcf4810ad0d4384a01306bb0f3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssZoom.GetHashCode()
 ^ ssType.GetHashCode()
 ^ ssLocalization.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssLocalization.RecursiveReset();
}

public void InternalRecursiveSave() {
ssLocalization.InternalRecursiveSave();
}


public ST_b2c05afcf4810ad0d4384a01306bb0f3Structure Duplicate() {
ST_b2c05afcf4810ad0d4384a01306bb0f3Structure t;
t.ssZoom = this.ssZoom;
t.ssType = this.ssType;
t.ssLocalization = (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)this.ssLocalization.Duplicate();
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
if (head == "zoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Zoom")) variable.Value = ssZoom; else variable.Optimized = true;
} else if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
} else if (head == "localization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Localization")) variable.Value = ssLocalization; else variable.Optimized = true;
variable.SetFieldName("localization");
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
if (key == IdZoom) {
return ssZoom;
}
if (key == IdType) {
return ssType;
}
if (key == IdLocalization) {
return ssLocalization;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZoom.Key.AsGuid) {
return ssZoom;
}
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
}
if (attributeKey == IdLocalization.Key.AsGuid) {
return ssLocalization;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssZoom = (int) other.AttributeGet(IdZoom);
ssType = (string) other.AttributeGet(IdType);
ssLocalization.FillFromOther((IRecord) other.AttributeGet(IdLocalization));
}
} // ST_b2c05afcf4810ad0d4384a01306bb0f3Structure
/// <summary>
/// RecordList type <code>OptionalStaticMapConfigsList</code> that represents a record list of
///  <code>OptionalStaticMapConfigs</code>
/// </summary>
public partial class RL_641ffd2e0663341a460be77463e186bb : GenericRecordList<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b2c05afcf4810ad0d4384a01306bb0f3Structure GetElementDefaultValue() {
return new ST_b2c05afcf4810ad0d4384a01306bb0f3Structure();
}

public T[] ToArray<T>(Func<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_641ffd2e0663341a460be77463e186bb recordList, Func<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_641ffd2e0663341a460be77463e186bb(ST_b2c05afcf4810ad0d4384a01306bb0f3Structure[] array) {
  RL_641ffd2e0663341a460be77463e186bb result = new RL_641ffd2e0663341a460be77463e186bb();
result.InnerFromArray(array);
    return result;
}

public static RL_641ffd2e0663341a460be77463e186bb ToList<T>(T[] array, Func <T, ST_b2c05afcf4810ad0d4384a01306bb0f3Structure> converter) {
  RL_641ffd2e0663341a460be77463e186bb result = new RL_641ffd2e0663341a460be77463e186bb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_641ffd2e0663341a460be77463e186bb FromRestList<T>(RestList<T> restList, Func <T, ST_b2c05afcf4810ad0d4384a01306bb0f3Structure> converter) {
  RL_641ffd2e0663341a460be77463e186bb result = new RL_641ffd2e0663341a460be77463e186bb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_641ffd2e0663341a460be77463e186bb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b2c05afcf4810ad0d4384a01306bb0f3Structure> NewList() {
return new RL_641ffd2e0663341a460be77463e186bb();
}


} // RL_641ffd2e0663341a460be77463e186bb
}

