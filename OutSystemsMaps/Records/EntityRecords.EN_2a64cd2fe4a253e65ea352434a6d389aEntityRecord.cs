using System.Diagnostics;
namespace ssOutSystemsMaps {

/// <summary>
/// [Entity] SearchTypes (3K1Mh+enKkKtiwJnBnvFYw)
///  <code>EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord</code> that represent
/// s <code>SearchTypes</code> <p>Description: Static entity with the available search types.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("SearchTypes","3K1Mh+enKkKtiwJnBnvFYw","0TG7lXnw1k+rLlyDJoVaqg", 0,"", null, false)]
// Name: SearchTypes
public partial struct EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord : ITypedRecord<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*7mzQ3FSbmkOBrPz5ord1kA");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Id")]
private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssId = "";
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
ssId = r.ReadText(index++, "SearchTypes.Id", "");
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord r) {
this = r;
}


public static bool operator == (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord a, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord a, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord)) return false;
return (this == (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord Duplicate() {
EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord t;
t._ssId = this._ssId;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
}
} // EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord

/// <summary>
/// RecordList type <code>SearchTypesList</code> that represents a record list of
///  <code>SearchTypes</code>
/// </summary>
public partial class RL_724d63befe29e32e7a03e32f4cd42851 : GenericRecordList<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord GetElementDefaultValue() {
return new EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord();
}

public T[] ToArray<T>(Func<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_724d63befe29e32e7a03e32f4cd42851 recordList, Func<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_724d63befe29e32e7a03e32f4cd42851(EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord[] array) {
  RL_724d63befe29e32e7a03e32f4cd42851 result = new RL_724d63befe29e32e7a03e32f4cd42851();
result.InnerFromArray(array);
    return result;
}

public static RL_724d63befe29e32e7a03e32f4cd42851 ToList<T>(T[] array, Func <T, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> converter) {
  RL_724d63befe29e32e7a03e32f4cd42851 result = new RL_724d63befe29e32e7a03e32f4cd42851();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_724d63befe29e32e7a03e32f4cd42851 FromRestList<T>(RestList<T> restList, Func <T, EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> converter) {
  RL_724d63befe29e32e7a03e32f4cd42851 result = new RL_724d63befe29e32e7a03e32f4cd42851();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_724d63befe29e32e7a03e32f4cd42851() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord> NewList() {
return new RL_724d63befe29e32e7a03e32f4cd42851();
}


} // RL_724d63befe29e32e7a03e32f4cd42851
}
