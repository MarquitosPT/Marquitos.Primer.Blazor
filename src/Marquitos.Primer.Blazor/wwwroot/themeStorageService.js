export const theme = {
    getThemeColor: function () {
        return sessionStorage.getItem('data-color-mode') ?? 'light';
    },

    getCurrentThemeColor: function () {
        return sessionStorage.getItem('data-color-mode') ?? 'light';
    },

    setCurrentThemeColor: function () {
        const currentThemeColor = sessionStorage.getItem('data-color-mode') ?? 'light';

        document.body.setAttribute('data-color-mode', currentThemeColor);

        document.body.setAttribute('data-light-theme', 'light');
        document.body.setAttribute('data-dark-theme', 'dark');

        sessionStorage.setItem('data-color-mode', currentThemeColor);
    },

    setThemeColor: function (themeColor) {
        document.body.setAttribute('data-color-mode', themeColor);

        document.body.setAttribute('data-light-theme', 'light');
        document.body.setAttribute('data-dark-theme', 'dark');

        sessionStorage.setItem('data-color-mode', themeColor);
    }
};
