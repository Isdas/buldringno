"use strict";
var Boulder = (function () {
    function Boulder(id, title, description, thumbnail, areaId, areaTitle, totalProblems, dateCreated) {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Thumbnail = thumbnail;
        this.AreaId = areaId;
        this.AreaTitle = areaTitle;
        this.TotalProblems = totalProblems;
        this.DateCreated = dateCreated;
    }
    return Boulder;
}());
exports.Boulder = Boulder;
//# sourceMappingURL=boulder.js.map