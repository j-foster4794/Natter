import { Component, Input } from '@angular/core';

@Component({
	selector: 'app-interactions',
	templateUrl: './interactions.component.html',
	styleUrls: ['./interactions.component.scss']
})
export class InteractionsComponent {

	@Input() interactionData: Array<IInteraction> = new Array<IInteraction>();

	constructor() {

	}




}

export interface IInteraction {

	type: string;
	numberOfInteractions: number;

}