namespace ssOutSystemsUI {
/// <summary>
/// [Structure] CarouselItems (3HUi56hX10erbaugSaKF9g)
///  <code>ST_660adb7a9db48bff1b12c6e03515b415Structure</code> that represent
/// s <code>CarouselItems</code> <p>Description: Number of visible Carousel items at the same time on
///  each slide.</p>
/// </summary>
// Name: CarouselItems
public partial struct ST_660adb7a9db48bff1b12c6e03515b415Structure : ITypedRecord<ST_660adb7a9db48bff1b12c6e03515b415Structure> {
internal static readonly GlobalObjectKey IdDesktop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*UKKTSUAp4EKHS+kl9PLiyQ");
internal static readonly GlobalObjectKey IdTablet = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*0SYG4McnFUWqA2BJDhKP5Q");
internal static readonly GlobalObjectKey IdPhone = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ZziZUV9CR0y3nlr1aI60lQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Desktop")]
public int ssDesktop;

[System.Xml.Serialization.XmlElement("Tablet")]
public int ssTablet;

[System.Xml.Serialization.XmlElement("Phone")]
public int ssPhone;


public BitArray OptimizedAttributes;

public ST_660adb7a9db48bff1b12c6e03515b415Structure() {
OptimizedAttributes = null;
ssDesktop = 1;
ssTablet = 1;
ssPhone = 1;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssDesktop = r.ReadInteger(index++, "CarouselItems.Desktop", 0);
ssTablet = r.ReadInteger(index++, "CarouselItems.Tablet", 0);
ssPhone = r.ReadInteger(index++, "CarouselItems.Phone", 0);
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
public void ReadIM(ST_660adb7a9db48bff1b12c6e03515b415Structure r) {
this = r;
}


public static bool operator == (ST_660adb7a9db48bff1b12c6e03515b415Structure a, ST_660adb7a9db48bff1b12c6e03515b415Structure b) {
if (a.ssDesktop != b.ssDesktop) return false;
if (a.ssTablet != b.ssTablet) return false;
if (a.ssPhone != b.ssPhone) return false;
return true;
}

public static bool operator != (ST_660adb7a9db48bff1b12c6e03515b415Structure a, ST_660adb7a9db48bff1b12c6e03515b415Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_660adb7a9db48bff1b12c6e03515b415Structure)) return false;
return (this == (ST_660adb7a9db48bff1b12c6e03515b415Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDesktop.GetHashCode()
 ^ ssTablet.GetHashCode()
 ^ ssPhone.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_660adb7a9db48bff1b12c6e03515b415Structure Duplicate() {
ST_660adb7a9db48bff1b12c6e03515b415Structure t;
t.ssDesktop = this.ssDesktop;
t.ssTablet = this.ssTablet;
t.ssPhone = this.ssPhone;
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
if (head == "desktop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desktop")) variable.Value = ssDesktop; else variable.Optimized = true;
} else if (head == "tablet") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tablet")) variable.Value = ssTablet; else variable.Optimized = true;
} else if (head == "phone") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Phone")) variable.Value = ssPhone; else variable.Optimized = true;
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
if (key == IdDesktop) {
return ssDesktop;
}
if (key == IdTablet) {
return ssTablet;
}
if (key == IdPhone) {
return ssPhone;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDesktop.Key.AsGuid) {
return ssDesktop;
}
if (attributeKey == IdTablet.Key.AsGuid) {
return ssTablet;
}
if (attributeKey == IdPhone.Key.AsGuid) {
return ssPhone;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDesktop = (int) other.AttributeGet(IdDesktop);
ssTablet = (int) other.AttributeGet(IdTablet);
ssPhone = (int) other.AttributeGet(IdPhone);
}
} // ST_660adb7a9db48bff1b12c6e03515b415Structure
/// <summary>
/// RecordList type <code>CarouselItemsList</code> that represents a record list of
///  <code>CarouselItems</code>
/// </summary>
public partial class RL_f9624ab6e814fdb86dd00a59d573aa8e : GenericRecordList<ST_660adb7a9db48bff1b12c6e03515b415Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_660adb7a9db48bff1b12c6e03515b415Structure GetElementDefaultValue() {
return new ST_660adb7a9db48bff1b12c6e03515b415Structure();
}

public T[] ToArray<T>(Func<ST_660adb7a9db48bff1b12c6e03515b415Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f9624ab6e814fdb86dd00a59d573aa8e recordList, Func<ST_660adb7a9db48bff1b12c6e03515b415Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f9624ab6e814fdb86dd00a59d573aa8e(ST_660adb7a9db48bff1b12c6e03515b415Structure[] array) {
  RL_f9624ab6e814fdb86dd00a59d573aa8e result = new RL_f9624ab6e814fdb86dd00a59d573aa8e();
result.InnerFromArray(array);
    return result;
}

public static RL_f9624ab6e814fdb86dd00a59d573aa8e ToList<T>(T[] array, Func <T, ST_660adb7a9db48bff1b12c6e03515b415Structure> converter) {
  RL_f9624ab6e814fdb86dd00a59d573aa8e result = new RL_f9624ab6e814fdb86dd00a59d573aa8e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f9624ab6e814fdb86dd00a59d573aa8e FromRestList<T>(RestList<T> restList, Func <T, ST_660adb7a9db48bff1b12c6e03515b415Structure> converter) {
  RL_f9624ab6e814fdb86dd00a59d573aa8e result = new RL_f9624ab6e814fdb86dd00a59d573aa8e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f9624ab6e814fdb86dd00a59d573aa8e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_660adb7a9db48bff1b12c6e03515b415Structure> NewList() {
return new RL_f9624ab6e814fdb86dd00a59d573aa8e();
}


} // RL_f9624ab6e814fdb86dd00a59d573aa8e
}

