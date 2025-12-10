namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (KL62fm_WGEaKHPzos_yFsg)
///  <code>RC_3bbfc6c91fcd8a2dd97847564be30682</code> that represent
/// s <code>IdentityProviderRecord</code> <p>Description: </p>
/// </summary>
// Name: IdentityProviderRecord
public partial struct RC_3bbfc6c91fcd8a2dd97847564be30682 : ITypedRecord<RC_3bbfc6c91fcd8a2dd97847564be30682> {
internal static readonly GlobalObjectKey IdIdentityProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yca_O80fLYrZeEdWS+MGgg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IdentityProvider")]
public EN_f9178b4aae1879ea388b92402c64db4cEntityRecord ssENIdentityProvider;


public static implicit operator EN_f9178b4aae1879ea388b92402c64db4cEntityRecord( RC_3bbfc6c91fcd8a2dd97847564be30682 r) {
return r.ssENIdentityProvider;
}

public static implicit operator RC_3bbfc6c91fcd8a2dd97847564be30682 (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord r) {
RC_3bbfc6c91fcd8a2dd97847564be30682 res = new RC_3bbfc6c91fcd8a2dd97847564be30682 ();
res.ssENIdentityProvider = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENIdentityProvider.ChangedAttributes = value;
}
get {
    return ssENIdentityProvider.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3bbfc6c91fcd8a2dd97847564be30682() {
OptimizedAttributes = null;
ssENIdentityProvider = new EN_f9178b4aae1879ea388b92402c64db4cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENIdentityProvider.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENIdentityProvider.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENIdentityProvider.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENIdentityProvider.Read( r, ref index);
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
public void ReadIM(RC_3bbfc6c91fcd8a2dd97847564be30682 r) {
this = r;
}


public static bool operator == (RC_3bbfc6c91fcd8a2dd97847564be30682 a, RC_3bbfc6c91fcd8a2dd97847564be30682 b) {
if (a.ssENIdentityProvider != b.ssENIdentityProvider) return false;
return true;
}

public static bool operator != (RC_3bbfc6c91fcd8a2dd97847564be30682 a, RC_3bbfc6c91fcd8a2dd97847564be30682 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3bbfc6c91fcd8a2dd97847564be30682)) return false;
return (this == (RC_3bbfc6c91fcd8a2dd97847564be30682)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENIdentityProvider.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENIdentityProvider.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENIdentityProvider.InternalRecursiveSave();
}


public RC_3bbfc6c91fcd8a2dd97847564be30682 Duplicate() {
RC_3bbfc6c91fcd8a2dd97847564be30682 t;
t.ssENIdentityProvider = (EN_f9178b4aae1879ea388b92402c64db4cEntityRecord)this.ssENIdentityProvider.Duplicate();
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
if (head == "identityprovider") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IdentityProvider")) variable.Value = ssENIdentityProvider; else variable.Optimized = true;
variable.SetFieldName("identityprovider");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENIdentityProvider.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENIdentityProvider.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdIdentityProvider) {
return ssENIdentityProvider;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIdentityProvider.Key.AsGuid) {
return ssENIdentityProvider;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENIdentityProvider.FillFromOther((IRecord) other.AttributeGet(IdIdentityProvider));
}
} // RC_3bbfc6c91fcd8a2dd97847564be30682
/// <summary>
/// RecordList type <code>IdentityProviderRecordList</code> that represents a record list of
///  <code>IdentityProvider</code>
/// </summary>
public partial class RL_b399fd74f6375cee8461023a74406333 : GenericRecordList<RC_3bbfc6c91fcd8a2dd97847564be30682>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_3bbfc6c91fcd8a2dd97847564be30682 GetElementDefaultValue() {
return new RC_3bbfc6c91fcd8a2dd97847564be30682();
}

public T[] ToArray<T>(Func<RC_3bbfc6c91fcd8a2dd97847564be30682, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b399fd74f6375cee8461023a74406333 recordList, Func<RC_3bbfc6c91fcd8a2dd97847564be30682, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b399fd74f6375cee8461023a74406333(RC_3bbfc6c91fcd8a2dd97847564be30682[] array) {
  RL_b399fd74f6375cee8461023a74406333 result = new RL_b399fd74f6375cee8461023a74406333();
result.InnerFromArray(array);
    return result;
}

public static RL_b399fd74f6375cee8461023a74406333 ToList<T>(T[] array, Func <T, RC_3bbfc6c91fcd8a2dd97847564be30682> converter) {
  RL_b399fd74f6375cee8461023a74406333 result = new RL_b399fd74f6375cee8461023a74406333();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b399fd74f6375cee8461023a74406333 FromRestList<T>(RestList<T> restList, Func <T, RC_3bbfc6c91fcd8a2dd97847564be30682> converter) {
  RL_b399fd74f6375cee8461023a74406333 result = new RL_b399fd74f6375cee8461023a74406333();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b399fd74f6375cee8461023a74406333() : base() {
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
protected override OSList<RC_3bbfc6c91fcd8a2dd97847564be30682> NewList() {
return new RL_b399fd74f6375cee8461023a74406333();
}


} // RL_b399fd74f6375cee8461023a74406333
}

