namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (w6G88s_iA0KX8ZjKavucTQ)
///  <code>RC_4d01ba747615bc6dc01c586f0b43450a</code> that represent
/// s <code>DropdownTagsOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownTagsOptionalConfigsRecord
public partial struct RC_4d01ba747615bc6dc01c586f0b43450a : ITypedRecord<RC_4d01ba747615bc6dc01c586f0b43450a> {
internal static readonly GlobalObjectKey IdDropdownTagsOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dLoBTRV2bbzAHFhvC0NFCg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownTagsOptionalConfigs")]
public ST_34444d0742578c128ebc8b2594439346Structure ssSTDropdownTagsOptionalConfigs;


public static implicit operator ST_34444d0742578c128ebc8b2594439346Structure( RC_4d01ba747615bc6dc01c586f0b43450a r) {
return r.ssSTDropdownTagsOptionalConfigs;
}

public static implicit operator RC_4d01ba747615bc6dc01c586f0b43450a (ST_34444d0742578c128ebc8b2594439346Structure r) {
RC_4d01ba747615bc6dc01c586f0b43450a res = new RC_4d01ba747615bc6dc01c586f0b43450a ();
res.ssSTDropdownTagsOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4d01ba747615bc6dc01c586f0b43450a() {
OptimizedAttributes = null;
ssSTDropdownTagsOptionalConfigs = new ST_34444d0742578c128ebc8b2594439346Structure();
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
    ssSTDropdownTagsOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTDropdownTagsOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_4d01ba747615bc6dc01c586f0b43450a r) {
this = r;
}


public static bool operator == (RC_4d01ba747615bc6dc01c586f0b43450a a, RC_4d01ba747615bc6dc01c586f0b43450a b) {
if (a.ssSTDropdownTagsOptionalConfigs != b.ssSTDropdownTagsOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_4d01ba747615bc6dc01c586f0b43450a a, RC_4d01ba747615bc6dc01c586f0b43450a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4d01ba747615bc6dc01c586f0b43450a)) return false;
return (this == (RC_4d01ba747615bc6dc01c586f0b43450a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownTagsOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownTagsOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownTagsOptionalConfigs.InternalRecursiveSave();
}


public RC_4d01ba747615bc6dc01c586f0b43450a Duplicate() {
RC_4d01ba747615bc6dc01c586f0b43450a t;
t.ssSTDropdownTagsOptionalConfigs = (ST_34444d0742578c128ebc8b2594439346Structure)this.ssSTDropdownTagsOptionalConfigs.Duplicate();
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
if (head == "dropdowntagsoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownTagsOptionalConfigs")) variable.Value = ssSTDropdownTagsOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("dropdowntagsoptionalconfigs");
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
if (key == IdDropdownTagsOptionalConfigs) {
return ssSTDropdownTagsOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownTagsOptionalConfigs.Key.AsGuid) {
return ssSTDropdownTagsOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownTagsOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDropdownTagsOptionalConfigs));
}
} // RC_4d01ba747615bc6dc01c586f0b43450a
/// <summary>
/// RecordList type <code>DropdownTagsOptionalConfigsRecordList</code> that represents a record list of
///  <code>DropdownTagsOptionalConfigs</code>
/// </summary>
public partial class RL_3168a7a1678dfe8f6720ee5fb1eb68a1 : GenericRecordList<RC_4d01ba747615bc6dc01c586f0b43450a>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_4d01ba747615bc6dc01c586f0b43450a GetElementDefaultValue() {
return new RC_4d01ba747615bc6dc01c586f0b43450a();
}

public T[] ToArray<T>(Func<RC_4d01ba747615bc6dc01c586f0b43450a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3168a7a1678dfe8f6720ee5fb1eb68a1 recordList, Func<RC_4d01ba747615bc6dc01c586f0b43450a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3168a7a1678dfe8f6720ee5fb1eb68a1(RC_4d01ba747615bc6dc01c586f0b43450a[] array) {
  RL_3168a7a1678dfe8f6720ee5fb1eb68a1 result = new RL_3168a7a1678dfe8f6720ee5fb1eb68a1();
result.InnerFromArray(array);
    return result;
}

public static RL_3168a7a1678dfe8f6720ee5fb1eb68a1 ToList<T>(T[] array, Func <T, RC_4d01ba747615bc6dc01c586f0b43450a> converter) {
  RL_3168a7a1678dfe8f6720ee5fb1eb68a1 result = new RL_3168a7a1678dfe8f6720ee5fb1eb68a1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3168a7a1678dfe8f6720ee5fb1eb68a1 FromRestList<T>(RestList<T> restList, Func <T, RC_4d01ba747615bc6dc01c586f0b43450a> converter) {
  RL_3168a7a1678dfe8f6720ee5fb1eb68a1 result = new RL_3168a7a1678dfe8f6720ee5fb1eb68a1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3168a7a1678dfe8f6720ee5fb1eb68a1() : base() {
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
protected override OSList<RC_4d01ba747615bc6dc01c586f0b43450a> NewList() {
return new RL_3168a7a1678dfe8f6720ee5fb1eb68a1();
}


} // RL_3168a7a1678dfe8f6720ee5fb1eb68a1
}

