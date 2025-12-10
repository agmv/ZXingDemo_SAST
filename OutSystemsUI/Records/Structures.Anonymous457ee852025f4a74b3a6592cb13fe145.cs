namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (Uuh+RV8CdEqzplkssT_hRQ)
///  <code>RC_0832b315fa435e0ff97aca2a0ca6bd44</code> that represents <code>ProgressTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProgressTypeRecord
public partial struct RC_0832b315fa435e0ff97aca2a0ca6bd44 : ITypedRecord<RC_0832b315fa435e0ff97aca2a0ca6bd44> {
internal static readonly GlobalObjectKey IdProgressType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FbMyCEP6D175esoqDKa9RA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ProgressType")]
public EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord ssENProgressType;


public static implicit operator EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord( RC_0832b315fa435e0ff97aca2a0ca6bd44 r) {
return r.ssENProgressType;
}

public static implicit operator RC_0832b315fa435e0ff97aca2a0ca6bd44 (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord r) {
RC_0832b315fa435e0ff97aca2a0ca6bd44 res = new RC_0832b315fa435e0ff97aca2a0ca6bd44 ();
res.ssENProgressType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProgressType.ChangedAttributes = value;
}
get {
    return ssENProgressType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0832b315fa435e0ff97aca2a0ca6bd44() {
OptimizedAttributes = null;
ssENProgressType = new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProgressType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProgressType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProgressType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProgressType.Read( r, ref index);
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
public void ReadIM(RC_0832b315fa435e0ff97aca2a0ca6bd44 r) {
this = r;
}


public static bool operator == (RC_0832b315fa435e0ff97aca2a0ca6bd44 a, RC_0832b315fa435e0ff97aca2a0ca6bd44 b) {
if (a.ssENProgressType != b.ssENProgressType) return false;
return true;
}

public static bool operator != (RC_0832b315fa435e0ff97aca2a0ca6bd44 a, RC_0832b315fa435e0ff97aca2a0ca6bd44 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0832b315fa435e0ff97aca2a0ca6bd44)) return false;
return (this == (RC_0832b315fa435e0ff97aca2a0ca6bd44)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProgressType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProgressType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProgressType.InternalRecursiveSave();
}


public RC_0832b315fa435e0ff97aca2a0ca6bd44 Duplicate() {
RC_0832b315fa435e0ff97aca2a0ca6bd44 t;
t.ssENProgressType = (EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord)this.ssENProgressType.Duplicate();
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
if (head == "progresstype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressType")) variable.Value = ssENProgressType; else variable.Optimized = true;
variable.SetFieldName("progresstype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProgressType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProgressType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProgressType) {
return ssENProgressType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProgressType.Key.AsGuid) {
return ssENProgressType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProgressType.FillFromOther((IRecord) other.AttributeGet(IdProgressType));
}
} // RC_0832b315fa435e0ff97aca2a0ca6bd44
/// <summary>
/// RecordList type <code>ProgressTypeRecordList</code> that represents a record list of
///  <code>ProgressType</code>
/// </summary>
public partial class RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 : GenericRecordList<RC_0832b315fa435e0ff97aca2a0ca6bd44>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0832b315fa435e0ff97aca2a0ca6bd44 GetElementDefaultValue() {
return new RC_0832b315fa435e0ff97aca2a0ca6bd44();
}

public T[] ToArray<T>(Func<RC_0832b315fa435e0ff97aca2a0ca6bd44, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 recordList, Func<RC_0832b315fa435e0ff97aca2a0ca6bd44, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4(RC_0832b315fa435e0ff97aca2a0ca6bd44[] array) {
  RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 result = new RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4();
result.InnerFromArray(array);
    return result;
}

public static RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 ToList<T>(T[] array, Func <T, RC_0832b315fa435e0ff97aca2a0ca6bd44> converter) {
  RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 result = new RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 FromRestList<T>(RestList<T> restList, Func <T, RC_0832b315fa435e0ff97aca2a0ca6bd44> converter) {
  RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4 result = new RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4() : base() {
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
protected override OSList<RC_0832b315fa435e0ff97aca2a0ca6bd44> NewList() {
return new RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4();
}


} // RL_43d8e9ecdc8162bbe976ff0cc1fbc6e4
}

