"use strict";
var Area = (function () {
    function Area(id, title, descriptionMain, descriptionSecondary, parking, approachTime, dateCreated, totalBoulders) {
        this.Id = id;
        this.Title = title;
        this.DescriptionMain = descriptionMain;
        this.DescriptionSecondary = descriptionSecondary;
        this.Parking = parking;
        this.ApproachTime = approachTime;
        this.DateCreated = dateCreated;
        this.TotalBoulders = totalBoulders;
    }
    return Area;
}());
exports.Area = Area;
