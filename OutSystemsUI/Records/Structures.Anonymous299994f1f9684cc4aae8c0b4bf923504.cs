namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (8ZSZKWj5xEyq6MC0v5I1BA)
///  <code>RC_c3613394da5ea68f302177112ad784ed</code> that represent
/// s
///  <code>DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPi
/// psStepVerticalHeightRecord</code> <p>Description: </p>
/// </summary>
// Name: DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord
public partial struct RC_c3613394da5ea68f302177112ad784ed : ITypedRecord<RC_c3613394da5ea68f302177112ad784ed> {
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UH1XvwJCNfm1kng6R5jWbg");
internal static readonly GlobalObjectKey IdInitialValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HnyFKLbcr0Yz5As5TAhusA");
internal static readonly GlobalObjectKey IdMaxValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6uFR9HTOmqEGH4gOQYyWiw");
internal static readonly GlobalObjectKey IdMinValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZlVfMGnOfAvJfYqNjg+94w");
internal static readonly GlobalObjectKey IdStep = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Lxr60GzwcCcQeXc3wkY8UQ");
internal static readonly GlobalObjectKey IdChangeEventDuringSlide = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gruFhmhKNZaCHiVCxT1GKA");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VngedsaPJ70hK0wO2TGGoQ");
internal static readonly GlobalObjectKey IdIsVertical = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fixrIXg68TmtaZrz4OwwyQ");
internal static readonly GlobalObjectKey IdShowPips = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cxRQnSS5eG37MxZNUIlSdg");
internal static readonly GlobalObjectKey IdPipsStep = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wNIluxLFC4alNXR0JZ2mWg");
internal static readonly GlobalObjectKey IdVerticalHeight = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ssxPOqbJ5DzKlrMqsMeHBQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Direction")]
public string ssDirection;

[System.Xml.Serialization.XmlElement("InitialValue")]
public decimal ssInitialValue;

[System.Xml.Serialization.XmlElement("MaxValue")]
public decimal ssMaxValue;

[System.Xml.Serialization.XmlElement("MinValue")]
public decimal ssMinValue;

[System.Xml.Serialization.XmlElement("Step")]
public decimal ssStep;

[System.Xml.Serialization.XmlElement("ChangeEventDuringSlide")]
public bool ssChangeEventDuringSlide;

[System.Xml.Serialization.XmlElement("IsDisabled")]
public bool ssIsDisabled;

[System.Xml.Serialization.XmlElement("IsVertical")]
public bool ssIsVertical;

[System.Xml.Serialization.XmlElement("ShowPips")]
public bool ssShowPips;

[System.Xml.Serialization.XmlElement("PipsStep")]
public int ssPipsStep;

[System.Xml.Serialization.XmlElement("VerticalHeight")]
public int ssVerticalHeight;


public BitArray OptimizedAttributes;

