namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (Fi8s+R+RuEqGKouAepLMwg)
///  <code>RC_098c46906c1c0c7e7b39f1210fb64f78</code> that represent
/// s <code>ShapeEventTriggeredRecord</code> <p>Description: </p>
/// </summary>
// Name: ShapeEventTriggeredRecord
public partial struct RC_098c46906c1c0c7e7b39f1210fb64f78 : ITypedRecord<RC_098c46906c1c0c7e7b39f1210fb64f78> {
internal static readonly GlobalObjectKey IdShapeEventTriggered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kEaMCRxsfgx7OfEhD7ZPeA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ShapeEventTriggered")]
public EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord ssENShapeEventTriggered;


public static implicit operator EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord( RC_098c46906c1c0c7e7b39f1210fb64f78 r) {
return r.ssENShapeEventTriggered;
}

public static implicit operator RC_098c46906c1c0c7e7b39f1210fb64f78 (EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord r) {
RC_098c46906c1c0c7e7b39f1210fb64f78 res = new RC_098c46906c1c0c7e7b39f1210fb64f78 ();
res.ssENShapeEventTriggered = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENShapeEventTriggered.ChangedAttributes = value;
}
get {
    return ssENShapeEventTriggered.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_098c46906c1c0c7e7b39f1210fb64f78() {
OptimizedAttributes = null;
ssENShapeEventTriggered = new EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENShapeEventTriggered.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENShapeEventTriggered.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENShapeEventTriggered.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENShapeEventTriggered.Read( r, ref index);
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
public void ReadIM(RC_098c46906c1c0c7e7b39f1210fb64f78 r) {
this = r;
}


public static bool operator == (RC_098c46906c1c0c7e7b39f1210fb64f78 a, RC_098c46906c1c0c7e7b39f1210fb64f78 b) {
if (a.ssENShapeEventTriggered != b.ssENShapeEventTriggered) return false;
return true;
}

public static bool operator != (RC_098c46906c1c0c7e7b39f1210fb64f78 a, RC_098c46906c1c0c7e7b39f1210fb64f78 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_098c46906c1c0c7e7b39f1210fb64f78)) return false;
return (this == (RC_098c46906c1c0c7e7b39f1210fb64f78)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENShapeEventTriggered.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENShapeEventTriggered.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENShapeEventTriggered.InternalRecursiveSave();
}


public RC_098c46906c1c0c7e7b39f1210fb64f78 Duplicate() {
RC_098c46906c1c0c7e7b39f1210fb64f78 t;
t.ssENShapeEventTriggered = (EN_d5303c5dfa3a0e0e964776dce02c36f0EntityRecord)this.ssENShapeEventTriggered.Duplicate();
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
if (head == "shapeeventtriggered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShapeEventTriggered")) variable.Value = ssENShapeEventTriggered; else variable.Optimized = true;
variable.SetFieldName("shapeeventtriggered");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENShapeEventTriggered.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENShapeEventTriggered.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdShapeEventTriggered) {
return ssENShapeEventTriggered;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShapeEventTriggered.Key.AsGuid) {
return ssENShapeEventTriggered;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENShapeEventTriggered.FillFromOther((IRecord) other.AttributeGet(IdShapeEventTriggered));
}
} // RC_098c46906c1c0c7e7b39f1210fb64f78
/// <summary>
/// RecordList type <code>ShapeEventTriggeredRecordList</code> that represents a record list of
///  <code>ShapeEventTriggered</code>
/// </summary>
public partial class RL_4805e15f00dc12c56ca2c04862bba5ec : GenericRecordList<RC_098c46906c1c0c7e7b39f1210fb64f78>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_098c46906c1c0c7e7b39f1210fb64f78 GetElementDefaultValue() {
return new RC_098c46906c1c0c7e7b39f1210fb64f78();
}

public T[] ToArray<T>(Func<RC_098c46906c1c0c7e7b39f1210fb64f78, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4805e15f00dc12c56ca2c04862bba5ec recordList, Func<RC_098c46906c1c0c7e7b39f1210fb64f78, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4805e15f00dc12c56ca2c04862bba5ec(RC_098c46906c1c0c7e7b39f1210fb64f78[] array) {
  RL_4805e15f00dc12c56ca2c04862bba5ec result = new RL_4805e15f00dc12c56ca2c04862bba5ec();
result.InnerFromArray(array);
    return result;
}

public static RL_4805e15f00dc12c56ca2c04862bba5ec ToList<T>(T[] array, Func <T, RC_098c46906c1c0c7e7b39f1210fb64f78> converter) {
  RL_4805e15f00dc12c56ca2c04862bba5ec result = new RL_4805e15f00dc12c56ca2c04862bba5ec();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4805e15f00dc12c56ca2c04862bba5ec FromRestList<T>(RestList<T> restList, Func <T, RC_098c46906c1c0c7e7b39f1210fb64f78> converter) {
  RL_4805e15f00dc12c56ca2c04862bba5ec result = new RL_4805e15f00dc12c56ca2c04862bba5ec();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4805e15f00dc12c56ca2c04862bba5ec() : base() {
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
protected override OSList<RC_098c46906c1c0c7e7b39f1210fb64f78> NewList() {
return new RL_4805e15f00dc12c56ca2c04862bba5ec();
}


} // RL_4805e15f00dc12c56ca2c04862bba5ec
}

