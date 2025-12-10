namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (idZjdKTob0CAnI_RE66q_A)
///  <code>RC_954cd1231210e70f33f184017bf580ac</code> that represents <code>MenuActionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MenuActionRecord
public partial struct RC_954cd1231210e70f33f184017bf580ac : ITypedRecord<RC_954cd1231210e70f33f184017bf580ac> {
internal static readonly GlobalObjectKey IdMenuAction = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*I9FMlRASD+cz8YQBe_WArA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MenuAction")]
public EN_f43f179caddf7f7b68b18272d67285d6EntityRecord ssENMenuAction;


public static implicit operator EN_f43f179caddf7f7b68b18272d67285d6EntityRecord( RC_954cd1231210e70f33f184017bf580ac r) {
return r.ssENMenuAction;
}

public static implicit operator RC_954cd1231210e70f33f184017bf580ac (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord r) {
RC_954cd1231210e70f33f184017bf580ac res = new RC_954cd1231210e70f33f184017bf580ac ();
res.ssENMenuAction = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMenuAction.ChangedAttributes = value;
}
get {
    return ssENMenuAction.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_954cd1231210e70f33f184017bf580ac() {
OptimizedAttributes = null;
ssENMenuAction = new EN_f43f179caddf7f7b68b18272d67285d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMenuAction.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMenuAction.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMenuAction.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMenuAction.Read( r, ref index);
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
public void ReadIM(RC_954cd1231210e70f33f184017bf580ac r) {
this = r;
}


public static bool operator == (RC_954cd1231210e70f33f184017bf580ac a, RC_954cd1231210e70f33f184017bf580ac b) {
if (a.ssENMenuAction != b.ssENMenuAction) return false;
return true;
}

public static bool operator != (RC_954cd1231210e70f33f184017bf580ac a, RC_954cd1231210e70f33f184017bf580ac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_954cd1231210e70f33f184017bf580ac)) return false;
return (this == (RC_954cd1231210e70f33f184017bf580ac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMenuAction.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMenuAction.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMenuAction.InternalRecursiveSave();
}


public RC_954cd1231210e70f33f184017bf580ac Duplicate() {
RC_954cd1231210e70f33f184017bf580ac t;
t.ssENMenuAction = (EN_f43f179caddf7f7b68b18272d67285d6EntityRecord)this.ssENMenuAction.Duplicate();
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
if (head == "menuaction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MenuAction")) variable.Value = ssENMenuAction; else variable.Optimized = true;
variable.SetFieldName("menuaction");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMenuAction.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMenuAction.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMenuAction) {
return ssENMenuAction;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMenuAction.Key.AsGuid) {
return ssENMenuAction;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMenuAction.FillFromOther((IRecord) other.AttributeGet(IdMenuAction));
}
} // RC_954cd1231210e70f33f184017bf580ac
/// <summary>
/// RecordList type <code>MenuActionRecordList</code> that represents a record list of
///  <code>MenuAction</code>
/// </summary>
public partial class RL_2cadeb0c6f7df3cfbe06d89edb556615 : GenericRecordList<RC_954cd1231210e70f33f184017bf580ac>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_954cd1231210e70f33f184017bf580ac GetElementDefaultValue() {
return new RC_954cd1231210e70f33f184017bf580ac();
}

public T[] ToArray<T>(Func<RC_954cd1231210e70f33f184017bf580ac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2cadeb0c6f7df3cfbe06d89edb556615 recordList, Func<RC_954cd1231210e70f33f184017bf580ac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2cadeb0c6f7df3cfbe06d89edb556615(RC_954cd1231210e70f33f184017bf580ac[] array) {
  RL_2cadeb0c6f7df3cfbe06d89edb556615 result = new RL_2cadeb0c6f7df3cfbe06d89edb556615();
result.InnerFromArray(array);
    return result;
}

public static RL_2cadeb0c6f7df3cfbe06d89edb556615 ToList<T>(T[] array, Func <T, RC_954cd1231210e70f33f184017bf580ac> converter) {
  RL_2cadeb0c6f7df3cfbe06d89edb556615 result = new RL_2cadeb0c6f7df3cfbe06d89edb556615();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2cadeb0c6f7df3cfbe06d89edb556615 FromRestList<T>(RestList<T> restList, Func <T, RC_954cd1231210e70f33f184017bf580ac> converter) {
  RL_2cadeb0c6f7df3cfbe06d89edb556615 result = new RL_2cadeb0c6f7df3cfbe06d89edb556615();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2cadeb0c6f7df3cfbe06d89edb556615() : base() {
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
protected override OSList<RC_954cd1231210e70f33f184017bf580ac> NewList() {
return new RL_2cadeb0c6f7df3cfbe06d89edb556615();
}


} // RL_2cadeb0c6f7df3cfbe06d89edb556615
}

