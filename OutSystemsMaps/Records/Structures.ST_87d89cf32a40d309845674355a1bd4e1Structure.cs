namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] FeatureData (W7DIZOfXLEuR2RbWFRjGEA)
///  <code>ST_87d89cf32a40d309845674355a1bd4e1Structure</code> that represents <code>FeatureData</code
/// > <p>Description: Holds information about the feature data in the context of File Layers.</p>
/// </summary>
// Name: FeatureData
public partial struct ST_87d89cf32a40d309845674355a1bd4e1Structure : ITypedRecord<ST_87d89cf32a40d309845674355a1bd4e1Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*dmxEAOUp1kujsE1qaHU_uA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*FMf_YpTkBkeKDacHsKyLag");
internal static readonly GlobalObjectKey IdAuthor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*SqRzQBi_wEWP9d44PeT8Gg");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Pr0k9NR6jUK_WRM603qgCg");
internal static readonly GlobalObjectKey IdInfoWindowHtml = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*p9HamsRjD0KSxmvg8aXwxQ");
internal static readonly GlobalObjectKey IdSnippet = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*VXVItQBTw0u7JAoeoSZMvw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Id")]
public string ssId;

[System.Xml.Serialization.XmlElement("Name")]
public string ssName;

[System.Xml.Serialization.XmlElement("Author")]
public ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure ssAuthor;

[System.Xml.Serialization.XmlElement("Description")]
public string ssDescription;

[System.Xml.Serialization.XmlElement("InfoWindowHtml")]
public string ssInfoWindowHtml;

[System.Xml.Serialization.XmlElement("Snippet")]
public string ssSnippet;


public BitArray OptimizedAttributes;

public ST_87d89cf32a40d309845674355a1bd4e1Structure() {
OptimizedAttributes = null;
ssId = "";
ssName = "";
ssAuthor = new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure();
ssDescription = "";
ssInfoWindowHtml = "";
ssSnippet = "";
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
    ssAuthor.OptimizedAttributes = value[0];
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
ssId = r.ReadText(index++, "FeatureData.Id", "");
ssName = r.ReadText(index++, "FeatureData.Name", "");
ssDescription = r.ReadText(index++, "FeatureData.Description", "");
ssInfoWindowHtml = r.ReadText(index++, "FeatureData.InfoWindowHtml", "");
ssSnippet = r.ReadText(index++, "FeatureData.Snippet", "");
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
public void ReadIM(ST_87d89cf32a40d309845674355a1bd4e1Structure r) {
this = r;
}


public static bool operator == (ST_87d89cf32a40d309845674355a1bd4e1Structure a, ST_87d89cf32a40d309845674355a1bd4e1Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssAuthor != b.ssAuthor) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssInfoWindowHtml != b.ssInfoWindowHtml) return false;
if (a.ssSnippet != b.ssSnippet) return false;
return true;
}

public static bool operator != (ST_87d89cf32a40d309845674355a1bd4e1Structure a, ST_87d89cf32a40d309845674355a1bd4e1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_87d89cf32a40d309845674355a1bd4e1Structure)) return false;
return (this == (ST_87d89cf32a40d309845674355a1bd4e1Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssAuthor.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssInfoWindowHtml.GetHashCode()
 ^ ssSnippet.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssAuthor.RecursiveReset();
}

public void InternalRecursiveSave() {
ssAuthor.InternalRecursiveSave();
}


public ST_87d89cf32a40d309845674355a1bd4e1Structure Duplicate() {
ST_87d89cf32a40d309845674355a1bd4e1Structure t;
t.ssId = this.ssId;
t.ssName = this.ssName;
t.ssAuthor = (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure)this.ssAuthor.Duplicate();
t.ssDescription = this.ssDescription;
t.ssInfoWindowHtml = this.ssInfoWindowHtml;
t.ssSnippet = this.ssSnippet;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "author") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Author")) variable.Value = ssAuthor; else variable.Optimized = true;
variable.SetFieldName("author");
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "infowindowhtml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InfoWindowHtml")) variable.Value = ssInfoWindowHtml; else variable.Optimized = true;
} else if (head == "snippet") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Snippet")) variable.Value = ssSnippet; else variable.Optimized = true;
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
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdAuthor) {
return ssAuthor;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdInfoWindowHtml) {
return ssInfoWindowHtml;
}
if (key == IdSnippet) {
return ssSnippet;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdAuthor.Key.AsGuid) {
return ssAuthor;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdInfoWindowHtml.Key.AsGuid) {
return ssInfoWindowHtml;
}
if (attributeKey == IdSnippet.Key.AsGuid) {
return ssSnippet;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ssAuthor.FillFromOther((IRecord) other.AttributeGet(IdAuthor));
ssDescription = (string) other.AttributeGet(IdDescription);
ssInfoWindowHtml = (string) other.AttributeGet(IdInfoWindowHtml);
ssSnippet = (string) other.AttributeGet(IdSnippet);
}
} // ST_87d89cf32a40d309845674355a1bd4e1Structure
/// <summary>
/// RecordList type <code>FeatureDataList</code> that represents a record list of
///  <code>FeatureData</code>
/// </summary>
public partial class RL_a6093ab8c4c3fe4e765d6d53e363d26f : GenericRecordList<ST_87d89cf32a40d309845674355a1bd4e1Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_87d89cf32a40d309845674355a1bd4e1Structure GetElementDefaultValue() {
return new ST_87d89cf32a40d309845674355a1bd4e1Structure();
}

public T[] ToArray<T>(Func<ST_87d89cf32a40d309845674355a1bd4e1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a6093ab8c4c3fe4e765d6d53e363d26f recordList, Func<ST_87d89cf32a40d309845674355a1bd4e1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a6093ab8c4c3fe4e765d6d53e363d26f(ST_87d89cf32a40d309845674355a1bd4e1Structure[] array) {
  RL_a6093ab8c4c3fe4e765d6d53e363d26f result = new RL_a6093ab8c4c3fe4e765d6d53e363d26f();
result.InnerFromArray(array);
    return result;
}

public static RL_a6093ab8c4c3fe4e765d6d53e363d26f ToList<T>(T[] array, Func <T, ST_87d89cf32a40d309845674355a1bd4e1Structure> converter) {
  RL_a6093ab8c4c3fe4e765d6d53e363d26f result = new RL_a6093ab8c4c3fe4e765d6d53e363d26f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a6093ab8c4c3fe4e765d6d53e363d26f FromRestList<T>(RestList<T> restList, Func <T, ST_87d89cf32a40d309845674355a1bd4e1Structure> converter) {
  RL_a6093ab8c4c3fe4e765d6d53e363d26f result = new RL_a6093ab8c4c3fe4e765d6d53e363d26f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a6093ab8c4c3fe4e765d6d53e363d26f() : base() {
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
protected override OSList<ST_87d89cf32a40d309845674355a1bd4e1Structure> NewList() {
return new RL_a6093ab8c4c3fe4e765d6d53e363d26f();
}


} // RL_a6093ab8c4c3fe4e765d6d53e363d26f
}

