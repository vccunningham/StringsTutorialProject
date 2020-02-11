using System;
using System.Collections.Generic;
using System.Text;

namespace StringsTutorialProject {
    class StringsTutorial {


        public string Firstname;
        public string Lastname;

        public StringsTutorial() {
            Firstname = "Vaughn";
            Lastname = "Cunningham";

            }
        public StringsTutorial(string firstname, string lastname) {
            Firstname = firstname;
            Lastname = lastname;
            }
        



        public string Fullname() {
            //var Firstname = "Vaughn";
            //var Lastname = "Cunningham";

            //var fullname = Firstname + " " + Lastname;
            var fullname = $"{Lastname}, {Firstname}";
            return fullname;

            }


        public string Fullname2() {
            //var Firstname = "Vaughn";
            //var Lastname = "Cunningham";

            var fullname = $"{Firstname} {Lastname}";
            return fullname;

            }

        }
    }
