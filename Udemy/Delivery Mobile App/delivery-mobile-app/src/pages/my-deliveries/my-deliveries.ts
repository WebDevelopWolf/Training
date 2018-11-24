import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { PastDeliveriesPage } from '../past-deliveries/past-deliveries';

@Component({
  selector: 'page-my-deliveries',
  templateUrl: 'my-deliveries.html',
})
export class MyDeliveriesPage {

  constructor(private nav: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad MyDeliveriesPage');
  }

  goToPastDeliveries() {
    this.nav.push(PastDeliveriesPage);
  }

}
