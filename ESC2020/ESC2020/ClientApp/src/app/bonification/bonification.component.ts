﻿import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Participant } from '../Model/Participant';
import { Election } from '../Model/Election';
import { TypeOpinion } from '../Model/TypeOpinion';
import { Users } from '../Model/Users';
import { Phase } from '../Model/Phase';
import { Router } from '@angular/router';
import { AuthentificationService } from '../services/authentification.service';
import { Opinion } from '../Model/Opinion';
import { NavBarStateService } from '../services/NavBarState.service';
import * as signalR from "@microsoft/signalr";


@Component({
    selector: 'app-bonification',
    templateUrl: './bonification.component.html',
    styleUrls: ['./bonification.component.css']
})

export class BonificationComponent implements OnInit {

    connected: boolean;
    connectedAccount: Users = new Users();

    election: Election = new Election();
    isElectedNotNull: boolean = false;
    actualElected: Users = new Users();
    connectedParticipant: Participant = new Participant();
    type: TypeOpinion = new TypeOpinion();
    electionId: string;
    host: boolean = false;

    participantsList: Participant[] = [];
    opinionsList: Opinion[] = [];
    usersList: Users[] = [];
    objectionsList: Opinion[] = [];

    hubConnection = new signalR.HubConnectionBuilder()
        .withUrl("/data")
        .build();

    constructor(private service: HttpClient, private router: Router, private authentificationService: AuthentificationService, private navBarStateService: NavBarStateService) {

    }

    ngOnInit() {
        this.authentificationService.getConnectedFeed().subscribe(aBoolean => this.connected = aBoolean);
        this.authentificationService.getConnectedAccountFeed().subscribe(anUser => this.connectedAccount = anUser);
        this.navBarStateService.SetIsInElection(true);
        this.navBarStateService.SetObjectionsVisible(true);
        this.navBarStateService.SetLogsVisible(true);
        // setInterval(() => this.getObjections(), 5000); // solution temporaire avant SignalR

        this.mainRequest();

        this.hubConnection.start().catch(err => console.log(err));
    }

    mainRequest() {
        //Récupérer l'id de l'élection actuelle à partir de l'url
        this.electionId = this.router.url.split('/')[2];
        this.service.get(window.location.origin + "/api/Elections/" + this.electionId).subscribe(result => {
            this.election = result as Election;
            this.navBarStateService.SetNavState(this.election['job']);
            this.getConnectedParticipant();
            this.checkHost();
            this.preStart();
        }, error => console.error(error));
    }

    getConnectedParticipant() {
        this.service.get(window.location.origin + "/api/Participants/" + this.connectedAccount['userId'] + "/" + this.election['electionId']).subscribe(result => {
            this.connectedParticipant = result as Participant;
        }, error => console.log(error));
    }

    checkHost() {
        if (this.connectedAccount["userId"] == this.election['hostId']) {
            this.host = true;
        }
        else {
            this.host = false;
        }
    }

    preStart() {
        //récupérer l'utilisateur actuellement élu en fonction du champ electedId d'une élection
        if (this.election['electedId'] != null) {
            this.isElectedNotNull = true;
            this.service.get(window.location.origin + "/api/Users/" + this.election['electedId']).subscribe(userResult => {
                this.actualElected = userResult as Users;
            }, error => console.error(error));
        }
    }


    refus() {
        // génération d'une opinion Bonification (id du type : 3 = opinion de type bonification)
        this.service.get(window.location.origin + "/api/TypeOpinions/3").subscribe(result => {
            this.type = result as TypeOpinion;
            this.service.post(window.location.origin + "/api/Opinions", {
                'AuthorId': this.connectedAccount["userId"],
                'ConcernedId': this.actualElected["userId"],
                'Reason': (<HTMLInputElement>document.getElementById("argumentaires")).value,
                'TypeId': this.type["typeId"],
                'DateOpinion': new Date(),
                'ElectionId': this.election['electionId']
            }).subscribe(result => {
                (<HTMLInputElement>document.getElementById("argumentaires")).value = "";
                console.log(result);
            }, error => console.log(error));
        }, error => console.error(error));

        
        this.service.put(window.location.origin + "/api/Participants/" + this.actualElected['userId'] + "/" + this.election['electionId'], {
            "UserId": this.actualElected['userId'],
            "ElectionId": this.election['electionId'],
            "HasTalked": false,
            "Proposable": false
        }).subscribe(result => {
        }, error => console.log(error));

        let phase: Phase = new Phase();
        this.service.get(window.location.origin + "/api/Phases/3").subscribe(phaseResult => {
            phase = phaseResult as Phase;

            this.service.put(window.location.origin + "/api/Elections/" + this.election['electionId'], {
                "ElectionId": this.election['electionId'],
                "Job": this.election['job'],
                "Mission": this.election['mission'],
                "Responsability": this.election['responsability'],
                "StartDate": this.election['startDate'],
                "EndDate": this.election['endDate'],
                "CodeElection": this.election['codeElection'],
                "HostId": this.election["hostId"],
                "ElectedId": null,
                "ElectionPhaseId": phase['phaseId']
            }).subscribe(result => {
                this.hubConnection.send("updatePhase", Number(this.electionId));
            }, error => console.log(error));
        });
    }

    goToNextPhase() {
        let phase: Phase = new Phase();
        this.service.get(window.location.origin + "/api/Phases/5").subscribe(phaseResult => {
            phase = phaseResult as Phase;

            this.service.put(window.location.origin + "/api/Elections/" + this.election['electionId'], {
                "ElectionId": this.election['electionId'],
                "Job": this.election['job'],
                "Mission": this.election['mission'],
                "Responsability": this.election['responsability'],
                "StartDate": this.election['startDate'],
                "EndDate": this.election['endDate'],
                "CodeElection": this.election['codeElection'],
                "HostId": this.election["hostId"],
                "ElectedId": null,
                "ElectionPhaseId": phase['phaseId']
            }).subscribe(result => {
                this.hubConnection.send("updatePhase", Number(this.electionId));
            }, error => console.log(error));
        });
    }
}
