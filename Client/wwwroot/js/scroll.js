window.scrollHelpers = window.scrollHelpers || {};
window.scrollHelpers.scrollToFragment = function (fragment) {
    if (!fragment) return;
    const id = fragment.replace('#', '');
    const el = document.getElementById(id);
    if (el) {
        el.scrollIntoView({ behavior: 'smooth', block: 'start' });
        // Opcional: actualizar hash sin recargar
        history.replaceState(null, '', '#' + id);
    }
};
