namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (RwQseobQYEG8ImvxXmLlpg)
///  <code>RC_f3c2b7b3f72abb115f72c934f4368624</code> that represent
/// s <code>FlatpickrConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: FlatpickrConfigsRecord
public partial struct RC_f3c2b7b3f72abb115f72c934f4368624 : ITypedRecord<RC_f3c2b7b3f72abb115f72c934f4368624> {
internal static readonly GlobalObjectKey IdFlatpickrConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*s7fC8yr3Ebtfcsk09DaGJA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("FlatpickrConfigs")]
public ST_14b00646f6cd842655571448758d0a23Structure ssSTFlatpickrConfigs;


public static implicit operator ST_14b00646f6cd842655571448758d0a23Structure( RC_f3c2b7b3f72abb115f72c934f4368624 r) {
return r.ssSTFlatpickrConfigs;
}

public static implicit operator RC_f3c2b7b3f72abb115f72c934f4368624 (ST_14b00646f6cd842655571448758d0a23Structure r) {
RC_f3c2b7b3f72abb115f72c934f4368624 res = new RC_f3c2b7b3f72abb115f72c934f4368624 ();
res.ssSTFlatpickrConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f3c2b7b3f72abb115f72c934f4368624() {
OptimizedAttributes = null;
ssSTFlatpickrConfigs = new ST_14b00646f6cd842655571448758d0a23Structure();
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
    ssSTFlatpickrConfigs.OptimizedAttributes = value[0];
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
ssSTFlatpickrConfigs.Read( r, ref index);
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
public void ReadIM(RC_f3c2b7b3f72abb115f72c934f4368624 r) {
this = r;
}


public static bool operator == (RC_f3c2b7b3f72abb115f72c934f4368624 a, RC_f3c2b7b3f72abb115f72c934f4368624 b) {
if (a.ssSTFlatpickrConfigs != b.ssSTFlatpickrConfigs) return false;
return true;
}

public static bool operator != (RC_f3c2b7b3f72abb115f72c934f4368624 a, RC_f3c2b7b3f72abb115f72c934f4368624 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f3c2b7b3f72abb115f72c934f4368624)) return false;
return (this == (RC_f3c2b7b3f72abb115f72c934f4368624)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFlatpickrConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFlatpickrConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFlatpickrConfigs.InternalRecursiveSave();
}


public RC_f3c2b7b3f72abb115f72c934f4368624 Duplicate() {
RC_f3c2b7b3f72abb115f72c934f4368624 t;
t.ssSTFlatpickrConfigs = (ST_14b00646f6cd842655571448758d0a23Structure)this.ssSTFlatpickrConfigs.Duplicate();
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
if (head == "flatpickrconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FlatpickrConfigs")) variable.Value = ssSTFlatpickrConfigs; else variable.Optimized = true;
variable.SetFieldName("flatpickrconfigs");
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
if (key == IdFlatpickrConfigs) {
return ssSTFlatpickrConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFlatpickrConfigs.Key.AsGuid) {
return ssSTFlatpickrConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFlatpickrConfigs.FillFromOther((IRecord) other.AttributeGet(IdFlatpickrConfigs));
}
} // RC_f3c2b7b3f72abb115f72c934f4368624
/// <summary>
/// RecordList type <code>FlatpickrConfigsRecordList</code> that represents a record list of
///  <code>FlatpickrConfigs</code>
/// </summary>
public partial class RL_47cfc8da94abd6a57dcb42f40bcbe06e : GenericRecordList<RC_f3c2b7b3f72abb115f72c934f4368624>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f3c2b7b3f72abb115f72c934f4368624 GetElementDefaultValue() {
return new RC_f3c2b7b3f72abb115f72c934f4368624();
}

public T[] ToArray<T>(Func<RC_f3c2b7b3f72abb115f72c934f4368624, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_47cfc8da94abd6a57dcb42f40bcbe06e recordList, Func<RC_f3c2b7b3f72abb115f72c934f4368624, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_47cfc8da94abd6a57dcb42f40bcbe06e(RC_f3c2b7b3f72abb115f72c934f4368624[] array) {
  RL_47cfc8da94abd6a57dcb42f40bcbe06e result = new RL_47cfc8da94abd6a57dcb42f40bcbe06e();
result.InnerFromArray(array);
    return result;
}

public static RL_47cfc8da94abd6a57dcb42f40bcbe06e ToList<T>(T[] array, Func <T, RC_f3c2b7b3f72abb115f72c934f4368624> converter) {
  RL_47cfc8da94abd6a57dcb42f40bcbe06e result = new RL_47cfc8da94abd6a57dcb42f40bcbe06e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_47cfc8da94abd6a57dcb42f40bcbe06e FromRestList<T>(RestList<T> restList, Func <T, RC_f3c2b7b3f72abb115f72c934f4368624> converter) {
  RL_47cfc8da94abd6a57dcb42f40bcbe06e result = new RL_47cfc8da94abd6a57dcb42f40bcbe06e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_47cfc8da94abd6a57dcb42f40bcbe06e() : base() {
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
protected override OSList<RC_f3c2b7b3f72abb115f72c934f4368624> NewList() {
return new RL_47cfc8da94abd6a57dcb42f40bcbe06e();
}


} // RL_47cfc8da94abd6a57dcb42f40bcbe06e
}

