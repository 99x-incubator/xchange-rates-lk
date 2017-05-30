var myApp = angular.module('myApp', []);

myApp.controller('mainController', function($scope , $http){
    $http.get('/home/GetRates')
        .success(function (result) {
            $scope.rates = result;
        })
        .error(function (data) {
            console.log(data);
        });

    $scope.newProduct = "";
    $scope.addProduct = function () {
        $http.post("/home/AddProduct/", { newProduct: $scope.newProduct })
            .success(function (result) {
                $scope.products = result;
                $scope.newProduct = "";
            })
          .error(function (data) {
              console.log(data);
          });
    }

    $scope.deleteProduct = function (product) {
        $http.post("/home/DeleteProduct/", { delProduct: product })
           .success(function (result) {
               $scope.products = result;
               $scope.newProduct = "";
           })
         .error(function (data) {
             console.log(data);
         });
    }


});