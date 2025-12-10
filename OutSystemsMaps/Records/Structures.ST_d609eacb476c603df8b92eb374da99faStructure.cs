namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalMapConfigs (Z6bJHsxUF0GE4UXTJclJew)
///  <code>ST_d609eacb476c603df8b92eb374da99faStructure</code> that represent
/// s <code>OptionalMapConfigs</code> <p>Description: Set additional parameters to customize map’s
///  behavior and functionality.</p>
/// </summary>
// Name: OptionalMapConfigs
public partial struct ST_d609eacb476c603df8b92eb374da99faStructure : ITypedRecord<ST_d609eacb476c603df8b92eb374da99faStructure> {
internal static readonly GlobalObjectKey IdAutoZoomOnShapes = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*lLIyAX_U5UWNB_UOmzqzOA");
internal static readonly GlobalObjectKey IdLocalization = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*NiDYtrYBIEqc4gcRJezLeg");
internal static readonly GlobalObjectKey IdMapStyleId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*zPHoLauU9kC+P8aWtihlLA");
internal static readonly GlobalObjectKey IdMarkerClusterer = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*hnutTwLXbEy2bbUc7icFbw");
internal static readonly GlobalObjectKey IdOffset = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*0m+dhD_alk2pGHR0m0+gzQ");
internal static readonly GlobalObjectKey IdRespectUserZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*bOCk+ZGOdEGmB8rg9iBRxg");
internal static readonly GlobalObjectKey IdShowTraffic = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*ZDU7pXCitUGjUzjrnVN6Tg");
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*ngdDxZ0WkEOO1__PqJMy7g");
internal static readonly GlobalObjectKey IdUseAdvancedMarkers = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*hKxFwJURn0m6nMr7FYdk2Q");
internal static readonly GlobalObjectKey IdZoom = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*jwv0PnEhCUCV_i3v9FvsZg");
internal static readonly GlobalObjectKey IdDEPRECATED_AdvancedFormat = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nnOwuWf0cUK1+k63PlTs2g");
internal static readonly GlobalObjectKey IdDEPRECATED_Style = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*EVA3Z84VsUGo4v68o5_Vgg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AutoZoomOnShapes")]
public bool ssAutoZoomOnShapes;

[System.Xml.Serialization.XmlElement("Localization")]
public ST_59c2aa6a35b14343cc78f655810f9ce8Structure ssLocalization;

[System.Xml.Serialization.XmlElement("MapStyleId")]
public string ssMapStyleId;

[System.Xml.Serialization.XmlElement("MarkerClusterer")]
public ST_30625b4ad0f3e10abf82b61ea58e8644Structure ssMarkerClusterer;

[System.Xml.Serialization.XmlElement("Offset")]
public ST_be62cc31fbe4705834275960beeb55e2Structure ssOffset;

[System.Xml.Serialization.XmlElement("RespectUserZoom")]
public bool ssRespectUserZoom;

[System.Xml.Serialization.XmlElement("ShowTraffic")]
public bool ssShowTraffic;

[System.Xml.Serialization.XmlElement("Type")]
public string ssType;

[System.Xml.Serialization.XmlElement("UseAdvancedMarkers")]
public bool ssUseAdvancedMarkers;

[System.Xml.Serialization.XmlElement("Zoom")]
public int ssZoom;

[System.Xml.Serialization.XmlElement("DEPRECATED_AdvancedFormat")]
public string ssDEPRECATED_AdvancedFormat;

[System.Xml.Serialization.XmlElement("DEPRECATED_Style")]
public int ssDEPRECATED_Style;


public BitArray OptimizedAttributes;

public ST_d609eacb476c603df8b92eb374da99faStructure() {
OptimizedAttributes = null;
ssAutoZoomOnShapes = false;
ssLocalization = new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
ssMapStyleId = "";
ssMarkerClusterer = new ST_30625b4ad0f3e10abf82b61ea58e8644Structure();
ssOffset = new ST_be62cc31fbe4705834275960beeb55e2Structure();
ssRespectUserZoom = false;
ssShowTraffic = false;
ssType = (ENTypeEntity.GetRecordByKey(ObjectKey.Parse("ovetaFeGuE6McBWDcnLLEg"))).ssMapType;
ssUseAdvancedMarkers = true;
ssZoom = (ENZoomEntity.GetRecordByKey(ObjectKey.Parse("WLo5+5B9A0iAL7Ee_Ty8xQ"))).ssId;
ssDEPRECATED_AdvancedFormat = "";
ssDEPRECATED_Style = (ENStyleEntity.GetRecordByKey(ObjectKey.Parse("z3WmRlAB0E+axyyW9z2pcA"))).ssId;
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
    ssLocalization.OptimizedAttributes = value[0];
    ssMarkerClusterer.OptimizedAttributes = value[1];
    ssOffset.OptimizedAttributes = value[2];
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
ssAutoZoomOnShapes = r.ReadBoolean(index++, "OptionalMapConfigs.AutoZoomOnShapes", false);
ssMapStyleId = r.ReadText(index++, "OptionalMapConfigs.MapStyleId", "");
ssRespectUserZoom = r.ReadBoolean(index++, "OptionalMapConfigs.RespectUserZoom", false);
ssShowTraffic = r.ReadBoolean(index++, "OptionalMapConfigs.ShowTraffic", false);
ssType = r.ReadEntityReferenceText(index++, "OptionalMapConfigs.Type", "");
ssUseAdvancedMarkers = r.ReadBoolean(index++, "OptionalMapConfigs.UseAdvancedMarkers", false);
ssZoom = r.ReadEntityReference(index++, "OptionalMapConfigs.Zoom", 0);
ssDEPRECATED_AdvancedFormat = r.ReadText(index++, "OptionalMapConfigs.DEPRECATED_AdvancedFormat", "");
ssDEPRECATED_Style = r.ReadEntityReference(index++, "OptionalMapConfigs.DEPRECATED_Style", 0);
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
public void ReadIM(ST_d609eacb476c603df8b92eb374da99faStructure r) {
this = r;
}


public static bool operator == (ST_d609eacb476c603df8b92eb374da99faStructure a, ST_d609eacb476c603df8b92eb374da99faStructure b) {
if (a.ssAutoZoomOnShapes != b.ssAutoZoomOnShapes) return false;
if (a.ssLocalization != b.ssLocalization) return false;
if (a.ssMapStyleId != b.ssMapStyleId) return false;
if (a.ssMarkerClusterer != b.ssMarkerClusterer) return false;
if (a.ssOffset != b.ssOffset) return false;
if (a.ssRespectUserZoom != b.ssRespectUserZoom) return false;
if (a.ssShowTraffic != b.ssShowTraffic) return false;
if (a.ssType != b.ssType) return false;
if (a.ssUseAdvancedMarkers != b.ssUseAdvancedMarkers) return false;
if (a.ssZoom != b.ssZoom) return false;
if (a.ssDEPRECATED_AdvancedFormat != b.ssDEPRECATED_AdvancedFormat) return false;
if (a.ssDEPRECATED_Style != b.ssDEPRECATED_Style) return false;
return true;
}

public static bool operator != (ST_d609eacb476c603df8b92eb374da99faStructure a, ST_d609eacb476c603df8b92eb374da99faStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d609eacb476c603df8b92eb374da99faStructure)) return false;
return (this == (ST_d609eacb476c603df8b92eb374da99faStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAutoZoomOnShapes.GetHashCode()
 ^ ssLocalization.GetHashCode()
 ^ ssMapStyleId.GetHashCode()
 ^ ssMarkerClusterer.GetHashCode()
 ^ ssOffset.GetHashCode()
 ^ ssRespectUserZoom.GetHashCode()
 ^ ssShowTraffic.GetHashCode()
 ^ ssType.GetHashCode()
 ^ ssUseAdvancedMarkers.GetHashCode()
 ^ ssZoom.GetHashCode()
 ^ ssDEPRECATED_AdvancedFormat.GetHashCode()
 ^ ssDEPRECATED_Style.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssLocalization.RecursiveReset();
ssMarkerClusterer.RecursiveReset();
ssOffset.RecursiveReset();
}

public void InternalRecursiveSave() {
ssLocalization.InternalRecursiveSave();
ssMarkerClusterer.InternalRecursiveSave();
ssOffset.InternalRecursiveSave();
}


public ST_d609eacb476c603df8b92eb374da99faStructure Duplicate() {
ST_d609eacb476c603df8b92eb374da99faStructure t;
t.ssAutoZoomOnShapes = this.ssAutoZoomOnShapes;
t.ssLocalization = (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)this.ssLocalization.Duplicate();
t.ssMapStyleId = this.ssMapStyleId;
t.ssMarkerClusterer = (ST_30625b4ad0f3e10abf82b61ea58e8644Structure)this.ssMarkerClusterer.Duplicate();
t.ssOffset = (ST_be62cc31fbe4705834275960beeb55e2Structure)this.ssOffset.Duplicate();
t.ssRespectUserZoom = this.ssRespectUserZoom;
t.ssShowTraffic = this.ssShowTraffic;
t.ssType = this.ssType;
t.ssUseAdvancedMarkers = this.ssUseAdvancedMarkers;
t.ssZoom = this.ssZoom;
t.ssDEPRECATED_AdvancedFormat = this.ssDEPRECATED_AdvancedFormat;
t.ssDEPRECATED_Style = this.ssDEPRECATED_Style;
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
if (head == "autozoomonshapes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AutoZoomOnShapes")) variable.Value = ssAutoZoomOnShapes; else variable.Optimized = true;
} else if (head == "localization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Localization")) variable.Value = ssLocalization; else variable.Optimized = true;
variable.SetFieldName("localization");
} else if (head == "mapstyleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MapStyleId")) variable.Value = ssMapStyleId; else variable.Optimized = true;
} else if (head == "markerclusterer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkerClusterer")) variable.Value = ssMarkerClusterer; else variable.Optimized = true;
variable.SetFieldName("markerclusterer");
} else if (head == "offset") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Offset")) variable.Value = ssOffset; else variable.Optimized = true;
variable.SetFieldName("offset");
} else if (head == "respectuserzoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RespectUserZoom")) variable.Value = ssRespectUserZoom; else variable.Optimized = true;
} else if (head == "showtraffic") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowTraffic")) variable.Value = ssShowTraffic; else variable.Optimized = true;
} else if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
} else if (head == "useadvancedmarkers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UseAdvancedMarkers")) variable.Value = ssUseAdvancedMarkers; else variable.Optimized = true;
} else if (head == "zoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Zoom")) variable.Value = ssZoom; else variable.Optimized = true;
} else if (head == "deprecated_advancedformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DEPRECATED_AdvancedFormat")) variable.Value = ssDEPRECATED_AdvancedFormat; else variable.Optimized = true;
} else if (head == "deprecated_style") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DEPRECATED_Style")) variable.Value = ssDEPRECATED_Style; else variable.Optimized = true;
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
if (key == IdAutoZoomOnShapes) {
return ssAutoZoomOnShapes;
}
if (key == IdLocalization) {
return ssLocalization;
}
if (key == IdMapStyleId) {
return ssMapStyleId;
}
if (key == IdMarkerClusterer) {
return ssMarkerClusterer;
}
if (key == IdOffset) {
return ssOffset;
}
if (key == IdRespectUserZoom) {
return ssRespectUserZoom;
}
if (key == IdShowTraffic) {
return ssShowTraffic;
}
if (key == IdType) {
return ssType;
}
if (key == IdUseAdvancedMarkers) {
return ssUseAdvancedMarkers;
}
if (key == IdZoom) {
return ssZoom;
}
if (key == IdDEPRECATED_AdvancedFormat) {
return ssDEPRECATED_AdvancedFormat;
}
if (key == IdDEPRECATED_Style) {
return ssDEPRECATED_Style;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAutoZoomOnShapes.Key.AsGuid) {
return ssAutoZoomOnShapes;
}
if (attributeKey == IdLocalization.Key.AsGuid) {
return ssLocalization;
}
if (attributeKey == IdMapStyleId.Key.AsGuid) {
return ssMapStyleId;
}
if (attributeKey == IdMarkerClusterer.Key.AsGuid) {
return ssMarkerClusterer;
}
if (attributeKey == IdOffset.Key.AsGuid) {
return ssOffset;
}
if (attributeKey == IdRespectUserZoom.Key.AsGuid) {
return ssRespectUserZoom;
}
if (attributeKey == IdShowTraffic.Key.AsGuid) {
return ssShowTraffic;
}
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
}
if (attributeKey == IdUseAdvancedMarkers.Key.AsGuid) {
return ssUseAdvancedMarkers;
}
if (attributeKey == IdZoom.Key.AsGuid) {
return ssZoom;
}
if (attributeKey == IdDEPRECATED_AdvancedFormat.Key.AsGuid) {
return ssDEPRECATED_AdvancedFormat;
}
if (attributeKey == IdDEPRECATED_Style.Key.AsGuid) {
return ssDEPRECATED_Style;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAutoZoomOnShapes = (bool) other.AttributeGet(IdAutoZoomOnShapes);
ssLocalization.FillFromOther((IRecord) other.AttributeGet(IdLocalization));
ssMapStyleId = (string) other.AttributeGet(IdMapStyleId);
ssMarkerClusterer.FillFromOther((IRecord) other.AttributeGet(IdMarkerClusterer));
ssOffset.FillFromOther((IRecord) other.AttributeGet(IdOffset));
ssRespectUserZoom = (bool) other.AttributeGet(IdRespectUserZoom);
ssShowTraffic = (bool) other.AttributeGet(IdShowTraffic);
ssType = (string) other.AttributeGet(IdType);
ssUseAdvancedMarkers = (bool) other.AttributeGet(IdUseAdvancedMarkers);
ssZoom = (int) other.AttributeGet(IdZoom);
ssDEPRECATED_AdvancedFormat = (string) other.AttributeGet(IdDEPRECATED_AdvancedFormat);
ssDEPRECATED_Style = (int) other.AttributeGet(IdDEPRECATED_Style);
}
} // ST_d609eacb476c603df8b92eb374da99faStructure
/// <summary>
/// RecordList type <code>OptionalMapConfigsList</code> that represents a record list of
///  <code>OptionalMapConfigs</code>
/// </summary>
public partial class RL_a0d33d282a082e36edde3e445101c333 : GenericRecordList<ST_d609eacb476c603df8b92eb374da99faStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_d609eacb476c603df8b92eb374da99faStructure GetElementDefaultValue() {
return new ST_d609eacb476c603df8b92eb374da99faStructure();
}

