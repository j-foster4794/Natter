import { Component } from '@angular/core';
import { IPost } from '../post/post.component';
import { IUser } from '../iuser';

@Component({
	selector: 'app-home',
	templateUrl: './home.component.html',
	styleUrls: ['./home.component.scss']
})
export class HomeComponent {

	public posts = new Array<IPost>();
	public user: IUser = {
		username: ""
	};

	ngOnInit() {
		this.createTestPosts();
		this.createTestUser();
		console.log("The posts: ", this.posts);
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
			username: "TestUser"
		}

	}



}
