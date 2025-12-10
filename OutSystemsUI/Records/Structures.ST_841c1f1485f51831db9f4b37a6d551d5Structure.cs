namespace ssOutSystemsUI {
/// <summary>
/// [Structure] NoUiSliderConfigs_Range (2cQY0DjpYU6CzF+YJYSuBw)
///  <code>ST_841c1f1485f51831db9f4b37a6d551d5Structure</code> that represent
/// s <code>NoUiSliderConfigs_Range</code> <p>Description: </p>
/// </summary>
// Name: NoUiSliderConfigs_Range
public partial struct ST_841c1f1485f51831db9f4b37a6d551d5Structure : ITypedRecord<ST_841c1f1485f51831db9f4b37a6d551d5Structure> {
internal static readonly GlobalObjectKey Idkey = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*PANMcB2ks0i6YXoNCOZG5w");
internal static readonly GlobalObjectKey Idvalue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*UNYKB1zSoUmJnQLHEpM_FA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("key")]
public string sskey;

[System.Xml.Serialization.XmlElement("value")]
public int ssvalue;


public BitArray OptimizedAttributes;

public ST_841c1f1485f51831db9f4b37a6d551d5Structure() {
OptimizedAttributes = null;
sskey = "";
ssvalue = 0;
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
sskey = r.ReadText(index++, "NoUiSliderConfigs_Range.key", "");
ssvalue = r.ReadInteger(index++, "NoUiSliderConfigs_Range.value", 0);
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
public void ReadIM(ST_841c1f1485f51831db9f4b37a6d551d5Structure r) {
this = r;
}


public static bool operator == (ST_841c1f1485f51831db9f4b37a6d551d5Structure a, ST_841c1f1485f51831db9f4b37a6d551d5Structure b) {
if (a.sskey != b.sskey) return false;
if (a.ssvalue != b.ssvalue) return false;
return true;
}

public static bool operator != (ST_841c1f1485f51831db9f4b37a6d551d5Structure a, ST_841c1f1485f51831db9f4b37a6d551d5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_841c1f1485f51831db9f4b37a6d551d5Structure)) return false;
return (this == (ST_841c1f1485f51831db9f4b37a6d551d5Structure)o);
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


public ST_841c1f1485f51831db9f4b37a6d551d5Structure Duplicate() {
ST_841c1f1485f51831db9f4b37a6d551d5Structure t;
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
ssvalue = (int) other.AttributeGet(Idvalue);
}
} // ST_841c1f1485f51831db9f4b37a6d551d5Structure
/// <summary>
/// RecordList type <code>NoUiSliderConfigs_RangeList</code> that represents a record list of
///  <code>NoUiSliderConfigs_Range</code>
/// </summary>
public partial class RL_b290214900b73d49f11f1fe32c57a145 : GenericRecordList<ST_841c1f1485f51831db9f4b37a6d551d5Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_841c1f1485f51831db9f4b37a6d551d5Structure GetElementDefaultValue() {
return new ST_841c1f1485f51831db9f4b37a6d551d5Structure();
}

public T[] ToArray<T>(Func<ST_841c1f1485f51831db9f4b37a6d551d5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b290214900b73d49f11f1fe32c57a145 recordList, Func<ST_841c1f1485f51831db9f4b37a6d551d5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b290214900b73d49f11f1fe32c57a145(ST_841c1f1485f51831db9f4b37a6d551d5Structure[] array) {
  RL_b290214900b73d49f11f1fe32c57a145 result = new RL_b290214900b73d49f11f1fe32c57a145();
result.InnerFromArray(array);
    return result;
}

public static RL_b290214900b73d49f11f1fe32c57a145 ToList<T>(T[] array, Func <T, ST_841c1f1485f51831db9f4b37a6d551d5Structure> converter) {
  RL_b290214900b73d49f11f1fe32c57a145 result = new RL_b290214900b73d49f11f1fe32c57a145();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b290214900b73d49f11f1fe32c57a145 FromRestList<T>(RestList<T> restList, Func <T, ST_841c1f1485f51831db9f4b37a6d551d5Structure> converter) {
  RL_b290214900b73d49f11f1fe32c57a145 result = new RL_b290214900b73d49f11f1fe32c57a145();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b290214900b73d49f11f1fe32c57a145() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_841c1f1485f51831db9f4b37a6d551d5Structure> NewList() {
return new RL_b290214900b73d49f11f1fe32c57a145();
}


} // RL_b290214900b73d49f11f1fe32c57a145
}

