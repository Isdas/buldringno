export class User {
    Username: string;
    Email: string;
    Password: string;
    RememberMe: boolean;

    constructor(username: string,
        email: string,
        password: string) {
        this.Username = username;
        this.Email = email;
        this.Password = password;
        this.RememberMe = false;
    }
}