namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (5f5zCc0NNkyks0bc_71NNg)
///  <code>RC_8d60218511e7c5a6826e7f1bde0eda29</code> that represent
/// s <code>DatePickerProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerProviderRecord
public partial struct RC_8d60218511e7c5a6826e7f1bde0eda29 : ITypedRecord<RC_8d60218511e7c5a6826e7f1bde0eda29> {
internal static readonly GlobalObjectKey IdDatePickerProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hSFgjecRpsWCbn8b3g7aKQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DatePickerProvider")]
public EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord ssENDatePickerProvider;


public static implicit operator EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord( RC_8d60218511e7c5a6826e7f1bde0eda29 r) {
return r.ssENDatePickerProvider;
}

public static implicit operator RC_8d60218511e7c5a6826e7f1bde0eda29 (EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord r) {
RC_8d60218511e7c5a6826e7f1bde0eda29 res = new RC_8d60218511e7c5a6826e7f1bde0eda29 ();
res.ssENDatePickerProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDatePickerProvider.ChangedAttributes = value;
}
get {
    return ssENDatePickerProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8d60218511e7c5a6826e7f1bde0eda29() {
OptimizedAttributes = null;
ssENDatePickerProvider = new EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDatePickerProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDatePickerProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDatePickerProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDatePickerProvider.Read( r, ref index);
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
public void ReadIM(RC_8d60218511e7c5a6826e7f1bde0eda29 r) {
this = r;
}


public static bool operator == (RC_8d60218511e7c5a6826e7f1bde0eda29 a, RC_8d60218511e7c5a6826e7f1bde0eda29 b) {
if (a.ssENDatePickerProvider != b.ssENDatePickerProvider) return false;
return true;
}

public static bool operator != (RC_8d60218511e7c5a6826e7f1bde0eda29 a, RC_8d60218511e7c5a6826e7f1bde0eda29 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8d60218511e7c5a6826e7f1bde0eda29)) return false;
return (this == (RC_8d60218511e7c5a6826e7f1bde0eda29)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDatePickerProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDatePickerProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDatePickerProvider.InternalRecursiveSave();
}


public RC_8d60218511e7c5a6826e7f1bde0eda29 Duplicate() {
RC_8d60218511e7c5a6826e7f1bde0eda29 t;
t.ssENDatePickerProvider = (EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord)this.ssENDatePickerProvider.Duplicate();
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
if (head == "datepickerprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerProvider")) variable.Value = ssENDatePickerProvider; else variable.Optimized = true;
variable.SetFieldName("datepickerprovider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDatePickerProvider) {
return ssENDatePickerProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerProvider.Key.AsGuid) {
return ssENDatePickerProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDatePickerProvider.FillFromOther((IRecord) other.AttributeGet(IdDatePickerProvider));
}
} // RC_8d60218511e7c5a6826e7f1bde0eda29
/// <summary>
/// RecordList type <code>DatePickerProviderRecordList</code> that represents a record list of
///  <code>DatePickerProvider</code>
/// </summary>
public partial class RL_be21e3aab03a03acafadf693c54c51b8 : GenericRecordList<RC_8d60218511e7c5a6826e7f1bde0eda29>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_8d60218511e7c5a6826e7f1bde0eda29 GetElementDefaultValue() {
return new RC_8d60218511e7c5a6826e7f1bde0eda29();
}

public T[] ToArray<T>(Func<RC_8d60218511e7c5a6826e7f1bde0eda29, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_be21e3aab03a03acafadf693c54c51b8 recordList, Func<RC_8d60218511e7c5a6826e7f1bde0eda29, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_be21e3aab03a03acafadf693c54c51b8(RC_8d60218511e7c5a6826e7f1bde0eda29[] array) {
  RL_be21e3aab03a03acafadf693c54c51b8 result = new RL_be21e3aab03a03acafadf693c54c51b8();
result.InnerFromArray(array);
    return result;
}

public static RL_be21e3aab03a03acafadf693c54c51b8 ToList<T>(T[] array, Func <T, RC_8d60218511e7c5a6826e7f1bde0eda29> converter) {
  RL_be21e3aab03a03acafadf693c54c51b8 result = new RL_be21e3aab03a03acafadf693c54c51b8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_be21e3aab03a03acafadf693c54c51b8 FromRestList<T>(RestList<T> restList, Func <T, RC_8d60218511e7c5a6826e7f1bde0eda29> converter) {
  RL_be21e3aab03a03acafadf693c54c51b8 result = new RL_be21e3aab03a03acafadf693c54c51b8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_be21e3aab03a03acafadf693c54c51b8() : base() {
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
protected override OSList<RC_8d60218511e7c5a6826e7f1bde0eda29> NewList() {
return new RL_be21e3aab03a03acafadf693c54c51b8();
}


} // RL_be21e3aab03a03acafadf693c54c51b8
}

