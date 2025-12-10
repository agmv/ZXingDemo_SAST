namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (8nKzHonm90ifoEKQaW67Jg)
///  <code>RC_967cb65710fd1a346ebf0b0d8dbea56b</code> that represent
/// s <code>StackedCardsPositionRecord</code> <p>Description: </p>
/// </summary>
// Name: StackedCardsPositionRecord
public partial struct RC_967cb65710fd1a346ebf0b0d8dbea56b : ITypedRecord<RC_967cb65710fd1a346ebf0b0d8dbea56b> {
internal static readonly GlobalObjectKey IdStackedCardsPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*V7Z8lv0QNBpuvwsNjb6law");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("StackedCardsPosition")]
public EN_92679525739afa328c09890d25f5ac45EntityRecord ssENStackedCardsPosition;


public static implicit operator EN_92679525739afa328c09890d25f5ac45EntityRecord( RC_967cb65710fd1a346ebf0b0d8dbea56b r) {
return r.ssENStackedCardsPosition;
}

public static implicit operator RC_967cb65710fd1a346ebf0b0d8dbea56b (EN_92679525739afa328c09890d25f5ac45EntityRecord r) {
RC_967cb65710fd1a346ebf0b0d8dbea56b res = new RC_967cb65710fd1a346ebf0b0d8dbea56b ();
res.ssENStackedCardsPosition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENStackedCardsPosition.ChangedAttributes = value;
}
get {
    return ssENStackedCardsPosition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_967cb65710fd1a346ebf0b0d8dbea56b() {
OptimizedAttributes = null;
ssENStackedCardsPosition = new EN_92679525739afa328c09890d25f5ac45EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENStackedCardsPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENStackedCardsPosition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENStackedCardsPosition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENStackedCardsPosition.Read( r, ref index);
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
public void ReadIM(RC_967cb65710fd1a346ebf0b0d8dbea56b r) {
this = r;
}


public static bool operator == (RC_967cb65710fd1a346ebf0b0d8dbea56b a, RC_967cb65710fd1a346ebf0b0d8dbea56b b) {
if (a.ssENStackedCardsPosition != b.ssENStackedCardsPosition) return false;
return true;
}

public static bool operator != (RC_967cb65710fd1a346ebf0b0d8dbea56b a, RC_967cb65710fd1a346ebf0b0d8dbea56b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_967cb65710fd1a346ebf0b0d8dbea56b)) return false;
return (this == (RC_967cb65710fd1a346ebf0b0d8dbea56b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENStackedCardsPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENStackedCardsPosition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENStackedCardsPosition.InternalRecursiveSave();
}


public RC_967cb65710fd1a346ebf0b0d8dbea56b Duplicate() {
RC_967cb65710fd1a346ebf0b0d8dbea56b t;
t.ssENStackedCardsPosition = (EN_92679525739afa328c09890d25f5ac45EntityRecord)this.ssENStackedCardsPosition.Duplicate();
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
if (head == "stackedcardsposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StackedCardsPosition")) variable.Value = ssENStackedCardsPosition; else variable.Optimized = true;
variable.SetFieldName("stackedcardsposition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENStackedCardsPosition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENStackedCardsPosition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdStackedCardsPosition) {
return ssENStackedCardsPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStackedCardsPosition.Key.AsGuid) {
return ssENStackedCardsPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENStackedCardsPosition.FillFromOther((IRecord) other.AttributeGet(IdStackedCardsPosition));
}
} // RC_967cb65710fd1a346ebf0b0d8dbea56b
/// <summary>
/// RecordList type <code>StackedCardsPositionRecordList</code> that represents a record list of
///  <code>StackedCardsPosition</code>
/// </summary>
public partial class RL_73c285d01c2c56407f6a3b6c7863f99b : GenericRecordList<RC_967cb65710fd1a346ebf0b0d8dbea56b>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_967cb65710fd1a346ebf0b0d8dbea56b GetElementDefaultValue() {
return new RC_967cb65710fd1a346ebf0b0d8dbea56b();
}

public T[] ToArray<T>(Func<RC_967cb65710fd1a346ebf0b0d8dbea56b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_73c285d01c2c56407f6a3b6c7863f99b recordList, Func<RC_967cb65710fd1a346ebf0b0d8dbea56b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_73c285d01c2c56407f6a3b6c7863f99b(RC_967cb65710fd1a346ebf0b0d8dbea56b[] array) {
  RL_73c285d01c2c56407f6a3b6c7863f99b result = new RL_73c285d01c2c56407f6a3b6c7863f99b();
result.InnerFromArray(array);
    return result;
}

public static RL_73c285d01c2c56407f6a3b6c7863f99b ToList<T>(T[] array, Func <T, RC_967cb65710fd1a346ebf0b0d8dbea56b> converter) {
  RL_73c285d01c2c56407f6a3b6c7863f99b result = new RL_73c285d01c2c56407f6a3b6c7863f99b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_73c285d01c2c56407f6a3b6c7863f99b FromRestList<T>(RestList<T> restList, Func <T, RC_967cb65710fd1a346ebf0b0d8dbea56b> converter) {
  RL_73c285d01c2c56407f6a3b6c7863f99b result = new RL_73c285d01c2c56407f6a3b6c7863f99b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_73c285d01c2c56407f6a3b6c7863f99b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_967cb65710fd1a346ebf0b0d8dbea56b> NewList() {
return new RL_73c285d01c2c56407f6a3b6c7863f99b();
}


} // RL_73c285d01c2c56407f6a3b6c7863f99b
}

