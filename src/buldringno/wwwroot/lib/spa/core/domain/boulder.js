"use strict";
var Boulder = (function () {
    function Boulder(id, title, description, thumbnail, dateCreated, totalPhotos) {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Thumbnail = thumbnail;
        this.DateCreated = dateCreated;
        this.TotalProblems = totalPhotos;
    }
    return Boulder;
}());
exports.Boulder = Boulder;
