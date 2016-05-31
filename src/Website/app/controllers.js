angular.module('fridge')
	.controller('AppCtrl', ['$scope', '$mdSidenav', '$resource', function($scope, $mdSidenav, $resource) {
		$scope.toggleLeft = buildToggler('left');
		$scope.complete = false;
		$scope.model = {
			Data: "",
			Email: ""
		};
		var self = this;
		var service = $resource('/api/fridge/:uid', { uid: '@uid' });
		$scope.submit = function() {
			if ($scope.theForm.$valid) {
				service.save($scope.model,
					function(response) {
						$scope.complete = true;
					},
					function(result) {
						console.log(result);
					});
			} else {
				console.log("Validation failed.");
			}
		};

		function isValid(model) {
			if (!model)
				return false;
			if (!model.Data)
			    return false;
			if (model.Data === "")
			    return false;
			if (model.Data.length < 3)
			    return false;
			if (model.Data.length > 100)
			    model.Data = model.Data.substr(0, 100);
			return true;
		}

		function buildToggler(navID) {
			return function() { $mdSidenav(navID).toggle(); }
		}
	}])
	.controller('LeftCtrl', ['$scope', '$mdSidenav', function($scope, $mdSidenav) {
		$scope.close = function() {
			$mdSidenav('left').close();
		};
	}]);
