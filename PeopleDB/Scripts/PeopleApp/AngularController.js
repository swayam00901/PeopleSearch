//Declaring angular module
var AnguarModule = angular.module('App', []);


//Declaring angular controller
// ApiCall---This is the service name which is in ApiCallService.js file
AnguarModule.controller('AppController', function ($scope, $http, $location,ApiCall) {
    //Intital message value
    $scope.message = " Getting list of your favorite people";

    //Load dropdown in page load event  with get api call using service
    var result = ApiCall.GetApiCall("Student", "GetPeopleList").success(function (data) {
        //var data = $.parseJSON(JSON.parse(data));
        $scope.PeopleList = data;
    });

    var names = '';
    $scope.handleChange = function () {
        names = $scope.ppl.Names;
    }

    $scope.btnPostCall = function () {
       
        var obj = {
            'Names': names
        };
        
        //Call Post method from web api in angular controller using angular service. I am passing string value to the web api through service.
        var result = ApiCall.PostApiCall("Student", "SearchPeople", obj).success(function (data) {
            $location.path("/Index");
            $scope.message = "Search Success";
        });
    };
});