#pragma checksum "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfcffae1304c8fa7f009e1c5f9aa145295b3d000"
// <auto-generated/>
#pragma warning disable 1591
namespace CreationCompte.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using CreationCompte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using CreationCompte.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"leftPos\" id=\"tvCreer\">Créez votre compte</h1>\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "parent");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "div1");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"exampleInputEmail1\">Adresse mail*</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "style", @" background: url('resources/mail.png');
                                background-repeat: no-repeat;
                                background-position: left;
                                background-position-x:5%;
                                background-size: 18px;
                                padding-left:15%;");
            __builder.AddAttribute(13, "type", "email");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "id", "exampleInputEmail1");
            __builder.AddAttribute(16, "aria-describedby", "emailHelp");
            __builder.AddAttribute(17, "placeholder", "Entrer votre email");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          mail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mail = __value, mail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label for=\"exampleInputPassword1\">Mot de passe*</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "style", @" background: url('resources/pass.png');
                                background-repeat: no-repeat;
                                background-position: left;
                                background-position-x:5%;
                                background-size: 18px;
                                padding-left:15%;");
            __builder.AddAttribute(28, "type", "password");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "id", "exampleInputPassword1");
            __builder.AddAttribute(31, "placeholder", "Mot de passe");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          pass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pass = __value, pass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.AddMarkupContent(39, "<label for=\"confirmerMdp\">Confirmer votre mot de passe*</label>\r\n            ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "style", @" background: url('resources/pass.png');
                                background-repeat: no-repeat;
                                background-position: left;
                                background-position-x:5%;
                                background-size: 18px;
                                padding-left:15%;");
            __builder.AddAttribute(42, "type", "password");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "id", "confirmerMdp");
            __builder.AddAttribute(45, "placeholder", "Entrer de nouveau votre mot de passe");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          passConfirm 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => passConfirm  = __value, passConfirm ));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.AddMarkupContent(53, "<label for=\"nom\">Nom*</label>\r\n            ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "id", "nom");
            __builder.AddAttribute(58, "placeholder", "Entrer votre nom");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          nom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nom = __value, nom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.AddMarkupContent(66, "<label for=\"prenom\">Prenom*</label>\r\n            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "id", "prenom");
            __builder.AddAttribute(71, "placeholder", "Entrer votre prenom");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          prenom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => prenom = __value, prenom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "div2");
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group");
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.AddMarkupContent(83, "<label for=\"poste\">Quel poste occupez-vous ?</label>\r\n            ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "class", "form-control");
            __builder.AddAttribute(87, "id", "poste");
            __builder.AddAttribute(88, "placeholder", "Entrer votre poste");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          poste

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => poste = __value, poste));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.AddMarkupContent(96, "<label for=\"dateNaiss\">Date de naissance*</label>\r\n            ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "style", @" background: url('resources/calendar.png');
                                background-repeat: no-repeat;
                                background-position: left;
                                background-position-x:5%;
                                background-size: 18px;
                                padding-left:15%;");
            __builder.AddAttribute(99, "type", "date");
            __builder.AddAttribute(100, "class", "form-control");
            __builder.AddAttribute(101, "id", "dateNaiss");
            __builder.AddAttribute(102, "placeholder", "Entrer votre poste");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                          dateNaiss

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dateNaiss = __value, dateNaiss, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n        ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "form-group");
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.AddMarkupContent(110, "<label for=\"exampleFormControlTextarea1\">Décrivez-vous en quelques mots*</label>\r\n            ");
            __builder.OpenElement(111, "textarea");
            __builder.AddAttribute(112, "class", "form-control");
            __builder.AddAttribute(113, "id", "exampleFormControlTextarea1");
            __builder.AddAttribute(114, "rows", "3");
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                             desc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => desc = __value, desc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n        ");
            __builder.OpenElement(119, "button");
            __builder.AddAttribute(120, "class", "btn btn-primary");
            __builder.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                                                   traiterDemande

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(122, "Créer mon compte");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 79 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
         foreach (var warn in warns)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, "            ");
            __builder.OpenElement(125, "p");
            __builder.AddAttribute(126, "class", "alert alert-danger");
            __builder.AddAttribute(127, "role", "alert");
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.AddContent(129, 
#nullable restore
#line 82 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
                 warn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 84 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n\r\n    ");
            __builder.OpenElement(134, "p");
            __builder.AddAttribute(135, "class", "alert alert-success");
            __builder.AddAttribute(136, "role", "alert");
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.AddContent(138, 
#nullable restore
#line 88 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
         sortie

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(139, ";\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\Cours\ProjetLicense\LP_Proj_ESC\CreationCompte\CreationCompte\Pages\Index.razor"
      

    private string mail = "";
    private string pass = "";
    private string passConfirm = "";
    private string nom = "";
    private string prenom = "";
    private string poste = "";
    private DateTime dateNaiss = new DateTime();
    private string desc = "";
    private string sortie = "";
    private IList<String> warns = new List<String>();


    public void traiterDemande()
    {
        warns.Clear();
        verifNull();
        verifMail();
        verifPass();

        if (warns.Count == 0)
        {

            //string output = "0," + mail + ","+ pass + "," + "d," + dateNaiss + "," + desc + "," + prenom + "," + nom;

            var user = new{
                UserId = 0,
                Email = mail,
                Password = pass,
                Salt = "d",
                BirthDate = dateNaiss,
                Description = desc,
                FirstName = prenom,
                LastName = nom
            };

            string output = JsonConvert.SerializeObject(user);
            //var output = new StringContent(user.ToString());
            warns.Add(output.ToString());
            createUser(output);
        }

    }

    private async Task createUser(string jsonUser)
    {
       
        await Http.PostJsonAsync("https://localhost:44329/api/Users", jsonUser);
    }


    public void verifNull()
    {
        if (desc.Trim().Equals("") ||
            mail.Trim().Equals("") ||
            pass.Trim().Equals("") ||
            passConfirm.Trim().Equals("") ||
            nom.Trim().Equals("") ||
            prenom.Trim().Equals("") ||
            dateNaiss.ToString().Trim().Equals(""))
        {
            warns.Add("Tous les champs sont obligatoires");
        }
    }

    public void verifMail()
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(mail);
        if (!match.Success || match == null)
        {
            warns.Add("Le mail " + mail + " est incorrect");
        }
    }

    public void verifPass()
    {
        if (pass.Trim().Length < 5 || pass == null)
        {
            warns.Add("Mot de passe trop court de " + (5 - pass.Trim().Length));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
