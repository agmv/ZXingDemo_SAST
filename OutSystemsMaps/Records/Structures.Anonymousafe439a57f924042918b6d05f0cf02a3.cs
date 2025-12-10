namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (pTnkr5J_QkCRi20F8M8Cow)
///  <code>RC_6beef079e29e7256385ac77b93f8d4bb</code> that represent
/// s <code>Internal_Shape_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_Shape_ConfigsRecord
public partial struct RC_6beef079e29e7256385ac77b93f8d4bb : ITypedRecord<RC_6beef079e29e7256385ac77b93f8d4bb> {
internal static readonly GlobalObjectKey IdInternal_Shape_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*efDua57iVnI4Wsd7k_jUuw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_Shape_Configs")]
public ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure ssSTInternal_Shape_Configs;


public static implicit operator ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure( RC_6beef079e29e7256385ac77b93f8d4bb r) {
return r.ssSTInternal_Shape_Configs;
}

public static implicit operator RC_6beef079e29e7256385ac77b93f8d4bb (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure r) {
RC_6beef079e29e7256385ac77b93f8d4bb res = new RC_6beef079e29e7256385ac77b93f8d4bb ();
res.ssSTInternal_Shape_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6beef079e29e7256385ac77b93f8d4bb() {
OptimizedAttributes = null;
ssSTInternal_Shape_Configs = new ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure();
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
    ssSTInternal_Shape_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_Shape_Configs.Read( r, ref index);
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
public void ReadIM(RC_6beef079e29e7256385ac77b93f8d4bb r) {
this = r;
}


public static bool operator == (RC_6beef079e29e7256385ac77b93f8d4bb a, RC_6beef079e29e7256385ac77b93f8d4bb b) {
if (a.ssSTInternal_Shape_Configs != b.ssSTInternal_Shape_Configs) return false;
return true;
}

public static bool operator != (RC_6beef079e29e7256385ac77b93f8d4bb a, RC_6beef079e29e7256385ac77b93f8d4bb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6beef079e29e7256385ac77b93f8d4bb)) return false;
return (this == (RC_6beef079e29e7256385ac77b93f8d4bb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_Shape_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_Shape_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_Shape_Configs.InternalRecursiveSave();
}


public RC_6beef079e29e7256385ac77b93f8d4bb Duplicate() {
RC_6beef079e29e7256385ac77b93f8d4bb t;
t.ssSTInternal_Shape_Configs = (ST_2f5ec17a6f7c3827bc8a33107ce38ec9Structure)this.ssSTInternal_Shape_Configs.Duplicate();
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
if (head == "internal_shape_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_Shape_Configs")) variable.Value = ssSTInternal_Shape_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_shape_configs");
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
if (key == IdInternal_Shape_Configs) {
return ssSTInternal_Shape_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_Shape_Configs.Key.AsGuid) {
return ssSTInternal_Shape_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_Shape_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_Shape_Configs));
}
} // RC_6beef079e29e7256385ac77b93f8d4bb
/// <summary>
/// RecordList type <code>Internal_Shape_ConfigsRecordList</code> that represents a record list of
///  <code>Internal_Shape_Configs</code>
/// </summary>
public partial class RL_aed7bfc55da2af3c9f376ba85cda12e8 : GenericRecordList<RC_6beef079e29e7256385ac77b93f8d4bb>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_6beef079e29e7256385ac77b93f8d4bb GetElementDefaultValue() {
return new RC_6beef079e29e7256385ac77b93f8d4bb();
}

public T[] ToArray<T>(Func<RC_6beef079e29e7256385ac77b93f8d4bb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aed7bfc55da2af3c9f376ba85cda12e8 recordList, Func<RC_6beef079e29e7256385ac77b93f8d4bb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aed7bfc55da2af3c9f376ba85cda12e8(RC_6beef079e29e7256385ac77b93f8d4bb[] array) {
  RL_aed7bfc55da2af3c9f376ba85cda12e8 result = new RL_aed7bfc55da2af3c9f376ba85cda12e8();
result.InnerFromArray(array);
    return result;
}

public static RL_aed7bfc55da2af3c9f376ba85cda12e8 ToList<T>(T[] array, Func <T, RC_6beef079e29e7256385ac77b93f8d4bb> converter) {
  RL_aed7bfc55da2af3c9f376ba85cda12e8 result = new RL_aed7bfc55da2af3c9f376ba85cda12e8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aed7bfc55da2af3c9f376ba85cda12e8 FromRestList<T>(RestList<T> restList, Func <T, RC_6beef079e29e7256385ac77b93f8d4bb> converter) {
  RL_aed7bfc55da2af3c9f376ba85cda12e8 result = new RL_aed7bfc55da2af3c9f376ba85cda12e8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aed7bfc55da2af3c9f376ba85cda12e8() : base() {
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
protected override OSList<RC_6beef079e29e7256385ac77b93f8d4bb> NewList() {
return new RL_aed7bfc55da2af3c9f376ba85cda12e8();
}


} // RL_aed7bfc55da2af3c9f376ba85cda12e8
}

