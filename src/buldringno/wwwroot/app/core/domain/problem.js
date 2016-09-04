"use strict";
var Problem = (function () {
    function Problem(id, title, uri, boulderId, boulderTitle, grade, dateUploaded) {
        this.Id = id;
        this.Title = title;
        this.Uri = uri;
        this.BoulderId = boulderId;
        this.BoulderTitle = boulderTitle;
        this.Grade = grade;
        this.DateUploaded = dateUploaded;
    }
    return Problem;
}());
exports.Problem = Problem;
//# sourceMappingURL=problem.js.map