namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Carousel_InternalConfig (Ah1voYpYeUiTsx0Qb1YaHQ)
///  <code>ST_736a0a0e931f1e6cffc1de4b3ad94539Structure</code> that represent
/// s <code>Carousel_InternalConfig</code> <p>Description: Group of internal configurations for the
///  Carousel block. </p>
/// </summary>
// Name: Carousel_InternalConfig
public partial struct ST_736a0a0e931f1e6cffc1de4b3ad94539Structure : ITypedRecord<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Lbff4c8Ze0ev5xtz5P9qGg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*BCDATEw_qUawRgsw+47Hrg");
internal static readonly GlobalObjectKey IdNavigation = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_RktaLGUrEyagfZDPa_0_A");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*LfjnU3hjBk6uteuY5I9UJA");
internal static readonly GlobalObjectKey IdItemsDesktop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*pIsdxgH4HkWAiKU7toqmqA");
internal static readonly GlobalObjectKey IdItemsTablet = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ZNJkwC+WPUGefaQFUSO78Q");
internal static readonly GlobalObjectKey IdItemsPhone = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*vMeTUTc5ZE2SGf7NpOzv+Q");
internal static readonly GlobalObjectKey IdAutoPlay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1KQVrc4UKU+ZRm31508EKw");
internal static readonly GlobalObjectKey IdLoop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_9Tr6vTYMUaJraVZ3H0UoA");
internal static readonly GlobalObjectKey IdPadding = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jLSMXgNR1kqZW71xJ+lbNQ");
internal static readonly GlobalObjectKey IdStartingPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ynzlk6LK8U+qAedCm3TcLg");
internal static readonly GlobalObjectKey IdItemsGap = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*eWgibxitxkylOfRuzKOiSg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("Navigation")]
public string ssNavigation;

[System.Xml.Serialization.XmlElement("Height")]
public string ssHeight;

[System.Xml.Serialization.XmlElement("ItemsDesktop")]
public int ssItemsDesktop;

[System.Xml.Serialization.XmlElement("ItemsTablet")]
public int ssItemsTablet;

[System.Xml.Serialization.XmlElement("ItemsPhone")]
public int ssItemsPhone;

[System.Xml.Serialization.XmlElement("AutoPlay")]
public bool ssAutoPlay;

[System.Xml.Serialization.XmlElement("Loop")]
public bool ssLoop;

[System.Xml.Serialization.XmlElement("Padding")]
public string ssPadding;

[System.Xml.Serialization.XmlElement("StartingPosition")]
public int ssStartingPosition;

[System.Xml.Serialization.XmlElement("ItemsGap")]
public string ssItemsGap;


public BitArray OptimizedAttributes;

public ST_736a0a0e931f1e6cffc1de4b3ad94539Structure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssExtendedClass = "";
ssNavigation = "";
ssHeight = "";
ssItemsDesktop = 1;
ssItemsTablet = 1;
ssItemsPhone = 1;
ssAutoPlay = true;
ssLoop = true;
ssPadding = "0";
ssStartingPosition = 0;
ssItemsGap = "0";
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
ssUniqueId = r.ReadText(index++, "Carousel_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "Carousel_InternalConfig.ExtendedClass", "");
ssNavigation = r.ReadEntityReferenceText(index++, "Carousel_InternalConfig.Navigation", "");
ssHeight = r.ReadText(index++, "Carousel_InternalConfig.Height", "");
ssItemsDesktop = r.ReadInteger(index++, "Carousel_InternalConfig.ItemsDesktop", 0);
ssItemsTablet = r.ReadInteger(index++, "Carousel_InternalConfig.ItemsTablet", 0);
ssItemsPhone = r.ReadInteger(index++, "Carousel_InternalConfig.ItemsPhone", 0);
ssAutoPlay = r.ReadBoolean(index++, "Carousel_InternalConfig.AutoPlay", false);
ssLoop = r.ReadBoolean(index++, "Carousel_InternalConfig.Loop", false);
ssPadding = r.ReadText(index++, "Carousel_InternalConfig.Padding", "");
ssStartingPosition = r.ReadInteger(index++, "Carousel_InternalConfig.StartingPosition", 0);
ssItemsGap = r.ReadText(index++, "Carousel_InternalConfig.ItemsGap", "");
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
public void ReadIM(ST_736a0a0e931f1e6cffc1de4b3ad94539Structure r) {
this = r;
}


public static bool operator == (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure a, ST_736a0a0e931f1e6cffc1de4b3ad94539Structure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssNavigation != b.ssNavigation) return false;
if (a.ssHeight != b.ssHeight) return false;
if (a.ssItemsDesktop != b.ssItemsDesktop) return false;
if (a.ssItemsTablet != b.ssItemsTablet) return false;
if (a.ssItemsPhone != b.ssItemsPhone) return false;
if (a.ssAutoPlay != b.ssAutoPlay) return false;
if (a.ssLoop != b.ssLoop) return false;
if (a.ssPadding != b.ssPadding) return false;
if (a.ssStartingPosition != b.ssStartingPosition) return false;
if (a.ssItemsGap != b.ssItemsGap) return false;
return true;
}

