namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DropdownServerSideItem_InternalConfigs (dLmJ218CdkqQoKXIqRC5ew)
///  <code>ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure</code> that represent
/// s <code>DropdownServerSideItem_InternalConfigs</code> <p>Description: Group of internal
///  configurations for the DropdownServerSideItem block. </p>
/// </summary>
// Name: DropdownServerSideItem_InternalConfigs
public partial struct ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure : ITypedRecord<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5PQW7zJ3EEel1dwC7+Qzfw");
internal static readonly GlobalObjectKey IdItemId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Hax+c3bku02OWg6Bj2lb2w");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*fVKaEN5rXUyldNZ735HJPw");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*4XUNdma2kkC20BaFZ3E5dA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ItemId")]
public string ssItemId;

[System.Xml.Serialization.XmlElement("IsSelected")]
public bool ssIsSelected;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssItemId = "";
ssIsSelected = false;
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
ssUniqueId = r.ReadText(index++, "DropdownServerSideItem_InternalConfigs.UniqueId", "");
ssItemId = r.ReadText(index++, "DropdownServerSideItem_InternalConfigs.ItemId", "");
ssIsSelected = r.ReadBoolean(index++, "DropdownServerSideItem_InternalConfigs.IsSelected", false);
ssExtendedClass = r.ReadText(index++, "DropdownServerSideItem_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure r) {
this = r;
}


public static bool operator == (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure a, ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssItemId != b.ssItemId) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure a, ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure)) return false;
return (this == (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssItemId.GetHashCode()
 ^ ssIsSelected.GetHashCode()
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


public ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure Duplicate() {
ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssItemId = this.ssItemId;
t.ssIsSelected = this.ssIsSelected;
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
} else if (head == "itemid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemId")) variable.Value = ssItemId; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdItemId) {
return ssItemId;
}
if (key == IdIsSelected) {
return ssIsSelected;
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
if (attributeKey == IdItemId.Key.AsGuid) {
return ssItemId;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssItemId = (string) other.AttributeGet(IdItemId);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure
/// <summary>
/// RecordList type <code>DropdownServerSideItem_InternalConfigsList</code> that represents a record
///  list of <code>DropdownServerSideItem_InternalConfigs</code>
/// </summary>
public partial class RL_dce3f06b54239d1a341b332bfbc48ec2 : GenericRecordList<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure GetElementDefaultValue() {
return new ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure();
}

public T[] ToArray<T>(Func<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dce3f06b54239d1a341b332bfbc48ec2 recordList, Func<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dce3f06b54239d1a341b332bfbc48ec2(ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure[] array) {
  RL_dce3f06b54239d1a341b332bfbc48ec2 result = new RL_dce3f06b54239d1a341b332bfbc48ec2();
result.InnerFromArray(array);
    return result;
}

public static RL_dce3f06b54239d1a341b332bfbc48ec2 ToList<T>(T[] array, Func <T, ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure> converter) {
  RL_dce3f06b54239d1a341b332bfbc48ec2 result = new RL_dce3f06b54239d1a341b332bfbc48ec2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dce3f06b54239d1a341b332bfbc48ec2 FromRestList<T>(RestList<T> restList, Func <T, ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure> converter) {
  RL_dce3f06b54239d1a341b332bfbc48ec2 result = new RL_dce3f06b54239d1a341b332bfbc48ec2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dce3f06b54239d1a341b332bfbc48ec2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure> NewList() {
return new RL_dce3f06b54239d1a341b332bfbc48ec2();
}


} // RL_dce3f06b54239d1a341b332bfbc48ec2
}

