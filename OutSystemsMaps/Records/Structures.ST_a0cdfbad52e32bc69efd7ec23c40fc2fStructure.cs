namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] IconSize (0K72Qk3W8UKfwN50QYd4Xw)
///  <code>ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure</code> that represents <code>IconSize</code
/// > <p>Description: Structure that helps defining the marker icon size.</p>
/// </summary>
// Name: IconSize
public partial struct ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure : ITypedRecord<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> {
internal static readonly GlobalObjectKey IdWidth = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nqOjQtygLEC6df2OKWLy1g");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*XBfLD_fTk0mXiU3IC1PRwg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Width")]
public int ssWidth;

[System.Xml.Serialization.XmlElement("Height")]
public int ssHeight;


public BitArray OptimizedAttributes;

public ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure() {
OptimizedAttributes = null;
ssWidth = 0;
ssHeight = 0;
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
ssWidth = r.ReadInteger(index++, "IconSize.Width", 0);
ssHeight = r.ReadInteger(index++, "IconSize.Height", 0);
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
public void ReadIM(ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure r) {
this = r;
}


public static bool operator == (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure a, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure b) {
if (a.ssWidth != b.ssWidth) return false;
if (a.ssHeight != b.ssHeight) return false;
return true;
}

public static bool operator != (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure a, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure)) return false;
return (this == (ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssWidth.GetHashCode()
 ^ ssHeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure Duplicate() {
ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure t;
t.ssWidth = this.ssWidth;
t.ssHeight = this.ssHeight;
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
if (head == "width") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Width")) variable.Value = ssWidth; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
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
if (key == IdWidth) {
return ssWidth;
}
if (key == IdHeight) {
return ssHeight;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWidth.Key.AsGuid) {
return ssWidth;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssWidth = (int) other.AttributeGet(IdWidth);
ssHeight = (int) other.AttributeGet(IdHeight);
}
} // ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure
/// <summary>
/// RecordList type <code>IconSizeList</code> that represents a record list of <code>IconSize</code>
/// </summary>
public partial class RL_41f69bc5f164eef25227510b7af86bed : GenericRecordList<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure GetElementDefaultValue() {
return new ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure();
}

public T[] ToArray<T>(Func<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_41f69bc5f164eef25227510b7af86bed recordList, Func<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_41f69bc5f164eef25227510b7af86bed(ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure[] array) {
  RL_41f69bc5f164eef25227510b7af86bed result = new RL_41f69bc5f164eef25227510b7af86bed();
result.InnerFromArray(array);
    return result;
}

public static RL_41f69bc5f164eef25227510b7af86bed ToList<T>(T[] array, Func <T, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> converter) {
  RL_41f69bc5f164eef25227510b7af86bed result = new RL_41f69bc5f164eef25227510b7af86bed();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_41f69bc5f164eef25227510b7af86bed FromRestList<T>(RestList<T> restList, Func <T, ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> converter) {
  RL_41f69bc5f164eef25227510b7af86bed result = new RL_41f69bc5f164eef25227510b7af86bed();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_41f69bc5f164eef25227510b7af86bed() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a0cdfbad52e32bc69efd7ec23c40fc2fStructure> NewList() {
return new RL_41f69bc5f164eef25227510b7af86bed();
}


} // RL_41f69bc5f164eef25227510b7af86bed
}

