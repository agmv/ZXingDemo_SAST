namespace ssOutSystemsUI {
/// <summary>
/// [Structure] RangeSlider_InternalConfig (G7MgCFuiW0qvONlwMAW_TQ)
///  <code>ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure</code> that represent
/// s <code>RangeSlider_InternalConfig</code> <p>Description: Group of internal configurations for the
///  RangeSlider block. </p>
/// </summary>
// Name: RangeSlider_InternalConfig
public partial struct ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure : ITypedRecord<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure> {
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xsTXH_ixz0+xjqDD4vRi9w");
internal static readonly GlobalObjectKey IdMinValue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5hfZZkDpsE60SRPo5VQU5g");
internal static readonly GlobalObjectKey IdMaxValue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tIqBixITgUG3QDPLnAdQuQ");
internal static readonly GlobalObjectKey IdStartingValueFrom = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*tbmd74OjZ0ONgUcO4ul6LQ");
internal static readonly GlobalObjectKey IdStartingValueTo = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*wNOiR1bXbEuk+Qpv5AgRrg");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*fUM8_0K9hEWMWbkIeI7b8Q");
internal static readonly GlobalObjectKey IdStep = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*w9LNLgG4q0K0Q86CVAVF3g");
internal static readonly GlobalObjectKey IdShowTickMarks = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+PnZsLtE_0qM1uMcsE1Pcg");
internal static readonly GlobalObjectKey IdTickMarksInterval = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*_ETmBTq6T0K6wYZ9PK1Bcg");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*at49oDUVmE6XUDmrXEbaWQ");
internal static readonly GlobalObjectKey IdOrientation = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*F9Pd0VSaEU6M58B6svC6rQ");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*7VUyxCBm1Ue2uLok3bF+eQ");
internal static readonly GlobalObjectKey IdShowFloatingLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*vVIAFtM4GEiz5ZCfnFAsKQ");
internal static readonly GlobalObjectKey IdInitialValueFrom = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*OcLTg+nLn0eEPF47puM2kw");
internal static readonly GlobalObjectKey IdInitialValueTo = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+QeW51hyS0irxYSZFZLR3g");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;

[System.Xml.Serialization.XmlElement("MinValue")]
public decimal ssMinValue;

[System.Xml.Serialization.XmlElement("MaxValue")]
public decimal ssMaxValue;

[System.Xml.Serialization.XmlElement("StartingValueFrom")]
public decimal ssStartingValueFrom;

[System.Xml.Serialization.XmlElement("StartingValueTo")]
public decimal ssStartingValueTo;

[System.Xml.Serialization.XmlElement("ExtendedClass")]
public string ssExtendedClass;

[System.Xml.Serialization.XmlElement("Step")]
public decimal ssStep;

[System.Xml.Serialization.XmlElement("ShowTickMarks")]
public bool ssShowTickMarks;

[System.Xml.Serialization.XmlElement("TickMarksInterval")]
public int ssTickMarksInterval;

