namespace ssOutSystemsUI {
/// <summary>
/// [Structure] NoUiSliderConfigs (OHFQpHsvwky+_PPPj80ixA)
///  <code>ST_af087c80f6ec63e7de4ff7926f7da7d0Structure</code> that represent
/// s <code>NoUiSliderConfigs</code> <p>Description: Structure with all configs supported by the
///  provider.</p>
/// </summary>
// Name: NoUiSliderConfigs
public partial struct ST_af087c80f6ec63e7de4ff7926f7da7d0Structure : ITypedRecord<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> {
internal static readonly GlobalObjectKey Idanimate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jTkXX5hptkqFpfbL+6DkZw");
internal static readonly GlobalObjectKey IdanimationDuration = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Ae+9rojgMkyyuognTCknew");
internal static readonly GlobalObjectKey Idbehaviour = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xcRjO66xMkCOUkRYW3bLYg");
internal static readonly GlobalObjectKey IdcssPrefix = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*26yHTN+BjU+7XQ+quP_bqw");
internal static readonly GlobalObjectKey IdkeyboardMultiplier = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xoQ4hE6iHke_qtEfLZ1x+g");
internal static readonly GlobalObjectKey IdkeyboardPageMultiplier = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*qdsQW0ad2ES5zaqVabUSeg");
internal static readonly GlobalObjectKey IdkeyboardSupport = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*3pgSkIq0Lk2OGFdzdUGrAQ");
internal static readonly GlobalObjectKey Idlimit = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*yWgfzH_ATkOhMCLeFla4fQ");
internal static readonly GlobalObjectKey Idmargin = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+1KM4R9atkWm_rvS6j8GRA");
internal static readonly GlobalObjectKey Idpadding = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KGxvU3bgeE2qW+ZKWrz1uw");
internal static readonly GlobalObjectKey Idrange = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+STPgawPM0uP8aMZS+xWPg");
internal static readonly GlobalObjectKey Idsnap = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*OYp50UUZpU+9n5yZlILqIg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("animate")]
public string ssanimate;

[System.Xml.Serialization.XmlElement("animationDuration")]
public int ssanimationDuration;

[System.Xml.Serialization.XmlElement("behaviour")]
public string ssbehaviour;

[System.Xml.Serialization.XmlElement("cssPrefix")]
public string sscssPrefix;

[System.Xml.Serialization.XmlElement("keyboardMultiplier")]
public int sskeyboardMultiplier;

[System.Xml.Serialization.XmlElement("keyboardPageMultiplier")]
public int sskeyboardPageMultiplier;

[System.Xml.Serialization.XmlElement("keyboardSupport")]
public string sskeyboardSupport;

[System.Xml.Serialization.XmlElement("limit")]
public int sslimit;

[System.Xml.Serialization.XmlElement("margin")]
public int ssmargin;

[System.Xml.Serialization.XmlElement("padding")]
public int sspadding;

[System.Xml.Serialization.XmlElement("range")]
public RL_b290214900b73d49f11f1fe32c57a145 ssrange;

[System.Xml.Serialization.XmlElement("snap")]
public bool sssnap;


public BitArray OptimizedAttributes;

public ST_af087c80f6ec63e7de4ff7926f7da7d0Structure() {
OptimizedAttributes = null;
ssanimate = (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel;
ssanimationDuration = 300;
ssbehaviour = "";
sscssPrefix = "";
sskeyboardMultiplier = 1;
sskeyboardPageMultiplier = 5;
sskeyboardSupport = (ENBooleanTypesEntity.GetRecordByKey(ObjectKey.Parse("WaERvwc3iEiOhsOwx4vIiQ"))).ssLabel;
sslimit = 0;
ssmargin = 0;
sspadding = 0;
ssrange = new RL_b290214900b73d49f11f1fe32c57a145();
sssnap = false;
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
ssanimate = r.ReadEntityReferenceText(index++, "NoUiSliderConfigs.animate", "");
ssanimationDuration = r.ReadInteger(index++, "NoUiSliderConfigs.animationDuration", 0);
ssbehaviour = r.ReadText(index++, "NoUiSliderConfigs.behaviour", "");
sscssPrefix = r.ReadText(index++, "NoUiSliderConfigs.cssPrefix", "");
sskeyboardMultiplier = r.ReadInteger(index++, "NoUiSliderConfigs.keyboardMultiplier", 0);
sskeyboardPageMultiplier = r.ReadInteger(index++, "NoUiSliderConfigs.keyboardPageMultiplier", 0);
sskeyboardSupport = r.ReadEntityReferenceText(index++, "NoUiSliderConfigs.keyboardSupport", "");
sslimit = r.ReadInteger(index++, "NoUiSliderConfigs.limit", 0);
ssmargin = r.ReadInteger(index++, "NoUiSliderConfigs.margin", 0);
sspadding = r.ReadInteger(index++, "NoUiSliderConfigs.padding", 0);
sssnap = r.ReadBoolean(index++, "NoUiSliderConfigs.snap", false);
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
public void ReadIM(ST_af087c80f6ec63e7de4ff7926f7da7d0Structure r) {
this = r;
}


public static bool operator == (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure a, ST_af087c80f6ec63e7de4ff7926f7da7d0Structure b) {
if (a.ssanimate != b.ssanimate) return false;
if (a.ssanimationDuration != b.ssanimationDuration) return false;
if (a.ssbehaviour != b.ssbehaviour) return false;
if (a.sscssPrefix != b.sscssPrefix) return false;
if (a.sskeyboardMultiplier != b.sskeyboardMultiplier) return false;
if (a.sskeyboardPageMultiplier != b.sskeyboardPageMultiplier) return false;
if (a.sskeyboardSupport != b.sskeyboardSupport) return false;
if (a.sslimit != b.sslimit) return false;
if (a.ssmargin != b.ssmargin) return false;
if (a.sspadding != b.sspadding) return false;
if (a.ssrange != b.ssrange) return false;
if (a.sssnap != b.sssnap) return false;
return true;
}

public static bool operator != (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure a, ST_af087c80f6ec63e7de4ff7926f7da7d0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure)) return false;
return (this == (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssanimate.GetHashCode()
 ^ ssanimationDuration.GetHashCode()
 ^ ssbehaviour.GetHashCode()
 ^ sscssPrefix.GetHashCode()
 ^ sskeyboardMultiplier.GetHashCode()
 ^ sskeyboardPageMultiplier.GetHashCode()
 ^ sskeyboardSupport.GetHashCode()
 ^ sslimit.GetHashCode()
 ^ ssmargin.GetHashCode()
 ^ sspadding.GetHashCode()
 ^ ssrange.GetHashCode()
 ^ sssnap.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssrange.RecursiveReset();
}

public void InternalRecursiveSave() {
ssrange.InternalRecursiveSave();
}


public ST_af087c80f6ec63e7de4ff7926f7da7d0Structure Duplicate() {
ST_af087c80f6ec63e7de4ff7926f7da7d0Structure t;
t.ssanimate = this.ssanimate;
t.ssanimationDuration = this.ssanimationDuration;
t.ssbehaviour = this.ssbehaviour;
t.sscssPrefix = this.sscssPrefix;
t.sskeyboardMultiplier = this.sskeyboardMultiplier;
t.sskeyboardPageMultiplier = this.sskeyboardPageMultiplier;
t.sskeyboardSupport = this.sskeyboardSupport;
t.sslimit = this.sslimit;
t.ssmargin = this.ssmargin;
t.sspadding = this.sspadding;
t.ssrange = (RL_b290214900b73d49f11f1fe32c57a145)this.ssrange.Duplicate();
t.sssnap = this.sssnap;
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
if (head == "animate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".animate")) variable.Value = ssanimate; else variable.Optimized = true;
} else if (head == "animationduration") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".animationDuration")) variable.Value = ssanimationDuration; else variable.Optimized = true;
} else if (head == "behaviour") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".behaviour")) variable.Value = ssbehaviour; else variable.Optimized = true;
} else if (head == "cssprefix") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".cssPrefix")) variable.Value = sscssPrefix; else variable.Optimized = true;
} else if (head == "keyboardmultiplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".keyboardMultiplier")) variable.Value = sskeyboardMultiplier; else variable.Optimized = true;
} else if (head == "keyboardpagemultiplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".keyboardPageMultiplier")) variable.Value = sskeyboardPageMultiplier; else variable.Optimized = true;
} else if (head == "keyboardsupport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".keyboardSupport")) variable.Value = sskeyboardSupport; else variable.Optimized = true;
} else if (head == "limit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".limit")) variable.Value = sslimit; else variable.Optimized = true;
} else if (head == "margin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".margin")) variable.Value = ssmargin; else variable.Optimized = true;
} else if (head == "padding") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".padding")) variable.Value = sspadding; else variable.Optimized = true;
} else if (head == "range") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".range")) variable.Value = ssrange; else variable.Optimized = true;
variable.SetFieldName("range");
} else if (head == "snap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".snap")) variable.Value = sssnap; else variable.Optimized = true;
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
if (key == Idanimate) {
return ssanimate;
}
if (key == IdanimationDuration) {
return ssanimationDuration;
}
if (key == Idbehaviour) {
return ssbehaviour;
}
if (key == IdcssPrefix) {
return sscssPrefix;
}
if (key == IdkeyboardMultiplier) {
return sskeyboardMultiplier;
}
if (key == IdkeyboardPageMultiplier) {
return sskeyboardPageMultiplier;
}
if (key == IdkeyboardSupport) {
return sskeyboardSupport;
}
if (key == Idlimit) {
return sslimit;
}
if (key == Idmargin) {
return ssmargin;
}
if (key == Idpadding) {
return sspadding;
}
if (key == Idrange) {
return ssrange;
}
if (key == Idsnap) {
return sssnap;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idanimate.Key.AsGuid) {
return ssanimate;
}
if (attributeKey == IdanimationDuration.Key.AsGuid) {
return ssanimationDuration;
}
if (attributeKey == Idbehaviour.Key.AsGuid) {
return ssbehaviour;
}
if (attributeKey == IdcssPrefix.Key.AsGuid) {
return sscssPrefix;
}
if (attributeKey == IdkeyboardMultiplier.Key.AsGuid) {
return sskeyboardMultiplier;
}
if (attributeKey == IdkeyboardPageMultiplier.Key.AsGuid) {
return sskeyboardPageMultiplier;
}
if (attributeKey == IdkeyboardSupport.Key.AsGuid) {
return sskeyboardSupport;
}
if (attributeKey == Idlimit.Key.AsGuid) {
return sslimit;
}
if (attributeKey == Idmargin.Key.AsGuid) {
return ssmargin;
}
if (attributeKey == Idpadding.Key.AsGuid) {
return sspadding;
}
if (attributeKey == Idrange.Key.AsGuid) {
return ssrange;
}
if (attributeKey == Idsnap.Key.AsGuid) {
return sssnap;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssanimate = (string) other.AttributeGet(Idanimate);
ssanimationDuration = (int) other.AttributeGet(IdanimationDuration);
ssbehaviour = (string) other.AttributeGet(Idbehaviour);
sscssPrefix = (string) other.AttributeGet(IdcssPrefix);
sskeyboardMultiplier = (int) other.AttributeGet(IdkeyboardMultiplier);
sskeyboardPageMultiplier = (int) other.AttributeGet(IdkeyboardPageMultiplier);
sskeyboardSupport = (string) other.AttributeGet(IdkeyboardSupport);
sslimit = (int) other.AttributeGet(Idlimit);
ssmargin = (int) other.AttributeGet(Idmargin);
sspadding = (int) other.AttributeGet(Idpadding);
ssrange = new RL_b290214900b73d49f11f1fe32c57a145();
ssrange.FillFromOther((IOSList) other.AttributeGet(Idrange));
sssnap = (bool) other.AttributeGet(Idsnap);
}
} // ST_af087c80f6ec63e7de4ff7926f7da7d0Structure
/// <summary>
/// RecordList type <code>NoUiSliderConfigsList</code> that represents a record list of
///  <code>NoUiSliderConfigs</code>
/// </summary>
public partial class RL_2434a812d9c1801fbc8d36150d23329c : GenericRecordList<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_af087c80f6ec63e7de4ff7926f7da7d0Structure GetElementDefaultValue() {
return new ST_af087c80f6ec63e7de4ff7926f7da7d0Structure();
}

public T[] ToArray<T>(Func<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2434a812d9c1801fbc8d36150d23329c recordList, Func<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2434a812d9c1801fbc8d36150d23329c(ST_af087c80f6ec63e7de4ff7926f7da7d0Structure[] array) {
  RL_2434a812d9c1801fbc8d36150d23329c result = new RL_2434a812d9c1801fbc8d36150d23329c();
result.InnerFromArray(array);
    return result;
}

public static RL_2434a812d9c1801fbc8d36150d23329c ToList<T>(T[] array, Func <T, ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> converter) {
  RL_2434a812d9c1801fbc8d36150d23329c result = new RL_2434a812d9c1801fbc8d36150d23329c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2434a812d9c1801fbc8d36150d23329c FromRestList<T>(RestList<T> restList, Func <T, ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> converter) {
  RL_2434a812d9c1801fbc8d36150d23329c result = new RL_2434a812d9c1801fbc8d36150d23329c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2434a812d9c1801fbc8d36150d23329c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_af087c80f6ec63e7de4ff7926f7da7d0Structure> NewList() {
return new RL_2434a812d9c1801fbc8d36150d23329c();
}


} // RL_2434a812d9c1801fbc8d36150d23329c
}

