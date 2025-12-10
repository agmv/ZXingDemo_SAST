namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] OptionalPopupMarkerConfigs (Pr_VyYUqikG_MiP87+uvLQ)
///  <code>ST_bbc1ca6a16af45dbf463953c280f2bf7Structure</code> that represent
/// s <code>OptionalPopupMarkerConfigs</code> <p>Description: Set additional parameters to customize
///  the popup marker’s behavior and functionality.</p>
/// </summary>
// Name: OptionalPopupMarkerConfigs
public partial struct ST_bbc1ca6a16af45dbf463953c280f2bf7Structure : ITypedRecord<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure> {
internal static readonly GlobalObjectKey IdIconURL = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*orXvtw8Z7EylR5sYHFfaWQ");
internal static readonly GlobalObjectKey IdIconSize = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*1Dlsn4T7nkOImE6sH4Kfzg");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*qaed_h5ZOkuRfLZiN_QNag");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*_OOgm1MmNkm9wnDn4ySTuw");
internal static readonly GlobalObjectKey IdAllowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Ehp9eOc4jUSt0GRmWMaQqA");

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

public ST_bbc1ca6a16af45dbf463953c280f2bf7Structure() {
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
ssIconURL = r.ReadText(index++, "OptionalPopupMarkerConfigs.IconURL", "");
ssTitle = r.ReadText(index++, "OptionalPopupMarkerConfigs.Title", "");
ssLabel = r.ReadText(index++, "OptionalPopupMarkerConfigs.Label", "");
ssAllowDrag = r.ReadBoolean(index++, "OptionalPopupMarkerConfigs.AllowDrag", false);
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
public void ReadIM(ST_bbc1ca6a16af45dbf463953c280f2bf7Structure r) {
this = r;
}


public static bool operator == (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure a, ST_bbc1ca6a16af45dbf463953c280f2bf7Structure b) {
if (a.ssIconURL != b.ssIconURL) return false;
if (a.ssIconSize != b.ssIconSize) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssAllowDrag != b.ssAllowDrag) return false;
return true;
}

public static bool operator != (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure a, ST_bbc1ca6a16af45dbf463953c280f2bf7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure)) return false;
return (this == (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure)o);
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


public ST_bbc1ca6a16af45dbf463953c280f2bf7Structure Duplicate() {
ST_bbc1ca6a16af45dbf463953c280f2bf7Structure t;
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
} // ST_bbc1ca6a16af45dbf463953c280f2bf7Structure
/// <summary>
/// RecordList type <code>OptionalPopupMarkerConfigsList</code> that represents a record list of
///  <code>OptionalPopupMarkerConfigs</code>
/// </summary>
public partial class RL_eafeffd52cd05aba315766e9bebd595c : GenericRecordList<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_bbc1ca6a16af45dbf463953c280f2bf7Structure GetElementDefaultValue() {
return new ST_bbc1ca6a16af45dbf463953c280f2bf7Structure();
}

public T[] ToArray<T>(Func<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eafeffd52cd05aba315766e9bebd595c recordList, Func<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eafeffd52cd05aba315766e9bebd595c(ST_bbc1ca6a16af45dbf463953c280f2bf7Structure[] array) {
  RL_eafeffd52cd05aba315766e9bebd595c result = new RL_eafeffd52cd05aba315766e9bebd595c();
result.InnerFromArray(array);
    return result;
}

public static RL_eafeffd52cd05aba315766e9bebd595c ToList<T>(T[] array, Func <T, ST_bbc1ca6a16af45dbf463953c280f2bf7Structure> converter) {
  RL_eafeffd52cd05aba315766e9bebd595c result = new RL_eafeffd52cd05aba315766e9bebd595c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eafeffd52cd05aba315766e9bebd595c FromRestList<T>(RestList<T> restList, Func <T, ST_bbc1ca6a16af45dbf463953c280f2bf7Structure> converter) {
  RL_eafeffd52cd05aba315766e9bebd595c result = new RL_eafeffd52cd05aba315766e9bebd595c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eafeffd52cd05aba315766e9bebd595c() : base() {
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
protected override OSList<ST_bbc1ca6a16af45dbf463953c280f2bf7Structure> NewList() {
return new RL_eafeffd52cd05aba315766e9bebd595c();
}


} // RL_eafeffd52cd05aba315766e9bebd595c
}

