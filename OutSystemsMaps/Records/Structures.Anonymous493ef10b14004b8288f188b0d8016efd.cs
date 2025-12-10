namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (C_E+SQAUgkuI8Yiw2AFu_Q)
///  <code>RC_d687bfbe104d17346737149645109738</code> that represents <code>MarkerClustererRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MarkerClustererRecord
public partial struct RC_d687bfbe104d17346737149645109738 : ITypedRecord<RC_d687bfbe104d17346737149645109738> {
internal static readonly GlobalObjectKey IdMarkerClusterer = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vr+H1k0QNBdnNxSWRRCXOA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MarkerClusterer")]
public ST_30625b4ad0f3e10abf82b61ea58e8644Structure ssSTMarkerClusterer;


public static implicit operator ST_30625b4ad0f3e10abf82b61ea58e8644Structure( RC_d687bfbe104d17346737149645109738 r) {
return r.ssSTMarkerClusterer;
}

public static implicit operator RC_d687bfbe104d17346737149645109738 (ST_30625b4ad0f3e10abf82b61ea58e8644Structure r) {
RC_d687bfbe104d17346737149645109738 res = new RC_d687bfbe104d17346737149645109738 ();
res.ssSTMarkerClusterer = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d687bfbe104d17346737149645109738() {
OptimizedAttributes = null;
ssSTMarkerClusterer = new ST_30625b4ad0f3e10abf82b61ea58e8644Structure();
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
    ssSTMarkerClusterer.OptimizedAttributes = value[0];
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
ssSTMarkerClusterer.Read( r, ref index);
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
public void ReadIM(RC_d687bfbe104d17346737149645109738 r) {
this = r;
}


public static bool operator == (RC_d687bfbe104d17346737149645109738 a, RC_d687bfbe104d17346737149645109738 b) {
if (a.ssSTMarkerClusterer != b.ssSTMarkerClusterer) return false;
return true;
}

public static bool operator != (RC_d687bfbe104d17346737149645109738 a, RC_d687bfbe104d17346737149645109738 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d687bfbe104d17346737149645109738)) return false;
return (this == (RC_d687bfbe104d17346737149645109738)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMarkerClusterer.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMarkerClusterer.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMarkerClusterer.InternalRecursiveSave();
}


public RC_d687bfbe104d17346737149645109738 Duplicate() {
RC_d687bfbe104d17346737149645109738 t;
t.ssSTMarkerClusterer = (ST_30625b4ad0f3e10abf82b61ea58e8644Structure)this.ssSTMarkerClusterer.Duplicate();
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
if (head == "markerclusterer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkerClusterer")) variable.Value = ssSTMarkerClusterer; else variable.Optimized = true;
variable.SetFieldName("markerclusterer");
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
if (key == IdMarkerClusterer) {
return ssSTMarkerClusterer;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMarkerClusterer.Key.AsGuid) {
return ssSTMarkerClusterer;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMarkerClusterer.FillFromOther((IRecord) other.AttributeGet(IdMarkerClusterer));
}
} // RC_d687bfbe104d17346737149645109738
/// <summary>
/// RecordList type <code>MarkerClustererRecordList</code> that represents a record list of
///  <code>MarkerClusterer</code>
/// </summary>
public partial class RL_ab79b46414538632e058912e7b4492f7 : GenericRecordList<RC_d687bfbe104d17346737149645109738>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d687bfbe104d17346737149645109738 GetElementDefaultValue() {
return new RC_d687bfbe104d17346737149645109738();
}

public T[] ToArray<T>(Func<RC_d687bfbe104d17346737149645109738, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ab79b46414538632e058912e7b4492f7 recordList, Func<RC_d687bfbe104d17346737149645109738, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ab79b46414538632e058912e7b4492f7(RC_d687bfbe104d17346737149645109738[] array) {
  RL_ab79b46414538632e058912e7b4492f7 result = new RL_ab79b46414538632e058912e7b4492f7();
result.InnerFromArray(array);
    return result;
}

public static RL_ab79b46414538632e058912e7b4492f7 ToList<T>(T[] array, Func <T, RC_d687bfbe104d17346737149645109738> converter) {
  RL_ab79b46414538632e058912e7b4492f7 result = new RL_ab79b46414538632e058912e7b4492f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ab79b46414538632e058912e7b4492f7 FromRestList<T>(RestList<T> restList, Func <T, RC_d687bfbe104d17346737149645109738> converter) {
  RL_ab79b46414538632e058912e7b4492f7 result = new RL_ab79b46414538632e058912e7b4492f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ab79b46414538632e058912e7b4492f7() : base() {
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
protected override OSList<RC_d687bfbe104d17346737149645109738> NewList() {
return new RL_ab79b46414538632e058912e7b4492f7();
}


} // RL_ab79b46414538632e058912e7b4492f7
}

