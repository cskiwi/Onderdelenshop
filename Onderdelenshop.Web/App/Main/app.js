(function() {
    "use strict";

    var app = angular.module("app", [
        "ngAnimate",
        "ngSanitize",
        "ui.router",
        "ui.bootstrap",
        "ui.jq",
        "abp"
    ]);

    //Configuration for Angular UI routing.
    app.config([
        "$stateProvider", "$urlRouterProvider",
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise("/");
            $stateProvider
                .state("home", {
                    url: "/",
                    templateUrl: "/App/Main/views/home/home.cshtml",
                    menu: "Home" //Matches to name of 'Home' menu in OnderdelenshopNavigationProvider
                })
                .state("about", {
                    url: "/about",
                    templateUrl: "/App/Main/views/about/about.cshtml",
                    menu: "About" //Matches to name of 'About' menu in OnderdelenshopNavigationProvider
                })
                .state("listParts", {
                    url: "/list",
                    templateUrl: "/App/Main/views/parts/list.cshtml",
                    menu: "ListParts"
                })
                .state("newtask", {
                    url: "/new",
                    templateUrl: "/App/Main/views/parts/new.cshtml",
                    menu: "ListParts" //Matches to name of 'NewTask' menu in OnderdelenshopNavigationProvider
                });
        }
    ]);
})();