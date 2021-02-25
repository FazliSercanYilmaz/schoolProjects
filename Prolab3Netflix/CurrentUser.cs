using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab3Netflix
{
    class CurrentUser
    {
       public CurrentUser(Dictionary<string,object> user)
        {
            this.user = user;
            this.userProgram = Program.netflix.kullaniciProgramLoad(user["User_Id"].ToString());
        }
       public Dictionary<string, object> user { get; set; }
        List<Dictionary<string, object>> userProgram { get; set; }
        public List<Dictionary<string, object>> userProgramGet()
        {
            this.userProgram = Program.netflix.kullaniciProgramLoad(user["User_Id"].ToString());
            return this.userProgram;
        } 
        public Dictionary<string,object> selectedUserProgramGet(string program_id)
        {
            this.userProgram = Program.netflix.kullaniciProgramLoad(user["User_Id"].ToString());

            foreach (var program in userProgram)
            {
                if(program["UserProgram_Program_Id"].ToString() == program_id)
                {
                    return program;
                }
            }
            return null;
        }
        public List<Dictionary<string,object>> UserRecommendPrograms()
        {
            List<Dictionary<string, object>> anaList = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> templist;
            string[] selectedTurIds = user["User_Choice"].ToString().Split(',');
            foreach(var turId in selectedTurIds)
            {
                templist = Program.netflix.UserRecommendLoad(turId);
                for(int index = 0;index<templist.Count;index++)
                {
                    if (analistIndexOf(anaList, templist[index]["Program_Id"].ToString()) != -1)
                    {
                        templist.Remove(templist[index]);
                        index = 0;
                    }
                }
                Dictionary<string, object>  tut;
                for (int gecici = 1; gecici < templist.Count; gecici++)
                {
                    for (int i = 0; i < templist.Count - 1; i++)
                    {
                        if (Convert.ToDouble(templist[i]["Program_Score"]) > Convert.ToDouble(templist[i+1]["Program_Score"]))
                        {
                            tut = templist[i];
                            templist[i] = templist[i + 1];
                            templist[i + 1] = tut;
                        }
                    }
                }
                int count = 0;
                if (templist.Count > 0)
                {
                    for (int sayac = templist.Count - 1; sayac >= 0; sayac--)
                    {
                        anaList.Add(templist[sayac]);
                        count++;
                        if (count == 2)
                        {
                            break;
                        }
                    }
                }
            }
            return anaList;

        }
        private int analistIndexOf(List<Dictionary<string, object>> analist,string program_Id)
        {
            int count = 0;
           foreach(var a in analist)
            {
                if (a["Program_Id"].ToString() == program_Id)
                    return count;
                count++;
            }
            return -1;
        }
    }
}
