namespace ssZXingLibDemo {
/// <summary>
/// [AnonymousStructure] Record (BvOW67nKtEWctv4XLV5+4A)
///  <code>RC_df417030a22338c6546ba4bfe47f9e17</code> that represents <code>WifiRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: WifiRecord
public partial struct RC_df417030a22338c6546ba4bfe47f9e17 : ITypedRecord<RC_df417030a22338c6546ba4bfe47f9e17>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdWifi = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MHBB3yOixjhUa6S_5H+eFw");

public static void EnsureInitialized(){}

static RC_df417030a22338c6546ba4bfe47f9e17() {
RC_df417030a22338c6546ba4bfe47f9e17TypeFactoryImpl.InitializeFactory();
}
[System.Xml.Serialization.XmlElement("Wifi")]
public ST_af04a340a4a61afef041397e6f042234Structure ssSTWifi;


public static implicit operator ST_af04a340a4a61afef041397e6f042234Structure( RC_df417030a22338c6546ba4bfe47f9e17 r) {
return r.ssSTWifi;
}

public static implicit operator RC_df417030a22338c6546ba4bfe47f9e17 (ST_af04a340a4a61afef041397e6f042234Structure r) {
RC_df417030a22338c6546ba4bfe47f9e17 res = new RC_df417030a22338c6546ba4bfe47f9e17 ();
res.ssSTWifi = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_df417030a22338c6546ba4bfe47f9e17() {
OptimizedAttributes = null;
ssSTWifi = new ST_af04a340a4a61afef041397e6f042234Structure();
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
    ssSTWifi.OptimizedAttributes = value[0];
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
ssSTWifi.Read( r, ref index);
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
public void ReadIM(RC_df417030a22338c6546ba4bfe47f9e17 r) {
this = r;
}


public static bool operator == (RC_df417030a22338c6546ba4bfe47f9e17 a, RC_df417030a22338c6546ba4bfe47f9e17 b) {
if (a.ssSTWifi != b.ssSTWifi) return false;
return true;
}

public static bool operator != (RC_df417030a22338c6546ba4bfe47f9e17 a, RC_df417030a22338c6546ba4bfe47f9e17 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_df417030a22338c6546ba4bfe47f9e17)) return false;
return (this == (RC_df417030a22338c6546ba4bfe47f9e17)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTWifi.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTWifi.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTWifi.InternalRecursiveSave();
}


public RC_df417030a22338c6546ba4bfe47f9e17 Duplicate() {
RC_df417030a22338c6546ba4bfe47f9e17 t;
t.ssSTWifi = (ST_af04a340a4a61afef041397e6f042234Structure)this.ssSTWifi.Duplicate();
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
if (head == "wifi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Wifi")) variable.Value = ssSTWifi; else variable.Optimized = true;
variable.SetFieldName("wifi");
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
if (key == IdWifi) {
return ssSTWifi;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWifi.Key.AsGuid) {
return ssSTWifi;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTWifi.FillFromOther((IRecord) other.AttributeGet(IdWifi));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTWifi.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdWifi.Key.AsGuid));
}
} // RC_df417030a22338c6546ba4bfe47f9e17
/// <summary>
/// RecordList type <code>WifiRecordList</code> that represents a record list of <code>Wifi</code>
/// </summary>
public partial class RL_e72c9d56c0e57d994fc473f2fc4b0153 : GenericRecordList<RC_df417030a22338c6546ba4bfe47f9e17>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_df417030a22338c6546ba4bfe47f9e17 GetElementDefaultValue() {
return new RC_df417030a22338c6546ba4bfe47f9e17();
}

public T[] ToArray<T>(Func<RC_df417030a22338c6546ba4bfe47f9e17, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e72c9d56c0e57d994fc473f2fc4b0153 recordList, Func<RC_df417030a22338c6546ba4bfe47f9e17, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e72c9d56c0e57d994fc473f2fc4b0153(RC_df417030a22338c6546ba4bfe47f9e17[] array) {
  RL_e72c9d56c0e57d994fc473f2fc4b0153 result = new RL_e72c9d56c0e57d994fc473f2fc4b0153();
result.InnerFromArray(array);
    return result;
}

public static RL_e72c9d56c0e57d994fc473f2fc4b0153 ToList<T>(T[] array, Func <T, RC_df417030a22338c6546ba4bfe47f9e17> converter) {
  RL_e72c9d56c0e57d994fc473f2fc4b0153 result = new RL_e72c9d56c0e57d994fc473f2fc4b0153();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e72c9d56c0e57d994fc473f2fc4b0153 FromRestList<T>(RestList<T> restList, Func <T, RC_df417030a22338c6546ba4bfe47f9e17> converter) {
  RL_e72c9d56c0e57d994fc473f2fc4b0153 result = new RL_e72c9d56c0e57d994fc473f2fc4b0153();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e72c9d56c0e57d994fc473f2fc4b0153() : base() {
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
protected override OSList<RC_df417030a22338c6546ba4bfe47f9e17> NewList() {
return new RL_e72c9d56c0e57d994fc473f2fc4b0153();
}


} // RL_e72c9d56c0e57d994fc473f2fc4b0153
}

