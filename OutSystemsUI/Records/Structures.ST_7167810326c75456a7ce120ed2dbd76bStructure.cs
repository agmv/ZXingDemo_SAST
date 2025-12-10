namespace ssOutSystemsUI {
/// <summary>
/// [Structure] RangeSliderOptionalConfigs (YH6NTPqYJkq2DoxNHSzraQ)
///  <code>ST_7167810326c75456a7ce120ed2dbd76bStructure</code> that represent
/// s <code>RangeSliderOptionalConfigs</code> <p>Description: Group of optional configurations for the
///  RangeSlider block. </p>
/// </summary>
// Name: RangeSliderOptionalConfigs
public partial struct ST_7167810326c75456a7ce120ed2dbd76bStructure : ITypedRecord<ST_7167810326c75456a7ce120ed2dbd76bStructure> {
internal static readonly GlobalObjectKey IdShowFloatingLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*9FxTqS9mRk2M86fU6oyOZA");
internal static readonly GlobalObjectKey IdStep = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1XBHf9FqTkOnyXwKO4qYaQ");
internal static readonly GlobalObjectKey IdShowTickMarks = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tlzHQU40YkqumDhjZQy3PA");
internal static readonly GlobalObjectKey IdTickMarksInterval = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Prr8JCQ6s0eKbVWbBWpGhw");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6rN5XdhsjEys5_TSq8d21Q");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("ShowFloatingLabel")]
public bool ssShowFloatingLabel;

[System.Xml.Serialization.XmlElement("Step")]
public decimal ssStep;

[System.Xml.Serialization.XmlElement("ShowTickMarks")]
public bool ssShowTickMarks;

[System.Xml.Serialization.XmlElement("TickMarksInterval")]
public int ssTickMarksInterval;

