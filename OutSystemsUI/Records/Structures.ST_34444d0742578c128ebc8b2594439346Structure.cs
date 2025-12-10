namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DropdownTagsOptionalConfigs (do9jkzG6BUq50KGz_s009w)
///  <code>ST_34444d0742578c128ebc8b2594439346Structure</code> that represent
/// s <code>DropdownTagsOptionalConfigs</code> <p>Description: DropdownTags optional configurations</p>
/// </summary>
// Name: DropdownTagsOptionalConfigs
public partial struct ST_34444d0742578c128ebc8b2594439346Structure : ITypedRecord<ST_34444d0742578c128ebc8b2594439346Structure> {
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ybL9+o6j6kKv0xspz36XgQ");
internal static readonly GlobalObjectKey IdNoResultsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*w0_1s81T80CLNeH_dJjPEA");
internal static readonly GlobalObjectKey IdSearchPrompt = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*paD3hoZlk0yhHU_LbF1d2w");
internal static readonly GlobalObjectKey IdNoOptionsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*owRrSMt6ZkKJ0JXR5FPXqA");
internal static readonly GlobalObjectKey IdSanitizeDropdownValues = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*aULcMoovZUCzC333+_5UBw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;

[System.Xml.Serialization.XmlElement("NoResultsText")]
public string ssNoResultsText;

[System.Xml.Serialization.XmlElement("SearchPrompt")]
public string ssSearchPrompt;

[System.Xml.Serialization.XmlElement("NoOptionsText")]
public string ssNoOptionsText;

[System.Xml.Serialization.XmlElement("SanitizeDropdownValues")]
public bool ssSanitizeDropdownValues;


public BitArray OptimizedAttributes;

public ST_34444d0742578c128ebc8b2594439346Structure() {
OptimizedAttributes = null;
ssIsDisabled = false;
ssNoResultsText = "There are no options to show.";
ssSearchPrompt = "Search...";
ssNoOptionsText = "There are no options to show.";
ssSanitizeDropdownValues = false;
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
ssIsDisabled = r.ReadBoolean(index++, "DropdownTagsOptionalConfigs.IsDisabled", false);
ssNoResultsText = r.ReadText(index++, "DropdownTagsOptionalConfigs.NoResultsText", "");
ssSearchPrompt = r.ReadText(index++, "DropdownTagsOptionalConfigs.SearchPrompt", "");
ssNoOptionsText = r.ReadText(index++, "DropdownTagsOptionalConfigs.NoOptionsText", "");
ssSanitizeDropdownValues = r.ReadBoolean(index++, "DropdownTagsOptionalConfigs.SanitizeDropdownValues", false);
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
public void ReadIM(ST_34444d0742578c128ebc8b2594439346Structure r) {
this = r;
}


public static bool operator == (ST_34444d0742578c128ebc8b2594439346Structure a, ST_34444d0742578c128ebc8b2594439346Structure b) {
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssNoResultsText != b.ssNoResultsText) return false;
if (a.ssSearchPrompt != b.ssSearchPrompt) return false;
if (a.ssNoOptionsText != b.ssNoOptionsText) return false;
if (a.ssSanitizeDropdownValues != b.ssSanitizeDropdownValues) return false;
return true;
}

public static bool operator != (ST_34444d0742578c128ebc8b2594439346Structure a, ST_34444d0742578c128ebc8b2594439346Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_34444d0742578c128ebc8b2594439346Structure)) return false;
return (this == (ST_34444d0742578c128ebc8b2594439346Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
 ^ ssNoResultsText.GetHashCode()
 ^ ssSearchPrompt.GetHashCode()
 ^ ssNoOptionsText.GetHashCode()
 ^ ssSanitizeDropdownValues.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_34444d0742578c128ebc8b2594439346Structure Duplicate() {
ST_34444d0742578c128ebc8b2594439346Structure t;
t.ssIsDisabled = this.ssIsDisabled;
t.ssNoResultsText = this.ssNoResultsText;
t.ssSearchPrompt = this.ssSearchPrompt;
t.ssNoOptionsText = this.ssNoOptionsText;
t.ssSanitizeDropdownValues = this.ssSanitizeDropdownValues;
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
if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
} else if (head == "noresultstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoResultsText")) variable.Value = ssNoResultsText; else variable.Optimized = true;
} else if (head == "searchprompt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchPrompt")) variable.Value = ssSearchPrompt; else variable.Optimized = true;
} else if (head == "nooptionstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoOptionsText")) variable.Value = ssNoOptionsText; else variable.Optimized = true;
} else if (head == "sanitizedropdownvalues") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SanitizeDropdownValues")) variable.Value = ssSanitizeDropdownValues; else variable.Optimized = true;
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
if (key == IdIsDisabled) {
return ssIsDisabled;
}
if (key == IdNoResultsText) {
return ssNoResultsText;
}
if (key == IdSearchPrompt) {
return ssSearchPrompt;
}
if (key == IdNoOptionsText) {
return ssNoOptionsText;
}
if (key == IdSanitizeDropdownValues) {
return ssSanitizeDropdownValues;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsDisabled.Key.AsGuid) {
return ssIsDisabled;
}
if (attributeKey == IdNoResultsText.Key.AsGuid) {
return ssNoResultsText;
}
if (attributeKey == IdSearchPrompt.Key.AsGuid) {
return ssSearchPrompt;
}
if (attributeKey == IdNoOptionsText.Key.AsGuid) {
return ssNoOptionsText;
}
if (attributeKey == IdSanitizeDropdownValues.Key.AsGuid) {
return ssSanitizeDropdownValues;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssNoResultsText = (string) other.AttributeGet(IdNoResultsText);
ssSearchPrompt = (string) other.AttributeGet(IdSearchPrompt);
ssNoOptionsText = (string) other.AttributeGet(IdNoOptionsText);
ssSanitizeDropdownValues = (bool) other.AttributeGet(IdSanitizeDropdownValues);
}
} // ST_34444d0742578c128ebc8b2594439346Structure
/// <summary>
/// RecordList type <code>DropdownTagsOptionalConfigsList</code> that represents a record list of
///  <code>DropdownTagsOptionalConfigs</code>
/// </summary>
public partial class RL_843bbe6b5508d5a1ce4c6547db1f1385 : GenericRecordList<ST_34444d0742578c128ebc8b2594439346Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_34444d0742578c128ebc8b2594439346Structure GetElementDefaultValue() {
return new ST_34444d0742578c128ebc8b2594439346Structure();
}

