namespace ssOutSystemsUI {
/// <summary>
/// [Structure] TabsHeaderItem_InternalConfig (WG08PF53dU2ieSkrt9nF6g)
///  <code>ST_4f70c42b393d853a53e093e196f4b683Structure</code> that represent
/// s <code>TabsHeaderItem_InternalConfig</code> <p>Description: Group of internal configurations for
///  the TabsHeaderItem block. </p>
/// </summary>
// Name: TabsHeaderItem_InternalConfig
public partial struct ST_4f70c42b393d853a53e093e196f4b683Structure : ITypedRecord<ST_4f70c42b393d853a53e093e196f4b683Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*GGu5_rCAkESn5jemqe_KAg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1aAdx1OlZUK5iKSubMyYcA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_4f70c42b393d853a53e093e196f4b683Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
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
ssUniqueId = r.ReadText(index++, "TabsHeaderItem_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "TabsHeaderItem_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_4f70c42b393d853a53e093e196f4b683Structure r) {
this = r;
}


public static bool operator == (ST_4f70c42b393d853a53e093e196f4b683Structure a, ST_4f70c42b393d853a53e093e196f4b683Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_4f70c42b393d853a53e093e196f4b683Structure a, ST_4f70c42b393d853a53e093e196f4b683Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4f70c42b393d853a53e093e196f4b683Structure)) return false;
return (this == (ST_4f70c42b393d853a53e093e196f4b683Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
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


public ST_4f70c42b393d853a53e093e196f4b683Structure Duplicate() {
ST_4f70c42b393d853a53e093e196f4b683Structure t;
t.ssUniqueId = this.ssUniqueId;
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
if (key == IdExtendedClass) {
return ssExtendedClass;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_4f70c42b393d853a53e093e196f4b683Structure
/// <summary>
/// RecordList type <code>TabsHeaderItem_InternalConfigList</code> that represents a record list of
///  <code>TabsHeaderItem_InternalConfig</code>
/// </summary>
public partial class RL_b17d2ee19e721e639857531d2bbc81c0 : GenericRecordList<ST_4f70c42b393d853a53e093e196f4b683Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_4f70c42b393d853a53e093e196f4b683Structure GetElementDefaultValue() {
return new ST_4f70c42b393d853a53e093e196f4b683Structure();
}

public T[] ToArray<T>(Func<ST_4f70c42b393d853a53e093e196f4b683Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b17d2ee19e721e639857531d2bbc81c0 recordList, Func<ST_4f70c42b393d853a53e093e196f4b683Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b17d2ee19e721e639857531d2bbc81c0(ST_4f70c42b393d853a53e093e196f4b683Structure[] array) {
  RL_b17d2ee19e721e639857531d2bbc81c0 result = new RL_b17d2ee19e721e639857531d2bbc81c0();
result.InnerFromArray(array);
    return result;
}

public static RL_b17d2ee19e721e639857531d2bbc81c0 ToList<T>(T[] array, Func <T, ST_4f70c42b393d853a53e093e196f4b683Structure> converter) {
  RL_b17d2ee19e721e639857531d2bbc81c0 result = new RL_b17d2ee19e721e639857531d2bbc81c0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b17d2ee19e721e639857531d2bbc81c0 FromRestList<T>(RestList<T> restList, Func <T, ST_4f70c42b393d853a53e093e196f4b683Structure> converter) {
  RL_b17d2ee19e721e639857531d2bbc81c0 result = new RL_b17d2ee19e721e639857531d2bbc81c0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b17d2ee19e721e639857531d2bbc81c0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4f70c42b393d853a53e093e196f4b683Structure> NewList() {
return new RL_b17d2ee19e721e639857531d2bbc81c0();
}


} // RL_b17d2ee19e721e639857531d2bbc81c0
}

