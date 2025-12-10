namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (2gtRjlb3q0+eDZK41iiYMA)
///  <code>RC_63c659b6dc554b0b4f81d60382bf5fd6</code> that represents <code>MessageStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MessageStatusRecord
public partial struct RC_63c659b6dc554b0b4f81d60382bf5fd6 : ITypedRecord<RC_63c659b6dc554b0b4f81d60382bf5fd6> {
internal static readonly GlobalObjectKey IdMessageStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tlnGY1XcC0tPgdYDgr9f1g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MessageStatus")]
public EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord ssENMessageStatus;


public static implicit operator EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord( RC_63c659b6dc554b0b4f81d60382bf5fd6 r) {
return r.ssENMessageStatus;
}

public static implicit operator RC_63c659b6dc554b0b4f81d60382bf5fd6 (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord r) {
RC_63c659b6dc554b0b4f81d60382bf5fd6 res = new RC_63c659b6dc554b0b4f81d60382bf5fd6 ();
res.ssENMessageStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMessageStatus.ChangedAttributes = value;
}
get {
    return ssENMessageStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_63c659b6dc554b0b4f81d60382bf5fd6() {
OptimizedAttributes = null;
ssENMessageStatus = new EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMessageStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMessageStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMessageStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMessageStatus.Read( r, ref index);
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
public void ReadIM(RC_63c659b6dc554b0b4f81d60382bf5fd6 r) {
this = r;
}


public static bool operator == (RC_63c659b6dc554b0b4f81d60382bf5fd6 a, RC_63c659b6dc554b0b4f81d60382bf5fd6 b) {
if (a.ssENMessageStatus != b.ssENMessageStatus) return false;
return true;
}

public static bool operator != (RC_63c659b6dc554b0b4f81d60382bf5fd6 a, RC_63c659b6dc554b0b4f81d60382bf5fd6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_63c659b6dc554b0b4f81d60382bf5fd6)) return false;
return (this == (RC_63c659b6dc554b0b4f81d60382bf5fd6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMessageStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMessageStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMessageStatus.InternalRecursiveSave();
}


public RC_63c659b6dc554b0b4f81d60382bf5fd6 Duplicate() {
RC_63c659b6dc554b0b4f81d60382bf5fd6 t;
t.ssENMessageStatus = (EN_189b647ddc5c60c1aa5290bb6481a72dEntityRecord)this.ssENMessageStatus.Duplicate();
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
if (head == "messagestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MessageStatus")) variable.Value = ssENMessageStatus; else variable.Optimized = true;
variable.SetFieldName("messagestatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMessageStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMessageStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMessageStatus) {
return ssENMessageStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMessageStatus.Key.AsGuid) {
return ssENMessageStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMessageStatus.FillFromOther((IRecord) other.AttributeGet(IdMessageStatus));
}
} // RC_63c659b6dc554b0b4f81d60382bf5fd6
/// <summary>
/// RecordList type <code>MessageStatusRecordList</code> that represents a record list of
///  <code>MessageStatus</code>
/// </summary>
public partial class RL_2c7706a8fd91e45cb8a8b97418bcf4d0 : GenericRecordList<RC_63c659b6dc554b0b4f81d60382bf5fd6>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_63c659b6dc554b0b4f81d60382bf5fd6 GetElementDefaultValue() {
return new RC_63c659b6dc554b0b4f81d60382bf5fd6();
}

public T[] ToArray<T>(Func<RC_63c659b6dc554b0b4f81d60382bf5fd6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2c7706a8fd91e45cb8a8b97418bcf4d0 recordList, Func<RC_63c659b6dc554b0b4f81d60382bf5fd6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2c7706a8fd91e45cb8a8b97418bcf4d0(RC_63c659b6dc554b0b4f81d60382bf5fd6[] array) {
  RL_2c7706a8fd91e45cb8a8b97418bcf4d0 result = new RL_2c7706a8fd91e45cb8a8b97418bcf4d0();
result.InnerFromArray(array);
    return result;
}

public static RL_2c7706a8fd91e45cb8a8b97418bcf4d0 ToList<T>(T[] array, Func <T, RC_63c659b6dc554b0b4f81d60382bf5fd6> converter) {
  RL_2c7706a8fd91e45cb8a8b97418bcf4d0 result = new RL_2c7706a8fd91e45cb8a8b97418bcf4d0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2c7706a8fd91e45cb8a8b97418bcf4d0 FromRestList<T>(RestList<T> restList, Func <T, RC_63c659b6dc554b0b4f81d60382bf5fd6> converter) {
  RL_2c7706a8fd91e45cb8a8b97418bcf4d0 result = new RL_2c7706a8fd91e45cb8a8b97418bcf4d0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2c7706a8fd91e45cb8a8b97418bcf4d0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_63c659b6dc554b0b4f81d60382bf5fd6> NewList() {
return new RL_2c7706a8fd91e45cb8a8b97418bcf4d0();
}


} // RL_2c7706a8fd91e45cb8a8b97418bcf4d0
}

