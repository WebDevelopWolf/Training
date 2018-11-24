import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';

import { MyApp } from './app.component';

import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { MyDeliveriesPage } from '../pages/my-deliveries/my-deliveries';
import { PastDeliveriesPage } from '../pages/past-deliveries/past-deliveries';
import { DeliveryDetailsPage } from '../pages/delivery-details/delivery-details';
import { DeliveryMapPage } from '../pages/delivery-map/delivery-map';
import { DeliverPage } from '../pages/deliver/deliver';
import { ConfirmDeliveryPage } from '../pages/confirm-delivery/confirm-delivery';

@NgModule({
  declarations: [
    MyApp,
    MyDeliveriesPage,
    PastDeliveriesPage,
    DeliveryDetailsPage,
    DeliveryMapPage,
    DeliverPage,
    ConfirmDeliveryPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp),
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    MyDeliveriesPage,
    PastDeliveriesPage,
    DeliveryDetailsPage,
    DeliveryMapPage,
    DeliverPage,
    ConfirmDeliveryPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
