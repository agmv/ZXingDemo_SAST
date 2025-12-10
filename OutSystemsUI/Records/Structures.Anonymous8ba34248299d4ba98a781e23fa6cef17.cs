namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (SEKji50pqUuKeB4j+mzvFw)
///  <code>RC_abb6a3eba8583e4ab0625de8f38fb719</code> that represent
/// s <code>DeviceConfigurationRecord</code> <p>Description: </p>
/// </summary>
// Name: DeviceConfigurationRecord
public partial struct RC_abb6a3eba8583e4ab0625de8f38fb719 : ITypedRecord<RC_abb6a3eba8583e4ab0625de8f38fb719> {
internal static readonly GlobalObjectKey IdDeviceConfiguration = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*66O2q1ioSj6wYl3o84+3GQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DeviceConfiguration")]
public ST_0262e6910ebecc922f633b08db78d688Structure ssSTDeviceConfiguration;


public static implicit operator ST_0262e6910ebecc922f633b08db78d688Structure( RC_abb6a3eba8583e4ab0625de8f38fb719 r) {
return r.ssSTDeviceConfiguration;
}

public static implicit operator RC_abb6a3eba8583e4ab0625de8f38fb719 (ST_0262e6910ebecc922f633b08db78d688Structure r) {
RC_abb6a3eba8583e4ab0625de8f38fb719 res = new RC_abb6a3eba8583e4ab0625de8f38fb719 ();
res.ssSTDeviceConfiguration = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_abb6a3eba8583e4ab0625de8f38fb719() {
OptimizedAttributes = null;
ssSTDeviceConfiguration = new ST_0262e6910ebecc922f633b08db78d688Structure();
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
    ssSTDeviceConfiguration.OptimizedAttributes = value[0];
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
ssSTDeviceConfiguration.Read( r, ref index);
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
public void ReadIM(RC_abb6a3eba8583e4ab0625de8f38fb719 r) {
this = r;
}


public static bool operator == (RC_abb6a3eba8583e4ab0625de8f38fb719 a, RC_abb6a3eba8583e4ab0625de8f38fb719 b) {
if (a.ssSTDeviceConfiguration != b.ssSTDeviceConfiguration) return false;
return true;
}

public static bool operator != (RC_abb6a3eba8583e4ab0625de8f38fb719 a, RC_abb6a3eba8583e4ab0625de8f38fb719 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_abb6a3eba8583e4ab0625de8f38fb719)) return false;
return (this == (RC_abb6a3eba8583e4ab0625de8f38fb719)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDeviceConfiguration.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDeviceConfiguration.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDeviceConfiguration.InternalRecursiveSave();
}


public RC_abb6a3eba8583e4ab0625de8f38fb719 Duplicate() {
RC_abb6a3eba8583e4ab0625de8f38fb719 t;
t.ssSTDeviceConfiguration = (ST_0262e6910ebecc922f633b08db78d688Structure)this.ssSTDeviceConfiguration.Duplicate();
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
if (head == "deviceconfiguration") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeviceConfiguration")) variable.Value = ssSTDeviceConfiguration; else variable.Optimized = true;
variable.SetFieldName("deviceconfiguration");
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
if (key == IdDeviceConfiguration) {
return ssSTDeviceConfiguration;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDeviceConfiguration.Key.AsGuid) {
return ssSTDeviceConfiguration;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDeviceConfiguration.FillFromOther((IRecord) other.AttributeGet(IdDeviceConfiguration));
}
} // RC_abb6a3eba8583e4ab0625de8f38fb719
/// <summary>
/// RecordList type <code>DeviceConfigurationRecordList</code> that represents a record list of
///  <code>DeviceConfiguration</code>
/// </summary>
public partial class RL_703668b187ab39de3436f6485526e12a : GenericRecordList<RC_abb6a3eba8583e4ab0625de8f38fb719>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_abb6a3eba8583e4ab0625de8f38fb719 GetElementDefaultValue() {
return new RC_abb6a3eba8583e4ab0625de8f38fb719();
}

public T[] ToArray<T>(Func<RC_abb6a3eba8583e4ab0625de8f38fb719, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_703668b187ab39de3436f6485526e12a recordList, Func<RC_abb6a3eba8583e4ab0625de8f38fb719, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_703668b187ab39de3436f6485526e12a(RC_abb6a3eba8583e4ab0625de8f38fb719[] array) {
  RL_703668b187ab39de3436f6485526e12a result = new RL_703668b187ab39de3436f6485526e12a();
result.InnerFromArray(array);
    return result;
}

public static RL_703668b187ab39de3436f6485526e12a ToList<T>(T[] array, Func <T, RC_abb6a3eba8583e4ab0625de8f38fb719> converter) {
  RL_703668b187ab39de3436f6485526e12a result = new RL_703668b187ab39de3436f6485526e12a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_703668b187ab39de3436f6485526e12a FromRestList<T>(RestList<T> restList, Func <T, RC_abb6a3eba8583e4ab0625de8f38fb719> converter) {
  RL_703668b187ab39de3436f6485526e12a result = new RL_703668b187ab39de3436f6485526e12a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_703668b187ab39de3436f6485526e12a() : base() {
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
protected override OSList<RC_abb6a3eba8583e4ab0625de8f38fb719> NewList() {
return new RL_703668b187ab39de3436f6485526e12a();
}


} // RL_703668b187ab39de3436f6485526e12a
}

