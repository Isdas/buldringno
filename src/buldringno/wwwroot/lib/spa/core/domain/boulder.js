"use strict";
var Boulder = (function () {
    function Boulder(id, title, descriptionMain, descriptionSecondary, thumbnail, areaId, areaTitle, totalProblems, dateCreated) {
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
    return Boulder;
}());
exports.Boulder = Boulder;
