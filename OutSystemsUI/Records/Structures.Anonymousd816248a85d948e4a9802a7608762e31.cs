namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (iiQW2NmF5EipgCp2CHYuMQ)
///  <code>RC_f332a0a4298f66d209888b6f5c56f633</code> that represents <code>RangeSliderTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RangeSliderTypeRecord
public partial struct RC_f332a0a4298f66d209888b6f5c56f633 : ITypedRecord<RC_f332a0a4298f66d209888b6f5c56f633> {
internal static readonly GlobalObjectKey IdRangeSliderType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pKAy848p0mYJiItvXFb2Mw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("RangeSliderType")]
public EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord ssENRangeSliderType;


public static implicit operator EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord( RC_f332a0a4298f66d209888b6f5c56f633 r) {
return r.ssENRangeSliderType;
}

public static implicit operator RC_f332a0a4298f66d209888b6f5c56f633 (EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord r) {
RC_f332a0a4298f66d209888b6f5c56f633 res = new RC_f332a0a4298f66d209888b6f5c56f633 ();
res.ssENRangeSliderType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRangeSliderType.ChangedAttributes = value;
}
get {
    return ssENRangeSliderType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f332a0a4298f66d209888b6f5c56f633() {
OptimizedAttributes = null;
ssENRangeSliderType = new EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRangeSliderType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRangeSliderType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRangeSliderType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRangeSliderType.Read( r, ref index);
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
public void ReadIM(RC_f332a0a4298f66d209888b6f5c56f633 r) {
this = r;
}


public static bool operator == (RC_f332a0a4298f66d209888b6f5c56f633 a, RC_f332a0a4298f66d209888b6f5c56f633 b) {
if (a.ssENRangeSliderType != b.ssENRangeSliderType) return false;
return true;
}

public static bool operator != (RC_f332a0a4298f66d209888b6f5c56f633 a, RC_f332a0a4298f66d209888b6f5c56f633 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f332a0a4298f66d209888b6f5c56f633)) return false;
return (this == (RC_f332a0a4298f66d209888b6f5c56f633)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRangeSliderType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRangeSliderType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRangeSliderType.InternalRecursiveSave();
}


public RC_f332a0a4298f66d209888b6f5c56f633 Duplicate() {
RC_f332a0a4298f66d209888b6f5c56f633 t;
t.ssENRangeSliderType = (EN_7e19f04989174b13ab8c3badf82f69b4EntityRecord)this.ssENRangeSliderType.Duplicate();
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
if (head == "rangeslidertype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RangeSliderType")) variable.Value = ssENRangeSliderType; else variable.Optimized = true;
variable.SetFieldName("rangeslidertype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRangeSliderType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRangeSliderType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRangeSliderType) {
return ssENRangeSliderType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRangeSliderType.Key.AsGuid) {
return ssENRangeSliderType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRangeSliderType.FillFromOther((IRecord) other.AttributeGet(IdRangeSliderType));
}
} // RC_f332a0a4298f66d209888b6f5c56f633
/// <summary>
/// RecordList type <code>RangeSliderTypeRecordList</code> that represents a record list of
///  <code>RangeSliderType</code>
/// </summary>
public partial class RL_d785cb35a227b6661ab0e0202fba3af9 : GenericRecordList<RC_f332a0a4298f66d209888b6f5c56f633>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f332a0a4298f66d209888b6f5c56f633 GetElementDefaultValue() {
return new RC_f332a0a4298f66d209888b6f5c56f633();
}

public T[] ToArray<T>(Func<RC_f332a0a4298f66d209888b6f5c56f633, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d785cb35a227b6661ab0e0202fba3af9 recordList, Func<RC_f332a0a4298f66d209888b6f5c56f633, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d785cb35a227b6661ab0e0202fba3af9(RC_f332a0a4298f66d209888b6f5c56f633[] array) {
  RL_d785cb35a227b6661ab0e0202fba3af9 result = new RL_d785cb35a227b6661ab0e0202fba3af9();
result.InnerFromArray(array);
    return result;
}

public static RL_d785cb35a227b6661ab0e0202fba3af9 ToList<T>(T[] array, Func <T, RC_f332a0a4298f66d209888b6f5c56f633> converter) {
  RL_d785cb35a227b6661ab0e0202fba3af9 result = new RL_d785cb35a227b6661ab0e0202fba3af9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d785cb35a227b6661ab0e0202fba3af9 FromRestList<T>(RestList<T> restList, Func <T, RC_f332a0a4298f66d209888b6f5c56f633> converter) {
  RL_d785cb35a227b6661ab0e0202fba3af9 result = new RL_d785cb35a227b6661ab0e0202fba3af9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d785cb35a227b6661ab0e0202fba3af9() : base() {
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
protected override OSList<RC_f332a0a4298f66d209888b6f5c56f633> NewList() {
return new RL_d785cb35a227b6661ab0e0202fba3af9();
}


} // RL_d785cb35a227b6661ab0e0202fba3af9
}

