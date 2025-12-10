namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ComposedName (J0iX6I9jskuK794E0zKV_Q)
///  <code>ST_2f980670f450ae43af56386ae46715c7Structure</code> that represents <code>ComposedName</code
/// > <p>Description: Defines a name by its components</p>
/// </summary>
// Name: ComposedName
public partial struct ST_2f980670f450ae43af56386ae46715c7Structure : ITypedRecord<ST_2f980670f450ae43af56386ae46715c7Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdfirstName = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*u4Cj4YbhuJ3mKbVHQN4Zig");
internal static readonly GlobalObjectKey IdlastName = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*OkvGNOO5rLGGDsMNGapspw");
internal static readonly GlobalObjectKey IdmiddleNames = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*ZKFey1gYoIBv++zAQBh2Jw");
internal static readonly GlobalObjectKey Idprefix = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*edxETyRB0tr7H+hG9hcDzA");
internal static readonly GlobalObjectKey Idsuffix = GlobalObjectKey.Parse("ETF1sYDUQ36_76GCa581Yw*qjyBzYIIOqyClmeCMycozQ");

[System.Xml.Serialization.XmlElement("firstName")]
public string ssfirstName;

[System.Xml.Serialization.XmlElement("lastName")]
public string sslastName;

[System.Xml.Serialization.XmlElement("middleNames")]
public string ssmiddleNames;

[System.Xml.Serialization.XmlElement("prefix")]
public string ssprefix;

[System.Xml.Serialization.XmlElement("suffix")]
public string sssuffix;


public BitArray OptimizedAttributes;

