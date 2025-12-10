namespace ssOutSystemsUI {
/// <summary>
/// [Structure] MonthPicker_InternalConfig (1gOu9kOxn0a4PTwSxG7I4Q)
///  <code>ST_6f97d9724e66f51b47133aa003a9e610Structure</code> that represent
/// s <code>MonthPicker_InternalConfig</code> <p>Description: Group of internal configurations for the
///  MonthPicker block. </p>
/// </summary>
// Name: MonthPicker_InternalConfig
public partial struct ST_6f97d9724e66f51b47133aa003a9e610Structure : ITypedRecord<ST_6f97d9724e66f51b47133aa003a9e610Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ANeVfvN0rUah0K1GqbX3eg");
internal static readonly GlobalObjectKey IdDateFormat = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*VUoENgqavkGkQVPr1YKcWQ");
internal static readonly GlobalObjectKey IdMinMonth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*vVlGSsuRyE+33_QmS9Fh7Q");
internal static readonly GlobalObjectKey IdInitialMonth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*sD7rqUYwV0Sgf6f8IrVlug");
internal static readonly GlobalObjectKey IdMaxMonth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*7wJktUOXdUeEwso3arcUEA");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*4lFjYw1WGEiWqU_H0jDxvg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("DateFormat")]
public string ssDateFormat;

[System.Xml.Serialization.XmlElement("MinMonth")]
public ST_5c08eaa15b890a2d617cabe547c34f0bStructure ssMinMonth;

[System.Xml.Serialization.XmlElement("InitialMonth")]
public ST_5c08eaa15b890a2d617cabe547c34f0bStructure ssInitialMonth;

[System.Xml.Serialization.XmlElement("MaxMonth")]
public ST_5c08eaa15b890a2d617cabe547c34f0bStructure ssMaxMonth;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_6f97d9724e66f51b47133aa003a9e610Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssDateFormat = "";
ssMinMonth = new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
ssInitialMonth = new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
ssMaxMonth = new ST_5c08eaa15b890a2d617cabe547c34f0bStructure();
ssExtendedClass = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssMinMonth.OptimizedAttributes = value[0];
    ssInitialMonth.OptimizedAttributes = value[1];
    ssMaxMonth.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssUniqueId = r.ReadText(index++, "MonthPicker_InternalConfig.UniqueId", "");
ssDateFormat = r.ReadText(index++, "MonthPicker_InternalConfig.DateFormat", "");
ssExtendedClass = r.ReadText(index++, "MonthPicker_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_6f97d9724e66f51b47133aa003a9e610Structure r) {
this = r;
}


public static bool operator == (ST_6f97d9724e66f51b47133aa003a9e610Structure a, ST_6f97d9724e66f51b47133aa003a9e610Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssDateFormat != b.ssDateFormat) return false;
if (a.ssMinMonth != b.ssMinMonth) return false;
if (a.ssInitialMonth != b.ssInitialMonth) return false;
if (a.ssMaxMonth != b.ssMaxMonth) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_6f97d9724e66f51b47133aa003a9e610Structure a, ST_6f97d9724e66f51b47133aa003a9e610Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6f97d9724e66f51b47133aa003a9e610Structure)) return false;
return (this == (ST_6f97d9724e66f51b47133aa003a9e610Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssDateFormat.GetHashCode()
 ^ ssMinMonth.GetHashCode()
 ^ ssInitialMonth.GetHashCode()
 ^ ssMaxMonth.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssMinMonth.RecursiveReset();
ssInitialMonth.RecursiveReset();
ssMaxMonth.RecursiveReset();
}

public void InternalRecursiveSave() {
ssMinMonth.InternalRecursiveSave();
ssInitialMonth.InternalRecursiveSave();
ssMaxMonth.InternalRecursiveSave();
}


public ST_6f97d9724e66f51b47133aa003a9e610Structure Duplicate() {
ST_6f97d9724e66f51b47133aa003a9e610Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssDateFormat = this.ssDateFormat;
t.ssMinMonth = (ST_5c08eaa15b890a2d617cabe547c34f0bStructure)this.ssMinMonth.Duplicate();
t.ssInitialMonth = (ST_5c08eaa15b890a2d617cabe547c34f0bStructure)this.ssInitialMonth.Duplicate();
t.ssMaxMonth = (ST_5c08eaa15b890a2d617cabe547c34f0bStructure)this.ssMaxMonth.Duplicate();
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
} else if (head == "dateformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateFormat")) variable.Value = ssDateFormat; else variable.Optimized = true;
} else if (head == "minmonth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinMonth")) variable.Value = ssMinMonth; else variable.Optimized = true;
variable.SetFieldName("minmonth");
} else if (head == "initialmonth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialMonth")) variable.Value = ssInitialMonth; else variable.Optimized = true;
variable.SetFieldName("initialmonth");
} else if (head == "maxmonth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxMonth")) variable.Value = ssMaxMonth; else variable.Optimized = true;
variable.SetFieldName("maxmonth");
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
if (key == IdDateFormat) {
return ssDateFormat;
}
if (key == IdMinMonth) {
return ssMinMonth;
}
if (key == IdInitialMonth) {
return ssInitialMonth;
}
if (key == IdMaxMonth) {
return ssMaxMonth;
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
if (attributeKey == IdDateFormat.Key.AsGuid) {
return ssDateFormat;
}
if (attributeKey == IdMinMonth.Key.AsGuid) {
return ssMinMonth;
}
if (attributeKey == IdInitialMonth.Key.AsGuid) {
return ssInitialMonth;
}
if (attributeKey == IdMaxMonth.Key.AsGuid) {
return ssMaxMonth;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssDateFormat = (string) other.AttributeGet(IdDateFormat);
ssMinMonth.FillFromOther((IRecord) other.AttributeGet(IdMinMonth));
ssInitialMonth.FillFromOther((IRecord) other.AttributeGet(IdInitialMonth));
ssMaxMonth.FillFromOther((IRecord) other.AttributeGet(IdMaxMonth));
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_6f97d9724e66f51b47133aa003a9e610Structure
/// <summary>
/// RecordList type <code>MonthPicker_InternalConfigList</code> that represents a record list of
///  <code>MonthPicker_InternalConfig</code>
/// </summary>
public partial class RL_264e480af17fa239d591aa03fb53347c : GenericRecordList<ST_6f97d9724e66f51b47133aa003a9e610Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_6f97d9724e66f51b47133aa003a9e610Structure GetElementDefaultValue() {
return new ST_6f97d9724e66f51b47133aa003a9e610Structure();
}

public T[] ToArray<T>(Func<ST_6f97d9724e66f51b47133aa003a9e610Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_264e480af17fa239d591aa03fb53347c recordList, Func<ST_6f97d9724e66f51b47133aa003a9e610Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_264e480af17fa239d591aa03fb53347c(ST_6f97d9724e66f51b47133aa003a9e610Structure[] array) {
  RL_264e480af17fa239d591aa03fb53347c result = new RL_264e480af17fa239d591aa03fb53347c();
result.InnerFromArray(array);
    return result;
}

public static RL_264e480af17fa239d591aa03fb53347c ToList<T>(T[] array, Func <T, ST_6f97d9724e66f51b47133aa003a9e610Structure> converter) {
  RL_264e480af17fa239d591aa03fb53347c result = new RL_264e480af17fa239d591aa03fb53347c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_264e480af17fa239d591aa03fb53347c FromRestList<T>(RestList<T> restList, Func <T, ST_6f97d9724e66f51b47133aa003a9e610Structure> converter) {
  RL_264e480af17fa239d591aa03fb53347c result = new RL_264e480af17fa239d591aa03fb53347c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_264e480af17fa239d591aa03fb53347c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = null;
def[1] = null;
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6f97d9724e66f51b47133aa003a9e610Structure> NewList() {
return new RL_264e480af17fa239d591aa03fb53347c();
}


} // RL_264e480af17fa239d591aa03fb53347c
}

