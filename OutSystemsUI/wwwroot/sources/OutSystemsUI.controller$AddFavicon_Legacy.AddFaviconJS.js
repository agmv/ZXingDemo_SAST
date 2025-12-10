export default function ($parameters, $actions, $roles, $public) {
const existingFavicon = document.querySelector("link[rel*='icon']");

if (existingFavicon) {
    existingFavicon.href = $parameters.URL;
}
else {
    const link = document.createElement('link');
    link.type = 'image/x-icon';
    link.rel = 'shortcut icon';
    link.href = $parameters.URL;
    document.getElementsByTagName('head')[0].appendChild(link);
}
};




