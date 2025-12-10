namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalMarkerConfigs (NXdd1rRCLkez78cYLP3_qg)
///  <code>ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure</code> that represent
/// s <code>OptionalMarkerConfigs</code> <p>Description: Set additional parameters to customize the
///  marker’s behavior and functionality.</p>
/// </summary>
// Name: OptionalMarkerConfigs
public partial struct ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure : ITypedRecord<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure> {
internal static readonly GlobalObjectKey IdIconURL = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*eFLctTJL7kakzNMeNe7qpw");
internal static readonly GlobalObjectKey IdIconSize = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*6DDiliTrekq2bIvQ3e2pTg");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*UGhurU5ss06AaRSt5wFtKA");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*CQs82XQVskCQ1WiIUXgPOA");
internal static readonly GlobalObjectKey IdAllowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*jRux2a+8aUGjjr3YNDII7Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IconURL")]
public string ssIconURL;

[System.Xml.Serialization.XmlElement("IconSize")]
public ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure ssIconSize;

[System.Xml.Serialization.XmlElement("Title")]
public string ssTitle;

[System.Xml.Serialization.XmlElement("Label")]
public string ssLabel;

[System.Xml.Serialization.XmlElement("AllowDrag")]
public bool ssAllowDrag;


public BitArray OptimizedAttributes;

public ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure() {
OptimizedAttributes = null;
ssIconURL = "";
ssIconSize = new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure();
ssTitle = "";
ssLabel = "";
ssAllowDrag = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssIconSize.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssIconURL = r.ReadText(index++, "OptionalMarkerConfigs.IconURL", "");
ssTitle = r.ReadText(index++, "OptionalMarkerConfigs.Title", "");
ssLabel = r.ReadText(index++, "OptionalMarkerConfigs.Label", "");
ssAllowDrag = r.ReadBoolean(index++, "OptionalMarkerConfigs.AllowDrag", false);
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
public void ReadIM(ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure r) {
this = r;
}


public static bool operator == (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure a, ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure b) {
if (a.ssIconURL != b.ssIconURL) return false;
if (a.ssIconSize != b.ssIconSize) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssAllowDrag != b.ssAllowDrag) return false;
return true;
}

public static bool operator != (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure a, ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure)) return false;
return (this == (ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIconURL.GetHashCode()
 ^ ssIconSize.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssAllowDrag.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssIconSize.RecursiveReset();
}

public void InternalRecursiveSave() {
ssIconSize.InternalRecursiveSave();
}


public ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure Duplicate() {
ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure t;
t.ssIconURL = this.ssIconURL;
t.ssIconSize = (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure)this.ssIconSize.Duplicate();
t.ssTitle = this.ssTitle;
t.ssLabel = this.ssLabel;
t.ssAllowDrag = this.ssAllowDrag;
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
if (head == "iconurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IconURL")) variable.Value = ssIconURL; else variable.Optimized = true;
} else if (head == "iconsize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IconSize")) variable.Value = ssIconSize; else variable.Optimized = true;
variable.SetFieldName("iconsize");
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "allowdrag") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllowDrag")) variable.Value = ssAllowDrag; else variable.Optimized = true;
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
if (key == IdIconURL) {
return ssIconURL;
}
if (key == IdIconSize) {
return ssIconSize;
}
if (key == IdTitle) {
return ssTitle;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdAllowDrag) {
return ssAllowDrag;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIconURL.Key.AsGuid) {
return ssIconURL;
}
if (attributeKey == IdIconSize.Key.AsGuid) {
return ssIconSize;
}
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdAllowDrag.Key.AsGuid) {
return ssAllowDrag;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIconURL = (string) other.AttributeGet(IdIconURL);
ssIconSize.FillFromOther((IRecord) other.AttributeGet(IdIconSize));
ssTitle = (string) other.AttributeGet(IdTitle);
ssLabel = (string) other.AttributeGet(IdLabel);
ssAllowDrag = (bool) other.AttributeGet(IdAllowDrag);
}
} // ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure
/// <summary>
/// RecordList type <code>OptionalMarkerConfigsList</code> that represents a record list of
///  <code>OptionalMarkerConfigs</code>
/// </summary>
public partial class RL_72d1939a3c0be1d010649f2d48d51148 : GenericRecordList<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure GetElementDefaultValue() {
return new ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure();
}

public T[] ToArray<T>(Func<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_72d1939a3c0be1d010649f2d48d51148 recordList, Func<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_72d1939a3c0be1d010649f2d48d51148(ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure[] array) {
  RL_72d1939a3c0be1d010649f2d48d51148 result = new RL_72d1939a3c0be1d010649f2d48d51148();
result.InnerFromArray(array);
    return result;
}

public static RL_72d1939a3c0be1d010649f2d48d51148 ToList<T>(T[] array, Func <T, ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure> converter) {
  RL_72d1939a3c0be1d010649f2d48d51148 result = new RL_72d1939a3c0be1d010649f2d48d51148();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_72d1939a3c0be1d010649f2d48d51148 FromRestList<T>(RestList<T> restList, Func <T, ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure> converter) {
  RL_72d1939a3c0be1d010649f2d48d51148 result = new RL_72d1939a3c0be1d010649f2d48d51148();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_72d1939a3c0be1d010649f2d48d51148() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7f069279f39dd7c7d2e7b5637a5b25c9Structure> NewList() {
return new RL_72d1939a3c0be1d010649f2d48d51148();
}


} // RL_72d1939a3c0be1d010649f2d48d51148
}

