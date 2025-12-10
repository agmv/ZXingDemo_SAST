namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] StaticMarker (HWKV7+6mrUKd5B5htFPGKw)
///  <code>ST_832344699c82a4f799a423f89bbe7297Structure</code> that represents <code>StaticMarker</code
/// > <p>Description: Use the StaticMarker parameter to set a location on the map. By default, the
///  Marker uses the google maps defaults marker but can by displayed custom images and you can chang
/// e it using the present parameters.  For more information, please visit
///  https://developers.google.com/maps/documentation/javascript/markers</p>
/// </summary>
// Name: StaticMarker
public partial struct ST_832344699c82a4f799a423f89bbe7297Structure : ITypedRecord<ST_832344699c82a4f799a423f89bbe7297Structure> {
internal static readonly GlobalObjectKey IdLocation = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*DSI2uejcjkGPfd_2WGkeew");
internal static readonly GlobalObjectKey IdIconURL = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*UdJKD3xrSkiFPd8+iHyWBA");
internal static readonly GlobalObjectKey IdDEPRECATED_AdvancedFormat = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*EfZpKbAe5kCWuATv6NUGIw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Location")]
public string ssLocation;

[System.Xml.Serialization.XmlElement("IconURL")]
public string ssIconURL;

[System.Xml.Serialization.XmlElement("DEPRECATED_AdvancedFormat")]
public string ssDEPRECATED_AdvancedFormat;


public BitArray OptimizedAttributes;

public ST_832344699c82a4f799a423f89bbe7297Structure() {
OptimizedAttributes = null;
ssLocation = "42.3517926,-71.0467845";
ssIconURL = "";
ssDEPRECATED_AdvancedFormat = "";
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
ssLocation = r.ReadText(index++, "StaticMarker.Location", "");
ssIconURL = r.ReadText(index++, "StaticMarker.IconURL", "");
ssDEPRECATED_AdvancedFormat = r.ReadText(index++, "StaticMarker.DEPRECATED_AdvancedFormat", "");
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
public void ReadIM(ST_832344699c82a4f799a423f89bbe7297Structure r) {
this = r;
}


public static bool operator == (ST_832344699c82a4f799a423f89bbe7297Structure a, ST_832344699c82a4f799a423f89bbe7297Structure b) {
if (a.ssLocation != b.ssLocation) return false;
if (a.ssIconURL != b.ssIconURL) return false;
if (a.ssDEPRECATED_AdvancedFormat != b.ssDEPRECATED_AdvancedFormat) return false;
return true;
}

public static bool operator != (ST_832344699c82a4f799a423f89bbe7297Structure a, ST_832344699c82a4f799a423f89bbe7297Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_832344699c82a4f799a423f89bbe7297Structure)) return false;
return (this == (ST_832344699c82a4f799a423f89bbe7297Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLocation.GetHashCode()
 ^ ssIconURL.GetHashCode()
 ^ ssDEPRECATED_AdvancedFormat.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_832344699c82a4f799a423f89bbe7297Structure Duplicate() {
ST_832344699c82a4f799a423f89bbe7297Structure t;
t.ssLocation = this.ssLocation;
t.ssIconURL = this.ssIconURL;
t.ssDEPRECATED_AdvancedFormat = this.ssDEPRECATED_AdvancedFormat;
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
if (head == "location") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Location")) variable.Value = ssLocation; else variable.Optimized = true;
} else if (head == "iconurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IconURL")) variable.Value = ssIconURL; else variable.Optimized = true;
} else if (head == "deprecated_advancedformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DEPRECATED_AdvancedFormat")) variable.Value = ssDEPRECATED_AdvancedFormat; else variable.Optimized = true;
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
if (key == IdLocation) {
return ssLocation;
}
if (key == IdIconURL) {
return ssIconURL;
}
if (key == IdDEPRECATED_AdvancedFormat) {
return ssDEPRECATED_AdvancedFormat;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLocation.Key.AsGuid) {
return ssLocation;
}
if (attributeKey == IdIconURL.Key.AsGuid) {
return ssIconURL;
}
if (attributeKey == IdDEPRECATED_AdvancedFormat.Key.AsGuid) {
return ssDEPRECATED_AdvancedFormat;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLocation = (string) other.AttributeGet(IdLocation);
ssIconURL = (string) other.AttributeGet(IdIconURL);
ssDEPRECATED_AdvancedFormat = (string) other.AttributeGet(IdDEPRECATED_AdvancedFormat);
}
} // ST_832344699c82a4f799a423f89bbe7297Structure
/// <summary>
/// RecordList type <code>StaticMarkerList</code> that represents a record list of
///  <code>StaticMarker</code>
/// </summary>
public partial class RL_7c4605673564471d88af1f24f7fd0a58 : GenericRecordList<ST_832344699c82a4f799a423f89bbe7297Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_832344699c82a4f799a423f89bbe7297Structure GetElementDefaultValue() {
return new ST_832344699c82a4f799a423f89bbe7297Structure();
}

public T[] ToArray<T>(Func<ST_832344699c82a4f799a423f89bbe7297Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7c4605673564471d88af1f24f7fd0a58 recordList, Func<ST_832344699c82a4f799a423f89bbe7297Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7c4605673564471d88af1f24f7fd0a58(ST_832344699c82a4f799a423f89bbe7297Structure[] array) {
  RL_7c4605673564471d88af1f24f7fd0a58 result = new RL_7c4605673564471d88af1f24f7fd0a58();
result.InnerFromArray(array);
    return result;
}

public static RL_7c4605673564471d88af1f24f7fd0a58 ToList<T>(T[] array, Func <T, ST_832344699c82a4f799a423f89bbe7297Structure> converter) {
  RL_7c4605673564471d88af1f24f7fd0a58 result = new RL_7c4605673564471d88af1f24f7fd0a58();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7c4605673564471d88af1f24f7fd0a58 FromRestList<T>(RestList<T> restList, Func <T, ST_832344699c82a4f799a423f89bbe7297Structure> converter) {
  RL_7c4605673564471d88af1f24f7fd0a58 result = new RL_7c4605673564471d88af1f24f7fd0a58();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7c4605673564471d88af1f24f7fd0a58() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_832344699c82a4f799a423f89bbe7297Structure> NewList() {
return new RL_7c4605673564471d88af1f24f7fd0a58();
}


} // RL_7c4605673564471d88af1f24f7fd0a58
}