public static bool operator != (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure a, ST_736a0a0e931f1e6cffc1de4b3ad94539Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure)) return false;
return (this == (ST_736a0a0e931f1e6cffc1de4b3ad94539Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssNavigation.GetHashCode()
 ^ ssHeight.GetHashCode()
 ^ ssItemsDesktop.GetHashCode()
 ^ ssItemsTablet.GetHashCode()
 ^ ssItemsPhone.GetHashCode()
 ^ ssAutoPlay.GetHashCode()
 ^ ssLoop.GetHashCode()
 ^ ssPadding.GetHashCode()
 ^ ssStartingPosition.GetHashCode()
 ^ ssItemsGap.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_736a0a0e931f1e6cffc1de4b3ad94539Structure Duplicate() {
ST_736a0a0e931f1e6cffc1de4b3ad94539Structure t;
t.ssUniqueId = this.ssUniqueId;
t.ssExtendedClass = this.ssExtendedClass;
t.ssNavigation = this.ssNavigation;
t.ssHeight = this.ssHeight;
t.ssItemsDesktop = this.ssItemsDesktop;
t.ssItemsTablet = this.ssItemsTablet;
t.ssItemsPhone = this.ssItemsPhone;
t.ssAutoPlay = this.ssAutoPlay;
t.ssLoop = this.ssLoop;
t.ssPadding = this.ssPadding;
t.ssStartingPosition = this.ssStartingPosition;
t.ssItemsGap = this.ssItemsGap;
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
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "navigation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Navigation")) variable.Value = ssNavigation; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
} else if (head == "itemsdesktop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsDesktop")) variable.Value = ssItemsDesktop; else variable.Optimized = true;
} else if (head == "itemstablet") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsTablet")) variable.Value = ssItemsTablet; else variable.Optimized = true;
} else if (head == "itemsphone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsPhone")) variable.Value = ssItemsPhone; else variable.Optimized = true;
} else if (head == "autoplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AutoPlay")) variable.Value = ssAutoPlay; else variable.Optimized = true;
} else if (head == "loop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Loop")) variable.Value = ssLoop; else variable.Optimized = true;
} else if (head == "padding") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Padding")) variable.Value = ssPadding; else variable.Optimized = true;
} else if (head == "startingposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartingPosition")) variable.Value = ssStartingPosition; else variable.Optimized = true;
} else if (head == "itemsgap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsGap")) variable.Value = ssItemsGap; else variable.Optimized = true;
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
if (key == IdExtendedClass) {
return ssExtendedClass;
}
if (key == IdNavigation) {
return ssNavigation;
}
if (key == IdHeight) {
return ssHeight;
}
if (key == IdItemsDesktop) {
return ssItemsDesktop;
}
if (key == IdItemsTablet) {
return ssItemsTablet;
}
if (key == IdItemsPhone) {
return ssItemsPhone;
}
if (key == IdAutoPlay) {
return ssAutoPlay;
}
if (key == IdLoop) {
return ssLoop;
}
if (key == IdPadding) {
return ssPadding;
}
if (key == IdStartingPosition) {
return ssStartingPosition;
}
if (key == IdItemsGap) {
return ssItemsGap;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
if (attributeKey == IdNavigation.Key.AsGuid) {
return ssNavigation;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
if (attributeKey == IdItemsDesktop.Key.AsGuid) {
return ssItemsDesktop;
}
if (attributeKey == IdItemsTablet.Key.AsGuid) {
return ssItemsTablet;
}
if (attributeKey == IdItemsPhone.Key.AsGuid) {
return ssItemsPhone;
}
if (attributeKey == IdAutoPlay.Key.AsGuid) {
return ssAutoPlay;
}
if (attributeKey == IdLoop.Key.AsGuid) {
return ssLoop;
}
if (attributeKey == IdPadding.Key.AsGuid) {
return ssPadding;
}
if (attributeKey == IdStartingPosition.Key.AsGuid) {
return ssStartingPosition;
}
if (attributeKey == IdItemsGap.Key.AsGuid) {
return ssItemsGap;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssNavigation = (string) other.AttributeGet(IdNavigation);
ssHeight = (string) other.AttributeGet(IdHeight);
ssItemsDesktop = (int) other.AttributeGet(IdItemsDesktop);
ssItemsTablet = (int) other.AttributeGet(IdItemsTablet);
ssItemsPhone = (int) other.AttributeGet(IdItemsPhone);
ssAutoPlay = (bool) other.AttributeGet(IdAutoPlay);
ssLoop = (bool) other.AttributeGet(IdLoop);
ssPadding = (string) other.AttributeGet(IdPadding);
ssStartingPosition = (int) other.AttributeGet(IdStartingPosition);
ssItemsGap = (string) other.AttributeGet(IdItemsGap);
}
} // ST_736a0a0e931f1e6cffc1de4b3ad94539Structure
/// <summary>
/// RecordList type <code>Carousel_InternalConfigList</code> that represents a record list of
///  <code>Carousel_InternalConfig</code>
/// </summary>
public partial class RL_2995190cb5b8004126c835c4dd6dec76 : GenericRecordList<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_736a0a0e931f1e6cffc1de4b3ad94539Structure GetElementDefaultValue() {
return new ST_736a0a0e931f1e6cffc1de4b3ad94539Structure();
}

public T[] ToArray<T>(Func<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2995190cb5b8004126c835c4dd6dec76 recordList, Func<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2995190cb5b8004126c835c4dd6dec76(ST_736a0a0e931f1e6cffc1de4b3ad94539Structure[] array) {
  RL_2995190cb5b8004126c835c4dd6dec76 result = new RL_2995190cb5b8004126c835c4dd6dec76();
result.InnerFromArray(array);
    return result;
}

public static RL_2995190cb5b8004126c835c4dd6dec76 ToList<T>(T[] array, Func <T, ST_736a0a0e931f1e6cffc1de4b3ad94539Structure> converter) {
  RL_2995190cb5b8004126c835c4dd6dec76 result = new RL_2995190cb5b8004126c835c4dd6dec76();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2995190cb5b8004126c835c4dd6dec76 FromRestList<T>(RestList<T> restList, Func <T, ST_736a0a0e931f1e6cffc1de4b3ad94539Structure> converter) {
  RL_2995190cb5b8004126c835c4dd6dec76 result = new RL_2995190cb5b8004126c835c4dd6dec76();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2995190cb5b8004126c835c4dd6dec76() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_736a0a0e931f1e6cffc1de4b3ad94539Structure> NewList() {
return new RL_2995190cb5b8004126c835c4dd6dec76();
}


} // RL_2995190cb5b8004126c835c4dd6dec76
}

