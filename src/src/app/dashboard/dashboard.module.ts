import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule }        from '@angular/forms';
import { SharedModule }       from '../shared/modules/shared.module';

import { routing }  from './dashboard.routing';
import { RootComponent } from './root/root.component';
import { HomeComponent } from './home/home.component';
import { DashboardService } from './services/dashboard.service';

import { AuthGuard } from '../auth.guard';
import { SettingsComponent } from './settings/settings.component';
import { GridComponent } from './grid/grid.component';

import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { GridModule } from '@progress/kendo-angular-grid';
import { LayoutModule } from '@progress/kendo-angular-layout'; 


@NgModule({
  imports: [
    LayoutModule,
    ButtonsModule,
    GridModule,
    CommonModule,
    FormsModule,
    routing,
    SharedModule
  ],
  declarations: [RootComponent,HomeComponent, SettingsComponent, GridComponent],
  exports:      [ ],
  providers:    [AuthGuard,DashboardService]
})
export class DashboardModule { }