[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;

[System.Xml.Serialization.XmlElement("Orientation")]
public string ssOrientation;

[System.Xml.Serialization.XmlElement("Size")]
public string ssSize;

[System.Xml.Serialization.XmlElement("ShowFloatingLabel")]
public bool ssShowFloatingLabel;

[System.Xml.Serialization.XmlElement("InitialValueFrom")]
public decimal ssInitialValueFrom;

[System.Xml.Serialization.XmlElement("InitialValueTo")]
public decimal ssInitialValueTo;


public BitArray OptimizedAttributes;

public ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure() {
OptimizedAttributes = null;
ssUniqueId = "";
ssMinValue = 0.0M;
ssMaxValue = 0.0M;
ssStartingValueFrom = 0.0M;
ssStartingValueTo = 0.0M;
ssExtendedClass = "";
ssStep = (((decimal)1));
ssShowTickMarks = true;
ssTickMarksInterval = 0;
ssIsDisabled = false;
ssOrientation = (ENOrientationEntity.GetRecordByKey(ObjectKey.Parse("FlS0fEo8eEGcW4fsz2_66A"))).ssOrientation;
ssSize = "100%";
ssShowFloatingLabel = false;
ssInitialValueFrom = 0.0M;
ssInitialValueTo = 0.0M;
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
ssUniqueId = r.ReadText(index++, "RangeSlider_InternalConfig.UniqueId", "");
ssMinValue = r.ReadDecimal(index++, "RangeSlider_InternalConfig.MinValue", 0.0M);
ssMaxValue = r.ReadDecimal(index++, "RangeSlider_InternalConfig.MaxValue", 0.0M);
ssStartingValueFrom = r.ReadDecimal(index++, "RangeSlider_InternalConfig.StartingValueFrom", 0.0M);
ssStartingValueTo = r.ReadDecimal(index++, "RangeSlider_InternalConfig.StartingValueTo", 0.0M);
ssExtendedClass = r.ReadText(index++, "RangeSlider_InternalConfig.ExtendedClass", "");
ssStep = r.ReadDecimal(index++, "RangeSlider_InternalConfig.Step", 0.0M);
ssShowTickMarks = r.ReadBoolean(index++, "RangeSlider_InternalConfig.ShowTickMarks", false);
ssTickMarksInterval = r.ReadInteger(index++, "RangeSlider_InternalConfig.TickMarksInterval", 0);
ssIsDisabled = r.ReadBoolean(index++, "RangeSlider_InternalConfig.IsDisabled", false);
ssOrientation = r.ReadEntityReferenceText(index++, "RangeSlider_InternalConfig.Orientation", "");
ssSize = r.ReadText(index++, "RangeSlider_InternalConfig.Size", "");
ssShowFloatingLabel = r.ReadBoolean(index++, "RangeSlider_InternalConfig.ShowFloatingLabel", false);
ssInitialValueFrom = r.ReadDecimal(index++, "RangeSlider_InternalConfig.InitialValueFrom", 0.0M);
ssInitialValueTo = r.ReadDecimal(index++, "RangeSlider_InternalConfig.InitialValueTo", 0.0M);
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
public void ReadIM(ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure r) {
this = r;
}


public static bool operator == (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure a, ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure b) {
if (a.ssUniqueId != b.ssUniqueId) return false;
if (a.ssMinValue != b.ssMinValue) return false;
if (a.ssMaxValue != b.ssMaxValue) return false;
if (a.ssStartingValueFrom != b.ssStartingValueFrom) return false;
if (a.ssStartingValueTo != b.ssStartingValueTo) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssStep != b.ssStep) return false;
if (a.ssShowTickMarks != b.ssShowTickMarks) return false;
if (a.ssTickMarksInterval != b.ssTickMarksInterval) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssOrientation != b.ssOrientation) return false;
if (a.ssSize != b.ssSize) return false;
if (a.ssShowFloatingLabel != b.ssShowFloatingLabel) return false;
if (a.ssInitialValueFrom != b.ssInitialValueFrom) return false;
if (a.ssInitialValueTo != b.ssInitialValueTo) return false;
return true;
}

