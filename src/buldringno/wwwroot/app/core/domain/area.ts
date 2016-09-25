export class Area {
    Id: number;
    Title: string;
    DescriptionMain: string;
    DescriptionSecondary: string;
    Parking: string;
    ApproachTime: string;
    DateCreated: Date;
    TotalBoulders: number;

    constructor(id: number,
        title: string,
        descriptionMain: string,
        descriptionSecondary: string,
        parking: string,
        approachTime: string,
        dateCreated: Date,
        totalBoulders: number) {
        this.Id = id;
        this.Title = title;
        this.DescriptionMain = descriptionMain;
        this.DescriptionSecondary = descriptionSecondary;
        this.Parking = parking;
        this.ApproachTime = approachTime;
        this.DateCreated = dateCreated;
        this.TotalBoulders = totalBoulders;
    }
}