public ST_2f980670f450ae43af56386ae46715c7Structure() {
OptimizedAttributes = null;
ssfirstName = "";
sslastName = "";
ssmiddleNames = "";
ssprefix = "";
sssuffix = "";
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
ssfirstName = r.ReadText(index++, "ComposedName.firstName", "");
sslastName = r.ReadText(index++, "ComposedName.lastName", "");
ssmiddleNames = r.ReadText(index++, "ComposedName.middleNames", "");
ssprefix = r.ReadText(index++, "ComposedName.prefix", "");
sssuffix = r.ReadText(index++, "ComposedName.suffix", "");
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
public void ReadIM(ST_2f980670f450ae43af56386ae46715c7Structure r) {
this = r;
}


public static bool operator == (ST_2f980670f450ae43af56386ae46715c7Structure a, ST_2f980670f450ae43af56386ae46715c7Structure b) {
if (a.ssfirstName != b.ssfirstName) return false;
if (a.sslastName != b.sslastName) return false;
if (a.ssmiddleNames != b.ssmiddleNames) return false;
if (a.ssprefix != b.ssprefix) return false;
if (a.sssuffix != b.sssuffix) return false;
return true;
}

public static bool operator != (ST_2f980670f450ae43af56386ae46715c7Structure a, ST_2f980670f450ae43af56386ae46715c7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2f980670f450ae43af56386ae46715c7Structure)) return false;
return (this == (ST_2f980670f450ae43af56386ae46715c7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssfirstName.GetHashCode()
 ^ sslastName.GetHashCode()
 ^ ssmiddleNames.GetHashCode()
 ^ ssprefix.GetHashCode()
 ^ sssuffix.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_2f980670f450ae43af56386ae46715c7Structure Duplicate() {
ST_2f980670f450ae43af56386ae46715c7Structure t;
t.ssfirstName = this.ssfirstName;
t.sslastName = this.sslastName;
t.ssmiddleNames = this.ssmiddleNames;
t.ssprefix = this.ssprefix;
t.sssuffix = this.sssuffix;
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
if (head == "firstname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".firstName")) variable.Value = ssfirstName; else variable.Optimized = true;
} else if (head == "lastname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".lastName")) variable.Value = sslastName; else variable.Optimized = true;
} else if (head == "middlenames") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".middleNames")) variable.Value = ssmiddleNames; else variable.Optimized = true;
} else if (head == "prefix") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".prefix")) variable.Value = ssprefix; else variable.Optimized = true;
} else if (head == "suffix") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".suffix")) variable.Value = sssuffix; else variable.Optimized = true;
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
if (key == IdfirstName) {
return ssfirstName;
}
if (key == IdlastName) {
return sslastName;
}
if (key == IdmiddleNames) {
return ssmiddleNames;
}
if (key == Idprefix) {
return ssprefix;
}
if (key == Idsuffix) {
return sssuffix;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdfirstName.Key.AsGuid) {
return ssfirstName;
}
if (attributeKey == IdlastName.Key.AsGuid) {
return sslastName;
}
if (attributeKey == IdmiddleNames.Key.AsGuid) {
return ssmiddleNames;
}
if (attributeKey == Idprefix.Key.AsGuid) {
return ssprefix;
}
if (attributeKey == Idsuffix.Key.AsGuid) {
return sssuffix;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssfirstName = (string) other.AttributeGet(IdfirstName);
sslastName = (string) other.AttributeGet(IdlastName);
ssmiddleNames = (string) other.AttributeGet(IdmiddleNames);
ssprefix = (string) other.AttributeGet(Idprefix);
sssuffix = (string) other.AttributeGet(Idsuffix);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssfirstName = (string) other.GetAttribute(IdfirstName.Key.AsGuid);
sslastName = (string) other.GetAttribute(IdlastName.Key.AsGuid);
ssmiddleNames = (string) other.GetAttribute(IdmiddleNames.Key.AsGuid);
ssprefix = (string) other.GetAttribute(Idprefix.Key.AsGuid);
sssuffix = (string) other.GetAttribute(Idsuffix.Key.AsGuid);
}
} // ST_2f980670f450ae43af56386ae46715c7Structure
/// <summary>
/// RecordList type <code>ComposedNameList</code> that represents a record list of
///  <code>ComposedName</code>
/// </summary>
public partial class RL_af63dcd54fbcccd88631a8ccec5c2896 : GenericRecordList<ST_2f980670f450ae43af56386ae46715c7Structure>, IEnumerable, IEnumerator {

protected override ST_2f980670f450ae43af56386ae46715c7Structure GetElementDefaultValue() {
return new ST_2f980670f450ae43af56386ae46715c7Structure();
}

public T[] ToArray<T>(Func<ST_2f980670f450ae43af56386ae46715c7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_af63dcd54fbcccd88631a8ccec5c2896 recordList, Func<ST_2f980670f450ae43af56386ae46715c7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_af63dcd54fbcccd88631a8ccec5c2896(ST_2f980670f450ae43af56386ae46715c7Structure[] array) {
  RL_af63dcd54fbcccd88631a8ccec5c2896 result = new RL_af63dcd54fbcccd88631a8ccec5c2896();
result.InnerFromArray(array);
    return result;
}

public static RL_af63dcd54fbcccd88631a8ccec5c2896 ToList<T>(T[] array, Func <T, ST_2f980670f450ae43af56386ae46715c7Structure> converter) {
  RL_af63dcd54fbcccd88631a8ccec5c2896 result = new RL_af63dcd54fbcccd88631a8ccec5c2896();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_af63dcd54fbcccd88631a8ccec5c2896 FromRestList<T>(RestList<T> restList, Func <T, ST_2f980670f450ae43af56386ae46715c7Structure> converter) {
  RL_af63dcd54fbcccd88631a8ccec5c2896 result = new RL_af63dcd54fbcccd88631a8ccec5c2896();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_af63dcd54fbcccd88631a8ccec5c2896() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2f980670f450ae43af56386ae46715c7Structure> NewList() {
return new RL_af63dcd54fbcccd88631a8ccec5c2896();
}


} // RL_af63dcd54fbcccd88631a8ccec5c2896
}

