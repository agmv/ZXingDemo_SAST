namespace ssOutSystemsUI {
/// <summary>
/// [Structure] DeviceConfiguration (uUnElVRZ7EeykU8Op0Iq9A)
///  <code>ST_0262e6910ebecc922f633b08db78d688Structure</code> that represent
/// s <code>DeviceConfiguration</code> <p>Description: Structure used for the customization of the
///  Device Detection.</p>
/// </summary>
// Name: DeviceConfiguration
public partial struct ST_0262e6910ebecc922f633b08db78d688Structure : ITypedRecord<ST_0262e6910ebecc922f633b08db78d688Structure> {
internal static readonly GlobalObjectKey IdPhoneWidth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MFRVMjshqkCMOuHUxY8McA");
internal static readonly GlobalObjectKey IdTabletWidth = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*HvhbMLet8keyiQ1gQCQUhw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("PhoneWidth")]
public int ssPhoneWidth;

[System.Xml.Serialization.XmlElement("TabletWidth")]
public int ssTabletWidth;


public BitArray OptimizedAttributes;

public ST_0262e6910ebecc922f633b08db78d688Structure() {
OptimizedAttributes = null;
ssPhoneWidth = 767;
ssTabletWidth = 1024;
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
ssPhoneWidth = r.ReadInteger(index++, "DeviceConfiguration.PhoneWidth", 0);
ssTabletWidth = r.ReadInteger(index++, "DeviceConfiguration.TabletWidth", 0);
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
public void ReadIM(ST_0262e6910ebecc922f633b08db78d688Structure r) {
this = r;
}


public static bool operator == (ST_0262e6910ebecc922f633b08db78d688Structure a, ST_0262e6910ebecc922f633b08db78d688Structure b) {
if (a.ssPhoneWidth != b.ssPhoneWidth) return false;
if (a.ssTabletWidth != b.ssTabletWidth) return false;
return true;
}

public static bool operator != (ST_0262e6910ebecc922f633b08db78d688Structure a, ST_0262e6910ebecc922f633b08db78d688Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0262e6910ebecc922f633b08db78d688Structure)) return false;
return (this == (ST_0262e6910ebecc922f633b08db78d688Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPhoneWidth.GetHashCode()
 ^ ssTabletWidth.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_0262e6910ebecc922f633b08db78d688Structure Duplicate() {
ST_0262e6910ebecc922f633b08db78d688Structure t;
t.ssPhoneWidth = this.ssPhoneWidth;
t.ssTabletWidth = this.ssTabletWidth;
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
if (head == "phonewidth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PhoneWidth")) variable.Value = ssPhoneWidth; else variable.Optimized = true;
} else if (head == "tabletwidth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabletWidth")) variable.Value = ssTabletWidth; else variable.Optimized = true;
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
if (key == IdPhoneWidth) {
return ssPhoneWidth;
}
if (key == IdTabletWidth) {
return ssTabletWidth;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPhoneWidth.Key.AsGuid) {
return ssPhoneWidth;
}
if (attributeKey == IdTabletWidth.Key.AsGuid) {
return ssTabletWidth;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPhoneWidth = (int) other.AttributeGet(IdPhoneWidth);
ssTabletWidth = (int) other.AttributeGet(IdTabletWidth);
}
} // ST_0262e6910ebecc922f633b08db78d688Structure
/// <summary>
/// RecordList type <code>DeviceConfigurationList</code> that represents a record list of
///  <code>DeviceConfiguration</code>
/// </summary>
public partial class RL_af7f649b9a00c07af59590b0760c28af : GenericRecordList<ST_0262e6910ebecc922f633b08db78d688Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_0262e6910ebecc922f633b08db78d688Structure GetElementDefaultValue() {
return new ST_0262e6910ebecc922f633b08db78d688Structure();
}

public T[] ToArray<T>(Func<ST_0262e6910ebecc922f633b08db78d688Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_af7f649b9a00c07af59590b0760c28af recordList, Func<ST_0262e6910ebecc922f633b08db78d688Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_af7f649b9a00c07af59590b0760c28af(ST_0262e6910ebecc922f633b08db78d688Structure[] array) {
  RL_af7f649b9a00c07af59590b0760c28af result = new RL_af7f649b9a00c07af59590b0760c28af();
result.InnerFromArray(array);
    return result;
}

public static RL_af7f649b9a00c07af59590b0760c28af ToList<T>(T[] array, Func <T, ST_0262e6910ebecc922f633b08db78d688Structure> converter) {
  RL_af7f649b9a00c07af59590b0760c28af result = new RL_af7f649b9a00c07af59590b0760c28af();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_af7f649b9a00c07af59590b0760c28af FromRestList<T>(RestList<T> restList, Func <T, ST_0262e6910ebecc922f633b08db78d688Structure> converter) {
  RL_af7f649b9a00c07af59590b0760c28af result = new RL_af7f649b9a00c07af59590b0760c28af();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_af7f649b9a00c07af59590b0760c28af() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0262e6910ebecc922f633b08db78d688Structure> NewList() {
return new RL_af7f649b9a00c07af59590b0760c28af();
}


} // RL_af7f649b9a00c07af59590b0760c28af
}

