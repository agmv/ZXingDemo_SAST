export default function ($parameters, $actions, $roles, $public) {
$parameters.ListElNodesObj[$parameters.CurrentPosition - 1].classList.remove('stackedcards-active');
$parameters.ListElNodesObj[$parameters.CurrentPosition - 1].classList.add('stackedcards-hidden');
$parameters.ListElNodesObj[$parameters.CurrentPosition - 1].setAttribute('aria-hidden', true);
$parameters.ListElNodesObj[$parameters.CurrentPosition].classList.add('stackedcards-active');
$parameters.ListElNodesObj[$parameters.CurrentPosition].setAttribute('aria-hidden', false);
};




