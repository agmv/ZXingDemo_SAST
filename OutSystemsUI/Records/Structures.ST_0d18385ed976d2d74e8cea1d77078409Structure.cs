namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DropdownServerSide_InternalConfigs (u2rQ+boY_0e_oh4IBcDtfQ)
///  <code>ST_0d18385ed976d2d74e8cea1d77078409Structure</code> that represent
/// s <code>DropdownServerSide_InternalConfigs</code> <p>Description: Group of internal configurations
///  for the DropdownServerSide block. </p>
/// </summary>
// Name: DropdownServerSide_InternalConfigs
public partial struct ST_0d18385ed976d2d74e8cea1d77078409Structure : ITypedRecord<ST_0d18385ed976d2d74e8cea1d77078409Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*egtLhxiNPkKyTEQGQS_Tbw");
internal static readonly GlobalObjectKey IdAllowMultipleSelection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Fff2D3iShkO7bYC3IcdgBw");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Sr4sP7wbFUaH9yJqbEQoSQ");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*dwMXA6+hy0OYFZvE5AULLw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("AllowMultipleSelection")]
public bool ssAllowMultipleSelection;

[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_0d18385ed976d2d74e8cea1d77078409Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssAllowMultipleSelection = false;
ssIsDisabled = false;
ssExtendedClass = Convert.ToString(1);
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
ssUniqueId = r.ReadText(index++, "DropdownServerSide_InternalConfigs.UniqueId", "");
ssAllowMultipleSelection = r.ReadBoolean(index++, "DropdownServerSide_InternalConfigs.AllowMultipleSelection", false);
ssIsDisabled = r.ReadBoolean(index++, "DropdownServerSide_InternalConfigs.IsDisabled", false);
ssExtendedClass = r.ReadText(index++, "DropdownServerSide_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_0d18385ed976d2d74e8cea1d77078409Structure r) {
this = r;
}


public static bool operator == (ST_0d18385ed976d2d74e8cea1d77078409Structure a, ST_0d18385ed976d2d74e8cea1d77078409Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssAllowMultipleSelection != b.ssAllowMultipleSelection) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_0d18385ed976d2d74e8cea1d77078409Structure a, ST_0d18385ed976d2d74e8cea1d77078409Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0d18385ed976d2d74e8cea1d77078409Structure)) return false;
return (this == (ST_0d18385ed976d2d74e8cea1d77078409Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssAllowMultipleSelection.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
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


public ST_0d18385ed976d2d74e8cea1d77078409Structure Duplicate() {
ST_0d18385ed976d2d74e8cea1d77078409Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssAllowMultipleSelection = this.ssAllowMultipleSelection;
t.ssIsDisabled = this.ssIsDisabled;
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
} else if (head == "allowmultipleselection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllowMultipleSelection")) variable.Value = ssAllowMultipleSelection; else variable.Optimized = true;
} else if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
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
if (key == IdAllowMultipleSelection) {
return ssAllowMultipleSelection;
}
if (key == IdIsDisabled) {
return ssIsDisabled;
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
if (attributeKey == IdAllowMultipleSelection.Key.AsGuid) {
return ssAllowMultipleSelection;
}
if (attributeKey == IdIsDisabled.Key.AsGuid) {
return ssIsDisabled;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssAllowMultipleSelection = (bool) other.AttributeGet(IdAllowMultipleSelection);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_0d18385ed976d2d74e8cea1d77078409Structure
/// <summary>
/// RecordList type <code>DropdownServerSide_InternalConfigsList</code> that represents a record list
///  of <code>DropdownServerSide_InternalConfigs</code>
/// </summary>
public partial class RL_ce72a5ad70ab717754c27c16d3a4aee6 : GenericRecordList<ST_0d18385ed976d2d74e8cea1d77078409Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_0d18385ed976d2d74e8cea1d77078409Structure GetElementDefaultValue() {
return new ST_0d18385ed976d2d74e8cea1d77078409Structure();
}

public T[] ToArray<T>(Func<ST_0d18385ed976d2d74e8cea1d77078409Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ce72a5ad70ab717754c27c16d3a4aee6 recordList, Func<ST_0d18385ed976d2d74e8cea1d77078409Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ce72a5ad70ab717754c27c16d3a4aee6(ST_0d18385ed976d2d74e8cea1d77078409Structure[] array) {
  RL_ce72a5ad70ab717754c27c16d3a4aee6 result = new RL_ce72a5ad70ab717754c27c16d3a4aee6();
result.InnerFromArray(array);
    return result;
}

public static RL_ce72a5ad70ab717754c27c16d3a4aee6 ToList<T>(T[] array, Func <T, ST_0d18385ed976d2d74e8cea1d77078409Structure> converter) {
  RL_ce72a5ad70ab717754c27c16d3a4aee6 result = new RL_ce72a5ad70ab717754c27c16d3a4aee6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ce72a5ad70ab717754c27c16d3a4aee6 FromRestList<T>(RestList<T> restList, Func <T, ST_0d18385ed976d2d74e8cea1d77078409Structure> converter) {
  RL_ce72a5ad70ab717754c27c16d3a4aee6 result = new RL_ce72a5ad70ab717754c27c16d3a4aee6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ce72a5ad70ab717754c27c16d3a4aee6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0d18385ed976d2d74e8cea1d77078409Structure> NewList() {
return new RL_ce72a5ad70ab717754c27c16d3a4aee6();
}


} // RL_ce72a5ad70ab717754c27c16d3a4aee6
}

