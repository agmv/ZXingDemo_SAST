namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (NSFU7uEM5E+E_NB1OmdZrQ)
///  <code>RC_ee9e4164abf6fbb75acecf37ce2b6aee</code> that represents <code>DirectionLegsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DirectionLegsRecord
public partial struct RC_ee9e4164abf6fbb75acecf37ce2b6aee : ITypedRecord<RC_ee9e4164abf6fbb75acecf37ce2b6aee> {
internal static readonly GlobalObjectKey IdDirectionLegs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZEGe7vart_tazs83zitq7g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DirectionLegs")]
public ST_2c6551904cfa95c93fa24da37b55d320Structure ssSTDirectionLegs;


public static implicit operator ST_2c6551904cfa95c93fa24da37b55d320Structure( RC_ee9e4164abf6fbb75acecf37ce2b6aee r) {
return r.ssSTDirectionLegs;
}

public static implicit operator RC_ee9e4164abf6fbb75acecf37ce2b6aee (ST_2c6551904cfa95c93fa24da37b55d320Structure r) {
RC_ee9e4164abf6fbb75acecf37ce2b6aee res = new RC_ee9e4164abf6fbb75acecf37ce2b6aee ();
res.ssSTDirectionLegs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ee9e4164abf6fbb75acecf37ce2b6aee() {
OptimizedAttributes = null;
ssSTDirectionLegs = new ST_2c6551904cfa95c93fa24da37b55d320Structure();
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
    ssSTDirectionLegs.OptimizedAttributes = value[0];
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
ssSTDirectionLegs.Read( r, ref index);
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
public void ReadIM(RC_ee9e4164abf6fbb75acecf37ce2b6aee r) {
this = r;
}


public static bool operator == (RC_ee9e4164abf6fbb75acecf37ce2b6aee a, RC_ee9e4164abf6fbb75acecf37ce2b6aee b) {
if (a.ssSTDirectionLegs != b.ssSTDirectionLegs) return false;
return true;
}

public static bool operator != (RC_ee9e4164abf6fbb75acecf37ce2b6aee a, RC_ee9e4164abf6fbb75acecf37ce2b6aee b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ee9e4164abf6fbb75acecf37ce2b6aee)) return false;
return (this == (RC_ee9e4164abf6fbb75acecf37ce2b6aee)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDirectionLegs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDirectionLegs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDirectionLegs.InternalRecursiveSave();
}


public RC_ee9e4164abf6fbb75acecf37ce2b6aee Duplicate() {
RC_ee9e4164abf6fbb75acecf37ce2b6aee t;
t.ssSTDirectionLegs = (ST_2c6551904cfa95c93fa24da37b55d320Structure)this.ssSTDirectionLegs.Duplicate();
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
if (head == "directionlegs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectionLegs")) variable.Value = ssSTDirectionLegs; else variable.Optimized = true;
variable.SetFieldName("directionlegs");
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
if (key == IdDirectionLegs) {
return ssSTDirectionLegs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirectionLegs.Key.AsGuid) {
return ssSTDirectionLegs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDirectionLegs.FillFromOther((IRecord) other.AttributeGet(IdDirectionLegs));
}
} // RC_ee9e4164abf6fbb75acecf37ce2b6aee
/// <summary>
/// RecordList type <code>DirectionLegsRecordList</code> that represents a record list of
///  <code>DirectionLegs</code>
/// </summary>
public partial class RL_4f4550c2ab239d2ba6872f9fe4fd88ec : GenericRecordList<RC_ee9e4164abf6fbb75acecf37ce2b6aee>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_ee9e4164abf6fbb75acecf37ce2b6aee GetElementDefaultValue() {
return new RC_ee9e4164abf6fbb75acecf37ce2b6aee();
}

public T[] ToArray<T>(Func<RC_ee9e4164abf6fbb75acecf37ce2b6aee, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4f4550c2ab239d2ba6872f9fe4fd88ec recordList, Func<RC_ee9e4164abf6fbb75acecf37ce2b6aee, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4f4550c2ab239d2ba6872f9fe4fd88ec(RC_ee9e4164abf6fbb75acecf37ce2b6aee[] array) {
  RL_4f4550c2ab239d2ba6872f9fe4fd88ec result = new RL_4f4550c2ab239d2ba6872f9fe4fd88ec();
result.InnerFromArray(array);
    return result;
}

public static RL_4f4550c2ab239d2ba6872f9fe4fd88ec ToList<T>(T[] array, Func <T, RC_ee9e4164abf6fbb75acecf37ce2b6aee> converter) {
  RL_4f4550c2ab239d2ba6872f9fe4fd88ec result = new RL_4f4550c2ab239d2ba6872f9fe4fd88ec();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4f4550c2ab239d2ba6872f9fe4fd88ec FromRestList<T>(RestList<T> restList, Func <T, RC_ee9e4164abf6fbb75acecf37ce2b6aee> converter) {
  RL_4f4550c2ab239d2ba6872f9fe4fd88ec result = new RL_4f4550c2ab239d2ba6872f9fe4fd88ec();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4f4550c2ab239d2ba6872f9fe4fd88ec() : base() {
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
protected override OSList<RC_ee9e4164abf6fbb75acecf37ce2b6aee> NewList() {
return new RL_4f4550c2ab239d2ba6872f9fe4fd88ec();
}


} // RL_4f4550c2ab239d2ba6872f9fe4fd88ec
}

