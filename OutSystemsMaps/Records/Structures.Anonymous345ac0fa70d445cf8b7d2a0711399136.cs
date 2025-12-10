namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (+sBaNNRwz0WLfSoHETmRNg)
///  <code>RC_c81197f1ff862582a2342ed17a50f086</code> that represents <code>ExcludeCriteriaRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ExcludeCriteriaRecord
public partial struct RC_c81197f1ff862582a2342ed17a50f086 : ITypedRecord<RC_c81197f1ff862582a2342ed17a50f086> {
internal static readonly GlobalObjectKey IdExcludeCriteria = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8ZcRyIb_giWiNC7RelDwhg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ExcludeCriteria")]
public ST_78fd8c130caeaf241d821392d1010014Structure ssSTExcludeCriteria;


public static implicit operator ST_78fd8c130caeaf241d821392d1010014Structure( RC_c81197f1ff862582a2342ed17a50f086 r) {
return r.ssSTExcludeCriteria;
}

public static implicit operator RC_c81197f1ff862582a2342ed17a50f086 (ST_78fd8c130caeaf241d821392d1010014Structure r) {
RC_c81197f1ff862582a2342ed17a50f086 res = new RC_c81197f1ff862582a2342ed17a50f086 ();
res.ssSTExcludeCriteria = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c81197f1ff862582a2342ed17a50f086() {
OptimizedAttributes = null;
ssSTExcludeCriteria = new ST_78fd8c130caeaf241d821392d1010014Structure();
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
    ssSTExcludeCriteria.OptimizedAttributes = value[0];
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
ssSTExcludeCriteria.Read( r, ref index);
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
public void ReadIM(RC_c81197f1ff862582a2342ed17a50f086 r) {
this = r;
}


public static bool operator == (RC_c81197f1ff862582a2342ed17a50f086 a, RC_c81197f1ff862582a2342ed17a50f086 b) {
if (a.ssSTExcludeCriteria != b.ssSTExcludeCriteria) return false;
return true;
}

public static bool operator != (RC_c81197f1ff862582a2342ed17a50f086 a, RC_c81197f1ff862582a2342ed17a50f086 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c81197f1ff862582a2342ed17a50f086)) return false;
return (this == (RC_c81197f1ff862582a2342ed17a50f086)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcludeCriteria.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcludeCriteria.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcludeCriteria.InternalRecursiveSave();
}


public RC_c81197f1ff862582a2342ed17a50f086 Duplicate() {
RC_c81197f1ff862582a2342ed17a50f086 t;
t.ssSTExcludeCriteria = (ST_78fd8c130caeaf241d821392d1010014Structure)this.ssSTExcludeCriteria.Duplicate();
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
if (head == "excludecriteria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcludeCriteria")) variable.Value = ssSTExcludeCriteria; else variable.Optimized = true;
variable.SetFieldName("excludecriteria");
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
if (key == IdExcludeCriteria) {
return ssSTExcludeCriteria;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcludeCriteria.Key.AsGuid) {
return ssSTExcludeCriteria;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcludeCriteria.FillFromOther((IRecord) other.AttributeGet(IdExcludeCriteria));
}
} // RC_c81197f1ff862582a2342ed17a50f086
/// <summary>
/// RecordList type <code>ExcludeCriteriaRecordList</code> that represents a record list of
///  <code>ExcludeCriteria</code>
/// </summary>
public partial class RL_4624f4b70e2046b470a77346edfc0bcc : GenericRecordList<RC_c81197f1ff862582a2342ed17a50f086>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c81197f1ff862582a2342ed17a50f086 GetElementDefaultValue() {
return new RC_c81197f1ff862582a2342ed17a50f086();
}

public T[] ToArray<T>(Func<RC_c81197f1ff862582a2342ed17a50f086, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4624f4b70e2046b470a77346edfc0bcc recordList, Func<RC_c81197f1ff862582a2342ed17a50f086, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4624f4b70e2046b470a77346edfc0bcc(RC_c81197f1ff862582a2342ed17a50f086[] array) {
  RL_4624f4b70e2046b470a77346edfc0bcc result = new RL_4624f4b70e2046b470a77346edfc0bcc();
result.InnerFromArray(array);
    return result;
}

public static RL_4624f4b70e2046b470a77346edfc0bcc ToList<T>(T[] array, Func <T, RC_c81197f1ff862582a2342ed17a50f086> converter) {
  RL_4624f4b70e2046b470a77346edfc0bcc result = new RL_4624f4b70e2046b470a77346edfc0bcc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4624f4b70e2046b470a77346edfc0bcc FromRestList<T>(RestList<T> restList, Func <T, RC_c81197f1ff862582a2342ed17a50f086> converter) {
  RL_4624f4b70e2046b470a77346edfc0bcc result = new RL_4624f4b70e2046b470a77346edfc0bcc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4624f4b70e2046b470a77346edfc0bcc() : base() {
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
protected override OSList<RC_c81197f1ff862582a2342ed17a50f086> NewList() {
return new RL_4624f4b70e2046b470a77346edfc0bcc();
}


} // RL_4624f4b70e2046b470a77346edfc0bcc
}