[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;


public BitArray OptimizedAttributes;

public ST_7167810326c75456a7ce120ed2dbd76bStructure() {
OptimizedAttributes = null;
ssShowFloatingLabel = false;
ssStep = (((decimal)1));
ssShowTickMarks = true;
ssTickMarksInterval = 0;
ssIsDisabled = false;
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
ssShowFloatingLabel = r.ReadBoolean(index++, "RangeSliderOptionalConfigs.ShowFloatingLabel", false);
ssStep = r.ReadDecimal(index++, "RangeSliderOptionalConfigs.Step", 0.0M);
ssShowTickMarks = r.ReadBoolean(index++, "RangeSliderOptionalConfigs.ShowTickMarks", false);
ssTickMarksInterval = r.ReadInteger(index++, "RangeSliderOptionalConfigs.TickMarksInterval", 0);
ssIsDisabled = r.ReadBoolean(index++, "RangeSliderOptionalConfigs.IsDisabled", false);
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
public void ReadIM(ST_7167810326c75456a7ce120ed2dbd76bStructure r) {
this = r;
}


public static bool operator == (ST_7167810326c75456a7ce120ed2dbd76bStructure a, ST_7167810326c75456a7ce120ed2dbd76bStructure b) {
if (a.ssShowFloatingLabel != b.ssShowFloatingLabel) return false;
if (a.ssStep != b.ssStep) return false;
if (a.ssShowTickMarks != b.ssShowTickMarks) return false;
if (a.ssTickMarksInterval != b.ssTickMarksInterval) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
return true;
}

public static bool operator != (ST_7167810326c75456a7ce120ed2dbd76bStructure a, ST_7167810326c75456a7ce120ed2dbd76bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7167810326c75456a7ce120ed2dbd76bStructure)) return false;
return (this == (ST_7167810326c75456a7ce120ed2dbd76bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssShowFloatingLabel.GetHashCode()
 ^ ssStep.GetHashCode()
 ^ ssShowTickMarks.GetHashCode()
 ^ ssTickMarksInterval.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7167810326c75456a7ce120ed2dbd76bStructure Duplicate() {
ST_7167810326c75456a7ce120ed2dbd76bStructure t;
t.ssShowFloatingLabel = this.ssShowFloatingLabel;
t.ssStep = this.ssStep;
t.ssShowTickMarks = this.ssShowTickMarks;
t.ssTickMarksInterval = this.ssTickMarksInterval;
t.ssIsDisabled = this.ssIsDisabled;
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
if (head == "showfloatinglabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowFloatingLabel")) variable.Value = ssShowFloatingLabel; else variable.Optimized = true;
} else if (head == "step") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Step")) variable.Value = ssStep; else variable.Optimized = true;
} else if (head == "showtickmarks") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowTickMarks")) variable.Value = ssShowTickMarks; else variable.Optimized = true;
} else if (head == "tickmarksinterval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TickMarksInterval")) variable.Value = ssTickMarksInterval; else variable.Optimized = true;
} else if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
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
if (key == IdShowFloatingLabel) {
return ssShowFloatingLabel;
}
if (key == IdStep) {
return ssStep;
}
if (key == IdShowTickMarks) {
return ssShowTickMarks;
}
if (key == IdTickMarksInterval) {
return ssTickMarksInterval;
}
if (key == IdIsDisabled) {
return ssIsDisabled;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShowFloatingLabel.Key.AsGuid) {
return ssShowFloatingLabel;
}
if (attributeKey == IdStep.Key.AsGuid) {
return ssStep;
}
if (attributeKey == IdShowTickMarks.Key.AsGuid) {
return ssShowTickMarks;
}
if (attributeKey == IdTickMarksInterval.Key.AsGuid) {
return ssTickMarksInterval;
}
if (attributeKey == IdIsDisabled.Key.AsGuid) {
return ssIsDisabled;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssShowFloatingLabel = (bool) other.AttributeGet(IdShowFloatingLabel);
ssStep = (decimal) other.AttributeGet(IdStep);
ssShowTickMarks = (bool) other.AttributeGet(IdShowTickMarks);
ssTickMarksInterval = (int) other.AttributeGet(IdTickMarksInterval);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
}
} // ST_7167810326c75456a7ce120ed2dbd76bStructure
/// <summary>
/// RecordList type <code>RangeSliderOptionalConfigsList</code> that represents a record list of
///  <code>RangeSliderOptionalConfigs</code>
/// </summary>
public partial class RL_c70c6fbde641bc249181616cec2cfcdf : GenericRecordList<ST_7167810326c75456a7ce120ed2dbd76bStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7167810326c75456a7ce120ed2dbd76bStructure GetElementDefaultValue() {
return new ST_7167810326c75456a7ce120ed2dbd76bStructure();
}

public T[] ToArray<T>(Func<ST_7167810326c75456a7ce120ed2dbd76bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c70c6fbde641bc249181616cec2cfcdf recordList, Func<ST_7167810326c75456a7ce120ed2dbd76bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c70c6fbde641bc249181616cec2cfcdf(ST_7167810326c75456a7ce120ed2dbd76bStructure[] array) {
  RL_c70c6fbde641bc249181616cec2cfcdf result = new RL_c70c6fbde641bc249181616cec2cfcdf();
result.InnerFromArray(array);
    return result;
}

public static RL_c70c6fbde641bc249181616cec2cfcdf ToList<T>(T[] array, Func <T, ST_7167810326c75456a7ce120ed2dbd76bStructure> converter) {
  RL_c70c6fbde641bc249181616cec2cfcdf result = new RL_c70c6fbde641bc249181616cec2cfcdf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c70c6fbde641bc249181616cec2cfcdf FromRestList<T>(RestList<T> restList, Func <T, ST_7167810326c75456a7ce120ed2dbd76bStructure> converter) {
  RL_c70c6fbde641bc249181616cec2cfcdf result = new RL_c70c6fbde641bc249181616cec2cfcdf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c70c6fbde641bc249181616cec2cfcdf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7167810326c75456a7ce120ed2dbd76bStructure> NewList() {
return new RL_c70c6fbde641bc249181616cec2cfcdf();
}


} // RL_c70c6fbde641bc249181616cec2cfcdf
}

