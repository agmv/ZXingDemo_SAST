namespace ssOutSystemsUI {
/// <summary>
/// [Structure] AccordionItem_InternalConfigs (NRG39adgLEGoSmglXlJNUg)
///  <code>ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure</code> that represent
/// s <code>AccordionItem_InternalConfigs</code> <p>Description: Group of internal configurations for
///  the AccordionItem block. </p>
/// </summary>
// Name: AccordionItem_InternalConfigs
public partial struct ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure : ITypedRecord<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ffThclzZ_UC4bDvAm0lNTg");
internal static readonly GlobalObjectKey IdStartsExpanded = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*rO3c14W_O06aRCKRDtC_cA");
internal static readonly GlobalObjectKey IdIcon = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*2nZRnOVxkk6CaukLK55qOw");
internal static readonly GlobalObjectKey IdIconPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*l_lppWmJ40qdot4ulfco9w");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_6ZBqh8O0UydfduH80t+0w");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*SJA8IgSbO0+Q75FTKCI7iw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("StartsExpanded")]
public bool ssStartsExpanded;

[System.Xml.Serialization.XmlElement("Icon")]
public string ssIcon;

[System.Xml.Serialization.XmlElement("IconPosition")]
public string ssIconPosition;

[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssStartsExpanded = false;
ssIcon = "";
ssIconPosition = "";
ssIsDisabled = false;
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
ssUniqueId = r.ReadText(index++, "AccordionItem_InternalConfigs.UniqueId", "");
ssStartsExpanded = r.ReadBoolean(index++, "AccordionItem_InternalConfigs.StartsExpanded", false);
ssIcon = r.ReadEntityReferenceText(index++, "AccordionItem_InternalConfigs.Icon", "");
ssIconPosition = r.ReadEntityReferenceText(index++, "AccordionItem_InternalConfigs.IconPosition", "");
ssIsDisabled = r.ReadBoolean(index++, "AccordionItem_InternalConfigs.IsDisabled", false);
ssExtendedClass = r.ReadText(index++, "AccordionItem_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure r) {
this = r;
}


public static bool operator == (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure a, ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssStartsExpanded != b.ssStartsExpanded) return false;
if (a.ssIcon != b.ssIcon) return false;
if (a.ssIconPosition != b.ssIconPosition) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure a, ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure)) return false;
return (this == (ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssStartsExpanded.GetHashCode()
 ^ ssIcon.GetHashCode()
 ^ ssIconPosition.GetHashCode()
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


public ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure Duplicate() {
ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssStartsExpanded = this.ssStartsExpanded;
t.ssIcon = this.ssIcon;
t.ssIconPosition = this.ssIconPosition;
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
} else if (head == "startsexpanded") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartsExpanded")) variable.Value = ssStartsExpanded; else variable.Optimized = true;
} else if (head == "icon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Icon")) variable.Value = ssIcon; else variable.Optimized = true;
} else if (head == "iconposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IconPosition")) variable.Value = ssIconPosition; else variable.Optimized = true;
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
if (key == IdStartsExpanded) {
return ssStartsExpanded;
}
if (key == IdIcon) {
return ssIcon;
}
if (key == IdIconPosition) {
return ssIconPosition;
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
if (attributeKey == IdStartsExpanded.Key.AsGuid) {
return ssStartsExpanded;
}
if (attributeKey == IdIcon.Key.AsGuid) {
return ssIcon;
}
if (attributeKey == IdIconPosition.Key.AsGuid) {
return ssIconPosition;
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
ssStartsExpanded = (bool) other.AttributeGet(IdStartsExpanded);
ssIcon = (string) other.AttributeGet(IdIcon);
ssIconPosition = (string) other.AttributeGet(IdIconPosition);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure
/// <summary>
/// RecordList type <code>AccordionItem_InternalConfigsList</code> that represents a record list of
///  <code>AccordionItem_InternalConfigs</code>
/// </summary>
public partial class RL_c96c932beb2df37555eef63900365df4 : GenericRecordList<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure GetElementDefaultValue() {
return new ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure();
}

public T[] ToArray<T>(Func<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c96c932beb2df37555eef63900365df4 recordList, Func<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c96c932beb2df37555eef63900365df4(ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure[] array) {
  RL_c96c932beb2df37555eef63900365df4 result = new RL_c96c932beb2df37555eef63900365df4();
result.InnerFromArray(array);
    return result;
}

public static RL_c96c932beb2df37555eef63900365df4 ToList<T>(T[] array, Func <T, ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> converter) {
  RL_c96c932beb2df37555eef63900365df4 result = new RL_c96c932beb2df37555eef63900365df4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c96c932beb2df37555eef63900365df4 FromRestList<T>(RestList<T> restList, Func <T, ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> converter) {
  RL_c96c932beb2df37555eef63900365df4 result = new RL_c96c932beb2df37555eef63900365df4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c96c932beb2df37555eef63900365df4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ef80898cf0e45bb0e0895a62dd0c45b1Structure> NewList() {
return new RL_c96c932beb2df37555eef63900365df4();
}


} // RL_c96c932beb2df37555eef63900365df4
}

