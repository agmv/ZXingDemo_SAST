export default function ($parameters, $actions, $roles, $public) {
var widget = document.getElementById($parameters.widgetId);

if(widget) {
    try {
        widget.clearDate();
    } catch (e) {
        console.warn('The action ClearDatePickerInput only works when bounding a DatePicker to an input widget');
    }
}
};




