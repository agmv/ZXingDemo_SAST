namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (ZGyL2XfMUk6ob_ivtizCRg)
///  <code>RC_e3355f6b7ba3051c4a4a9a00634d68d0</code> that represents <code>CoordinatesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CoordinatesRecord
public partial struct RC_e3355f6b7ba3051c4a4a9a00634d68d0 : ITypedRecord<RC_e3355f6b7ba3051c4a4a9a00634d68d0> {
internal static readonly GlobalObjectKey IdCoordinates = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a18146N7HAVKSpoAY01o0A");

[System.Xml.Serialization.XmlElement("Coordinates")]
public ST_0e474756a4be14d378c73cd05f602bcdStructure ssSTCoordinates;


public static implicit operator ST_0e474756a4be14d378c73cd05f602bcdStructure( RC_e3355f6b7ba3051c4a4a9a00634d68d0 r) {
return r.ssSTCoordinates;
}

public static implicit operator RC_e3355f6b7ba3051c4a4a9a00634d68d0 (ST_0e474756a4be14d378c73cd05f602bcdStructure r) {
RC_e3355f6b7ba3051c4a4a9a00634d68d0 res = new RC_e3355f6b7ba3051c4a4a9a00634d68d0 ();
res.ssSTCoordinates = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e3355f6b7ba3051c4a4a9a00634d68d0() {
OptimizedAttributes = null;
ssSTCoordinates = new ST_0e474756a4be14d378c73cd05f602bcdStructure();
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
    ssSTCoordinates.OptimizedAttributes = value[0];
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
ssSTCoordinates.Read( r, ref index);
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
public void ReadIM(RC_e3355f6b7ba3051c4a4a9a00634d68d0 r) {
this = r;
}


public static bool operator == (RC_e3355f6b7ba3051c4a4a9a00634d68d0 a, RC_e3355f6b7ba3051c4a4a9a00634d68d0 b) {
if (a.ssSTCoordinates != b.ssSTCoordinates) return false;
return true;
}

public static bool operator != (RC_e3355f6b7ba3051c4a4a9a00634d68d0 a, RC_e3355f6b7ba3051c4a4a9a00634d68d0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e3355f6b7ba3051c4a4a9a00634d68d0)) return false;
return (this == (RC_e3355f6b7ba3051c4a4a9a00634d68d0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCoordinates.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCoordinates.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCoordinates.InternalRecursiveSave();
}


public RC_e3355f6b7ba3051c4a4a9a00634d68d0 Duplicate() {
RC_e3355f6b7ba3051c4a4a9a00634d68d0 t;
t.ssSTCoordinates = (ST_0e474756a4be14d378c73cd05f602bcdStructure)this.ssSTCoordinates.Duplicate();
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
if (head == "coordinates") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Coordinates")) variable.Value = ssSTCoordinates; else variable.Optimized = true;
variable.SetFieldName("coordinates");
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
if (key == IdCoordinates) {
return ssSTCoordinates;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCoordinates.Key.AsGuid) {
return ssSTCoordinates;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCoordinates.FillFromOther((IRecord) other.AttributeGet(IdCoordinates));
}
} // RC_e3355f6b7ba3051c4a4a9a00634d68d0
/// <summary>
/// RecordList type <code>CoordinatesRecordList</code> that represents a record list of
///  <code>Coordinates</code>
/// </summary>
public partial class RL_55aa3adfaada82d015c1dcd249b8e8ce : GenericRecordList<RC_e3355f6b7ba3051c4a4a9a00634d68d0>, IEnumerable, IEnumerator {

protected override RC_e3355f6b7ba3051c4a4a9a00634d68d0 GetElementDefaultValue() {
return new RC_e3355f6b7ba3051c4a4a9a00634d68d0();
}

public T[] ToArray<T>(Func<RC_e3355f6b7ba3051c4a4a9a00634d68d0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_55aa3adfaada82d015c1dcd249b8e8ce recordList, Func<RC_e3355f6b7ba3051c4a4a9a00634d68d0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_55aa3adfaada82d015c1dcd249b8e8ce(RC_e3355f6b7ba3051c4a4a9a00634d68d0[] array) {
  RL_55aa3adfaada82d015c1dcd249b8e8ce result = new RL_55aa3adfaada82d015c1dcd249b8e8ce();
result.InnerFromArray(array);
    return result;
}

public static RL_55aa3adfaada82d015c1dcd249b8e8ce ToList<T>(T[] array, Func <T, RC_e3355f6b7ba3051c4a4a9a00634d68d0> converter) {
  RL_55aa3adfaada82d015c1dcd249b8e8ce result = new RL_55aa3adfaada82d015c1dcd249b8e8ce();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_55aa3adfaada82d015c1dcd249b8e8ce FromRestList<T>(RestList<T> restList, Func <T, RC_e3355f6b7ba3051c4a4a9a00634d68d0> converter) {
  RL_55aa3adfaada82d015c1dcd249b8e8ce result = new RL_55aa3adfaada82d015c1dcd249b8e8ce();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_55aa3adfaada82d015c1dcd249b8e8ce() : base() {
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
protected override OSList<RC_e3355f6b7ba3051c4a4a9a00634d68d0> NewList() {
return new RL_55aa3adfaada82d015c1dcd249b8e8ce();
}


} // RL_55aa3adfaada82d015c1dcd249b8e8ce
}

