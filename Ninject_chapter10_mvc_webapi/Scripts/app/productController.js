app.controller('ProductController', ['$scope', 'ProductService', function ($scope, ProductService) {

    ProductService.getProducts()
        .success(function (products) {
            $scope.products = products;

        })
        .error(function (error, status, headers, config) {
            $scope.status = 'Unable to load customer data: ' + error.message;

        });

}]);