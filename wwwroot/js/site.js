const header = document.querySelector('[data-header]');
const toggle = document.querySelector('[data-nav-toggle]');
const navigation = document.querySelector('[data-nav]');
const year = document.querySelector('[data-year]');
const languageOptions = document.querySelectorAll('[data-language-option]');

if (year) year.textContent = new Date().getFullYear();

const currentLanguage = document.documentElement.lang === 'en' ? 'en' : 'es';
const requestedLanguage = new URL(window.location.href).searchParams.get('lang');

try {
    const savedLanguage = window.localStorage.getItem('portfolio-language');

    if (!requestedLanguage && savedLanguage && savedLanguage !== currentLanguage) {
        const savedLanguageUrl = new URL(window.location.href);
        savedLanguageUrl.searchParams.set('lang', savedLanguage);
        window.location.replace(savedLanguageUrl);
    }
} catch {
    // The language switch still works when browser storage is unavailable.
}

languageOptions.forEach((option) => {
    option.addEventListener('click', () => {
        const language = option.dataset.languageOption;
        if (language !== 'es' && language !== 'en') return;

        try {
            window.localStorage.setItem('portfolio-language', language);
        } catch {
            // Storage can be blocked without affecting navigation.
        }

        if (language === currentLanguage) return;

        const languageUrl = new URL(window.location.href);
        languageUrl.searchParams.set('lang', language);
        window.location.assign(languageUrl);
    });
});

const updateHeader = () => {
    header.classList.toggle('is-scrolled', window.scrollY > 24);
};

updateHeader();
window.addEventListener('scroll', updateHeader, { passive: true });

toggle?.addEventListener('click', () => {
    const isOpen = navigation.classList.toggle('is-open');
    toggle.setAttribute('aria-expanded', String(isOpen));
});

navigation?.querySelectorAll('a').forEach((link) => {
    link.addEventListener('click', () => {
        navigation.classList.remove('is-open');
        toggle?.setAttribute('aria-expanded', 'false');
    });
});

const revealObserver = new IntersectionObserver((entries, observer) => {
    entries.forEach((entry) => {
        if (!entry.isIntersecting) return;
        entry.target.classList.add('is-visible');
        observer.unobserve(entry.target);
    });
}, { threshold: 0.12 });

document.querySelectorAll('.reveal').forEach((element) => revealObserver.observe(element));
