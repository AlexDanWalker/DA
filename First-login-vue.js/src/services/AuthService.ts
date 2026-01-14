import {users} from "./UserData";
import type{User} from "../models/User";

export class AuthService{

    static login(name:string, email:string):User | null{

        const user = users.find(u=> u.name===name && u.email===email);

        if (!user) {
            return null;
        }

        localStorage.setItem("session", JSON.stringify(user));


        return user;
    }

    static register(name: string, email: string): User | null {
    const exist = users.find(u => u.email === email);

    if (exist) {
        console.error("Ese usuario ya existe");
        return null;
    }

    const newUser: User = {
        id: users.length + 1,
        name,
        email
    };

    users.push(newUser);
    localStorage.setItem("session", JSON.stringify(newUser));

    return newUser;
    }

}