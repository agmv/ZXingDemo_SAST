namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_drawMarker_configs (D2F4gyUAlE2H8DJrHI41Qg)
///  <code>ST_f121435b3edb481ee03ab7ef58e5b805Structure</code> that represent
/// s <code>Internal_to_provider_drawMarker_configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_to_provider_drawMarker_configs
public partial struct ST_f121435b3edb481ee03ab7ef58e5b805Structure : ITypedRecord<ST_f121435b3edb481ee03ab7ef58e5b805Structure> {
internal static readonly GlobalObjectKey IdallowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*qiq5pQRNtESPBcacaaXuTA");
internal static readonly GlobalObjectKey IdiconUrl = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*_N6GMYqC40ePhVV9L52yig");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("allowDrag")]
public bool ssallowDrag;

[System.Xml.Serialization.XmlElement("iconUrl")]
public string ssiconUrl;


public BitArray OptimizedAttributes;

public ST_f121435b3edb481ee03ab7ef58e5b805Structure() {
OptimizedAttributes = null;
ssallowDrag = false;
ssiconUrl = "";
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
ssallowDrag = r.ReadBoolean(index++, "Internal_to_provider_drawMarker_configs.allowDrag", false);
ssiconUrl = r.ReadText(index++, "Internal_to_provider_drawMarker_configs.iconUrl", "");
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
public void ReadIM(ST_f121435b3edb481ee03ab7ef58e5b805Structure r) {
this = r;
}


public static bool operator == (ST_f121435b3edb481ee03ab7ef58e5b805Structure a, ST_f121435b3edb481ee03ab7ef58e5b805Structure b) {
if (a.ssallowDrag != b.ssallowDrag) return false;
if (a.ssiconUrl != b.ssiconUrl) return false;
return true;
}

public static bool operator != (ST_f121435b3edb481ee03ab7ef58e5b805Structure a, ST_f121435b3edb481ee03ab7ef58e5b805Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f121435b3edb481ee03ab7ef58e5b805Structure)) return false;
return (this == (ST_f121435b3edb481ee03ab7ef58e5b805Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssallowDrag.GetHashCode()
 ^ ssiconUrl.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f121435b3edb481ee03ab7ef58e5b805Structure Duplicate() {
ST_f121435b3edb481ee03ab7ef58e5b805Structure t;
t.ssallowDrag = this.ssallowDrag;
t.ssiconUrl = this.ssiconUrl;
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
if (head == "allowdrag") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".allowDrag")) variable.Value = ssallowDrag; else variable.Optimized = true;
} else if (head == "iconurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".iconUrl")) variable.Value = ssiconUrl; else variable.Optimized = true;
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
if (key == IdallowDrag) {
return ssallowDrag;
}
if (key == IdiconUrl) {
return ssiconUrl;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdallowDrag.Key.AsGuid) {
return ssallowDrag;
}
if (attributeKey == IdiconUrl.Key.AsGuid) {
return ssiconUrl;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssallowDrag = (bool) other.AttributeGet(IdallowDrag);
ssiconUrl = (string) other.AttributeGet(IdiconUrl);
}
} // ST_f121435b3edb481ee03ab7ef58e5b805Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_drawMarker_configsList</code> that represents a record
///  list of <code>Internal_to_provider_drawMarker_configs</code>
/// </summary>
public partial class RL_3b9b74504238c1837b79b58dfe494b5b : GenericRecordList<ST_f121435b3edb481ee03ab7ef58e5b805Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f121435b3edb481ee03ab7ef58e5b805Structure GetElementDefaultValue() {
return new ST_f121435b3edb481ee03ab7ef58e5b805Structure();
}

public T[] ToArray<T>(Func<ST_f121435b3edb481ee03ab7ef58e5b805Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3b9b74504238c1837b79b58dfe494b5b recordList, Func<ST_f121435b3edb481ee03ab7ef58e5b805Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3b9b74504238c1837b79b58dfe494b5b(ST_f121435b3edb481ee03ab7ef58e5b805Structure[] array) {
  RL_3b9b74504238c1837b79b58dfe494b5b result = new RL_3b9b74504238c1837b79b58dfe494b5b();
result.InnerFromArray(array);
    return result;
}

public static RL_3b9b74504238c1837b79b58dfe494b5b ToList<T>(T[] array, Func <T, ST_f121435b3edb481ee03ab7ef58e5b805Structure> converter) {
  RL_3b9b74504238c1837b79b58dfe494b5b result = new RL_3b9b74504238c1837b79b58dfe494b5b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3b9b74504238c1837b79b58dfe494b5b FromRestList<T>(RestList<T> restList, Func <T, ST_f121435b3edb481ee03ab7ef58e5b805Structure> converter) {
  RL_3b9b74504238c1837b79b58dfe494b5b result = new RL_3b9b74504238c1837b79b58dfe494b5b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3b9b74504238c1837b79b58dfe494b5b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f121435b3edb481ee03ab7ef58e5b805Structure> NewList() {
return new RL_3b9b74504238c1837b79b58dfe494b5b();
}


} // RL_3b9b74504238c1837b79b58dfe494b5b
}

