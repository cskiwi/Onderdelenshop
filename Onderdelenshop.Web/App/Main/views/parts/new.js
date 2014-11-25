(function() {
    var app = angular.module('app');

    var controllerId = 'os.views.part.new';
    app.controller(controllerId, [
        '$scope', '$location', 'abp.services.tasksystem.part', 'abp.services.tasksystem.user',
        function($scope, $location, partService, userService) {
            var vm = this;

            vm.part = {
                description: '',
                title: '',
                userId: null
            };

            var localize = abp.localization.getSource('Onderdelenshop');

            vm.users = [];

            userService.getAllUsers().success(function (data) {
                vm.users = data.users;
            });

            vm.savePart = function () {
                abp.ui.setBusy(
                    null,
                    partService.createPart(
                        vm.part
                    ).success(function() {
                        abp.notify.info(abp.utils.formatString(localize("PartCreatedMessage"), vm.part.title));
                        $location.path('/list');
                    })
                );
            };
        }
    ]);
})();