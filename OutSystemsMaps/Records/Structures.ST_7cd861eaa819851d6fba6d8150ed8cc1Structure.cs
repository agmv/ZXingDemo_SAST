namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalSearchPlacesConfigs (yWoLwBfCakyAdoDj4wGuwA)
///  <code>ST_7cd861eaa819851d6fba6d8150ed8cc1Structure</code> that represent
/// s <code>OptionalSearchPlacesConfigs</code> <p>Description: Set additional parameters to customize
///  search behavior and functionality.</p>
/// </summary>
// Name: OptionalSearchPlacesConfigs
public partial struct ST_7cd861eaa819851d6fba6d8150ed8cc1Structure : ITypedRecord<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> {
internal static readonly GlobalObjectKey IdCountries = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*HjYwVtLcykupETmD4LULew");
internal static readonly GlobalObjectKey IdSearchArea = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*xR3U6JM1GUGq+RMCDa6hWw");
internal static readonly GlobalObjectKey IdSearchType = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*WKFcUGIOKE+11SjsQes2BA");
internal static readonly GlobalObjectKey IdLocalization = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*WA04pYJCQkagyhnvuq0hmg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Countries")]
public BasicTypeList<string> ssCountries;

[System.Xml.Serialization.XmlElement("SearchArea")]
public ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure ssSearchArea;

[System.Xml.Serialization.XmlElement("SearchType")]
public string ssSearchType;

[System.Xml.Serialization.XmlElement("Localization")]
public ST_59c2aa6a35b14343cc78f655810f9ce8Structure ssLocalization;


public BitArray OptimizedAttributes;

public ST_7cd861eaa819851d6fba6d8150ed8cc1Structure() {
OptimizedAttributes = null;
ssCountries = new BasicTypeList<string>();
ssSearchArea = new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure();
ssSearchType = "";
ssLocalization = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSearchArea.OptimizedAttributes = value[0];
    ssLocalization.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSearchType = r.ReadEntityReferenceText(index++, "OptionalSearchPlacesConfigs.SearchType", "");
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
public void ReadIM(ST_7cd861eaa819851d6fba6d8150ed8cc1Structure r) {
this = r;
}


public static bool operator == (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure a, ST_7cd861eaa819851d6fba6d8150ed8cc1Structure b) {
if (a.ssCountries != b.ssCountries) return false;
if (a.ssSearchArea != b.ssSearchArea) return false;
if (a.ssSearchType != b.ssSearchType) return false;
if (a.ssLocalization != b.ssLocalization) return false;
return true;
}

public static bool operator != (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure a, ST_7cd861eaa819851d6fba6d8150ed8cc1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure)) return false;
return (this == (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCountries.GetHashCode()
 ^ ssSearchArea.GetHashCode()
 ^ ssSearchType.GetHashCode()
 ^ ssLocalization.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssCountries.RecursiveReset();
ssSearchArea.RecursiveReset();
ssLocalization.RecursiveReset();
}

public void InternalRecursiveSave() {
ssCountries.InternalRecursiveSave();
ssSearchArea.InternalRecursiveSave();
ssLocalization.InternalRecursiveSave();
}


public ST_7cd861eaa819851d6fba6d8150ed8cc1Structure Duplicate() {
ST_7cd861eaa819851d6fba6d8150ed8cc1Structure t;
t.ssCountries = (BasicTypeList<string>)this.ssCountries.Duplicate();
t.ssSearchArea = (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure)this.ssSearchArea.Duplicate();
t.ssSearchType = this.ssSearchType;
t.ssLocalization = (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)this.ssLocalization.Duplicate();
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
if (head == "countries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Countries")) variable.Value = ssCountries; else variable.Optimized = true;
variable.SetFieldName("countries");
} else if (head == "searcharea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchArea")) variable.Value = ssSearchArea; else variable.Optimized = true;
variable.SetFieldName("searcharea");
} else if (head == "searchtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchType")) variable.Value = ssSearchType; else variable.Optimized = true;
} else if (head == "localization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Localization")) variable.Value = ssLocalization; else variable.Optimized = true;
variable.SetFieldName("localization");
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
if (key == IdCountries) {
return ssCountries;
}
if (key == IdSearchArea) {
return ssSearchArea;
}
if (key == IdSearchType) {
return ssSearchType;
}
if (key == IdLocalization) {
return ssLocalization;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCountries.Key.AsGuid) {
return ssCountries;
}
if (attributeKey == IdSearchArea.Key.AsGuid) {
return ssSearchArea;
}
if (attributeKey == IdSearchType.Key.AsGuid) {
return ssSearchType;
}
if (attributeKey == IdLocalization.Key.AsGuid) {
return ssLocalization;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCountries = new BasicTypeList<string>();
ssCountries.FillFromOther((IOSList) other.AttributeGet(IdCountries));
ssSearchArea.FillFromOther((IRecord) other.AttributeGet(IdSearchArea));
ssSearchType = (string) other.AttributeGet(IdSearchType);
ssLocalization.FillFromOther((IRecord) other.AttributeGet(IdLocalization));
}
} // ST_7cd861eaa819851d6fba6d8150ed8cc1Structure
/// <summary>
/// RecordList type <code>OptionalSearchPlacesConfigsList</code> that represents a record list of
///  <code>OptionalSearchPlacesConfigs</code>
/// </summary>
public partial class RL_8da67595edc06c9fadd5ecd2611bc025 : GenericRecordList<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7cd861eaa819851d6fba6d8150ed8cc1Structure GetElementDefaultValue() {
return new ST_7cd861eaa819851d6fba6d8150ed8cc1Structure();
}

public T[] ToArray<T>(Func<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8da67595edc06c9fadd5ecd2611bc025 recordList, Func<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8da67595edc06c9fadd5ecd2611bc025(ST_7cd861eaa819851d6fba6d8150ed8cc1Structure[] array) {
  RL_8da67595edc06c9fadd5ecd2611bc025 result = new RL_8da67595edc06c9fadd5ecd2611bc025();
result.InnerFromArray(array);
    return result;
}

public static RL_8da67595edc06c9fadd5ecd2611bc025 ToList<T>(T[] array, Func <T, ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> converter) {
  RL_8da67595edc06c9fadd5ecd2611bc025 result = new RL_8da67595edc06c9fadd5ecd2611bc025();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8da67595edc06c9fadd5ecd2611bc025 FromRestList<T>(RestList<T> restList, Func <T, ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> converter) {
  RL_8da67595edc06c9fadd5ecd2611bc025 result = new RL_8da67595edc06c9fadd5ecd2611bc025();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8da67595edc06c9fadd5ecd2611bc025() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> NewList() {
return new RL_8da67595edc06c9fadd5ecd2611bc025();
}


} // RL_8da67595edc06c9fadd5ecd2611bc025
}

