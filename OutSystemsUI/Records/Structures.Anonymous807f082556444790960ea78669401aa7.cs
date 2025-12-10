namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (JQh_gERWkEeWDqeGaUAapw)
///  <code>RC_de4b3bacd4ec5ee23880b64e848f90da</code> that represents <code>ReturnMessageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ReturnMessageRecord
public partial struct RC_de4b3bacd4ec5ee23880b64e848f90da : ITypedRecord<RC_de4b3bacd4ec5ee23880b64e848f90da> {
internal static readonly GlobalObjectKey IdReturnMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rDtL3uzU4l44gLZOhI+Q2g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ReturnMessage")]
public ST_13c131829a33cb5bedb5c64aa6f4add2Structure ssSTReturnMessage;


public static implicit operator ST_13c131829a33cb5bedb5c64aa6f4add2Structure( RC_de4b3bacd4ec5ee23880b64e848f90da r) {
return r.ssSTReturnMessage;
}

public static implicit operator RC_de4b3bacd4ec5ee23880b64e848f90da (ST_13c131829a33cb5bedb5c64aa6f4add2Structure r) {
RC_de4b3bacd4ec5ee23880b64e848f90da res = new RC_de4b3bacd4ec5ee23880b64e848f90da ();
res.ssSTReturnMessage = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_de4b3bacd4ec5ee23880b64e848f90da() {
OptimizedAttributes = null;
ssSTReturnMessage = new ST_13c131829a33cb5bedb5c64aa6f4add2Structure();
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
public void ReadIM(RC_de4b3bacd4ec5ee23880b64e848f90da r) {
this = r;
}


public static bool operator == (RC_de4b3bacd4ec5ee23880b64e848f90da a, RC_de4b3bacd4ec5ee23880b64e848f90da b) {
if (a.ssSTReturnMessage != b.ssSTReturnMessage) return false;
return true;
}

public static bool operator != (RC_de4b3bacd4ec5ee23880b64e848f90da a, RC_de4b3bacd4ec5ee23880b64e848f90da b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_de4b3bacd4ec5ee23880b64e848f90da)) return false;
return (this == (RC_de4b3bacd4ec5ee23880b64e848f90da)o);
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


public RC_de4b3bacd4ec5ee23880b64e848f90da Duplicate() {
RC_de4b3bacd4ec5ee23880b64e848f90da t;
t.ssSTReturnMessage = (ST_13c131829a33cb5bedb5c64aa6f4add2Structure)this.ssSTReturnMessage.Duplicate();
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
} // RC_de4b3bacd4ec5ee23880b64e848f90da
/// <summary>
/// RecordList type <code>ReturnMessageRecordList</code> that represents a record list of
///  <code>ReturnMessage</code>
/// </summary>
public partial class RL_7b51ea73c091c181cde3054c500bd942 : GenericRecordList<RC_de4b3bacd4ec5ee23880b64e848f90da>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_de4b3bacd4ec5ee23880b64e848f90da GetElementDefaultValue() {
return new RC_de4b3bacd4ec5ee23880b64e848f90da();
}

public T[] ToArray<T>(Func<RC_de4b3bacd4ec5ee23880b64e848f90da, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7b51ea73c091c181cde3054c500bd942 recordList, Func<RC_de4b3bacd4ec5ee23880b64e848f90da, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7b51ea73c091c181cde3054c500bd942(RC_de4b3bacd4ec5ee23880b64e848f90da[] array) {
  RL_7b51ea73c091c181cde3054c500bd942 result = new RL_7b51ea73c091c181cde3054c500bd942();
result.InnerFromArray(array);
    return result;
}

public static RL_7b51ea73c091c181cde3054c500bd942 ToList<T>(T[] array, Func <T, RC_de4b3bacd4ec5ee23880b64e848f90da> converter) {
  RL_7b51ea73c091c181cde3054c500bd942 result = new RL_7b51ea73c091c181cde3054c500bd942();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7b51ea73c091c181cde3054c500bd942 FromRestList<T>(RestList<T> restList, Func <T, RC_de4b3bacd4ec5ee23880b64e848f90da> converter) {
  RL_7b51ea73c091c181cde3054c500bd942 result = new RL_7b51ea73c091c181cde3054c500bd942();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7b51ea73c091c181cde3054c500bd942() : base() {
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
protected override OSList<RC_de4b3bacd4ec5ee23880b64e848f90da> NewList() {
return new RL_7b51ea73c091c181cde3054c500bd942();
}


} // RL_7b51ea73c091c181cde3054c500bd942
}

