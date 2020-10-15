export class ApiCommonMessage {
    UserName: string;
    Token: string;
    FormName: string;
    ModuleName: string;
    Content: string;

    constructor(userName: string, token: string, content: any) {
        this.UserName = userName;
        this.Token = token;
        this.Content = JSON.stringify(content);
    }
}