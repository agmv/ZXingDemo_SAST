namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (yRkCMNrspUajPLUUzHaRUg)
///  <code>RC_2afa68ebeade43c502f553bf208d417d</code> that represent
/// s <code>Internal_DrawRectangle_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawRectangle_ConfigsRecord
public partial struct RC_2afa68ebeade43c502f553bf208d417d : ITypedRecord<RC_2afa68ebeade43c502f553bf208d417d> {
internal static readonly GlobalObjectKey IdInternal_DrawRectangle_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*62j6Kt7qxUMC9VO_II1BfQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawRectangle_Configs")]
public ST_9df57e801e7478aaf703933c17abb4f6Structure ssSTInternal_DrawRectangle_Configs;


public static implicit operator ST_9df57e801e7478aaf703933c17abb4f6Structure( RC_2afa68ebeade43c502f553bf208d417d r) {
return r.ssSTInternal_DrawRectangle_Configs;
}

public static implicit operator RC_2afa68ebeade43c502f553bf208d417d (ST_9df57e801e7478aaf703933c17abb4f6Structure r) {
RC_2afa68ebeade43c502f553bf208d417d res = new RC_2afa68ebeade43c502f553bf208d417d ();
res.ssSTInternal_DrawRectangle_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2afa68ebeade43c502f553bf208d417d() {
OptimizedAttributes = null;
ssSTInternal_DrawRectangle_Configs = new ST_9df57e801e7478aaf703933c17abb4f6Structure();
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
    ssSTInternal_DrawRectangle_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_DrawRectangle_Configs.Read( r, ref index);
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
public void ReadIM(RC_2afa68ebeade43c502f553bf208d417d r) {
this = r;
}


public static bool operator == (RC_2afa68ebeade43c502f553bf208d417d a, RC_2afa68ebeade43c502f553bf208d417d b) {
if (a.ssSTInternal_DrawRectangle_Configs != b.ssSTInternal_DrawRectangle_Configs) return false;
return true;
}

public static bool operator != (RC_2afa68ebeade43c502f553bf208d417d a, RC_2afa68ebeade43c502f553bf208d417d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2afa68ebeade43c502f553bf208d417d)) return false;
return (this == (RC_2afa68ebeade43c502f553bf208d417d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawRectangle_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawRectangle_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawRectangle_Configs.InternalRecursiveSave();
}


public RC_2afa68ebeade43c502f553bf208d417d Duplicate() {
RC_2afa68ebeade43c502f553bf208d417d t;
t.ssSTInternal_DrawRectangle_Configs = (ST_9df57e801e7478aaf703933c17abb4f6Structure)this.ssSTInternal_DrawRectangle_Configs.Duplicate();
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
if (head == "internal_drawrectangle_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawRectangle_Configs")) variable.Value = ssSTInternal_DrawRectangle_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_drawrectangle_configs");
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
if (key == IdInternal_DrawRectangle_Configs) {
return ssSTInternal_DrawRectangle_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawRectangle_Configs.Key.AsGuid) {
return ssSTInternal_DrawRectangle_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawRectangle_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawRectangle_Configs));
}
} // RC_2afa68ebeade43c502f553bf208d417d
/// <summary>
/// RecordList type <code>Internal_DrawRectangle_ConfigsRecordList</code> that represents a record list
///  of <code>Internal_DrawRectangle_Configs</code>
/// </summary>
public partial class RL_592eaf1c99729dad11d69819a0523b2c : GenericRecordList<RC_2afa68ebeade43c502f553bf208d417d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2afa68ebeade43c502f553bf208d417d GetElementDefaultValue() {
return new RC_2afa68ebeade43c502f553bf208d417d();
}

public T[] ToArray<T>(Func<RC_2afa68ebeade43c502f553bf208d417d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_592eaf1c99729dad11d69819a0523b2c recordList, Func<RC_2afa68ebeade43c502f553bf208d417d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_592eaf1c99729dad11d69819a0523b2c(RC_2afa68ebeade43c502f553bf208d417d[] array) {
  RL_592eaf1c99729dad11d69819a0523b2c result = new RL_592eaf1c99729dad11d69819a0523b2c();
result.InnerFromArray(array);
    return result;
}

public static RL_592eaf1c99729dad11d69819a0523b2c ToList<T>(T[] array, Func <T, RC_2afa68ebeade43c502f553bf208d417d> converter) {
  RL_592eaf1c99729dad11d69819a0523b2c result = new RL_592eaf1c99729dad11d69819a0523b2c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_592eaf1c99729dad11d69819a0523b2c FromRestList<T>(RestList<T> restList, Func <T, RC_2afa68ebeade43c502f553bf208d417d> converter) {
  RL_592eaf1c99729dad11d69819a0523b2c result = new RL_592eaf1c99729dad11d69819a0523b2c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_592eaf1c99729dad11d69819a0523b2c() : base() {
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
protected override OSList<RC_2afa68ebeade43c502f553bf208d417d> NewList() {
return new RL_592eaf1c99729dad11d69819a0523b2c();
}


} // RL_592eaf1c99729dad11d69819a0523b2c
}

