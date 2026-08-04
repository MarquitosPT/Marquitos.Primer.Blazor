window.themeProvider = {
    
    initThemeColor: function () {
        const currentThemeColor = sessionStorage.getItem('data-color-mode') ?? 'light';

        document.body.setAttribute('data-color-mode', currentThemeColor);

        document.body.setAttribute('data-light-theme', 'light');
        document.body.setAttribute('data-dark-theme', 'dark');

        document.querySelector('meta[name="theme-color"]')
            ?.setAttribute("content", currentThemeColor === "dark" ? "#000000" : "#f2f5f3");

        sessionStorage.setItem('data-color-mode', currentThemeColor);

        return currentThemeColor;
    },

    getThemeColor: function () {
        return sessionStorage.getItem('data-color-mode') ?? 'light';
    },

    toggleThemeColor: function () {
        const currentThemeColor = sessionStorage.getItem('data-color-mode') ?? 'light';
        const newThemeColor = currentThemeColor === 'light' ? 'dark' : 'light';

        document.body.setAttribute('data-color-mode', newThemeColor);

        document.querySelector('meta[name="theme-color"]')
            ?.setAttribute("content", newThemeColor === "dark" ? "#000000" : "#f2f5f3");

        sessionStorage.setItem('data-color-mode', newThemeColor);

        return newThemeColor;
    },

    setThemeColor: function (themeColor) {
        document.body.setAttribute('data-color-mode', themeColor);

        document.querySelector('meta[name="theme-color"]')
            ?.setAttribute("content", themeColor === "dark" ? "#000000" : "#f2f5f3");

        sessionStorage.setItem('data-color-mode', themeColor);

        return themeColor;
    }
};

(function () {
    themeProvider.initThemeColor();
})();
