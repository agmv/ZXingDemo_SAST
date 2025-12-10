export default function ($parameters, $actions, $roles, $public) {
let inputElem = document.getElementById($parameters.InputElemId);

if(inputElem) {
    inputElem.removeEventListener('keydown', $parameters.KeypressCallback);
}
};




