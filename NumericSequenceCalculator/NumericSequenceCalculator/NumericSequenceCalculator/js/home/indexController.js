/*
 * Index Controller - for Sequence Generation
 */

( function () {
    'use strict';

    angular
        .module('NumericSequenceCalculator')
        .controller('IndexController', HomeController);

    //angular.module('NumericSequenceCalculator', ['ngDialog'])
    //.controller('indexControl', HomeController);

    //function indexControl($scope, ngDialog) {
    //    ngDialog.()
    //};

    var x = document.getElementById('myDialog');
    function showDialog() {
        x.show();
    };

    HomeController.$inject = ['$scope', '$timeout', 'sequenceService'];

    function HomeController( $scope, $timeout, sequenceService ) {

        $scope.sequences = {
            all: [],
            even: [],
            odd: [],
            conditional: [],
            fibonacci: []
        };
        $scope.number = null;

        $scope.generateSequences = function () {

            //Default
            sequenceService.getSequence( $scope.number ).then( function ( res ) {
                $scope.sequences.all = res.data;
            }, error );

            //Even
            sequenceService.getEvenSequence( $scope.number ).then( function ( res ) {
                $scope.sequences.even = res.data;
            }, error );

            //Odd
            sequenceService.getOddSequence( $scope.number ).then( function ( res ) {
                $scope.sequences.odd = res.data;
            }, error );

            //Conditional
            sequenceService.getConditionalSequence( $scope.number ).then( function ( res ) {
                $scope.sequences.conditional = res.data;
            }, error );

            //Fibonacci
            sequenceService.getFibonacciSequence( $scope.number ).then( function ( res ) {
                $scope.sequences.fibonacci = res.data;
            }, error );

            success();
        };



        //Helpers
        function success( text ) {
            $scope.message = { success: true, text: text || 'Sequences generated' };
            $timeout( function () { $scope.message = null; }, 3000 );
        }

        //Errors from the server
        function error( res ) {

            var errors = [];
            errors.push( res.data.errorMessage );

            for ( var key in res.data.modelState ) {
                for ( var i = 0; i < res.data.modelState[key].length; i++ ) {
                    errors.push( res.data.modelState[key][i] );
                }
            }
            var text = "Oops " + errors.join( ', ' );

            $scope.message = {
                success: false,
                text: text
            }
            $timeout( function () { $scope.message = null; }, 3000 );
        }
    }
} )();