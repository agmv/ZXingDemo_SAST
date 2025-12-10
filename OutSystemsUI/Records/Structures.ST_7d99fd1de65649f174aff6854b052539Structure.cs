namespace ssOutSystemsUI {
/// <summary>
/// [Structure] CarouselOptionalConfigs (yukJtDn+o0uipSQPZip3mQ)
///  <code>ST_7d99fd1de65649f174aff6854b052539Structure</code> that represent
/// s <code>CarouselOptionalConfigs</code> <p>Description: Group of optional configurations for the
///  Carousel block. </p>
/// </summary>
// Name: CarouselOptionalConfigs
public partial struct ST_7d99fd1de65649f174aff6854b052539Structure : ITypedRecord<ST_7d99fd1de65649f174aff6854b052539Structure> {
internal static readonly GlobalObjectKey IdAutoPlay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*VDiaXZjN9EmhfPhF6XQdhQ");
internal static readonly GlobalObjectKey IdLoop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*V23Q4jxz40K6ImFAk4brQg");
internal static readonly GlobalObjectKey IdPadding = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*SB0oGV2ZZkuGdZ8WDti7zg");
internal static readonly GlobalObjectKey IdItemsGap = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*76cXR8LzSUecl0S1sBp7pw");
internal static readonly GlobalObjectKey IdStartingPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tTzBA2OjEE2wpWJwRn9N4A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AutoPlay")]
public bool ssAutoPlay;

[System.Xml.Serialization.XmlElement("Loop")]
public bool ssLoop;

[System.Xml.Serialization.XmlElement("Padding")]
public string ssPadding;

[System.Xml.Serialization.XmlElement("ItemsGap")]
public string ssItemsGap;

[System.Xml.Serialization.XmlElement("StartingPosition")]
public int ssStartingPosition;


public BitArray OptimizedAttributes;

public ST_7d99fd1de65649f174aff6854b052539Structure() {
OptimizedAttributes = null;
ssAutoPlay = true;
ssLoop = true;
ssPadding = "";
ssItemsGap = "";
ssStartingPosition = 0;
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
ssAutoPlay = r.ReadBoolean(index++, "CarouselOptionalConfigs.AutoPlay", false);
ssLoop = r.ReadBoolean(index++, "CarouselOptionalConfigs.Loop", false);
ssPadding = r.ReadText(index++, "CarouselOptionalConfigs.Padding", "");
ssItemsGap = r.ReadText(index++, "CarouselOptionalConfigs.ItemsGap", "");
ssStartingPosition = r.ReadInteger(index++, "CarouselOptionalConfigs.StartingPosition", 0);
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
public void ReadIM(ST_7d99fd1de65649f174aff6854b052539Structure r) {
this = r;
}


public static bool operator == (ST_7d99fd1de65649f174aff6854b052539Structure a, ST_7d99fd1de65649f174aff6854b052539Structure b) {
if (a.ssAutoPlay != b.ssAutoPlay) return false;
if (a.ssLoop != b.ssLoop) return false;
if (a.ssPadding != b.ssPadding) return false;
if (a.ssItemsGap != b.ssItemsGap) return false;
if (a.ssStartingPosition != b.ssStartingPosition) return false;
return true;
}

public static bool operator != (ST_7d99fd1de65649f174aff6854b052539Structure a, ST_7d99fd1de65649f174aff6854b052539Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7d99fd1de65649f174aff6854b052539Structure)) return false;
return (this == (ST_7d99fd1de65649f174aff6854b052539Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAutoPlay.GetHashCode()
 ^ ssLoop.GetHashCode()
 ^ ssPadding.GetHashCode()
 ^ ssItemsGap.GetHashCode()
 ^ ssStartingPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7d99fd1de65649f174aff6854b052539Structure Duplicate() {
ST_7d99fd1de65649f174aff6854b052539Structure t;
t.ssAutoPlay = this.ssAutoPlay;
t.ssLoop = this.ssLoop;
t.ssPadding = this.ssPadding;
t.ssItemsGap = this.ssItemsGap;
t.ssStartingPosition = this.ssStartingPosition;
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
if (head == "autoplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AutoPlay")) variable.Value = ssAutoPlay; else variable.Optimized = true;
} else if (head == "loop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Loop")) variable.Value = ssLoop; else variable.Optimized = true;
} else if (head == "padding") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Padding")) variable.Value = ssPadding; else variable.Optimized = true;
} else if (head == "itemsgap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsGap")) variable.Value = ssItemsGap; else variable.Optimized = true;
} else if (head == "startingposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartingPosition")) variable.Value = ssStartingPosition; else variable.Optimized = true;
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
if (key == IdAutoPlay) {
return ssAutoPlay;
}
if (key == IdLoop) {
return ssLoop;
}
if (key == IdPadding) {
return ssPadding;
}
if (key == IdItemsGap) {
return ssItemsGap;
}
if (key == IdStartingPosition) {
return ssStartingPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAutoPlay.Key.AsGuid) {
return ssAutoPlay;
}
if (attributeKey == IdLoop.Key.AsGuid) {
return ssLoop;
}
if (attributeKey == IdPadding.Key.AsGuid) {
return ssPadding;
}
if (attributeKey == IdItemsGap.Key.AsGuid) {
return ssItemsGap;
}
if (attributeKey == IdStartingPosition.Key.AsGuid) {
return ssStartingPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAutoPlay = (bool) other.AttributeGet(IdAutoPlay);
ssLoop = (bool) other.AttributeGet(IdLoop);
ssPadding = (string) other.AttributeGet(IdPadding);
ssItemsGap = (string) other.AttributeGet(IdItemsGap);
ssStartingPosition = (int) other.AttributeGet(IdStartingPosition);
}
} // ST_7d99fd1de65649f174aff6854b052539Structure
/// <summary>
/// RecordList type <code>CarouselOptionalConfigsList</code> that represents a record list of
///  <code>CarouselOptionalConfigs</code>
/// </summary>
public partial class RL_50d3e0774fce43a1ce1cf3a9009855f8 : GenericRecordList<ST_7d99fd1de65649f174aff6854b052539Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7d99fd1de65649f174aff6854b052539Structure GetElementDefaultValue() {
return new ST_7d99fd1de65649f174aff6854b052539Structure();
}

