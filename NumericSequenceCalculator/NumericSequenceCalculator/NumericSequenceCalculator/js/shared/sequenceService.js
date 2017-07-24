/*
 * Sequence Generator Api Service
 */

( function () {
    'use strict';

    angular
        .module('NumericSequenceCalculator')
        .factory( 'sequenceService', ['$http', sequenceService] );

    function sequenceService( $http ) {

        var service = {};

        service.getSequence = function ( number ) {
            return $http.get( '/api/sequences/' + number + '/all' );
        }

        service.getEvenSequence = function ( number ) {
            return $http.get( '/api/sequences/' + number + '/even' );
        }

        service.getOddSequence = function ( number ) {
            return $http.get( '/api/sequences/' + number + '/odd' );
        }

        service.getConditionalSequence = function ( number ) {
            return $http.get( '/api/sequences/' + number + '/conditional' );
        }

        service.getFibonacciSequence = function ( number ) {
            return $http.get( '/api/sequences/' + number + '/fibonacci' );
        }

        return service;
    }

} )();
