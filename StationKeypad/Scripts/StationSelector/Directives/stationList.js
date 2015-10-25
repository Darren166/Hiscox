(function () {
	"use strict";

	angular.module('stationKeypad')
		.directive('stationList', function () {
			return {
				restrict: 'E',
				scope: {
					selectedStations: '='
				},
				template: "<ul><li ng-repeat='stationName in selectedStations' >{{stationName}}</li></ul>"
			};
		});
}());