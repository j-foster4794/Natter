import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { IPost } from '../post/post.component';

@Injectable({
	providedIn: 'root'
})
export class CreatePostService {

	private readonly _closeDialogStatus = new BehaviorSubject(false);
	public closeDialogStatus = this._closeDialogStatus.asObservable();

	constructor() { }


	/**
	 * Create a new post
	 * 
	 * @param input The new post to be created
	 */
	public async createNewPost(input: ICreateNewPostInput) {

		console.log("Data to send: ", input);

		let response = await fetch("https://localhost:44311/NatterPost/CreateNewPost",
			{
				method: "POST",
				body: JSON.stringify(input),
				headers: {
					"Content-Type": "application/json"
				}
			}
		);

		let jsonResponse = await response.json();

		console.log("Json response: ", jsonResponse);

		this._closeDialogStatus.next(false);

	}

	public closeDialog() {
		this._closeDialogStatus.next(false);
	}

	public openDialog() {
		this._closeDialogStatus.next(true);
	}
}


export interface ICreateNewPostInput {
	natterPost: IPost;
	userId: number;
}