public T[] ToArray<T>(Func<ST_7d99fd1de65649f174aff6854b052539Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_50d3e0774fce43a1ce1cf3a9009855f8 recordList, Func<ST_7d99fd1de65649f174aff6854b052539Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_50d3e0774fce43a1ce1cf3a9009855f8(ST_7d99fd1de65649f174aff6854b052539Structure[] array) {
  RL_50d3e0774fce43a1ce1cf3a9009855f8 result = new RL_50d3e0774fce43a1ce1cf3a9009855f8();
result.InnerFromArray(array);
    return result;
}

public static RL_50d3e0774fce43a1ce1cf3a9009855f8 ToList<T>(T[] array, Func <T, ST_7d99fd1de65649f174aff6854b052539Structure> converter) {
  RL_50d3e0774fce43a1ce1cf3a9009855f8 result = new RL_50d3e0774fce43a1ce1cf3a9009855f8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_50d3e0774fce43a1ce1cf3a9009855f8 FromRestList<T>(RestList<T> restList, Func <T, ST_7d99fd1de65649f174aff6854b052539Structure> converter) {
  RL_50d3e0774fce43a1ce1cf3a9009855f8 result = new RL_50d3e0774fce43a1ce1cf3a9009855f8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_50d3e0774fce43a1ce1cf3a9009855f8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7d99fd1de65649f174aff6854b052539Structure> NewList() {
return new RL_50d3e0774fce43a1ce1cf3a9009855f8();
}


} // RL_50d3e0774fce43a1ce1cf3a9009855f8
}

