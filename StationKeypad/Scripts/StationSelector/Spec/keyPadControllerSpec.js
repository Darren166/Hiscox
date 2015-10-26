///<reference path="~/scripts/jasmine/jasmine.js"/>
///<reference path="~/scripts/angular.js"/>
///<reference path="~/scripts/angular-mocks.js"/>

/// <reference path="keyPadControllerSpec.js" />
/// <reference path="../app.js" />

describe('keyPadController', function () {
	var $httpBackend, createController, stationsApiCall;

	// Set up the module
	beforeEach(module('stationKeypad'));

	beforeEach(inject(function ($injector) {
		// Set up the mock http service responses
		$httpBackend = $injector.get('$httpBackend');
		// backend definition common for all tests
		stationsApiCall = $httpBackend.when('GET', '/api/stations/')
			.respond(['one', 'two', 'three']);

		// The $controller service is used to create instances of controllers
		var $controller = $injector.get('$controller');

		createController = function () {
			return $controller('KeypadController', {});
		};
	}));

	it('should fetch all stations from the API', function () {
		var controller = createController();
		$httpBackend.flush();
		expect(controller.allStations.length).toBe(3);
	});
});
