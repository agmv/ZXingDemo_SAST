namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_Configs (ZRXDTr30qEugunKn7iL2aA)
///  <code>ST_78d3133d124713193d703c2644ecd39bStructure</code> that represent
/// s <code>Internal_Configs</code> <p>Description: Structure to handle internal configurations for the
///  Map.</p>
/// </summary>
// Name: Internal_Configs
public partial struct ST_78d3133d124713193d703c2644ecd39bStructure : ITypedRecord<ST_78d3133d124713193d703c2644ecd39bStructure> {
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*H+hk2m4qCE6g1DgUiwKhfw");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*hRnnVZb9wUany4izxxRhoA");
internal static readonly GlobalObjectKey IdInternal_to_provider_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*CoeScC0Mc0aMUgkMz1F_EA");
internal static readonly GlobalObjectKey IdStaticMapURL = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*4C9qFYGPlkCUwHsjydanmg");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Y9oGgkqHBk2I8cdpa6M1OQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("Height")]
public string ssHeight;

[System.Xml.Serialization.XmlElement("Internal_to_provider_configs")]
public ST_5baae74ed57e3bb61180aff1dadec4e1Structure ssInternal_to_provider_configs;

[System.Xml.Serialization.XmlElement("StaticMapURL")]
public string ssStaticMapURL;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_78d3133d124713193d703c2644ecd39bStructure() {
OptimizedAttributes = null;
ssExtendedClass = "";
ssHeight = "";
ssInternal_to_provider_configs = new ST_5baae74ed57e3bb61180aff1dadec4e1Structure();
ssStaticMapURL = "";
ssUniqueId = "";
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
    ssInternal_to_provider_configs.OptimizedAttributes = value[0];
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
ssExtendedClass = r.ReadText(index++, "Internal_Configs.ExtendedClass", "");
ssHeight = r.ReadText(index++, "Internal_Configs.Height", "");
ssStaticMapURL = r.ReadText(index++, "Internal_Configs.StaticMapURL", "");
ssUniqueId = r.ReadText(index++, "Internal_Configs.UniqueId", "");
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
public void ReadIM(ST_78d3133d124713193d703c2644ecd39bStructure r) {
this = r;
}


public static bool operator == (ST_78d3133d124713193d703c2644ecd39bStructure a, ST_78d3133d124713193d703c2644ecd39bStructure b) {
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssHeight != b.ssHeight) return false;
if (a.ssInternal_to_provider_configs != b.ssInternal_to_provider_configs) return false;
if (a.ssStaticMapURL != b.ssStaticMapURL) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_78d3133d124713193d703c2644ecd39bStructure a, ST_78d3133d124713193d703c2644ecd39bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_78d3133d124713193d703c2644ecd39bStructure)) return false;
return (this == (ST_78d3133d124713193d703c2644ecd39bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssHeight.GetHashCode()
 ^ ssInternal_to_provider_configs.GetHashCode()
 ^ ssStaticMapURL.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_configs.InternalRecursiveSave();
}


public ST_78d3133d124713193d703c2644ecd39bStructure Duplicate() {
ST_78d3133d124713193d703c2644ecd39bStructure t;
t.ssExtendedClass = this.ssExtendedClass;
t.ssHeight = this.ssHeight;
t.ssInternal_to_provider_configs = (ST_5baae74ed57e3bb61180aff1dadec4e1Structure)this.ssInternal_to_provider_configs.Duplicate();
t.ssStaticMapURL = this.ssStaticMapURL;
t.ssUniqueId = this.ssUniqueId;
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
if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
} else if (head == "internal_to_provider_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_configs")) variable.Value = ssInternal_to_provider_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_configs");
} else if (head == "staticmapurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StaticMapURL")) variable.Value = ssStaticMapURL; else variable.Optimized = true;
} else if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
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
if (key == IdExtendedClass) {
return ssExtendedClass;
}
if (key == IdHeight) {
return ssHeight;
}
if (key == IdInternal_to_provider_configs) {
return ssInternal_to_provider_configs;
}
if (key == IdStaticMapURL) {
return ssStaticMapURL;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
if (attributeKey == IdInternal_to_provider_configs.Key.AsGuid) {
return ssInternal_to_provider_configs;
}
if (attributeKey == IdStaticMapURL.Key.AsGuid) {
return ssStaticMapURL;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssHeight = (string) other.AttributeGet(IdHeight);
ssInternal_to_provider_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_configs));
ssStaticMapURL = (string) other.AttributeGet(IdStaticMapURL);
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_78d3133d124713193d703c2644ecd39bStructure
/// <summary>
/// RecordList type <code>Internal_ConfigsList</code> that represents a record list of
///  <code>Internal_Configs</code>
/// </summary>
public partial class RL_8261860bc5d9da142a31f73ae9b497b1 : GenericRecordList<ST_78d3133d124713193d703c2644ecd39bStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_78d3133d124713193d703c2644ecd39bStructure GetElementDefaultValue() {
return new ST_78d3133d124713193d703c2644ecd39bStructure();
}

public T[] ToArray<T>(Func<ST_78d3133d124713193d703c2644ecd39bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8261860bc5d9da142a31f73ae9b497b1 recordList, Func<ST_78d3133d124713193d703c2644ecd39bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8261860bc5d9da142a31f73ae9b497b1(ST_78d3133d124713193d703c2644ecd39bStructure[] array) {
  RL_8261860bc5d9da142a31f73ae9b497b1 result = new RL_8261860bc5d9da142a31f73ae9b497b1();
result.InnerFromArray(array);
    return result;
}

public static RL_8261860bc5d9da142a31f73ae9b497b1 ToList<T>(T[] array, Func <T, ST_78d3133d124713193d703c2644ecd39bStructure> converter) {
  RL_8261860bc5d9da142a31f73ae9b497b1 result = new RL_8261860bc5d9da142a31f73ae9b497b1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8261860bc5d9da142a31f73ae9b497b1 FromRestList<T>(RestList<T> restList, Func <T, ST_78d3133d124713193d703c2644ecd39bStructure> converter) {
  RL_8261860bc5d9da142a31f73ae9b497b1 result = new RL_8261860bc5d9da142a31f73ae9b497b1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8261860bc5d9da142a31f73ae9b497b1() : base() {
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
protected override OSList<ST_78d3133d124713193d703c2644ecd39bStructure> NewList() {
return new RL_8261860bc5d9da142a31f73ae9b497b1();
}


} // RL_8261860bc5d9da142a31f73ae9b497b1
}

