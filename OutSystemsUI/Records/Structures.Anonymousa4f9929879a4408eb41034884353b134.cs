namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (mJL5pKR5jkC0EDSIQ1OxNA)
///  <code>RC_1310596a4ac4ae2b0319b38dd9472639</code> that represent
/// s <code>NoUiSliderConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: NoUiSliderConfigsRecord
public partial struct RC_1310596a4ac4ae2b0319b38dd9472639 : ITypedRecord<RC_1310596a4ac4ae2b0319b38dd9472639> {
internal static readonly GlobalObjectKey IdNoUiSliderConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*alkQE8RKK64DGbON2UcmOQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("NoUiSliderConfigs")]
public ST_af087c80f6ec63e7de4ff7926f7da7d0Structure ssSTNoUiSliderConfigs;


public static implicit operator ST_af087c80f6ec63e7de4ff7926f7da7d0Structure( RC_1310596a4ac4ae2b0319b38dd9472639 r) {
return r.ssSTNoUiSliderConfigs;
}

public static implicit operator RC_1310596a4ac4ae2b0319b38dd9472639 (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure r) {
RC_1310596a4ac4ae2b0319b38dd9472639 res = new RC_1310596a4ac4ae2b0319b38dd9472639 ();
res.ssSTNoUiSliderConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1310596a4ac4ae2b0319b38dd9472639() {
OptimizedAttributes = null;
ssSTNoUiSliderConfigs = new ST_af087c80f6ec63e7de4ff7926f7da7d0Structure();
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
    ssSTNoUiSliderConfigs.OptimizedAttributes = value[0];
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
ssSTNoUiSliderConfigs.Read( r, ref index);
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
public void ReadIM(RC_1310596a4ac4ae2b0319b38dd9472639 r) {
this = r;
}


public static bool operator == (RC_1310596a4ac4ae2b0319b38dd9472639 a, RC_1310596a4ac4ae2b0319b38dd9472639 b) {
if (a.ssSTNoUiSliderConfigs != b.ssSTNoUiSliderConfigs) return false;
return true;
}

public static bool operator != (RC_1310596a4ac4ae2b0319b38dd9472639 a, RC_1310596a4ac4ae2b0319b38dd9472639 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1310596a4ac4ae2b0319b38dd9472639)) return false;
return (this == (RC_1310596a4ac4ae2b0319b38dd9472639)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNoUiSliderConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNoUiSliderConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNoUiSliderConfigs.InternalRecursiveSave();
}


public RC_1310596a4ac4ae2b0319b38dd9472639 Duplicate() {
RC_1310596a4ac4ae2b0319b38dd9472639 t;
t.ssSTNoUiSliderConfigs = (ST_af087c80f6ec63e7de4ff7926f7da7d0Structure)this.ssSTNoUiSliderConfigs.Duplicate();
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
if (head == "nouisliderconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoUiSliderConfigs")) variable.Value = ssSTNoUiSliderConfigs; else variable.Optimized = true;
variable.SetFieldName("nouisliderconfigs");
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
if (key == IdNoUiSliderConfigs) {
return ssSTNoUiSliderConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNoUiSliderConfigs.Key.AsGuid) {
return ssSTNoUiSliderConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNoUiSliderConfigs.FillFromOther((IRecord) other.AttributeGet(IdNoUiSliderConfigs));
}
} // RC_1310596a4ac4ae2b0319b38dd9472639
/// <summary>
/// RecordList type <code>NoUiSliderConfigsRecordList</code> that represents a record list of
///  <code>NoUiSliderConfigs</code>
/// </summary>
public partial class RL_505eb79092b88d8c5112cf252cbfabf9 : GenericRecordList<RC_1310596a4ac4ae2b0319b38dd9472639>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_1310596a4ac4ae2b0319b38dd9472639 GetElementDefaultValue() {
return new RC_1310596a4ac4ae2b0319b38dd9472639();
}

public T[] ToArray<T>(Func<RC_1310596a4ac4ae2b0319b38dd9472639, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_505eb79092b88d8c5112cf252cbfabf9 recordList, Func<RC_1310596a4ac4ae2b0319b38dd9472639, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_505eb79092b88d8c5112cf252cbfabf9(RC_1310596a4ac4ae2b0319b38dd9472639[] array) {
  RL_505eb79092b88d8c5112cf252cbfabf9 result = new RL_505eb79092b88d8c5112cf252cbfabf9();
result.InnerFromArray(array);
    return result;
}

public static RL_505eb79092b88d8c5112cf252cbfabf9 ToList<T>(T[] array, Func <T, RC_1310596a4ac4ae2b0319b38dd9472639> converter) {
  RL_505eb79092b88d8c5112cf252cbfabf9 result = new RL_505eb79092b88d8c5112cf252cbfabf9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_505eb79092b88d8c5112cf252cbfabf9 FromRestList<T>(RestList<T> restList, Func <T, RC_1310596a4ac4ae2b0319b38dd9472639> converter) {
  RL_505eb79092b88d8c5112cf252cbfabf9 result = new RL_505eb79092b88d8c5112cf252cbfabf9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_505eb79092b88d8c5112cf252cbfabf9() : base() {
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
protected override OSList<RC_1310596a4ac4ae2b0319b38dd9472639> NewList() {
return new RL_505eb79092b88d8c5112cf252cbfabf9();
}


} // RL_505eb79092b88d8c5112cf252cbfabf9
}