public T[] ToArray<T>(Func<ST_34444d0742578c128ebc8b2594439346Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_843bbe6b5508d5a1ce4c6547db1f1385 recordList, Func<ST_34444d0742578c128ebc8b2594439346Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_843bbe6b5508d5a1ce4c6547db1f1385(ST_34444d0742578c128ebc8b2594439346Structure[] array) {
  RL_843bbe6b5508d5a1ce4c6547db1f1385 result = new RL_843bbe6b5508d5a1ce4c6547db1f1385();
result.InnerFromArray(array);
    return result;
}

public static RL_843bbe6b5508d5a1ce4c6547db1f1385 ToList<T>(T[] array, Func <T, ST_34444d0742578c128ebc8b2594439346Structure> converter) {
  RL_843bbe6b5508d5a1ce4c6547db1f1385 result = new RL_843bbe6b5508d5a1ce4c6547db1f1385();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_843bbe6b5508d5a1ce4c6547db1f1385 FromRestList<T>(RestList<T> restList, Func <T, ST_34444d0742578c128ebc8b2594439346Structure> converter) {
  RL_843bbe6b5508d5a1ce4c6547db1f1385 result = new RL_843bbe6b5508d5a1ce4c6547db1f1385();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_843bbe6b5508d5a1ce4c6547db1f1385() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_34444d0742578c128ebc8b2594439346Structure> NewList() {
return new RL_843bbe6b5508d5a1ce4c6547db1f1385();
}


} // RL_843bbe6b5508d5a1ce4c6547db1f1385
}

