var app = angular.module('myApp', ['ngTouch', 'ui.grid', 'ui.grid.selection', 'ui.grid.pagination']);

app.service('Data', function () {

    // private variable
    var _dataObj = {};
    _dataObj.firstName = "";
    _dataObj.lastName = "";

    // expose it publicly for any controller to use
    this.data = _dataObj;
});

app.filter('orderObjectBy', function () {
    return function (input, attribute) {
        if (!angular.isObject(input)) return input;

        var array = [];
        for (var objectKey in input) {
            array.push(input[objectKey]);
        }

        array.sort(function (a, b) {
            a = parseInt(a[attribute]);
            b = parseInt(b[attribute]);
            return a - b;
        });
        return array;
    };
});


app.controller('CtrlSearch', ['$scope', '$http', '$window', '$interval', 'uiGridConstants', function ($scope, $http, $window, $interval, uiGridConstants) {

    //var apiPath = "/websvc/api/";
    var env = '@System.Configuration.ConfigurationManager.AppSettings["env"]';

    //var apiPath = "http://localhost:34667/api/";
    //var apiPath = "http://evolutionrevolutionoflove.com/api/";
    var apiPath = "http://api.evolutionrevolutionoflove.com/api/";
    $scope.productList = [];
    $scope.categoryList = [];
    $scope.partofalbumList = [];
    $scope.themeList = [];

    $scope.selectedUser = 2;



    $scope.title = "surfsup";

    var paginationOptions = {
        pageNumber: 1,
        pageSize: 25,
        sort: null
    };

    $.ajax({
        url: apiPath + 'category/',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data, textStatus, xhr) {

            $scope.categoryList = data.data["0"].categoryLists;
            $scope.$apply();

        },
        error: function (xhr, textStatus, errorThrown) {

        }
    }).done(function () {


    });


    $.ajax({
        url: apiPath + 'theme/',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data, textStatus, xhr) {

            $scope.themeList = data.data["0"].categoryLists;
            $scope.$apply();

        },
        error: function (xhr, textStatus, errorThrown) {

        }
    }).done(function () {


    });



    $scope.categoryChange = function () {

        var result = $scope.category;
        getGetPartOfAlbum($scope.category);
        return $scope;
    };

    $scope.partofalbumChange = function () {

        var result = $scope.partofalbum;
        return $scope;
    };

    $scope.themeChange = function () {

        var result = $scope.theme;
        return $scope;
    };









    var getGetPartOfAlbum = function (category) {



        var url = apiPath + 'partofalbum/' + category;
        //alert(url);

        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data, textStatus, xhr) {
                //$scope.categoryList = data.data["0"].categoryLists;
                $scope.partofalbumList = data.data["0"].categoryLists;
                //alert("found");
                $scope.$apply();


            },
            error: function (xhr, textStatus, errorThrown) {

            }
        }).done(function () {

        });

    };




    $scope.gridOptions = {
        useExternalPagination: true,
        paginationPageSizes: [5, 25, 50, 75],
        paginationPageSize: 25,
        enableRowSelection: true,
        enableRowHeaderSelection: false
    };

    $scope.gridOptions.multiSelect = false;
    $scope.gridOptions.modifierKeysToMultiSelect = false;
    $scope.gridOptions.noUnselect = true;
    $scope.gridOptions.onRegisterApi = function (gridApi) {
        $scope.gridApi = gridApi;
        gridApi.selection.on.rowSelectionChanged($scope, function (row) {
            var msg = 'row selected ' + row.isSelected;
            $scope.ID = row.entity.ID;
            $scope.HttpPathName = row.entity.HttpPathName;
            $scope.FullName = row.entity.FullName;
            $scope.ShortName = row.entity.ShortName;
            $scope.PathName = row.entity.PathName;
            $scope.playAudio = $scope.HttpPathName + $scope.FullName;

            $scope.Albumjpg = row.entity.Albumjpg;
            $scope.Albumpdf = row.entity.Albumpdf;

            $scope.Theme = row.entity.Theme;
            $scope.selectedUser = row.entity.Theme;
            //$scope.$apply();
            $(".edit").show();


            // add logic for editing

            //var myElJPG = angular.element(document.querySelector('#divJPG'));
            //var jpg = '<img src="' + $scope.Albumjpg + '"  alt="album" style="width:300px;height:300px;">';
            //myElJPG.html(jpg);


            //var myElPDF = angular.element(document.querySelector('#divPDF'));
            //var PDF = '<br>  <a href="' + $scope.Albumpdf + '" class=" btn btn-primary btn-lg" target="_blank">Click to Open PDF </a>';
            //myElPDF.html(PDF);

            //var myEl = angular.element(document.querySelector('#divID'));
            //myEl.html($scope.ShortName + '</div > <div><audio controls><source src="' + $scope.PathName + '" type="audio/wav">Your browser does not support the audio element.</audio></div></div>');

        });

        gridApi.core.registerColumnsProcessor(hideIdColumn);

        function hideIdColumn(columns) {
            columns.forEach(function (column) {
                if (column.field !== 'ShortName' && column.field !== 'ThemeName') {
                    column.visible = false;
                }
            });
            return columns;
        }

        gridApi.pagination.on.paginationChanged($scope, function (newPage, pageSize) {
            paginationOptions.pageNumber = newPage;
            paginationOptions.pageSize = pageSize;
            getPage();
        });


    };



    var getPage = function () {


        var category = $scope.category;
        var partofalbum = $scope.partofalbum;
        var theme = $scope.theme;

        if ($scope.category === null || typeof category === 'undefined'  ) {
            category = 0;
        }

        if ($scope.partofalbum === null || typeof partofalbum === 'undefined'  ) {
            partofalbum = 0;
        }

        if ($scope.theme === null || typeof theme === 'undefined' ) {
            theme = 0;
        }


        var pageNumber = paginationOptions.pageNumber;
        var pageSize = paginationOptions.pageSize;


        var url = apiPath + 'evolution/' + $scope.title + "/" + theme + "/" + category + "/" + partofalbum + "/" + pageNumber + "/" + pageSize;

        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data, textStatus, xhr) {
                var firstRow = (paginationOptions.pageNumber - 1) * paginationOptions.pageSize;

                $scope.gridOptions.totalItems = $scope.totalRecords;
                $scope.gridOptions.data = data.data["0"].productCertificates;
                $scope.$apply();
                // $interval whilst we wait for the grid to digest the data we just gave it
                $interval(function () {
                    $scope.gridApi.selection.selectRow($scope.gridOptions.data[0]);
                }, 0, 1);

                setTimeout(function () {
                    $scope.$apply(function () {
                        $scope.gridApi.core.notifyDataChange(uiGridConstants.dataChange.ALL);
                        $scope.gridApi.core.handleWindowResize(uiGridConstants.dataChange.ALL);
                    });

                }, 800);

            },
            error: function (xhr, textStatus, errorThrown) {

            }
        }).done(function () {

        });

    };



    $scope.toggleRowSelection = function () {
        $scope.gridApi.selection.clearSelectedRows();
        $scope.gridOptions.enableRowSelection = !$scope.gridOptions.enableRowSelection;
        $scope.gridApi.core.notifyDataChange(uiGridConstants.dataChange.OPTIONS);
    };


    //var getEvolutionRecords = function () {

    //    var category = $scope.category;
    //    var partofalbum = $scope.partofalbum;
    //    var theme = $scope.theme;

    //    if ($scope.category == null) {
    //        category = 0;
    //    }

    //    if ($scope.partofalbum == null) {
    //        partofalbum = 0;
    //    }

    //    if ($scope.theme == null) {
    //        theme = 0;
    //    }



    //    //var apiPath = "/websvc/api/";
    //    var url = apiPath + 'evolution/' + $scope.title + "/" + theme + "/" + category + "/" + partofalbum + "/1/25";

    //    $.ajax({
    //        url: url,
    //        type: 'GET',
    //        dataType: 'json',
    //        contentType: 'application/json',
    //        success: function (data, textStatus, xhr) {

    //            $scope.gridOptions.data = data.data["0"].productCertificates;
    //            $scope.gridOptions.totalItems = $scope.totalRecords;

    //            $scope.$apply();
    //            // $interval whilst we wait for the grid to digest the data we just gave it
    //            $interval(function () {
    //                $scope.gridApi.selection.selectRow($scope.gridOptions.data[0]);
    //            }, 0, 1);

    //            setTimeout(function () {
    //                $scope.$apply(function () {
    //                    $scope.gridApi.core.notifyDataChange(uiGridConstants.dataChange.ALL);
    //                    $scope.gridApi.core.handleWindowResize(uiGridConstants.dataChange.ALL);
    //                });

    //            }, 800);


    //        },
    //        error: function (xhr, textStatus, errorThrown) {

    //        }
    //    }).done(function () {
    //        //$window.refreshGrid();

    //    });


    //};


    $scope.Save = function () {

        var id= $scope.ID;
        var theme = $scope.selectedUser;

        
        if ($scope.Theme === null || typeof theme === 'undefined') {
            Alert("You must select a theme");
            return;
        }



        var url = apiPath + 'save/' + id + "/" + theme;



        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data, textStatus, xhr) {
                
                //$("#closeButton").click();
                //$(".edit").hide();
                //angular.element('#closeButton').triggerHandler('click');
                getPage();
                //$scope.$apply();
                
            },
            error: function (xhr, textStatus, errorThrown) {

            }
        }).done(function () {
            //$window.refreshGrid();

        });


    };



    $scope.Search = function () {

        var category = $scope.category;
        var partofalbum = $scope.partofalbum;
        var theme = $scope.theme;

        if ($scope.category === null || typeof category === 'undefined' ) {
            category = 0;
        }

        if ($scope.partofalbum === null || typeof partofalbum === 'undefined' ) {
            partofalbum = 0;
        }



        if ($scope.theme === null || typeof theme === 'undefined' ) {
            theme = 0;
        }



        var url = apiPath + 'evolution/' + $scope.title + "/" + theme + "/" + category + "/" + partofalbum + "/1/25";
        //var url = apiPath + 'evolution/' + $scope.title + "/" + theme + "/" + category + "/" + partofalbum + "/0/0";



        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data, textStatus, xhr) {
                //$scope.gridOptions.data = data.data["0"].productCertificates;
                $scope.gridOptions.data = data.data["0"].productCertificates;
                $scope.gridOptions.totalItems = $scope.totalRecords;
                $scope.totalRecords = data.result;
                $scope.$apply();
                //getEvolutionRecords();


            },
            error: function (xhr, textStatus, errorThrown) {

            }
        }).done(function () {
            //$window.refreshGrid();

        });


    };


}]);
