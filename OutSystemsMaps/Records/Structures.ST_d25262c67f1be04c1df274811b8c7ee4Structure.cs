namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_drawFilledShape_configs (WPmwy36CtES52O0tPtn4UA)
///  <code>ST_d25262c67f1be04c1df274811b8c7ee4Structure</code> that represent
/// s <code>Internal_to_provider_drawFilledShape_configs</code> <p>Description: Structure to handle
///  internal configurations associated with the Drawing Tools.</p>
/// </summary>
// Name: Internal_to_provider_drawFilledShape_configs
public partial struct ST_d25262c67f1be04c1df274811b8c7ee4Structure : ITypedRecord<ST_d25262c67f1be04c1df274811b8c7ee4Structure> {
internal static readonly GlobalObjectKey IdallowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*YPN_bg8Ea0OlbxRP5CNT0Q");
internal static readonly GlobalObjectKey IdallowEdit = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*MxVpc8pHYUmhPIxhFHK2Ow");
internal static readonly GlobalObjectKey IdstrokeColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*gKO7UAgQhEyRlU8F4JJFpQ");
internal static readonly GlobalObjectKey IdstrokeOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nQGGKVWgKkSsXHwJcMcTzw");
internal static readonly GlobalObjectKey IdstrokeWeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*GRz5M0yuekGKO6Y3E7x0jA");
internal static readonly GlobalObjectKey IdfillColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*Sp0QO50dLk6bYmFlP42QQg");
internal static readonly GlobalObjectKey IdfillOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*nmeKOAEOCkq5eZCGs5_oIg");

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

[System.Xml.Serialization.XmlElement("fillColor")]
public string ssfillColor;

[System.Xml.Serialization.XmlElement("fillOpacity")]
public decimal ssfillOpacity;


public BitArray OptimizedAttributes;

public ST_d25262c67f1be04c1df274811b8c7ee4Structure() {
OptimizedAttributes = null;
ssallowDrag = false;
ssallowEdit = false;
ssstrokeColor = "#000000";
ssstrokeOpacity = (((decimal)1));
ssstrokeWeight = 2;
ssfillColor = "#000000";
ssfillOpacity = (((decimal)1));
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
ssallowDrag = r.ReadBoolean(index++, "Internal_to_provider_drawFilledShape_configs.allowDrag", false);
ssallowEdit = r.ReadBoolean(index++, "Internal_to_provider_drawFilledShape_configs.allowEdit", false);
ssstrokeColor = r.ReadText(index++, "Internal_to_provider_drawFilledShape_configs.strokeColor", "");
ssstrokeOpacity = r.ReadDecimal(index++, "Internal_to_provider_drawFilledShape_configs.strokeOpacity", 0.0M);
ssstrokeWeight = r.ReadInteger(index++, "Internal_to_provider_drawFilledShape_configs.strokeWeight", 0);
ssfillColor = r.ReadText(index++, "Internal_to_provider_drawFilledShape_configs.fillColor", "");
ssfillOpacity = r.ReadDecimal(index++, "Internal_to_provider_drawFilledShape_configs.fillOpacity", 0.0M);
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
public void ReadIM(ST_d25262c67f1be04c1df274811b8c7ee4Structure r) {
this = r;
}


public static bool operator == (ST_d25262c67f1be04c1df274811b8c7ee4Structure a, ST_d25262c67f1be04c1df274811b8c7ee4Structure b) {
if (a.ssallowDrag != b.ssallowDrag) return false;
if (a.ssallowEdit != b.ssallowEdit) return false;
if (a.ssstrokeColor != b.ssstrokeColor) return false;
if (a.ssstrokeOpacity != b.ssstrokeOpacity) return false;
if (a.ssstrokeWeight != b.ssstrokeWeight) return false;
if (a.ssfillColor != b.ssfillColor) return false;
if (a.ssfillOpacity != b.ssfillOpacity) return false;
return true;
}

public static bool operator != (ST_d25262c67f1be04c1df274811b8c7ee4Structure a, ST_d25262c67f1be04c1df274811b8c7ee4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d25262c67f1be04c1df274811b8c7ee4Structure)) return false;
return (this == (ST_d25262c67f1be04c1df274811b8c7ee4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssallowDrag.GetHashCode()
 ^ ssallowEdit.GetHashCode()
 ^ ssstrokeColor.GetHashCode()
 ^ ssstrokeOpacity.GetHashCode()
 ^ ssstrokeWeight.GetHashCode()
 ^ ssfillColor.GetHashCode()
 ^ ssfillOpacity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d25262c67f1be04c1df274811b8c7ee4Structure Duplicate() {
ST_d25262c67f1be04c1df274811b8c7ee4Structure t;
t.ssallowDrag = this.ssallowDrag;
t.ssallowEdit = this.ssallowEdit;
t.ssstrokeColor = this.ssstrokeColor;
t.ssstrokeOpacity = this.ssstrokeOpacity;
t.ssstrokeWeight = this.ssstrokeWeight;
t.ssfillColor = this.ssfillColor;
t.ssfillOpacity = this.ssfillOpacity;
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
} else if (head == "fillcolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".fillColor")) variable.Value = ssfillColor; else variable.Optimized = true;
} else if (head == "fillopacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".fillOpacity")) variable.Value = ssfillOpacity; else variable.Optimized = true;
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
if (key == IdfillColor) {
return ssfillColor;
}
if (key == IdfillOpacity) {
return ssfillOpacity;
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
if (attributeKey == IdfillColor.Key.AsGuid) {
return ssfillColor;
}
if (attributeKey == IdfillOpacity.Key.AsGuid) {
return ssfillOpacity;
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
ssfillColor = (string) other.AttributeGet(IdfillColor);
ssfillOpacity = (decimal) other.AttributeGet(IdfillOpacity);
}
} // ST_d25262c67f1be04c1df274811b8c7ee4Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_drawFilledShape_configsList</code> that represents a
///  record list of <code>Internal_to_provider_drawFilledShape_configs</code>
/// </summary>
public partial class RL_fa4032a5fa1100d682b184e818a06718 : GenericRecordList<ST_d25262c67f1be04c1df274811b8c7ee4Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_d25262c67f1be04c1df274811b8c7ee4Structure GetElementDefaultValue() {
return new ST_d25262c67f1be04c1df274811b8c7ee4Structure();
}

public T[] ToArray<T>(Func<ST_d25262c67f1be04c1df274811b8c7ee4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fa4032a5fa1100d682b184e818a06718 recordList, Func<ST_d25262c67f1be04c1df274811b8c7ee4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fa4032a5fa1100d682b184e818a06718(ST_d25262c67f1be04c1df274811b8c7ee4Structure[] array) {
  RL_fa4032a5fa1100d682b184e818a06718 result = new RL_fa4032a5fa1100d682b184e818a06718();
result.InnerFromArray(array);
    return result;
}

public static RL_fa4032a5fa1100d682b184e818a06718 ToList<T>(T[] array, Func <T, ST_d25262c67f1be04c1df274811b8c7ee4Structure> converter) {
  RL_fa4032a5fa1100d682b184e818a06718 result = new RL_fa4032a5fa1100d682b184e818a06718();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fa4032a5fa1100d682b184e818a06718 FromRestList<T>(RestList<T> restList, Func <T, ST_d25262c67f1be04c1df274811b8c7ee4Structure> converter) {
  RL_fa4032a5fa1100d682b184e818a06718 result = new RL_fa4032a5fa1100d682b184e818a06718();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fa4032a5fa1100d682b184e818a06718() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d25262c67f1be04c1df274811b8c7ee4Structure> NewList() {
return new RL_fa4032a5fa1100d682b184e818a06718();
}


} // RL_fa4032a5fa1100d682b184e818a06718
}

