app.factory('ProductService', ['$http', function ($http) {

    var urlBase = 'http://localhost:54000/api';
    var productService = {};
    productService.getProducts = function () {
        return $http.get(urlBase + '/Products');
    };

    return productService;
}]);