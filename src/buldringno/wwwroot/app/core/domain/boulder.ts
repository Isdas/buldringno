export class Boulder {
    Id: number;
    Title: string;
    Description: string;
    Thumbnail: string;
    AreaId: number;
    AreaTitle: string;
    TotalProblems: number;
    DateCreated: Date;

    constructor(id: number,
        title: string,
        description: string,
        thumbnail: string,
        areaId: number,
        areaTitle: string,
        totalProblems: number,
        dateCreated: Date) {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Thumbnail = thumbnail;
        this.AreaId = areaId;
        this.AreaTitle = areaTitle;
        this.TotalProblems = totalProblems;
        this.DateCreated = dateCreated;
    }
}