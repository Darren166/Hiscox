///<reference path="~/scripts/jasmine/jasmine.js"/>
///<reference path="~/scripts/angular.js"/>
///<reference path="~/scripts/angular-mocks.js"/>
/// <reference path="../../jquery-2.1.4.js" />

/// <reference path="keyPadControllerSpec.js" />
/// <reference path="../app.js" />

describe('Directive: stationSelector', function () {
	var element, scope;

	beforeEach(module('stationKeypad'));

	beforeEach(inject(function ($templateCache) {
		var directiveTemplate = null;
		var req = new XMLHttpRequest();
		req.onload = function () {
			directiveTemplate = this.responseText;
		};
		// Best to use Karma or Grunt to preload the templatecache - see http://stackoverflow.com/questions/15214760/unit-testing-angularjs-directive-with-templateurl
		// Not using either here though as ran out of time!
		req.open("get", "../Templates/Keypad.html", false);
		req.send();
		$templateCache.put("/Scripts/StationSelector/Templates/keyPad.html", directiveTemplate);
	}));

	beforeEach(function () {
		element = angular.element('<station-selector all-stations="allStations" selected-stations="selectedStations" search="search" />');
		inject(function ($rootScope, $compile) {
			scope = $rootScope.$new();
			scope.allStations = ['DARTFORD', 'DARTMOUTH', 'TOWER HILL', 'DERBY'];
			$compile(element)(scope);
			scope.$digest();
		});
	});

	it('should have all stations selected when there is no search set', function () {
		expect(scope.selectedStations.length).toBe(4);
	});

	it('should have DARTFORD and DARTMOUTH selected when searching for DART in DARTFORD, DARTMOUTH, TOWER HILL, DERBY', function () {
		scope.search = "DART";
		scope.$digest();
		expect(scope.selectedStations.length).toBe(2);
		expect(scope.selectedStations[0]).toBe("DARTFORD");
		expect(scope.selectedStations[1]).toBe("DARTMOUTH");
	});

	it('should show f and m as available keys when searching for DART in DARTFORD, DARTMOUTH, TOWER HILL, DERBY', function () {
		scope.search = "DART";
		scope.$digest();
		var buttons = $("button:enabled", element);
		expect(buttons.length).toBe(2);
		expect(buttons.eq(0).text()).toBe('f');
		expect(buttons.eq(1).text()).toBe('m');
	});
	it('should have LIVERPOOL and LIVERPOOL LIME STREET selected when searching for LIVERPOOL in LIVERPOOL, LIVERPOOL LIME STREET, PADDINGTON', function () {
		scope.allStations = ['LIVERPOOL', 'LIVERPOOL LIME STREET', 'PADDINGTON'];
		scope.search = "LIVERPOOL";
		scope.$digest();
		expect(scope.selectedStations.length).toBe(2);
		expect(scope.selectedStations[0]).toBe("LIVERPOOL");
		expect(scope.selectedStations[1]).toBe("LIVERPOOL LIME STREET");
	});

	it('should show SPACE as available key when searching for LIVERPOOL in LIVERPOOL, LIVERPOOL LIME STREET, PADDINGTON', function () {
		scope.allStations = ['LIVERPOOL', 'LIVERPOOL LIME STREET', 'PADDINGTON'];
		scope.search = "LIVERPOOL";
		scope.$digest();
		var buttons = $("button:enabled", element);
		expect(buttons.length).toBe(1);
		expect(buttons.eq(0).text()).toBe('SPACE');
	});
	it('should have nothing selected when searching for KINGS CROSS in EUSTON, LONDON BRIDGE, VICTORIA', function () {
		scope.allStations = ['EUSTON', 'LONDON BRIDGE', 'VICTORIA'];
		scope.search = "KINGS CROSS";
		scope.$digest();
		expect(scope.selectedStations.length).toBe(0);
	});

	it('should show no available keys when searching for KINGS CROSS in EUSTON, LONDON BRIDGE, VICTORIA', function () {
		scope.allStations = ['EUSTON', 'LONDON BRIDGE', 'VICTORIA'];
		scope.search = "KINGS CROSS";
		scope.$digest();
		var buttons = $("button:enabled", element);
		expect(buttons.length).toBe(0);
	});
});





