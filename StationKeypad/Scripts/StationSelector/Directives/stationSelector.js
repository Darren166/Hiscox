(function () {
"use strict";

	angular.module('stationKeypad')
		.directive('stationSelector', function() {
			return {
				restrict: 'E',
				scope: {
					selectedStations: '=',
					allStations: '=',
					search: '='
				},
				templateUrl: "/Scripts/StationSelector/Templates/keyPad.html",
				link: function(scope) {
					scope.keys = "abcdefghijklmnopqrstuvwxyz()";
					scope.availableKeys = "";
					scope.search = "";

					scope.onKeyPadClicked = function(key) {
						scope.search += key;
					};

					scope.isKeyDisabled = function(key) {
						return scope.availableKeys.indexOf(key) < 0;
					};

					var stationStartsWith = function (station, text) {
						return (station.lastIndexOf(text, 0) === 0);
					}

					var addToSelectedStations = function(station) {
						scope.selectedStations[scope.selectedStations.length] = station;
					}

					var addToAvailableKeys = function(letter) {
						scope.availableKeys += scope.availableKeys.indexOf(letter) < 0 ? letter : '';
					}

					scope.$watch('search', function(search) {
						var loweredCaseSearch = search ? search.toLowerCase() : '';
						scope.availableKeys = "";
						scope.selectedStations = [];
						for (var i = 0; i < scope.allStations.length; i++) {
							var station = scope.allStations[i];
							if (stationStartsWith(station.toLowerCase(),loweredCaseSearch)) {
								addToSelectedStations(station);
								addToAvailableKeys(station[loweredCaseSearch.length].toLowerCase());
							}
						}
					});
				}
			};
		});
}());



