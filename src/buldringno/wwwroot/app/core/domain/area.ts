export class Area {
    Id: number;
    Title: string;
    Description: string;
    DateCreated: Date;
    TotalBoulders: number;

    constructor(id: number,
        title: string,
        description: string,
        dateCreated: Date,
        totalBoulders: number) {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.DateCreated = dateCreated;
        this.TotalBoulders = totalBoulders;
    }
}