namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (ON2kSfgAx06Z4Dp46dmRVA)
///  <code>RC_7848ef17b87824c24f6e707b82dac222</code> that represent
/// s <code>Private_MarkerClustererRecord</code> <p>Description: </p>
/// </summary>
// Name: Private_MarkerClustererRecord
public partial struct RC_7848ef17b87824c24f6e707b82dac222 : ITypedRecord<RC_7848ef17b87824c24f6e707b82dac222> {
internal static readonly GlobalObjectKey IdPrivate_MarkerClusterer = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*F+9IeHi4wiRPbnB7gtrCIg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Private_MarkerClusterer")]
public ST_9f8ac95fe4e47e327de12de1b56bed45Structure ssSTPrivate_MarkerClusterer;


public static implicit operator ST_9f8ac95fe4e47e327de12de1b56bed45Structure( RC_7848ef17b87824c24f6e707b82dac222 r) {
return r.ssSTPrivate_MarkerClusterer;
}

public static implicit operator RC_7848ef17b87824c24f6e707b82dac222 (ST_9f8ac95fe4e47e327de12de1b56bed45Structure r) {
RC_7848ef17b87824c24f6e707b82dac222 res = new RC_7848ef17b87824c24f6e707b82dac222 ();
res.ssSTPrivate_MarkerClusterer = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7848ef17b87824c24f6e707b82dac222() {
OptimizedAttributes = null;
ssSTPrivate_MarkerClusterer = new ST_9f8ac95fe4e47e327de12de1b56bed45Structure();
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
    ssSTPrivate_MarkerClusterer.OptimizedAttributes = value[0];
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
ssSTPrivate_MarkerClusterer.Read( r, ref index);
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
public void ReadIM(RC_7848ef17b87824c24f6e707b82dac222 r) {
this = r;
}


public static bool operator == (RC_7848ef17b87824c24f6e707b82dac222 a, RC_7848ef17b87824c24f6e707b82dac222 b) {
if (a.ssSTPrivate_MarkerClusterer != b.ssSTPrivate_MarkerClusterer) return false;
return true;
}

public static bool operator != (RC_7848ef17b87824c24f6e707b82dac222 a, RC_7848ef17b87824c24f6e707b82dac222 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7848ef17b87824c24f6e707b82dac222)) return false;
return (this == (RC_7848ef17b87824c24f6e707b82dac222)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPrivate_MarkerClusterer.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPrivate_MarkerClusterer.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPrivate_MarkerClusterer.InternalRecursiveSave();
}


public RC_7848ef17b87824c24f6e707b82dac222 Duplicate() {
RC_7848ef17b87824c24f6e707b82dac222 t;
t.ssSTPrivate_MarkerClusterer = (ST_9f8ac95fe4e47e327de12de1b56bed45Structure)this.ssSTPrivate_MarkerClusterer.Duplicate();
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
if (head == "private_markerclusterer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Private_MarkerClusterer")) variable.Value = ssSTPrivate_MarkerClusterer; else variable.Optimized = true;
variable.SetFieldName("private_markerclusterer");
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
if (key == IdPrivate_MarkerClusterer) {
return ssSTPrivate_MarkerClusterer;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPrivate_MarkerClusterer.Key.AsGuid) {
return ssSTPrivate_MarkerClusterer;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPrivate_MarkerClusterer.FillFromOther((IRecord) other.AttributeGet(IdPrivate_MarkerClusterer));
}
} // RC_7848ef17b87824c24f6e707b82dac222
/// <summary>
/// RecordList type <code>Private_MarkerClustererRecordList</code> that represents a record list of
///  <code>Private_MarkerClusterer</code>
/// </summary>
public partial class RL_cf834024cc0749abefb56f537d2bf6f7 : GenericRecordList<RC_7848ef17b87824c24f6e707b82dac222>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7848ef17b87824c24f6e707b82dac222 GetElementDefaultValue() {
return new RC_7848ef17b87824c24f6e707b82dac222();
}

public T[] ToArray<T>(Func<RC_7848ef17b87824c24f6e707b82dac222, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cf834024cc0749abefb56f537d2bf6f7 recordList, Func<RC_7848ef17b87824c24f6e707b82dac222, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cf834024cc0749abefb56f537d2bf6f7(RC_7848ef17b87824c24f6e707b82dac222[] array) {
  RL_cf834024cc0749abefb56f537d2bf6f7 result = new RL_cf834024cc0749abefb56f537d2bf6f7();
result.InnerFromArray(array);
    return result;
}

public static RL_cf834024cc0749abefb56f537d2bf6f7 ToList<T>(T[] array, Func <T, RC_7848ef17b87824c24f6e707b82dac222> converter) {
  RL_cf834024cc0749abefb56f537d2bf6f7 result = new RL_cf834024cc0749abefb56f537d2bf6f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cf834024cc0749abefb56f537d2bf6f7 FromRestList<T>(RestList<T> restList, Func <T, RC_7848ef17b87824c24f6e707b82dac222> converter) {
  RL_cf834024cc0749abefb56f537d2bf6f7 result = new RL_cf834024cc0749abefb56f537d2bf6f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cf834024cc0749abefb56f537d2bf6f7() : base() {
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
protected override OSList<RC_7848ef17b87824c24f6e707b82dac222> NewList() {
return new RL_cf834024cc0749abefb56f537d2bf6f7();
}


} // RL_cf834024cc0749abefb56f537d2bf6f7
}

