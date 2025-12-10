namespace ssOutSystemsUI {
/// <summary>
/// [Structure] GradientColor (IxDFM_PyIUSuvuT8UjkOpA)
///  <code>ST_27b48af5cc16a3b2165fd73e0270cad1Structure</code> that represent
/// s <code>GradientColor</code> <p>Description: </p>
/// </summary>
// Name: GradientColor
public partial struct ST_27b48af5cc16a3b2165fd73e0270cad1Structure : ITypedRecord<ST_27b48af5cc16a3b2165fd73e0270cad1Structure> {
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*2ljZniZuF0as0Rk65gT6_A");
internal static readonly GlobalObjectKey IdPercentage = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*VeBERNsyCkSeNEASrI9p+w");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Color")]
public string ssColor;

[System.Xml.Serialization.XmlElement("Percentage")]
public decimal ssPercentage;


public BitArray OptimizedAttributes;

public ST_27b48af5cc16a3b2165fd73e0270cad1Structure() {
OptimizedAttributes = null;
ssColor = "";
ssPercentage = (((decimal)(-1)));
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
ssColor = r.ReadText(index++, "GradientColor.Color", "");
ssPercentage = r.ReadDecimal(index++, "GradientColor.Percentage", 0.0M);
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
public void ReadIM(ST_27b48af5cc16a3b2165fd73e0270cad1Structure r) {
this = r;
}


public static bool operator == (ST_27b48af5cc16a3b2165fd73e0270cad1Structure a, ST_27b48af5cc16a3b2165fd73e0270cad1Structure b) {
if (a.ssColor != b.ssColor) return false;
if (a.ssPercentage != b.ssPercentage) return false;
return true;
}

public static bool operator != (ST_27b48af5cc16a3b2165fd73e0270cad1Structure a, ST_27b48af5cc16a3b2165fd73e0270cad1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_27b48af5cc16a3b2165fd73e0270cad1Structure)) return false;
return (this == (ST_27b48af5cc16a3b2165fd73e0270cad1Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssColor.GetHashCode()
 ^ ssPercentage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_27b48af5cc16a3b2165fd73e0270cad1Structure Duplicate() {
ST_27b48af5cc16a3b2165fd73e0270cad1Structure t;
t.ssColor = this.ssColor;
t.ssPercentage = this.ssPercentage;
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
if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssColor; else variable.Optimized = true;
} else if (head == "percentage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Percentage")) variable.Value = ssPercentage; else variable.Optimized = true;
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
if (key == IdColor) {
return ssColor;
}
if (key == IdPercentage) {
return ssPercentage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColor.Key.AsGuid) {
return ssColor;
}
if (attributeKey == IdPercentage.Key.AsGuid) {
return ssPercentage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssColor = (string) other.AttributeGet(IdColor);
ssPercentage = (decimal) other.AttributeGet(IdPercentage);
}
} // ST_27b48af5cc16a3b2165fd73e0270cad1Structure
/// <summary>
/// RecordList type <code>GradientColorList</code> that represents a record list of
///  <code>GradientColor</code>
/// </summary>
public partial class RL_9e7bcabdb3b3258424c077ac40a6d519 : GenericRecordList<ST_27b48af5cc16a3b2165fd73e0270cad1Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_27b48af5cc16a3b2165fd73e0270cad1Structure GetElementDefaultValue() {
return new ST_27b48af5cc16a3b2165fd73e0270cad1Structure();
}

public T[] ToArray<T>(Func<ST_27b48af5cc16a3b2165fd73e0270cad1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e7bcabdb3b3258424c077ac40a6d519 recordList, Func<ST_27b48af5cc16a3b2165fd73e0270cad1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e7bcabdb3b3258424c077ac40a6d519(ST_27b48af5cc16a3b2165fd73e0270cad1Structure[] array) {
  RL_9e7bcabdb3b3258424c077ac40a6d519 result = new RL_9e7bcabdb3b3258424c077ac40a6d519();
result.InnerFromArray(array);
    return result;
}

public static RL_9e7bcabdb3b3258424c077ac40a6d519 ToList<T>(T[] array, Func <T, ST_27b48af5cc16a3b2165fd73e0270cad1Structure> converter) {
  RL_9e7bcabdb3b3258424c077ac40a6d519 result = new RL_9e7bcabdb3b3258424c077ac40a6d519();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e7bcabdb3b3258424c077ac40a6d519 FromRestList<T>(RestList<T> restList, Func <T, ST_27b48af5cc16a3b2165fd73e0270cad1Structure> converter) {
  RL_9e7bcabdb3b3258424c077ac40a6d519 result = new RL_9e7bcabdb3b3258424c077ac40a6d519();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e7bcabdb3b3258424c077ac40a6d519() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_27b48af5cc16a3b2165fd73e0270cad1Structure> NewList() {
return new RL_9e7bcabdb3b3258424c077ac40a6d519();
}


} // RL_9e7bcabdb3b3258424c077ac40a6d519
}

