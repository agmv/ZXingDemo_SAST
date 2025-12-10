namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_fileLayer_configs (4xEbhNlUi06CHfLsPoXhzg)
///  <code>ST_793e574f3ddb64f39831eacf8a4462b0Structure</code> that represent
/// s <code>Internal_to_provider_fileLayer_configs</code> <p>Description: Set additional parameters to
///  customize the file layer behavior and functionality.</p>
/// </summary>
// Name: Internal_to_provider_fileLayer_configs
public partial struct ST_793e574f3ddb64f39831eacf8a4462b0Structure : ITypedRecord<ST_793e574f3ddb64f39831eacf8a4462b0Structure> {
internal static readonly GlobalObjectKey IdlayerUrl = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*lIXC5ouBvEGh3H_bj3535Q");
internal static readonly GlobalObjectKey IdsuppressPopups = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*PlWKucqT40iLlx23uFBdGA");
internal static readonly GlobalObjectKey IdpreserveViewport = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*tvboi0kxgUW_fAsSNhl3QQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("layerUrl")]
public string sslayerUrl;

[System.Xml.Serialization.XmlElement("suppressPopups")]
public bool sssuppressPopups;

[System.Xml.Serialization.XmlElement("preserveViewport")]
public bool sspreserveViewport;


public BitArray OptimizedAttributes;

public ST_793e574f3ddb64f39831eacf8a4462b0Structure() {
OptimizedAttributes = null;
sslayerUrl = "";
sssuppressPopups = false;
sspreserveViewport = false;
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
sslayerUrl = r.ReadText(index++, "Internal_to_provider_fileLayer_configs.layerUrl", "");
sssuppressPopups = r.ReadBoolean(index++, "Internal_to_provider_fileLayer_configs.suppressPopups", false);
sspreserveViewport = r.ReadBoolean(index++, "Internal_to_provider_fileLayer_configs.preserveViewport", false);
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
public void ReadIM(ST_793e574f3ddb64f39831eacf8a4462b0Structure r) {
this = r;
}


public static bool operator == (ST_793e574f3ddb64f39831eacf8a4462b0Structure a, ST_793e574f3ddb64f39831eacf8a4462b0Structure b) {
if (a.sslayerUrl != b.sslayerUrl) return false;
if (a.sssuppressPopups != b.sssuppressPopups) return false;
if (a.sspreserveViewport != b.sspreserveViewport) return false;
return true;
}

public static bool operator != (ST_793e574f3ddb64f39831eacf8a4462b0Structure a, ST_793e574f3ddb64f39831eacf8a4462b0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_793e574f3ddb64f39831eacf8a4462b0Structure)) return false;
return (this == (ST_793e574f3ddb64f39831eacf8a4462b0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sslayerUrl.GetHashCode()
 ^ sssuppressPopups.GetHashCode()
 ^ sspreserveViewport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_793e574f3ddb64f39831eacf8a4462b0Structure Duplicate() {
ST_793e574f3ddb64f39831eacf8a4462b0Structure t;
t.sslayerUrl = this.sslayerUrl;
t.sssuppressPopups = this.sssuppressPopups;
t.sspreserveViewport = this.sspreserveViewport;
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
if (head == "layerurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".layerUrl")) variable.Value = sslayerUrl; else variable.Optimized = true;
} else if (head == "suppresspopups") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".suppressPopups")) variable.Value = sssuppressPopups; else variable.Optimized = true;
} else if (head == "preserveviewport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".preserveViewport")) variable.Value = sspreserveViewport; else variable.Optimized = true;
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
if (key == IdlayerUrl) {
return sslayerUrl;
}
if (key == IdsuppressPopups) {
return sssuppressPopups;
}
if (key == IdpreserveViewport) {
return sspreserveViewport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdlayerUrl.Key.AsGuid) {
return sslayerUrl;
}
if (attributeKey == IdsuppressPopups.Key.AsGuid) {
return sssuppressPopups;
}
if (attributeKey == IdpreserveViewport.Key.AsGuid) {
return sspreserveViewport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
sslayerUrl = (string) other.AttributeGet(IdlayerUrl);
sssuppressPopups = (bool) other.AttributeGet(IdsuppressPopups);
sspreserveViewport = (bool) other.AttributeGet(IdpreserveViewport);
}
} // ST_793e574f3ddb64f39831eacf8a4462b0Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_fileLayer_configsList</code> that represents a record
///  list of <code>Internal_to_provider_fileLayer_configs</code>
/// </summary>
public partial class RL_117c109748f839c6db14d3cec441846b : GenericRecordList<ST_793e574f3ddb64f39831eacf8a4462b0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_793e574f3ddb64f39831eacf8a4462b0Structure GetElementDefaultValue() {
return new ST_793e574f3ddb64f39831eacf8a4462b0Structure();
}

public T[] ToArray<T>(Func<ST_793e574f3ddb64f39831eacf8a4462b0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_117c109748f839c6db14d3cec441846b recordList, Func<ST_793e574f3ddb64f39831eacf8a4462b0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_117c109748f839c6db14d3cec441846b(ST_793e574f3ddb64f39831eacf8a4462b0Structure[] array) {
  RL_117c109748f839c6db14d3cec441846b result = new RL_117c109748f839c6db14d3cec441846b();
result.InnerFromArray(array);
    return result;
}

public static RL_117c109748f839c6db14d3cec441846b ToList<T>(T[] array, Func <T, ST_793e574f3ddb64f39831eacf8a4462b0Structure> converter) {
  RL_117c109748f839c6db14d3cec441846b result = new RL_117c109748f839c6db14d3cec441846b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_117c109748f839c6db14d3cec441846b FromRestList<T>(RestList<T> restList, Func <T, ST_793e574f3ddb64f39831eacf8a4462b0Structure> converter) {
  RL_117c109748f839c6db14d3cec441846b result = new RL_117c109748f839c6db14d3cec441846b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_117c109748f839c6db14d3cec441846b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_793e574f3ddb64f39831eacf8a4462b0Structure> NewList() {
return new RL_117c109748f839c6db14d3cec441846b();
}


} // RL_117c109748f839c6db14d3cec441846b
}

