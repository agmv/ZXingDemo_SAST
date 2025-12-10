namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_to_provider_shape_configs (MoAcoeDjw0eCFGdPryY3ww)
///  <code>ST_4d96f69748c4f35fb433f7995d061407Structure</code> that represent
/// s <code>Internal_to_provider_shape_configs</code> <p>Description: Structure to handle internal
///  configurations associated with Shapes at the provider level.</p>
/// </summary>
// Name: Internal_to_provider_shape_configs
public partial struct ST_4d96f69748c4f35fb433f7995d061407Structure : ITypedRecord<ST_4d96f69748c4f35fb433f7995d061407Structure> {
internal static readonly GlobalObjectKey Idlocations = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*h0I5er7hmk2g1ErZzqcwGw");
internal static readonly GlobalObjectKey Idcenter = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*yz6LzQ7P3E2IV9XRVpq+ow");
internal static readonly GlobalObjectKey Idbounds = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*TehRZA6tq0Sm0FCqya7O1w");
internal static readonly GlobalObjectKey Idradius = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*D7Z1tPRZy0uti5R1iCXb9A");
internal static readonly GlobalObjectKey IdallowDrag = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*7BL2_bGgYU6BYodHHYKYJg");
internal static readonly GlobalObjectKey IdallowEdit = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*QoO_neqf106yHzp1aUrQsQ");
internal static readonly GlobalObjectKey IdstrokeColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*StrXvOPCCUCtqiHsfhSHEg");
internal static readonly GlobalObjectKey IdstrokeOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*lpyp9fg7P0aJuD75dDMLYA");
internal static readonly GlobalObjectKey IdstrokeWeight = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*gdI4jH_RM0yTq1+PwDIoIA");
internal static readonly GlobalObjectKey IdfillColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*QzcVq9HzaUaLoykbmxELcw");
internal static readonly GlobalObjectKey IdfillOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*jYTM6hUCzUionzNJyuy_Vg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("locations")]
public string sslocations;

[System.Xml.Serialization.XmlElement("center")]
public string sscenter;

[System.Xml.Serialization.XmlElement("bounds")]
public string ssbounds;

[System.Xml.Serialization.XmlElement("radius")]
public int ssradius;

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

