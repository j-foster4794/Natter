import { Component, Input } from '@angular/core';
import { CreatePostService, ICreateNewPostInput } from './create-post.service';

@Component({
	selector: 'app-create-post',
	templateUrl: './create-post.component.html',
	styleUrls: ['./create-post.component.scss']
})
export class CreatePostComponent {

	public caption = "";
	public description = "";

	@Input() userId!: number;


	constructor(
		private createPostService: CreatePostService
	) {

	}


	async createPost() {

		let createPostInput: ICreateNewPostInput = {
			natterPost: {
				caption: this.caption,
				description: this.description,
				creationTime: new Date()
			},
			userId: this.userId
		}

		let response = await this.createPostService.createNewPost(createPostInput);

	}

	cancel() {
		this.createPostService.closeDialog();
	}

}
