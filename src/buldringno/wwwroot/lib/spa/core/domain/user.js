"use strict";
var User = (function () {
    function User(username, email, password) {
        this.Username = username;
        this.Email = email;
        this.Password = password;
        this.RememberMe = false;
    }
    return User;
}());
exports.User = User;
