namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DropdownSearch_InternalConfigs (K0Zp9IRCXkWyQMu_Z7QvCg)
///  <code>ST_936f99e69df60f5aa2563bbd38e49c98Structure</code> that represent
/// s <code>DropdownSearch_InternalConfigs</code> <p>Description: Group of internal configurations for
///  the DropdownSearch block. </p>
/// </summary>
// Name: DropdownSearch_InternalConfigs
public partial struct ST_936f99e69df60f5aa2563bbd38e49c98Structure : ITypedRecord<ST_936f99e69df60f5aa2563bbd38e49c98Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ISKyrfMUIUW9Yo55ivyb1w");
internal static readonly GlobalObjectKey IdOptionsList = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*gznLSIpBskW91b+rLg+F6w");
internal static readonly GlobalObjectKey IdStartingSelection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*nNnALoD0WU+fxEUlZMHJ5A");
internal static readonly GlobalObjectKey IdPrompt = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5xP0ABIh9EOxT1PPVoJLCg");
internal static readonly GlobalObjectKey IdAllowMultipleSelection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Zg3J9rb6hkSLWHh+Ge2HoQ");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ADAbHtMYkkChJhLjZhFdOQ");
internal static readonly GlobalObjectKey IdNoOptionsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*bTaqyh_2IE6zi0xVaPff6Q");
internal static readonly GlobalObjectKey IdNoResultsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KdQvELKwQUaZPv4LXYqvtA");
internal static readonly GlobalObjectKey IdSearchPrompt = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+yDwC6T4+UCworhmfqMXfQ");
internal static readonly GlobalObjectKey IdSanitizeDropdownValues = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*FS_qo_1fz0SikSArGLjilg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*WOI586+APkSwkyszBIlKqw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("OptionsList")]
public RL_c0f17d75c546075264f5d075e00ba65b ssOptionsList;

[System.Xml.Serialization.XmlElement("StartingSelection")]
public RL_c0f17d75c546075264f5d075e00ba65b ssStartingSelection;

[System.Xml.Serialization.XmlElement("Prompt")]
public string ssPrompt;

[System.Xml.Serialization.XmlElement("AllowMultipleSelection")]
public bool ssAllowMultipleSelection;

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

public ST_936f99e69df60f5aa2563bbd38e49c98Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssOptionsList = new RL_c0f17d75c546075264f5d075e00ba65b();
ssStartingSelection = new RL_c0f17d75c546075264f5d075e00ba65b();
ssPrompt = "Select an item";
ssAllowMultipleSelection = false;
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
ssUniqueId = r.ReadText(index++, "DropdownSearch_InternalConfigs.UniqueId", "");
ssPrompt = r.ReadText(index++, "DropdownSearch_InternalConfigs.Prompt", "");
ssAllowMultipleSelection = r.ReadBoolean(index++, "DropdownSearch_InternalConfigs.AllowMultipleSelection", false);
ssIsDisabled = r.ReadBoolean(index++, "DropdownSearch_InternalConfigs.IsDisabled", false);
ssNoOptionsText = r.ReadText(index++, "DropdownSearch_InternalConfigs.NoOptionsText", "");
ssNoResultsText = r.ReadText(index++, "DropdownSearch_InternalConfigs.NoResultsText", "");
ssSearchPrompt = r.ReadText(index++, "DropdownSearch_InternalConfigs.SearchPrompt", "");
ssSanitizeDropdownValues = r.ReadBoolean(index++, "DropdownSearch_InternalConfigs.SanitizeDropdownValues", false);
ssExtendedClass = r.ReadText(index++, "DropdownSearch_InternalConfigs.ExtendedClass", "");
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
public void ReadIM(ST_936f99e69df60f5aa2563bbd38e49c98Structure r) {
this = r;
}


