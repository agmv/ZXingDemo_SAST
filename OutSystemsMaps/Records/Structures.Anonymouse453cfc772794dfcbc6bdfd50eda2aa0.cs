namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (x89T5Hly_E28a9_VDtoqoA)
///  <code>RC_d186ae1becb56f86c126b4768e3f70d2</code> that represents <code>SearchTypesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SearchTypesRecord
public partial struct RC_d186ae1becb56f86c126b4768e3f70d2 : ITypedRecord<RC_d186ae1becb56f86c126b4768e3f70d2> {
internal static readonly GlobalObjectKey IdSearchTypes = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*G66G0bXshm_BJrR2jj9w0g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SearchTypes")]
public EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord ssENSearchTypes;


public static implicit operator EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord( RC_d186ae1becb56f86c126b4768e3f70d2 r) {
return r.ssENSearchTypes;
}

public static implicit operator RC_d186ae1becb56f86c126b4768e3f70d2 (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord r) {
RC_d186ae1becb56f86c126b4768e3f70d2 res = new RC_d186ae1becb56f86c126b4768e3f70d2 ();
res.ssENSearchTypes = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSearchTypes.ChangedAttributes = value;
}
get {
    return ssENSearchTypes.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d186ae1becb56f86c126b4768e3f70d2() {
OptimizedAttributes = null;
ssENSearchTypes = new EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSearchTypes.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSearchTypes.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSearchTypes.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSearchTypes.Read( r, ref index);
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
public void ReadIM(RC_d186ae1becb56f86c126b4768e3f70d2 r) {
this = r;
}


public static bool operator == (RC_d186ae1becb56f86c126b4768e3f70d2 a, RC_d186ae1becb56f86c126b4768e3f70d2 b) {
if (a.ssENSearchTypes != b.ssENSearchTypes) return false;
return true;
}

public static bool operator != (RC_d186ae1becb56f86c126b4768e3f70d2 a, RC_d186ae1becb56f86c126b4768e3f70d2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d186ae1becb56f86c126b4768e3f70d2)) return false;
return (this == (RC_d186ae1becb56f86c126b4768e3f70d2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSearchTypes.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSearchTypes.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSearchTypes.InternalRecursiveSave();
}


public RC_d186ae1becb56f86c126b4768e3f70d2 Duplicate() {
RC_d186ae1becb56f86c126b4768e3f70d2 t;
t.ssENSearchTypes = (EN_2a64cd2fe4a253e65ea352434a6d389aEntityRecord)this.ssENSearchTypes.Duplicate();
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
if (head == "searchtypes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchTypes")) variable.Value = ssENSearchTypes; else variable.Optimized = true;
variable.SetFieldName("searchtypes");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSearchTypes.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSearchTypes.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSearchTypes) {
return ssENSearchTypes;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSearchTypes.Key.AsGuid) {
return ssENSearchTypes;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSearchTypes.FillFromOther((IRecord) other.AttributeGet(IdSearchTypes));
}
} // RC_d186ae1becb56f86c126b4768e3f70d2
/// <summary>
/// RecordList type <code>SearchTypesRecordList</code> that represents a record list of
///  <code>SearchTypes</code>
/// </summary>
public partial class RL_848d56b8d953088a0f1dbc9b1b919b2e : GenericRecordList<RC_d186ae1becb56f86c126b4768e3f70d2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d186ae1becb56f86c126b4768e3f70d2 GetElementDefaultValue() {
return new RC_d186ae1becb56f86c126b4768e3f70d2();
}

public T[] ToArray<T>(Func<RC_d186ae1becb56f86c126b4768e3f70d2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_848d56b8d953088a0f1dbc9b1b919b2e recordList, Func<RC_d186ae1becb56f86c126b4768e3f70d2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_848d56b8d953088a0f1dbc9b1b919b2e(RC_d186ae1becb56f86c126b4768e3f70d2[] array) {
  RL_848d56b8d953088a0f1dbc9b1b919b2e result = new RL_848d56b8d953088a0f1dbc9b1b919b2e();
result.InnerFromArray(array);
    return result;
}

public static RL_848d56b8d953088a0f1dbc9b1b919b2e ToList<T>(T[] array, Func <T, RC_d186ae1becb56f86c126b4768e3f70d2> converter) {
  RL_848d56b8d953088a0f1dbc9b1b919b2e result = new RL_848d56b8d953088a0f1dbc9b1b919b2e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_848d56b8d953088a0f1dbc9b1b919b2e FromRestList<T>(RestList<T> restList, Func <T, RC_d186ae1becb56f86c126b4768e3f70d2> converter) {
  RL_848d56b8d953088a0f1dbc9b1b919b2e result = new RL_848d56b8d953088a0f1dbc9b1b919b2e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_848d56b8d953088a0f1dbc9b1b919b2e() : base() {
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
protected override OSList<RC_d186ae1becb56f86c126b4768e3f70d2> NewList() {
return new RL_848d56b8d953088a0f1dbc9b1b919b2e();
}


} // RL_848d56b8d953088a0f1dbc9b1b919b2e
}

