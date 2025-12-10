namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] Metadata (i6oh1BqmKUCLzJSJQBmprA)
///  <code>ST_a1f7d5fa968628cf9ed1d90efadf9506Structure</code> that represents <code>Metadata</code
/// > <p>Description: Barcode metadata</p>
/// </summary>
// Name: Metadata
public partial struct ST_a1f7d5fa968628cf9ed1d90efadf9506Structure : ITypedRecord<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey Idkey = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*uX1U0KbP1u5WXNm93HqsNg");
internal static readonly GlobalObjectKey Idvalue = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*h47Wt+lPglIT1BoJn1il7A");

[System.Xml.Serialization.XmlElement("key")]
public string sskey;

[System.Xml.Serialization.XmlElement("value")]
public string ssvalue;


public BitArray OptimizedAttributes;

public ST_a1f7d5fa968628cf9ed1d90efadf9506Structure() {
OptimizedAttributes = null;
sskey = "";
ssvalue = "";
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
sskey = r.ReadText(index++, "Metadata.key", "");
ssvalue = r.ReadText(index++, "Metadata.value", "");
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
public void ReadIM(ST_a1f7d5fa968628cf9ed1d90efadf9506Structure r) {
this = r;
}


public static bool operator == (ST_a1f7d5fa968628cf9ed1d90efadf9506Structure a, ST_a1f7d5fa968628cf9ed1d90efadf9506Structure b) {
if (a.sskey != b.sskey) return false;
if (a.ssvalue != b.ssvalue) return false;
return true;
}

public static bool operator != (ST_a1f7d5fa968628cf9ed1d90efadf9506Structure a, ST_a1f7d5fa968628cf9ed1d90efadf9506Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a1f7d5fa968628cf9ed1d90efadf9506Structure)) return false;
return (this == (ST_a1f7d5fa968628cf9ed1d90efadf9506Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sskey.GetHashCode()
 ^ ssvalue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a1f7d5fa968628cf9ed1d90efadf9506Structure Duplicate() {
ST_a1f7d5fa968628cf9ed1d90efadf9506Structure t;
t.sskey = this.sskey;
t.ssvalue = this.ssvalue;
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
if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".key")) variable.Value = sskey; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".value")) variable.Value = ssvalue; else variable.Optimized = true;
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
if (key == Idkey) {
return sskey;
}
if (key == Idvalue) {
return ssvalue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idkey.Key.AsGuid) {
return sskey;
}
if (attributeKey == Idvalue.Key.AsGuid) {
return ssvalue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
sskey = (string) other.AttributeGet(Idkey);
ssvalue = (string) other.AttributeGet(Idvalue);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
sskey = (string) other.GetAttribute(Idkey.Key.AsGuid);
ssvalue = (string) other.GetAttribute(Idvalue.Key.AsGuid);
}
} // ST_a1f7d5fa968628cf9ed1d90efadf9506Structure
/// <summary>
/// RecordList type <code>MetadataList</code> that represents a record list of <code>Metadata</code>
/// </summary>
public partial class RL_7919f33989696cd32796fc8e261021d2 : GenericRecordList<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure>, IEnumerable, IEnumerator , OutSystems.Application.Extensibility.DataTypes.IRecordList {

public IEnumerable<OutSystems.Application.Extensibility.DataTypes.IRecord> GetRecords() {
    return _data.Cast<OutSystems.Application.Extensibility.DataTypes.IRecord>();
}

public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecordList other) {
    foreach (var element in other.GetRecords()) {
        var convertedElement = new ST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
        convertedElement.CopyFrom(element);
        Append(convertedElement);
    }
}


protected override ST_a1f7d5fa968628cf9ed1d90efadf9506Structure GetElementDefaultValue() {
return new ST_a1f7d5fa968628cf9ed1d90efadf9506Structure();
}

public T[] ToArray<T>(Func<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7919f33989696cd32796fc8e261021d2 recordList, Func<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7919f33989696cd32796fc8e261021d2(ST_a1f7d5fa968628cf9ed1d90efadf9506Structure[] array) {
  RL_7919f33989696cd32796fc8e261021d2 result = new RL_7919f33989696cd32796fc8e261021d2();
result.InnerFromArray(array);
    return result;
}

public static RL_7919f33989696cd32796fc8e261021d2 ToList<T>(T[] array, Func <T, ST_a1f7d5fa968628cf9ed1d90efadf9506Structure> converter) {
  RL_7919f33989696cd32796fc8e261021d2 result = new RL_7919f33989696cd32796fc8e261021d2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7919f33989696cd32796fc8e261021d2 FromRestList<T>(RestList<T> restList, Func <T, ST_a1f7d5fa968628cf9ed1d90efadf9506Structure> converter) {
  RL_7919f33989696cd32796fc8e261021d2 result = new RL_7919f33989696cd32796fc8e261021d2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7919f33989696cd32796fc8e261021d2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a1f7d5fa968628cf9ed1d90efadf9506Structure> NewList() {
return new RL_7919f33989696cd32796fc8e261021d2();
}


} // RL_7919f33989696cd32796fc8e261021d2
}

