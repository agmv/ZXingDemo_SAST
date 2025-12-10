namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Author (lwdcVrIMEEeM9fgd9Eyr7A)
///  <code>ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure</code> that represents <code>Author</code
/// > <p>Description: Holds information about the author in the context of the File Layers.</p>
/// </summary>
// Name: Author
public partial struct ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure : ITypedRecord<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> {
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*bTnRerS60EeAMB39FOMKrA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*881LTA7iNEGNKilgEfRhdA");
internal static readonly GlobalObjectKey IdUri = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*u6n23K8ZnESONT5tDKb+tQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Email")]
public string ssEmail;

[System.Xml.Serialization.XmlElement("Name")]
public string ssName;

[System.Xml.Serialization.XmlElement("Uri")]
public string ssUri;


public BitArray OptimizedAttributes;

public ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure() {
OptimizedAttributes = null;
ssEmail = "";
ssName = "";
ssUri = "";
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
ssEmail = r.ReadEmail(index++, "Author.Email", "");
ssName = r.ReadText(index++, "Author.Name", "");
ssUri = r.ReadText(index++, "Author.Uri", "");
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
public void ReadIM(ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure r) {
this = r;
}


public static bool operator == (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure a, ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure b) {
if (a.ssEmail != b.ssEmail) return false;
if (a.ssName != b.ssName) return false;
if (a.ssUri != b.ssUri) return false;
return true;
}

public static bool operator != (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure a, ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure)) return false;
return (this == (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssUri.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure Duplicate() {
ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure t;
t.ssEmail = this.ssEmail;
t.ssName = this.ssName;
t.ssUri = this.ssUri;
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
if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "uri") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Uri")) variable.Value = ssUri; else variable.Optimized = true;
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
if (key == IdEmail) {
return ssEmail;
}
if (key == IdName) {
return ssName;
}
if (key == IdUri) {
return ssUri;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdUri.Key.AsGuid) {
return ssUri;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEmail = (string) other.AttributeGet(IdEmail);
ssName = (string) other.AttributeGet(IdName);
ssUri = (string) other.AttributeGet(IdUri);
}
} // ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure
/// <summary>
/// RecordList type <code>AuthorList</code> that represents a record list of <code>Author</code>
/// </summary>
public partial class RL_d8645c67ee74276888b02145980ad608 : GenericRecordList<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure GetElementDefaultValue() {
return new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure();
}

public T[] ToArray<T>(Func<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8645c67ee74276888b02145980ad608 recordList, Func<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8645c67ee74276888b02145980ad608(ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure[] array) {
  RL_d8645c67ee74276888b02145980ad608 result = new RL_d8645c67ee74276888b02145980ad608();
result.InnerFromArray(array);
    return result;
}

public static RL_d8645c67ee74276888b02145980ad608 ToList<T>(T[] array, Func <T, ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> converter) {
  RL_d8645c67ee74276888b02145980ad608 result = new RL_d8645c67ee74276888b02145980ad608();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8645c67ee74276888b02145980ad608 FromRestList<T>(RestList<T> restList, Func <T, ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> converter) {
  RL_d8645c67ee74276888b02145980ad608 result = new RL_d8645c67ee74276888b02145980ad608();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8645c67ee74276888b02145980ad608() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> NewList() {
return new RL_d8645c67ee74276888b02145980ad608();
}


} // RL_d8645c67ee74276888b02145980ad608
}