public static bool operator != (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure a, ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure)) return false;
return (this == (ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUniqueId.GetHashCode()
 ^ ssMinValue.GetHashCode()
 ^ ssMaxValue.GetHashCode()
 ^ ssStartingValueFrom.GetHashCode()
 ^ ssStartingValueTo.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssStep.GetHashCode()
 ^ ssShowTickMarks.GetHashCode()
 ^ ssTickMarksInterval.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
 ^ ssOrientation.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssShowFloatingLabel.GetHashCode()
 ^ ssInitialValueFrom.GetHashCode()
 ^ ssInitialValueTo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure Duplicate() {
ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure t;
t.ssUniqueId = this.ssUniqueId;
t.ssMinValue = this.ssMinValue;
t.ssMaxValue = this.ssMaxValue;
t.ssStartingValueFrom = this.ssStartingValueFrom;
t.ssStartingValueTo = this.ssStartingValueTo;
t.ssExtendedClass = this.ssExtendedClass;
t.ssStep = this.ssStep;
t.ssShowTickMarks = this.ssShowTickMarks;
t.ssTickMarksInterval = this.ssTickMarksInterval;
t.ssIsDisabled = this.ssIsDisabled;
t.ssOrientation = this.ssOrientation;
t.ssSize = this.ssSize;
t.ssShowFloatingLabel = this.ssShowFloatingLabel;
t.ssInitialValueFrom = this.ssInitialValueFrom;
t.ssInitialValueTo = this.ssInitialValueTo;
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
if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
} else if (head == "minvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinValue")) variable.Value = ssMinValue; else variable.Optimized = true;
} else if (head == "maxvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxValue")) variable.Value = ssMaxValue; else variable.Optimized = true;
} else if (head == "startingvaluefrom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartingValueFrom")) variable.Value = ssStartingValueFrom; else variable.Optimized = true;
} else if (head == "startingvalueto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartingValueTo")) variable.Value = ssStartingValueTo; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "step") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Step")) variable.Value = ssStep; else variable.Optimized = true;
} else if (head == "showtickmarks") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowTickMarks")) variable.Value = ssShowTickMarks; else variable.Optimized = true;
} else if (head == "tickmarksinterval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TickMarksInterval")) variable.Value = ssTickMarksInterval; else variable.Optimized = true;
} else if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
} else if (head == "orientation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Orientation")) variable.Value = ssOrientation; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
} else if (head == "showfloatinglabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowFloatingLabel")) variable.Value = ssShowFloatingLabel; else variable.Optimized = true;
} else if (head == "initialvaluefrom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialValueFrom")) variable.Value = ssInitialValueFrom; else variable.Optimized = true;
} else if (head == "initialvalueto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialValueTo")) variable.Value = ssInitialValueTo; else variable.Optimized = true;
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
if (key == IdUniqueId) {
return ssUniqueId;
}
if (key == IdMinValue) {
return ssMinValue;
}
if (key == IdMaxValue) {
return ssMaxValue;
}
if (key == IdStartingValueFrom) {
return ssStartingValueFrom;
}
if (key == IdStartingValueTo) {
return ssStartingValueTo;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
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
if (key == IdOrientation) {
return ssOrientation;
}
if (key == IdSize) {
return ssSize;
}
if (key == IdShowFloatingLabel) {
return ssShowFloatingLabel;
}
if (key == IdInitialValueFrom) {
return ssInitialValueFrom;
}
if (key == IdInitialValueTo) {
return ssInitialValueTo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
if (attributeKey == IdMinValue.Key.AsGuid) {
return ssMinValue;
}
if (attributeKey == IdMaxValue.Key.AsGuid) {
return ssMaxValue;
}
if (attributeKey == IdStartingValueFrom.Key.AsGuid) {
return ssStartingValueFrom;
}
if (attributeKey == IdStartingValueTo.Key.AsGuid) {
return ssStartingValueTo;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
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
if (attributeKey == IdOrientation.Key.AsGuid) {
return ssOrientation;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdShowFloatingLabel.Key.AsGuid) {
return ssShowFloatingLabel;
}
if (attributeKey == IdInitialValueFrom.Key.AsGuid) {
return ssInitialValueFrom;
}
if (attributeKey == IdInitialValueTo.Key.AsGuid) {
return ssInitialValueTo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
ssMinValue = (decimal) other.AttributeGet(IdMinValue);
ssMaxValue = (decimal) other.AttributeGet(IdMaxValue);
ssStartingValueFrom = (decimal) other.AttributeGet(IdStartingValueFrom);
ssStartingValueTo = (decimal) other.AttributeGet(IdStartingValueTo);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssStep = (decimal) other.AttributeGet(IdStep);
ssShowTickMarks = (bool) other.AttributeGet(IdShowTickMarks);
ssTickMarksInterval = (int) other.AttributeGet(IdTickMarksInterval);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssOrientation = (string) other.AttributeGet(IdOrientation);
ssSize = (string) other.AttributeGet(IdSize);
ssShowFloatingLabel = (bool) other.AttributeGet(IdShowFloatingLabel);
ssInitialValueFrom = (decimal) other.AttributeGet(IdInitialValueFrom);
ssInitialValueTo = (decimal) other.AttributeGet(IdInitialValueTo);
}
} // ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure
/// <summary>
/// RecordList type <code>RangeSlider_InternalConfigList</code> that represents a record list of
///  <code>RangeSlider_InternalConfig</code>
/// </summary>
public partial class RL_851e3aab1d06720d1786c3bd3c18c1aa : GenericRecordList<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure GetElementDefaultValue() {
return new ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure();
}

public T[] ToArray<T>(Func<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_851e3aab1d06720d1786c3bd3c18c1aa recordList, Func<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_851e3aab1d06720d1786c3bd3c18c1aa(ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure[] array) {
  RL_851e3aab1d06720d1786c3bd3c18c1aa result = new RL_851e3aab1d06720d1786c3bd3c18c1aa();
result.InnerFromArray(array);
    return result;
}

public static RL_851e3aab1d06720d1786c3bd3c18c1aa ToList<T>(T[] array, Func <T, ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure> converter) {
  RL_851e3aab1d06720d1786c3bd3c18c1aa result = new RL_851e3aab1d06720d1786c3bd3c18c1aa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_851e3aab1d06720d1786c3bd3c18c1aa FromRestList<T>(RestList<T> restList, Func <T, ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure> converter) {
  RL_851e3aab1d06720d1786c3bd3c18c1aa result = new RL_851e3aab1d06720d1786c3bd3c18c1aa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_851e3aab1d06720d1786c3bd3c18c1aa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5abb10cad8e1029cd3a5a677a5bd89aeStructure> NewList() {
return new RL_851e3aab1d06720d1786c3bd3c18c1aa();
}


} // RL_851e3aab1d06720d1786c3bd3c18c1aa
}

