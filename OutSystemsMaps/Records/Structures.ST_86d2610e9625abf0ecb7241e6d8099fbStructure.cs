namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_drawNotFilledShape_configs (XP5BXZXXqkaA8ZUvsFnNJw)
///  <code>ST_86d2610e9625abf0ecb7241e6d8099fbStructure</code> that represent
/// s <code>Internal_to_provider_drawNotFilledShape_configs</code> <p>Description: Structure to handle
///  internal configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_to_provider_drawNotFilledShape_configs
public partial struct ST_86d2610e9625abf0ecb7241e6d8099fbStructure : ITypedRecord<ST_86d2610e9625abf0ecb7241e6d8099fbStructure> {
internal static readonly GlobalObjectKey IdallowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*4dUHm08ADU2_77A1_QLjgg");
internal static readonly GlobalObjectKey IdallowEdit = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*zu1YTgwrYkC8cZuGEPaEcw");
internal static readonly GlobalObjectKey IdstrokeColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*FrG2Lb12WkmXXqs8TFqATA");
internal static readonly GlobalObjectKey IdstrokeOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*7o+bds061kScAI_jlbvKmw");
internal static readonly GlobalObjectKey IdstrokeWeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*PB8Xkaak20GXnXFJV4xtbw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("allowDrag")]
public bool ssallowDrag;

[System.Xml.Serialization.XmlElement("allowEdit")]
public bool ssallowEdit;

[System.Xml.Serialization.XmlElement("strokeColor")]
public string ssstrokeColor;

[System.Xml.Serialization.XmlElement("strokeOpacity")]
public decimal ssstrokeOpacity;

[System.Xml.Serialization.XmlElement("strokeWeight")]
public int ssstrokeWeight;


public BitArray OptimizedAttributes;

