using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] Month (JLfZM7GgCkuR+ychQ8RKhQ)
///  <code>EN_5be8b31925746693c09b3f64c4898006EntityRecord</code> that represents <code>Month</code
/// > <p>Description: Contains the list of available months.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Month","JLfZM7GgCkuR+ychQ8RKhQ","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: Month
public partial struct EN_5be8b31925746693c09b3f64c4898006EntityRecord : ITypedRecord<EN_5be8b31925746693c09b3f64c4898006EntityRecord> {
internal static readonly GlobalObjectKey IdMonth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*nmbSsN5aEk6o+kpas6Yfdw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*g3erSsRYHEm1Gi0HKqB4PQ");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MONTH",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Month")]
private string _ssMonth;
public string ssMonth{
  get{
      return _ssMonth;
  }
  set{
      if((_ssMonth!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssMonth = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ORDER",0,false,false,false,true)]
[System.Xml.Serialization.XmlElement("Order")]
private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrder = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5be8b31925746693c09b3f64c4898006EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssMonth = "";
_ssOrder = 0;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssMonth = r.ReadText(index++, "Month.Month", "");
ssOrder = r.ReadInteger(index++, "Month.Order", 0);
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(EN_5be8b31925746693c09b3f64c4898006EntityRecord r) {
this = r;
}


public static bool operator == (EN_5be8b31925746693c09b3f64c4898006EntityRecord a, EN_5be8b31925746693c09b3f64c4898006EntityRecord b) {
if (a.ssMonth != b.ssMonth) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_5be8b31925746693c09b3f64c4898006EntityRecord a, EN_5be8b31925746693c09b3f64c4898006EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5be8b31925746693c09b3f64c4898006EntityRecord)) return false;
return (this == (EN_5be8b31925746693c09b3f64c4898006EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssMonth.GetHashCode()
 ^ ssOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5be8b31925746693c09b3f64c4898006EntityRecord Duplicate() {
EN_5be8b31925746693c09b3f64c4898006EntityRecord t;
t._ssMonth = this._ssMonth;
t._ssOrder = this._ssOrder;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "month") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Month")) variable.Value = ssMonth; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdMonth)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdMonth)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMonth) {
return ssMonth;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMonth.Key.AsGuid) {
return ssMonth;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssMonth = (string) other.AttributeGet(IdMonth);
ChangedAttributes[0] = other.ChangedAttributeGet(IdMonth);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMonth);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_5be8b31925746693c09b3f64c4898006EntityRecord

/// <summary>
/// RecordList type <code>MonthList</code> that represents a record list of <code>Month</code>
/// </summary>
public partial class RL_f90829e8248d7dd911b648b9522ef82a : GenericRecordList<EN_5be8b31925746693c09b3f64c4898006EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_5be8b31925746693c09b3f64c4898006EntityRecord GetElementDefaultValue() {
return new EN_5be8b31925746693c09b3f64c4898006EntityRecord();
}

public T[] ToArray<T>(Func<EN_5be8b31925746693c09b3f64c4898006EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f90829e8248d7dd911b648b9522ef82a recordList, Func<EN_5be8b31925746693c09b3f64c4898006EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f90829e8248d7dd911b648b9522ef82a(EN_5be8b31925746693c09b3f64c4898006EntityRecord[] array) {
  RL_f90829e8248d7dd911b648b9522ef82a result = new RL_f90829e8248d7dd911b648b9522ef82a();
result.InnerFromArray(array);
    return result;
}

public static RL_f90829e8248d7dd911b648b9522ef82a ToList<T>(T[] array, Func <T, EN_5be8b31925746693c09b3f64c4898006EntityRecord> converter) {
  RL_f90829e8248d7dd911b648b9522ef82a result = new RL_f90829e8248d7dd911b648b9522ef82a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f90829e8248d7dd911b648b9522ef82a FromRestList<T>(RestList<T> restList, Func <T, EN_5be8b31925746693c09b3f64c4898006EntityRecord> converter) {
  RL_f90829e8248d7dd911b648b9522ef82a result = new RL_f90829e8248d7dd911b648b9522ef82a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f90829e8248d7dd911b648b9522ef82a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5be8b31925746693c09b3f64c4898006EntityRecord> NewList() {
return new RL_f90829e8248d7dd911b648b9522ef82a();
}


} // RL_f90829e8248d7dd911b648b9522ef82a
}
