namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Gallery_InternalConfig (fMj_IFecB0GVe95ppGgX8A)
///  <code>ST_546a3060996e070a522a708cd2d94c23Structure</code> that represent
/// s <code>Gallery_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Gallery block. </p>
/// </summary>
// Name: Gallery_InternalConfig
public partial struct ST_546a3060996e070a522a708cd2d94c23Structure : ITypedRecord<ST_546a3060996e070a522a708cd2d94c23Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*EIpdsR9NWkSkqe3t57cPCg");
internal static readonly GlobalObjectKey IdRowItemsPhone = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*AFjXG0GFVkmFZY5Bmfp72A");
internal static readonly GlobalObjectKey IdRowItemsTablet = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6VGXohepeE2QMzLn1q0j2A");
internal static readonly GlobalObjectKey IdRowItemsDesktop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*45DRvpB9Vke3Tn6byjnX7g");
internal static readonly GlobalObjectKey IdItemsGap = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*fvY35cK5uUOO5wXlxPvjjQ");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*F2Vk4iR55kWFeucbA+IYdw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("RowItemsPhone")]
public string ssRowItemsPhone;

[System.Xml.Serialization.XmlElement("RowItemsTablet")]
public string ssRowItemsTablet;

[System.Xml.Serialization.XmlElement("RowItemsDesktop")]
public string ssRowItemsDesktop;

[System.Xml.Serialization.XmlElement("ItemsGap")]
public string ssItemsGap;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_546a3060996e070a522a708cd2d94c23Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssRowItemsPhone = "";
ssRowItemsTablet = "";
ssRowItemsDesktop = "";
ssItemsGap = "";
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
ssUniqueId = r.ReadText(index++, "Gallery_InternalConfig.UniqueId", "");
ssRowItemsPhone = r.ReadPhoneNumber(index++, "Gallery_InternalConfig.RowItemsPhone", "");
ssRowItemsTablet = r.ReadText(index++, "Gallery_InternalConfig.RowItemsTablet", "");
ssRowItemsDesktop = r.ReadText(index++, "Gallery_InternalConfig.RowItemsDesktop", "");
ssItemsGap = r.ReadEntityReferenceText(index++, "Gallery_InternalConfig.ItemsGap", "");
ssExtendedClass = r.ReadText(index++, "Gallery_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_546a3060996e070a522a708cd2d94c23Structure r) {
this = r;
}


public static bool operator == (ST_546a3060996e070a522a708cd2d94c23Structure a, ST_546a3060996e070a522a708cd2d94c23Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssRowItemsPhone != b.ssRowItemsPhone) return false;
if (a.ssRowItemsTablet != b.ssRowItemsTablet) return false;
if (a.ssRowItemsDesktop != b.ssRowItemsDesktop) return false;
if (a.ssItemsGap != b.ssItemsGap) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_546a3060996e070a522a708cd2d94c23Structure a, ST_546a3060996e070a522a708cd2d94c23Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_546a3060996e070a522a708cd2d94c23Structure)) return false;
return (this == (ST_546a3060996e070a522a708cd2d94c23Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssRowItemsPhone.GetHashCode()
 ^ ssRowItemsTablet.GetHashCode()
 ^ ssRowItemsDesktop.GetHashCode()
 ^ ssItemsGap.GetHashCode()
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


public ST_546a3060996e070a522a708cd2d94c23Structure Duplicate() {
ST_546a3060996e070a522a708cd2d94c23Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssRowItemsPhone = this.ssRowItemsPhone;
t.ssRowItemsTablet = this.ssRowItemsTablet;
t.ssRowItemsDesktop = this.ssRowItemsDesktop;
t.ssItemsGap = this.ssItemsGap;
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
} else if (head == "rowitemsphone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RowItemsPhone")) variable.Value = ssRowItemsPhone; else variable.Optimized = true;
} else if (head == "rowitemstablet") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RowItemsTablet")) variable.Value = ssRowItemsTablet; else variable.Optimized = true;
} else if (head == "rowitemsdesktop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RowItemsDesktop")) variable.Value = ssRowItemsDesktop; else variable.Optimized = true;
} else if (head == "itemsgap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsGap")) variable.Value = ssItemsGap; else variable.Optimized = true;
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
if (key == IdRowItemsPhone) {
return ssRowItemsPhone;
}
if (key == IdRowItemsTablet) {
return ssRowItemsTablet;
}
if (key == IdRowItemsDesktop) {
return ssRowItemsDesktop;
}
if (key == IdItemsGap) {
return ssItemsGap;
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
if (attributeKey == IdRowItemsPhone.Key.AsGuid) {
return ssRowItemsPhone;
}
if (attributeKey == IdRowItemsTablet.Key.AsGuid) {
return ssRowItemsTablet;
}
if (attributeKey == IdRowItemsDesktop.Key.AsGuid) {
return ssRowItemsDesktop;
}
if (attributeKey == IdItemsGap.Key.AsGuid) {
return ssItemsGap;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssRowItemsPhone = (string) other.AttributeGet(IdRowItemsPhone);
ssRowItemsTablet = (string) other.AttributeGet(IdRowItemsTablet);
ssRowItemsDesktop = (string) other.AttributeGet(IdRowItemsDesktop);
ssItemsGap = (string) other.AttributeGet(IdItemsGap);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_546a3060996e070a522a708cd2d94c23Structure
/// <summary>
/// RecordList type <code>Gallery_InternalConfigList</code> that represents a record list of
///  <code>Gallery_InternalConfig</code>
/// </summary>
public partial class RL_ee3b3fae9cabe5575be671b0ad7cd7cc : GenericRecordList<ST_546a3060996e070a522a708cd2d94c23Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_546a3060996e070a522a708cd2d94c23Structure GetElementDefaultValue() {
return new ST_546a3060996e070a522a708cd2d94c23Structure();
}

public T[] ToArray<T>(Func<ST_546a3060996e070a522a708cd2d94c23Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ee3b3fae9cabe5575be671b0ad7cd7cc recordList, Func<ST_546a3060996e070a522a708cd2d94c23Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ee3b3fae9cabe5575be671b0ad7cd7cc(ST_546a3060996e070a522a708cd2d94c23Structure[] array) {
  RL_ee3b3fae9cabe5575be671b0ad7cd7cc result = new RL_ee3b3fae9cabe5575be671b0ad7cd7cc();
result.InnerFromArray(array);
    return result;
}

public static RL_ee3b3fae9cabe5575be671b0ad7cd7cc ToList<T>(T[] array, Func <T, ST_546a3060996e070a522a708cd2d94c23Structure> converter) {
  RL_ee3b3fae9cabe5575be671b0ad7cd7cc result = new RL_ee3b3fae9cabe5575be671b0ad7cd7cc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ee3b3fae9cabe5575be671b0ad7cd7cc FromRestList<T>(RestList<T> restList, Func <T, ST_546a3060996e070a522a708cd2d94c23Structure> converter) {
  RL_ee3b3fae9cabe5575be671b0ad7cd7cc result = new RL_ee3b3fae9cabe5575be671b0ad7cd7cc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ee3b3fae9cabe5575be671b0ad7cd7cc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_546a3060996e070a522a708cd2d94c23Structure> NewList() {
return new RL_ee3b3fae9cabe5575be671b0ad7cd7cc();
}


} // RL_ee3b3fae9cabe5575be671b0ad7cd7cc
}

