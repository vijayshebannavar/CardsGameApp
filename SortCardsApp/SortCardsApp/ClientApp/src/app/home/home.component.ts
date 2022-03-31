import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { IDropdownSettings } from 'ng-multiselect-dropdown';
import { CardService } from '../services/card.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
 /*  public inputs:string[] = ['3C', 'JS', '2D', 'PT', '10H', 'KH', '8S', '4T', 'AC', '4H', 'RT']; */
  public inputs:string[] = [];
  public outputs:string[] = [];
  dropdownList = [];
  selectedItems = [];
  public isInputSelected = false;
  dropdownSettings:IDropdownSettings={};

  constructor(public cardService:CardService) {
    
  }

  ngOnInit(){
   this.InitDropDownList();
    this.dropdownSettings = {
      idField: 'id',
      textField: 'card',
    };
  }

  InitDropDownList(){
    this.dropdownList = [
      { id: 1, card: '2H' },
      { id: 2, card: '3H' },
      { id: 3, card: '4H' },
      { id: 4, card: '5H' },
      { id: 5, card: '6H' },
      { id: 6, card: '7H' },
      { id: 7, card: '8H' },
      { id: 8, card: '9H' },
      { id: 9, card: '10H' },
      { id: 10, card: 'JH' },
      { id: 11, card: 'QH' },
      { id: 12, card: 'KH' },
      { id: 13, card: 'AH' },
      { id: 14, card: '2S' },
      { id: 15, card: '3S' },
      { id: 16, card: '4S' },
      { id: 17, card: '5S' },
      { id: 18, card: '6S' },
      { id: 19, card: '7S' },
      { id: 20, card: '8S' },
      { id: 21, card: '9S' },
      { id: 22, card: '10S' },
      { id: 23, card: 'JS' },
      { id: 24, card: 'QS' },
      { id: 25, card: 'KS' },
      { id: 26, card: 'AS' },
      { id: 27, card: '2D' },
      { id: 28, card: '3D' },
      { id: 29, card: '4D' },
      { id: 30, card: '5D' },
      { id: 31, card: '6D' },
      { id: 32, card: '7D' },
      { id: 33, card: '8D' },
      { id: 34, card: '9D' },
      { id: 35, card: '10D' },
      { id: 36, card: 'JD' },
      { id: 37, card: 'QD' },
      { id: 38, card: 'KD' },
      { id: 39, card: 'AD' },
      { id: 40, card: '2C' },
      { id: 41, card: '3C' },
      { id: 42, card: '4C' },
      { id: 43, card: '5C' },
      { id: 44, card: '6C' },
      { id: 45, card: '7C' },
      { id: 46, card: '8C' },
      { id: 47, card: '9C' },
      { id: 48, card: '10C' },
      { id: 49, card: 'JC' },
      { id: 50, card: 'QC' },
      { id: 51, card: 'KC' },
      { id: 52, card: 'AC' },
      { id: 53, card: '4T' },
      { id: 54, card: '2T' },
      { id: 55, card: 'ST' },
      { id: 56, card: 'PT' },
      { id: 57, card: 'RT' },
    ];
  }

  OnSortClick(){
    this.inputs = [];
    this.selectedItems.forEach(x => {
      this.inputs.push(x.card);
    })
    console.log(this.selectedItems);
    this.cardService.sortCards(this.inputs).subscribe(res => {
      this.outputs = res;
     console.log(this.outputs);
  });

  }

  OnClearClick(){
    this.selectedItems = [];
    
  }


}
