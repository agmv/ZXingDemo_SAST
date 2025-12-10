namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (lDsE8gvEvkyyg1gE6vafLw)
///  <code>RC_80e81fddca0089d3f29f81106c0bee34</code> that represents <code>ZoomRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ZoomRecord
public partial struct RC_80e81fddca0089d3f29f81106c0bee34 : ITypedRecord<RC_80e81fddca0089d3f29f81106c0bee34> {
internal static readonly GlobalObjectKey IdZoom = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3R_ogADK04nyn4EQbAvuNA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Zoom")]
public EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord ssENZoom;


public static implicit operator EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord( RC_80e81fddca0089d3f29f81106c0bee34 r) {
return r.ssENZoom;
}

public static implicit operator RC_80e81fddca0089d3f29f81106c0bee34 (EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord r) {
RC_80e81fddca0089d3f29f81106c0bee34 res = new RC_80e81fddca0089d3f29f81106c0bee34 ();
res.ssENZoom = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENZoom.ChangedAttributes = value;
}
get {
    return ssENZoom.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_80e81fddca0089d3f29f81106c0bee34() {
OptimizedAttributes = null;
ssENZoom = new EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENZoom.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENZoom.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENZoom.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENZoom.Read( r, ref index);
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
public void ReadIM(RC_80e81fddca0089d3f29f81106c0bee34 r) {
this = r;
}


public static bool operator == (RC_80e81fddca0089d3f29f81106c0bee34 a, RC_80e81fddca0089d3f29f81106c0bee34 b) {
if (a.ssENZoom != b.ssENZoom) return false;
return true;
}

public static bool operator != (RC_80e81fddca0089d3f29f81106c0bee34 a, RC_80e81fddca0089d3f29f81106c0bee34 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_80e81fddca0089d3f29f81106c0bee34)) return false;
return (this == (RC_80e81fddca0089d3f29f81106c0bee34)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENZoom.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENZoom.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENZoom.InternalRecursiveSave();
}


public RC_80e81fddca0089d3f29f81106c0bee34 Duplicate() {
RC_80e81fddca0089d3f29f81106c0bee34 t;
t.ssENZoom = (EN_480235a969b3f42eac91ad5813fe9bf9EntityRecord)this.ssENZoom.Duplicate();
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
if (head == "zoom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Zoom")) variable.Value = ssENZoom; else variable.Optimized = true;
variable.SetFieldName("zoom");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENZoom.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENZoom.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdZoom) {
return ssENZoom;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZoom.Key.AsGuid) {
return ssENZoom;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENZoom.FillFromOther((IRecord) other.AttributeGet(IdZoom));
}
} // RC_80e81fddca0089d3f29f81106c0bee34
/// <summary>
/// RecordList type <code>ZoomRecordList</code> that represents a record list of <code>Zoom</code>
/// </summary>
public partial class RL_cc2748e8dc663faa1bc70171492e8ff9 : GenericRecordList<RC_80e81fddca0089d3f29f81106c0bee34>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_80e81fddca0089d3f29f81106c0bee34 GetElementDefaultValue() {
return new RC_80e81fddca0089d3f29f81106c0bee34();
}

public T[] ToArray<T>(Func<RC_80e81fddca0089d3f29f81106c0bee34, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cc2748e8dc663faa1bc70171492e8ff9 recordList, Func<RC_80e81fddca0089d3f29f81106c0bee34, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cc2748e8dc663faa1bc70171492e8ff9(RC_80e81fddca0089d3f29f81106c0bee34[] array) {
  RL_cc2748e8dc663faa1bc70171492e8ff9 result = new RL_cc2748e8dc663faa1bc70171492e8ff9();
result.InnerFromArray(array);
    return result;
}

public static RL_cc2748e8dc663faa1bc70171492e8ff9 ToList<T>(T[] array, Func <T, RC_80e81fddca0089d3f29f81106c0bee34> converter) {
  RL_cc2748e8dc663faa1bc70171492e8ff9 result = new RL_cc2748e8dc663faa1bc70171492e8ff9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cc2748e8dc663faa1bc70171492e8ff9 FromRestList<T>(RestList<T> restList, Func <T, RC_80e81fddca0089d3f29f81106c0bee34> converter) {
  RL_cc2748e8dc663faa1bc70171492e8ff9 result = new RL_cc2748e8dc663faa1bc70171492e8ff9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cc2748e8dc663faa1bc70171492e8ff9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_80e81fddca0089d3f29f81106c0bee34> NewList() {
return new RL_cc2748e8dc663faa1bc70171492e8ff9();
}


} // RL_cc2748e8dc663faa1bc70171492e8ff9
}

