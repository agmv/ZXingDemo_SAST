namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Tabs_InternalConfig (q6N1AFDTQ0SDsO27VtSt6w)
///  <code>ST_235f8a24bba710c13f14db6b69a566bbStructure</code> that represent
/// s <code>Tabs_InternalConfig</code> <p>Description: Group of internal configurations for the Tabs
///  block. </p>
/// </summary>
// Name: Tabs_InternalConfig
public partial struct ST_235f8a24bba710c13f14db6b69a566bbStructure : ITypedRecord<ST_235f8a24bba710c13f14db6b69a566bbStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*m1TifXs8A0ifSIx2tTkdOg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KHZ5uedQ0k+2CsgIkfQPnw");
internal static readonly GlobalObjectKey IdStartingTab = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*uxQbKkcSKES5vmuXRZH3vw");
internal static readonly GlobalObjectKey IdTabsOrientation = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*qIFWkf3ET0aN4QAwNP0W_w");
internal static readonly GlobalObjectKey IdTabsVerticalPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*PzvvXkhT_0CmCAnE12SQGQ");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*rQafuawFaEavijr3zjyvEw");
internal static readonly GlobalObjectKey IdJustifyHeaders = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*c+j5NBApQkCUHgNn5F0hHw");
internal static readonly GlobalObjectKey IdContentAutoHeight = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5MFQ4lwx30+7mSEDD0Hr_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("StartingTab")]
public int ssStartingTab;

[System.Xml.Serialization.XmlElement("TabsOrientation")]
public string ssTabsOrientation;

[System.Xml.Serialization.XmlElement("TabsVerticalPosition")]
public string ssTabsVerticalPosition;

[System.Xml.Serialization.XmlElement("Height")]
public string ssHeight;

[System.Xml.Serialization.XmlElement("JustifyHeaders")]
public bool ssJustifyHeaders;

[System.Xml.Serialization.XmlElement("ContentAutoHeight")]
public bool ssContentAutoHeight;


public BitArray OptimizedAttributes;

