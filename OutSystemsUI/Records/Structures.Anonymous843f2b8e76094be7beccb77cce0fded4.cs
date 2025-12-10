namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (jis_hAl250u+zLd8zg_e1A)
///  <code>RC_3fbb4babd0ba48852fecc04be37d3c0e</code> that represent
/// s <code>NoUiSliderConfigs_RangeRecord</code> <p>Description: </p>
/// </summary>
// Name: NoUiSliderConfigs_RangeRecord
public partial struct RC_3fbb4babd0ba48852fecc04be37d3c0e : ITypedRecord<RC_3fbb4babd0ba48852fecc04be37d3c0e> {
internal static readonly GlobalObjectKey IdNoUiSliderConfigs_Range = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q0u7P7rQhUgv7MBL4308Dg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("NoUiSliderConfigs_Range")]
public ST_841c1f1485f51831db9f4b37a6d551d5Structure ssSTNoUiSliderConfigs_Range;


public static implicit operator ST_841c1f1485f51831db9f4b37a6d551d5Structure( RC_3fbb4babd0ba48852fecc04be37d3c0e r) {
return r.ssSTNoUiSliderConfigs_Range;
}

public static implicit operator RC_3fbb4babd0ba48852fecc04be37d3c0e (ST_841c1f1485f51831db9f4b37a6d551d5Structure r) {
RC_3fbb4babd0ba48852fecc04be37d3c0e res = new RC_3fbb4babd0ba48852fecc04be37d3c0e ();
res.ssSTNoUiSliderConfigs_Range = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3fbb4babd0ba48852fecc04be37d3c0e() {
OptimizedAttributes = null;
ssSTNoUiSliderConfigs_Range = new ST_841c1f1485f51831db9f4b37a6d551d5Structure();
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
    ssSTNoUiSliderConfigs_Range.OptimizedAttributes = value[0];
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
ssSTNoUiSliderConfigs_Range.Read( r, ref index);
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
public void ReadIM(RC_3fbb4babd0ba48852fecc04be37d3c0e r) {
this = r;
}


public static bool operator == (RC_3fbb4babd0ba48852fecc04be37d3c0e a, RC_3fbb4babd0ba48852fecc04be37d3c0e b) {
if (a.ssSTNoUiSliderConfigs_Range != b.ssSTNoUiSliderConfigs_Range) return false;
return true;
}

public static bool operator != (RC_3fbb4babd0ba48852fecc04be37d3c0e a, RC_3fbb4babd0ba48852fecc04be37d3c0e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3fbb4babd0ba48852fecc04be37d3c0e)) return false;
return (this == (RC_3fbb4babd0ba48852fecc04be37d3c0e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNoUiSliderConfigs_Range.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNoUiSliderConfigs_Range.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNoUiSliderConfigs_Range.InternalRecursiveSave();
}


public RC_3fbb4babd0ba48852fecc04be37d3c0e Duplicate() {
RC_3fbb4babd0ba48852fecc04be37d3c0e t;
t.ssSTNoUiSliderConfigs_Range = (ST_841c1f1485f51831db9f4b37a6d551d5Structure)this.ssSTNoUiSliderConfigs_Range.Duplicate();
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
if (head == "nouisliderconfigs_range") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoUiSliderConfigs_Range")) variable.Value = ssSTNoUiSliderConfigs_Range; else variable.Optimized = true;
variable.SetFieldName("nouisliderconfigs_range");
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
if (key == IdNoUiSliderConfigs_Range) {
return ssSTNoUiSliderConfigs_Range;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNoUiSliderConfigs_Range.Key.AsGuid) {
return ssSTNoUiSliderConfigs_Range;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNoUiSliderConfigs_Range.FillFromOther((IRecord) other.AttributeGet(IdNoUiSliderConfigs_Range));
}
} // RC_3fbb4babd0ba48852fecc04be37d3c0e
/// <summary>
/// RecordList type <code>NoUiSliderConfigs_RangeRecordList</code> that represents a record list of
///  <code>NoUiSliderConfigs_Range</code>
/// </summary>
public partial class RL_acf3198d7827e501ece64b7f57e6f374 : GenericRecordList<RC_3fbb4babd0ba48852fecc04be37d3c0e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3fbb4babd0ba48852fecc04be37d3c0e GetElementDefaultValue() {
return new RC_3fbb4babd0ba48852fecc04be37d3c0e();
}

public T[] ToArray<T>(Func<RC_3fbb4babd0ba48852fecc04be37d3c0e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_acf3198d7827e501ece64b7f57e6f374 recordList, Func<RC_3fbb4babd0ba48852fecc04be37d3c0e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_acf3198d7827e501ece64b7f57e6f374(RC_3fbb4babd0ba48852fecc04be37d3c0e[] array) {
  RL_acf3198d7827e501ece64b7f57e6f374 result = new RL_acf3198d7827e501ece64b7f57e6f374();
result.InnerFromArray(array);
    return result;
}

public static RL_acf3198d7827e501ece64b7f57e6f374 ToList<T>(T[] array, Func <T, RC_3fbb4babd0ba48852fecc04be37d3c0e> converter) {
  RL_acf3198d7827e501ece64b7f57e6f374 result = new RL_acf3198d7827e501ece64b7f57e6f374();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_acf3198d7827e501ece64b7f57e6f374 FromRestList<T>(RestList<T> restList, Func <T, RC_3fbb4babd0ba48852fecc04be37d3c0e> converter) {
  RL_acf3198d7827e501ece64b7f57e6f374 result = new RL_acf3198d7827e501ece64b7f57e6f374();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_acf3198d7827e501ece64b7f57e6f374() : base() {
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
protected override OSList<RC_3fbb4babd0ba48852fecc04be37d3c0e> NewList() {
return new RL_acf3198d7827e501ece64b7f57e6f374();
}


} // RL_acf3198d7827e501ece64b7f57e6f374
}

