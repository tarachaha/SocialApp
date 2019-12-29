import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    age?: number;
    about?: string;
    photos?: Photo[];
}
