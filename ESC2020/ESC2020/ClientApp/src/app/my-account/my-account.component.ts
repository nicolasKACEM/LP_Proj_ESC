﻿import { Component, OnInit, ViewChild, SystemJsNgModuleLoader } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Users } from '../Model/Users';
import { AuthentificationService } from '../services/authentification.service';
import { DomSanitizer, SafeUrl } from '@angular/platform-browser';
import { NavBarStateService } from '../services/NavBarState.service';
import { HTTPRequestService } from '../services/HTTPRequest.service';


@Component({
    selector: 'app-accountPage',
    templateUrl: './my-account.component.html',
    styleUrls: ['./my-account.component.css']
})
export class MyAccountComponent implements OnInit {
    private erreur = "";
    private connected: boolean;
    public connectedAccount: Users;
    public isReadOnly: boolean = true;
    public image: any;

    constructor(private httpRequest: HTTPRequestService,private authentificationService: AuthentificationService, private service: HttpClient, private sanitizer: DomSanitizer, private navBarStateService: NavBarStateService) { }

    ngOnInit() {
        this.authentificationService.getConnectedFeed().subscribe(aBoolean => this.connected = aBoolean);
        this.authentificationService.getConnectedAccountFeed().subscribe(anUser => this.connectedAccount=anUser);
        
        this.navBarStateService.SetIsInElection(false);
    }

    scroll(el: HTMLElement) {
        el.scrollIntoView({ behavior: 'smooth', block: 'start' });
    }

    modifyProfile() {
        //si l'utilisateur a terminé la modification de ses informations
        if (!this.isReadOnly) {
            //verifier si les modifications sont valides
            if (!this.verifyProfile())//ne pas oublier de prévenir l'utilisateur par affichage que ce n'est pas valide
                return;
            //console.log(this.connectedAccount.avatar);
            if (this.image != null) {
                this.image = this.decodeBase64(this.image);
            } else {
                this.image = this.connectedAccount['avatar'];
            }
            //il faudra éventuellement rajouter des vérifications par exemple : une limite de chaine de caractères, pas de nombre dans le nom...
            //remplacement

            let updateUser: Users = { userId: this.connectedAccount.userId, email: this.connectedAccount.email, password: this.connectedAccount.password, salt: this.connectedAccount.salt, birthDate: (<HTMLInputElement>document.getElementById("birthDate")).value, description: (<HTMLInputElement>document.getElementById("description")).value, job: (<HTMLInputElement>document.getElementById("job")).value, lastName: (<HTMLInputElement>document.getElementById("lastName")).value, firstName: (<HTMLInputElement>document.getElementById("firstName")).value, avatar: this.image, authUser: this.connectedAccount.authUser }
            this.httpRequest.updateUser(this.connectedAccount.userId, updateUser).then(
                () => {
                    this.actualize();
                });


        }
        this.isReadOnly = !this.isReadOnly;
    }

    changeListener($event): void {
        this.readThis($event.target);

    }

    //Supprime une partie inutile de la chaine de caractère de l'image
    decodeBase64(image: any) {
        if (image.includes("data:image/png;base64,")) 
            image = image.replace("data:image/png;base64,", "");
        else if (image.includes("data:image/jpg;base64,"))
            image = image.replace("data:image/jpg;base64,", "");
        else if (image.includes("data:image/jpeg;base64,"))
            image = image.replace("data:image/jpeg;base64,", "");
        
        return image;
    }

    readThis(inputValue: any): void {
        var file: File = inputValue.files[0];
        var myReader: FileReader = new FileReader();

        myReader.onloadend = (e) => {
            this.image = myReader.result;
        }
        if (file != null)
            myReader.readAsDataURL(file);
    }

    //vérifier que le nom, le prénom, le job et la description sont non-vides
    verifyProfile() {
        if ((<HTMLInputElement>document.getElementById("lastName")).value.trim() == "" || (<HTMLInputElement>document.getElementById("firstName")).value.trim() == ""
            || (<HTMLInputElement>document.getElementById("job")).value.trim() == "" || (<HTMLInputElement>document.getElementById("description")).value.trim() == "") {
            this.erreur = "*Tous les champs doivent être remplis";
            alert(this.erreur);
            return false;
        }
        return true;
    }

    //Actualise l'affichage après la modification du profil
    actualize() {
        this.httpRequest.getUserById(this.connectedAccount['userId']).then(
            userData => {
                this.authentificationService.setConnectedAccount(userData as Users);
            }, error => console.log(error)
        );
    }
}