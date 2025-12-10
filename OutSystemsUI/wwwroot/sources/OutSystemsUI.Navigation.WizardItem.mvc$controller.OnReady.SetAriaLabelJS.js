export default function ($parameters, $actions, $roles, $public) {
// Set wizard elements
var wizardWrapperItem = document.getElementById($parameters.WidgetId);
var wizardItemLabel = wizardWrapperItem.querySelector('.wizard-item-label').textContent;

// Set aria-label to wizard item wrapper
wizardWrapperItem.setAttribute('aria-label', wizardItemLabel);
};