public ST_86d2610e9625abf0ecb7241e6d8099fbStructure() {
OptimizedAttributes = null;
ssallowDrag = false;
ssallowEdit = false;
ssstrokeColor = "#000000";
ssstrokeOpacity = (((decimal)1));
ssstrokeWeight = 2;
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
ssallowDrag = r.ReadBoolean(index++, "Internal_to_provider_drawNotFilledShape_configs.allowDrag", false);
ssallowEdit = r.ReadBoolean(index++, "Internal_to_provider_drawNotFilledShape_configs.allowEdit", false);
ssstrokeColor = r.ReadText(index++, "Internal_to_provider_drawNotFilledShape_configs.strokeColor", "");
ssstrokeOpacity = r.ReadDecimal(index++, "Internal_to_provider_drawNotFilledShape_configs.strokeOpacity", 0.0M);
ssstrokeWeight = r.ReadInteger(index++, "Internal_to_provider_drawNotFilledShape_configs.strokeWeight", 0);
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
public void ReadIM(ST_86d2610e9625abf0ecb7241e6d8099fbStructure r) {
this = r;
}


public static bool operator == (ST_86d2610e9625abf0ecb7241e6d8099fbStructure a, ST_86d2610e9625abf0ecb7241e6d8099fbStructure b) {
if (a.ssallowDrag != b.ssallowDrag) return false;
if (a.ssallowEdit != b.ssallowEdit) return false;
if (a.ssstrokeColor != b.ssstrokeColor) return false;
if (a.ssstrokeOpacity != b.ssstrokeOpacity) return false;
if (a.ssstrokeWeight != b.ssstrokeWeight) return false;
return true;
}

public static bool operator != (ST_86d2610e9625abf0ecb7241e6d8099fbStructure a, ST_86d2610e9625abf0ecb7241e6d8099fbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_86d2610e9625abf0ecb7241e6d8099fbStructure)) return false;
return (this == (ST_86d2610e9625abf0ecb7241e6d8099fbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssallowDrag.GetHashCode()
 ^ ssallowEdit.GetHashCode()
 ^ ssstrokeColor.GetHashCode()
 ^ ssstrokeOpacity.GetHashCode()
 ^ ssstrokeWeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_86d2610e9625abf0ecb7241e6d8099fbStructure Duplicate() {
ST_86d2610e9625abf0ecb7241e6d8099fbStructure t;
t.ssallowDrag = this.ssallowDrag;
t.ssallowEdit = this.ssallowEdit;
t.ssstrokeColor = this.ssstrokeColor;
t.ssstrokeOpacity = this.ssstrokeOpacity;
t.ssstrokeWeight = this.ssstrokeWeight;
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
if (head == "allowdrag") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".allowDrag")) variable.Value = ssallowDrag; else variable.Optimized = true;
} else if (head == "allowedit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".allowEdit")) variable.Value = ssallowEdit; else variable.Optimized = true;
} else if (head == "strokecolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".strokeColor")) variable.Value = ssstrokeColor; else variable.Optimized = true;
} else if (head == "strokeopacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".strokeOpacity")) variable.Value = ssstrokeOpacity; else variable.Optimized = true;
} else if (head == "strokeweight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".strokeWeight")) variable.Value = ssstrokeWeight; else variable.Optimized = true;
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
if (key == IdallowDrag) {
return ssallowDrag;
}
if (key == IdallowEdit) {
return ssallowEdit;
}
if (key == IdstrokeColor) {
return ssstrokeColor;
}
if (key == IdstrokeOpacity) {
return ssstrokeOpacity;
}
if (key == IdstrokeWeight) {
return ssstrokeWeight;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdallowDrag.Key.AsGuid) {
return ssallowDrag;
}
if (attributeKey == IdallowEdit.Key.AsGuid) {
return ssallowEdit;
}
if (attributeKey == IdstrokeColor.Key.AsGuid) {
return ssstrokeColor;
}
if (attributeKey == IdstrokeOpacity.Key.AsGuid) {
return ssstrokeOpacity;
}
if (attributeKey == IdstrokeWeight.Key.AsGuid) {
return ssstrokeWeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssallowDrag = (bool) other.AttributeGet(IdallowDrag);
ssallowEdit = (bool) other.AttributeGet(IdallowEdit);
ssstrokeColor = (string) other.AttributeGet(IdstrokeColor);
ssstrokeOpacity = (decimal) other.AttributeGet(IdstrokeOpacity);
ssstrokeWeight = (int) other.AttributeGet(IdstrokeWeight);
}
} // ST_86d2610e9625abf0ecb7241e6d8099fbStructure
/// <summary>
/// RecordList type <code>Internal_to_provider_drawNotFilledShape_configsList</code> that represents a
///  record list of <code>Internal_to_provider_drawNotFilledShape_configs</code>
/// </summary>
public partial class RL_c0fa3cff543c32f44aedaea106082dd0 : GenericRecordList<ST_86d2610e9625abf0ecb7241e6d8099fbStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_86d2610e9625abf0ecb7241e6d8099fbStructure GetElementDefaultValue() {
return new ST_86d2610e9625abf0ecb7241e6d8099fbStructure();
}

public T[] ToArray<T>(Func<ST_86d2610e9625abf0ecb7241e6d8099fbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c0fa3cff543c32f44aedaea106082dd0 recordList, Func<ST_86d2610e9625abf0ecb7241e6d8099fbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c0fa3cff543c32f44aedaea106082dd0(ST_86d2610e9625abf0ecb7241e6d8099fbStructure[] array) {
  RL_c0fa3cff543c32f44aedaea106082dd0 result = new RL_c0fa3cff543c32f44aedaea106082dd0();
result.InnerFromArray(array);
    return result;
}

public static RL_c0fa3cff543c32f44aedaea106082dd0 ToList<T>(T[] array, Func <T, ST_86d2610e9625abf0ecb7241e6d8099fbStructure> converter) {
  RL_c0fa3cff543c32f44aedaea106082dd0 result = new RL_c0fa3cff543c32f44aedaea106082dd0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c0fa3cff543c32f44aedaea106082dd0 FromRestList<T>(RestList<T> restList, Func <T, ST_86d2610e9625abf0ecb7241e6d8099fbStructure> converter) {
  RL_c0fa3cff543c32f44aedaea106082dd0 result = new RL_c0fa3cff543c32f44aedaea106082dd0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c0fa3cff543c32f44aedaea106082dd0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_86d2610e9625abf0ecb7241e6d8099fbStructure> NewList() {
return new RL_c0fa3cff543c32f44aedaea106082dd0();
}


} // RL_c0fa3cff543c32f44aedaea106082dd0
}

