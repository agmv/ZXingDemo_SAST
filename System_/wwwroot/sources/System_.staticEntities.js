import * as OS from "@outsystems/runtime-core-js";
var System_Model = {
staticEntities: {
runtimeType: Object.freeze({
get mobile() {return "Mobile";
},
get mobileLibrary() {return "MobileLibrary";
},
get service() {return "Service";
},
get reactive() {return "Reactive";
},
get unknown() {return "Unknown";
},
get reactiveLibrary() {return "ReactiveLibrary";
}
}),
processStatus: Object.freeze({
get active() {return OS.BuiltinFunctions.integerToLongInteger(1);
},
get activeWithErrors() {return OS.BuiltinFunctions.integerToLongInteger(2);
},
get terminated() {return OS.BuiltinFunctions.integerToLongInteger(4);
},
get done() {return OS.BuiltinFunctions.integerToLongInteger(3);
}
}),
activityStatus: Object.freeze({
get running() {return OS.BuiltinFunctions.integerToLongInteger(2);
},
get terminated() {return OS.BuiltinFunctions.integerToLongInteger(4);
},
get waiting() {return OS.BuiltinFunctions.integerToLongInteger(1);
},
get open() {return OS.BuiltinFunctions.integerToLongInteger(6);
},
get error() {return OS.BuiltinFunctions.integerToLongInteger(5);
},
get completed() {return OS.BuiltinFunctions.integerToLongInteger(3);
}
}),
activityKind: Object.freeze({
get terminate() {return OS.BuiltinFunctions.integerToLongInteger(8);
},
get end() {return OS.BuiltinFunctions.integerToLongInteger(5);
},
get conditionalStart() {return OS.BuiltinFunctions.integerToLongInteger(6);
},
get wait() {return OS.BuiltinFunctions.integerToLongInteger(7);
},
get decision() {return OS.BuiltinFunctions.integerToLongInteger(4);
},
get humanActivity() {return OS.BuiltinFunctions.integerToLongInteger(3);
},
get automaticActivity() {return OS.BuiltinFunctions.integerToLongInteger(2);
},
get start() {return OS.BuiltinFunctions.integerToLongInteger(1);
}
})
}
};
export var staticEntities = System_Model.staticEntities;


