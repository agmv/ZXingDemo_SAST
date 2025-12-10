namespace ssOutSystemsUI {
/// <summary>
/// [Structure] Video_InternalConfig (CHgc3lJhnESJwD2FGfaYeQ)
///  <code>ST_87ed820dae13f311d79f7f394fc3790aStructure</code> that represent
/// s <code>Video_InternalConfig</code> <p>Description: Group of internal configurations for the Video
///  block. </p>
/// </summary>
// Name: Video_InternalConfig
public partial struct ST_87ed820dae13f311d79f7f394fc3790aStructure : ITypedRecord<ST_87ed820dae13f311d79f7f394fc3790aStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tUXQX4nJqEeoryrTrLk+kQ");
internal static readonly GlobalObjectKey IdAutoplay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ewtKVDauq0C7K5OzB9RmnA");
internal static readonly GlobalObjectKey IdCaptions = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*LXQuf09bXEOlCeBwDap+tg");
internal static readonly GlobalObjectKey IdControls = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*mZC+IYqeZEKOPzlvkwpxRA");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*q0mX52lmDESs+mUc_KCPrw");
internal static readonly GlobalObjectKey IdLoop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*vZKiKLe7Ukq728uQ5wu4og");
internal static readonly GlobalObjectKey IdMuted = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*FA2oArCG4UWWW07YD3u2MA");
internal static readonly GlobalObjectKey IdPosterURL = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*qcUPCTLrXUS6++L8dnJwdQ");
internal static readonly GlobalObjectKey IdURL = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*hOZ8SRZgk0uDfToxsCqI_w");
internal static readonly GlobalObjectKey IdWidth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*WZtILheXpEG8W3Czu3dWGQ");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KTcAj845DUyF5Z4fFFqiWA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("Autoplay")]
public bool ssAutoplay;

[System.Xml.Serialization.XmlElement("Captions")]
public string ssCaptions;

[System.Xml.Serialization.XmlElement("Controls")]
public bool ssControls;

[System.Xml.Serialization.XmlElement("Height")]
public string ssHeight;

[System.Xml.Serialization.XmlElement("Loop")]
public bool ssLoop;

[System.Xml.Serialization.XmlElement("Muted")]
public bool ssMuted;

[System.Xml.Serialization.XmlElement("PosterURL")]
public string ssPosterURL;

[System.Xml.Serialization.XmlElement("URL")]
public string ssURL;

[System.Xml.Serialization.XmlElement("Width")]
public string ssWidth;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;


public BitArray OptimizedAttributes;

public ST_87ed820dae13f311d79f7f394fc3790aStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssAutoplay = true;
ssCaptions = "";
ssControls = true;
ssHeight = "";
ssLoop = false;
ssMuted = false;
ssPosterURL = "";
ssURL = "";
ssWidth = "";
ssExtendedClass = "";
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
ssUniqueId = r.ReadText(index++, "Video_InternalConfig.UniqueId", "");
ssAutoplay = r.ReadBoolean(index++, "Video_InternalConfig.Autoplay", false);
ssCaptions = r.ReadText(index++, "Video_InternalConfig.Captions", "");
ssControls = r.ReadBoolean(index++, "Video_InternalConfig.Controls", false);
ssHeight = r.ReadText(index++, "Video_InternalConfig.Height", "");
ssLoop = r.ReadBoolean(index++, "Video_InternalConfig.Loop", false);
ssMuted = r.ReadBoolean(index++, "Video_InternalConfig.Muted", false);
ssPosterURL = r.ReadText(index++, "Video_InternalConfig.PosterURL", "");
ssURL = r.ReadText(index++, "Video_InternalConfig.URL", "");
ssWidth = r.ReadText(index++, "Video_InternalConfig.Width", "");
ssExtendedClass = r.ReadText(index++, "Video_InternalConfig.ExtendedClass", "");
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
public void ReadIM(ST_87ed820dae13f311d79f7f394fc3790aStructure r) {
this = r;
}


public static bool operator == (ST_87ed820dae13f311d79f7f394fc3790aStructure a, ST_87ed820dae13f311d79f7f394fc3790aStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssAutoplay != b.ssAutoplay) return false;
if (a.ssCaptions != b.ssCaptions) return false;
if (a.ssControls != b.ssControls) return false;
if (a.ssHeight != b.ssHeight) return false;
if (a.ssLoop != b.ssLoop) return false;
if (a.ssMuted != b.ssMuted) return false;
if (a.ssPosterURL != b.ssPosterURL) return false;
if (a.ssURL != b.ssURL) return false;
if (a.ssWidth != b.ssWidth) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
return true;
}

