namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (Z0+cvUf19U6pmmr10Kz7qA)
///  <code>RC_6806bcabed8c9a627c64e2f22fd43e7d</code> that represent
/// s <code>Submenu_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: Submenu_InternalConfigRecord
public partial struct RC_6806bcabed8c9a627c64e2f22fd43e7d : ITypedRecord<RC_6806bcabed8c9a627c64e2f22fd43e7d> {
internal static readonly GlobalObjectKey IdSubmenu_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q7wGaIztYpp8ZOLyL9Q+fQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Submenu_InternalConfig")]
public ST_e373082a732833044c6d132d736b9a20Structure ssSTSubmenu_InternalConfig;


public static implicit operator ST_e373082a732833044c6d132d736b9a20Structure( RC_6806bcabed8c9a627c64e2f22fd43e7d r) {
return r.ssSTSubmenu_InternalConfig;
}

public static implicit operator RC_6806bcabed8c9a627c64e2f22fd43e7d (ST_e373082a732833044c6d132d736b9a20Structure r) {
RC_6806bcabed8c9a627c64e2f22fd43e7d res = new RC_6806bcabed8c9a627c64e2f22fd43e7d ();
res.ssSTSubmenu_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6806bcabed8c9a627c64e2f22fd43e7d() {
OptimizedAttributes = null;
ssSTSubmenu_InternalConfig = new ST_e373082a732833044c6d132d736b9a20Structure();
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
    ssSTSubmenu_InternalConfig.OptimizedAttributes = value[0];
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
ssSTSubmenu_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_6806bcabed8c9a627c64e2f22fd43e7d r) {
this = r;
}


public static bool operator == (RC_6806bcabed8c9a627c64e2f22fd43e7d a, RC_6806bcabed8c9a627c64e2f22fd43e7d b) {
if (a.ssSTSubmenu_InternalConfig != b.ssSTSubmenu_InternalConfig) return false;
return true;
}

public static bool operator != (RC_6806bcabed8c9a627c64e2f22fd43e7d a, RC_6806bcabed8c9a627c64e2f22fd43e7d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6806bcabed8c9a627c64e2f22fd43e7d)) return false;
return (this == (RC_6806bcabed8c9a627c64e2f22fd43e7d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSubmenu_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSubmenu_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSubmenu_InternalConfig.InternalRecursiveSave();
}


public RC_6806bcabed8c9a627c64e2f22fd43e7d Duplicate() {
RC_6806bcabed8c9a627c64e2f22fd43e7d t;
t.ssSTSubmenu_InternalConfig = (ST_e373082a732833044c6d132d736b9a20Structure)this.ssSTSubmenu_InternalConfig.Duplicate();
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
if (head == "submenu_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Submenu_InternalConfig")) variable.Value = ssSTSubmenu_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("submenu_internalconfig");
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
if (key == IdSubmenu_InternalConfig) {
return ssSTSubmenu_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSubmenu_InternalConfig.Key.AsGuid) {
return ssSTSubmenu_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSubmenu_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdSubmenu_InternalConfig));
}
} // RC_6806bcabed8c9a627c64e2f22fd43e7d
/// <summary>
/// RecordList type <code>Submenu_InternalConfigRecordList</code> that represents a record list of
///  <code>Submenu_InternalConfig</code>
/// </summary>
public partial class RL_078368f87c33aa8427e5634fd132a359 : GenericRecordList<RC_6806bcabed8c9a627c64e2f22fd43e7d>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_6806bcabed8c9a627c64e2f22fd43e7d GetElementDefaultValue() {
return new RC_6806bcabed8c9a627c64e2f22fd43e7d();
}

public T[] ToArray<T>(Func<RC_6806bcabed8c9a627c64e2f22fd43e7d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_078368f87c33aa8427e5634fd132a359 recordList, Func<RC_6806bcabed8c9a627c64e2f22fd43e7d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_078368f87c33aa8427e5634fd132a359(RC_6806bcabed8c9a627c64e2f22fd43e7d[] array) {
  RL_078368f87c33aa8427e5634fd132a359 result = new RL_078368f87c33aa8427e5634fd132a359();
result.InnerFromArray(array);
    return result;
}

public static RL_078368f87c33aa8427e5634fd132a359 ToList<T>(T[] array, Func <T, RC_6806bcabed8c9a627c64e2f22fd43e7d> converter) {
  RL_078368f87c33aa8427e5634fd132a359 result = new RL_078368f87c33aa8427e5634fd132a359();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_078368f87c33aa8427e5634fd132a359 FromRestList<T>(RestList<T> restList, Func <T, RC_6806bcabed8c9a627c64e2f22fd43e7d> converter) {
  RL_078368f87c33aa8427e5634fd132a359 result = new RL_078368f87c33aa8427e5634fd132a359();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_078368f87c33aa8427e5634fd132a359() : base() {
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
protected override OSList<RC_6806bcabed8c9a627c64e2f22fd43e7d> NewList() {
return new RL_078368f87c33aa8427e5634fd132a359();
}


} // RL_078368f87c33aa8427e5634fd132a359
}

