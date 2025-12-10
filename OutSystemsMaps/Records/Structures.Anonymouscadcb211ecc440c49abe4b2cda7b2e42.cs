namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (EbLcysTsxECavkss2nsuQg)
///  <code>RC_7511ee1a86159a139a2f21acdabfee5b</code> that represents <code>ReturnMessageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ReturnMessageRecord
public partial struct RC_7511ee1a86159a139a2f21acdabfee5b : ITypedRecord<RC_7511ee1a86159a139a2f21acdabfee5b> {
internal static readonly GlobalObjectKey IdReturnMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Gu4RdRWGE5qaLyGs2r_uWw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ReturnMessage")]
public ST_cdd94bc434e873b4d04598ac1e187543Structure ssSTReturnMessage;


public static implicit operator ST_cdd94bc434e873b4d04598ac1e187543Structure( RC_7511ee1a86159a139a2f21acdabfee5b r) {
return r.ssSTReturnMessage;
}

public static implicit operator RC_7511ee1a86159a139a2f21acdabfee5b (ST_cdd94bc434e873b4d04598ac1e187543Structure r) {
RC_7511ee1a86159a139a2f21acdabfee5b res = new RC_7511ee1a86159a139a2f21acdabfee5b ();
res.ssSTReturnMessage = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7511ee1a86159a139a2f21acdabfee5b() {
OptimizedAttributes = null;
ssSTReturnMessage = new ST_cdd94bc434e873b4d04598ac1e187543Structure();
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
    ssSTReturnMessage.OptimizedAttributes = value[0];
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
ssSTReturnMessage.Read( r, ref index);
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
public void ReadIM(RC_7511ee1a86159a139a2f21acdabfee5b r) {
this = r;
}


public static bool operator == (RC_7511ee1a86159a139a2f21acdabfee5b a, RC_7511ee1a86159a139a2f21acdabfee5b b) {
if (a.ssSTReturnMessage != b.ssSTReturnMessage) return false;
return true;
}

public static bool operator != (RC_7511ee1a86159a139a2f21acdabfee5b a, RC_7511ee1a86159a139a2f21acdabfee5b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7511ee1a86159a139a2f21acdabfee5b)) return false;
return (this == (RC_7511ee1a86159a139a2f21acdabfee5b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTReturnMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTReturnMessage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTReturnMessage.InternalRecursiveSave();
}


public RC_7511ee1a86159a139a2f21acdabfee5b Duplicate() {
RC_7511ee1a86159a139a2f21acdabfee5b t;
t.ssSTReturnMessage = (ST_cdd94bc434e873b4d04598ac1e187543Structure)this.ssSTReturnMessage.Duplicate();
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
if (head == "returnmessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReturnMessage")) variable.Value = ssSTReturnMessage; else variable.Optimized = true;
variable.SetFieldName("returnmessage");
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
if (key == IdReturnMessage) {
return ssSTReturnMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdReturnMessage.Key.AsGuid) {
return ssSTReturnMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTReturnMessage.FillFromOther((IRecord) other.AttributeGet(IdReturnMessage));
}
} // RC_7511ee1a86159a139a2f21acdabfee5b
/// <summary>
/// RecordList type <code>ReturnMessageRecordList</code> that represents a record list of
///  <code>ReturnMessage</code>
/// </summary>
public partial class RL_f8f20865cae1dc5bfcf574f1089add11 : GenericRecordList<RC_7511ee1a86159a139a2f21acdabfee5b>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7511ee1a86159a139a2f21acdabfee5b GetElementDefaultValue() {
return new RC_7511ee1a86159a139a2f21acdabfee5b();
}

public T[] ToArray<T>(Func<RC_7511ee1a86159a139a2f21acdabfee5b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f8f20865cae1dc5bfcf574f1089add11 recordList, Func<RC_7511ee1a86159a139a2f21acdabfee5b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f8f20865cae1dc5bfcf574f1089add11(RC_7511ee1a86159a139a2f21acdabfee5b[] array) {
  RL_f8f20865cae1dc5bfcf574f1089add11 result = new RL_f8f20865cae1dc5bfcf574f1089add11();
result.InnerFromArray(array);
    return result;
}

public static RL_f8f20865cae1dc5bfcf574f1089add11 ToList<T>(T[] array, Func <T, RC_7511ee1a86159a139a2f21acdabfee5b> converter) {
  RL_f8f20865cae1dc5bfcf574f1089add11 result = new RL_f8f20865cae1dc5bfcf574f1089add11();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f8f20865cae1dc5bfcf574f1089add11 FromRestList<T>(RestList<T> restList, Func <T, RC_7511ee1a86159a139a2f21acdabfee5b> converter) {
  RL_f8f20865cae1dc5bfcf574f1089add11 result = new RL_f8f20865cae1dc5bfcf574f1089add11();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f8f20865cae1dc5bfcf574f1089add11() : base() {
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
protected override OSList<RC_7511ee1a86159a139a2f21acdabfee5b> NewList() {
return new RL_f8f20865cae1dc5bfcf574f1089add11();
}


} // RL_f8f20865cae1dc5bfcf574f1089add11
}