public static bool operator != (ST_87ed820dae13f311d79f7f394fc3790aStructure a, ST_87ed820dae13f311d79f7f394fc3790aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_87ed820dae13f311d79f7f394fc3790aStructure)) return false;
return (this == (ST_87ed820dae13f311d79f7f394fc3790aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssAutoplay.GetHashCode()
 ^ ssCaptions.GetHashCode()
 ^ ssControls.GetHashCode()
 ^ ssHeight.GetHashCode()
 ^ ssLoop.GetHashCode()
 ^ ssMuted.GetHashCode()
 ^ ssPosterURL.GetHashCode()
 ^ ssURL.GetHashCode()
 ^ ssWidth.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_87ed820dae13f311d79f7f394fc3790aStructure Duplicate() {
ST_87ed820dae13f311d79f7f394fc3790aStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssAutoplay = this.ssAutoplay;
t.ssCaptions = this.ssCaptions;
t.ssControls = this.ssControls;
t.ssHeight = this.ssHeight;
t.ssLoop = this.ssLoop;
t.ssMuted = this.ssMuted;
t.ssPosterURL = this.ssPosterURL;
t.ssURL = this.ssURL;
t.ssWidth = this.ssWidth;
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
} else if (head == "autoplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Autoplay")) variable.Value = ssAutoplay; else variable.Optimized = true;
} else if (head == "captions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Captions")) variable.Value = ssCaptions; else variable.Optimized = true;
} else if (head == "controls") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Controls")) variable.Value = ssControls; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
} else if (head == "loop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Loop")) variable.Value = ssLoop; else variable.Optimized = true;
} else if (head == "muted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Muted")) variable.Value = ssMuted; else variable.Optimized = true;
} else if (head == "posterurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PosterURL")) variable.Value = ssPosterURL; else variable.Optimized = true;
} else if (head == "url") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URL")) variable.Value = ssURL; else variable.Optimized = true;
} else if (head == "width") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Width")) variable.Value = ssWidth; else variable.Optimized = true;
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
if (key == IdAutoplay) {
return ssAutoplay;
}
if (key == IdCaptions) {
return ssCaptions;
}
if (key == IdControls) {
return ssControls;
}
if (key == IdHeight) {
return ssHeight;
}
if (key == IdLoop) {
return ssLoop;
}
if (key == IdMuted) {
return ssMuted;
}
if (key == IdPosterURL) {
return ssPosterURL;
}
if (key == IdURL) {
return ssURL;
}
if (key == IdWidth) {
return ssWidth;
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
if (attributeKey == IdAutoplay.Key.AsGuid) {
return ssAutoplay;
}
if (attributeKey == IdCaptions.Key.AsGuid) {
return ssCaptions;
}
if (attributeKey == IdControls.Key.AsGuid) {
return ssControls;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
if (attributeKey == IdLoop.Key.AsGuid) {
return ssLoop;
}
if (attributeKey == IdMuted.Key.AsGuid) {
return ssMuted;
}
if (attributeKey == IdPosterURL.Key.AsGuid) {
return ssPosterURL;
}
if (attributeKey == IdURL.Key.AsGuid) {
return ssURL;
}
if (attributeKey == IdWidth.Key.AsGuid) {
return ssWidth;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssAutoplay = (bool) other.AttributeGet(IdAutoplay);
ssCaptions = (string) other.AttributeGet(IdCaptions);
ssControls = (bool) other.AttributeGet(IdControls);
ssHeight = (string) other.AttributeGet(IdHeight);
ssLoop = (bool) other.AttributeGet(IdLoop);
ssMuted = (bool) other.AttributeGet(IdMuted);
ssPosterURL = (string) other.AttributeGet(IdPosterURL);
ssURL = (string) other.AttributeGet(IdURL);
ssWidth = (string) other.AttributeGet(IdWidth);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
}
} // ST_87ed820dae13f311d79f7f394fc3790aStructure
/// <summary>
/// RecordList type <code>Video_InternalConfigList</code> that represents a record list of
///  <code>Video_InternalConfig</code>
/// </summary>
public partial class RL_73cbe97ff08da4924df6411aaaf55e68 : GenericRecordList<ST_87ed820dae13f311d79f7f394fc3790aStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_87ed820dae13f311d79f7f394fc3790aStructure GetElementDefaultValue() {
return new ST_87ed820dae13f311d79f7f394fc3790aStructure();
}

public T[] ToArray<T>(Func<ST_87ed820dae13f311d79f7f394fc3790aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_73cbe97ff08da4924df6411aaaf55e68 recordList, Func<ST_87ed820dae13f311d79f7f394fc3790aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_73cbe97ff08da4924df6411aaaf55e68(ST_87ed820dae13f311d79f7f394fc3790aStructure[] array) {
  RL_73cbe97ff08da4924df6411aaaf55e68 result = new RL_73cbe97ff08da4924df6411aaaf55e68();
result.InnerFromArray(array);
    return result;
}

public static RL_73cbe97ff08da4924df6411aaaf55e68 ToList<T>(T[] array, Func <T, ST_87ed820dae13f311d79f7f394fc3790aStructure> converter) {
  RL_73cbe97ff08da4924df6411aaaf55e68 result = new RL_73cbe97ff08da4924df6411aaaf55e68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_73cbe97ff08da4924df6411aaaf55e68 FromRestList<T>(RestList<T> restList, Func <T, ST_87ed820dae13f311d79f7f394fc3790aStructure> converter) {
  RL_73cbe97ff08da4924df6411aaaf55e68 result = new RL_73cbe97ff08da4924df6411aaaf55e68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_73cbe97ff08da4924df6411aaaf55e68() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_87ed820dae13f311d79f7f394fc3790aStructure> NewList() {
return new RL_73cbe97ff08da4924df6411aaaf55e68();
}


} // RL_73cbe97ff08da4924df6411aaaf55e68
}