public T[] ToArray<T>(Func<ST_d609eacb476c603df8b92eb374da99faStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a0d33d282a082e36edde3e445101c333 recordList, Func<ST_d609eacb476c603df8b92eb374da99faStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a0d33d282a082e36edde3e445101c333(ST_d609eacb476c603df8b92eb374da99faStructure[] array) {
  RL_a0d33d282a082e36edde3e445101c333 result = new RL_a0d33d282a082e36edde3e445101c333();
result.InnerFromArray(array);
    return result;
}

public static RL_a0d33d282a082e36edde3e445101c333 ToList<T>(T[] array, Func <T, ST_d609eacb476c603df8b92eb374da99faStructure> converter) {
  RL_a0d33d282a082e36edde3e445101c333 result = new RL_a0d33d282a082e36edde3e445101c333();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a0d33d282a082e36edde3e445101c333 FromRestList<T>(RestList<T> restList, Func <T, ST_d609eacb476c603df8b92eb374da99faStructure> converter) {
  RL_a0d33d282a082e36edde3e445101c333 result = new RL_a0d33d282a082e36edde3e445101c333();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a0d33d282a082e36edde3e445101c333() : base() {
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
protected override OSList<ST_d609eacb476c603df8b92eb374da99faStructure> NewList() {
return new RL_a0d33d282a082e36edde3e445101c333();
}


} // RL_a0d33d282a082e36edde3e445101c333
}

