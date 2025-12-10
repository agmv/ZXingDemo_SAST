namespace ssOutSystemsUI {
/// <summary>
/// [Structure] ListNavigation (rm0XYdWa3kCsgj4zHmyl+g)
///  <code>ST_28a47f2e64dd49f0d3d29e55f70be394Structure</code> that represent
/// s <code>ListNavigation</code> <p>Description: Adds items to the Pagination pattern.</p>
/// </summary>
// Name: ListNavigation
public partial struct ST_28a47f2e64dd49f0d3d29e55f70be394Structure : ITypedRecord<ST_28a47f2e64dd49f0d3d29e55f70be394Structure> {
internal static readonly GlobalObjectKey IdPage = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*nQfsju+biUi4O5R_BW_acA");
internal static readonly GlobalObjectKey IdStartIndex = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_jL7WFrx6UaoGk6a4ddV_w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Page")]
public int ssPage;

[System.Xml.Serialization.XmlElement("StartIndex")]
public int ssStartIndex;


public BitArray OptimizedAttributes;

public ST_28a47f2e64dd49f0d3d29e55f70be394Structure() {
OptimizedAttributes = null;
ssPage = 0;
ssStartIndex = 0;
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
ssPage = r.ReadInteger(index++, "ListNavigation.Page", 0);
ssStartIndex = r.ReadInteger(index++, "ListNavigation.StartIndex", 0);
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
public void ReadIM(ST_28a47f2e64dd49f0d3d29e55f70be394Structure r) {
this = r;
}


public static bool operator == (ST_28a47f2e64dd49f0d3d29e55f70be394Structure a, ST_28a47f2e64dd49f0d3d29e55f70be394Structure b) {
if (a.ssPage != b.ssPage) return false;
if (a.ssStartIndex != b.ssStartIndex) return false;
return true;
}

public static bool operator != (ST_28a47f2e64dd49f0d3d29e55f70be394Structure a, ST_28a47f2e64dd49f0d3d29e55f70be394Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_28a47f2e64dd49f0d3d29e55f70be394Structure)) return false;
return (this == (ST_28a47f2e64dd49f0d3d29e55f70be394Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPage.GetHashCode()
 ^ ssStartIndex.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_28a47f2e64dd49f0d3d29e55f70be394Structure Duplicate() {
ST_28a47f2e64dd49f0d3d29e55f70be394Structure t;
t.ssPage = this.ssPage;
t.ssStartIndex = this.ssStartIndex;
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
if (head == "page") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Page")) variable.Value = ssPage; else variable.Optimized = true;
} else if (head == "startindex") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartIndex")) variable.Value = ssStartIndex; else variable.Optimized = true;
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
if (key == IdPage) {
return ssPage;
}
if (key == IdStartIndex) {
return ssStartIndex;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPage.Key.AsGuid) {
return ssPage;
}
if (attributeKey == IdStartIndex.Key.AsGuid) {
return ssStartIndex;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPage = (int) other.AttributeGet(IdPage);
ssStartIndex = (int) other.AttributeGet(IdStartIndex);
}
} // ST_28a47f2e64dd49f0d3d29e55f70be394Structure
/// <summary>
/// RecordList type <code>ListNavigationList</code> that represents a record list of
///  <code>ListNavigation</code>
/// </summary>
public partial class RL_584bbb33120a24b11c5b7440ce29b75f : GenericRecordList<ST_28a47f2e64dd49f0d3d29e55f70be394Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_28a47f2e64dd49f0d3d29e55f70be394Structure GetElementDefaultValue() {
return new ST_28a47f2e64dd49f0d3d29e55f70be394Structure();
}

public T[] ToArray<T>(Func<ST_28a47f2e64dd49f0d3d29e55f70be394Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_584bbb33120a24b11c5b7440ce29b75f recordList, Func<ST_28a47f2e64dd49f0d3d29e55f70be394Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_584bbb33120a24b11c5b7440ce29b75f(ST_28a47f2e64dd49f0d3d29e55f70be394Structure[] array) {
  RL_584bbb33120a24b11c5b7440ce29b75f result = new RL_584bbb33120a24b11c5b7440ce29b75f();
result.InnerFromArray(array);
    return result;
}

public static RL_584bbb33120a24b11c5b7440ce29b75f ToList<T>(T[] array, Func <T, ST_28a47f2e64dd49f0d3d29e55f70be394Structure> converter) {
  RL_584bbb33120a24b11c5b7440ce29b75f result = new RL_584bbb33120a24b11c5b7440ce29b75f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_584bbb33120a24b11c5b7440ce29b75f FromRestList<T>(RestList<T> restList, Func <T, ST_28a47f2e64dd49f0d3d29e55f70be394Structure> converter) {
  RL_584bbb33120a24b11c5b7440ce29b75f result = new RL_584bbb33120a24b11c5b7440ce29b75f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_584bbb33120a24b11c5b7440ce29b75f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_28a47f2e64dd49f0d3d29e55f70be394Structure> NewList() {
return new RL_584bbb33120a24b11c5b7440ce29b75f();
}


} // RL_584bbb33120a24b11c5b7440ce29b75f
}

