import { Component } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '../../shared/animations/routerTransition';

@Component({
	selector: 'app-natter-users',
	standalone: true,
	templateUrl: './natter-users.component.html',
	styleUrl: './natter-users.component.css',
	animations: [appModuleAnimation()]
})
export class NatterUsersComponent {


	constructor() {

	}


	createNatterUser() {

	}
}
