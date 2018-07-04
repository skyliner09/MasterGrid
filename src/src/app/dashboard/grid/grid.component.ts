import { Component, OnInit } from '@angular/core';

import { MasterDetails } from '../models/master.details.interface';
import { DashboardService } from '../services/dashboard.service';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.scss']
})
export class GridComponent implements OnInit {
  title = 'Hello World!';
  masterDetails: MasterDetails;

  constructor(private dashboardService: DashboardService) { }

  onButtonClick() {
    this.title = 'Hello from Kendo UI!';
  }

  masterData = [{ artist: "Pink Floyd", track: "The dark side of the Moon" },
  { artist: "The Beatles", track: "I've just seen a face" },
    { artist: "Queen", track: "Innuendo" }];

  masterColumns = [{ field: "artist", title: "Artist" },
  { field: "track", title: "Track" }];


 
  ngOnInit() {
    this.dashboardService.getMasterDetails()
      .subscribe((masterDetails: MasterDetails) => {
        this.masterDetails = masterDetails;
      },
        error => {
          //this.notificationService.printErrorMessage(error);
        });
  }

  //angular.module("KendoDemos", [ "kendo.directives" ])
  //      .controller("MyCtrl", function($scope) {
  //  $scope.mainGridOptions = {
  //    dataSource: {
  //      type: "odata",
  //      transport: {
  //        read: "https://demos.telerik.com/kendo-ui/service/Northwind.svc/Employees"
  //      },
  //      pageSize: 5,
  //      serverPaging: true,
  //      serverSorting: true
  //    },
  //    sortable: true,
  //    pageable: true,
  //    dataBound: function () {
  //      this.expandRow(this.tbody.find("tr.k-master-row").first());
  //    },
  //    columns: [{
  //      field: "Id",
  //    }, {
  //      field: "EquipmentName",
  //    }, {
  //      field: "EquipmentLocation",
  //    }, {
  //      field: "Purchased",
  //    }, {
  //      field: "PurchasePrice",
  //    }, {
  //      field: "Active",
  //    }, {
  //      field: "EnteredBY",
  //    }, {
  //      field: "EnteredOn",
  //    }, {
  //      field: "LastUpdateBY",
  //    }, {
  //      field: "LastUpdateOn",
  //    }]
  //  };

  //  $scope.detailGridOptions = function (dataItem) {
  //    return {
  //      dataSource: {
  //        type: "odata",
  //        transport: {
  //          read: "https://demos.telerik.com/kendo-ui/service/Northwind.svc/Orders"
  //        },
  //        serverPaging: true,
  //        serverSorting: true,
  //        serverFiltering: true,
  //        pageSize: 5,
  //        filter: { field: "EmployeeID", operator: "eq", value: dataItem.EmployeeID }
  //      },
  //      scrollable: false,
  //      sortable: true,
  //      pageable: true,
  //      columns: [
  //        { field: "OrderID", title: "ID", width: "56px" },
  //        { field: "ShipCountry", title: "Ship Country", width: "110px" },
  //        { field: "ShipAddress", title: "Ship Address" },
  //        { field: "ShipName", title: "Ship Name", width: "190px" }
  //      ]
  //    };
  //  };

  //  $scope.masterData = [{ artist: "Pink Floyd", track: "The dark side of the Moon" },
  //  { artist: "The Beatles", track: "I've just seen a face" },
  //  { artist: "Queen", track: "Innuendo" }];//masterDetails;
  //  $scope.masterColumns = [{ field: "artist", title: "Artist" },
  //  { field: "track", title: "Track" }
  //    //{
  //    //    field: "equipmentName",
  //    //  }, {
  //    //    field: "equipmentLocation",
  //    //  }, {
  //    //    field: "purchased",
  //    //  }, {
  //    //    field: "purchasePrice",
  //    //  }, {
  //    //    field: "active",
  //    //  }, {
  //    //    field: "enteredBY",
  //    //  }, {
  //    //    field: "enteredOn",
  //    //  }, {
  //    //    field: "lastUpdateBY",
  //    //  }, {
  //    //    field: "lastUpdateOn",
  //    //  }
  //  ];
  //  //$scope.update = function () {
  //  //    $scope.gridData[0].track = "Hey you";
  //  //    console.log($scope.gridData);
  //  //};
  //})


}
