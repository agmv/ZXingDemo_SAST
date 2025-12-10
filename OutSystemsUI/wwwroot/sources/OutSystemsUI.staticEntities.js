import * as OS from "@outsystems/runtime-core-js";
var OutSystemsUIModel = {
staticEntities: {
carouselProvider: Object.freeze({
get splide() {return "Splide";
}
}),
animationType: Object.freeze({
get topToBottom() {return "top-to-bottom";
},
get bounce() {return "bounce";
},
get fadeIn() {return "fade-in";
},
get scaleDown() {return "scale-down";
},
get scale() {return "scale";
},
get spinner() {return "spinner";
},
get bottomToTop() {return "bottom-to-top";
},
get rightToLeft() {return "right-to-left";
},
get leftToRight() {return "left-to-right";
}
}),
speed: Object.freeze({
get fast() {return "fast";
},
get normal() {return "normal";
},
get slow() {return "slow";
}
}),
sideMenuBehavior: Object.freeze({
get visible() {return "aside-visible";
},
get expandable() {return "aside-expandable";
},
get overlay() {return "aside-overlay";
}
}),
gradient: Object.freeze({
get linearHorizontal() {return "LinearHorizontal";
},
get radial() {return "Radial";
},
get linearDiagonally() {return "LinearDiagonally";
},
get linearVertical() {return "LinearVertical";
}
}),
size: Object.freeze({
get medium() {return "medium";
},
get small() {return "small";
}
}),
deviceResponsive: Object.freeze({
get desktopAndTablet() {return "DesktopAndTablet";
},
get tabletOnly() {return "TabletOnly";
},
get allDevices() {return "AllDevices";
},
get phoneOnly() {return "PhoneOnly";
},
get tabletAndPhone() {return "TabletAndPhone";
},
get desktopOnly() {return "DesktopOnly";
}
}),
gutterSize: Object.freeze({
get xXLarge() {return "gutter-xxl";
},
get medium() {return "gutter-m";
},
get none() {return "gutter-none";
},
get extraLarge() {return "gutter-xl";
},
get small() {return "gutter-s";
},
get large() {return "gutter-l";
},
get base() {return "gutter-base";
},
get extraSmall() {return "gutter-xs";
}
}),
month: Object.freeze({
get june() {return "June";
},
get march() {return "March";
},
get december() {return "December";
},
get february() {return "February";
},
get may() {return "May";
},
get april() {return "April";
},
get november() {return "November";
},
get august() {return "August";
},
get january() {return "January";
},
get july() {return "July";
},
get september() {return "September";
},
get october() {return "October";
}
}),
datePickerLanguage: Object.freeze({
get japanese() {return "ja";
},
get dutchFlemish() {return "nl";
},
get czech() {return "cs";
},
get indonesian() {return "id";
},
get punjabiPanjabi() {return "pa";
},
get latvian() {return "lv";
},
get chinese() {return "zh";
},
get polish() {return "pl";
},
get estonian() {return "et";
},
get catalanValencian() {return "ca";
},
get malay() {return "ms";
},
get slovak() {return "sk";
},
get sinhalaSinhalese() {return "si";
},
get danish() {return "da";
},
get english() {return "en";
},
get hungarian() {return "hu";
},
get norwegianNynorsk() {return "nn";
},
get norwegianBokmal() {return "nb";
},
get arabic() {return "ar";
},
get faroese() {return "fo";
},
get centralKhmer() {return "km";
},
get romanianMoldavianMoldovan() {return "ro";
},
get chineseTraditional() {return "zh_tw";
},
get norwegian() {return "no";
},
get esperanto() {return "eo";
},
get croatian() {return "hr";
},
get albanian() {return "sq";
},
get korean() {return "ko";
},
get thai() {return "th";
},
get mongolian() {return "mn";
},
get spanishCastilian() {return "es";
},
get slovenian() {return "sl";
},
get vietnamese() {return "vi";
},
get bosnian() {return "bs";
},
get french() {return "fr";
},
get turkish() {return "tr";
},
get russian() {return "ru";
},
get serbian() {return "sr";
},
get lithuanian() {return "lt";
},
get portuguese() {return "pt";
},
get hebrew() {return "he";
},
get uzbek() {return "uz";
},
get burmese() {return "my";
},
get italian() {return "it";
},
get georgian() {return "ka";
},
get swedish() {return "sv";
},
get azerbaijani() {return "az";
},
get hindi() {return "hi";
},
get bulgarian() {return "bg";
},
get finnish() {return "fi";
},
get persian() {return "fa";
},
get armenian() {return "hy";
},
get german() {return "de";
},
get belarusian() {return "be";
},
get welsh() {return "cy";
},
get ukrainian() {return "uk";
},
get bengali() {return "bn";
},
get macedonian() {return "mk";
}
}),
dEPRECATED_Color: Object.freeze({
get white() {return "white";
},
get blue() {return "blue";
},
get black() {return "black";
},
get violet() {return "violet";
},
get none() {return "default";
},
get orange() {return "orange";
},
get red() {return "red";
},
get primaryColor() {return "primary-color";
},
get green() {return "green";
},
get grey() {return "grey";
}
}),
orientation: Object.freeze({
get horizontal() {return "horizontal";
},
get vertical() {return "vertical";
}
}),
datePickerTimeFormat: Object.freeze({
get disabled() {return "disabled";
},
get time24hFormat() {return "24";
},
get time12hFormat() {return "12";
}
}),
accordionIconType: Object.freeze({
get custom() {return "Custom";
},
get plusMinus() {return "PlusMinus";
},
get caret() {return "Caret";
}
}),
direction: Object.freeze({
get left() {return "left";
},
get right() {return "right";
}
}),
breakColumns: Object.freeze({
get none() {return "break-none";
},
get first() {return "break-first";
},
get all() {return "break-all";
},
get middle() {return "break-middle";
},
get last() {return "break-last";
}
}),
rangeSliderType: Object.freeze({
get single() {return "single";
},
get interval() {return "interval";
}
}),
shape: Object.freeze({
get sharp() {return "none";
},
get softRounded() {return "soft";
},
get rounded() {return "rounded";
}
}),
stackedCardsPosition: Object.freeze({
get bottom() {return "Bottom";
},
get top() {return "Top";
},
get none() {return "None";
}
}),
carouselDirection: Object.freeze({
get rightToLeft() {return "RightToLeft";
},
get leftToRight() {return "LeftToRight";
}
}),
rangeSliderProvider: Object.freeze({
get noUiSlider() {return "noUiSlider";
}
}),
registeredCallbackEvents: Object.freeze({
get carousel_OnSlideMoved() {return "OnSlideMoved";
},
get onChange() {return "OnChange";
},
get initialized() {return "Initialized";
},
get rangeSlider_OnValueChange() {return "OnValueChange";
},
get onSelected() {return "OnSelected";
},
get onToggle() {return "OnToggle";
}
}),
autoplay: Object.freeze({
get disabled() {return "disabled";
},
get slow() {return "slow";
},
get fast() {return "fast";
},
get normal() {return "normal";
}
}),
position: Object.freeze({
get top() {return "top";
},
get left() {return "left";
},
get bottomRight() {return "bottom-right";
},
get bottomLeft() {return "bottom-left";
},
get right() {return "right";
},
get topLeft() {return "top-left";
},
get topRight() {return "top-right";
},
get center() {return "center";
},
get bottom() {return "bottom";
}
}),
identityProvider: Object.freeze({
get facebook() {return "facebook";
},
get google() {return "google";
},
get apple() {return "apple";
}
}),
trigger: Object.freeze({
get onClick() {return "onclick";
},
get onHover() {return "onhover";
}
}),
space: Object.freeze({
get large() {return "l";
},
get medium() {return "m";
},
get xXLarge() {return "xxl";
},
get extraSmall() {return "xs";
},
get small() {return "s";
},
get base() {return "base";
},
get extraLarge() {return "xl";
},
get none() {return "none";
}
}),
alert: Object.freeze({
get success() {return "alert-success";
},
get error() {return "alert-error";
},
get info() {return "alert-info";
},
get warning() {return "alert-warning";
}
}),
floatingPosition: Object.freeze({
get leftStart() {return "left-start";
},
get topEnd() {return "top-end";
},
get right() {return "right";
},
get top() {return "top";
},
get bottomEnd() {return "bottom-end";
},
get auto() {return "auto";
},
get leftEnd() {return "left-end";
},
get bottomStart() {return "bottom-start";
},
get rightEnd() {return "right-end";
},
get topStart() {return "top-start";
},
get left() {return "left";
},
get rightStart() {return "right-start";
},
get center() {return "center";
},
get bottom() {return "bottom";
}
}),
booleanTypes: Object.freeze({
get true() {return "true";
},
get unset() {return "unset";
},
get false() {return "false";
}
}),
menuAction: Object.freeze({
get menu() {return "Menu";
},
get auto() {return "Auto";
},
get hidden() {return "Hidden";
},
get back() {return "Back";
}
}),
accordionIconPosition: Object.freeze({
get left() {return "left";
},
get right() {return "right";
}
}),
datePickerCalendarType: Object.freeze({
get single() {return "single";
},
get range() {return "range";
}
}),
logType: Object.freeze({
get performance() {return "Performance";
},
get debug() {return "Debug";
},
get error() {return "Error";
},
get general() {return "General";
},
get warning() {return "Warning";
}
}),
progressType: Object.freeze({
get bar() {return "Bar";
},
get circle() {return "Circle";
},
get circleFraction() {return "CircleFraction";
}
}),
messageStatus: Object.freeze({
get hidden() {return "Hidden";
},
get read() {return "Read";
},
get sent() {return "Sent";
},
get received() {return "Received";
}
}),
scrollbarStyle: Object.freeze({
get none() {return "none";
},
get default() {return "default";
},
get compact() {return "compact";
}
}),
dropdownProvider: Object.freeze({
get oSUIComponents() {return "osui-components";
},
get virtualSelect() {return "virtual-select";
}
}),
color: Object.freeze({
get neutral9() {return "neutral-9";
},
get grape() {return "grape";
},
get neutral7() {return "neutral-7";
},
get neutral10() {return "neutral-10";
},
get teal() {return "teal";
},
get primary() {return "primary";
},
get neutral4() {return "neutral-4";
},
get neutral8() {return "neutral-8";
},
get indigo() {return "indigo";
},
get orange() {return "orange";
},
get lime() {return "lime";
},
get cyan() {return "cyan";
},
get secondary() {return "secondary";
},
get neutral6() {return "neutral-6";
},
get yellow() {return "yellow";
},
get neutral2() {return "neutral-2";
},
get neutral1() {return "neutral-1";
},
get neutral3() {return "neutral-3";
},
get transparent() {return "transparent";
},
get violet() {return "violet";
},
get blue() {return "blue";
},
get neutral5() {return "neutral-5";
},
get red() {return "red";
},
get pink() {return "pink";
},
get green() {return "green";
},
get neutral0() {return "neutral-0";
}
}),
columnBreak: Object.freeze({
get breakMiddle() {return "break-middle";
},
get breakAll() {return "break-all";
},
get breakNone() {return "break-none";
},
get breakLast() {return "break-last";
},
get breakFirst() {return "break-first";
}
}),
dropdownType: Object.freeze({
get tags() {return "tags";
},
get serverSide() {return "server-side";
},
get search() {return "search";
}
}),
steps: Object.freeze({
get next() {return "next";
},
get past() {return "past";
},
get active() {return "active";
}
}),
datePickerProvider: Object.freeze({
get flatpickr() {return "flatpickr";
}
}),
carouselNavigation: Object.freeze({
get dots() {return "dots";
},
get none() {return "none";
},
get arrows() {return "arrows";
},
get both() {return "both";
}
}),
videoState: Object.freeze({
get unstarted() {return "Unstarted";
},
get paused() {return "Paused";
},
get ended() {return "Ended";
},
get playing() {return "Playing";
}
}),
datePickerWeekDay: Object.freeze({
get monday() {return 1;
},
get saturday() {return 6;
},
get sunday() {return 0;
},
get friday() {return 5;
},
get tuesday() {return 2;
},
get thursday() {return 4;
},
get wednesday() {return 3;
}
})
}
};
export var staticEntities = OutSystemsUIModel.staticEntities;


