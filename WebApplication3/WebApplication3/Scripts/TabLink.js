    // Gets all TAB links and content items.
    const tabLinks = document.querySelectorAll('.tab-link');
    const tabItems = document.querySelectorAll('.tab-content');

    // Expand everything by default.
    function showAllTabs() {
        tabItems.forEach(function (tab) {
            tab.style.display = 'block';
        });
    }

     // Definition function.
    function setupTabClickHandlers() {
        tabLinks.forEach(function (link) {
            link.addEventListener('click', function (event) {
                
                event.preventDefault();

                var targetId = this.getAttribute('href').substring(1);

                tabItems.forEach(function (tab) {
                    tab.style.display = 'none';
                });

                var selectedTab = document.getElementById(targetId);
                if (selectedTab) {
                    selectedTab.style.display = 'block';
                }
            });
        });
    }
    window.onload = function () {
        showAllTabs();
    setupTabClickHandlers();
    };


