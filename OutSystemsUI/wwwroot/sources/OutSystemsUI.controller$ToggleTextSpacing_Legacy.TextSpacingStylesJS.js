export default function ($actions, $roles, $public) {
var spacingStyles = document.querySelector('.acessibility-style-tag');

if (!spacingStyles) {
    spacingStyles = document.createElement('style');
    spacingStyles.classList.add('acessibility-style-tag');
    spacingStyles.textContent = " * { line-height: 1.5 !important; letter-spacing: 0.12em !important; word-spacing: 0.16em !important; } p { margin-bottom: 2em !important; } ";
    document.head.appendChild(spacingStyles);
} else if(spacingStyles) {
    spacingStyles.remove();
}
};




