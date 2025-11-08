window.scrollHelpers = window.scrollHelpers || {};

// Smoothly scroll to a DOM element by ElementReference from Blazor
window.scrollHelpers.scrollIntoViewElement = function (el) {
    if (!el) return;
    try {
        el.scrollIntoView({ behavior: 'smooth', block: 'center' });
    } catch (e) {
        // Fallback without options for older browsers
        try { el.scrollIntoView(); } catch { /* ignore */ }
    }
};

// Smoothly scroll to an element by its id or hash fragment
window.scrollHelpers.scrollToFragment = function (fragment) {
    if (!fragment) return;
    const id = fragment.replace('#', '');
    const el = document.getElementById(id);
    if (el) {
        try {
            el.scrollIntoView({ behavior: 'smooth', block: 'start' });
        } catch {
            try { el.scrollIntoView(); } catch { /* ignore */ }
        }
        // Optional: update hash without reload
        history.replaceState(null, '', '#' + id);
    }
};
