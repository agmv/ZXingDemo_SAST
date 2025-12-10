namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (q6jmGU90SECIkA0eD116sA)
///  <code>RC_3af5daa8009f6f7f8a09f38255a62078</code> that represent
/// s <code>DatePicker_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePicker_InternalConfigRecord
public partial struct RC_3af5daa8009f6f7f8a09f38255a62078 : ITypedRecord<RC_3af5daa8009f6f7f8a09f38255a62078> {
internal static readonly GlobalObjectKey IdDatePicker_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qNr1Op8Af2+KCfOCVaYgeA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DatePicker_InternalConfig")]
public ST_cd3e064c4ee8b37ab96945c09d5d2155Structure ssSTDatePicker_InternalConfig;


public static implicit operator ST_cd3e064c4ee8b37ab96945c09d5d2155Structure( RC_3af5daa8009f6f7f8a09f38255a62078 r) {
return r.ssSTDatePicker_InternalConfig;
}

public static implicit operator RC_3af5daa8009f6f7f8a09f38255a62078 (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure r) {
RC_3af5daa8009f6f7f8a09f38255a62078 res = new RC_3af5daa8009f6f7f8a09f38255a62078 ();
res.ssSTDatePicker_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3af5daa8009f6f7f8a09f38255a62078() {
OptimizedAttributes = null;
ssSTDatePicker_InternalConfig = new ST_cd3e064c4ee8b37ab96945c09d5d2155Structure();
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
    ssSTDatePicker_InternalConfig.OptimizedAttributes = value[0];
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
ssSTDatePicker_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_3af5daa8009f6f7f8a09f38255a62078 r) {
this = r;
}


public static bool operator == (RC_3af5daa8009f6f7f8a09f38255a62078 a, RC_3af5daa8009f6f7f8a09f38255a62078 b) {
if (a.ssSTDatePicker_InternalConfig != b.ssSTDatePicker_InternalConfig) return false;
return true;
}

public static bool operator != (RC_3af5daa8009f6f7f8a09f38255a62078 a, RC_3af5daa8009f6f7f8a09f38255a62078 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3af5daa8009f6f7f8a09f38255a62078)) return false;
return (this == (RC_3af5daa8009f6f7f8a09f38255a62078)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDatePicker_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDatePicker_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDatePicker_InternalConfig.InternalRecursiveSave();
}


public RC_3af5daa8009f6f7f8a09f38255a62078 Duplicate() {
RC_3af5daa8009f6f7f8a09f38255a62078 t;
t.ssSTDatePicker_InternalConfig = (ST_cd3e064c4ee8b37ab96945c09d5d2155Structure)this.ssSTDatePicker_InternalConfig.Duplicate();
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
if (head == "datepicker_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePicker_InternalConfig")) variable.Value = ssSTDatePicker_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("datepicker_internalconfig");
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
if (key == IdDatePicker_InternalConfig) {
return ssSTDatePicker_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePicker_InternalConfig.Key.AsGuid) {
return ssSTDatePicker_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDatePicker_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdDatePicker_InternalConfig));
}
} // RC_3af5daa8009f6f7f8a09f38255a62078
/// <summary>
/// RecordList type <code>DatePicker_InternalConfigRecordList</code> that represents a record list of
///  <code>DatePicker_InternalConfig</code>
/// </summary>
public partial class RL_86a710fa3061d711a5a3426a0542a93a : GenericRecordList<RC_3af5daa8009f6f7f8a09f38255a62078>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3af5daa8009f6f7f8a09f38255a62078 GetElementDefaultValue() {
return new RC_3af5daa8009f6f7f8a09f38255a62078();
}

public T[] ToArray<T>(Func<RC_3af5daa8009f6f7f8a09f38255a62078, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_86a710fa3061d711a5a3426a0542a93a recordList, Func<RC_3af5daa8009f6f7f8a09f38255a62078, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_86a710fa3061d711a5a3426a0542a93a(RC_3af5daa8009f6f7f8a09f38255a62078[] array) {
  RL_86a710fa3061d711a5a3426a0542a93a result = new RL_86a710fa3061d711a5a3426a0542a93a();
result.InnerFromArray(array);
    return result;
}

public static RL_86a710fa3061d711a5a3426a0542a93a ToList<T>(T[] array, Func <T, RC_3af5daa8009f6f7f8a09f38255a62078> converter) {
  RL_86a710fa3061d711a5a3426a0542a93a result = new RL_86a710fa3061d711a5a3426a0542a93a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_86a710fa3061d711a5a3426a0542a93a FromRestList<T>(RestList<T> restList, Func <T, RC_3af5daa8009f6f7f8a09f38255a62078> converter) {
  RL_86a710fa3061d711a5a3426a0542a93a result = new RL_86a710fa3061d711a5a3426a0542a93a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_86a710fa3061d711a5a3426a0542a93a() : base() {
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
protected override OSList<RC_3af5daa8009f6f7f8a09f38255a62078> NewList() {
return new RL_86a710fa3061d711a5a3426a0542a93a();
}


} // RL_86a710fa3061d711a5a3426a0542a93a
}

