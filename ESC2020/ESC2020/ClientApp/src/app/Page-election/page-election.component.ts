import { Component, OnInit, AfterViewInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Participant } from '../Model/Participant';
import { Session } from '../Model/Session';
import { TypeOpinion } from '../Model/TypeOpinion';
import { Users } from '../Model/Users';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';
import { AuthentificationService } from '../services/authentification.service';

@Component({
    selector: 'app-election',
    templateUrl: './page-election.component.html',
    styleUrls: ['./page-election.component.css']
})

export class PageElectionComponent implements OnInit {

    private connected: boolean;
    private connectedAccount: Users = new Users();
    private electionId: string;
    private type: TypeOpinion = new TypeOpinion();
    private listeParticipants : Participant[] = []

    currentUser: Users = new Users();
    session: Session = new Session();
    currentParticipant: Participant = new Participant();
    scrollingItems: number[] = [];
    actualClickedId: number = 1;

    private listeUsers: Users[] = [];
    private liste: Users[] = [];

    age: number;

    constructor(private service: HttpClient, private router: Router, private authentificationService: AuthentificationService) { }


    IntantiateBadge(id:string){
        console.log("initBage id : " + id);
        //console.log("Liste : " +  this.listeParticipants);

        //let regexp: RegExp = /\d/;
        //this.electionId = regexp.exec(this.router.url)[0];

        //this.service.get(window.location.origin + "/api/Elections/" + this.electionId).subscribe(result => {
        //    this.session = result as Session;

        //    //récupérer la liste des participants en fonction de l'id d'une élection
        //    this.service.get(window.location.origin + "/api/Participants/election/" + this.session['electionId']).subscribe(participantResult => {
        //        this.listeParticipants = participantResult as Participant[];
        //        this.listeParticipants.forEach((participant) => {
        //            console.log("oui");

        //        });
        //    }, error => console.error(error));
        //}, error => console.error(error));
    }

    ngOnInit() {
        this.FetchParticipants();
    }

    async FetchParticipants() {
        this.authentificationService.getConnectedFeed().subscribe(aBoolean => this.connected = aBoolean);
        this.authentificationService.getConnectedAccountFeed().subscribe(anUser => this.connectedAccount = anUser);

        //Récupérer l'id de l'élection actuelle à partir de l'url
        let regexp: RegExp = /\d/;
        this.electionId = regexp.exec(this.router.url)[0];

        await this.service.get(window.location.origin + "/api/Elections/" + this.electionId).subscribe(result => {
            this.session = result as Session;

            //récupérer la liste des participants en fonction de l'id d'une élection
            this.service.get(window.location.origin + "/api/Participants/election/" + this.session['electionId']).subscribe(participantResult => {
                this.listeParticipants = participantResult as Participant[];
                this.listeParticipants.forEach((participant) => {
                    this.FetchUser(participant);
                });
            }, error => console.error(error));
        }, error => console.error(error));
    }

    async FetchUser(participant: Participant) {
        await this.service.get(window.location.origin + "/api/Users/" + participant['userId']).subscribe(userResult => {
            console.log(participant);

            this.currentParticipant = participant;
            console.log("participant : " + this.listeParticipants.get(userResult as Users));

            this.listeUsers.push(userResult as Users);
            //console.log(participant);
            //console.log(participant['userId'] + "Voted");

            //if (participant['hasTalked'])
            //    document.getElementById(participant['userId'] + "Voted").style.visibility = "visible";
            //else
            //    document.getElementById(participant['userId'] + "NotVoted").style.visibility = "visible";
        }, error => console.error(error));
    }

    actualParticipant(user: Users, birthDate: string) {
        document.getElementById("selectParticipant").style.visibility = "visible";

        this.ageCalculation(birthDate);
        this.currentUser = user;
    }

    private ageCalculation(birthDate: string) {
        const currentDate: Date = new Date();
        const BirthDate: Date = new Date(birthDate);

        var Age: number = currentDate.getFullYear() - BirthDate.getFullYear() - 1;

        if (currentDate.getMonth() > BirthDate.getMonth()) {
            Age++;
        }
        else if (currentDate.getMonth() == BirthDate.getMonth()) {
            if (currentDate.getDate() >= BirthDate.getDate()) {
                Age++;
            }
        }

        this.age = Age;
    }

    changeColor(userId: number) {
        if (userId != this.actualClickedId) {
            document.getElementById(this.actualClickedId.toString()).style.borderColor = "black";
            document.getElementById(this.actualClickedId.toString()).style.borderWidth = "3px";

            this.actualClickedId = userId
            document.getElementById(this.actualClickedId.toString()).style.borderColor = "#640a60";
            document.getElementById(this.actualClickedId.toString()).style.borderWidth = "5px";
        } else {
            document.getElementById(this.actualClickedId.toString()).style.borderColor = "#640a60";
            document.getElementById(this.actualClickedId.toString()).style.borderWidth = "5px";
        }
    }

    Vote() {
        //génération d'une opinion Vote (id du type : 1 = opinion de type vote)
        this.service.get(window.location.origin + "/api/TypeOpinions/1").subscribe(result => {
            this.type = result as TypeOpinion;
            this.service.post(window.location.origin + "/api/Opinions", {
                'AuthorId': this.connectedAccount["userId"],
                'ConcernedId': this.currentUser["userId"],
                'Reason': (<HTMLInputElement>document.getElementById("argumentaires")).value,
                'TypeId': this.type["typeId"],
                'Date': Date.now(),
                'ElectionId': this.session['electionId']
            }).subscribe(result => {
                console.log(result);
            }, error => console.log(error));
        }, error => console.error(error));

        this.service.get(window.location.origin + "/api/Participants/" + this.connectedAccount['userId'] + "/" + this.session['electionId']).subscribe(result => {
            let participantResult: Participant = result as Participant;
            this.service.put<Participant>(window.location.origin + "/api/Participants/" + this.connectedAccount['userId'] + "/" + this.session['electionId'], {
                'UserId': participantResult['userId'],
                'ElectionId': participantResult['electionId'],
                'HasTalked': false
            }).subscribe(result => {
            }, error => console.log(error));
        }, error => console.log(error));
    }
}

/*
 *
 *             this.service.put(window.location.origin + "/api/Participants/" + this.connectedAccount['userId'], {
                'HasTalked': true
            }).subscribe(result => {
                console.log(result);
            }
            */