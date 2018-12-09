import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { PastDeliveriesPage } from '../past-deliveries/past-deliveries';
import { DeliveryDetailsPage } from '../delivery-details/delivery-details';

@Component({
  selector: 'page-my-deliveries',
  templateUrl: 'my-deliveries.html',
})
export class MyDeliveriesPage {

  constructor(private nav: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    
  }

  goToPastDeliveries() {
    this.nav.push(PastDeliveriesPage);
  }

  goToDelivery() {
    this.nav.push(DeliveryDetailsPage);
  }

}
