namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (_2nVtVx7802qME7mRc30ww)
///  <code>RC_486a35159c95750661e012cbe99a555f</code> that represents <code>GradientColorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: GradientColorRecord
public partial struct RC_486a35159c95750661e012cbe99a555f : ITypedRecord<RC_486a35159c95750661e012cbe99a555f> {
internal static readonly GlobalObjectKey IdGradientColor = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FTVqSJWcBnVh4BLL6ZpVXw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("GradientColor")]
public ST_27b48af5cc16a3b2165fd73e0270cad1Structure ssSTGradientColor;


public static implicit operator ST_27b48af5cc16a3b2165fd73e0270cad1Structure( RC_486a35159c95750661e012cbe99a555f r) {
return r.ssSTGradientColor;
}

public static implicit operator RC_486a35159c95750661e012cbe99a555f (ST_27b48af5cc16a3b2165fd73e0270cad1Structure r) {
RC_486a35159c95750661e012cbe99a555f res = new RC_486a35159c95750661e012cbe99a555f ();
res.ssSTGradientColor = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_486a35159c95750661e012cbe99a555f() {
OptimizedAttributes = null;
ssSTGradientColor = new ST_27b48af5cc16a3b2165fd73e0270cad1Structure();
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
    ssSTGradientColor.OptimizedAttributes = value[0];
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
ssSTGradientColor.Read( r, ref index);
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
public void ReadIM(RC_486a35159c95750661e012cbe99a555f r) {
this = r;
}


public static bool operator == (RC_486a35159c95750661e012cbe99a555f a, RC_486a35159c95750661e012cbe99a555f b) {
if (a.ssSTGradientColor != b.ssSTGradientColor) return false;
return true;
}

public static bool operator != (RC_486a35159c95750661e012cbe99a555f a, RC_486a35159c95750661e012cbe99a555f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_486a35159c95750661e012cbe99a555f)) return false;
return (this == (RC_486a35159c95750661e012cbe99a555f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTGradientColor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTGradientColor.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTGradientColor.InternalRecursiveSave();
}


public RC_486a35159c95750661e012cbe99a555f Duplicate() {
RC_486a35159c95750661e012cbe99a555f t;
t.ssSTGradientColor = (ST_27b48af5cc16a3b2165fd73e0270cad1Structure)this.ssSTGradientColor.Duplicate();
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
if (head == "gradientcolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GradientColor")) variable.Value = ssSTGradientColor; else variable.Optimized = true;
variable.SetFieldName("gradientcolor");
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
if (key == IdGradientColor) {
return ssSTGradientColor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGradientColor.Key.AsGuid) {
return ssSTGradientColor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTGradientColor.FillFromOther((IRecord) other.AttributeGet(IdGradientColor));
}
} // RC_486a35159c95750661e012cbe99a555f
/// <summary>
/// RecordList type <code>GradientColorRecordList</code> that represents a record list of
///  <code>GradientColor</code>
/// </summary>
public partial class RL_4d67a428caaa9d0a9cf0257d7fce0e9b : GenericRecordList<RC_486a35159c95750661e012cbe99a555f>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_486a35159c95750661e012cbe99a555f GetElementDefaultValue() {
return new RC_486a35159c95750661e012cbe99a555f();
}

public T[] ToArray<T>(Func<RC_486a35159c95750661e012cbe99a555f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d67a428caaa9d0a9cf0257d7fce0e9b recordList, Func<RC_486a35159c95750661e012cbe99a555f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d67a428caaa9d0a9cf0257d7fce0e9b(RC_486a35159c95750661e012cbe99a555f[] array) {
  RL_4d67a428caaa9d0a9cf0257d7fce0e9b result = new RL_4d67a428caaa9d0a9cf0257d7fce0e9b();
result.InnerFromArray(array);
    return result;
}

public static RL_4d67a428caaa9d0a9cf0257d7fce0e9b ToList<T>(T[] array, Func <T, RC_486a35159c95750661e012cbe99a555f> converter) {
  RL_4d67a428caaa9d0a9cf0257d7fce0e9b result = new RL_4d67a428caaa9d0a9cf0257d7fce0e9b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d67a428caaa9d0a9cf0257d7fce0e9b FromRestList<T>(RestList<T> restList, Func <T, RC_486a35159c95750661e012cbe99a555f> converter) {
  RL_4d67a428caaa9d0a9cf0257d7fce0e9b result = new RL_4d67a428caaa9d0a9cf0257d7fce0e9b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d67a428caaa9d0a9cf0257d7fce0e9b() : base() {
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
protected override OSList<RC_486a35159c95750661e012cbe99a555f> NewList() {
return new RL_4d67a428caaa9d0a9cf0257d7fce0e9b();
}


} // RL_4d67a428caaa9d0a9cf0257d7fce0e9b
}

