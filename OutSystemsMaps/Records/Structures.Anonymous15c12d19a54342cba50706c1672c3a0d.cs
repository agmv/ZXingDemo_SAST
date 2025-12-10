namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (GS3BFUOly0KlBwbBZyw6DQ)
///  <code>RC_21369035d43ec8805ca548830e8c3c98</code> that represents <code>ProviderRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProviderRecord
public partial struct RC_21369035d43ec8805ca548830e8c3c98 : ITypedRecord<RC_21369035d43ec8805ca548830e8c3c98> {
internal static readonly GlobalObjectKey IdProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NZA2IT7UgMhcpUiDDow8mA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Provider")]
public EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord ssENProvider;


public static implicit operator EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord( RC_21369035d43ec8805ca548830e8c3c98 r) {
return r.ssENProvider;
}

public static implicit operator RC_21369035d43ec8805ca548830e8c3c98 (EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord r) {
RC_21369035d43ec8805ca548830e8c3c98 res = new RC_21369035d43ec8805ca548830e8c3c98 ();
res.ssENProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProvider.ChangedAttributes = value;
}
get {
    return ssENProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_21369035d43ec8805ca548830e8c3c98() {
OptimizedAttributes = null;
ssENProvider = new EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProvider.Read( r, ref index);
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
public void ReadIM(RC_21369035d43ec8805ca548830e8c3c98 r) {
this = r;
}


public static bool operator == (RC_21369035d43ec8805ca548830e8c3c98 a, RC_21369035d43ec8805ca548830e8c3c98 b) {
if (a.ssENProvider != b.ssENProvider) return false;
return true;
}

public static bool operator != (RC_21369035d43ec8805ca548830e8c3c98 a, RC_21369035d43ec8805ca548830e8c3c98 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_21369035d43ec8805ca548830e8c3c98)) return false;
return (this == (RC_21369035d43ec8805ca548830e8c3c98)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProvider.InternalRecursiveSave();
}


public RC_21369035d43ec8805ca548830e8c3c98 Duplicate() {
RC_21369035d43ec8805ca548830e8c3c98 t;
t.ssENProvider = (EN_6a1434d5022d0c0b07dda84f17d8b42fEntityRecord)this.ssENProvider.Duplicate();
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
if (head == "provider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Provider")) variable.Value = ssENProvider; else variable.Optimized = true;
variable.SetFieldName("provider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProvider) {
return ssENProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProvider.Key.AsGuid) {
return ssENProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProvider.FillFromOther((IRecord) other.AttributeGet(IdProvider));
}
} // RC_21369035d43ec8805ca548830e8c3c98
/// <summary>
/// RecordList type <code>ProviderRecordList</code> that represents a record list of
///  <code>Provider</code>
/// </summary>
public partial class RL_62008a3a72717059889cf2557d83f9e8 : GenericRecordList<RC_21369035d43ec8805ca548830e8c3c98>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_21369035d43ec8805ca548830e8c3c98 GetElementDefaultValue() {
return new RC_21369035d43ec8805ca548830e8c3c98();
}

public T[] ToArray<T>(Func<RC_21369035d43ec8805ca548830e8c3c98, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_62008a3a72717059889cf2557d83f9e8 recordList, Func<RC_21369035d43ec8805ca548830e8c3c98, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_62008a3a72717059889cf2557d83f9e8(RC_21369035d43ec8805ca548830e8c3c98[] array) {
  RL_62008a3a72717059889cf2557d83f9e8 result = new RL_62008a3a72717059889cf2557d83f9e8();
result.InnerFromArray(array);
    return result;
}

public static RL_62008a3a72717059889cf2557d83f9e8 ToList<T>(T[] array, Func <T, RC_21369035d43ec8805ca548830e8c3c98> converter) {
  RL_62008a3a72717059889cf2557d83f9e8 result = new RL_62008a3a72717059889cf2557d83f9e8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_62008a3a72717059889cf2557d83f9e8 FromRestList<T>(RestList<T> restList, Func <T, RC_21369035d43ec8805ca548830e8c3c98> converter) {
  RL_62008a3a72717059889cf2557d83f9e8 result = new RL_62008a3a72717059889cf2557d83f9e8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_62008a3a72717059889cf2557d83f9e8() : base() {
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
protected override OSList<RC_21369035d43ec8805ca548830e8c3c98> NewList() {
return new RL_62008a3a72717059889cf2557d83f9e8();
}


} // RL_62008a3a72717059889cf2557d83f9e8
}

