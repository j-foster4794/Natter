import { Component, Input } from '@angular/core';

@Component({
	selector: 'app-post',
	templateUrl: './post.component.html',
	styleUrls: ['./post.component.scss']
})
export class PostComponent {


	@Input() postData!: IPost;

	public caption: string = "";
	public description: string = "";
	public images: Array<string> = new Array<string>();
	public postDate: Date = new Date();

	constructor() {

	}

	ngOnInit() {
		this.caption = this.postData.caption;
		this.description = this.postData.description;
		if (this.postData.images) this.images = this.postData.images.split(",");
		this.postDate = this.postData.creationTime;
	}

}

export interface IPost {
	caption: string;
	description: string;
	images?: string; // Comma separated list or URLs,
	creationTime: Date
}