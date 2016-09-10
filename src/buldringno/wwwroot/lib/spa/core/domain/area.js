"use strict";
var Area = (function () {
    function Area(id, title, description, dateCreated, totalBoulders) {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.DateCreated = dateCreated;
        this.TotalBoulders = totalBoulders;
    }
    return Area;
}());
exports.Area = Area;
