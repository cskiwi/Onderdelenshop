(function () {
    var app = angular.module('app');

    var controllerId = 'os.views.part.list';
    app.controller(controllerId, [
        '$scope', '$location', 'abp.services.tasksystem.part',
        function ($scope, $location, partService) {
            var vm = this;
            vm.localize = abp.localization.getSource("Onderdelenshop");

            vm.parts = [];

            vm.getPartCountText = function () {
                return abp.utils.formatString(vm.localize("XParts"), vm.parts.length);
            };

            $scope.selectedPartState = 0;

            $scope.$watch("selectedPartState", function(value) {
                vm.refreshParts();
            });

            vm.refreshParts = function () {
                abp.ui.setBusy( //Set whole page busy until getParts complete
                    null,
                    partService.getParts({ //Call application service method directly from javascript
                        state: $scope.selectedPartState > 0 ? $scope.selectedPartState : null
                    }).success(function (data) {
                        console.log(data.parts);
                        vm.parts = data.parts;
                    })
                );
            };

            /*vm.changePartState = function (part) {
                var newState;
                if (part.state === 1) {
                    newState = 2; //Completed
                } else {
                    newState = 1; //Active
                }


                partService.updatePart({
                    partId: part.id,
                    state: newState
                }).success(function() {
                    part.state = newState;
                    abp.notify.info(vm.localize("PartUpdatedMessage"));
                });
            };//*/

            
        }
    ]);
})();
