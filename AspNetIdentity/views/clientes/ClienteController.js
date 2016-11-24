(function () {
    angular.module('App')

    .controller('ClienteController', ClienteController);

    function ClienteController($scope, ClienteService) {
        $scope.clientes = [];
        $scope.cliente = {};
        $scope.mensaje = "";
        $scope.close = close;
        $scope.limpiar = limpiar;


        $scope.PostClientes = PostClientes;


        __init();

        function __init() {
            GetClientes();
        }

        function GetClientes() {
            var promiseGet = ClienteService.GetClientes();
            promiseGet.then(
                function (data) {
                    if (data.data.length != 0) {
                        $scope.clientes = data.data;
                    }
                },
                function (err) {
                    console.log(JSON.stringify(err));
                }
            )
        }

        function PostClientes() {
            var promisePost = ClienteService.PostClientes($scope.cliente);
            promisePost.then(
                function (data) {
                    var respuesta = data.data;
                    if (!respuesta.error) {
                        $scope.mensaje = respuesta.mensaje;
                        $scope.cliente = {};
                        GetClientes();
                    }
                },
                function (err) {
                    console.log(JSON.stringify(err));
                }
            )
        }

        function close() {
            $scope.mensaje = "";
        }
        
        function limpiar() {
            $scope.cliente = {};
        }
        
    }
})();