namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (TFHPw3xPUEGrXnKXbVRFhQ)
///  <code>RC_bb80a04f7ea6a5bb3d33db9b2bca4c88</code> that represent
/// s <code>TimePickerOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: TimePickerOptionalConfigsRecord
public partial struct RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 : ITypedRecord<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> {
internal static readonly GlobalObjectKey IdTimePickerOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T6CAu6Z+u6U9M9ubK8pMiA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("TimePickerOptionalConfigs")]
public ST_b96c67f06fdfae580256b7081d85460dStructure ssSTTimePickerOptionalConfigs;


public static implicit operator ST_b96c67f06fdfae580256b7081d85460dStructure( RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 r) {
return r.ssSTTimePickerOptionalConfigs;
}

public static implicit operator RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 (ST_b96c67f06fdfae580256b7081d85460dStructure r) {
RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 res = new RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 ();
res.ssSTTimePickerOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bb80a04f7ea6a5bb3d33db9b2bca4c88() {
OptimizedAttributes = null;
ssSTTimePickerOptionalConfigs = new ST_b96c67f06fdfae580256b7081d85460dStructure();
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
    ssSTTimePickerOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTTimePickerOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 r) {
this = r;
}


public static bool operator == (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 a, RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 b) {
if (a.ssSTTimePickerOptionalConfigs != b.ssSTTimePickerOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 a, RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88)) return false;
return (this == (RC_bb80a04f7ea6a5bb3d33db9b2bca4c88)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTimePickerOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTimePickerOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTimePickerOptionalConfigs.InternalRecursiveSave();
}


public RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 Duplicate() {
RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 t;
t.ssSTTimePickerOptionalConfigs = (ST_b96c67f06fdfae580256b7081d85460dStructure)this.ssSTTimePickerOptionalConfigs.Duplicate();
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
if (head == "timepickeroptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimePickerOptionalConfigs")) variable.Value = ssSTTimePickerOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("timepickeroptionalconfigs");
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
if (key == IdTimePickerOptionalConfigs) {
return ssSTTimePickerOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTimePickerOptionalConfigs.Key.AsGuid) {
return ssSTTimePickerOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTimePickerOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdTimePickerOptionalConfigs));
}
} // RC_bb80a04f7ea6a5bb3d33db9b2bca4c88
/// <summary>
/// RecordList type <code>TimePickerOptionalConfigsRecordList</code> that represents a record list of
///  <code>TimePickerOptionalConfigs</code>
/// </summary>
public partial class RL_f6b054c71a69c2b6a6022397c94198cd : GenericRecordList<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_bb80a04f7ea6a5bb3d33db9b2bca4c88 GetElementDefaultValue() {
return new RC_bb80a04f7ea6a5bb3d33db9b2bca4c88();
}

public T[] ToArray<T>(Func<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6b054c71a69c2b6a6022397c94198cd recordList, Func<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6b054c71a69c2b6a6022397c94198cd(RC_bb80a04f7ea6a5bb3d33db9b2bca4c88[] array) {
  RL_f6b054c71a69c2b6a6022397c94198cd result = new RL_f6b054c71a69c2b6a6022397c94198cd();
result.InnerFromArray(array);
    return result;
}

public static RL_f6b054c71a69c2b6a6022397c94198cd ToList<T>(T[] array, Func <T, RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> converter) {
  RL_f6b054c71a69c2b6a6022397c94198cd result = new RL_f6b054c71a69c2b6a6022397c94198cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6b054c71a69c2b6a6022397c94198cd FromRestList<T>(RestList<T> restList, Func <T, RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> converter) {
  RL_f6b054c71a69c2b6a6022397c94198cd result = new RL_f6b054c71a69c2b6a6022397c94198cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6b054c71a69c2b6a6022397c94198cd() : base() {
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
protected override OSList<RC_bb80a04f7ea6a5bb3d33db9b2bca4c88> NewList() {
return new RL_f6b054c71a69c2b6a6022397c94198cd();
}


} // RL_f6b054c71a69c2b6a6022397c94198cd
}