public ST_4d96f69748c4f35fb433f7995d061407Structure() {
OptimizedAttributes = null;
sslocations = "";
sscenter = "";
ssbounds = "";
ssradius = 0;
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
sslocations = r.ReadText(index++, "Internal_to_provider_shape_configs.locations", "");
sscenter = r.ReadText(index++, "Internal_to_provider_shape_configs.center", "");
ssbounds = r.ReadText(index++, "Internal_to_provider_shape_configs.bounds", "");
ssradius = r.ReadInteger(index++, "Internal_to_provider_shape_configs.radius", 0);
ssallowDrag = r.ReadBoolean(index++, "Internal_to_provider_shape_configs.allowDrag", false);
ssallowEdit = r.ReadBoolean(index++, "Internal_to_provider_shape_configs.allowEdit", false);
ssstrokeColor = r.ReadText(index++, "Internal_to_provider_shape_configs.strokeColor", "");
ssstrokeOpacity = r.ReadDecimal(index++, "Internal_to_provider_shape_configs.strokeOpacity", 0.0M);
ssstrokeWeight = r.ReadInteger(index++, "Internal_to_provider_shape_configs.strokeWeight", 0);
ssfillColor = r.ReadText(index++, "Internal_to_provider_shape_configs.fillColor", "");
ssfillOpacity = r.ReadDecimal(index++, "Internal_to_provider_shape_configs.fillOpacity", 0.0M);
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
public void ReadIM(ST_4d96f69748c4f35fb433f7995d061407Structure r) {
this = r;
}


public static bool operator == (ST_4d96f69748c4f35fb433f7995d061407Structure a, ST_4d96f69748c4f35fb433f7995d061407Structure b) {
if (a.sslocations != b.sslocations) return false;
if (a.sscenter != b.sscenter) return false;
if (a.ssbounds != b.ssbounds) return false;
if (a.ssradius != b.ssradius) return false;
if (a.ssallowDrag != b.ssallowDrag) return false;
if (a.ssallowEdit != b.ssallowEdit) return false;
if (a.ssstrokeColor != b.ssstrokeColor) return false;
if (a.ssstrokeOpacity != b.ssstrokeOpacity) return false;
if (a.ssstrokeWeight != b.ssstrokeWeight) return false;
if (a.ssfillColor != b.ssfillColor) return false;
if (a.ssfillOpacity != b.ssfillOpacity) return false;
return true;
}

public static bool operator != (ST_4d96f69748c4f35fb433f7995d061407Structure a, ST_4d96f69748c4f35fb433f7995d061407Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4d96f69748c4f35fb433f7995d061407Structure)) return false;
return (this == (ST_4d96f69748c4f35fb433f7995d061407Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sslocations.GetHashCode()
 ^ sscenter.GetHashCode()
 ^ ssbounds.GetHashCode()
 ^ ssradius.GetHashCode()
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


public ST_4d96f69748c4f35fb433f7995d061407Structure Duplicate() {
ST_4d96f69748c4f35fb433f7995d061407Structure t;
t.sslocations = this.sslocations;
t.sscenter = this.sscenter;
t.ssbounds = this.ssbounds;
t.ssradius = this.ssradius;
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
if (head == "locations") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".locations")) variable.Value = sslocations; else variable.Optimized = true;
} else if (head == "center") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".center")) variable.Value = sscenter; else variable.Optimized = true;
} else if (head == "bounds") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".bounds")) variable.Value = ssbounds; else variable.Optimized = true;
} else if (head == "radius") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".radius")) variable.Value = ssradius; else variable.Optimized = true;
} else if (head == "allowdrag") {
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
if (key == Idlocations) {
return sslocations;
}
if (key == Idcenter) {
return sscenter;
}
if (key == Idbounds) {
return ssbounds;
}
if (key == Idradius) {
return ssradius;
}
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
if (attributeKey == Idlocations.Key.AsGuid) {
return sslocations;
}
if (attributeKey == Idcenter.Key.AsGuid) {
return sscenter;
}
if (attributeKey == Idbounds.Key.AsGuid) {
return ssbounds;
}
if (attributeKey == Idradius.Key.AsGuid) {
return ssradius;
}
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
sslocations = (string) other.AttributeGet(Idlocations);
sscenter = (string) other.AttributeGet(Idcenter);
ssbounds = (string) other.AttributeGet(Idbounds);
ssradius = (int) other.AttributeGet(Idradius);
ssallowDrag = (bool) other.AttributeGet(IdallowDrag);
ssallowEdit = (bool) other.AttributeGet(IdallowEdit);
ssstrokeColor = (string) other.AttributeGet(IdstrokeColor);
ssstrokeOpacity = (decimal) other.AttributeGet(IdstrokeOpacity);
ssstrokeWeight = (int) other.AttributeGet(IdstrokeWeight);
ssfillColor = (string) other.AttributeGet(IdfillColor);
ssfillOpacity = (decimal) other.AttributeGet(IdfillOpacity);
}
} // ST_4d96f69748c4f35fb433f7995d061407Structure
/// <summary>
/// RecordList type <code>Internal_to_provider_shape_configsList</code> that represents a record list
///  of <code>Internal_to_provider_shape_configs</code>
/// </summary>
public partial class RL_0407be818a2fac09cd5cb9fba665bce7 : GenericRecordList<ST_4d96f69748c4f35fb433f7995d061407Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_4d96f69748c4f35fb433f7995d061407Structure GetElementDefaultValue() {
return new ST_4d96f69748c4f35fb433f7995d061407Structure();
}

public T[] ToArray<T>(Func<ST_4d96f69748c4f35fb433f7995d061407Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0407be818a2fac09cd5cb9fba665bce7 recordList, Func<ST_4d96f69748c4f35fb433f7995d061407Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0407be818a2fac09cd5cb9fba665bce7(ST_4d96f69748c4f35fb433f7995d061407Structure[] array) {
  RL_0407be818a2fac09cd5cb9fba665bce7 result = new RL_0407be818a2fac09cd5cb9fba665bce7();
result.InnerFromArray(array);
    return result;
}

public static RL_0407be818a2fac09cd5cb9fba665bce7 ToList<T>(T[] array, Func <T, ST_4d96f69748c4f35fb433f7995d061407Structure> converter) {
  RL_0407be818a2fac09cd5cb9fba665bce7 result = new RL_0407be818a2fac09cd5cb9fba665bce7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0407be818a2fac09cd5cb9fba665bce7 FromRestList<T>(RestList<T> restList, Func <T, ST_4d96f69748c4f35fb433f7995d061407Structure> converter) {
  RL_0407be818a2fac09cd5cb9fba665bce7 result = new RL_0407be818a2fac09cd5cb9fba665bce7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0407be818a2fac09cd5cb9fba665bce7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4d96f69748c4f35fb433f7995d061407Structure> NewList() {
return new RL_0407be818a2fac09cd5cb9fba665bce7();
}


} // RL_0407be818a2fac09cd5cb9fba665bce7
}

