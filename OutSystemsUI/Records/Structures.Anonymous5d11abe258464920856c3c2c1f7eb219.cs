namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (4qsRXUZYIEmFbDwsH36yGQ)
///  <code>RC_c47826b7e4232fbf890784243715f5a8</code> that represent
/// s <code>DEPRECATED_ColorRecord</code> <p>Description: </p>
/// </summary>
// Name: DEPRECATED_ColorRecord
public partial struct RC_c47826b7e4232fbf890784243715f5a8 : ITypedRecord<RC_c47826b7e4232fbf890784243715f5a8> {
internal static readonly GlobalObjectKey IdDEPRECATED_Color = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tyZ4xCPkvy+JB4QkNxX1qA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DEPRECATED_Color")]
public EN_d383eada98ae47b51248dfe934bb4fabEntityRecord ssENDEPRECATED_Color;


public static implicit operator EN_d383eada98ae47b51248dfe934bb4fabEntityRecord( RC_c47826b7e4232fbf890784243715f5a8 r) {
return r.ssENDEPRECATED_Color;
}

public static implicit operator RC_c47826b7e4232fbf890784243715f5a8 (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord r) {
RC_c47826b7e4232fbf890784243715f5a8 res = new RC_c47826b7e4232fbf890784243715f5a8 ();
res.ssENDEPRECATED_Color = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDEPRECATED_Color.ChangedAttributes = value;
}
get {
    return ssENDEPRECATED_Color.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c47826b7e4232fbf890784243715f5a8() {
OptimizedAttributes = null;
ssENDEPRECATED_Color = new EN_d383eada98ae47b51248dfe934bb4fabEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDEPRECATED_Color.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDEPRECATED_Color.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDEPRECATED_Color.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDEPRECATED_Color.Read( r, ref index);
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
public void ReadIM(RC_c47826b7e4232fbf890784243715f5a8 r) {
this = r;
}


public static bool operator == (RC_c47826b7e4232fbf890784243715f5a8 a, RC_c47826b7e4232fbf890784243715f5a8 b) {
if (a.ssENDEPRECATED_Color != b.ssENDEPRECATED_Color) return false;
return true;
}

public static bool operator != (RC_c47826b7e4232fbf890784243715f5a8 a, RC_c47826b7e4232fbf890784243715f5a8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c47826b7e4232fbf890784243715f5a8)) return false;
return (this == (RC_c47826b7e4232fbf890784243715f5a8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDEPRECATED_Color.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDEPRECATED_Color.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDEPRECATED_Color.InternalRecursiveSave();
}


public RC_c47826b7e4232fbf890784243715f5a8 Duplicate() {
RC_c47826b7e4232fbf890784243715f5a8 t;
t.ssENDEPRECATED_Color = (EN_d383eada98ae47b51248dfe934bb4fabEntityRecord)this.ssENDEPRECATED_Color.Duplicate();
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
if (head == "deprecated_color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DEPRECATED_Color")) variable.Value = ssENDEPRECATED_Color; else variable.Optimized = true;
variable.SetFieldName("deprecated_color");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDEPRECATED_Color.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDEPRECATED_Color.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDEPRECATED_Color) {
return ssENDEPRECATED_Color;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDEPRECATED_Color.Key.AsGuid) {
return ssENDEPRECATED_Color;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDEPRECATED_Color.FillFromOther((IRecord) other.AttributeGet(IdDEPRECATED_Color));
}
} // RC_c47826b7e4232fbf890784243715f5a8
/// <summary>
/// RecordList type <code>DEPRECATED_ColorRecordList</code> that represents a record list of
///  <code>DEPRECATED_Color</code>
/// </summary>
public partial class RL_a8ebdafe2cd32ab057831964cf8f39ff : GenericRecordList<RC_c47826b7e4232fbf890784243715f5a8>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c47826b7e4232fbf890784243715f5a8 GetElementDefaultValue() {
return new RC_c47826b7e4232fbf890784243715f5a8();
}

public T[] ToArray<T>(Func<RC_c47826b7e4232fbf890784243715f5a8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a8ebdafe2cd32ab057831964cf8f39ff recordList, Func<RC_c47826b7e4232fbf890784243715f5a8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a8ebdafe2cd32ab057831964cf8f39ff(RC_c47826b7e4232fbf890784243715f5a8[] array) {
  RL_a8ebdafe2cd32ab057831964cf8f39ff result = new RL_a8ebdafe2cd32ab057831964cf8f39ff();
result.InnerFromArray(array);
    return result;
}

public static RL_a8ebdafe2cd32ab057831964cf8f39ff ToList<T>(T[] array, Func <T, RC_c47826b7e4232fbf890784243715f5a8> converter) {
  RL_a8ebdafe2cd32ab057831964cf8f39ff result = new RL_a8ebdafe2cd32ab057831964cf8f39ff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a8ebdafe2cd32ab057831964cf8f39ff FromRestList<T>(RestList<T> restList, Func <T, RC_c47826b7e4232fbf890784243715f5a8> converter) {
  RL_a8ebdafe2cd32ab057831964cf8f39ff result = new RL_a8ebdafe2cd32ab057831964cf8f39ff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a8ebdafe2cd32ab057831964cf8f39ff() : base() {
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
protected override OSList<RC_c47826b7e4232fbf890784243715f5a8> NewList() {
return new RL_a8ebdafe2cd32ab057831964cf8f39ff();
}


} // RL_a8ebdafe2cd32ab057831964cf8f39ff
}

