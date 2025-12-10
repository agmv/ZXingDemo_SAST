export default function ($parameters, $actions, $roles, $public) {
var element = document.getElementById($parameters.WidgetId);

if(element) {
    var countTabs = element.querySelectorAll(".tabs-header-tab").length-1;
    var newTargetTab = ($parameters.TabNumber < 0) ? 0 : ($parameters.TabNumber > countTabs) ? countTabs : $parameters.TabNumber;
    element.changeTab(newTargetTab);
}
};