public ST_235f8a24bba710c13f14db6b69a566bbStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssExtendedClass = "";
ssStartingTab = 0;
ssTabsOrientation = (ENOrientationEntity.GetRecordByKey(ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"))).ssOrientation;
ssTabsVerticalPosition = (ENDirectionEntity.GetRecordByKey(ObjectKey.Parse("dTjFZzFGd0u1v3BPY_5QaA"))).ssDirection;
ssHeight = "auto";
ssJustifyHeaders = false;
ssContentAutoHeight = false;
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
ssUniqueId = r.ReadText(index++, "Tabs_InternalConfig.UniqueId", "");
ssExtendedClass = r.ReadText(index++, "Tabs_InternalConfig.ExtendedClass", "");
ssStartingTab = r.ReadInteger(index++, "Tabs_InternalConfig.StartingTab", 0);
ssTabsOrientation = r.ReadEntityReferenceText(index++, "Tabs_InternalConfig.TabsOrientation", "");
ssTabsVerticalPosition = r.ReadEntityReferenceText(index++, "Tabs_InternalConfig.TabsVerticalPosition", "");
ssHeight = r.ReadText(index++, "Tabs_InternalConfig.Height", "");
ssJustifyHeaders = r.ReadBoolean(index++, "Tabs_InternalConfig.JustifyHeaders", false);
ssContentAutoHeight = r.ReadBoolean(index++, "Tabs_InternalConfig.ContentAutoHeight", false);
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
public void ReadIM(ST_235f8a24bba710c13f14db6b69a566bbStructure r) {
this = r;
}


public static bool operator == (ST_235f8a24bba710c13f14db6b69a566bbStructure a, ST_235f8a24bba710c13f14db6b69a566bbStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssStartingTab != b.ssStartingTab) return false;
if (a.ssTabsOrientation != b.ssTabsOrientation) return false;
if (a.ssTabsVerticalPosition != b.ssTabsVerticalPosition) return false;
if (a.ssHeight != b.ssHeight) return false;
if (a.ssJustifyHeaders != b.ssJustifyHeaders) return false;
if (a.ssContentAutoHeight != b.ssContentAutoHeight) return false;
return true;
}

public static bool operator != (ST_235f8a24bba710c13f14db6b69a566bbStructure a, ST_235f8a24bba710c13f14db6b69a566bbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_235f8a24bba710c13f14db6b69a566bbStructure)) return false;
return (this == (ST_235f8a24bba710c13f14db6b69a566bbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssStartingTab.GetHashCode()
 ^ ssTabsOrientation.GetHashCode()
 ^ ssTabsVerticalPosition.GetHashCode()
 ^ ssHeight.GetHashCode()
 ^ ssJustifyHeaders.GetHashCode()
 ^ ssContentAutoHeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_235f8a24bba710c13f14db6b69a566bbStructure Duplicate() {
ST_235f8a24bba710c13f14db6b69a566bbStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssExtendedClass = this.ssExtendedClass;
t.ssStartingTab = this.ssStartingTab;
t.ssTabsOrientation = this.ssTabsOrientation;
t.ssTabsVerticalPosition = this.ssTabsVerticalPosition;
t.ssHeight = this.ssHeight;
t.ssJustifyHeaders = this.ssJustifyHeaders;
t.ssContentAutoHeight = this.ssContentAutoHeight;
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
} else if (head == "startingtab") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartingTab")) variable.Value = ssStartingTab; else variable.Optimized = true;
} else if (head == "tabsorientation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabsOrientation")) variable.Value = ssTabsOrientation; else variable.Optimized = true;
} else if (head == "tabsverticalposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabsVerticalPosition")) variable.Value = ssTabsVerticalPosition; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
} else if (head == "justifyheaders") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JustifyHeaders")) variable.Value = ssJustifyHeaders; else variable.Optimized = true;
} else if (head == "contentautoheight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentAutoHeight")) variable.Value = ssContentAutoHeight; else variable.Optimized = true;
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
if (key == IdStartingTab) {
return ssStartingTab;
}
if (key == IdTabsOrientation) {
return ssTabsOrientation;
}
if (key == IdTabsVerticalPosition) {
return ssTabsVerticalPosition;
}
if (key == IdHeight) {
return ssHeight;
}
if (key == IdJustifyHeaders) {
return ssJustifyHeaders;
}
if (key == IdContentAutoHeight) {
return ssContentAutoHeight;
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
if (attributeKey == IdStartingTab.Key.AsGuid) {
return ssStartingTab;
}
if (attributeKey == IdTabsOrientation.Key.AsGuid) {
return ssTabsOrientation;
}
if (attributeKey == IdTabsVerticalPosition.Key.AsGuid) {
return ssTabsVerticalPosition;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
if (attributeKey == IdJustifyHeaders.Key.AsGuid) {
return ssJustifyHeaders;
}
if (attributeKey == IdContentAutoHeight.Key.AsGuid) {
return ssContentAutoHeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssStartingTab = (int) other.AttributeGet(IdStartingTab);
ssTabsOrientation = (string) other.AttributeGet(IdTabsOrientation);
ssTabsVerticalPosition = (string) other.AttributeGet(IdTabsVerticalPosition);
ssHeight = (string) other.AttributeGet(IdHeight);
ssJustifyHeaders = (bool) other.AttributeGet(IdJustifyHeaders);
ssContentAutoHeight = (bool) other.AttributeGet(IdContentAutoHeight);
}
} // ST_235f8a24bba710c13f14db6b69a566bbStructure
/// <summary>
/// RecordList type <code>Tabs_InternalConfigList</code> that represents a record list of
///  <code>Tabs_InternalConfig</code>
/// </summary>
public partial class RL_2a0eb2112b6bdaac280617c2b6e06a2f : GenericRecordList<ST_235f8a24bba710c13f14db6b69a566bbStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_235f8a24bba710c13f14db6b69a566bbStructure GetElementDefaultValue() {
return new ST_235f8a24bba710c13f14db6b69a566bbStructure();
}

public T[] ToArray<T>(Func<ST_235f8a24bba710c13f14db6b69a566bbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2a0eb2112b6bdaac280617c2b6e06a2f recordList, Func<ST_235f8a24bba710c13f14db6b69a566bbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2a0eb2112b6bdaac280617c2b6e06a2f(ST_235f8a24bba710c13f14db6b69a566bbStructure[] array) {
  RL_2a0eb2112b6bdaac280617c2b6e06a2f result = new RL_2a0eb2112b6bdaac280617c2b6e06a2f();
result.InnerFromArray(array);
    return result;
}

public static RL_2a0eb2112b6bdaac280617c2b6e06a2f ToList<T>(T[] array, Func <T, ST_235f8a24bba710c13f14db6b69a566bbStructure> converter) {
  RL_2a0eb2112b6bdaac280617c2b6e06a2f result = new RL_2a0eb2112b6bdaac280617c2b6e06a2f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2a0eb2112b6bdaac280617c2b6e06a2f FromRestList<T>(RestList<T> restList, Func <T, ST_235f8a24bba710c13f14db6b69a566bbStructure> converter) {
  RL_2a0eb2112b6bdaac280617c2b6e06a2f result = new RL_2a0eb2112b6bdaac280617c2b6e06a2f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2a0eb2112b6bdaac280617c2b6e06a2f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_235f8a24bba710c13f14db6b69a566bbStructure> NewList() {
return new RL_2a0eb2112b6bdaac280617c2b6e06a2f();
}


} // RL_2a0eb2112b6bdaac280617c2b6e06a2f
}

