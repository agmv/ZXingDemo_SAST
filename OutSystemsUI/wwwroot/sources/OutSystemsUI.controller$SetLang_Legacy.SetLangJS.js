export default function ($parameters, $actions, $roles, $public) {
var hasLangAttribute = document.documentElement.lang !== "";

if(!hasLangAttribute && $parameters.Lang !== "") {
    document.documentElement.lang = $parameters.Lang;
}
};




