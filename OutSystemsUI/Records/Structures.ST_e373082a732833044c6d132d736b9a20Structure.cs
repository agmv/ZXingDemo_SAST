namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Submenu_InternalConfig (aNqOE1Mk4kyFjAPdlUZZGg)
///  <code>ST_e373082a732833044c6d132d736b9a20Structure</code> that represent
/// s <code>Submenu_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Submenu block. </p>
/// </summary>
// Name: Submenu_InternalConfig
public partial struct ST_e373082a732833044c6d132d736b9a20Structure : ITypedRecord<ST_e373082a732833044c6d132d736b9a20Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*9m+47V_zVEeQo285zlMICw");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*QmCeH0tKNEWPa2ay2nM9Yw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_e373082a732833044c6d132d736b9a20Structure() {
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
ssUniqueId = r.ReadText(index++, "Submenu_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "Submenu_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_e373082a732833044c6d132d736b9a20Structure r) {
this = r;
}


public static bool operator == (ST_e373082a732833044c6d132d736b9a20Structure a, ST_e373082a732833044c6d132d736b9a20Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_e373082a732833044c6d132d736b9a20Structure a, ST_e373082a732833044c6d132d736b9a20Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e373082a732833044c6d132d736b9a20Structure)) return false;
return (this == (ST_e373082a732833044c6d132d736b9a20Structure)o);
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


public ST_e373082a732833044c6d132d736b9a20Structure Duplicate() {
ST_e373082a732833044c6d132d736b9a20Structure t;
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
} // ST_e373082a732833044c6d132d736b9a20Structure
/// <summary>
/// RecordList type <code>Submenu_InternalConfigList</code> that represents a record list of
///  <code>Submenu_InternalConfig</code>
/// </summary>
public partial class RL_ca76f33b4bf777f87addea60d1bc4e8c : GenericRecordList<ST_e373082a732833044c6d132d736b9a20Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_e373082a732833044c6d132d736b9a20Structure GetElementDefaultValue() {
return new ST_e373082a732833044c6d132d736b9a20Structure();
}

public T[] ToArray<T>(Func<ST_e373082a732833044c6d132d736b9a20Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ca76f33b4bf777f87addea60d1bc4e8c recordList, Func<ST_e373082a732833044c6d132d736b9a20Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ca76f33b4bf777f87addea60d1bc4e8c(ST_e373082a732833044c6d132d736b9a20Structure[] array) {
  RL_ca76f33b4bf777f87addea60d1bc4e8c result = new RL_ca76f33b4bf777f87addea60d1bc4e8c();
result.InnerFromArray(array);
    return result;
}

public static RL_ca76f33b4bf777f87addea60d1bc4e8c ToList<T>(T[] array, Func <T, ST_e373082a732833044c6d132d736b9a20Structure> converter) {
  RL_ca76f33b4bf777f87addea60d1bc4e8c result = new RL_ca76f33b4bf777f87addea60d1bc4e8c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ca76f33b4bf777f87addea60d1bc4e8c FromRestList<T>(RestList<T> restList, Func <T, ST_e373082a732833044c6d132d736b9a20Structure> converter) {
  RL_ca76f33b4bf777f87addea60d1bc4e8c result = new RL_ca76f33b4bf777f87addea60d1bc4e8c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ca76f33b4bf777f87addea60d1bc4e8c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e373082a732833044c6d132d736b9a20Structure> NewList() {
return new RL_ca76f33b4bf777f87addea60d1bc4e8c();
}


} // RL_ca76f33b4bf777f87addea60d1bc4e8c
}

