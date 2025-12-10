namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_configs (7PDFwTPL0EClIRq70EwWpA)
///  <code>ST_5baae74ed57e3bb61180aff1dadec4e1Structure</code> that represent
/// s <code>Internal_to_provider_configs</code> <p>Description: Structure to handle internal
///  configurations associated with the Map's provider.</p>
/// </summary>
// Name: Internal_to_provider_configs
public partial struct ST_5baae74ed57e3bb61180aff1dadec4e1Structure : ITypedRecord<ST_5baae74ed57e3bb61180aff1dadec4e1Structure> {
internal static readonly GlobalObjectKey IdadvancedFormat = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*D9KD_WrKOUGe7kLQyxZZnA");
internal static readonly GlobalObjectKey IdapiKey = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*RGwEL4jUXEqgjWOKz0w+fg");
internal static readonly GlobalObjectKey IdautoZoomOnShapes = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*0cnjZKlvfEaBgQIa4IDYwA");
internal static readonly GlobalObjectKey Idcenter = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*2+vn645FkEmAya3QGixFsg");
internal static readonly GlobalObjectKey Idheight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*eU+NF59RrEGAoTINc8Bcng");
internal static readonly GlobalObjectKey Idoffset = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*PpHQvXUD9UGB42nrSq06vg");
internal static readonly GlobalObjectKey IdshowTraffic = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*n9Rqqa6rH0uns8mADJFcBg");
internal static readonly GlobalObjectKey IdstaticMap = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*bJrJMal_+E24HyyxMVthlA");
internal static readonly GlobalObjectKey Idstyle = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*QD0W87yKqUWlENDxflvVEA");
internal static readonly GlobalObjectKey Idtype = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*kRjzdZqU9kKLpVagwKedWQ");
internal static readonly GlobalObjectKey Idzoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*4KRjqQxgU0uzKNUGXkBupA");
internal static readonly GlobalObjectKey IdmarkerClusterer = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*9i+7DgbuUkuWX98esrh56Q");
internal static readonly GlobalObjectKey IdrespectUserZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*73JE2AJDdUWAx93pnxJU_Q");
internal static readonly GlobalObjectKey Idlocalization = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*DdpO1j69HkCHeIjd8YX6HA");
internal static readonly GlobalObjectKey IduseAdvancedMarkers = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*798452mCCU2fyHfP+cUPQQ");
internal static readonly GlobalObjectKey IdmapStyleId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*H99YL9IyUUGh+QK2GUHa1A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("advancedFormat")]
public string ssadvancedFormat;

[System.Xml.Serialization.XmlElement("apiKey")]
public string ssapiKey;

[System.Xml.Serialization.XmlElement("autoZoomOnShapes")]
public bool ssautoZoomOnShapes;

[System.Xml.Serialization.XmlElement("center")]
public string sscenter;

[System.Xml.Serialization.XmlElement("height")]
public string ssheight;

[System.Xml.Serialization.XmlElement("offset")]
public ST_be62cc31fbe4705834275960beeb55e2Structure ssoffset;

[System.Xml.Serialization.XmlElement("showTraffic")]
public bool ssshowTraffic;

[System.Xml.Serialization.XmlElement("staticMap")]
public bool ssstaticMap;

[System.Xml.Serialization.XmlElement("style")]
public int ssstyle;

[System.Xml.Serialization.XmlElement("type")]
public string sstype;

[System.Xml.Serialization.XmlElement("zoom")]
public int sszoom;

[System.Xml.Serialization.XmlElement("markerClusterer")]
public ST_9f8ac95fe4e47e327de12de1b56bed45Structure ssmarkerClusterer;

[System.Xml.Serialization.XmlElement("respectUserZoom")]
public bool ssrespectUserZoom;

[System.Xml.Serialization.XmlElement("localization")]
public ST_59c2aa6a35b14343cc78f655810f9ce8Structure sslocalization;

[System.Xml.Serialization.XmlElement("useAdvancedMarkers")]
public bool ssuseAdvancedMarkers;

[System.Xml.Serialization.XmlElement("mapStyleId")]
public string ssmapStyleId;


public BitArray OptimizedAttributes;

