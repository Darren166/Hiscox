(function () {
	"use strict";

	var KeypadController = function ($http) {
		var keyPadModel = this;
		var onGotStations = function (response) {
			keyPadModel.allStations = keyPadModel.selectedStations = response.data;
		}

		$http.get("/api/stations/").then(onGotStations);
	};

	angular.module('stationKeypad')
		.controller('KeypadController', KeypadController);

}());