public RC_c3613394da5ea68f302177112ad784ed() {
OptimizedAttributes = null;
ssDirection = "";
ssInitialValue = 0.0M;
ssMaxValue = 0.0M;
ssMinValue = 0.0M;
ssStep = 0.0M;
ssChangeEventDuringSlide = false;
ssIsDisabled = false;
ssIsVertical = false;
ssShowPips = false;
ssPipsStep = 0;
ssVerticalHeight = 0;
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
ssDirection = r.ReadText(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.Direction", "");
ssInitialValue = r.ReadDecimal(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.InitialValue", 0.0M);
ssMaxValue = r.ReadDecimal(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.MaxValue", 0.0M);
ssMinValue = r.ReadDecimal(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.MinValue", 0.0M);
ssStep = r.ReadDecimal(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.Step", 0.0M);
ssChangeEventDuringSlide = r.ReadBoolean(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.ChangeEventDuringSlide", false);
ssIsDisabled = r.ReadBoolean(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.IsDisabled", false);
ssIsVertical = r.ReadBoolean(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.IsVertical", false);
ssShowPips = r.ReadBoolean(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.ShowPips", false);
ssPipsStep = r.ReadInteger(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.PipsStep", 0);
ssVerticalHeight = r.ReadInteger(index++, "DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPipsStepVerticalHeightRecord.VerticalHeight", 0);
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
public void ReadIM(RC_c3613394da5ea68f302177112ad784ed r) {
this = r;
}


public static bool operator == (RC_c3613394da5ea68f302177112ad784ed a, RC_c3613394da5ea68f302177112ad784ed b) {
if (a.ssDirection != b.ssDirection) return false;
if (a.ssInitialValue != b.ssInitialValue) return false;
if (a.ssMaxValue != b.ssMaxValue) return false;
if (a.ssMinValue != b.ssMinValue) return false;
if (a.ssStep != b.ssStep) return false;
if (a.ssChangeEventDuringSlide != b.ssChangeEventDuringSlide) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssIsVertical != b.ssIsVertical) return false;
if (a.ssShowPips != b.ssShowPips) return false;
if (a.ssPipsStep != b.ssPipsStep) return false;
if (a.ssVerticalHeight != b.ssVerticalHeight) return false;
return true;
}

public static bool operator != (RC_c3613394da5ea68f302177112ad784ed a, RC_c3613394da5ea68f302177112ad784ed b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c3613394da5ea68f302177112ad784ed)) return false;
return (this == (RC_c3613394da5ea68f302177112ad784ed)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssInitialValue.GetHashCode()
 ^ ssMaxValue.GetHashCode()
 ^ ssMinValue.GetHashCode()
 ^ ssStep.GetHashCode()
 ^ ssChangeEventDuringSlide.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
 ^ ssIsVertical.GetHashCode()
 ^ ssShowPips.GetHashCode()
 ^ ssPipsStep.GetHashCode()
 ^ ssVerticalHeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_c3613394da5ea68f302177112ad784ed Duplicate() {
RC_c3613394da5ea68f302177112ad784ed t;
t.ssDirection = this.ssDirection;
t.ssInitialValue = this.ssInitialValue;
t.ssMaxValue = this.ssMaxValue;
t.ssMinValue = this.ssMinValue;
t.ssStep = this.ssStep;
t.ssChangeEventDuringSlide = this.ssChangeEventDuringSlide;
t.ssIsDisabled = this.ssIsDisabled;
t.ssIsVertical = this.ssIsVertical;
t.ssShowPips = this.ssShowPips;
t.ssPipsStep = this.ssPipsStep;
t.ssVerticalHeight = this.ssVerticalHeight;
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
if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "initialvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialValue")) variable.Value = ssInitialValue; else variable.Optimized = true;
} else if (head == "maxvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxValue")) variable.Value = ssMaxValue; else variable.Optimized = true;
} else if (head == "minvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinValue")) variable.Value = ssMinValue; else variable.Optimized = true;
} else if (head == "step") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Step")) variable.Value = ssStep; else variable.Optimized = true;
} else if (head == "changeeventduringslide") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangeEventDuringSlide")) variable.Value = ssChangeEventDuringSlide; else variable.Optimized = true;
} else if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
} else if (head == "isvertical") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsVertical")) variable.Value = ssIsVertical; else variable.Optimized = true;
} else if (head == "showpips") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowPips")) variable.Value = ssShowPips; else variable.Optimized = true;
} else if (head == "pipsstep") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PipsStep")) variable.Value = ssPipsStep; else variable.Optimized = true;
} else if (head == "verticalheight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VerticalHeight")) variable.Value = ssVerticalHeight; else variable.Optimized = true;
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
if (key == IdDirection) {
return ssDirection;
}
if (key == IdInitialValue) {
return ssInitialValue;
}
if (key == IdMaxValue) {
return ssMaxValue;
}
if (key == IdMinValue) {
return ssMinValue;
}
if (key == IdStep) {
return ssStep;
}
if (key == IdChangeEventDuringSlide) {
return ssChangeEventDuringSlide;
}
if (key == IdIsDisabled) {
return ssIsDisabled;
}
if (key == IdIsVertical) {
return ssIsVertical;
}
if (key == IdShowPips) {
return ssShowPips;
}
if (key == IdPipsStep) {
return ssPipsStep;
}
if (key == IdVerticalHeight) {
return ssVerticalHeight;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdInitialValue.Key.AsGuid) {
return ssInitialValue;
}
if (attributeKey == IdMaxValue.Key.AsGuid) {
return ssMaxValue;
}
if (attributeKey == IdMinValue.Key.AsGuid) {
return ssMinValue;
}
if (attributeKey == IdStep.Key.AsGuid) {
return ssStep;
}
if (attributeKey == IdChangeEventDuringSlide.Key.AsGuid) {
return ssChangeEventDuringSlide;
}
if (attributeKey == IdIsDisabled.Key.AsGuid) {
return ssIsDisabled;
}
if (attributeKey == IdIsVertical.Key.AsGuid) {
return ssIsVertical;
}
if (attributeKey == IdShowPips.Key.AsGuid) {
return ssShowPips;
}
if (attributeKey == IdPipsStep.Key.AsGuid) {
return ssPipsStep;
}
if (attributeKey == IdVerticalHeight.Key.AsGuid) {
return ssVerticalHeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDirection = (string) other.AttributeGet(IdDirection);
ssInitialValue = (decimal) other.AttributeGet(IdInitialValue);
ssMaxValue = (decimal) other.AttributeGet(IdMaxValue);
ssMinValue = (decimal) other.AttributeGet(IdMinValue);
ssStep = (decimal) other.AttributeGet(IdStep);
ssChangeEventDuringSlide = (bool) other.AttributeGet(IdChangeEventDuringSlide);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssIsVertical = (bool) other.AttributeGet(IdIsVertical);
ssShowPips = (bool) other.AttributeGet(IdShowPips);
ssPipsStep = (int) other.AttributeGet(IdPipsStep);
ssVerticalHeight = (int) other.AttributeGet(IdVerticalHeight);
}
} // RC_c3613394da5ea68f302177112ad784ed
/// <summary>
/// RecordList type
///  <code>DirectionInitialValueMaxValueMinValueStepChangeEventDuringSlideIsDisabledIsVerticalShowPipsPi
/// psStepVerticalHeightRecordList</code> that represents a record list of <code>Text, Decimal,
///  Decimal, Decimal, Decimal, Boolean, Boolean, Boolean, Boolean, Integer, Integer</code>
/// </summary>
public partial class RL_914da2be0748baaaf7570352c3c10799 : GenericRecordList<RC_c3613394da5ea68f302177112ad784ed>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_c3613394da5ea68f302177112ad784ed GetElementDefaultValue() {
return new RC_c3613394da5ea68f302177112ad784ed();
}

