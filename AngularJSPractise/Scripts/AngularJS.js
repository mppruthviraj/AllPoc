/// <reference path="angular.min.js" />
var myapp = angular.module("mymodule", []);

//First controller
var myController = function($scope){
    $scope.message = "First AJS Example";
};

myapp.controller("myController", myController);


//Image test controller
var imageController = function ($scope) {
    var BuildStatusScreenShot = {
        Name: "BuildStatus",
        Date:"09/11/2015",
        ScreenShot:"/Images/BuildOk.PNG"
    };
    $scope.BuildStatusScreenShot = BuildStatusScreenShot;
};

myapp.controller("imageController", imageController);


//ng-model controller   
var modelExample = function ($scope) {
    var employee = {
        FirstName: "Raj",
        LastName: "K",
        Gender:"Male"
    };
    $scope.Employee = employee;
};

myapp.controller("modelExample", modelExample);


//Simple ng-repeat
var repeatExample = function ($scope) {
    var employees = [{ FirstName: "Raj", LastName: "K", Gender: "M", JobTitle: "Development" },
        { FirstName: "Preritha", LastName: "J", Gender: "F", JobTitle: "Security" },
        { FirstName: "Mohan", LastName: "Y", Gender: "M", JobTitle: "Admin" },
        { FirstName: "Megha", LastName: "R", Gender: "F", JobTitle: "Support" }];

    $scope.Employees = employees;
};

myapp.controller("repeatExample", repeatExample);



//Complex ng-repeat
var complexRepeatExample = function ($scope) {
    var countries = [
        {
            Name: "US",
            Cities: [
            { CityName: "New York" }, { CityName: "W D C" }, {CityName:"Texas"}
            ]
        },
        {
            Name: "UK",
            Cities: [
            { CityName: "Netherland" }, { CityName: "Ireland" }, { CityName: "GreenLand" }
            ]
        },
        {
            Name: "India",
            Cities: [
            { CityName: "Delhi" }, { CityName: "Kolkatta" }, { CityName: "Bangalore" }
            ]
        }

    ];

    $scope.Countries = countries;
};

myapp.controller("complexRepeatExample", complexRepeatExample);


//ng-click example
var clickExample = function ($scope) {
    var technology = [{ Name: "C#", Likes: 0, Dislikes: 0 },
        { Name: "ASP.NET", Likes: 0, Dislikes: 0 },
        { Name: "AngularJS", Likes: 0, Dislikes: 0 },
        { Name: "SQL", Likes: 0, Dislikes: 0 }];

    $scope.Technology = technology;

    $scope.IncrementLikes = function(technology){
        technology.Likes++;
    };

    $scope.IncrementDisLikes = function (technology) {
        technology.Dislikes++;
    };

};

myapp.controller("clickExample", clickExample);


//Filter Example
var filterExample = function ($scope) {
    var employeeData = [{ Name: "Raj", DateOfJoining: new Date("12/02/2013"), Gender: "Male", Salry: 59000.788 },
        { Name: "Mohan", DateOfJoining: new Date("05/12/2011"), Gender: "Male", Salry: 65000.0000},
        { Name: "Savitha", DateOfJoining: new Date("15/01/2013"), Gender: "FeMale", Salry: 59000.788 },
        { Name: "Mandara", DateOfJoining: new Date("31/12/2014"), Gender: "FeMale", Salry: 70000 },
        { Name: "Hemanth", DateOfJoining: new Date("12/06/2015"), Gender: "Male", Salry: 1500 }];

    $scope.EmployeeData = employeeData;

    $scope.rowLimit = 3;
};

myapp.controller("filterExample", filterExample);




//Sorting Example
var sortingExample = function ($scope) {
    var employeeData = [{ Name: "Raj", DateOfJoining: new Date("12/02/2013"), Gender: "Male", Salry: 59000.788 },
        { Name: "Mohan", DateOfJoining: new Date("05/12/2011"), Gender: "Male", Salry: 65000.0000 },
        { Name: "Savitha", DateOfJoining: new Date("15/01/2013"), Gender: "FeMale", Salry: 59000.788 },
        { Name: "Mandara", DateOfJoining: new Date("31/12/2014"), Gender: "FeMale", Salry: 70000 },
        { Name: "Hemanth", DateOfJoining: new Date("12/06/2015"), Gender: "Male", Salry: 1500 }];

    $scope.EmployeeData = employeeData;

    $scope.rowLimit = 3;

    $scope.orderByParam = "Name";
};

myapp.controller("sortingExample", sortingExample);

//Sorting example click header
var sortingExampleHeaderClick = function ($scope) {
    var employeeData = [{ Name: "Raj", DateOfJoining: new Date("12/02/2013"), Gender: "Male", Salry: 59000.788 },
        { Name: "Mohan", DateOfJoining: new Date("05/12/2011"), Gender: "Male", Salry: 65000.0000 },
        { Name: "Savitha", DateOfJoining: new Date("15/01/2013"), Gender: "FeMale", Salry: 59000.788 },
        { Name: "Mandara", DateOfJoining: new Date("31/12/2014"), Gender: "FeMale", Salry: 70000 },
        { Name: "Hemanth", DateOfJoining: new Date("12/06/2015"), Gender: "Male", Salry: 1500 }];

    $scope.EmployeeData = employeeData;

    $scope.SortColumnName = "Name";

    $scope.ReverseSort = false;

    $scope.SortColumn = function (columnName) {
        $scope.ReverseSort = ($scope.SortColumnName == columnName) ? !$scope.ReverseSort : false;
        $scope.SortColumnName = columnName;
    };

    $scope.getSortColumn = function (columnName) {
        if ($scope.SortColumnName == columnName)
        {
            return $scope.ReverseSort ? 'arrow-down' : 'arrow-up';
        }
        return '';
    };
};

myapp.controller("sortingExampleHeaderClick", sortingExampleHeaderClick);


//Serach filter to the whole class
