(function () {
    'use strict';


    angular.module('App')
    .service('ClienteService', ClienteService);

    function ClienteService($http) {
        var url = "http://localhost:1876/api/Clientes";

        this.GetClientes = function () {
            return $http.get(url);
        }

        this.PostClientes = function (Cliente) {
            return $http.post(url, Cliente);
        }
    }
})();