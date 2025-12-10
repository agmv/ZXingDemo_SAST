namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (_rVQn6vmpUiiz6TpbbvUjw)
///  <code>RC_b1f70cd6a745b5879d66249a8c483fef</code> that represent
/// s <code>FlipContent_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: FlipContent_InternalConfigRecord
public partial struct RC_b1f70cd6a745b5879d66249a8c483fef : ITypedRecord<RC_b1f70cd6a745b5879d66249a8c483fef> {
internal static readonly GlobalObjectKey IdFlipContent_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1gz3sUWnh7WdZiSajEg_7w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FlipContent_InternalConfig")]
public ST_e828cdbd51e0c1ef095bd323f6e2875aStructure ssSTFlipContent_InternalConfig;


public static implicit operator ST_e828cdbd51e0c1ef095bd323f6e2875aStructure( RC_b1f70cd6a745b5879d66249a8c483fef r) {
return r.ssSTFlipContent_InternalConfig;
}

public static implicit operator RC_b1f70cd6a745b5879d66249a8c483fef (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure r) {
RC_b1f70cd6a745b5879d66249a8c483fef res = new RC_b1f70cd6a745b5879d66249a8c483fef ();
res.ssSTFlipContent_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b1f70cd6a745b5879d66249a8c483fef() {
OptimizedAttributes = null;
ssSTFlipContent_InternalConfig = new ST_e828cdbd51e0c1ef095bd323f6e2875aStructure();
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
    ssSTFlipContent_InternalConfig.OptimizedAttributes = value[0];
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
ssSTFlipContent_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_b1f70cd6a745b5879d66249a8c483fef r) {
this = r;
}


public static bool operator == (RC_b1f70cd6a745b5879d66249a8c483fef a, RC_b1f70cd6a745b5879d66249a8c483fef b) {
if (a.ssSTFlipContent_InternalConfig != b.ssSTFlipContent_InternalConfig) return false;
return true;
}

public static bool operator != (RC_b1f70cd6a745b5879d66249a8c483fef a, RC_b1f70cd6a745b5879d66249a8c483fef b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b1f70cd6a745b5879d66249a8c483fef)) return false;
return (this == (RC_b1f70cd6a745b5879d66249a8c483fef)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFlipContent_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFlipContent_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFlipContent_InternalConfig.InternalRecursiveSave();
}


public RC_b1f70cd6a745b5879d66249a8c483fef Duplicate() {
RC_b1f70cd6a745b5879d66249a8c483fef t;
t.ssSTFlipContent_InternalConfig = (ST_e828cdbd51e0c1ef095bd323f6e2875aStructure)this.ssSTFlipContent_InternalConfig.Duplicate();
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
if (head == "flipcontent_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FlipContent_InternalConfig")) variable.Value = ssSTFlipContent_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("flipcontent_internalconfig");
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
if (key == IdFlipContent_InternalConfig) {
return ssSTFlipContent_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFlipContent_InternalConfig.Key.AsGuid) {
return ssSTFlipContent_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFlipContent_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdFlipContent_InternalConfig));
}
} // RC_b1f70cd6a745b5879d66249a8c483fef
/// <summary>
/// RecordList type <code>FlipContent_InternalConfigRecordList</code> that represents a record list of
///  <code>FlipContent_InternalConfig</code>
/// </summary>
public partial class RL_fbb2b7534faa0da2d8fb2745cf7ef411 : GenericRecordList<RC_b1f70cd6a745b5879d66249a8c483fef>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_b1f70cd6a745b5879d66249a8c483fef GetElementDefaultValue() {
return new RC_b1f70cd6a745b5879d66249a8c483fef();
}

public T[] ToArray<T>(Func<RC_b1f70cd6a745b5879d66249a8c483fef, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fbb2b7534faa0da2d8fb2745cf7ef411 recordList, Func<RC_b1f70cd6a745b5879d66249a8c483fef, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fbb2b7534faa0da2d8fb2745cf7ef411(RC_b1f70cd6a745b5879d66249a8c483fef[] array) {
  RL_fbb2b7534faa0da2d8fb2745cf7ef411 result = new RL_fbb2b7534faa0da2d8fb2745cf7ef411();
result.InnerFromArray(array);
    return result;
}

public static RL_fbb2b7534faa0da2d8fb2745cf7ef411 ToList<T>(T[] array, Func <T, RC_b1f70cd6a745b5879d66249a8c483fef> converter) {
  RL_fbb2b7534faa0da2d8fb2745cf7ef411 result = new RL_fbb2b7534faa0da2d8fb2745cf7ef411();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fbb2b7534faa0da2d8fb2745cf7ef411 FromRestList<T>(RestList<T> restList, Func <T, RC_b1f70cd6a745b5879d66249a8c483fef> converter) {
  RL_fbb2b7534faa0da2d8fb2745cf7ef411 result = new RL_fbb2b7534faa0da2d8fb2745cf7ef411();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fbb2b7534faa0da2d8fb2745cf7ef411() : base() {
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
protected override OSList<RC_b1f70cd6a745b5879d66249a8c483fef> NewList() {
return new RL_fbb2b7534faa0da2d8fb2745cf7ef411();
}


} // RL_fbb2b7534faa0da2d8fb2745cf7ef411
}

