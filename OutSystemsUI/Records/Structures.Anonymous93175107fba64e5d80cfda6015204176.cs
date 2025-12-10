namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (B1EXk6b7XU6Az9pgFSBBdg)
///  <code>RC_a784fb81632458d6690327bfa77675d9</code> that represents <code>SplideConfigsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SplideConfigsRecord
public partial struct RC_a784fb81632458d6690327bfa77675d9 : ITypedRecord<RC_a784fb81632458d6690327bfa77675d9> {
internal static readonly GlobalObjectKey IdSplideConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gfuEpyRj1lhpAye_p3Z12Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SplideConfigs")]
public ST_3fe78d74e319e2ce842fd51dd2d67caaStructure ssSTSplideConfigs;


public static implicit operator ST_3fe78d74e319e2ce842fd51dd2d67caaStructure( RC_a784fb81632458d6690327bfa77675d9 r) {
return r.ssSTSplideConfigs;
}

public static implicit operator RC_a784fb81632458d6690327bfa77675d9 (ST_3fe78d74e319e2ce842fd51dd2d67caaStructure r) {
RC_a784fb81632458d6690327bfa77675d9 res = new RC_a784fb81632458d6690327bfa77675d9 ();
res.ssSTSplideConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a784fb81632458d6690327bfa77675d9() {
OptimizedAttributes = null;
ssSTSplideConfigs = new ST_3fe78d74e319e2ce842fd51dd2d67caaStructure();
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
    ssSTSplideConfigs.OptimizedAttributes = value[0];
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
ssSTSplideConfigs.Read( r, ref index);
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
public void ReadIM(RC_a784fb81632458d6690327bfa77675d9 r) {
this = r;
}


public static bool operator == (RC_a784fb81632458d6690327bfa77675d9 a, RC_a784fb81632458d6690327bfa77675d9 b) {
if (a.ssSTSplideConfigs != b.ssSTSplideConfigs) return false;
return true;
}

public static bool operator != (RC_a784fb81632458d6690327bfa77675d9 a, RC_a784fb81632458d6690327bfa77675d9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a784fb81632458d6690327bfa77675d9)) return false;
return (this == (RC_a784fb81632458d6690327bfa77675d9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSplideConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSplideConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSplideConfigs.InternalRecursiveSave();
}


public RC_a784fb81632458d6690327bfa77675d9 Duplicate() {
RC_a784fb81632458d6690327bfa77675d9 t;
t.ssSTSplideConfigs = (ST_3fe78d74e319e2ce842fd51dd2d67caaStructure)this.ssSTSplideConfigs.Duplicate();
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
if (head == "splideconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SplideConfigs")) variable.Value = ssSTSplideConfigs; else variable.Optimized = true;
variable.SetFieldName("splideconfigs");
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
if (key == IdSplideConfigs) {
return ssSTSplideConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSplideConfigs.Key.AsGuid) {
return ssSTSplideConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSplideConfigs.FillFromOther((IRecord) other.AttributeGet(IdSplideConfigs));
}
} // RC_a784fb81632458d6690327bfa77675d9
/// <summary>
/// RecordList type <code>SplideConfigsRecordList</code> that represents a record list of
///  <code>SplideConfigs</code>
/// </summary>
public partial class RL_b81a693ea5fe206cf847a51f9be40beb : GenericRecordList<RC_a784fb81632458d6690327bfa77675d9>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a784fb81632458d6690327bfa77675d9 GetElementDefaultValue() {
return new RC_a784fb81632458d6690327bfa77675d9();
}

public T[] ToArray<T>(Func<RC_a784fb81632458d6690327bfa77675d9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b81a693ea5fe206cf847a51f9be40beb recordList, Func<RC_a784fb81632458d6690327bfa77675d9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b81a693ea5fe206cf847a51f9be40beb(RC_a784fb81632458d6690327bfa77675d9[] array) {
  RL_b81a693ea5fe206cf847a51f9be40beb result = new RL_b81a693ea5fe206cf847a51f9be40beb();
result.InnerFromArray(array);
    return result;
}

public static RL_b81a693ea5fe206cf847a51f9be40beb ToList<T>(T[] array, Func <T, RC_a784fb81632458d6690327bfa77675d9> converter) {
  RL_b81a693ea5fe206cf847a51f9be40beb result = new RL_b81a693ea5fe206cf847a51f9be40beb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b81a693ea5fe206cf847a51f9be40beb FromRestList<T>(RestList<T> restList, Func <T, RC_a784fb81632458d6690327bfa77675d9> converter) {
  RL_b81a693ea5fe206cf847a51f9be40beb result = new RL_b81a693ea5fe206cf847a51f9be40beb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b81a693ea5fe206cf847a51f9be40beb() : base() {
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
protected override OSList<RC_a784fb81632458d6690327bfa77675d9> NewList() {
return new RL_b81a693ea5fe206cf847a51f9be40beb();
}


} // RL_b81a693ea5fe206cf847a51f9be40beb
}

