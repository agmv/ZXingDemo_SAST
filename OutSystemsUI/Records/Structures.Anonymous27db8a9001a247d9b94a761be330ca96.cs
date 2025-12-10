namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (kIrbJ6IB2Ue5SnYb4zDKlg)
///  <code>RC_d5f1a8119489aabce0fbd0fa422c2185</code> that represent
/// s <code>Rating_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Rating_InternalConfigRecord
public partial struct RC_d5f1a8119489aabce0fbd0fa422c2185 : ITypedRecord<RC_d5f1a8119489aabce0fbd0fa422c2185> {
internal static readonly GlobalObjectKey IdRating_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Eajx1YmUvKrg+9D6QiwhhQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Rating_InternalConfig")]
public ST_69c22c095aca285f3fb706e10e473ba5Structure ssSTRating_InternalConfig;


public static implicit operator ST_69c22c095aca285f3fb706e10e473ba5Structure( RC_d5f1a8119489aabce0fbd0fa422c2185 r) {
return r.ssSTRating_InternalConfig;
}

public static implicit operator RC_d5f1a8119489aabce0fbd0fa422c2185 (ST_69c22c095aca285f3fb706e10e473ba5Structure r) {
RC_d5f1a8119489aabce0fbd0fa422c2185 res = new RC_d5f1a8119489aabce0fbd0fa422c2185 ();
res.ssSTRating_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d5f1a8119489aabce0fbd0fa422c2185() {
OptimizedAttributes = null;
ssSTRating_InternalConfig = new ST_69c22c095aca285f3fb706e10e473ba5Structure();
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
    ssSTRating_InternalConfig.OptimizedAttributes = value[0];
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
ssSTRating_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_d5f1a8119489aabce0fbd0fa422c2185 r) {
this = r;
}


public static bool operator == (RC_d5f1a8119489aabce0fbd0fa422c2185 a, RC_d5f1a8119489aabce0fbd0fa422c2185 b) {
if (a.ssSTRating_InternalConfig != b.ssSTRating_InternalConfig) return false;
return true;
}

public static bool operator != (RC_d5f1a8119489aabce0fbd0fa422c2185 a, RC_d5f1a8119489aabce0fbd0fa422c2185 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d5f1a8119489aabce0fbd0fa422c2185)) return false;
return (this == (RC_d5f1a8119489aabce0fbd0fa422c2185)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRating_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRating_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRating_InternalConfig.InternalRecursiveSave();
}


public RC_d5f1a8119489aabce0fbd0fa422c2185 Duplicate() {
RC_d5f1a8119489aabce0fbd0fa422c2185 t;
t.ssSTRating_InternalConfig = (ST_69c22c095aca285f3fb706e10e473ba5Structure)this.ssSTRating_InternalConfig.Duplicate();
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
if (head == "rating_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Rating_InternalConfig")) variable.Value = ssSTRating_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("rating_internalconfig");
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
if (key == IdRating_InternalConfig) {
return ssSTRating_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRating_InternalConfig.Key.AsGuid) {
return ssSTRating_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRating_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdRating_InternalConfig));
}
} // RC_d5f1a8119489aabce0fbd0fa422c2185
/// <summary>
/// RecordList type <code>Rating_InternalConfigRecordList</code> that represents a record list of
///  <code>Rating_InternalConfig</code>
/// </summary>
public partial class RL_fe6fb4f018033ae17b199f007902ed43 : GenericRecordList<RC_d5f1a8119489aabce0fbd0fa422c2185>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_d5f1a8119489aabce0fbd0fa422c2185 GetElementDefaultValue() {
return new RC_d5f1a8119489aabce0fbd0fa422c2185();
}

public T[] ToArray<T>(Func<RC_d5f1a8119489aabce0fbd0fa422c2185, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fe6fb4f018033ae17b199f007902ed43 recordList, Func<RC_d5f1a8119489aabce0fbd0fa422c2185, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fe6fb4f018033ae17b199f007902ed43(RC_d5f1a8119489aabce0fbd0fa422c2185[] array) {
  RL_fe6fb4f018033ae17b199f007902ed43 result = new RL_fe6fb4f018033ae17b199f007902ed43();
result.InnerFromArray(array);
    return result;
}

public static RL_fe6fb4f018033ae17b199f007902ed43 ToList<T>(T[] array, Func <T, RC_d5f1a8119489aabce0fbd0fa422c2185> converter) {
  RL_fe6fb4f018033ae17b199f007902ed43 result = new RL_fe6fb4f018033ae17b199f007902ed43();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fe6fb4f018033ae17b199f007902ed43 FromRestList<T>(RestList<T> restList, Func <T, RC_d5f1a8119489aabce0fbd0fa422c2185> converter) {
  RL_fe6fb4f018033ae17b199f007902ed43 result = new RL_fe6fb4f018033ae17b199f007902ed43();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fe6fb4f018033ae17b199f007902ed43() : base() {
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
protected override OSList<RC_d5f1a8119489aabce0fbd0fa422c2185> NewList() {
return new RL_fe6fb4f018033ae17b199f007902ed43();
}


} // RL_fe6fb4f018033ae17b199f007902ed43
}

