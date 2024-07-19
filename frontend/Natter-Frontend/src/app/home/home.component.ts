import { Component } from '@angular/core';
import { IPost } from '../post/post.component';
import { IUser } from '../iuser';
import { CreatePostService } from '../create-post/create-post.service';
import { Subscription } from 'rxjs';

@Component({
	selector: 'app-home',
	templateUrl: './home.component.html',
	styleUrls: ['./home.component.scss']
})
export class HomeComponent {

	public posts = new Array<IPost>();
	public user: IUser = {
		username: "",
		id: 0
	};
	public showCreateNewPostDialog = false;

	private useTestData = false;

	private createPostSubscription = new Subscription();

	constructor(private createPostService: CreatePostService) {

	}

	ngOnInit() {

		if (this.useTestData) {
			this.createTestPosts();
			this.createTestUser();
		}
		else {
			this.getRealPosts();
			this.getRealUser();
		}
		console.log("The posts: ", this.posts);

		this.createPostSubscription.add(this.createPostService.closeDialogStatus.subscribe((data) => {
			if (data !== undefined && data !== null) {
				console.log("Dialog data: ", data);
				this.showCreateNewPostDialog = data;
			}
		}));
	}

	async getRealPosts() {

		let response = await fetch("https://localhost:44311/NatterPost/GetAllNatterPosts");

		let jsonData = await response.json();

		console.log("Real posts: ", jsonData);

		this.posts = jsonData.result.posts;

	}

	async getRealUser() {

		var response = await fetch("https://localhost:44311/NatterUser/GetUserById", {
			method: "POST"
		});

		let jsonData = await response.json();

		console.log("Real user: ", jsonData);

		this.user = jsonData.result.natterUser;

	}

	createTestPosts() {

		this.posts.push({
			caption: "Test 1",
			description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam sed erat vestibulum, hendrerit magna in, vehicula velit. Nulla quis eros a metus egestas rhoncus ut at enim.",
			images: "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png",
			creationTime: new Date()
		});

		this.posts.push({
			caption: "Test 2",
			description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam sed erat vestibulum, hendrerit magna in, vehicula velit. Nulla quis eros a metus egestas rhoncus ut at enim.",
			creationTime: new Date()
		})

		this.posts.push({
			caption: "Test 3",
			description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam sed erat vestibulum, hendrerit magna in, vehicula velit. Nulla quis eros a metus egestas rhoncus ut at enim.",
			images: "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png",
			creationTime: new Date()
		})

		this.posts.push({
			caption: "Test 4",
			description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam sed erat vestibulum, hendrerit magna in, vehicula velit. Nulla quis eros a metus egestas rhoncus ut at enim.",
			images: "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png",
			creationTime: new Date()
		})

	}


	createTestUser() {

		this.user = {
			username: "TestUser",
			id: 1
		}

	}

	openNewPostDialog() {

		this.createPostService.openDialog();

	}



}
