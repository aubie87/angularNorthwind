var app = angular.module('appRouting', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when("/", {
        templateUrl: "home.html",
        controller: "homeCtrl"
    });

    $routeProvider.when("/about", {
        templateUrl: "about.html",
        controller: "aboutCtrl"
    });

    $routeProvider.when("/contact", {
        templateUrl: "contact.html",
        controller: "contactCtrl"
    });
});

// These controllers should normally live in their own files.
app.controller('homeCtrl', function ($scope) {
    $scope.message = "Hello from the home control!";
});

app.controller('aboutCtrl', function ($scope) {
    $scope.message = "Hello from the About controller.";
});

app.controller('contactCtrl', function ($scope) {
    $scope.message = "Hello from the contact controller?";
});

