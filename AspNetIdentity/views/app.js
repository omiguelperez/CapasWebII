/// <reference path="Clientes/Clientes.html" />
(function () {
    'use strict';


    angular.module('App', ['ui.router'])

    .config(config);

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider

                .state('clientes', {
                    url: '/clientes',
                    templateUrl: 'Clientes/Clientes.html',
                    controller: 'ClienteController'
                })

        $urlRouterProvider.otherwise('/clientes');
    }
})();