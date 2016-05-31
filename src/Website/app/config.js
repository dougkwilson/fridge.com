angular.module('fridge')
	.config(['$mdIconProvider', '$mdThemingProvider', function($mdIconProvider, $mdThemingProvider) {
	    $mdIconProvider
			.defaultIconSet('/Content/mdi.svg');

	    $mdThemingProvider.theme('default')
			.primaryPalette('blue-grey')
			.accentPalette('blue');
	}]);
