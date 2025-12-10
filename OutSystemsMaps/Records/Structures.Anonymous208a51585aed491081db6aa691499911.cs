namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (WFGKIO1aEEmB22qmkUmZEQ)
///  <code>RC_098b5b5f4bf19fe0ddbe136503d3bd5a</code> that represents <code>ErrorMessageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ErrorMessageRecord
public partial struct RC_098b5b5f4bf19fe0ddbe136503d3bd5a : ITypedRecord<RC_098b5b5f4bf19fe0ddbe136503d3bd5a> {
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*X1uLCfFL4J_dvhNlA9O9Wg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ErrorMessage")]
public ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure ssSTErrorMessage;


public static implicit operator ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure( RC_098b5b5f4bf19fe0ddbe136503d3bd5a r) {
return r.ssSTErrorMessage;
}

public static implicit operator RC_098b5b5f4bf19fe0ddbe136503d3bd5a (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure r) {
RC_098b5b5f4bf19fe0ddbe136503d3bd5a res = new RC_098b5b5f4bf19fe0ddbe136503d3bd5a ();
res.ssSTErrorMessage = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_098b5b5f4bf19fe0ddbe136503d3bd5a() {
OptimizedAttributes = null;
ssSTErrorMessage = new ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure();
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
    ssSTErrorMessage.OptimizedAttributes = value[0];
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
ssSTErrorMessage.Read( r, ref index);
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
public void ReadIM(RC_098b5b5f4bf19fe0ddbe136503d3bd5a r) {
this = r;
}


public static bool operator == (RC_098b5b5f4bf19fe0ddbe136503d3bd5a a, RC_098b5b5f4bf19fe0ddbe136503d3bd5a b) {
if (a.ssSTErrorMessage != b.ssSTErrorMessage) return false;
return true;
}

public static bool operator != (RC_098b5b5f4bf19fe0ddbe136503d3bd5a a, RC_098b5b5f4bf19fe0ddbe136503d3bd5a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_098b5b5f4bf19fe0ddbe136503d3bd5a)) return false;
return (this == (RC_098b5b5f4bf19fe0ddbe136503d3bd5a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTErrorMessage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTErrorMessage.InternalRecursiveSave();
}


public RC_098b5b5f4bf19fe0ddbe136503d3bd5a Duplicate() {
RC_098b5b5f4bf19fe0ddbe136503d3bd5a t;
t.ssSTErrorMessage = (ST_f8c2d1b69d03ea90c73e9f07e7d98bf0Structure)this.ssSTErrorMessage.Duplicate();
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
if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssSTErrorMessage; else variable.Optimized = true;
variable.SetFieldName("errormessage");
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
if (key == IdErrorMessage) {
return ssSTErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssSTErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTErrorMessage.FillFromOther((IRecord) other.AttributeGet(IdErrorMessage));
}
} // RC_098b5b5f4bf19fe0ddbe136503d3bd5a
/// <summary>
/// RecordList type <code>ErrorMessageRecordList</code> that represents a record list of
///  <code>ErrorMessage</code>
/// </summary>
public partial class RL_08e6ffa61762e97d642011e69cfed7f8 : GenericRecordList<RC_098b5b5f4bf19fe0ddbe136503d3bd5a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_098b5b5f4bf19fe0ddbe136503d3bd5a GetElementDefaultValue() {
return new RC_098b5b5f4bf19fe0ddbe136503d3bd5a();
}

public T[] ToArray<T>(Func<RC_098b5b5f4bf19fe0ddbe136503d3bd5a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_08e6ffa61762e97d642011e69cfed7f8 recordList, Func<RC_098b5b5f4bf19fe0ddbe136503d3bd5a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_08e6ffa61762e97d642011e69cfed7f8(RC_098b5b5f4bf19fe0ddbe136503d3bd5a[] array) {
  RL_08e6ffa61762e97d642011e69cfed7f8 result = new RL_08e6ffa61762e97d642011e69cfed7f8();
result.InnerFromArray(array);
    return result;
}

public static RL_08e6ffa61762e97d642011e69cfed7f8 ToList<T>(T[] array, Func <T, RC_098b5b5f4bf19fe0ddbe136503d3bd5a> converter) {
  RL_08e6ffa61762e97d642011e69cfed7f8 result = new RL_08e6ffa61762e97d642011e69cfed7f8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_08e6ffa61762e97d642011e69cfed7f8 FromRestList<T>(RestList<T> restList, Func <T, RC_098b5b5f4bf19fe0ddbe136503d3bd5a> converter) {
  RL_08e6ffa61762e97d642011e69cfed7f8 result = new RL_08e6ffa61762e97d642011e69cfed7f8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_08e6ffa61762e97d642011e69cfed7f8() : base() {
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
protected override OSList<RC_098b5b5f4bf19fe0ddbe136503d3bd5a> NewList() {
return new RL_08e6ffa61762e97d642011e69cfed7f8();
}


} // RL_08e6ffa61762e97d642011e69cfed7f8
}