public ST_5baae74ed57e3bb61180aff1dadec4e1Structure() {
OptimizedAttributes = null;
ssadvancedFormat = "";
ssapiKey = "";
ssautoZoomOnShapes = false;
sscenter = "";
ssheight = "";
ssoffset = new ST_be62cc31fbe4705834275960beeb55e2Structure();
ssshowTraffic = false;
ssstaticMap = false;
ssstyle = 0;
sstype = "";
sszoom = 0;
ssmarkerClusterer = new ST_9f8ac95fe4e47e327de12de1b56bed45Structure();
ssrespectUserZoom = false;
sslocalization = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
ssuseAdvancedMarkers = false;
ssmapStyleId = "";
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
    ssoffset.OptimizedAttributes = value[0];
    ssmarkerClusterer.OptimizedAttributes = value[1];
    sslocalization.OptimizedAttributes = value[2];
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
ssadvancedFormat = r.ReadText(index++, "Internal_to_provider_configs.advancedFormat", "");
ssapiKey = r.ReadText(index++, "Internal_to_provider_configs.apiKey", "");
ssautoZoomOnShapes = r.ReadBoolean(index++, "Internal_to_provider_configs.autoZoomOnShapes", false);
sscenter = r.ReadText(index++, "Internal_to_provider_configs.center", "");
ssheight = r.ReadText(index++, "Internal_to_provider_configs.height", "");
ssshowTraffic = r.ReadBoolean(index++, "Internal_to_provider_configs.showTraffic", false);
ssstaticMap = r.ReadBoolean(index++, "Internal_to_provider_configs.staticMap", false);
ssstyle = r.ReadEntityReference(index++, "Internal_to_provider_configs.style", 0);
sstype = r.ReadEntityReferenceText(index++, "Internal_to_provider_configs.type", "");
sszoom = r.ReadEntityReference(index++, "Internal_to_provider_configs.zoom", 0);
ssrespectUserZoom = r.ReadBoolean(index++, "Internal_to_provider_configs.respectUserZoom", false);
ssuseAdvancedMarkers = r.ReadBoolean(index++, "Internal_to_provider_configs.useAdvancedMarkers", false);
ssmapStyleId = r.ReadText(index++, "Internal_to_provider_configs.mapStyleId", "");
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
public void ReadIM(ST_5baae74ed57e3bb61180aff1dadec4e1Structure r) {
this = r;
}


public static bool operator == (ST_5baae74ed57e3bb61180aff1dadec4e1Structure a, ST_5baae74ed57e3bb61180aff1dadec4e1Structure b) {
if (a.ssadvancedFormat != b.ssadvancedFormat) return false;
if (a.ssapiKey != b.ssapiKey) return false;
if (a.ssautoZoomOnShapes != b.ssautoZoomOnShapes) return false;
if (a.sscenter != b.sscenter) return false;
if (a.ssheight != b.ssheight) return false;
if (a.ssoffset != b.ssoffset) return false;
if (a.ssshowTraffic != b.ssshowTraffic) return false;
if (a.ssstaticMap != b.ssstaticMap) return false;
if (a.ssstyle != b.ssstyle) return false;
if (a.sstype != b.sstype) return false;
if (a.sszoom != b.sszoom) return false;
if (a.ssmarkerClusterer != b.ssmarkerClusterer) return false;
if (a.ssrespectUserZoom != b.ssrespectUserZoom) return false;
if (a.sslocalization != b.sslocalization) return false;
if (a.ssuseAdvancedMarkers != b.ssuseAdvancedMarkers) return false;
if (a.ssmapStyleId != b.ssmapStyleId) return false;
return true;
}

public static bool operator != (ST_5baae74ed57e3bb61180aff1dadec4e1Structure a, ST_5baae74ed57e3bb61180aff1dadec4e1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5baae74ed57e3bb61180aff1dadec4e1Structure)) return false;
return (this == (ST_5baae74ed57e3bb61180aff1dadec4e1Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssadvancedFormat.GetHashCode()
 ^ ssapiKey.GetHashCode()
 ^ ssautoZoomOnShapes.GetHashCode()
 ^ sscenter.GetHashCode()
 ^ ssheight.GetHashCode()
 ^ ssoffset.GetHashCode()
 ^ ssshowTraffic.GetHashCode()
 ^ ssstaticMap.GetHashCode()
 ^ ssstyle.GetHashCode()
 ^ sstype.GetHashCode()
 ^ sszoom.GetHashCode()
 ^ ssmarkerClusterer.GetHashCode()
 ^ ssrespectUserZoom.GetHashCode()
 ^ sslocalization.GetHashCode()
 ^ ssuseAdvancedMarkers.GetHashCode()
 ^ ssmapStyleId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssoffset.RecursiveReset();
ssmarkerClusterer.RecursiveReset();
sslocalization.RecursiveReset();
}

public void InternalRecursiveSave() {
ssoffset.InternalRecursiveSave();
ssmarkerClusterer.InternalRecursiveSave();
sslocalization.InternalRecursiveSave();
}


public ST_5baae74ed57e3bb61180aff1dadec4e1Structure Duplicate() {
ST_5baae74ed57e3bb61180aff1dadec4e1Structure t;
t.ssadvancedFormat = this.ssadvancedFormat;
t.ssapiKey = this.ssapiKey;
t.ssautoZoomOnShapes = this.ssautoZoomOnShapes;
t.sscenter = this.sscenter;
t.ssheight = this.ssheight;
t.ssoffset = (ST_be62cc31fbe4705834275960beeb55e2Structure)this.ssoffset.Duplicate();
t.ssshowTraffic = this.ssshowTraffic;
t.ssstaticMap = this.ssstaticMap;
t.ssstyle = this.ssstyle;
t.sstype = this.sstype;
t.sszoom = this.sszoom;
t.ssmarkerClusterer = (ST_9f8ac95fe4e47e327de12de1b56bed45Structure)this.ssmarkerClusterer.Duplicate();
t.ssrespectUserZoom = this.ssrespectUserZoom;
t.sslocalization = (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)this.sslocalization.Duplicate();
t.ssuseAdvancedMarkers = this.ssuseAdvancedMarkers;
t.ssmapStyleId = this.ssmapStyleId;
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
if (head == "advancedformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".advancedFormat")) variable.Value = ssadvancedFormat; else variable.Optimized = true;
} else if (head == "apikey") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".apiKey")) variable.Value = ssapiKey; else variable.Optimized = true;
} else if (head == "autozoomonshapes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".autoZoomOnShapes")) variable.Value = ssautoZoomOnShapes; else variable.Optimized = true;
} else if (head == "center") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".center")) variable.Value = sscenter; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".height")) variable.Value = ssheight; else variable.Optimized = true;
} else if (head == "offset") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".offset")) variable.Value = ssoffset; else variable.Optimized = true;
variable.SetFieldName("offset");
} else if (head == "showtraffic") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".showTraffic")) variable.Value = ssshowTraffic; else variable.Optimized = true;
} else if (head == "staticmap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".staticMap")) variable.Value = ssstaticMap; else variable.Optimized = true;
} else if (head == "style") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".style")) variable.Value = ssstyle; else variable.Optimized = true;
} else if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".type")) variable.Value = sstype; else variable.Optimized = true;
} else if (head == "zoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".zoom")) variable.Value = sszoom; else variable.Optimized = true;
} else if (head == "markerclusterer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".markerClusterer")) variable.Value = ssmarkerClusterer; else variable.Optimized = true;
variable.SetFieldName("markerclusterer");
} else if (head == "respectuserzoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".respectUserZoom")) variable.Value = ssrespectUserZoom; else variable.Optimized = true;
} else if (head == "localization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".localization")) variable.Value = sslocalization; else variable.Optimized = true;
variable.SetFieldName("localization");
} else if (head == "useadvancedmarkers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".useAdvancedMarkers")) variable.Value = ssuseAdvancedMarkers; else variable.Optimized = true;
} else if (head == "mapstyleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".mapStyleId")) variable.Value = ssmapStyleId; else variable.Optimized = true;
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
if (key == IdadvancedFormat) {
return ssadvancedFormat;
}
if (key == IdapiKey) {
return ssapiKey;
}
if (key == IdautoZoomOnShapes) {
return ssautoZoomOnShapes;
}
if (key == Idcenter) {
return sscenter;
}
if (key == Idheight) {
return ssheight;
}
if (key == Idoffset) {
return ssoffset;
}
if (key == IdshowTraffic) {
return ssshowTraffic;
}
if (key == IdstaticMap) {
return ssstaticMap;
}
if (key == Idstyle) {
return ssstyle;
}
if (key == Idtype) {
return sstype;
}
if (key == Idzoom) {
return sszoom;
}
if (key == IdmarkerClusterer) {
return ssmarkerClusterer;
}
if (key == IdrespectUserZoom) {
return ssrespectUserZoom;
}
if (key == Idlocalization) {
return sslocalization;
}
if (key == IduseAdvancedMarkers) {
return ssuseAdvancedMarkers;
}
if (key == IdmapStyleId) {
return ssmapStyleId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdadvancedFormat.Key.AsGuid) {
return ssadvancedFormat;
}
if (attributeKey == IdapiKey.Key.AsGuid) {
return ssapiKey;
}
if (attributeKey == IdautoZoomOnShapes.Key.AsGuid) {
return ssautoZoomOnShapes;
}
if (attributeKey == Idcenter.Key.AsGuid) {
return sscenter;
}
if (attributeKey == Idheight.Key.AsGuid) {
return ssheight;
}
if (attributeKey == Idoffset.Key.AsGuid) {
return ssoffset;
}
if (attributeKey == IdshowTraffic.Key.AsGuid) {
return ssshowTraffic;
}
if (attributeKey == IdstaticMap.Key.AsGuid) {
return ssstaticMap;
}
if (attributeKey == Idstyle.Key.AsGuid) {
return ssstyle;
}
if (attributeKey == Idtype.Key.AsGuid) {
return sstype;
}
if (attributeKey == Idzoom.Key.AsGuid) {
return sszoom;
}
if (attributeKey == IdmarkerClusterer.Key.AsGuid) {
return ssmarkerClusterer;
}
if (attributeKey == IdrespectUserZoom.Key.AsGuid) {
return ssrespectUserZoom;
}
if (attributeKey == Idlocalization.Key.AsGuid) {
return sslocalization;
}
if (attributeKey == IduseAdvancedMarkers.Key.AsGuid) {
return ssuseAdvancedMarkers;
}
if (attributeKey == IdmapStyleId.Key.AsGuid) {
return ssmapStyleId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssadvancedFormat = (string) other.AttributeGet(IdadvancedFormat);
ssapiKey = (string) other.AttributeGet(IdapiKey);
ssautoZoomOnShapes = (bool) other.AttributeGet(IdautoZoomOnShapes);
sscenter = (string) other.AttributeGet(Idcenter);
ssheight = (string) other.AttributeGet(Idheight);
ssoffset.FillFromOther((IRecord) other.AttributeGet(Idoffset));
ssshowTraffic = (bool) other.AttributeGet(IdshowTraffic);
ssstaticMap = (bool) other.AttributeGet(IdstaticMap);
ssstyle = (int) other.AttributeGet(Idstyle);
sstype = (string) other.AttributeGet(Idtype);
sszoom = (int) other.AttributeGet(Idzoom);
ssmarkerClusterer.FillFromOther((IRecord) other.AttributeGet(IdmarkerClusterer));
ssrespectUserZoom = (bool) other.AttributeGet(IdrespectUserZoom);
sslocalization.FillFromOther((IRecord) other.AttributeGet(Idlocalization));
ssuseAdvancedMarkers = (bool) other.AttributeGet(IduseAdvancedMarkers);
ssmapStyleId = (string) other.AttributeGet(IdmapStyleId);
}
} // ST_5baae74ed57e3bb61180aff1dadec4e1Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_configsList</code> that represents a record list of
///  <code>Internal_to_provider_configs</code>
/// </summary>
public partial class RL_22a46c31cc29b485a4a09782f08327cb : GenericRecordList<ST_5baae74ed57e3bb61180aff1dadec4e1Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_5baae74ed57e3bb61180aff1dadec4e1Structure GetElementDefaultValue() {
return new ST_5baae74ed57e3bb61180aff1dadec4e1Structure();
}

