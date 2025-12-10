namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DropdownTags_InternalConfigs (5zxmpe7gj0u+QUu7FWVNlg)
///  <code>ST_f2d4817754eec123207470e41d7a01d7Structure</code> that represent
/// s <code>DropdownTags_InternalConfigs</code> <p>Description: Group of internal configurations for
///  the DropdownTags block. </p>
/// </summary>
// Name: DropdownTags_InternalConfigs
public partial struct ST_f2d4817754eec123207470e41d7a01d7Structure : ITypedRecord<ST_f2d4817754eec123207470e41d7a01d7Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ikbN+dFvZkitJN8yPLX_vA");
internal static readonly GlobalObjectKey IdOptionsList = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*BHky81H9OUurBl3D1ekFhg");
internal static readonly GlobalObjectKey IdStartingSelection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*wQvyPVOp2UOIRxvJwzU3Fw");
internal static readonly GlobalObjectKey IdPrompt = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Yghdw1tXs0aI4xld_+sCYQ");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*3kJ8CoV+bEmQgjcYNLAKeg");
internal static readonly GlobalObjectKey IdNoOptionsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Ta8sK7yt2kqTFu8I1d6RzQ");
internal static readonly GlobalObjectKey IdNoResultsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*N+T4va7V80q61iK9BIt4lw");
internal static readonly GlobalObjectKey IdSearchPrompt = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ayhQ5qb28kK8QjLJKvgDFA");
internal static readonly GlobalObjectKey IdSanitizeDropdownValues = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*u5s1FXJ9v0+KvywFklOJ+Q");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*kgX5MG4zPU+HR3kLCy+tMQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("OptionsList")]
public RL_c0f17d75c546075264f5d075e00ba65b ssOptionsList;

[System.Xml.Serialization.XmlElement("StartingSelection")]
public RL_c0f17d75c546075264f5d075e00ba65b ssStartingSelection;

[System.Xml.Serialization.XmlElement("Prompt")]
public string ssPrompt;

