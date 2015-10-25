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
					scope.alphaKeys = "abcdefghijklmnopqrstuvwxyz";
					scope.availableKeys = "";
					scope.search = "";

					scope.onKeyPadClicked = function(key) {
						scope.search += key;
					};

					scope.isKeyDisabled = function(key) {
						return scope.availableKeys.indexOf(key) < 0;
					};

					scope.$watch('search', function(search) {
						var loweredCaseSearch = search ? search.toLowerCase() : '';
						scope.availableKeys = "";
						scope.selectedStations = [];
						var j = 0, i;
						for (i = 0; i < scope.allStations.length; i++) {
							if (scope.allStations[i].toLowerCase().lastIndexOf(loweredCaseSearch, 0) === 0) {
								scope.selectedStations[j] = scope.allStations[i];
								var nextLetter = scope.selectedStations[j][loweredCaseSearch.length].toLowerCase();
								scope.availableKeys += scope.availableKeys.indexOf(nextLetter) < 0 ? nextLetter : '';
								j++;
							}
						}
					});
				}
			};
		});
}());



