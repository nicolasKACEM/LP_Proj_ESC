﻿import { Component, OnInit } from '@angular/core';
import { Users } from '../Model/Users';
import { FormControl, FormGroup, Validators, ValidationErrors, FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { AuthentificationService } from '../services/authentification.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
    selector: 'app-create-account',
    templateUrl: './create-account.component.html',
    styleUrls: ['./create-account.component.css'],
})
export class CreateAccountComponent implements OnInit {
    public image: any;
    errorCreate = false;
    error = false;
    public user: Users;
    submitted = false;

    public emailTaken: any;

    profil: FormGroup;
    defaultImagePath: any = "assets/img/accountIcon.png";
    defaultImage: any;

    constructor(private service: HttpClient, private router: Router, private formBuilder: FormBuilder, private authentificationService: AuthentificationService) {

    }

    ngOnInit() {
        this.profil = this.formBuilder.group({
            lastName: new FormControl('', [Validators.required]),
            firstName: new FormControl('', [Validators.required]),
            pass: new FormControl('', [
                Validators.required,
                Validators.minLength(6)]),
            confirmPass: new FormControl('', [Validators.required]),
            email: new FormControl('', [
                Validators.required,
                Validators.pattern("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$")]),
            description: new FormControl(''),
            birthDate: new FormControl('', [Validators.required]),
            job: new FormControl(''),
            avatar: new FormControl('')
        });
    }

    get verifEmail() {
        return this.profil.get('email');
    }

    get verifPassword() {
        return this.profil.get('pass');
    }

    get verifConfirmPassword() {
        return this.profil.get('confirmPass');
    }

    verifPasswordMatch() {
        if (this.profil.get('pass').value != this.profil.get('confirmPass').value && this.profil.get('confirmPass').value != "")
            return false;
        else
            return true;

    }
    get verifLastName() {
        return this.profil.get('lastName');
    }

    get verifFirstName() {
        return this.profil.get('firstName');
    }

    get verifDescription() {
        return this.profil.get('description');
    }

    get verifBirthDate() {
        return this.profil.get('birthDate');
    }

    get verifAvatar() {
        return this.profil.get('avatar');
    }

    verifValidBirthDate() {
        var currentDate = new Date().getTime();
        var dateToCheck = new Date(this.profil.get('birthDate').value);
        if (dateToCheck.getTime() > currentDate)
            return false;
        return true;
    }

    displayImage($event) {
        this.readThis($event.target);
    }

    readThis(inputValue: any): void {
        var file: File = inputValue.files[0];
        var myReader: FileReader = new FileReader();

        myReader.onloadend = (e) => {
            this.image = myReader.result;
            this.image = this.decodeBase64(this.image);
            this.submitted = true;
        }
        if (file != null)
            myReader.readAsDataURL(file);
    }

    decodeBase64(image: any) {
        if (image.includes("data:image/png;base64,"))
            image = image.replace("data:image/png;base64,", "");
        else if (image.includes("data:image/jpg;base64,"))
            image = image.replace("data:image/jpg;base64,", "");
        else if (image.includes("data:image/jpeg;base64,"))
            image = image.replace("data:image/jpeg;base64,", "");

        return image;
    }

    getFormValidationErrors() {
        let error: boolean = false;
        Object.keys(this.profil.controls).forEach(key => {

            const controlErrors: ValidationErrors = this.profil.get(key).errors;
            if (controlErrors != null) {
                Object.keys(controlErrors).forEach(keyError => {
                    if (controlErrors[keyError])
                        error = true;
                });
            }
        });
        if (error)
            return false;
        else
            return true;
    }

    /*
     * Vérifie que l'utilisateur prêt à être créé utilise un email pour la première fois
     * @return : true si un email dans la liste des utilisateurs est identique, sinon false
    */
    emailAlreadyTakenVerification() {
        this.emailTaken = new Promise((resolve, reject) => {
            let dejaPris: boolean = false;
            //récupèrer la liste des utilisateurs existants
            this.service.get(window.location.origin + "/api/Users/").subscribe(usersResult => {
                let usersList: Users[] = usersResult as Users[];
                //si il n'y a pas d'user dans la BDD
                if (usersList.length == 0) {
                    this.error = false;
                    resolve(dejaPris);
                }
                else {
                    //boucle for qui fait reject si l'email est déjà utilisé
                    for (let i = 0; i < usersList.length; i++) {
                        if (this.profil.get('email').value == usersList[i]['email']) {
                            dejaPris = true;
                            this.error = true;
                            reject(new Error('fail'));
                        }
                        if (i == usersList.length - 1 && !dejaPris) {
                            this.error = false;
                            resolve(dejaPris);
                        }
                    }
                }
            }, error => console.error(error));
        });
    }

    checkMail() {
        this.emailAlreadyTakenVerification();
        this.emailTaken.then((dejaPris) => {
            if (!dejaPris)
                this.createAccount();
        }, (fail) => console.log(fail))
    }

    createAccount() {
        //Vérifier que les entrées soient bonnes, s'il n'y a pas d'erreur, alors vérif du mail puis POST
        const form = this.profil.value;

        if (this.getFormValidationErrors()) {
            this.errorCreate = false;
            if (!this.submitted)
                this.image = this.defaultImage;
            if (!this.error) {
                this.service.post(window.location.origin + "/api/Users", {
                    "Email": form["email"],
                    "Password": form["pass"],
                    "Salt": "Le salt se fera après",
                    "BirthDate": form["birthDate"],
                    "Description": form["description"],
                    "FirstName": form["firstName"],
                    "LastName": form["lastName"],
                    "Job": form["job"],
                    "Avatar": this.image
                }).subscribe(() => {
                    alert("Le compte a bien été crée.");
                    this.connect(form["email"], form["pass"]);
                    this.router.navigate(['home/']);
                }, error => console.log(error));
            }
        } else
            this.errorCreate = true;
    }

    connect(email: string, password: string) {
        this.authentificationService.connect(email, password);
    }

    getDefaultImage() {
        this.service.get(this.defaultImagePath, { responseType: 'blob' }).subscribe(res => {
            const reader = new FileReader();
            reader.onloadend = () => {
                var base64data = reader.result;
                this.defaultImage = this.decodeBase64(base64data);
            }
            reader.readAsDataURL(res);
        });
    }
}