public T[] ToArray<T>(Func<RC_c3613394da5ea68f302177112ad784ed, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_914da2be0748baaaf7570352c3c10799 recordList, Func<RC_c3613394da5ea68f302177112ad784ed, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_914da2be0748baaaf7570352c3c10799(RC_c3613394da5ea68f302177112ad784ed[] array) {
  RL_914da2be0748baaaf7570352c3c10799 result = new RL_914da2be0748baaaf7570352c3c10799();
result.InnerFromArray(array);
    return result;
}

public static RL_914da2be0748baaaf7570352c3c10799 ToList<T>(T[] array, Func <T, RC_c3613394da5ea68f302177112ad784ed> converter) {
  RL_914da2be0748baaaf7570352c3c10799 result = new RL_914da2be0748baaaf7570352c3c10799();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_914da2be0748baaaf7570352c3c10799 FromRestList<T>(RestList<T> restList, Func <T, RC_c3613394da5ea68f302177112ad784ed> converter) {
  RL_914da2be0748baaaf7570352c3c10799 result = new RL_914da2be0748baaaf7570352c3c10799();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_914da2be0748baaaf7570352c3c10799() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c3613394da5ea68f302177112ad784ed> NewList() {
return new RL_914da2be0748baaaf7570352c3c10799();
}


} // RL_914da2be0748baaaf7570352c3c10799
}