public static bool operator == (ST_936f99e69df60f5aa2563bbd38e49c98Structure a, ST_936f99e69df60f5aa2563bbd38e49c98Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssOptionsList != b.ssOptionsList) return false;
if (a.ssStartingSelection != b.ssStartingSelection) return false;
if (a.ssPrompt != b.ssPrompt) return false;
if (a.ssAllowMultipleSelection != b.ssAllowMultipleSelection) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssNoOptionsText != b.ssNoOptionsText) return false;
if (a.ssNoResultsText != b.ssNoResultsText) return false;
if (a.ssSearchPrompt != b.ssSearchPrompt) return false;
if (a.ssSanitizeDropdownValues != b.ssSanitizeDropdownValues) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_936f99e69df60f5aa2563bbd38e49c98Structure a, ST_936f99e69df60f5aa2563bbd38e49c98Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_936f99e69df60f5aa2563bbd38e49c98Structure)) return false;
return (this == (ST_936f99e69df60f5aa2563bbd38e49c98Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssOptionsList.GetHashCode()
 ^ ssStartingSelection.GetHashCode()
 ^ ssPrompt.GetHashCode()
 ^ ssAllowMultipleSelection.GetHashCode()
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


public ST_936f99e69df60f5aa2563bbd38e49c98Structure Duplicate() {
ST_936f99e69df60f5aa2563bbd38e49c98Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssOptionsList = (RL_c0f17d75c546075264f5d075e00ba65b)this.ssOptionsList.Duplicate();
t.ssStartingSelection = (RL_c0f17d75c546075264f5d075e00ba65b)this.ssStartingSelection.Duplicate();
t.ssPrompt = this.ssPrompt;
t.ssAllowMultipleSelection = this.ssAllowMultipleSelection;
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
} else if (head == "allowmultipleselection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllowMultipleSelection")) variable.Value = ssAllowMultipleSelection; else variable.Optimized = true;
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
if (key == IdAllowMultipleSelection) {
return ssAllowMultipleSelection;
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
if (attributeKey == IdAllowMultipleSelection.Key.AsGuid) {
return ssAllowMultipleSelection;
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
ssAllowMultipleSelection = (bool) other.AttributeGet(IdAllowMultipleSelection);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssNoOptionsText = (string) other.AttributeGet(IdNoOptionsText);
ssNoResultsText = (string) other.AttributeGet(IdNoResultsText);
ssSearchPrompt = (string) other.AttributeGet(IdSearchPrompt);
ssSanitizeDropdownValues = (bool) other.AttributeGet(IdSanitizeDropdownValues);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_936f99e69df60f5aa2563bbd38e49c98Structure
/// <summary>
/// RecordList type <code>DropdownSearch_InternalConfigsList</code> that represents a record list of
///  <code>DropdownSearch_InternalConfigs</code>
/// </summary>
public partial class RL_fa557d462db5fd8b6c78f8146063f07b : GenericRecordList<ST_936f99e69df60f5aa2563bbd38e49c98Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_936f99e69df60f5aa2563bbd38e49c98Structure GetElementDefaultValue() {
return new ST_936f99e69df60f5aa2563bbd38e49c98Structure();
}

public T[] ToArray<T>(Func<ST_936f99e69df60f5aa2563bbd38e49c98Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fa557d462db5fd8b6c78f8146063f07b recordList, Func<ST_936f99e69df60f5aa2563bbd38e49c98Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fa557d462db5fd8b6c78f8146063f07b(ST_936f99e69df60f5aa2563bbd38e49c98Structure[] array) {
  RL_fa557d462db5fd8b6c78f8146063f07b result = new RL_fa557d462db5fd8b6c78f8146063f07b();
result.InnerFromArray(array);
    return result;
}

public static RL_fa557d462db5fd8b6c78f8146063f07b ToList<T>(T[] array, Func <T, ST_936f99e69df60f5aa2563bbd38e49c98Structure> converter) {
  RL_fa557d462db5fd8b6c78f8146063f07b result = new RL_fa557d462db5fd8b6c78f8146063f07b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fa557d462db5fd8b6c78f8146063f07b FromRestList<T>(RestList<T> restList, Func <T, ST_936f99e69df60f5aa2563bbd38e49c98Structure> converter) {
  RL_fa557d462db5fd8b6c78f8146063f07b result = new RL_fa557d462db5fd8b6c78f8146063f07b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fa557d462db5fd8b6c78f8146063f07b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_936f99e69df60f5aa2563bbd38e49c98Structure> NewList() {
return new RL_fa557d462db5fd8b6c78f8146063f07b();
}


} // RL_fa557d462db5fd8b6c78f8146063f07b
}

