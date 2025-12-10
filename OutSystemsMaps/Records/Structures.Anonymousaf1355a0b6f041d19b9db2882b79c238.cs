namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (oFUTr_C20UGbnbKIK3nCOA)
///  <code>RC_a4e8f80d0a21edea3a71318677a15130</code> that represents <code>CircleShapeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CircleShapeRecord
public partial struct RC_a4e8f80d0a21edea3a71318677a15130 : ITypedRecord<RC_a4e8f80d0a21edea3a71318677a15130> {
internal static readonly GlobalObjectKey IdCircleShape = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DfjopCEK6u06cTGGd6FRMA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("CircleShape")]
public ST_7e9e7e47a56960855c31bd37116d68abStructure ssSTCircleShape;


public static implicit operator ST_7e9e7e47a56960855c31bd37116d68abStructure( RC_a4e8f80d0a21edea3a71318677a15130 r) {
return r.ssSTCircleShape;
}

public static implicit operator RC_a4e8f80d0a21edea3a71318677a15130 (ST_7e9e7e47a56960855c31bd37116d68abStructure r) {
RC_a4e8f80d0a21edea3a71318677a15130 res = new RC_a4e8f80d0a21edea3a71318677a15130 ();
res.ssSTCircleShape = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a4e8f80d0a21edea3a71318677a15130() {
OptimizedAttributes = null;
ssSTCircleShape = new ST_7e9e7e47a56960855c31bd37116d68abStructure();
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
    ssSTCircleShape.OptimizedAttributes = value[0];
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
ssSTCircleShape.Read( r, ref index);
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
public void ReadIM(RC_a4e8f80d0a21edea3a71318677a15130 r) {
this = r;
}


public static bool operator == (RC_a4e8f80d0a21edea3a71318677a15130 a, RC_a4e8f80d0a21edea3a71318677a15130 b) {
if (a.ssSTCircleShape != b.ssSTCircleShape) return false;
return true;
}

public static bool operator != (RC_a4e8f80d0a21edea3a71318677a15130 a, RC_a4e8f80d0a21edea3a71318677a15130 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a4e8f80d0a21edea3a71318677a15130)) return false;
return (this == (RC_a4e8f80d0a21edea3a71318677a15130)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCircleShape.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCircleShape.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCircleShape.InternalRecursiveSave();
}


public RC_a4e8f80d0a21edea3a71318677a15130 Duplicate() {
RC_a4e8f80d0a21edea3a71318677a15130 t;
t.ssSTCircleShape = (ST_7e9e7e47a56960855c31bd37116d68abStructure)this.ssSTCircleShape.Duplicate();
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
if (head == "circleshape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CircleShape")) variable.Value = ssSTCircleShape; else variable.Optimized = true;
variable.SetFieldName("circleshape");
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
if (key == IdCircleShape) {
return ssSTCircleShape;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCircleShape.Key.AsGuid) {
return ssSTCircleShape;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCircleShape.FillFromOther((IRecord) other.AttributeGet(IdCircleShape));
}
} // RC_a4e8f80d0a21edea3a71318677a15130
/// <summary>
/// RecordList type <code>CircleShapeRecordList</code> that represents a record list of
///  <code>CircleShape</code>
/// </summary>
public partial class RL_e49abea873c895e5d77d216c9c1ed16d : GenericRecordList<RC_a4e8f80d0a21edea3a71318677a15130>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a4e8f80d0a21edea3a71318677a15130 GetElementDefaultValue() {
return new RC_a4e8f80d0a21edea3a71318677a15130();
}

public T[] ToArray<T>(Func<RC_a4e8f80d0a21edea3a71318677a15130, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e49abea873c895e5d77d216c9c1ed16d recordList, Func<RC_a4e8f80d0a21edea3a71318677a15130, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e49abea873c895e5d77d216c9c1ed16d(RC_a4e8f80d0a21edea3a71318677a15130[] array) {
  RL_e49abea873c895e5d77d216c9c1ed16d result = new RL_e49abea873c895e5d77d216c9c1ed16d();
result.InnerFromArray(array);
    return result;
}

public static RL_e49abea873c895e5d77d216c9c1ed16d ToList<T>(T[] array, Func <T, RC_a4e8f80d0a21edea3a71318677a15130> converter) {
  RL_e49abea873c895e5d77d216c9c1ed16d result = new RL_e49abea873c895e5d77d216c9c1ed16d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e49abea873c895e5d77d216c9c1ed16d FromRestList<T>(RestList<T> restList, Func <T, RC_a4e8f80d0a21edea3a71318677a15130> converter) {
  RL_e49abea873c895e5d77d216c9c1ed16d result = new RL_e49abea873c895e5d77d216c9c1ed16d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e49abea873c895e5d77d216c9c1ed16d() : base() {
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
protected override OSList<RC_a4e8f80d0a21edea3a71318677a15130> NewList() {
return new RL_e49abea873c895e5d77d216c9c1ed16d();
}


} // RL_e49abea873c895e5d77d216c9c1ed16d
}

