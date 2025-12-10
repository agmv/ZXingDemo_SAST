namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_searchPlaces_configs (9CYjlVBqN0SqfZGSO3kV_g)
///  <code>ST_d4721898ae8c007cd938074f575e2979Structure</code> that represent
/// s <code>Internal_to_provider_searchPlaces_configs</code> <p>Description: Structure to handle
///  internal configurations associated with search places.</p>
/// </summary>
// Name: Internal_to_provider_searchPlaces_configs
public partial struct ST_d4721898ae8c007cd938074f575e2979Structure : ITypedRecord<ST_d4721898ae8c007cd938074f575e2979Structure> {
internal static readonly GlobalObjectKey IdapiKey = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*CAeNrWQXK0+shfABAuq9aQ");
internal static readonly GlobalObjectKey Idcountries = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*VDGtjvpejESE1YxUbpC1UA");
internal static readonly GlobalObjectKey IdsearchArea = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*2VkN_IaeiUK4ctqFRuY5kA");
internal static readonly GlobalObjectKey IdsearchType = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GyAOR+vf302UtVcm+GIDCw");
internal static readonly GlobalObjectKey Idlocalization = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*y0+DuWyc5kKiVsJNfl9fGQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("apiKey")]
public string ssapiKey;

[System.Xml.Serialization.XmlElement("countries")]
public BasicTypeList<string> sscountries;

[System.Xml.Serialization.XmlElement("searchArea")]
public ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure sssearchArea;

[System.Xml.Serialization.XmlElement("searchType")]
public string sssearchType;

[System.Xml.Serialization.XmlElement("localization")]
public ST_59c2aa6a35b14343cc78f655810f9ce8Structure sslocalization;


public BitArray OptimizedAttributes;

