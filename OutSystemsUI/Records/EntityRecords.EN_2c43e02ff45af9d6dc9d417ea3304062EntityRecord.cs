using System.Diagnostics;
namespace ssOutSystemsUI {

/// <summary>
/// [Entity] Speed (rsRcCk+1o06azp9Jx3JGBg)
///  <code>EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord</code> that represents <code>Speed</code
/// > <p>Description: Sets animation speed settings.</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Speed","rsRcCk+1o06azp9Jx3JGBg","Kn_hixxDWEm4lMd7mIpycQ", 0,"", null, false)]
// Name: Speed
public partial struct EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord : ITypedRecord<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> {
internal static readonly GlobalObjectKey IdSpeed = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jQbBOPeLR02d+4+32zCuMQ");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SPEED",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Speed")]
private string _ssSpeed;
public string ssSpeed{
  get{
      return _ssSpeed;
  }
  set{
      if((_ssSpeed!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssSpeed = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssSpeed = "";
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
ssSpeed = r.ReadText(index++, "Speed.Speed", "");
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
public void ReadIM(EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord r) {
this = r;
}


public static bool operator == (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord a, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord b) {
if (a.ssSpeed != b.ssSpeed) return false;
return true;
}

public static bool operator != (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord a, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord)) return false;
return (this == (EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSpeed.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord Duplicate() {
EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord t;
t._ssSpeed = this._ssSpeed;
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
if (head == "speed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Speed")) variable.Value = ssSpeed; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSpeed)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSpeed)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpeed) {
return ssSpeed;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpeed.Key.AsGuid) {
return ssSpeed;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssSpeed = (string) other.AttributeGet(IdSpeed);
ChangedAttributes[0] = other.ChangedAttributeGet(IdSpeed);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSpeed);
}
} // EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord

/// <summary>
/// RecordList type <code>SpeedList</code> that represents a record list of <code>Speed</code>
/// </summary>
public partial class RL_e8445d61f812c92de860d050e73a5e29 : GenericRecordList<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord GetElementDefaultValue() {
return new EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord();
}

public T[] ToArray<T>(Func<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e8445d61f812c92de860d050e73a5e29 recordList, Func<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e8445d61f812c92de860d050e73a5e29(EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord[] array) {
  RL_e8445d61f812c92de860d050e73a5e29 result = new RL_e8445d61f812c92de860d050e73a5e29();
result.InnerFromArray(array);
    return result;
}

public static RL_e8445d61f812c92de860d050e73a5e29 ToList<T>(T[] array, Func <T, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> converter) {
  RL_e8445d61f812c92de860d050e73a5e29 result = new RL_e8445d61f812c92de860d050e73a5e29();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e8445d61f812c92de860d050e73a5e29 FromRestList<T>(RestList<T> restList, Func <T, EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> converter) {
  RL_e8445d61f812c92de860d050e73a5e29 result = new RL_e8445d61f812c92de860d050e73a5e29();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e8445d61f812c92de860d050e73a5e29() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_2c43e02ff45af9d6dc9d417ea3304062EntityRecord> NewList() {
return new RL_e8445d61f812c92de860d050e73a5e29();
}


} // RL_e8445d61f812c92de860d050e73a5e29
}
