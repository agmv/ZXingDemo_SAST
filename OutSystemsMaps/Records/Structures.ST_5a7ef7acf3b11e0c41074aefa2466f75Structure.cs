namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Marker (NiCGoYbA+0qb4lPY4N633w)
///  <code>ST_5a7ef7acf3b11e0c41074aefa2466f75Structure</code> that represents <code>Marker</code
/// > <p>Description: Use the Marker parameter to set a location on the map. By default, the Marker
///  uses the google maps defaults marker but can by displayed custom images and you can change it usin
/// g the present parameters.  For more information, please visit
///  https://developers.google.com/maps/documentation/javascript/markers</p>
/// </summary>
// Name: Marker
public partial struct ST_5a7ef7acf3b11e0c41074aefa2466f75Structure : ITypedRecord<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure> {
internal static readonly GlobalObjectKey IdLocation = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*IWZYqiz1Z0KTnOROLPDvMw");
internal static readonly GlobalObjectKey IdIconURL = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*2ipvIJEeHEaId26a_or5kQ");
internal static readonly GlobalObjectKey IdAdvancedFormat = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nT3_H0fcbE+157mhxsS1rw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Location")]
public string ssLocation;

[System.Xml.Serialization.XmlElement("IconURL")]
public string ssIconURL;

[System.Xml.Serialization.XmlElement("AdvancedFormat")]
public string ssAdvancedFormat;


public BitArray OptimizedAttributes;

public ST_5a7ef7acf3b11e0c41074aefa2466f75Structure() {
OptimizedAttributes = null;
ssLocation = "42.3517926,-71.0467845";
ssIconURL = "";
ssAdvancedFormat = "";
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
ssLocation = r.ReadText(index++, "Marker.Location", "");
ssIconURL = r.ReadText(index++, "Marker.IconURL", "");
ssAdvancedFormat = r.ReadText(index++, "Marker.AdvancedFormat", "");
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
public void ReadIM(ST_5a7ef7acf3b11e0c41074aefa2466f75Structure r) {
this = r;
}


public static bool operator == (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure a, ST_5a7ef7acf3b11e0c41074aefa2466f75Structure b) {
if (a.ssLocation != b.ssLocation) return false;
if (a.ssIconURL != b.ssIconURL) return false;
if (a.ssAdvancedFormat != b.ssAdvancedFormat) return false;
return true;
}

public static bool operator != (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure a, ST_5a7ef7acf3b11e0c41074aefa2466f75Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure)) return false;
return (this == (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLocation.GetHashCode()
 ^ ssIconURL.GetHashCode()
 ^ ssAdvancedFormat.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5a7ef7acf3b11e0c41074aefa2466f75Structure Duplicate() {
ST_5a7ef7acf3b11e0c41074aefa2466f75Structure t;
t.ssLocation = this.ssLocation;
t.ssIconURL = this.ssIconURL;
t.ssAdvancedFormat = this.ssAdvancedFormat;
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
} else if (head == "advancedformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvancedFormat")) variable.Value = ssAdvancedFormat; else variable.Optimized = true;
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
if (key == IdAdvancedFormat) {
return ssAdvancedFormat;
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
if (attributeKey == IdAdvancedFormat.Key.AsGuid) {
return ssAdvancedFormat;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLocation = (string) other.AttributeGet(IdLocation);
ssIconURL = (string) other.AttributeGet(IdIconURL);
ssAdvancedFormat = (string) other.AttributeGet(IdAdvancedFormat);
}
} // ST_5a7ef7acf3b11e0c41074aefa2466f75Structure
/// <summary>
/// RecordList type <code>MarkerList</code> that represents a record list of <code>Marker</code>
/// </summary>
public partial class RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 : GenericRecordList<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_5a7ef7acf3b11e0c41074aefa2466f75Structure GetElementDefaultValue() {
return new ST_5a7ef7acf3b11e0c41074aefa2466f75Structure();
}

public T[] ToArray<T>(Func<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 recordList, Func<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2(ST_5a7ef7acf3b11e0c41074aefa2466f75Structure[] array) {
  RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 result = new RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2();
result.InnerFromArray(array);
    return result;
}

public static RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 ToList<T>(T[] array, Func <T, ST_5a7ef7acf3b11e0c41074aefa2466f75Structure> converter) {
  RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 result = new RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 FromRestList<T>(RestList<T> restList, Func <T, ST_5a7ef7acf3b11e0c41074aefa2466f75Structure> converter) {
  RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2 result = new RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure> NewList() {
return new RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2();
}


} // RL_78b384ffc67b2b6c5ffe17e2f3a3c3b2
}