[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;

[System.Xml.Serialization.XmlElement("NoOptionsText")]
public string ssNoOptionsText;

[System.Xml.Serialization.XmlElement("NoResultsText")]
public string ssNoResultsText;

[System.Xml.Serialization.XmlElement("SearchPrompt")]
public string ssSearchPrompt;

[System.Xml.Serialization.XmlElement("SanitizeDropdownValues")]
public bool ssSanitizeDropdownValues;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_f2d4817754eec123207470e41d7a01d7Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssOptionsList = new RL_c0f17d75c546075264f5d075e00ba65b();
ssStartingSelection = new RL_c0f17d75c546075264f5d075e00ba65b();
ssPrompt = "Select an item";
ssIsDisabled = false;
ssNoOptionsText = Convert.ToString(0);
ssNoResultsText = Convert.ToString(0);
ssSearchPrompt = "";
ssSanitizeDropdownValues = false;
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
ssUniqueId = r.ReadText(index++, "DropdownTags_InternalConfigs.UniqueId", "");
ssPrompt = r.ReadText(index++, "DropdownTags_InternalConfigs.Prompt", "");
ssIsDisabled = r.ReadBoolean(index++, "DropdownTags_InternalConfigs.IsDisabled", false);
ssNoOptionsText = r.ReadText(index++, "DropdownTags_InternalConfigs.NoOptionsText", "");
ssNoResultsText = r.ReadText(index++, "DropdownTags_InternalConfigs.NoResultsText", "");
ssSearchPrompt = r.ReadText(index++, "DropdownTags_InternalConfigs.SearchPrompt", "");
ssSanitizeDropdownValues = r.ReadBoolean(index++, "DropdownTags_InternalConfigs.SanitizeDropdownValues", false);
ssExtendedClass = r.ReadText(index++, "DropdownTags_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_f2d4817754eec123207470e41d7a01d7Structure r) {
this = r;
}


public static bool operator == (ST_f2d4817754eec123207470e41d7a01d7Structure a, ST_f2d4817754eec123207470e41d7a01d7Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssOptionsList != b.ssOptionsList) return false;
if (a.ssStartingSelection != b.ssStartingSelection) return false;
if (a.ssPrompt != b.ssPrompt) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssNoOptionsText != b.ssNoOptionsText) return false;
if (a.ssNoResultsText != b.ssNoResultsText) return false;
if (a.ssSearchPrompt != b.ssSearchPrompt) return false;
if (a.ssSanitizeDropdownValues != b.ssSanitizeDropdownValues) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_f2d4817754eec123207470e41d7a01d7Structure a, ST_f2d4817754eec123207470e41d7a01d7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f2d4817754eec123207470e41d7a01d7Structure)) return false;
return (this == (ST_f2d4817754eec123207470e41d7a01d7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssOptionsList.GetHashCode()
 ^ ssStartingSelection.GetHashCode()
 ^ ssPrompt.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
 ^ ssNoOptionsText.GetHashCode()
 ^ ssNoResultsText.GetHashCode()
 ^ ssSearchPrompt.GetHashCode()
 ^ ssSanitizeDropdownValues.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOptionsList.RecursiveReset();
ssStartingSelection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOptionsList.InternalRecursiveSave();
ssStartingSelection.InternalRecursiveSave();
}


public ST_f2d4817754eec123207470e41d7a01d7Structure Duplicate() {
ST_f2d4817754eec123207470e41d7a01d7Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssOptionsList = (RL_c0f17d75c546075264f5d075e00ba65b)this.ssOptionsList.Duplicate();
t.ssStartingSelection = (RL_c0f17d75c546075264f5d075e00ba65b)this.ssStartingSelection.Duplicate();
t.ssPrompt = this.ssPrompt;
t.ssIsDisabled = this.ssIsDisabled;
t.ssNoOptionsText = this.ssNoOptionsText;
t.ssNoResultsText = this.ssNoResultsText;
t.ssSearchPrompt = this.ssSearchPrompt;
t.ssSanitizeDropdownValues = this.ssSanitizeDropdownValues;
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
} else if (head == "optionslist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionsList")) variable.Value = ssOptionsList; else variable.Optimized = true;
variable.SetFieldName("optionslist");
} else if (head == "startingselection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartingSelection")) variable.Value = ssStartingSelection; else variable.Optimized = true;
variable.SetFieldName("startingselection");
} else if (head == "prompt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Prompt")) variable.Value = ssPrompt; else variable.Optimized = true;
} else if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
} else if (head == "nooptionstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoOptionsText")) variable.Value = ssNoOptionsText; else variable.Optimized = true;
} else if (head == "noresultstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoResultsText")) variable.Value = ssNoResultsText; else variable.Optimized = true;
} else if (head == "searchprompt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchPrompt")) variable.Value = ssSearchPrompt; else variable.Optimized = true;
} else if (head == "sanitizedropdownvalues") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SanitizeDropdownValues")) variable.Value = ssSanitizeDropdownValues; else variable.Optimized = true;
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
if (key == IdOptionsList) {
return ssOptionsList;
}
if (key == IdStartingSelection) {
return ssStartingSelection;
}
if (key == IdPrompt) {
return ssPrompt;
}
if (key == IdIsDisabled) {
return ssIsDisabled;
}
if (key == IdNoOptionsText) {
return ssNoOptionsText;
}
if (key == IdNoResultsText) {
return ssNoResultsText;
}
if (key == IdSearchPrompt) {
return ssSearchPrompt;
}
if (key == IdSanitizeDropdownValues) {
return ssSanitizeDropdownValues;
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
if (attributeKey == IdOptionsList.Key.AsGuid) {
return ssOptionsList;
}
if (attributeKey == IdStartingSelection.Key.AsGuid) {
return ssStartingSelection;
}
if (attributeKey == IdPrompt.Key.AsGuid) {
return ssPrompt;
}
if (attributeKey == IdIsDisabled.Key.AsGuid) {
return ssIsDisabled;
}
if (attributeKey == IdNoOptionsText.Key.AsGuid) {
return ssNoOptionsText;
}
if (attributeKey == IdNoResultsText.Key.AsGuid) {
return ssNoResultsText;
}
if (attributeKey == IdSearchPrompt.Key.AsGuid) {
return ssSearchPrompt;
}
if (attributeKey == IdSanitizeDropdownValues.Key.AsGuid) {
return ssSanitizeDropdownValues;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssOptionsList = new RL_c0f17d75c546075264f5d075e00ba65b();
ssOptionsList.FillFromOther((IOSList) other.AttributeGet(IdOptionsList));
ssStartingSelection = new RL_c0f17d75c546075264f5d075e00ba65b();
ssStartingSelection.FillFromOther((IOSList) other.AttributeGet(IdStartingSelection));
ssPrompt = (string) other.AttributeGet(IdPrompt);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssNoOptionsText = (string) other.AttributeGet(IdNoOptionsText);
ssNoResultsText = (string) other.AttributeGet(IdNoResultsText);
ssSearchPrompt = (string) other.AttributeGet(IdSearchPrompt);
ssSanitizeDropdownValues = (bool) other.AttributeGet(IdSanitizeDropdownValues);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_f2d4817754eec123207470e41d7a01d7Structure
/// <summary>
/// RecordList type <code>DropdownTags_InternalConfigsList</code> that represents a record list of
///  <code>DropdownTags_InternalConfigs</code>
/// </summary>
public partial class RL_da293bf48581f98e964af95ac114b752 : GenericRecordList<ST_f2d4817754eec123207470e41d7a01d7Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_f2d4817754eec123207470e41d7a01d7Structure GetElementDefaultValue() {
return new ST_f2d4817754eec123207470e41d7a01d7Structure();
}

public T[] ToArray<T>(Func<ST_f2d4817754eec123207470e41d7a01d7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da293bf48581f98e964af95ac114b752 recordList, Func<ST_f2d4817754eec123207470e41d7a01d7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da293bf48581f98e964af95ac114b752(ST_f2d4817754eec123207470e41d7a01d7Structure[] array) {
  RL_da293bf48581f98e964af95ac114b752 result = new RL_da293bf48581f98e964af95ac114b752();
result.InnerFromArray(array);
    return result;
}

public static RL_da293bf48581f98e964af95ac114b752 ToList<T>(T[] array, Func <T, ST_f2d4817754eec123207470e41d7a01d7Structure> converter) {
  RL_da293bf48581f98e964af95ac114b752 result = new RL_da293bf48581f98e964af95ac114b752();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da293bf48581f98e964af95ac114b752 FromRestList<T>(RestList<T> restList, Func <T, ST_f2d4817754eec123207470e41d7a01d7Structure> converter) {
  RL_da293bf48581f98e964af95ac114b752 result = new RL_da293bf48581f98e964af95ac114b752();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da293bf48581f98e964af95ac114b752() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f2d4817754eec123207470e41d7a01d7Structure> NewList() {
return new RL_da293bf48581f98e964af95ac114b752();
}


} // RL_da293bf48581f98e964af95ac114b752
}

