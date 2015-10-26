///<reference path="~/scripts/jasmine/jasmine.js"/>
///<reference path="~/scripts/angular.js"/>
///<reference path="~/scripts/angular-mocks.js"/>

/// <reference path="keyPadControllerSpec.js" />
/// <reference path="../app.js" />

describe('Directive: stationList', function () {
	var element;
	beforeEach(function () {
		module('stationKeypad');
		element = angular.element('<station-list selected-stations="selectedStations" />');
		inject(function ($rootScope, $compile) {
			var scope = $rootScope.$new();
			scope.selectedStations = ['one', 'two'];
			$compile(element)(scope);
			scope.$digest();
		});
	});

	it('should display the right number of stations', function () {
		expect(element.find('li').length).toBe(2);
	});
});