public T[] ToArray<T>(Func<ST_5baae74ed57e3bb61180aff1dadec4e1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_22a46c31cc29b485a4a09782f08327cb recordList, Func<ST_5baae74ed57e3bb61180aff1dadec4e1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_22a46c31cc29b485a4a09782f08327cb(ST_5baae74ed57e3bb61180aff1dadec4e1Structure[] array) {
  RL_22a46c31cc29b485a4a09782f08327cb result = new RL_22a46c31cc29b485a4a09782f08327cb();
result.InnerFromArray(array);
    return result;
}

public static RL_22a46c31cc29b485a4a09782f08327cb ToList<T>(T[] array, Func <T, ST_5baae74ed57e3bb61180aff1dadec4e1Structure> converter) {
  RL_22a46c31cc29b485a4a09782f08327cb result = new RL_22a46c31cc29b485a4a09782f08327cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_22a46c31cc29b485a4a09782f08327cb FromRestList<T>(RestList<T> restList, Func <T, ST_5baae74ed57e3bb61180aff1dadec4e1Structure> converter) {
  RL_22a46c31cc29b485a4a09782f08327cb result = new RL_22a46c31cc29b485a4a09782f08327cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_22a46c31cc29b485a4a09782f08327cb() : base() {
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
protected override OSList<ST_5baae74ed57e3bb61180aff1dadec4e1Structure> NewList() {
return new RL_22a46c31cc29b485a4a09782f08327cb();
}


} // RL_22a46c31cc29b485a4a09782f08327cb
}

