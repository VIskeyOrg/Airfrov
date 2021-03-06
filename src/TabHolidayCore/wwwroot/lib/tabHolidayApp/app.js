﻿var myapp = angular.module('myapp', ['ngRoute', 'ui.bootstrap', 'angular.filter','ngMessages']);

myapp.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider.
            when('/requestsByCountry', {
                templateUrl: '/lib/tabHolidayApp/requests/byCountry.html'
            }).
            when('/search', {
                templateUrl: '/lib/tabHolidayApp/requests/searchRequests.html'
            }).
             when('/newtrip', {
                 templateUrl: '/lib/tabHolidayApp/trips/trips.html'
             }).
            when('/dmc', {
                templateUrl: '/lib/tabHolidayApp/dmc/dmc.html'
            }).
            when('/region', {
                templateUrl: '/lib/myapp/Region/Index.html'
            }).
            when('/agegroup', {
                templateUrl: '/lib/myapp/AgeGroup/Index.html'
            }).
            when('/profile', {
                templateUrl: '/lib/myapp/Profile/Index.html'
            }).
            when('/product', {
                templateUrl: '/lib/myapp/Product/ProductAdd.html'
            }).
            when('/productlist', {
                templateUrl: '/lib/myapp/Product/ProductList.html'
            }).
            when('/productlist1', {
                templateUrl: '/lib/myapp/Product/ProductList1.html'
            }).
             when('/imageupload', {
                 templateUrl: '/lib/myapp/Product/ImageUpload.html'
             }).
            when('/plan', {
                templateUrl: '/lib/myapp/Plan/Index.html'
            }).
            when('/selectplan', {
                templateUrl: '/lib/myapp/Plan/SelectPlan.html'
            }).
            when('/myplanrequests', {
                templateUrl: '/lib/myapp/PlanRequest/MyPlanRequests.html'
            }).
             when('/myplanrequests2', {
                 templateUrl: '/lib/myapp/PlanRequest/MyPlanRequest2.html'
             }).
            when('/allplanrequests', {
                templateUrl: '/lib/myapp/PlanRequest/AllPlanRequests.html'
            }).
            otherwise({
                templateUrl: '/lib/tabHolidayApp/Index.html'
            })
    }
]);