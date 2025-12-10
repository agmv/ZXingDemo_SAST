namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (TBcZMWfsREC2OlwkGUywCA)
///  <code>RC_8cdaa87184301dfa944cee1224e04604</code> that represent
/// s <code>DirectionOptionsRecord</code> <p>Description: </p>
/// </summary>
// Name: DirectionOptionsRecord
public partial struct RC_8cdaa87184301dfa944cee1224e04604 : ITypedRecord<RC_8cdaa87184301dfa944cee1224e04604> {
internal static readonly GlobalObjectKey IdDirectionOptions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cajajDCE+h2UTO4SJOBGBA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DirectionOptions")]
public ST_78b0cd1737b6725aac7ae45759769b93Structure ssSTDirectionOptions;


public static implicit operator ST_78b0cd1737b6725aac7ae45759769b93Structure( RC_8cdaa87184301dfa944cee1224e04604 r) {
return r.ssSTDirectionOptions;
}

public static implicit operator RC_8cdaa87184301dfa944cee1224e04604 (ST_78b0cd1737b6725aac7ae45759769b93Structure r) {
RC_8cdaa87184301dfa944cee1224e04604 res = new RC_8cdaa87184301dfa944cee1224e04604 ();
res.ssSTDirectionOptions = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8cdaa87184301dfa944cee1224e04604() {
OptimizedAttributes = null;
ssSTDirectionOptions = new ST_78b0cd1737b6725aac7ae45759769b93Structure();
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
    ssSTDirectionOptions.OptimizedAttributes = value[0];
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
ssSTDirectionOptions.Read( r, ref index);
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
public void ReadIM(RC_8cdaa87184301dfa944cee1224e04604 r) {
this = r;
}


public static bool operator == (RC_8cdaa87184301dfa944cee1224e04604 a, RC_8cdaa87184301dfa944cee1224e04604 b) {
if (a.ssSTDirectionOptions != b.ssSTDirectionOptions) return false;
return true;
}

public static bool operator != (RC_8cdaa87184301dfa944cee1224e04604 a, RC_8cdaa87184301dfa944cee1224e04604 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8cdaa87184301dfa944cee1224e04604)) return false;
return (this == (RC_8cdaa87184301dfa944cee1224e04604)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDirectionOptions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDirectionOptions.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDirectionOptions.InternalRecursiveSave();
}


public RC_8cdaa87184301dfa944cee1224e04604 Duplicate() {
RC_8cdaa87184301dfa944cee1224e04604 t;
t.ssSTDirectionOptions = (ST_78b0cd1737b6725aac7ae45759769b93Structure)this.ssSTDirectionOptions.Duplicate();
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
if (head == "directionoptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectionOptions")) variable.Value = ssSTDirectionOptions; else variable.Optimized = true;
variable.SetFieldName("directionoptions");
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
if (key == IdDirectionOptions) {
return ssSTDirectionOptions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirectionOptions.Key.AsGuid) {
return ssSTDirectionOptions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDirectionOptions.FillFromOther((IRecord) other.AttributeGet(IdDirectionOptions));
}
} // RC_8cdaa87184301dfa944cee1224e04604
/// <summary>
/// RecordList type <code>DirectionOptionsRecordList</code> that represents a record list of
///  <code>DirectionOptions</code>
/// </summary>
public partial class RL_3d74d9d326e1af4e0ef57c8e7b6106e5 : GenericRecordList<RC_8cdaa87184301dfa944cee1224e04604>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8cdaa87184301dfa944cee1224e04604 GetElementDefaultValue() {
return new RC_8cdaa87184301dfa944cee1224e04604();
}

public T[] ToArray<T>(Func<RC_8cdaa87184301dfa944cee1224e04604, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d74d9d326e1af4e0ef57c8e7b6106e5 recordList, Func<RC_8cdaa87184301dfa944cee1224e04604, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d74d9d326e1af4e0ef57c8e7b6106e5(RC_8cdaa87184301dfa944cee1224e04604[] array) {
  RL_3d74d9d326e1af4e0ef57c8e7b6106e5 result = new RL_3d74d9d326e1af4e0ef57c8e7b6106e5();
result.InnerFromArray(array);
    return result;
}

public static RL_3d74d9d326e1af4e0ef57c8e7b6106e5 ToList<T>(T[] array, Func <T, RC_8cdaa87184301dfa944cee1224e04604> converter) {
  RL_3d74d9d326e1af4e0ef57c8e7b6106e5 result = new RL_3d74d9d326e1af4e0ef57c8e7b6106e5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d74d9d326e1af4e0ef57c8e7b6106e5 FromRestList<T>(RestList<T> restList, Func <T, RC_8cdaa87184301dfa944cee1224e04604> converter) {
  RL_3d74d9d326e1af4e0ef57c8e7b6106e5 result = new RL_3d74d9d326e1af4e0ef57c8e7b6106e5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d74d9d326e1af4e0ef57c8e7b6106e5() : base() {
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
protected override OSList<RC_8cdaa87184301dfa944cee1224e04604> NewList() {
return new RL_3d74d9d326e1af4e0ef57c8e7b6106e5();
}


} // RL_3d74d9d326e1af4e0ef57c8e7b6106e5
}