public ST_d4721898ae8c007cd938074f575e2979Structure() {
OptimizedAttributes = null;
ssapiKey = "";
sscountries = new BasicTypeList<string>();
sssearchArea = new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure();
sssearchType = "";
sslocalization = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
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
    sssearchArea.OptimizedAttributes = value[0];
    sslocalization.OptimizedAttributes = value[1];
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
ssapiKey = r.ReadText(index++, "Internal_to_provider_searchPlaces_configs.apiKey", "");
sssearchType = r.ReadEntityReferenceText(index++, "Internal_to_provider_searchPlaces_configs.searchType", "");
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
public void ReadIM(ST_d4721898ae8c007cd938074f575e2979Structure r) {
this = r;
}


public static bool operator == (ST_d4721898ae8c007cd938074f575e2979Structure a, ST_d4721898ae8c007cd938074f575e2979Structure b) {
if (a.ssapiKey != b.ssapiKey) return false;
if (a.sscountries != b.sscountries) return false;
if (a.sssearchArea != b.sssearchArea) return false;
if (a.sssearchType != b.sssearchType) return false;
if (a.sslocalization != b.sslocalization) return false;
return true;
}

public static bool operator != (ST_d4721898ae8c007cd938074f575e2979Structure a, ST_d4721898ae8c007cd938074f575e2979Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d4721898ae8c007cd938074f575e2979Structure)) return false;
return (this == (ST_d4721898ae8c007cd938074f575e2979Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssapiKey.GetHashCode()
 ^ sscountries.GetHashCode()
 ^ sssearchArea.GetHashCode()
 ^ sssearchType.GetHashCode()
 ^ sslocalization.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
sscountries.RecursiveReset();
sssearchArea.RecursiveReset();
sslocalization.RecursiveReset();
}

public void InternalRecursiveSave() {
sscountries.InternalRecursiveSave();
sssearchArea.InternalRecursiveSave();
sslocalization.InternalRecursiveSave();
}


public ST_d4721898ae8c007cd938074f575e2979Structure Duplicate() {
ST_d4721898ae8c007cd938074f575e2979Structure t;
t.ssapiKey = this.ssapiKey;
t.sscountries = (BasicTypeList<string>)this.sscountries.Duplicate();
t.sssearchArea = (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure)this.sssearchArea.Duplicate();
t.sssearchType = this.sssearchType;
t.sslocalization = (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)this.sslocalization.Duplicate();
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
if (head == "apikey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".apiKey")) variable.Value = ssapiKey; else variable.Optimized = true;
} else if (head == "countries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".countries")) variable.Value = sscountries; else variable.Optimized = true;
variable.SetFieldName("countries");
} else if (head == "searcharea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".searchArea")) variable.Value = sssearchArea; else variable.Optimized = true;
variable.SetFieldName("searcharea");
} else if (head == "searchtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".searchType")) variable.Value = sssearchType; else variable.Optimized = true;
} else if (head == "localization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".localization")) variable.Value = sslocalization; else variable.Optimized = true;
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
if (key == IdapiKey) {
return ssapiKey;
}
if (key == Idcountries) {
return sscountries;
}
if (key == IdsearchArea) {
return sssearchArea;
}
if (key == IdsearchType) {
return sssearchType;
}
if (key == Idlocalization) {
return sslocalization;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdapiKey.Key.AsGuid) {
return ssapiKey;
}
if (attributeKey == Idcountries.Key.AsGuid) {
return sscountries;
}
if (attributeKey == IdsearchArea.Key.AsGuid) {
return sssearchArea;
}
if (attributeKey == IdsearchType.Key.AsGuid) {
return sssearchType;
}
if (attributeKey == Idlocalization.Key.AsGuid) {
return sslocalization;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssapiKey = (string) other.AttributeGet(IdapiKey);
sscountries = new BasicTypeList<string>();
sscountries.FillFromOther((IOSList) other.AttributeGet(Idcountries));
sssearchArea.FillFromOther((IRecord) other.AttributeGet(IdsearchArea));
sssearchType = (string) other.AttributeGet(IdsearchType);
sslocalization.FillFromOther((IRecord) other.AttributeGet(Idlocalization));
}
} // ST_d4721898ae8c007cd938074f575e2979Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_searchPlaces_configsList</code> that represents a record
///  list of <code>Internal_to_provider_searchPlaces_configs</code>
/// </summary>
public partial class RL_e2de29528fcc4f4e1167813e7872d86f : GenericRecordList<ST_d4721898ae8c007cd938074f575e2979Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_d4721898ae8c007cd938074f575e2979Structure GetElementDefaultValue() {
return new ST_d4721898ae8c007cd938074f575e2979Structure();
}

public T[] ToArray<T>(Func<ST_d4721898ae8c007cd938074f575e2979Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2de29528fcc4f4e1167813e7872d86f recordList, Func<ST_d4721898ae8c007cd938074f575e2979Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2de29528fcc4f4e1167813e7872d86f(ST_d4721898ae8c007cd938074f575e2979Structure[] array) {
  RL_e2de29528fcc4f4e1167813e7872d86f result = new RL_e2de29528fcc4f4e1167813e7872d86f();
result.InnerFromArray(array);
    return result;
}

public static RL_e2de29528fcc4f4e1167813e7872d86f ToList<T>(T[] array, Func <T, ST_d4721898ae8c007cd938074f575e2979Structure> converter) {
  RL_e2de29528fcc4f4e1167813e7872d86f result = new RL_e2de29528fcc4f4e1167813e7872d86f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2de29528fcc4f4e1167813e7872d86f FromRestList<T>(RestList<T> restList, Func <T, ST_d4721898ae8c007cd938074f575e2979Structure> converter) {
  RL_e2de29528fcc4f4e1167813e7872d86f result = new RL_e2de29528fcc4f4e1167813e7872d86f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2de29528fcc4f4e1167813e7872d86f() : base() {
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
protected override OSList<ST_d4721898ae8c007cd938074f575e2979Structure> NewList() {
return new RL_e2de29528fcc4f4e1167813e7872d86f();
}


} // RL_e2de29528fcc4f4e1167813e7872d86f
}

