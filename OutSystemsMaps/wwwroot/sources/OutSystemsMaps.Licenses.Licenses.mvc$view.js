import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./OutSystemsMaps.Licenses.Licenses.mvc$model.js";
import ControllerFactory from "./OutSystemsMaps.Licenses.Licenses.mvc$controller.js";
import * as OS from "@outsystems/runtime-core-js";
import * as OSRuntimeCore from "@outsystems/runtime-core-js";
import * as OutSystemsMapsModel from "./OutSystemsMaps.model.js";
import * as OutSystemsMapsController from "./OutSystemsMaps.controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "license-font",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heading6",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Libraries We Use"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 20px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, "OutSystemsMaps uses a lot of great open source projects. These are their licenses and copyright notices. ", createElement("br"), createElement("br"), "========================================", createElement("br"), "Google Maps - Apache 2.0 License", createElement("br"), "========================================", createElement("br"), createElement("br"), "https://developers.google.com/maps/terms", createElement("br"), createElement("br"), "Copyright (c) Google", createElement("br"), createElement("br"), "Licensed under the Apache License, Version 2.0 (the \"License\");", createElement("br"), "you may not use this file except in compliance with the License.", createElement("br"), "You may obtain a copy of the License at", createElement("br"), createElement("br"), "    http://www.apache.org/licenses/LICENSE-2.0", createElement("br"), createElement("br"), "Unless required by applicable law or agreed to in writing, software", createElement("br"), "distributed under the License is distributed on an \"AS IS\" BASIS,", createElement("br"), "WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.", createElement("br"), "See the License for the specific language governing permissions and", createElement("br"), "limitations under the License.", createElement("br"), createElement("br"), "========================================", createElement("br"), "Leaflet - BSD 2-Clause License", createElement("br"), "========================================", createElement("br"), createElement("br"), "Copyright (c) 2010-2021, Vladimir Agafonkin", createElement("br"), "Copyright (c) 2010-2011, CloudMade", createElement("br"), "All rights reserved.", createElement("br"), createElement("br"), "Redistribution and use in source and binary forms, with or without", createElement("br"), "modification, are permitted provided that the following conditions are met:", createElement("br"), createElement("br"), "1.  Redistributions of source code must retain the above copyright notice, this", createElement("br"), "    list of conditions and the following disclaimer.", createElement("br"), createElement("br"), "2.  Redistributions in binary form must reproduce the above copyright notice,", createElement("br"), "    this list of conditions and the following disclaimer in the documentation", createElement("br"), "    and/or other materials provided with the distribution.", createElement("br"), createElement("br"), "THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS \"AS IS\"", createElement("br"), "AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE", createElement("br"), "IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE", createElement("br"), "DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE", createElement("br"), "FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL", createElement("br"), "DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR", createElement("br"), "SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER", createElement("br"), "CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,", createElement("br"), "OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE", createElement("br"), "OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.", createElement("br"), createElement("br"), "========================================", createElement("br"), "leaflet-routing-machine - ISC License", createElement("br"), "========================================", createElement("br"), createElement("br"), "Copyright (c) 2014, Per Liedman (per@liedman.net) Turn instruction icons Copyright (c) 2014, Mapbox (mapbox.com)", createElement("br"), createElement("br"), "Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.", createElement("br"), createElement("br"), "THE SOFTWARE IS PROVIDED \"AS IS\" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.", createElement("br"), createElement("br"), "========================================", createElement("br"), "Leaflet.Editable - WTFPL license", createElement("br"), "========================================", createElement("br"), createElement("br"), "Leaflet.Editable is released under the WTFPL license.", createElement("br"), createElement("br"), "========================================", createElement("br"), "Leaflet.draw - The MIT License (MIT)", createElement("br"), "========================================", createElement("br"), createElement("br"), "Copyright 2012-2017 Jon West, Jacob Toye, and Leaflet", createElement("br"), createElement("br"), "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:", createElement("br"), createElement("br"), "The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.", createElement("br"), createElement("br"), "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.", createElement("br"), createElement("br"), "========================================", createElement("br"), "Leaflet - Path.Drag.js - The MIT License (MIT)", createElement("br"), "========================================", createElement("br"), createElement("br"), "Copyright 2016 Yohan Boniface", createElement("br"), createElement("br"), "Permission is hereby granted, free of charge, to any person obtaining a copy", createElement("br"), "of this software and associated documentation files (the \"Software\"), to deal", createElement("br"), "in the Software without restriction, including without limitation the rights", createElement("br"), "to use, copy, modify, merge, publish, distribute, sublicense, and/or sell", createElement("br"), "copies of the Software, and to permit persons to whom the Software is", createElement("br"), "furnished to do so, subject to the following conditions:", createElement("br"), createElement("br"), "The above copyright notice and this permission notice shall be included in", createElement("br"), "all copies or substantial portions of the Software.", createElement("br"), createElement("br"), "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR", createElement("br"), "IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,", createElement("br"), "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE", createElement("br"), "AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER", createElement("br"), "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,", createElement("br"), "OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN", createElement("br"), "THE SOFTWARE.")));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Licenses",
functionKey: "c65d42f1-1b67-4d66-9408-7ecad7dbf9a2",
functionOwnerName: "OutSystemsMaps",
functionOwnerKey: "95bb31d1-f079-4fd6-ab2e-5c8326855aaa",
screen: ""
};
},
displayName: "Licenses.Licenses",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsMaps.Licenses.Licenses.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
