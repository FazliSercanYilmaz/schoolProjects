using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab3Netflix
{
    class DataBase
    {
            public DataBase(string connectionString)
            {
                this.connector = new SqlConnector(connectionString);
            }
       public SqlConnector connector { get; set; }
        public Dictionary<string,object> userAuth(string email,string password)
        {
            var a = this.connector.sqlLoad($"SELECT * from Kullanici WHERE User_Email = \"{email}\" AND User_Password= \"{password}\"");
            if(a.Count ==1)
            {
                return a[0];
            }
            else
            {
                return null;
            }
        }
        public bool userRegister(string name ,string email, string password, string user_Date, string User_Choice)
        {
            var b = this.connector.sqlLoad($"SELECT * from Kullanici WHERE User_Email = \"{email}\"");
            if(b.Count != 0)
            {
                return false;
            }
            var a = this.connector.sqlLoad($"INSERT INTO Kullanici (User_Name,User_Email,User_Password,User_Date,User_Choice)" +
                $"VALUES (\"{name}\",\"{email}\",\"{password}\",\"{user_Date}\",\"{User_Choice}\")");
            if(a == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Dictionary<string, object>> TurLoad()
        {
            return this.connector.sqlLoad("SELECT * from Tur");
        }
        public List<Dictionary<string,object>> kullaniciProgramLoad(string user_id)
        {
            return this.connector.sqlLoad($"select * from KullaniciProgram where UserProgram_User_Id =\"{user_id}\"");
        }
        public List<Dictionary<string,object>> watchLoad()
        {
            return turEkleyici(this.connector.sqlLoad($"SELECT * from Program"));

        }
        public List<Dictionary<string, object>> UserRecommendLoad(string tur_Id)
        {
            return turEkleyici(this.connector.sqlLoad($"SELECT * from Program where Program.Program_Id in (SELECT ProgramTur_Program_Id as Program_Id from ProgramTur where ProgramTur.ProgramTur_Tur_Id =  (SELECT Tur.Tur_Id from Tur where tur.Tur_Id=  \"{tur_Id}\"))"));

        }
        public Dictionary<string, object> OneWatchLoad(string program_id)
        {
            return turEkleyici(this.connector.sqlLoad($"SELECT * from Program WHERE Program_Id = \"{program_id}\" "))[0];

        }
        public List<Dictionary<string,object>> watchSearch(string tur)
        {
            return turEkleyici(this.connector.sqlLoad($"SELECT * from Program where Program.Program_Id in (SELECT ProgramTur_Program_Id as Program_Id from ProgramTur where ProgramTur.ProgramTur_Tur_Id =  (SELECT Tur.Tur_Id from Tur where tur.Tur_Name =  \"{tur}\"))"));
     
        }
        public List<Dictionary<string, object>> watchSearch(string programAdi,string tur)
        {
            return turEkleyici(this.connector.sqlLoad($"select * from Program where Program_Name like \"%{programAdi}%\" and Program_Id in(SELECT ProgramTur_Program_Id as Program_Id FROM ProgramTur where ProgramTur.ProgramTur_Tur_Id =  (SELECT Tur.Tur_Id from Tur where tur.Tur_Name = \"{tur}\"))"));
        }
        public List<Dictionary<string, object>> watchSearchProgramAdi(string programAdi)
        {
            return turEkleyici(this.connector.sqlLoad($"select * from Program where Program_Name like \"%{programAdi}%\""));

        }
        public void userWatchedUpdate(string user_Id ,string program_Id,string watchDate, string watchTime,string kaldigiBolum,string kaldigiSure,int score = 0)
        {
            var a = this.connector.sqlLoad($"SELECT * from KullaniciProgram where UserProgram_User_Id = \"{user_Id}\" and UserProgram_Program_Id = \"{program_Id}\"");
            if(a.Count == 0)
            {
                this.connector.sqlLoad($"INSERT INTO KullaniciProgram (UserProgram_User_Id,UserProgram_Program_Id,UserProgram_IzlemeTarihi,UserProgram_IzlemeSuresi,UserProgrma_KaldigiBolum,UserProgram_KaldigiSure,UserProgram_Puan)" +
                $"VALUES (\"{user_Id}\",\"{program_Id}\",\"{watchDate}\",\"{watchTime}\",\"{kaldigiBolum}\",\"{kaldigiSure}\",\"{score}\")");
            }
            else if(a.Count == 1)
            {
                this.connector.sqlLoad($"UPDATE KullaniciProgram set  UserProgram_User_Id = \"{user_Id}\",UserProgram_Program_Id = \"{program_Id}\",UserProgram_IzlemeTarihi = \"{watchDate}\",UserProgram_IzlemeSuresi = \"{watchTime}\",UserProgrma_KaldigiBolum = \"{kaldigiBolum}\",UserProgram_KaldigiSure = \"{kaldigiSure}\", UserProgram_Puan = \"{score}\" WHERE UserProgram_User_Id = \"{user_Id}\" AND UserProgram_Program_Id = \"{program_Id}\"");
            }
        }
        public List<Dictionary<string, object>> userWatchedLoad(int user_Id)
        {
            return this.connector.sqlLoad($"SELECT * from KullaniciProgram where UserProgram_User_Id = \"{user_Id}\"");
        }
        List<Dictionary<string,object>> turEkleyici(List<Dictionary<string,object>> input)
        {
            string temp = "";
            foreach(var satir in input)
            {
                temp = "";
                var turler = this.connector.sqlLoad($"SELECT Tur_Name from Tur where Tur_Id in (SELECT ProgramTur_Tur_Id as Tur_Id from ProgramTur where ProgramTur_Program_Id = \"{satir["Program_Id"]}\")");
                if (turler.Count != 0)
                {
                   foreach(var tur in turler)
                    {
                        temp += tur["Tur_Name"] + ",";
                    }
                    satir.Add("Program_Turleri", temp);

                }
                else
                {
                    satir.Add("Program_Turleri","");

                }
            }
            return input;
        }
     
    }
}
