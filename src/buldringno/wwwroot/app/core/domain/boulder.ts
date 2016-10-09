export class Boulder {
    Id: number;
    Title: string;
    DescriptionMain: string;
    DescriptionSecondary: string;
    Thumbnail: string;
    AreaId: number;
    AreaTitle: string;
    TotalProblems: number;
    DateCreated: Date;

    constructor(id: number,
        title: string,
        descriptionMain: string,
        descriptionSecondary: string,
        thumbnail: string,
        areaId: number,
        areaTitle: string,
        totalProblems: number,
        dateCreated: Date) {
        this.Id = id;
        this.Title = title;
        this.DescriptionMain = descriptionMain;
        this.DescriptionSecondary = descriptionSecondary;
        this.Thumbnail = thumbnail;
        this.AreaId = areaId;
        this.AreaTitle = areaTitle;
        this.TotalProblems = totalProblems;
        this.DateCreated = dateCreated;
    }
}