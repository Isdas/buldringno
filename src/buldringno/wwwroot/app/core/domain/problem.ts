export class Problem {
    Id: number;
    Title: string;
    Uri: string;
    BoulderId: number;
    BoulderTitle: string;
    DateUploaded: Date;

    constructor(id: number,
        title: string,
        uri: string,
        boulderId: number,
        boulderTitle: string,
        dateUploaded: Date) {
        this.Id = id;
        this.Title = title;
        this.Uri = uri;
        this.BoulderId = boulderId;
        this.BoulderTitle = boulderTitle;
        this.DateUploaded = dateUploaded;
    }
}