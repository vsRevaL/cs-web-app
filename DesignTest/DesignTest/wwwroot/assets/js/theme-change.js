document.addEventListener("DOMContentLoaded", function () {
    const toggleSwitch2 = document.querySelector('.theme-switch input[type="checkbox"]');
    const currentTheme = 'light';

    if (currentTheme) {
        document.documentElement.setAttribute('data-theme', currentTheme);

        if (currentTheme === 'dark') {
            toggleSwitch2.checked = true;
        }
    }

    function switchTheme(e) {
        if (e.target.checked) {
            document.documentElement.setAttribute('data-theme', 'dark');
        }
        else {
            document.documentElement.setAttribute('data-theme', 'light');
        }
    }


    toggleSwitch2.addEventListener('change', switchTheme, false);
});



