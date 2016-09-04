export class Problem {
    Id: number;
    Title: string;
    Uri: string;
    BoulderId: number;
    BoulderTitle: string;
    Grade: string;
    DateUploaded: Date;

    constructor(id: number,
        title: string,
        uri: string,
        boulderId: number,
        boulderTitle: string,
        grade: string,
        dateUploaded: Date) {
        this.Id = id;
        this.Title = title;
        this.Uri = uri;
        this.BoulderId = boulderId;
        this.BoulderTitle = boulderTitle;
        this.Grade = grade;
        this.DateUploaded = dateUploaded;
    }
}