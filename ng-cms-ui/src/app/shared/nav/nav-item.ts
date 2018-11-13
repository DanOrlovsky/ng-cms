


export class NavItem {
    name: string = "";
    permissionName: string = "";
    icon: string = "";
    route: string = "";
    children: NavItem[] = [];


    constructor(name: string, permissionName: string, icon: string, route: string, children: NavItem[] = null) {
        this.name = name;
        this.permissionName = permissionName;
        this.icon = icon;
        this.route = route;
        this.children = children;
    }
}