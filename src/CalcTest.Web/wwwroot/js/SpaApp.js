(function () {
    'use strict';

    // App Angular
    var SpaApp = angular.module('SpaApp', []);

    // Configurações globais

    //SpaApp.value('config', {
    //    baseUrl: location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : ''),
    //    timeout: -1
    //});

    //SpaApp.value('config', {
    //    baseUrl: 'https://localhost:63271',
    //    timeout: -1
    //});

    //SpaApp.value('config', {
    //    baseUrl: 'http://robertosistemas-001-site1.itempurl.com',
    //    timeout: -1
    //});

    SpaApp.value('config', {
        baseUrl: 'https://localhost:44317',
        timeout: -1
    });

    // Service
    SpaApp.factory('SpaService', SpaService);

    SpaService.$inject = ['$http', 'config'];
    ///CalculaJuros?valorinicial=100&meses=5
    function SpaService($http, config) {
        var getJuros = function (valorInicial, meses) {
            return $http.get(config.baseUrl + '/calculajuros?valorinicial=' + valorInicial + '&meses=' + meses, null, { timeout: config.timeout });
        };
        return {
            getJuros: getJuros
        };
    }

    // Controller
    SpaApp.controller('SpaController', SpaController);

    SpaController.$inject = ['$scope', 'SpaService'];

    function SpaController($scope, SpaService) {

        var vm = this;

        vm.loading = false;
        vm.consultou = false;
        vm.ValorInicial = "";
        vm.Meses = "";
        vm.Resultado = "";

        vm.getJuros = function (valorInicial, meses) {
            vm.loading = true;
            vm.consultou = false;
            SpaService.getJuros(valorInicial, meses)
                .then(function (resultado) {
                    delete vm.Resultado;
                    $scope.SpaForm.$setPristine();
                    vm.Resultado = resultado.data;
                    vm.consultou = true;
                }, function (error) {
                    console.log(error);
                }).finally(function () {
                    vm.loading = false;
                });
        };

        vm.mostrarDados = function () {
            return vm.consultou && vm.Resultado && vm.Resultado.length > 0;
        };

        vm.mostrarMsg = function () {
            return vm.consultou && (!vm.Resultado || vm.Resultado.length <= 0);
        };

    }

})();