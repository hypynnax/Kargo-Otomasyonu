using System;
using System.Collections.Generic;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace CargoAutomation {
    class Database {

        private IFirebaseConfig config;
        public IFirebaseClient client;
        public FirebaseResponse response;

        public Database() {
            config = new FirebaseConfig {
                AuthSecret = "B3L5ZvfWQmbWQe9X2ikMImhdWf9rkK3UfYOnXwUZ",
                BasePath = "https://kargo-otomasyonu-d8afc-default-rtdb.europe-west1.firebasedatabase.app/" };
            client = new FireSharp.FirebaseClient(config);
        }

        public async void veriAl() {
            try {
                response = await client.GetAsync("Analiz");
                Dictionary<string, Analiz> data = JsonConvert.DeserializeObject<Dictionary<string, Analiz>>(response.Body);
                Program.admSys = data["Veriler"].admSys;
                Program.prsSys = data["Veriler"].prsSys;
                Program.ueSys = data["Veriler"].ueSys;
                Program.sbSys = data["Veriler"].sbSys;
                Program.tmmlnkrgSys = data["Veriler"].tmmlnkrgSys;
                Program.aktfKrgSys = data["Veriler"].aktfKrgSys;
            }catch (Exception e) { }
        }

        public async void veriKayitEt() {
            Analiz analiz = new Analiz() {
                admSys = Program.admSys,
                prsSys = Program.prsSys,
                ueSys = Program.ueSys,
                sbSys = Program.sbSys,
                tmmlnkrgSys = Program.tmmlnkrgSys,
                aktfKrgSys = Program.aktfKrgSys };
            try {
                response = await client.UpdateAsync("Analiz/Veriler", analiz);
            }catch (Exception e) { }
        }
    }
}
